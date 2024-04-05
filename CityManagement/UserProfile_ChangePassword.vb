Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class UserProfile_ChangePassword
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)



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

    Private Function IsEmailRegistered(email As String) As Boolean
        Dim isRegistered As Boolean = False
        Try
            conn.Open()

            Dim query As String = "SELECT COUNT(*) FROM User WHERE EmailAddress = @Email"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", email)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' If count is greater than 0, email is registered
            If count > 0 Then
                isRegistered = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking email registration: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return isRegistered
    End Function

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim Email = TextBox4.Text ' Assuming TextBox4 is for entering the email address
        Dim OldPassword = TextBox3.Text ' Assuming TextBox3 is for entering the old password
        Dim NewPassword = TextBox1.Text ' Assuming TextBox1 is for entering the new password
        Dim ConfirmPassword = TextBox2.Text ' Assuming TextBox2 is for confirming the new password

        If String.IsNullOrWhiteSpace(TextBox4.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If Not IsEmailRegistered(Email) Then
            MessageBox.Show("Email is not registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBox3.Text = TextBox1.Text Then
            MessageBox.Show("Old password and new password cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the new password and confirm password match
        If NewPassword <> ConfirmPassword Then
            MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim StrengthCheck = PasswordStrengthCheck(NewPassword)

        If StrengthCheck < 5 Then
            MessageBox.Show("Your password does not meet the recommended strength criteria. It is weak.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        ' Hash the passwords
        Dim oldHashedPassword = HashPassword(OldPassword)
        Dim newHashedPassword = HashPassword(NewPassword)

        Try
            conn.Open()

            ' Query to retrieve the existing password hash
            Dim query = "SELECT PasswordHash FROM User WHERE EmailAddress = @Email"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", Email)
            Dim existingHash = Convert.ToString(cmd.ExecuteScalar())

            ' Verify if the old password matches the existing password
            If oldHashedPassword <> existingHash Then
                MessageBox.Show("Old password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Update the password in the database
            query = "UPDATE User SET PasswordHash = @NewPassword WHERE EmailAddress = @Email"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@NewPassword", newHashedPassword)
            cmd.Parameters.AddWithValue("@Email", Email)
            Dim affectedRows = cmd.ExecuteNonQuery()

            If affectedRows > 0 Then
                MessageBox.Show("Password updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Open the signup form when the label is clicked
                mypanel.Panel1.Controls.Clear()
                Dim form As New User_Profile
                form.TopLevel = False
                mypanel.Panel1.Controls.Add(form)
                form.Show()
                Me.Close()

            Else
                MessageBox.Show("Failed to update password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        ' Toggle password visibility based on checkbox state
        TextBox1.UseSystemPasswordChar = Not CheckBox1.Checked
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
        TextBox3.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub User_ChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Any additional initialization code can be placed here
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Open the login form when the button is clicked
        User_Profile.Show()
        Me.Hide()
    End Sub
End Class
