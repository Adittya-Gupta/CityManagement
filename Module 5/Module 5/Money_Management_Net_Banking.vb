Imports MySql.Data.MySqlClient

Public Class Money_Management_Net_Banking
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Dim username As String
    Dim password As String
    Dim remark As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox_Username.Text = RichTextBox_Username.Text.Trim()
        RichTextBox_Password.Text = RichTextBox_Password.Text.Trim()
        RichTextBox_Remark.Text = RichTextBox_Remark.Text.Trim()

        username = RichTextBox_Username.Text
        password = RichTextBox_Password.Text
        remark = RichTextBox_Remark.Text

        If Not username <> "" Then
            MessageBox.Show("Please enter username.")
        ElseIf Not password <> "" Then
            MessageBox.Show("Please enter password.")
        ElseIf Not remark <> "" Then
            MessageBox.Show("Please enter remark.")
        Else
            Try
                conn.Open()
                Dim query = "SELECT * FROM UserData Where Username = '" & username & "' AND Password = '" & password & "' ;"
                Dim cmd = New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                Dim sqlDt As New DataTable
                sqlDt.Load(reader)
                reader.Close()
                If sqlDt.Rows.Count = 0 Then
                    MessageBox.Show("Wrong Username or Password.")
                Else
                    MessageBox.Show("Correct Username & Password")
                End If

                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error: {0}", ex.Message)
                conn.Close()
            End Try
        End If
    End Sub
End Class