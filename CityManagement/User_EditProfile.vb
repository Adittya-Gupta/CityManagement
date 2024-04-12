Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Xml

Public Class User_EditProfile

    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Dim selectedImagePath As String = ""
    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = Screen.PrimaryScreen.Bounds.Width - 200
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        'Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
        ' Populate the gender ComboBox
        GenderComboBox.Items.AddRange({"Select", "Male", "Female", "Non Binary", "Prefer not to say"})
        ' Select the first item by default
        GenderComboBox.SelectedIndex = 0

        If Module1.CurrUserSID <> -1 Then
            ' If loggedInUserID is valid, fetch user details and display them
            Dim userDetails As Dictionary(Of String, Object) = GetUserDetails(Module1.CurrUserSID)
            If userDetails IsNot Nothing Then
                ' Display user details
                NameTextBox.Text = userDetails("Name")
                EmailTextBox.Text = userDetails("Email")
                GenderComboBox.SelectedIndex = GenderComboBox.FindStringExact(userDetails("Gender"))
                ContactTextBox.Text = userDetails("ContactNo")
                DateOfBirthDateTimePicker.Value = userDetails("DOB")

            Else
                MessageBox.Show("User details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("User not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    ' Function to generate a unique SID
    Private Function GenerateUniqueSID() As Integer
        Dim sid As Integer
        Dim query As String
        Dim count As Integer

        ' Generate a random 6-digit number
        Dim rnd As New Random()
        sid = rnd.Next(100000, 999999)

        ' Check if the generated SID already exists in the database
        query = "SELECT COUNT(*) FROM User WHERE SID = @SID"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@SID", sid)
            count = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        ' If the generated SID already exists, generate a new one recursively
        If count > 0 Then
            sid = GenerateUniqueSID() ' Recursive call to generate a new SID
        End If

        Return sid
    End Function


    ' Function to hash the password using SHA256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function


    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        ' Perform signup logic here
        Dim name As String = NameTextBox.Text
        Dim contactNo As String = ContactTextBox.Text
        Dim gender As String = GenderComboBox.SelectedItem.ToString()
        Dim dob As Date = DateOfBirthDateTimePicker.Value

        ' Check for not null constraints
        If String.IsNullOrEmpty(name) Then
            MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(contactNo) Then
            MessageBox.Show("Please enter your contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If



        ' Check for integer constraint on contact number
        Dim contactNoInteger As Double
        If Not Double.TryParse(contactNo, contactNoInteger) Then
            MessageBox.Show("Contact number must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Perform validation for other fields as necessary...

        ' Perform validation for password and confirm password


        Try
            conn.Open()



            ' Check if the contact number already exists in the database
            Dim query As String = "SELECT COUNT(*) FROM User WHERE ContactNo = @ContactNo"

            ' Convert profile picture to byte array
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
                query = "Update User Set Name=@Name, ContactNo=@ContactNo, Gender=@Gender, ProfilePic=@ProfilePic, DOB=@DOB where SID=@SID"
            Else
                Debug.WriteLine("Profile picture is null or empty")
                query = "Update User Set Name=@Name, ContactNo=@ContactNo, Gender=@Gender, DOB=@DOB where SID=@SID"
            End If

            Debug.WriteLine(profilePic)
            Debug.WriteLine(selectedImagePath)


            ' Insert the new user into the database
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SID", Module1.CurrUserSID)
                cmd.Parameters.AddWithValue("@Name", name)
                cmd.Parameters.AddWithValue("@ContactNo", contactNo)
                cmd.Parameters.AddWithValue("@Gender", gender)
                If profilePic IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@ProfilePic", profilePic)
                End If
                cmd.Parameters.AddWithValue("@DOB", dob)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Information updated successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear the text boxes after successful signup
            NameTextBox.Text = ""
            EmailTextBox.Text = ""
            ContactTextBox.Text = ""
            GenderComboBox.SelectedIndex = -1
            DateOfBirthDateTimePicker.Value = Date.Now
            Button1.Text = "Upload Picture"

            Submit_Click()


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        ' Add your signup logic here
        ' Once signup is successful, you can navigate to another form or perform other actions
        'MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Submit_Click()
        ' Open the signup form when the label is clicked
        mypanel.Panel1.Controls.Clear()
        Dim form As New User_Profile
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Function GetUserDetails(userID As Integer) As Dictionary(Of String, Object)
        Dim userDetails As New Dictionary(Of String, Object)()
        Try
            conn.Open()
            Dim query As String = "SELECT Name, EmailAddress, Gender, ContactNo, Designation, DOB, ProfilePic FROM User WHERE SID = @SID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SID", userID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    userDetails.Add("Name", reader("Name"))
                    userDetails.Add("Email", reader("EmailAddress"))
                    userDetails.Add("Gender", reader("Gender"))
                    userDetails.Add("ContactNo", reader("ContactNo"))
                    userDetails.Add("Designation", reader("Designation"))
                    userDetails.Add("DOB", reader("DOB"))
                    userDetails.Add("ProfilePic", If(Not IsDBNull(reader("ProfilePic")), DirectCast(reader("ProfilePic"), Byte()), Nothing))
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return userDetails
    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        mypanel.Panel1.Controls.Clear()
        Dim form As New User_Profile
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class