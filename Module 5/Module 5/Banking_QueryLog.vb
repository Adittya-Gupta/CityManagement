Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Banking_QueryLog


    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String

    'Dim server As String = "localhost"
    'Dim username As String = "root"
    ' Dim password As String = "12345678"
    ' Dim database As String = "bankingdatabase"

    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "bankingdatabase"

    Dim Query_ID_Loan As String
    Dim Bank_Account_Number_Loan As String
    Dim Type_of_Query_Loan As String
    Dim Day_Loan As String
    Dim Query_Loan As String
    Dim Status_Loan As String
    Dim Reply_Loan As String


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
            'sqlConn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
            sqlConn.ConnectionString = Global_Attributes.slqConnection_banking

            ' Open the connection
            sqlConn.Open()

            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "SELECT * FROM QueryLog WHERE Type_of_Query !='Loan request' AND Status='Pending'"

            sqlRd = sqlCmd.ExecuteReader
            sqlDt.Clear()
            sqlDt.Load(sqlRd)
            sqlRd.Close()

            ' Close the connection after use
            sqlConn.Close()

            'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.ScrollBars = ScrollBars.Both
            DataGridView1.DataSource = sqlDt

        Catch ex As Exception
            MessageBox.Show("Error updating table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Banking_QueryLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Query_ID_Loan = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            Bank_Account_Number_Loan = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            Type_of_Query_Loan = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            Day_Loan = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            Query_Loan = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            Status_Loan = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
            Reply_Loan = DataGridView1.SelectedRows(0).Cells(6).Value.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub Refresh_Button_Click(sender As Object, e As EventArgs) Handles Refresh_Button.Click
        updateTable()
    End Sub

    Private Sub Resolve_Button_Click(sender As Object, e As EventArgs) Handles Resolve_Button.Click
        Try
            'sqlConn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
            sqlConn.ConnectionString = Global_Attributes.slqConnection_banking

            sqlConn.Open()

            sqlCmd.Connection = sqlConn

            With sqlCmd
                .CommandText = "UPDATE QueryLog SET Bank_Account_Number=@Bank_Account_Number, Type_of_Query=@Type_of_Query, Day=CURDATE(), Query=@Query, Status=@Status, Reply=@Reply WHERE Query_ID=@Query_ID"
                .CommandType = CommandType.Text

                .Parameters.Clear()
                Status_Loan = "Approved"
                Reply_Loan = "Query Resolved!"

                ' Add parameters within the With block only
                .Parameters.AddWithValue("@Query_ID", Query_ID_Loan)
                .Parameters.AddWithValue("@Bank_Account_Number", Bank_Account_Number_Loan)
                .Parameters.AddWithValue("@Type_of_Query", Type_of_Query_Loan)
                .Parameters.AddWithValue("@Day", Day_Loan)
                .Parameters.AddWithValue("@Query", Query_Loan)
                .Parameters.AddWithValue("@Status", Status_Loan)
                .Parameters.AddWithValue("@Reply", Reply_Loan)


                ' Execute the command
                .ExecuteNonQuery()

                ' Clear parameters for next update operation
                .Parameters.Clear()
            End With


            MessageBox.Show("New record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)




            ' Refresh DataGridView to reflect the updated data
            updateTable()


        Catch ex As Exception
            MessageBox.Show("Error adding new record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try
    End Sub
End Class