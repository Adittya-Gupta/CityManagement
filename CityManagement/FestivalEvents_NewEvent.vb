Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FestivalEvents_NewEvent
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
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
        Dim eventname As String = NameTextBox.Text
        Dim eventdate As Date = EventDatePicker.Value
        Dim spacereq As String = SpaceRequired.Text
        Dim descr As String = EventDescription.Text
        Dim venue As String = VenueTextBox.Text
        Dim owner_id As Integer = Module1.CurrUserSID
        Dim isopen As Integer
        Dim etype As String
        If (eventdate > DateAndTime.Now) Then
            isopen = 1
        Else
            isopen = 0
        End If

        If Indoor.Checked Then
                etype = "Indoor"
            Else
                etype = "Outdoor"
        End If


        ' Check for not null constraints
        If String.IsNullOrEmpty(eventname) Then
            MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'If String.IsNullOrEmpty(email) OrElse Not email.Contains("@") OrElse Not email.Contains(".") Then
        '    MessageBox.Show("Please enter correct email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'End If

        'If String.IsNullOrEmpty(contactNo) Then
        '    MessageBox.Show("Please enter your contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'End If

        If String.IsNullOrEmpty(descr) Then
            MessageBox.Show("Please enter event description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(eventdate) Then
            MessageBox.Show("Please enter event date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check for integer constraint on contact number
        'Dim contactNoInteger As Double
        'If Not Double.TryParse(contactNo, contactNoInteger) Then
        '    MessageBox.Show("Contact number must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'End If

        ' Perform validation for other fields as necessary...

        ' Perform validation for password and confirm password
        'If password <> confirmPassword Then
        '    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'End If


        Try
            conn.Open()

            ' Check if the email already exists in the database
            'Dim query As String = "SELECT COUNT(*) FROM User WHERE EmailAddress = @Email"
            'Using cmd As New MySqlCommand(query, conn)
            '    cmd.Parameters.AddWithValue("@Email", email)
            '    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            '    If count > 0 Then
            '        MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Return
            '    End If
            'End Using

            ' Check if the contact number already exists in the database
            'query = "SELECT COUNT(*) FROM User WHERE ContactNo = @ContactNo"
            'Using cmd As New MySqlCommand(query, conn)
            '    cmd.Parameters.AddWithValue("@ContactNo", contactNo)
            '    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            '    If count > 0 Then
            '        MessageBox.Show("Contact number already exists. Please use a different contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Return
            '    End If
            'End Using

            'Convert profile picture to byte array
            Dim profilePic As Byte() = Nothing
            Try
                If (selectedImagePath <> "") Then
                    profilePic = File.ReadAllBytes(selectedImagePath)
                End If
            Catch ex As Exception
                Debug.WriteLine("Error reading file: " & ex.Message)
            End Try

            If profilePic IsNot Nothing Then
                Debug.WriteLine("Size of profilePic: " & profilePic.Length & " bytes")
            Else
                Debug.WriteLine("Profile picture is null or empty")
            End If

            Debug.WriteLine(profilePic)
            Debug.WriteLine(selectedImagePath)

            ' Generate a unique SID
            Dim eid As Integer = GenerateUniqueEventID()

            ' Hash the password
            'Dim hashedPassword As String = HashPassword(password)

            ' Insert the new user into the database
            Dim query As String = "INSERT INTO festivals (dateTime,description, event_type, id, image, isapproved, isopen, name, owner_sid,venue) VALUES (@datetime,@descr,@etype,@EID,@image,@isapproved,@isopen,@Name, @ownerid, @venue)"
            Using cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@EID", eid)
                cmd.Parameters.AddWithValue("@Name", eventname)
                cmd.Parameters.AddWithValue("@descr", descr)
                cmd.Parameters.AddWithValue("@etype", etype)
                cmd.Parameters.AddWithValue("@image", profilePic)
                cmd.Parameters.AddWithValue("@isapproved", 0)
                cmd.Parameters.AddWithValue("@isopen", isopen)
                cmd.Parameters.AddWithValue("@ownerid", owner_id)
                cmd.Parameters.AddWithValue("@venue", venue)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Event Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear the text boxes after successful signup
            NameTextBox.Text = ""
            VenueTextBox.Text = ""
            'ContactTextBox.Text = ""
            'GenderComboBox.SelectedIndex = -1
            'PasswordTextBox.Text = ""
            'ConfirmPasswordTextBox.Text = ""
            'DateOfBirthDateTimePicker.Value = Date.Now
            'Button1.Text = "Upload Picture"




        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        ' Add your signup logic here
        ' Once signup is successful, you can navigate to another form or perform other actions
        'MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        ' Set the properties of the OpenFileDialog
        openFileDialog1.Title = "Upload Picture"
        openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png"
        openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)


        ' Display the OpenFileDialog and check if the user selected a file
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            selectedImagePath = openFileDialog1.FileName

            ' Set the button text to the name of the selected image file
            Button1.Text = System.IO.Path.GetFileName(selectedImagePath)

            ' Load the image into an Image control or perform other operations
            'PictureBox1.Image = Image.FromFile(selectedImagePath)
        End If
    End Sub
End Class