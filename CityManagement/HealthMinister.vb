Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO

Public Class HealthMinister

    Private isPendingView As Boolean = False ' Flag to track if pending view is active

    Private Sub HealthMinister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMinisterRequests()
    End Sub

    Private Sub LoadMinisterRequests()
        ' Establish connection to the database
        'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Dim connString As String = Module1.connString
        Dim conn As New MySqlConnection(connString)

        Try
            ' Open the database connection
            conn.Open()

            ' Create a MySqlCommand object to execute SQL queries
            Dim cmd As New MySqlCommand()

            ' Set the command text to retrieve data from minister_req and User tables based on status
            Dim statusFilter As String = If(isPendingView, "1 OR mr.Status = -1", "0")
            cmd.CommandText = "SELECT mr.SID, u.Name, u.ProfilePic, mr.Date, mr.details, mr.Status FROM minister_req mr JOIN User u ON mr.SID = u.SID WHERE mr.Ministry = 'Health' AND mr.Status = " & statusFilter

            ' Set the connection for the command
            cmd.Connection = conn

            ' Execute the command and retrieve the data
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing controls in Panel1
            Panel1.Controls.Clear()

            ' Create a FlowLayoutPanel to hold the min_req controls
            Dim flowLayoutPanel As New FlowLayoutPanel()
            flowLayoutPanel.Dock = DockStyle.Fill
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown

            ' Set AutoScroll property of FlowLayoutPanel to True to enable vertical scrolling
            flowLayoutPanel.AutoScroll = True

            ' Set WrapContents property to False to ensure vertical arrangement
            flowLayoutPanel.WrapContents = False

            ' Add the FlowLayoutPanel to Panel1
            Panel1.Controls.Add(flowLayoutPanel)

            ' Iterate through the rows returned by the query
            While reader.Read()
                ' Create a new instance of min_req user control
                Dim minReqControl As New min_req

                ' Populate the min_req control with data from the reader
                minReqControl.lbldateTime.Text = reader("Date").ToString()
                minReqControl.lblName.Text = reader("Name").ToString()

                ' Convert ProfilePic from byte array to Image and assign to PictureBox
                Dim imageData As Byte() = If(reader("ProfilePic") Is DBNull.Value, Nothing, DirectCast(reader("ProfilePic"), Byte()))
                If imageData IsNot Nothing Then
                    Using ms As New MemoryStream(imageData)
                        minReqControl.pbProfile.SizeMode = PictureBoxSizeMode.StretchImage
                        minReqControl.pbProfile.Image = Image.FromStream(ms)
                    End Using
                End If

                ' Store SID in Tag property of min_req control for reference
                minReqControl.Tag = reader("SID")

                ' Attach event handlers for lblDetails, lblAccept, and lblReject
                AddHandler minReqControl.lblDetails.Click, AddressOf lblDetails_Click
                AddHandler minReqControl.lblAccept.Click, AddressOf lblAccept_Click
                AddHandler minReqControl.lblReject.Click, AddressOf lblReject_Click
                Dim status As Integer = Convert.ToInt32(reader("Status"))
                Select Case status
                    Case 0
                        minReqControl.lblAccrej.Text = "Pending"
                    Case 1
                        minReqControl.lblAccrej.Text = "Approved"
                    Case -1
                        minReqControl.lblAccrej.Text = "Rejected"
                End Select
                ' Add the min_req control to the FlowLayoutPanel
                flowLayoutPanel.Controls.Add(minReqControl)
            End While

            ' Close the reader
            reader.Close()

        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub

    Private Sub lblDetails_Click(sender As Object, e As EventArgs)
        ' Handle lblDetails click event
        Dim minReqControl As min_req = DirectCast(sender.Parent, min_req)

        ' Extract SID from Tag property
        Dim SID As Integer = Convert.ToInt32(minReqControl.Tag)

        ' Retrieve details from the database for the given SID
        Dim connString As String = Module1.connString
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT details FROM minister_req WHERE SID = @SID", conn)
                cmd.Parameters.AddWithValue("@SID", SID)
                Dim details As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
                If details IsNot Nothing Then
                    ' Generate a unique temporary file name with .pdf extension in the temp folder
                    Dim tempPdfFilePath As String = Path.Combine(Application.StartupPath, "..\..\..\MediaFiles", Guid.NewGuid().ToString() & ".pdf")

                    ' Write the binary data to the temporary PDF file
                    File.WriteAllBytes(tempPdfFilePath, details)
                    MessageBox.Show("PDF downloaded in  " & tempPdfFilePath)

                Else
                    MessageBox.Show("Details not found for SID: " & SID)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        ' Reload the minister requests after processing the click event
        LoadMinisterRequests()
    End Sub

    Private Sub lblAccept_Click(sender As Object, e As EventArgs)
        ' Handle lblAccept click event
        Dim minReqControl As min_req = DirectCast(sender.Parent, min_req)

        ' Extract SID from Tag property
        Dim SID As Integer = Convert.ToInt32(minReqControl.Tag)

        ' Update the Status column to 1 in the minister_req table for the given SID
        UpdateStatus(SID, 1)

        ' Reload the minister requests after processing the click event
        LoadMinisterRequests()
    End Sub

    Private Sub lblReject_Click(sender As Object, e As EventArgs)
        ' Handle lblReject click event
        Dim minReqControl As min_req = DirectCast(sender.Parent, min_req)

        ' Extract SID from Tag property
        Dim SID As Integer = Convert.ToInt32(minReqControl.Tag)

        ' Update the Status column to -1 in the minister_req table for the given SID
        UpdateStatus(SID, -1)

        ' Reload the minister requests after processing the click event
        LoadMinisterRequests()
    End Sub


    Private Sub UpdateStatus(SID As Integer, status As Integer)
        ' Update the Status column in the minister_req table for the given SID
        Dim connString As String = Module1.connString
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE minister_req SET Status = @Status WHERE SID = @SID", conn)
                cmd.Parameters.AddWithValue("@SID", SID)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Status updated successfully for SID: " & SID)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Toggle between pending and approved views
        isPendingView = Not isPendingView
        Label1.Text = If(isPendingView, "Pending", "Approved")
        LoadMinisterRequests()
    End Sub
End Class
