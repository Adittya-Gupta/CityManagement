Imports Google.Protobuf.WellKnownTypes
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Banking_LoansPayNow
    Public bank_username As String
    Public AC_no As String
    Public LoanID As Integer
    Public Balance As Double
    'Interest Rates- will be passed on every loans page
    Public Home_IR As Double
    Public Edu_IR As Double
    Public Busn_LowRisk_IR As Double
    Public Busn_HighRisk_IR As Double
    Public Transport_IR As Double
    Public Personal_Medical_IR As Double
    Public Personal_Otherwise_IR As Double

    'loan repayment info
    Dim Principal As Double
    Dim InterestRate As Double
    Dim LoanType As String
    Dim TimePeriod As Double
    Dim StartDate As Date

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
    ' Public database As String = "banking_database"

    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "bankingdatabase"

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Private Sub Banking_LoansPayNow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bank_username = Global_Attributes.banking_username

        ' Print debug output of LoanID
        System.Diagnostics.Debug.WriteLine("LoanID, paynow page: " & LoanID)

        '--------------obtain loan payment info----------------
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_banking

        Mysqlconn.Open()   'Open the connection

        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = Mysqlconn
        'select the loan info required
        'sqlCmd.CommandText = "SELECT Loan_Type, Amount, Interest_Rate, Period" &
        '"FROM banking_database.loanplans " &
        '"WHERE Loan_Plan_ID=" & LoanID.ToString() & ";"

        sqlCmd.CommandText = "SELECT Loan_Type, Amount, Interest_Rate, Period, Start_Date " &
                     "FROM loanplans JOIN loanmanagement " &
                     "ON loanplans.Loan_Plan_ID = loanmanagement.LoanPlanID " &
                     "WHERE Loan_Plan_ID = @LoanID AND Bank_Account_Number = @AC_no;"

        ' Add parameter to the SqlCommand
        sqlCmd.Parameters.AddWithValue("@LoanID", LoanID)
        sqlCmd.Parameters.AddWithValue("@AC_no", AC_no)

        Dim adapter As New MySqlDataAdapter(sqlCmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ' Check if the DataTable contains any rows
        If table.Rows.Count > 0 Then
            ' Retrieve the value from the first row and first column
            Principal = Double.Parse(table.Rows(0)("Amount").ToString())
            InterestRate = Double.Parse(table.Rows(0)("Interest_Rate").ToString())
            LoanType = table.Rows(0)("Loan_Type").ToString()
            TimePeriod = Double.Parse(table.Rows(0)("Period").ToString())
            StartDate = Date.Parse(table.Rows(0)("Start_Date").ToString())
        End If

        Mysqlconn.Close()
        sqlCmd.Dispose()

        '----------------autofill info in payment details page----------------------------------
        RichTextBox1.Text = Principal.ToString()
        RichTextBox4.Text = InterestRate.ToString()

        Dim amt_due As Double = Principal + (Principal * InterestRate * 0.01 * TimePeriod) 'calculate amount due = P+SI
        RichTextBox5.Text = amt_due.ToString()

        RadioButton1.Checked = True 'pay full amt
        RichTextBox3.Text = amt_due.ToString() 'amount due

        RichTextBox2.Text = "0"   'amount pending
        RichTextBox6.Text = LoanID.ToString()  'loan id
        RichTextBox7.Text = LoanType  'loan type
        RichTextBox8.Text = TimePeriod.ToString & "years"  'maturation period
        RichTextBox10.Text = StartDate.ToString()

        Dim EndDate As Date
        Dim yrs_to_add As Integer = CInt(Math.Floor(TimePeriod))
        Dim months_to_add As Integer = CInt(Math.Floor((TimePeriod - Math.Floor(TimePeriod)) * 12))

        ' Add the integral number of years
        EndDate = StartDate.AddYears(yrs_to_add)
        ' Add the fractional number of months, converted to integer
        EndDate = EndDate.AddMonths(months_to_add)
        RichTextBox9.Text = EndDate.ToString()

    End Sub

    Private Sub Loans_btn_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        Banking_LoanHomepage.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton2.Checked = Not RadioButton1.Checked 'they should be opposite
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton1.Checked = Not RadioButton2.Checked 'they should be opposite
        'handle partial amount
        RichTextBox3.Clear()
        RichTextBox2.Clear()
    End Sub

    Private Sub PayNow_btn_Click(sender As Object, e As EventArgs) Handles PayNow_btn.Click
        'perform validation checks
        Dim flag As Boolean = True
        Dim x As Double
        If Double.TryParse(RichTextBox3.Text, x) And x > Balance Then 'if amt to be paid exceeds balance
            flag = False
            MessageBox.Show("The amount you are trying to pay is more than your current account balance.")
        ElseIf Double.TryParse(RichTextBox2.Text, x) And x < 0 Then 'if amt pending is -ve
            flag = False
            MessageBox.Show("The amount you are trying to pay is more than your loan amount due.")
        ElseIf Double.TryParse(RichTextBox3.Text, x) And x <= 0 Then
            flag = False
            MessageBox.Show("Please enter a non-zero amount to be paid.")
        End If

        If flag = True Then
            'pass all common variables
            'Money_Management_Homepage.bank_username = bank_username
            'Money_Management_Homepage.bank_username = bank_username 'amount to be paid
            'Money_Management_Homepage.bank_username = bank_username 'bank's account number

            'redirect to money transfer page
            Global_Attributes.banking_payment_amount = Double.Parse(RichTextBox3.Text)
            Global_Attributes.banking_recv_username = "bank"
            ChildForm(Banking_Main.Panel1, Banking_Money_Management_Homepage)
            ' Me.Hide()
            'Money_Management_Homepage.Show()
        End If
    End Sub

    Private Sub RichTextBox3_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox3.TextChanged
        'when user enters amount he wants to pay, update pending amount
        Dim amt_pending, X, Y As Double
        If RadioButton2.Checked = True And Double.TryParse(RichTextBox5.Text, X) And Double.TryParse(RichTextBox3.Text, Y) Then
            amt_pending = X - Y
            RichTextBox2.Text = amt_pending.ToString()
        End If
    End Sub
End Class