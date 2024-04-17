Imports System.Drawing.Text
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json
Public Class FestivalEvents_Offer_Service2

    ' Database connection string
    Dim connString As String = Module1.connString
    ' MySqlConnection object to handle communication with the MySQL database
    Dim conn As New MySqlConnection(connString)

    Dim EventId As Integer = CurrEventID
    Dim UserSID As Integer = CurrUserSID

    'Dim EventId As Integer = 4
    'Dim UserSID As Integer = 1

    Dim vendorServiceTags As List(Of VendorServiceTag)


    Public Class VendorServiceTag
        Public Property TagServiceName As String
        Public Property IsRequired As Boolean
        Public Property ListofVendorSIDs As List(Of Integer)
        Public Property ApprovedVendorSID As Integer?
    End Class


    Private Sub Event_OfferService_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If UserSID <> -1 Then
            ' Assume EventID is somehow determined or passed to this form
            Dim eventDetails As Dictionary(Of String, Object) = GetEventDetails(EventId)
            If eventDetails IsNot Nothing Then
                ' Populate the labels with these details
                EventName.Text = eventDetails("EventName").ToString()
                EventVenue.Text = eventDetails("Venue").ToString()
                Description.Text = eventDetails("EventDescription").ToString()

                ' Parse and format the DateTime to separate date and time
                Dim eventDateTime As DateTime
                If DateTime.TryParse(eventDetails("DateTime").ToString(), eventDateTime) Then
                    EventDate.Text = eventDateTime.ToString("d") ' Example format: 12/31/2020
                    EventTime.Text = eventDateTime.ToString("t") ' Example format: 11:59 PM
                End If

                ' If a cover image is available, load it into the PictureBox
                Dim CoverImageData As Byte() = TryCast(eventDetails("CoverImage"), Byte())
                If CoverImageData IsNot Nothing Then
                    Dim ms As New System.IO.MemoryStream(CoverImageData)
                    PictureBox1.Image = Image.FromStream(ms)
                End If

                ' Handle VendorServiceTags
                Dim vendorServiceTagsJson As String = eventDetails("VendorServiceTags").ToString()
                PopulateVendorServices(vendorServiceTagsJson, UserSID)



            Else
                MessageBox.Show("Festival details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("User not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PopulateVendorServices(jsonString As String, userId As Integer)
        vendorServiceTags = JsonConvert.DeserializeObject(Of List(Of VendorServiceTag))(jsonString)


        FlowLayoutPanelVendorServices.Controls.Clear()

        For Each ServiceTag In vendorServiceTags
            If ServiceTag.IsRequired Then
                Dim panel As New Panel With {.Width = 400, .Height = 50, .Margin = New Padding(0, 0, 80, 0)}
                Dim label As New Label With {.Text = ServiceTag.TagServiceName, .Width = 210, .Dock = DockStyle.Left, .Font = New Font("Abhaya Libre Medium", 20)}
                panel.Controls.Add(label)

                Dim button As New Button With {.Text = If(ServiceTag.ListofVendorSIDs.Contains(userId), "Cancel", "Request"), .Tag = ServiceTag, .Dock = DockStyle.Right, .Width = 210, .Height = 50, .BackColor = Color.Black, .ForeColor = Color.White, .Font = New Font("Abhaya Libre Medium", 20)}
                AddHandler button.Click, AddressOf VendorServiceButton_Click
                panel.Controls.Add(button)

                FlowLayoutPanelVendorServices.Controls.Add(panel)
            End If
        Next

    End Sub

    Private Sub VendorServiceButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Dim tag As VendorServiceTag = CType(button.Tag, VendorServiceTag)
        Dim userId As Integer = UserSID ' Assuming you have a global user ID

        If tag.ListofVendorSIDs.Contains(userId) Then
            ' User is canceling the request
            tag.ListofVendorSIDs.Remove(userId)
            button.Text = "Request"
        Else
            ' User is making a request
            tag.ListofVendorSIDs.Add(userId)
            button.Text = "Cancel"
        End If

        ' Serialize the updated list of VendorServiceTags back to JSON
        Dim updatedJsonString As String = SerializeVendorServiceTags(vendorServiceTags)

        ' Update the JSON in your database with the new list of VendorSIDs
        Try
            conn.Open() ' Open database connection

            ' SQL query to update only the vendor_service_tags column for a specific festival
            Dim sql As String = "UPDATE festivals SET vendor_service_tags = @VendorServiceTags WHERE id = @EventID"

            Using cmd As New MySqlCommand(sql, conn)
                ' Bind the EventID to identify the correct festival to update
                cmd.Parameters.AddWithValue("@EventID", EventId) ' Make sure you have the correct EventID here

                ' Bind the updated vendor service tags JSON string
                cmd.Parameters.AddWithValue("@VendorServiceTags", updatedJsonString)

                ' Execute the SQL command
                cmd.ExecuteNonQuery()

                MessageBox.Show("Vendor service updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to update vendor service: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close() ' Ensure the database connection is closed
            End If
        End Try
    End Sub


    Public Function SerializeVendorServiceTags(vendorServiceTags As List(Of VendorServiceTag)) As String
        Return JsonConvert.SerializeObject(vendorServiceTags)
    End Function


    ' Retrieves festival details from the database using the provided EventID
    Private Function GetEventDetails(EventID As Integer) As Dictionary(Of String, Object)
        Dim festivalDetails As New Dictionary(Of String, Object)()
        Try
            conn.Open() ' Open database connection
            ' SQL query to fetch festival details
            Dim query As String = "SELECT name, description, image, owner_sid, vendor_service_tags, event_type, venue, dateTime, isapproved, isopen, restrictions FROM festivals WHERE id = @EventID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EventID", EventID) ' Bind the EventID parameter
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    festivalDetails.Add("EventName", reader("name"))
                    festivalDetails.Add("DateTime", reader("dateTime").ToString())
                    festivalDetails.Add("Venue", reader("venue"))
                    festivalDetails.Add("EventDescription", reader("description"))
                    festivalDetails.Add("VendorServiceTags", If(Not IsDBNull(reader("vendor_service_tags")), reader("vendor_service_tags").ToString(), "{}"))
                    ' Assuming CoverImage is also being retrieved here based on your initial setup
                    festivalDetails.Add("CoverImage", If(Not IsDBNull(reader("image")), DirectCast(reader("image"), Byte()), Nothing))
                    ' Additional fields can be added as needed
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching festival details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close() ' Ensure the connection is closed even if an error occurs
        End Try
        Return festivalDetails
    End Function


    Private Sub ApplyFontToControl(ByVal control As Control, ByVal font As Font)
        ' Set font for the current control
        control.Font = font

        ' Recursively set font for all child controls
        For Each childControl As Control In control.Controls
            ApplyFontToControl(childControl, font)
        Next
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New FestivalEvents_EventDetails
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class