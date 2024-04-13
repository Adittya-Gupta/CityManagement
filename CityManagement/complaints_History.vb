Imports System.Reflection.Emit
Imports MySql.Data.MySqlClient
Public Class complaints_History
    Private Sub complaints_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userID As String = "11"
        Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Using connection As New MySqlConnection(connString)

            Dim conn As New MySqlConnection(connString)
            Try

                Dim query As String = "SELECT * FROM Complaints WHERE from_user_id = @userID"

                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@userID", userID)

                Dim dataAdapter As New MySqlDataAdapter(command)

                Dim dataTable As New DataTable
                dataAdapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable
                DataGridView1.AllowUserToAddRows = False
                DataGridView1.RowHeadersVisible = False
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                DataGridView1.ScrollBars = ScrollBars.Vertical
                'Dim newColumn As New DataGridViewButtonColumn()
                'newColumn.Name = "Cancel Leave"
                'newColumn.UseColumnTextForButtonValue = True
                'newColumn.Text = "Cancel"
                'newColumn.DefaultCellStyle.BackColor = Color.Crimson
                'newColumn.DefaultCellStyle.SelectionBackColor = Color.Crimson
                'newColumn.DefaultCellStyle.ForeColor = Color.White
                'newColumn.DefaultCellStyle.SelectionForeColor = Color.White
                'newColumn.FlatStyle = FlatStyle.Flat
                'DataGridView1.Columns.Add(newColumn)

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class