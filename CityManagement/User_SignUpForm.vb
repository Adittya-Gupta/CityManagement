Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class User_SignUpForm

    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Dim selectedImagePath As String = ""
    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.WindowState = FormWindowState.Maximized

        ' Populate the gender ComboBox
        GenderComboBox.Items.AddRange({"Select", "Male", "Female", "Non Binary", "Prefer not to say"})
        ' Select the first item by default
        GenderComboBox.SelectedIndex = 0

        StrengthCheckLabel.Visible = False
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
        Using sha256 As SHA256 = sha256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    'a function that verifies if there is any upper case alphabet in the entered password
    Function ContainsUpperCase(ByVal inputString As String) As Boolean
        'iterating through whole input string entered
        For Each character As Char In inputString
            If Char.IsUpper(character) Then
                Return True
            End If
        Next

        Return False
    End Function

    'a function that verifies if there is any lower case alphabet in the entered password
    Function ContainsLowerCase(ByVal inputString As String) As Boolean
        'iterating through whole input string entered
        For Each character As Char In inputString
            If Char.IsLower(character) Then
                Return True
            End If
        Next

        Return False
    End Function

    'a function that verifies if there is any digit(0-9) in the entered password
    Function ContainsDigit(ByVal inputString As String) As Boolean
        'iterating through whole input string entered
        For Each character As Char In inputString
            If Char.IsDigit(character) Then
                Return True
            End If
        Next

        Return False
    End Function

    'a function that verifies if there is any special character in the entered password
    Function ContainsSpecialCharacter(ByVal inputString As String) As Boolean
        'iterating through whole input string entered
        For Each character As Char In inputString
            If Not Char.IsLetterOrDigit(character) Then
                ' If the character is not a letter or digit, consider it as a special character
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        If Not String.IsNullOrEmpty(PasswordTextBox.Text) Then
            ' If the password is not empty and not the default text, make the strength label visible
            StrengthCheckLabel.Visible = True
        Else
            ' Otherwise, hide the strength label
            StrengthCheckLabel.Visible = False
        End If
    End Sub

    Private Function PasswordStrengthCheck(ByVal InputString As String) As Integer
        Dim checkVar As Integer = 0
        Dim message As String = "Password Strength Check:" & vbCrLf

        ' Checking length criteria
        If InputString.Length >= 8 Then
            checkVar += 1
            message &= "✓ Length should be at least 8 characters." & vbCrLf
        Else
            message &= "✗ Length should be at least 8 characters." & vbCrLf
        End If

        ' Checking if the password has a digit
        If ContainsDigit(InputString) Then
            checkVar += 1
            message &= "✓ Contains at least one digit." & vbCrLf
        Else
            message &= "✗ Should contain at least one digit." & vbCrLf
        End If

        ' Checking if the password has a lowercase letter
        If ContainsLowerCase(InputString) Then
            checkVar += 1
            message &= "✓ Contains at least one lowercase letter." & vbCrLf
        Else
            message &= "✗ Should contain at least one lowercase letter." & vbCrLf
        End If

        ' Checking if the password has a special character
        If ContainsSpecialCharacter(InputString) Then
            checkVar += 1
            message &= "✓ Contains at least one special character." & vbCrLf
        Else
            message &= "✗ Should contain at least one special character." & vbCrLf
        End If

        ' Checking if the password has an uppercase letter
        If ContainsUpperCase(InputString) Then
            checkVar += 1
            message &= "✓ Contains at least one uppercase letter." & vbCrLf
        Else
            message &= "✗ Should contain at least one uppercase letter." & vbCrLf
        End If

        If checkVar < 5 Then
            MessageBox.Show(message, "Password Strength", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return checkVar

    End Function

    Private Sub CheckStrengthClick() Handles StrengthCheckLabel.Click
        PasswordStrengthCheck(PasswordTextBox.Text)

    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        ' Perform signup logic here
        Dim name As String = NameTextBox.Text
        Dim email As String = EmailTextBox.Text
        Dim contactNo As String = ContactTextBox.Text
        Dim gender As String = GenderComboBox.SelectedItem.ToString()
        Dim password As String = PasswordTextBox.Text
        Dim confirmPassword As String = ConfirmPasswordTextBox.Text
        Dim dob As Date = DateOfBirthDateTimePicker.Value

        ' Check for not null constraints
        If String.IsNullOrEmpty(name) Then
            MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(email) OrElse Not email.Contains("@") OrElse Not email.Contains(".") Then
            MessageBox.Show("Please enter correct email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(contactNo) Then
            MessageBox.Show("Please enter your contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(confirmPassword) Then
            MessageBox.Show("Please confirm your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Try
            conn.Open()

            ' Check if the email already exists in the database
            Dim query As String = "SELECT COUNT(*) FROM User WHERE EmailAddress = @Email"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Email", email)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

            ' Check if the contact number already exists in the database
            query = "SELECT COUNT(*) FROM User WHERE ContactNo = @ContactNo"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ContactNo", contactNo)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Contact number already exists. Please use a different contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

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
            Else
                Debug.WriteLine("Profile picture is null or empty")
            End If

            Debug.WriteLine(profilePic)
            Debug.WriteLine(selectedImagePath)

            ' Generate a unique SID
            Dim sid As Integer = GenerateUniqueSID()

            ' Hash the password
            Dim hashedPassword As String = HashPassword(password)

            ' Insert the new user into the database
            query = "INSERT INTO User (SID, Name, EmailAddress, ContactNo, Gender, Designation, ProfilePic, PasswordHash, DOB) VALUES (@SID, @Name, @Email, @ContactNo, @Gender, @Designation, @ProfilePic, @PasswordHash, @DOB)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SID", sid)
                cmd.Parameters.AddWithValue("@Name", name)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@ContactNo", contactNo)
                cmd.Parameters.AddWithValue("@Gender", gender)
                cmd.Parameters.AddWithValue("@Designation", "Not Employed")
                cmd.Parameters.AddWithValue("@ProfilePic", profilePic)
                cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword)
                cmd.Parameters.AddWithValue("@DOB", dob)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear the text boxes after successful signup
            NameTextBox.Text = ""
            EmailTextBox.Text = ""
            ContactTextBox.Text = ""
            GenderComboBox.SelectedIndex = -1
            PasswordTextBox.Text = ""
            ConfirmPasswordTextBox.Text = ""
            DateOfBirthDateTimePicker.Value = Date.Now
            Button1.Text = "Upload Picture"

            LoginLabel_Click()


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        ' Add your signup logic here
        ' Once signup is successful, you can navigate to another form or perform other actions
        'MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LoginLabel_Click() Handles LoginLabel.Click
        ' Open the signup form when the label is clicked
        Dim LoginForm As New User_Login()
        LoginForm.StartPosition = FormStartPosition.Manual
        LoginForm.Location = Me.Location ' Set the location of the new form to the current form's location
        LoginForm.Show()
        Me.Hide()
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