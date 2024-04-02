Imports System.CodeDom
Imports System.Data.SqlClient
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class Banking_LoanHomepage
    'On loading this form, obtain interest rates, table, balance, CIBIL score from DB

    'Interest Rates
    Dim Home_IR As Double = 6.75
    Dim Edu_IR As Double = 10
    Dim Busn_LowRisk_IR As Double = 11
    Dim Busn_HighRisk_IR As Double = 19.8
    Dim Transport_IR As Double = 7
    Dim Personal_Medical_IR As Double = 10
    Dim Personal_Otherwise_IR As Double = 17
    Public CIBIL_score As Double = 402.6
    Public Balance As Double = 12090.5

    Public Mysqlconn As New MySqlConnection
    'Public sqlCmd As New MySqlCommand
    Public sqlRd As MySqlDataReader
    Public sqlDt As New DataTable
    Public Dta As New MySqlDataAdapter
    Public SqlQuery As String

    'Public server As String = "172.16.114.244"
    'Public username As String = "admin"
    'Public password As String = "nimda"
    'Public database As String = "banking_database"

    'Public server As String = "localhost"
    'Public username As String = "root"
    'Public password As String = "vacuum#28C"
    'Public database As String = "banking_database"


    Public bank_account_no As Integer = 1
    Public bank_username As String = "admin"

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Call the load_table function here
        LoadFields()
        Balance_tb.Text = Balance.ToString()
        CIBILScore_tb.Text = CIBIL_score.ToString()
    End Sub

    Private Sub LoadFields()
        Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        sqlDt.Clear()
        ' Open the connection
        Mysqlconn.Open()

        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = Mysqlconn
        'for now, displaying all rows, later take join of 2 tables acc to a/c no
        sqlCmd.CommandText = "Select * from banking_database.loanplans;"
        'sqlCmd.Parameters.Add("@BAC", MySqlDbType.Int64).Value = bank_account_no

        Dim adapter As New MySqlDataAdapter(sqlCmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ' Set the DataSource property of the DataGridView
        CurrentLoans_table.DataSource = table

        'get user data
        'Dim sqlCmd1 As New MySqlCommand
        'sqlCmd1.Connection = Mysqlconn
        'for now, displaying all rows, later take join of 2 tables acc to a/c no
        'sqlCmd1.CommandText = "Select * from banking_database.loanplans;"
        'sqlCmd.Parameters.Add("@BAC", MySqlDbType.Int64).Value = bank_account_no

        'Dim adapter1 As New MySqlDataAdapter(sqlCmd)
        'Dim table1 As New DataTable()
        'sqlCmd1.CommandText = "Select * from banking_database.userdata;"
        'adapter1.Fill(table1)

        'get balance and cibil score, not authenticated user yet- to do later
        'If table1.Rows.Count = 1 Then
        'Balance_tb.Text = table1.Rows(0)(8).ToString()
        'LScore_tb.Text = table1.Rows(0)(9).ToString()
        'Else
        'MessageBox.Show("Error has occured")
        'End If

        Mysqlconn.Close()
        sqlCmd.Dispose()
        'sqlCmd1.Dispose()
    End Sub

    Private Sub PendingRequests_btn_Click(sender As Object, e As EventArgs) Handles PendingRequests_btn.Click
        'toggle between button text
        If PendingRequests_btn.Text = "View Pending Requests" Then
            TableTitle.Text = "Pending Requests:"
            PendingRequests_btn.Text = "View Current Loans"

            'Display pending requests in the same table
            Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
            sqlDt.Clear()
            ' Open the connection
            Mysqlconn.Open()
            Dim sqlCmd As New MySqlCommand

            sqlCmd.Connection = Mysqlconn
            'for now, displaying all rows, later take join of 2 tables acc to acc no
            sqlCmd.CommandText = "Select * from banking_database.querylog;"

            'sqlCmd.Parameters.Add("@BAC", MySqlDbType.Int64).Value = bank_account_no

            Dim adapter As New MySqlDataAdapter(sqlCmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            ' Set the DataSource property of the DataGridView
            CurrentLoans_table.DataSource = table

            Mysqlconn.Close()
            sqlCmd.Dispose()
        ElseIf PendingRequests_btn.Text = "View Current Loans" Then
            TableTitle.Text = "Current Loans:"
            PendingRequests_btn.Text = "View Pending Requests"
            'load current loans
            LoadFields()
        End If

    End Sub

    Private Sub ApplyNow_btn_Click(sender As Object, e As EventArgs) Handles ApplyNow_btn.Click
        'Open loans application page
        'Me.Hide()
        'Banking_LoansApplication.Show()

        ChildForm(Banking_Main.Panel1, Banking_LoansApplication)
    End Sub

    Private Sub PayNow_btn_Click(sender As Object, e As EventArgs) Handles PayNow_btn.Click
        'Open loans payment page
        'Me.Hide()
        'Banking_LoansPayNow.Show()

        ChildForm(Banking_Main.Panel1, Banking_LoansPayNow)
    End Sub
End Class