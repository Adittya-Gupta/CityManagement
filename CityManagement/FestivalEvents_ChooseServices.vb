Imports CityManagement.Event_OfferService
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient


Public Class FestivalEvents_ChooseServices
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim vendorServiceTags As List(Of VendorServiceTag)
    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged
        Dim checkbox = DirectCast(sender, CheckBox)

        Select Case checkbox.Name
            Case "CheckBox1"
                ToggleVisibility(checkbox.Checked, Button1, Label1, Label6)
                ToggleIsRequired(checkbox.Checked, 0)
            Case "CheckBox2"
                ToggleVisibility(checkbox.Checked, Button2, Label2, Label9)
                ToggleIsRequired(checkbox.Checked, 1)
            Case "CheckBox3"
                ToggleVisibility(checkbox.Checked, Button3, Label5, Label10)
                ToggleIsRequired(checkbox.Checked, 2)
            Case "CheckBox4"
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
        Label6.Text = If(vendorServiceTags(0).ApprovedVendorSID Is Nothing, "Not selected", vendorServiceTags(0).ApprovedVendorSID)
        Label9.Text = If(vendorServiceTags(1).ApprovedVendorSID Is Nothing, "Not selected", vendorServiceTags(1).ApprovedVendorSID)
        Label10.Text = If(vendorServiceTags(2).ApprovedVendorSID Is Nothing, "Not selected", vendorServiceTags(2).ApprovedVendorSID)
        Label8.Text = If(vendorServiceTags(3).ApprovedVendorSID Is Nothing, "Not selected", vendorServiceTags(3).ApprovedVendorSID)
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        Dim btn = DirectCast(sender, Button)
        Dim currentIndex As Integer = -1

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

        ' Check if the currentIndex is valid
        If currentIndex >= 0 AndAlso currentIndex < vendorServiceTags.Count Then
            ' Open the FestivalEvents_ChooseVendor form with the vendorServiceTags and currentIndex as parameters
            Dim chooseVendorForm As New FestivalEvents_ChooseVendor(vendorServiceTags, currentIndex)
            Dim result As DialogResult = chooseVendorForm.ShowDialog() ' Show the form as a dialog

            ' Check the result from the FestivalEvents_ChooseVendor form
            If result = DialogResult.OK Then
                ' Update the vendorServiceTags list
                ' You can access the updated vendorServiceTags list using chooseVendorForm.vendorServiceTags
                ' Proceed with any further actions here
                vendorServiceTags = chooseVendorForm.vendorServiceTags
                updatePage(vendorServiceTags)

            End If
        Else
            MessageBox.Show("Invalid index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Serialize the vendorServiceTags list back to JSON format
        Dim updatedServiceTags As String = Newtonsoft.Json.JsonConvert.SerializeObject(vendorServiceTags)

        ' Update the database with the updated vendor service tags
        Try
            conn.Open()
            Dim query As String = "UPDATE festivals SET vendor_service_tags = @ServiceTags WHERE name = @CurrEvent"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ServiceTags", updatedServiceTags)
                cmd.Parameters.AddWithValue("@CurrEvent", Module1.CurrEvent)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show("Database updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class