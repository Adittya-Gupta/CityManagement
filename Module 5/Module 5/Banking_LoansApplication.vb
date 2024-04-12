Public Class Banking_LoansApplication

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

    Public loan_type As String
    Public bank_username As String
    'Interest Rates- will be passed on every loans page
    Public Home_IR As Double
    Public Edu_IR As Double
    Public Busn_LowRisk_IR As Double
    Public Busn_HighRisk_IR As Double
    Public Transport_IR As Double
    Public Personal_Medical_IR As Double
    Public Personal_Otherwise_IR As Double

    Private Sub HomeLoan_btn_Click(sender As Object, e As EventArgs) Handles HomeLoan_btn.Click
        loan_type = "Home"

        'pass the common variables
        Banking_LoanDetails.bank_username = bank_username
        Banking_LoanDetails.loan_type = loan_type
        Banking_LoanDetails.Home_IR = Home_IR
        Banking_LoanDetails.Edu_IR = Edu_IR
        Banking_LoanDetails.Busn_LowRisk_IR = Busn_LowRisk_IR
        Banking_LoanDetails.Busn_HighRisk_IR = Busn_HighRisk_IR
        Banking_LoanDetails.Transport_IR = Transport_IR
        Banking_LoanDetails.Personal_Medical_IR = Personal_Medical_IR
        Banking_LoanDetails.Personal_Otherwise_IR = Personal_Otherwise_IR

        'Open the loan application detail-filling page
        ChildForm(Banking_Main.Panel1, Banking_LoanDetails)
        'Me.Hide()
        'Banking_LoanDetails.Show()
    End Sub

    Private Sub EduLoan_btn_Click(sender As Object, e As EventArgs) Handles EduLoan_btn.Click
        loan_type = "Education"

        'pass the common variables
        Banking_LoanDetails.bank_username = bank_username
        Banking_LoanDetails.loan_type = loan_type
        Banking_LoanDetails.Home_IR = Home_IR
        Banking_LoanDetails.Edu_IR = Edu_IR
        Banking_LoanDetails.Busn_LowRisk_IR = Busn_LowRisk_IR
        Banking_LoanDetails.Busn_HighRisk_IR = Busn_HighRisk_IR
        Banking_LoanDetails.Transport_IR = Transport_IR
        Banking_LoanDetails.Personal_Medical_IR = Personal_Medical_IR
        Banking_LoanDetails.Personal_Otherwise_IR = Personal_Otherwise_IR

        'Open the loan application detail-filling page
        ChildForm(Banking_Main.Panel1, Banking_LoanDetails)
        'Me.Hide()
        'Banking_LoanDetails.Show()
    End Sub

    Private Sub PersLoan_btn_Click(sender As Object, e As EventArgs) Handles PersLoan_btn.Click
        loan_type = "Personal"

        'pass the common variables
        Banking_LoanDetails.bank_username = bank_username
        Banking_LoanDetails.loan_type = loan_type
        Banking_LoanDetails.Home_IR = Home_IR
        Banking_LoanDetails.Edu_IR = Edu_IR
        Banking_LoanDetails.Busn_LowRisk_IR = Busn_LowRisk_IR
        Banking_LoanDetails.Busn_HighRisk_IR = Busn_HighRisk_IR
        Banking_LoanDetails.Transport_IR = Transport_IR
        Banking_LoanDetails.Personal_Medical_IR = Personal_Medical_IR
        Banking_LoanDetails.Personal_Otherwise_IR = Personal_Otherwise_IR

        'Open the loan application detail-filling page
        ChildForm(Banking_Main.Panel1, Banking_LoanDetails)
        'Me.Hide()
        'Banking_LoanDetails.Show()
    End Sub

    Private Sub TranspLoan_btn_Click(sender As Object, e As EventArgs) Handles TranspLoan_btn.Click
        loan_type = "Transport"

        'pass the common variables
        Banking_LoanDetails.bank_username = bank_username
        Banking_LoanDetails.loan_type = loan_type
        Banking_LoanDetails.Home_IR = Home_IR
        Banking_LoanDetails.Edu_IR = Edu_IR
        Banking_LoanDetails.Busn_LowRisk_IR = Busn_LowRisk_IR
        Banking_LoanDetails.Busn_HighRisk_IR = Busn_HighRisk_IR
        Banking_LoanDetails.Transport_IR = Transport_IR
        Banking_LoanDetails.Personal_Medical_IR = Personal_Medical_IR
        Banking_LoanDetails.Personal_Otherwise_IR = Personal_Otherwise_IR

        'Open the loan application detail-filling page
        ChildForm(Banking_Main.Panel1, Banking_LoanDetails)
        'Me.Hide()
        ' Banking_LoanDetails.Show()
    End Sub

    Private Sub BusnLoan_btn_Click(sender As Object, e As EventArgs) Handles BusnLoan_btn.Click
        loan_type = "Business"

        'pass the common variables
        Banking_LoanDetails.bank_username = bank_username
        Banking_LoanDetails.loan_type = loan_type
        Banking_LoanDetails.Home_IR = Home_IR
        Banking_LoanDetails.Edu_IR = Edu_IR
        Banking_LoanDetails.Busn_LowRisk_IR = Busn_LowRisk_IR
        Banking_LoanDetails.Busn_HighRisk_IR = Busn_HighRisk_IR
        Banking_LoanDetails.Transport_IR = Transport_IR
        Banking_LoanDetails.Personal_Medical_IR = Personal_Medical_IR
        Banking_LoanDetails.Personal_Otherwise_IR = Personal_Otherwise_IR

        'Open the loan application detail-filling page
        ChildForm(Banking_Main.Panel1, Banking_LoanDetails)
        'Me.Hide()
        'Banking_LoanDetails.Show()
    End Sub

    'Private Sub Loans_btn_Click(sender As Object, e As EventArgs)
    '    Banking_LoanHomepage.bank_username = bank_username
    'Me.Hide()
    '    Banking_LoanHomepage.Show()
    'End Sub

    Private Sub Banking_LoansApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bank_username = Global_Attributes.banking_username

    End Sub
End Class