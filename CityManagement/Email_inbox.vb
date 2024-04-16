Public Class Email_inbox


    Public Property username_test As String

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String


    'Dim server As String = "localhost"
    'Dim username As String = "root"
    ' Dim password As String = "12345678"
    ' Dim database As String = "emaildatabase"

    Public server As String = "MYSQL9001.site4now.net"
    Public username As String = "aa78df_scms"
    Public password As String = "abcd1234"
    Public database As String = "db_aa78df_scms"

    ' Dim username_test As String = "achyut@gmail.com"
    'Dim username_test As String = Email_Landing.User_EmailID



    Private Sub updateTable()
        Try
            ' Close the connection before modifying the connection string property
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next

            ' Set the connection string property
            'sqlConn.ConnectionString = "server=MYSQL9001.site4now.net;userid=aa78df_scms;Password=abcd1234;database=db_aa78df_scms;sslmode=none"
            sqlConn.ConnectionString = GlobalConnString.str

            ' Open the connection
            sqlConn.Open()

            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "SELECT * FROM EmailsData WHERE Email_To=@Email_To"
            sqlCmd.CommandType = CommandType.Text
            sqlCmd.Parameters.AddWithValue("@Email_To", username_test)

            sqlRd = sqlCmd.ExecuteReader
            sqlCmd.Parameters.Clear()


            sqlDt.Clear()
            sqlDt.Load(sqlRd)
            sqlRd.Close()

            ' Close the connection after use
            sqlConn.Close()

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.ScrollBars = ScrollBars.Both
            DataGridView1.DataSource = sqlDt

        Catch ex As Exception
            MessageBox.Show("Error updating table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub Email_inbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is in the leftmost column
        If e.ColumnIndex >= 0 Then
            ' If not, exit the event handler without performing any action
            Return
        End If

        ' Now proceed to load data into text boxes only if the clicked cell is in the leftmost column
        Try
            From_TextBox.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            Subject_TextBox.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            Content_TextBox.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Refresh_Button_Click(sender As Object, e As EventArgs)
        updateTable()
    End Sub


End Class