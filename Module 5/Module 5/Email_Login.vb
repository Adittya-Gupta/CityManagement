Imports MySql.Data.MySqlClient
Public Class Email_Login

    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=email_database;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        Dim email As String = email_tb.Text

        Dim password1 As String = pass1_tb.Text

        Try
            conn.Open()


            Dim query = "SELECT Username
                 FROM UserData
                WHERE email = '" & email & "' and Password = '" & password1 & "';"

            Dim cmd = New MySqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader
            Dim sqlDt As New DataTable
            sqlDt.Load(reader)
            reader.Close()

            If sqlDt.Rows.Count = 0 Then
                MessageBox.Show("Incorrect email/password")
            Else
                Dim username As String = sqlDt.Rows(0)("Username").ToString()
                MessageBox.Show("You have been successfully logged in with username " & username)
            End If
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: {0}", ex.Message)
            conn.Close()
        End Try

    End Sub

End Class