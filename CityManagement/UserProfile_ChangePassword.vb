Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class UserProfile_ChangePassword
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)

    Private Function GetUserDetails(userID As Integer) As Dictionary(Of String, Object)
        Dim userDetails As New Dictionary(Of String, Object)()
        Try
            conn.Open()
            Dim query As String = "SELECT EmailAddress FROM User WHERE SID = @SID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SID", userID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    userDetails.Add("Email", reader("EmailAddress"))
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching user Email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return userDetails
    End Function
    Private Sub UserProfile_ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Module1.CurrUserSID <> -1 Then
            ' If loggedInUserID is valid, fetch user details and display them
            Dim userDetails As Dictionary(Of String, Object) = GetUserDetails(Module1.CurrUserSID)
            If userDetails IsNot Nothing Then
                ' Display user Email

                TextBox4.Text = userDetails("Email")


            Else
                MessageBox.Show("User details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("User not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

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

        If TextBox3.Text = TextBox1.Text Then
            MessageBox.Show("Old password and new password cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the new password and confirm password match
        If NewPassword <> ConfirmPassword Then
            MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
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


            Dim StrengthCheck = PasswordStrengthCheck(NewPassword)

            Dim result = MessageBox.Show("Kindly Confirm. Do you want to change password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                Return ' Do nothing, return back
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

End Class
