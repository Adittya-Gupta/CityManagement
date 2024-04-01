Imports MySql.Data.MySqlClient
Public Class Email_Register

    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=email_database;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Private Sub SignUp_btn_Click(sender As Object, e As EventArgs) Handles SignUp_btn.Click
        Dim email As String = email_tb.Text
        Dim name As String = "Avinav Yadav"
        Dim password1 As String = pass1_tb.Text
        Dim password2 As String = pass2_tb.Text

        If password1 <> password2 Then
            MessageBox.Show("Passwords do not match. Please try again.")
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
End Class