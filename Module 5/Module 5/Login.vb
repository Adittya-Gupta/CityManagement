Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim Username As String = TextBoxUsername.Text.Trim()
        Dim Password As String = TextBoxpassword.Text.Trim()

        ' connection to database
        Dim connString As String = "server=172.16.114.244;userid=admin;password=nimda;database=smart_city_management"
        Dim conn As MySqlConnection = New MySqlConnection(connString)

        Try
            conn.Open()
            'Dim query As String = "SELECT photo FROM `BankUsers` WHERE username = '" & Username & "'"
            'Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            'cmd = New MySqlCommand(query, conn)
            'cmd.Parameters.AddWithValue("@ID", IdentificationNumber) ' Assuming IdentificationNumber is the identifier you're using
            'Dim imageData As Byte() = CType(cmd.ExecuteScalar(), Byte())

            ' Convert the binary image data to an Image object
            'If imageData IsNot Nothing Then
            'Using ms As New MemoryStream(imageData)
            'Dim img As Image = Image.FromStream(ms)
            ' Display the image in PictureBox control
            'PictureB'ox1.Image = img
            'End Using
            'Else
            ' Handle case where no image is found for the given ID
            'MessageBox.Show("No image found for the given ID.")
            'End If

            Dim query As String = "SELECT * FROM `BankUsers` WHERE username = '" & Username & "'"
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim sqlDt As New DataTable
            sqlDt.Load(reader)

            Dim rowCount As Integer = sqlDt.Rows.Count
            Dim columnCount As Integer = sqlDt.Columns.Count

            'DataGridView1.DataSource = sqlDt




            If rowCount = 0 Then
                MessageBox.Show("You have not registered yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reader.Close()
                'DataGridView1.DataSource = sqlDt
                conn.Close() ' Close the connection after using it
                Return
            ElseIf rowCount > 1 Then
                MessageBox.Show("An error occurred in database. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reader.Close()
                'DataGridView1.DataSource = sqlDt
                conn.Close() ' Close the connection after using it
                Return
            Else
                If sqlDt.Rows(0)(6).ToString() = Password.ToString() Then
                    'Form51.ReceivedEmail = enteredEmail
                    Profile.current_user = Username
                    'Me.Hide()
                    Profile.Show()
                    'Dim imageBytes As Byte() = DirectCast(sqlDt.Rows(0)(9), Byte())
                    'Dim ms As New System.IO.MemoryStream(imageBytes)
                    'Dim image As Image = Image.FromStream(ms)
                    'PictureBox1.Image = image
                    'DataGridView1.DataSource = sqlDt
                Else
                    MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: {0}", ex.Message)
        Finally
            conn.Close()
            MessageBox.Show("Connection closed.")
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        TextBoxpassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Registration.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class