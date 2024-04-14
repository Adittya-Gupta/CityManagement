Imports MySql.Data.MySqlClient
Public Class Email_Register

    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=email_database;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Private Sub PrintStrength(input As String)

    End Sub


    Private Sub SignUp_btn_Click(sender As Object, e As EventArgs) Handles SignUp_btn.Click
        Dim email As String = email_tb.Text
        Dim name As String = username_tb.Text
        Dim password1 As String = pass1_tb.Text
        Dim password2 As String = pass2_tb.Text

        ' Initialize flags for character types
        Dim hasLower As Boolean = False
        Dim hasUpper As Boolean = False
        Dim hasDigit As Boolean = False
        Dim specialChar As Boolean = False

        ' Define normal characters allowed in the password
        Dim normalChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 "

        ' Iterate through each character in the input string
        For Each ch As Char In password1
            ' Check if the character is a lowercase letter
            If Char.IsLower(ch) Then
                hasLower = True
            End If

            ' Check if the character is an uppercase letter
            If Char.IsUpper(ch) Then
                hasUpper = True
            End If
            ' Check if the character is a digit
            If Char.IsDigit(ch) Then
                hasDigit = True
            End If

            ' Check if the character is a special character
            If normalChars.IndexOf(ch) = -1 Then
                specialChar = True
            End If
        Next

        ' Evaluate the strength of the password
        Dim strengthMessage As String =
                   If(hasLower And hasUpper And hasDigit And specialChar And password1.Length >= 8, "Strong",
                      If((hasLower Or hasUpper) And specialChar And password1.Length >= 6, "Moderate", "Weak"))

        ' Display the result in a message box
        'MessageBox.Show(strengthMessage)

        If password1 <> password2 Then
            MessageBox.Show("Passwords do not match. Please try again.")
        ElseIf username_tb.Text = "" Or email_tb.Text = "" Or pass1_tb.Text = "" Or pass2_tb.Text = "" Then

            MessageBox.Show("Please fill in all the fields !!")
        ElseIf strengthMessage = "Weak" Then
            MessageBox.Show("Please enter a strong password !!")
        Else
            Try
                conn.Open()


                Dim query = "INSERT INTO UserData (Username, email, Password)
                        VALUES ('" & name & "','" & email & "','" & password1 & "');"

                Dim cmd = New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                Dim sqlDt As New DataTable
                sqlDt.Load(reader)
                reader.Close()


                conn.Close()

                MessageBox.Show("You have been successfully registered!")

                Dim form1 As New Email_Login()
                form1.Show()
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show("Error: {0}", ex.Message)
                conn.Close()
            End Try
        End If

    End Sub

    Private Sub Email_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class