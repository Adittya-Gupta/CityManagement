Imports System.Drawing.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.IsisMtt.X509

Public Class FestivalEvents_EditEvent

    ' Database connection string
    Dim connString As String = Module1.connString
    ' MySqlConnection object to handle communication with the MySQL database
    Dim conn As New MySqlConnection(connString)

    Dim EventId As Integer = Module1.CurrEventID
    Dim UserSID As Integer = Module1.CurrUserSID



    ' This method is called when the Edit_Event form loads
    Private Sub Edit_Event_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Check if the global user ID from the login form is valid (not -1)
        If UserSID <> -1 Then
            ' Fetch event details from the database using the GetEventDetails function
            Dim eventDetails As Dictionary(Of String, Object) = GetEventDetails(EventId)
            If eventDetails IsNot Nothing Then
                ' If event details are found, populate the form fields with these details
                NameTextBox.Text = eventDetails("EventName").ToString()
                SpaceTextBox.Text = eventDetails("Venue").ToString()
                DescTextBox.Text = eventDetails("EventDescription").ToString()

                ' Attempt to parse the DateTime from the event details
                Dim eventDateTime As DateTime
                If DateTime.TryParse(eventDetails("DateTime").ToString(), eventDateTime) Then
                    DateTimePicker1.Value = eventDateTime
                    DateTimePicker2.Value = eventDateTime
                End If



                ' If a cover image is available, load it into the PictureBox
                Dim CoverImageData As Byte() = TryCast(eventDetails("CoverImage"), Byte())
                If CoverImageData IsNot Nothing Then
                    Dim ms As New System.IO.MemoryStream(CoverImageData)
                    PictureBox1.Image = Image.FromStream(ms)
                End If

                Dim eventType As String = eventDetails("EventType").ToString()
                If eventType = "Indoor" Then
                    RadioButton1.Checked = True
                ElseIf eventType = "Outdoor" Then
                    RadioButton2.Checked = True
                End If

            Else
                MessageBox.Show("Event details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("User not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

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
                    festivalDetails.Add("EventType", reader("event_type"))
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

    ' Event handler for the button click to upload a picture
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Title = "Select a picture" ' Title for the OpenFileDialog
            .Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG" ' Filter to only show image files
            .Multiselect = False ' Disallow selection of multiple files
        End With

        ' Show the OpenFileDialog and check the result
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                ' Load and display the selected image in the PictureBox
                Dim selectedImage As Image = Image.FromFile(OpenFileDialog1.FileName)
                PictureBox1.Image = selectedImage
            Catch ex As Exception
                ' Display an error message if loading the image fails
                MessageBox.Show("An error occurred while trying to load the picture: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Event handler for the Save Changes button click
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try


            Dim combinedDateTime As DateTime = DateTimePicker1.Value.Date + DateTimePicker2.Value.TimeOfDay
            Dim sql As String = "UPDATE festivals SET name = @EventName, isapproved = 0 ,venue = @Venue, description = @EventDescription, dateTime = @DateTime, image = @CoverImage, event_type = @EventType WHERE id = @EventID"
            If combinedDateTime < DateTime.Now Then
                MessageBox.Show("Date of event cannot be before current date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            conn.Open() ' Open the database connection
            ' SQL query to update event details in the database

            ' Combine Date and Time from the two DateTimePicker controls

            Using cmd As New MySqlCommand(sql, conn)
                ' Bind the form field values to the SQL query parameters
                cmd.Parameters.AddWithValue("@EventName", NameTextBox.Text)
                cmd.Parameters.AddWithValue("@Venue", SpaceTextBox.Text)
                cmd.Parameters.AddWithValue("@EventDescription", DescTextBox.Text)
                cmd.Parameters.AddWithValue("@DateTime", combinedDateTime)

                ' Determine the event type based on the checked radio button
                Dim eventType As String
                If RadioButton1.Checked Then
                    eventType = "Indoor"
                ElseIf RadioButton2.Checked Then
                    eventType = "Outdoor"
                Else
                    ' Handle the case where neither radio button is checked
                    eventType = "Unknown"
                End If
                cmd.Parameters.AddWithValue("@EventType", eventType)

                ' Convert the image in PictureBox to a byte array and bind it to the query parameter
                If PictureBox1.Image IsNot Nothing Then
                    Dim ms As New System.IO.MemoryStream()
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    Dim byteImage As Byte() = ms.ToArray()
                    cmd.Parameters.AddWithValue("@CoverImage", byteImage)
                Else
                    ' If no image is selected, bind a DBNull value
                    cmd.Parameters.AddWithValue("@CoverImage", DBNull.Value)
                End If

                ' Bind the EventID to the query parameter
                cmd.Parameters.AddWithValue("@EventID", EventId)

                ' Execute the SQL command
                cmd.ExecuteNonQuery()

                ' Display a success message
                MessageBox.Show("Event details updated successfully. However this will be sent for an approval again ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            ' Display an error message if updating the event fails
            MessageBox.Show("Failed to update event details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close() ' Close the database connection to free resources
        End Try
    End Sub

    Private Sub ApplyFontToControl(ByVal control As Control, ByVal font As Font)
        ' Set font for the current control
        control.Font = font

        ' Recursively set font for all child controls
        For Each childControl As Control In control.Controls
            ApplyFontToControl(childControl, font)
        Next
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New FestivalEvents_EventDetails
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class

