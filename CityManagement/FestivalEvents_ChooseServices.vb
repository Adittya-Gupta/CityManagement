Imports CityManagement.FestivalEvents_Offer_Service2
Imports MySql.Data.MySqlClient


Public Class FestivalEvents_ChooseServices
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Dim vendorServiceTags As List(Of VendorServiceTag)
    Dim currentIndex = -1
    Private selectedVendorButton As Button
    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged
        Dim checkbox = DirectCast(sender, CheckBox)

        Select Case checkbox.Name
            Case "CheckBox1"
                If currentIndex = 0 AndAlso Not checkbox.Checked Then
                    Panel6.Controls.Clear()
                End If
                ToggleVisibility(checkbox.Checked, Button1, Label1, Label6)
                ToggleIsRequired(checkbox.Checked, 0)
            Case "CheckBox2"
                If currentIndex = 1 AndAlso Not checkbox.Checked Then
                    Panel6.Controls.Clear()
                End If
                ToggleVisibility(checkbox.Checked, Button2, Label2, Label9)
                ToggleIsRequired(checkbox.Checked, 1)
            Case "CheckBox3"
                If currentIndex = 2 AndAlso Not checkbox.Checked Then
                    Panel6.Controls.Clear()
                End If
                ToggleVisibility(checkbox.Checked, Button3, Label5, Label10)
                ToggleIsRequired(checkbox.Checked, 2)
            Case "CheckBox4"
                If currentIndex = 3 AndAlso Not checkbox.Checked Then
                    Panel6.Controls.Clear()
                End If
                ToggleVisibility(checkbox.Checked, Button4, Label4, Label8)
                ToggleIsRequired(checkbox.Checked, 3)
        End Select
    End Sub
    Private Sub ToggleIsRequired(isRequired As Boolean, index As Integer)
        If vendorServiceTags IsNot Nothing AndAlso index >= 0 AndAlso index < vendorServiceTags.Count Then
            vendorServiceTags(index).IsRequired = isRequired
        End If
    End Sub
    Private Sub ToggleVisibility(visible As Boolean, ParamArray controls As Control())
        For Each ctrl As Control In controls
            ctrl.Visible = visible
        Next
    End Sub

    Private Sub FestivalEvents_ChooseServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide all controls initially
        Panel1.AutoScroll = True
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM festivals WHERE name = @CurrEvent "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CurrEvent", Module1.CurrEvent)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                reader.Read()
                Dim serviceTags As String = If(Not IsDBNull(reader("vendor_service_tags")), reader("vendor_service_tags").ToString(), "{}")
                serviceTags = serviceTags.ToString()
                vendorServiceTags = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of VendorServiceTag))(serviceTags)
                updatePage(vendorServiceTags)


            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        CheckBox_CheckedChanged(CheckBox1, Nothing)
        CheckBox_CheckedChanged(CheckBox2, Nothing)
        CheckBox_CheckedChanged(CheckBox3, Nothing)
        CheckBox_CheckedChanged(CheckBox4, Nothing)
        'ToggleVisibility(False, Button1, Button2, Button3, Button4, Label1, Label2, Label4, Label5, Label6, Label8, Label9, Label10)
    End Sub

    Private Sub updatePage(vendorServiceTags As List(Of VendorServiceTag))
        CheckBox1.Checked = vendorServiceTags(0).IsRequired
        CheckBox2.Checked = vendorServiceTags(1).IsRequired
        CheckBox3.Checked = vendorServiceTags(2).IsRequired
        CheckBox4.Checked = vendorServiceTags(3).IsRequired
        CheckBox1.Text = vendorServiceTags(0).TagServiceName
        CheckBox2.Text = vendorServiceTags(1).TagServiceName
        CheckBox3.Text = vendorServiceTags(2).TagServiceName
        CheckBox4.Text = vendorServiceTags(3).TagServiceName
        Button1.Tag = vendorServiceTags(0)
        Button2.Tag = vendorServiceTags(1)
        Button3.Tag = vendorServiceTags(2)
        Button4.Tag = vendorServiceTags(3)
        Label6.Text = If(vendorServiceTags(0).ApprovedVendorSID Is Nothing, "Not selected", GetVendorName(vendorServiceTags(0).ApprovedVendorSID))
        Label9.Text = If(vendorServiceTags(1).ApprovedVendorSID Is Nothing, "Not selected", GetVendorName(vendorServiceTags(1).ApprovedVendorSID))
        Label10.Text = If(vendorServiceTags(2).ApprovedVendorSID Is Nothing, "Not selected", GetVendorName(vendorServiceTags(2).ApprovedVendorSID))
        Label8.Text = If(vendorServiceTags(3).ApprovedVendorSID Is Nothing, "Not selected", GetVendorName(vendorServiceTags(3).ApprovedVendorSID))
    End Sub
    Public Function GetVendorName(ByVal SID As Integer) As String
        Dim vendorName As String = ""

        ' Ensure the connection is closed before attempting to open it again
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        ' Open the connection
        Try
            conn.Open()
            Dim query = "SELECT Name FROM User WHERE SID = @sid"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@sid", SID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    vendorName = reader("Name").ToString()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection after use
            conn.Close()
        End Try

        Return vendorName
    End Function


    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        Dim btn = DirectCast(sender, Button)


        ' Determine the current index based on the clicked button
        Select Case btn.Name
            Case "Button1"
                currentIndex = 0
            Case "Button2"
                currentIndex = 1
            Case "Button3"
                currentIndex = 2
            Case "Button4"
                currentIndex = 3
        End Select
        Panel6.Controls.Clear()
        Label11.Text = vendorServiceTags(currentIndex).TagServiceName
        Dim yPos As Integer = 0
        For Each vendor In vendorServiceTags(currentIndex).ListofVendorSIDs
            Dim lblVendor As New Label()
            lblVendor.Text = GetVendorName(vendor)
            lblVendor.BackColor = Color.Transparent
            lblVendor.Font = New Font(FontFamily.GenericSansSerif, 12)
            lblVendor.AutoSize = True
            lblVendor.Location = New Point(10, yPos)

            Dim selectButton As New Button()
            selectButton.Text = "Select"
            selectButton.AutoSize = True
            selectButton.Location = New Point(lblVendor.Right + 70, yPos)
            selectButton.FlatStyle = FlatStyle.Flat ' Remove the border
            selectButton.Tag = vendor ' Set the vendor name as the Tag of the button
            selectButton.BackColor = Color.Black ' Set background color to blue
            selectButton.ForeColor = Color.White ' Set foreground color to white

            AddHandler selectButton.Click, Sub(senderClicked As Object, eClicked As EventArgs)
                                               SelectButton_Click(senderClicked, eClicked, currentIndex)
                                           End Sub

            Panel6.Controls.Add(lblVendor)
            Panel6.Controls.Add(selectButton)

            yPos += lblVendor.Height + 20
        Next

    End Sub

    Private Sub SelectButton_Click(sender As Object, e As EventArgs, currentIndex As Integer)
        Dim clickedButton As Button = DirectCast(sender, Button)
        If clickedButton.Enabled = False Then
            Return
        End If
        If selectedVendorButton IsNot Nothing Then
            selectedVendorButton.Enabled = True
        End If
        clickedButton.Enabled = False
        selectedVendorButton = clickedButton
        vendorServiceTags(currentIndex).ApprovedVendorSID = clickedButton.Tag.ToString()
        updatePage(vendorServiceTags)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Serialize the vendorServiceTags list back to JSON format
        Dim updatedServiceTags = Newtonsoft.Json.JsonConvert.SerializeObject(vendorServiceTags)

        ' Update the database with the updated vendor service tags
        Try
            conn.Open()
            Dim query = "UPDATE festivals SET vendor_service_tags = @ServiceTags WHERE name = @CurrEvent"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ServiceTags", updatedServiceTags)
                cmd.Parameters.AddWithValue("@CurrEvent", CurrEvent)
                Dim rowsAffected = cmd.ExecuteNonQuery
                MessageBox.Show("Database updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim form As New FestivalEvents_EventDetails
        form.TopLevel = False
        mypanel.Panel1.Controls.Clear()
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class