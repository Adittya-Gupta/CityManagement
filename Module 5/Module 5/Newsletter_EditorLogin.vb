Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Newsletter_EditorLogin

    Public Mysqlconn As New MySqlConnection
    Public sqlRd As MySqlDataReader
    Public sqlDt As New DataTable
    Public Dta As New MySqlDataAdapter
    Public SqlQuery As String

    ' Just change these to access local or online db

    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "newsdatabase"

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub
    Private Sub Newsletter_EditorLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(246, 246, 233)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim editor_username As String = TextBox1.Text
        Dim editor_password As String = TextBox2.Text

        If editor_username = "" Then
            MessageBox.Show("Enter approriate username")
            Return
        End If
        If editor_password = "" Then
            MessageBox.Show("Enter approriate password")
            Return
        End If
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_newsletter

        sqlDt.Clear()
        ' Open the connection
        Mysqlconn.Open()
        Dim query As String = "SELECT Password FROM admindata WHERE Username = '" & editor_username & "';"

        Dim cmd As MySqlCommand = New MySqlCommand(query, Mysqlconn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        sqlDt.Load(reader)

        Dim rowCount As Integer = sqlDt.Rows.Count

        If rowCount = 0 Then
            MessageBox.Show("You are not an editor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            reader.Close()
            'DataGridView1.DataSource = sqlDt
            Mysqlconn.Close() ' Close the connection after using it
            Return
        ElseIf rowCount > 1 Then
            MessageBox.Show("An error occurred in database. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            reader.Close()
            'DataGridView1.DataSource = sqlDt
            Mysqlconn.Close() ' Close the connection after using it
            Return
        Else
            If sqlDt.Rows(0)("Password").ToString() = editor_password.ToString() Then

                reader.Close()
                Mysqlconn.Close()

                ChildForm(Newsletter_Main.Panel1, Newsletter_Editor)
            Else
                reader.Close()
                Mysqlconn.Close()
                MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class