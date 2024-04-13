Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Banking_Admin_Login

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Private sqlConn As New MySqlConnection
    'Private connectionString As String = "server=localhost;user id=root;password=12345678;database=bankingdatabase;"
    'Private connectionString As String = "server=localhost;userid=root;password=Aasneh18;database=bankingdatabase;"
    Private connectionString As String = Global_Attributes.slqConnection_banking

    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        Dim username As String = Username_TextBox.Text.Trim()
        Dim password As String = Password_TextBox.Text.Trim()

        Try
            Using sqlConn As New MySqlConnection(connectionString)
                sqlConn.Open()

                Dim query As String = "SELECT COUNT(*) FROM Admindata WHERE Username = @Username AND Password = @Password"
                Using cmd As New MySqlCommand(query, sqlConn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Proceed to the next form or perform other actions
                        ChildForm(Banking_Main.Panel1, Banking_Panel)
                    Else
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Banking_Admin_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
