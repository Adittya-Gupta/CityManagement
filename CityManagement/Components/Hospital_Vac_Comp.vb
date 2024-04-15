Imports MySql.Data.MySqlClient

Public Class Hospital_Vac_Comp
    Private _parentForm As Form
    Private _hos_id As Integer
    Private _description As String

    Public Sub New(ParentForm As Form, ByVal hos_id As Integer, ByVal department As String, ByVal vacancyCount As Integer, ByVal description As String)
        InitializeComponent()

        _parentForm = ParentForm
        _hos_id = hos_id
        _description = description

        ' Set the values of the components based on the parameters
        Label2.Text = hos_id.ToString()
        Label3.Text = department
        Label6.Text = vacancyCount.ToString()
        Label1.Text = "Description :"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim childForm As New Hos_Desc_Form(_description)
        '_parentForm.Controls.Add(childUserControl)
        childForm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hosID As Integer = CType(sender, Button).Tag

        ' Remove the entry from the database using the user ID
        Dim success As Boolean = RemoveEntryFromDatabase(hosID)

        If success Then
            MsgBox("Vacancy removed from the database")
        Else
            MsgBox("Failed to remove the Vacancy")
        End If
    End Sub

    Private Function RemoveEntryFromDatabase(hosID As Integer) As Boolean
        ' Execute a MySQL delete query to remove the entry from the database
        Dim connectionString As String = Module1.connString
        'Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Dim query As String = "DELETE FROM hospitalVacancy WHERE hos_id = @hos_id"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Replace @user_id with the actual user_id of the entry to be removed
                command.Parameters.AddWithValue("@hos_id", hosID)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' If at least one row is affected, the entry was successfully deleted
                    Return rowsAffected > 0
                Catch ex As Exception
                    ' Handle any exceptions
                    MsgBox("Error: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function
End Class
