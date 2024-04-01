Imports CityManagement.Event_OfferService
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient


Public Class FestivalEvents_ChooseServices
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim vendorServiceTags As List(Of VendorServiceTag)
    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Dim checkbox = DirectCast(sender, CheckBox)

        Select Case checkbox.Name
            Case "CheckBox1"
                ToggleVisibility(checkbox.Checked, Button1, Label1, Label6)
            Case "CheckBox2"
                ToggleVisibility(checkbox.Checked, Button2, Label2, Label9)
            Case "CheckBox3"
                ToggleVisibility(checkbox.Checked, Button3, Label5, Label10)
            Case "CheckBox4"
                ToggleVisibility(checkbox.Checked, Button4, Label4, Label8)
        End Select
    End Sub

    Private Sub ToggleVisibility(visible As Boolean, ParamArray controls As Control())
        For Each ctrl As Control In controls
            ctrl.Visible = visible
        Next
    End Sub

    Private Sub FestivalEvents_ChooseServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide all controls initially
        Panel1.AutoScroll = True

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM festivals WHERE id = @CurrEventId "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CurrEventId", Module1.CurrEventID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                reader.Read()
                Dim serviceTags As String = If(Not IsDBNull(reader("vendor_service_tags")), reader("vendor_service_tags").ToString(), "{}")
                serviceTags = serviceTags.ToString()
                vendorServiceTags = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of VendorServiceTag))(serviceTags)
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
                Label6.Text = If(Not IsDBNull(vendorServiceTags(0).ApprovedVendorSID), vendorServiceTags(0).ApprovedVendorSID, "Not Selected")
                Label9.Text = If(Not IsDBNull(vendorServiceTags(1).ApprovedVendorSID), vendorServiceTags(1).ApprovedVendorSID, "Not Selected")
                Label10.Text = If(Not IsDBNull(vendorServiceTags(2).ApprovedVendorSID), vendorServiceTags(2).ApprovedVendorSID, "Not Selected")
                Label8.Text = If(Not IsDBNull(vendorServiceTags(3).ApprovedVendorSID), vendorServiceTags(3).ApprovedVendorSID, "Not Selected")
                'For Each ServiceTag In vendorServiceTags
                '    'Dim panel As New Panel With {.Width = 500, .Height = 50}
                '    Dim label As New Label With {.Text = ServiceTag.TagServiceName, .Width = 200, .Dock = DockStyle.Left}
                '    Panel1.Controls.Add(label)

                '    Dim button As New Button With {.Text = "Choose Vendor", .Tag = ServiceTag, .Dock = DockStyle.Right, .BackColor = Color.Black, .ForeColor = Color.White, .FlatStle =}
                '    AddHandler button.Click, AddressOf Button_Click
                '    Panel1.Controls.Add(button)

                '    'FlowLayoutPanelVendorServices.Controls.Add(panel)
                'Next

            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        ToggleVisibility(False, Button1, Button2, Button3, Button4, Label1, Label2, Label4, Label5, Label6, Label8, Label9, Label10)
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)

        ' Open the FestivalEvents_ChooseVendor form
        Dim chooseVendorForm As New FestivalEvents_ChooseVendor
        chooseVendorForm.ShowDialog() ' Show the form as a dialog
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class