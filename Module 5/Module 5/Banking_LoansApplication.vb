Public Class Banking_LoansApplication
    Public loan_type As String = "Home"

    Private Sub HomeLoan_btn_Click(sender As Object, e As EventArgs) Handles HomeLoan_btn.Click
        loan_type = "Home"
        Me.Hide()
        Banking_LoanDetails.Show()
    End Sub

    Private Sub EduLoan_btn_Click(sender As Object, e As EventArgs) Handles EduLoan_btn.Click
        loan_type = "Education"
        Me.Hide()
        Banking_LoanDetails.Show()
    End Sub

    Private Sub PersLoan_btn_Click(sender As Object, e As EventArgs) Handles PersLoan_btn.Click
        loan_type = "Personal"
        Me.Hide()
        Banking_LoanDetails.Show()
    End Sub

    Private Sub TranspLoan_btn_Click(sender As Object, e As EventArgs) Handles TranspLoan_btn.Click
        loan_type = "Transport"
        Me.Hide()
        Banking_LoanDetails.Show()
    End Sub

    Private Sub BusnLoan_btn_Click(sender As Object, e As EventArgs) Handles BusnLoan_btn.Click
        loan_type = "Business"
        Me.Hide()
        Banking_LoanDetails.Show()
    End Sub

    Private Sub Loans_btn_Click(sender As Object, e As EventArgs) Handles Loans_btn.Click
        Me.Hide()
        Banking_LoanHomepage.Show()
    End Sub
End Class