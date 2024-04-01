﻿Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class User_ChangePassword
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Email = Environment.GetEnvironmentVariable("Email")

        If TextBox1.Text <> TextBox2.Text Then
            MessageBox.Show("Passwords do no match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim inputString As String = TextBox1.Text

        If inputString.Length < 1 Then
            MessageBox.Show("Please enter a non empty password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim StrengthCheck As Integer = PasswordStrengthCheck(inputString)

        If StrengthCheck < 5 Then
            Return
        End If


        ' Hash the password
        Dim newpassword As String = inputString
        Dim newhashedPassword As String = HashPassword(newpassword)

        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()

                Dim query As String = "SELECT PasswordHash FROM User WHERE EmailAddress = @Email"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Email", Email)
                Dim existingHash As String = Convert.ToString(cmd.ExecuteScalar())

                If newhashedPassword = existingHash Then
                    MessageBox.Show("Congratulations!! You have remembered your old password.... No need to change it now.", "Password Unchanged", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim LoginForm As New User_Login()
                    LoginForm.StartPosition = FormStartPosition.Manual
                    LoginForm.Location = Me.Location ' Set the location of the new form to the current form's location
                    LoginForm.Show()
                    Me.Close()
                    Return
                End If

                query = "UPDATE User SET PasswordHash = @PasswordHash WHERE EmailAddress = @Email"

                ' Make sure you use the "connection" object you've created and opened.
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", Email)
                command.Parameters.AddWithValue("@PasswordHash", newhashedPassword)

                Dim result As Integer = command.ExecuteNonQuery()

                ' Check if the update was successful based on affected rows.
                If result > 0 Then
                    MessageBox.Show("Password updated successfully!! , You will now be redirected back to Login Page")

                    Dim LoginForm As New User_Login()
                    LoginForm.StartPosition = FormStartPosition.Manual
                    LoginForm.Location = Me.Location ' Set the location of the new form to the current form's location
                    LoginForm.Show()
                    Me.Close()

                Else
                    MessageBox.Show("Password update failed!!")
                End If

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                ' The connection will be closed automatically due to the Using statement.
            End Try
        End Using

    End Sub

    Private Sub ChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        TextBox1.UseSystemPasswordChar = CheckBox1.Checked
        TextBox2.UseSystemPasswordChar = CheckBox1.Checked
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)

    End Sub

End Class