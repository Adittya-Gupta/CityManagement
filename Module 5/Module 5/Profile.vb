Imports System.IO
Imports System.Reflection.Emit
Imports MySql.Data.MySqlClient

Public Class Profile

    Public bank_username As String = "admin"
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' connection to database
        Dim connString = "server=172.16.114.244;userid=admin;password=nimda;database=banking_database"
        Dim conn = New MySqlConnection(connString)

        Try
            conn.Open()
            Dim query = "SELECT * FROM `UserData` WHERE username = '" & current_user & "'"
            Dim cmd = New MySqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader
            Dim sqlDt As New DataTable
            sqlDt.Load(reader)

            Dim rowCount = sqlDt.Rows.Count
            Dim columnCount = sqlDt.Columns.Count

            Dim imageBytes = DirectCast(sqlDt.Rows(0)(10), Byte())
            Dim ms As New MemoryStream(imageBytes)
            Dim image As Image = image.FromStream(ms)
            PictureBox1.Image = image
            'DataGridView1.DataSource = sqlDt

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: {0}", ex.Message)
        Finally
            conn.Close()
            MessageBox.Show("Connection closed.")
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBoxUsername.UseSystemPasswordChar = CheckBox1.Checked
        TextBoxAccountNumber.UseSystemPasswordChar = CheckBox1.Checked
        TextBoxBalence.UseSystemPasswordChar = CheckBox1.Checked
        TextBoxCIBILScore.UseSystemPasswordChar = CheckBox1.Checked
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub
End Class