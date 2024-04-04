Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Profile
    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "bankingdatabase"

    Public bank_username As String = "samuel"
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' connection to database
        MessageBox.Show(bank_username)

        'im connString = "server=172.16.114.244;userid=admin;password=nimda;database=banking_database"
        'im connString As String = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Dim connString As String = "server=localhost;userid=root;password=Aasneh18;database=bankingdatabase;"
        Dim conn = New MySqlConnection(connString)

        Try
            conn.Open()
            Dim query = "SELECT * FROM `UserData` WHERE username = '" & bank_username & "'"
            Dim cmd = New MySqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader
            Dim sqlDt As New DataTable
            sqlDt.Clear()
            sqlDt.Load(reader)

            Dim rowCount = sqlDt.Rows.Count
            Dim columnCount = sqlDt.Columns.Count

            'Dim imageBytes = DirectCast(sqlDt.Rows(0)(10), Byte())
            'Dim ms As New MemoryStream(imageBytes)
            'Dim image As Image = image.FromStream(ms)
            'PictureBox1.Image = image
            'DataGridView1.DataSource = sqlDt

            TextBoxBalence.Text = sqlDt.Rows(0)(8).ToString()
            TextBoxAccountNumber.Text = sqlDt.Rows(0)(0).ToString()
            TextBoxCIBILScore.Text = sqlDt.Rows(0)(9).ToString()
            TextBoxUsername.Text = sqlDt.Rows(0)(5).ToString()

            LabelName.Text = sqlDt.Rows(0)(2).ToString()
            LabelAddress.Text = sqlDt.Rows(0)(3).ToString()
            sqlDt.Clear()
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: {0}", ex.Message)
        Finally
            conn.Close()
            'MessageBox.Show("Connection closed.")
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBoxUsername.UseSystemPasswordChar = CheckBox1.Checked
        TextBoxAccountNumber.UseSystemPasswordChar = CheckBox1.Checked
        TextBoxBalence.UseSystemPasswordChar = CheckBox1.Checked
        TextBoxCIBILScore.UseSystemPasswordChar = CheckBox1.Checked
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


End Class