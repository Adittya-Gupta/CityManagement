Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FestivalEvents_NewEvent
    Dim connString As String = Module1.connString
    'Dim connString As String = "server=localhost;userid=root;password=pwd;database=smart_city_management"
    Dim conn As New MySqlConnection(connString)
    Dim selectedImagePath As String = ""
    Private Function GenerateUniqueEventID() As Integer
        Dim eid As Integer
        Dim query As String
        Dim count As Integer

        ' Generate a random 6-digit number
        Dim rnd As New Random()
        eid = rnd.Next(100000, 999999)

        ' Check if the generated SID already exists in the database
        query = "SELECT COUNT(*) FROM festivals WHERE id = @eid"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@eid", eid)
            count = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        ' If the generated SID already exists, generate a new one recursively
        If count > 0 Then
            eid = GenerateUniqueEventID() ' Recursive call to generate a new SID
        End If

        Return eid
    End Function
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        mypanel.Panel1.Controls.Clear()
        Dim form As New FestivalEvents_MainMenu
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Success As Integer = 0
        Try
            Dim eventname As String = NameTextBox.Text
            Dim eventdate As Date = EventDatePicker.Value
            Dim descr As String = EventDescription.Text
            Dim venue As String = VenueTextBox.Text
            Dim owner_id As Integer = Module1.CurrUserSID
            Dim isopen As Integer = 1 'If(eventdate > DateAndTime.Now, 1, 0)
            Dim etype As String = If(Indoor.Checked, "Indoor", "Outdoor")

            ' Check for not null constraints
            If String.IsNullOrEmpty(eventname) Then
                MessageBox.Show("Please enter the event name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrEmpty(descr) Then
                MessageBox.Show("Please enter event description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If eventdate < DateTime.Now Then
                MessageBox.Show("Date of event cannot be before current date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' You may add more validation checks here...

            conn.Open()

            ' Convert profile picture to byte array
            Dim profilePic As Byte() = Nothing
            If Not String.IsNullOrEmpty(selectedImagePath) Then
                profilePic = File.ReadAllBytes(selectedImagePath)
            End If

            ' Generate a unique event ID
            Dim eid As Integer = GenerateUniqueEventID()
            Debug.WriteLine(owner_id)

            ' Insert the new event into the database
            Dim defaultVendorServiceTagsJson As String = "[{""TagServiceName"":""Catering"",""IsRequired"":false,""ListofVendorSIDs"":[],""ApprovedVendorSID"":null},{""TagServiceName"":""Photography"",""IsRequired"":false,""ListofVendorSIDs"":[],""ApprovedVendorSID"":null},{""TagServiceName"":""Music & DJ"",""IsRequired"":false,""ListofVendorSIDs"":[],""ApprovedVendorSID"":null},{""TagServiceName"":""Cleaning"",""IsRequired"":false,""ListofVendorSIDs"":[],""ApprovedVendorSID"":null}]"

            Dim query As String = "INSERT INTO festivals (dateTime, description, event_type, id, image, isapproved, isopen, name, owner_sid, venue, vendor_service_tags) VALUES (@datetime, @descr, @etype, @EID, @image, 0, @isopen, @Name, @ownerid, @venue, @vendorServiceTags)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EID", eid)
                cmd.Parameters.AddWithValue("@Name", eventname)
                cmd.Parameters.AddWithValue("@descr", descr)
                cmd.Parameters.AddWithValue("@etype", etype)
                cmd.Parameters.AddWithValue("@image", If(profilePic, DBNull.Value))
                cmd.Parameters.AddWithValue("@isopen", isopen)
                cmd.Parameters.AddWithValue("@ownerid", owner_id)
                cmd.Parameters.AddWithValue("@venue", venue)
                cmd.Parameters.AddWithValue("@datetime", eventdate)
                cmd.Parameters.AddWithValue("@vendorServiceTags", defaultVendorServiceTagsJson)
                cmd.ExecuteNonQuery()
            End Using


            MessageBox.Show("Event Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear the text boxes after successful registration
            NameTextBox.Text = ""
            VenueTextBox.Text = ""
            EventDescription.Text = ""
            ' Clear other fields as needed...
            Success = 1

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            conn.Close()
        End Try

        If Success = 1 Then
            mypanel.Panel1.Controls.Clear()
            Dim form As New FestivalEvents_MainMenu
            form.TopLevel = False
            mypanel.Panel1.Controls.Add(form)
            form.Show()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        ' Set the properties of the OpenFileDialog
        openFileDialog1.Title = "Upload Picture"
        openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png"
        openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

        ' Display the OpenFileDialog and check if the user selected a file
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                ' Get the selected file path
                selectedImagePath = openFileDialog1.FileName

                ' Set the button text to the name of the selected image file
                Button1.Text = System.IO.Path.GetFileName(selectedImagePath)

                ' Load the image into an Image control or perform other operations
                EventImage.Image = Image.FromFile(selectedImagePath)
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


End Class