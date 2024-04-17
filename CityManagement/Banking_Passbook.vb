Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Banking_Passbook

    Public Mysqlconn As New MySqlConnection
    'Public sqlCmd As New MySqlCommand
    Public sqlRd As MySqlDataReader
    Public sqlDt As New DataTable
    Public Dta As New MySqlDataAdapter
    Public SqlQuery As String

    ' Just change these to access local or online db
    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "bankingdatabase"

    ' Public server As String = "172.16.114.244"
    ' Public username As String = "admin"
    ' Public password As String = "nimda"
    ' Public database As String = "banking_database"

    Public bank_account_no As String = "1"
    Public bank_username As String = Global_Attributes.banking_username

    Private Sub ClearFields()
        Label16.Text = ""
        Label17.Text = ""
        Label18.Text = ""
        Label19.Text = ""
        Label20.Text = ""
        Label21.Text = ""
        Label22.Text = ""
    End Sub
    Private Sub CalculateBankAccNo()
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_banking

        sqlDt.Clear()
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "Select Bank_Account_Number from BankUserData where Username = '" & bank_username & "';"
        Using reader As MySqlDataReader = sqlCmd.ExecuteReader()
            If reader.Read() Then
                bank_account_no = reader.GetString("Bank_Account_Number")
            End If
        End Using
        Mysqlconn.Close()
        sqlCmd.Dispose()
    End Sub

    Private Sub LoadFields()
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_banking
        sqlDt.Clear()
        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand

        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "Select * from BankUserData where Bank_Account_Number = @BAC;"

        sqlCmd.Parameters.Add("@BAC", MySqlDbType.VarChar).Value = bank_account_no


        Dim adapter As New MySqlDataAdapter(sqlCmd)
        Dim table As New DataTable()


        adapter.Fill(table)

        If table.Rows.Count = 1 Then
            Label7.Text = table.Rows(0)("Balance").ToString()
            Label8.Text = table.Rows(0)("CIBIL_Score").ToString()
        Else
            MessageBox.Show("Error has occured")
        End If
        Mysqlconn.Close()
        sqlCmd.Dispose()
    End Sub
    Private Sub ClearDataGrid()
        For Each row As DataGridViewRow In DataGridView1.Rows
            DataGridView1.Rows.Remove(row)
        Next
    End Sub
    Private Sub RefreshDataGrid()
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
        ' Set the connection string property
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_banking
        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand
        sqlDt.Clear()

        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "SELECT * FROM BankTransactionLog where Bank_Account_Number = @BAC;"

        sqlCmd.Parameters.Add("@BAC", MySqlDbType.VarChar).Value = bank_account_no

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()

        ' Close the connection after use
        Mysqlconn.Close()
        sqlCmd.Dispose()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.DataSource = sqlDt
    End Sub
    'Make this form full screen
    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        banking_username = Global_Attributes.banking_username
        CalculateBankAccNo()
        RefreshDataGrid()
        ClearFields()
        LoadFields()
        TextBox1.Text = bank_account_no

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex >= 0 Then
            'If Not, exit the event handler without performing any action
            'MessageBox.Show("Error")
            Return
        End If

        Dim Trans_ID As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString


        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_banking

        sqlDt.Clear()
        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand


        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "Select * from BankTransactionLog where Transaction_ID = @ID;"

        sqlCmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Trans_ID


        Dim adapter As New MySqlDataAdapter(sqlCmd)
        Dim table As New DataTable()


        adapter.Fill(table)

        If table.Rows.Count = 1 Then
            Label16.Text = table.Rows(0)(0).ToString()
            Label17.Text = table.Rows(0)(4).ToString()
            Label18.Text = table.Rows(0)(2).ToString()
            Label19.Text = table.Rows(0)(1).ToString()
            Label20.Text = table.Rows(0)(3).ToString()
            Label21.Text = table.Rows(0)(5).ToString()
            Label22.Text = table.Rows(0)(6).ToString()

        Else
            MessageBox.Show("Error has occured")
        End If
        Mysqlconn.Close()
        sqlCmd.Dispose()
        RefreshDataGrid()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label22_Click_1(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        RefreshDataGrid()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class