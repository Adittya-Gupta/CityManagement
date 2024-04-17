Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Banking_Login

    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "bankingdatabase"

    ' connection to database
    'Dim connString As String = "server=172.16.114.244;userid=admin;password=nimda;database=banking_database"
    'Dim connString As String = "server=localhost;userid=root;password=Aasneh18;database=bankingdatabase;"
    'Dim connString As String = "server=localhost;userid=root;password=abinash;database=banking_database;"
    Dim connString As String = Global_Attributes.slqConnection_banking

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Public bank_username As String = "samuel"
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim Username As String = TextBoxUsername.Text.Trim()
        Dim Password As String = TextBoxpassword.Text.Trim()


        Dim conn As MySqlConnection = New MySqlConnection(connString)

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM `BankUserData` WHERE username = '" & Username & "'"
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
                If sqlDt.Rows(0)("Password").ToString() = Password.ToString() Then

                    If sqlDt.Rows(0)("Approved").ToString() = "0" Then
                        MessageBox.Show("Your Application is under review")
                    Else
                        'Form51.ReceivedEmail = enteredEmail
                        Banking_Profile.bank_username = Username
                        Banking_Main.bank_username = Username
                        Global_Attributes.banking_username = Username
                        'MessageBox.Show(Username)
                        'Me.Hide()
                        'Profile.Show()
                        ChildForm(Banking_Main.Panel1, Banking_Profile)


                        'Dim imageBytes As Byte() = DirectCast(sqlDt.Rows(0)(9), Byte())
                        'Dim ms As New System.IO.MemoryStream(imageBytes)
                        'Dim image As Image = Image.FromStream(ms)
                        'PictureBox1.Image = image
                        'DataGridView1.DataSource = sqlDt
                    End If
                Else
                    MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: {0}", ex.Message)
        Finally
            conn.Close()
            'MessageBox.Show("Connection closed.")
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        TextBoxpassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        ChildForm(Banking_Main.Panel1, Banking_Registration)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class