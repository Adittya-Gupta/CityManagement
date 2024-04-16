Imports System.CodeDom
Imports System.Data.SqlClient
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class Banking_LoanHomepage
    'Interest Rates- will be passed on every loans page
    Public Home_IR As Double = 6.75
    Public Edu_IR As Double = 10
    Public Busn_LowRisk_IR As Double = 11
    Public Busn_HighRisk_IR As Double = 19.8
    Public Transport_IR As Double = 7
    Public Personal_Medical_IR As Double = 10
    Public Personal_Otherwise_IR As Double = 17
    'user info
    Dim CIBIL_score As Double
    Public Balance As Double
    Public AC_no As String
    Public bank_username As String = "Robert" 'Will be passed on every banking page. Change to admin if reqd.
    'loan info for payment
    Public LoanID As Integer

    Public Mysqlconn As New MySqlConnection
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

    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "bankingdatabase"

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
                AC_no = reader.GetString("Bank_Account_Number")
            End If
        End Using
        Mysqlconn.Close()
        sqlCmd.Dispose()
    End Sub
    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Private Sub LoadFields()
        MessageBox.Show(AC_no)
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_banking

        sqlDt.Clear()
        ' Open the connection
        Mysqlconn.Open()

        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = Mysqlconn
        'Take join of 2 tables according to a/c no. Displaying all loans of current user.
        sqlCmd.CommandText = "SELECT * FROM BankLoanPlans " &
                      "JOIN BankLoanManagement " &
                      "ON BankLoanPlans.Loan_Plan_ID = BankLoanManagement.LoanPlanID " &
                      "WHERE BankLoanManagement.Bank_Account_Number = '" & AC_no & "';"

        Dim adapter As New MySqlDataAdapter(sqlCmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        CurrentLoans_table.DataSource = table  'Set DataSource property of the DataGridView

        Mysqlconn.Close()
        sqlCmd.Dispose()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '--------------obtain user info----------------
        bank_username = Global_Attributes.banking_username


        'CalculateBankAccNo()

        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_banking

        Mysqlconn.Open()   'Open the connection

        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = Mysqlconn
        'select the user info
        sqlCmd.CommandText = "SELECT Bank_Account_Number,Balance,CIBIL_score FROM BankUserData WHERE Username='" & bank_username & "';"
        Dim adapter As New MySqlDataAdapter(sqlCmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ' Check if the DataTable contains any rows
        If table.Rows.Count > 0 Then
            'MessageBox.Show("Loaded!")
            ' Retrieve the value from the first row and first column
            AC_no = table.Rows(0)("Bank_Account_Number").ToString()
            Balance = Double.Parse(table.Rows(0)("Balance").ToString())
            CIBIL_score = Double.Parse(table.Rows(0)("CIBIL_score").ToString())
        End If

        Mysqlconn.Close()
        sqlCmd.Dispose()

        'display balance and cibil score
        Balance_tb.Text = Balance.ToString()
        CIBILScore_tb.Text = CIBIL_score.ToString()
        ' Call the load_fields function here
        ' MessageBox.Show(banking_username)
        LoadFields()
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
            'Displaying all pending Loan Requests for current user.
            sqlCmd.CommandText = "SELECT * FROM BankQueryLog " &
                                "WHERE Bank_Account_Number='" & AC_no &
                                "' AND Type_of_Query='Loan request';"

            Dim adapter As New MySqlDataAdapter(sqlCmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            CurrentLoans_table.DataSource = table  'Set DataSource property of the DataGridView

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
        'pass all common variables
        Banking_LoansApplication.bank_username = bank_username
        Banking_LoansApplication.Home_IR = Home_IR
        Banking_LoansApplication.Edu_IR = Edu_IR
        Banking_LoansApplication.Busn_LowRisk_IR = Busn_LowRisk_IR
        Banking_LoansApplication.Busn_HighRisk_IR = Busn_HighRisk_IR
        Banking_LoansApplication.Transport_IR = Transport_IR
        Banking_LoansApplication.Personal_Medical_IR = Personal_Medical_IR
        Banking_LoansApplication.Personal_Otherwise_IR = Personal_Otherwise_IR

        'Open loans application page
        ChildForm(Banking_Main.Panel1, Banking_LoansApplication)
        'Me.Hide()
        ' Banking_LoansApplication.Show()
    End Sub

    Private Sub PayNow_btn_Click(sender As Object, e As EventArgs) Handles PayNow_btn.Click
        Banking_LoansPayNow.bank_username = bank_username
        Banking_LoansPayNow.AC_no = AC_no
        Banking_LoansPayNow.LoanID = LoanID
        Banking_LoansPayNow.Balance = Balance

        Banking_LoansPayNow.Home_IR = Home_IR
        Banking_LoansPayNow.Edu_IR = Edu_IR
        Banking_LoansPayNow.Busn_LowRisk_IR = Busn_LowRisk_IR
        Banking_LoansPayNow.Busn_HighRisk_IR = Busn_HighRisk_IR
        Banking_LoansPayNow.Transport_IR = Transport_IR
        Banking_LoansPayNow.Personal_Medical_IR = Personal_Medical_IR
        Banking_LoansPayNow.Personal_Otherwise_IR = Personal_Otherwise_IR
        ChildForm(Banking_Main.Panel1, Banking_LoansPayNow)
        'Open loans payment page
        'Me.Hide()
        'Banking_LoansPayNow.Show()
    End Sub

    Private Sub CurrentLoans_table_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CurrentLoans_table.CellContentClick
        ' Check if the clicked cell is valid and not the header cell
        If TableTitle.Text = "Current Loans:" And e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the loan ID from the selected row
            Dim temp As String = CurrentLoans_table.Rows(e.RowIndex).Cells("Loan_Plan_ID").Value.ToString()
            LoanID = Integer.Parse(temp)
            ' Print debug output of LoanID
            System.Diagnostics.Debug.WriteLine("LoanID, home page: " & LoanID)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        LoadFields()
    End Sub
End Class