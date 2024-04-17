Imports MySql.Data.MySqlClient
Imports System.IO
Imports GemBox.Pdf
Imports GemBox.Pdf.Content
Public Class transport_busbooking
    Private _busId As String
    Private _from As String
    Private _endpoint As String
    Private _tottime As Integer
    Public Property BusId As String
        Get
            Return _busId
        End Get
        Set(value As String)
            _busId = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property
    Public Property StartPoint As String
        Get
            Return _from
        End Get
        Set(value As String)
            _from = value
            Label16.Text = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    Public Property EndPoint As String
        Get
            Return _endpoint
        End Get
        Set(value As String)
            _endpoint = value
            Label17.Text = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    Public Property totTime As String
        Get
            Return _tottime
        End Get
        Set(value As String)
            _tottime = value
            Label25.Text = value + "min"
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    Dim connString As String = Globals.connectionstring
    Dim conn As New MySqlConnection(connString)
    Private Sub transport_busbooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim busIdToRetrieve = _busId
            RetrieveBusInfo(busIdToRetrieve)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub RetrieveBusInfo(busId As Integer)
        Dim query As String = "SELECT * FROM bus WHERE bus_id = @busId"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@busId", busId)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' Retrieve bus information
                Dim driverName As String = reader.GetString("driver_name")
                Dim driverNumber As String = reader.GetString("driver_numner")
                Dim girlsSeat As Integer = reader.GetInt32("girls_seat")
                Dim boysSeat As Integer = reader.GetInt32("boys_seat")
                Dim girlsPrice As Double = reader.GetDouble("girls_price") * totTime
                Dim boysPrice As Double = reader.GetDouble("boys_price") * totTime
                Dim pathId As Integer = reader.GetInt32("path_id")
                Label28.Text = driverName
                Label29.Text = driverNumber
                Label18.Text = girlsSeat
                Label19.Text = boysSeat
                Label20.Text = girlsPrice
                Label21.Text = boysPrice
                reader.Close()
            Else
                MessageBox.Show("Bus not found with ID: " & busId)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function RetrieveFromAndEndPt(pathId As Integer) As Tuple(Of String, String)
        Dim fromPt As String = ""
        Dim endPt As String = ""
        Dim query As String = "SELECT p.from_pt, p.end_pt FROM path p WHERE p.path_id = @pathId"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@pathId", pathId)

        Try
            Dim reader1 As MySqlDataReader = cmd.ExecuteReader()
            If reader1.Read() Then
                fromPt = reader1.GetString("from_pt")
                endPt = reader1.GetString("end_pt")
            End If
            reader1.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return New Tuple(Of String, String)(fromPt, endPt)
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label22.Text = TextBox7.Text * Label20.Text + TextBox8.Text * Label21.Text
        Label24.Text = Label22.Text
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim busResultsForm As New transport_busSearch
        mypanel.panel1.Controls.Clear()
        busResultsForm.TopLevel = False
        mypanel.panel1.Controls.Add(busResultsForm)
        busResultsForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrWhiteSpace(TextBox9.Text) OrElse String.IsNullOrWhiteSpace(TextBox10.Text) Then
            MessageBox.Show("Please enter your phone number and email address.")
            Return
        End If

        If Global_Attributes.banking_payment_done = 0 Then
            MessageBox.Show("Make Payment First")
            Return
        End If


        ComponentInfo.SetLicense("FREE-LIMITED-KEY")

        Dim document = New PdfDocument
        Dim margin As Double = 10

        ' Add a page.
        Dim page = document.Pages.Add

        ' Generate the ticket name with the current time.
        Dim ticketName = "Tickets" & Date.Now.ToString("yyyyMMddHHmmss")

        Dim ticketContent = $"Bus Ticket
-----------------------------------------
From: {_from}
To: {_endpoint}
Date: {Date.Now.ToString("dd/MM/yyyy")}
Time: {Date.Now.ToString("HH:mm")}
-----------------------------------------
Driver: {Label28.Text}
Driver Number: {Label29.Text}
-----------------------------------------
Girls Seat Booked: {TextBox7.Text}
Boys Seat Booked: {TextBox8.Text}
-----------------------------------------
Total Price: Rs. {Label22.Text}
-----------------------------------------
Your Phone Number: {TextBox9.Text}
Your Email Address: {TextBox10.Text}
-----------------------------------------
Thank you for choosing our service!"
        ' Write the ticket name on the PDF.
        Using formattedText = New PdfFormattedText
            formattedText.TextAlignment = PdfTextAlignment.Center
            formattedText.MaxTextWidth = 200
            formattedText.Append(ticketContent)
            page.Content.DrawText(formattedText,
                    New PdfPoint((page.CropBox.Width - formattedText.MaxTextWidth) / 2,
                        page.CropBox.Top - margin - formattedText.Height))

            formattedText.Clear()

        End Using

        ' Specify the path where you want to save the PDF file.
        Dim myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim filePath = Path.Combine(myDocumentsPath, ticketName & ".pdf")

        ' Save the PDF document to the specified path.
        document.Save(filePath)

        ' Close the PDF document.
        document.Close()

        MessageBox.Show("PDF file Downloaded! Check your MyDocuments for the Pdf file")

        Global_Attributes.banking_payment_done = 0

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If String.IsNullOrWhiteSpace(TextBox9.Text) OrElse String.IsNullOrWhiteSpace(TextBox10.Text) Then
            MessageBox.Show("Please enter your phone number and email address.")
            Return
        End If

        banking_recv_username = "transport"
        banking_recv_name = "transport"
        Go_Back = 2
        Go_Back_Form = Me
        banking_payment_amount = Label22.Text

        Banking_Main.Panel1.Controls.Clear()
        Newsletter_Main.Panel1.Controls.Clear()

        ChildForm(Banking_Main.Panel1, Banking_Homepage)
        mypanel.panel1.Controls.Clear()
        ChildForm2(Banking_Main)

    End Sub
    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Public Shared Sub ChildForm2(ByVal childform As Form)
        mypanel.panel1.Controls.Clear()
        childform.TopLevel = False
        mypanel.panel1.Controls.Add(childform)
        childform.Show()
    End Sub
End Class