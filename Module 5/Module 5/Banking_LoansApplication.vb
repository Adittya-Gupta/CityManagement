Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Banking_LoansApplication
    Public loan_type As String = "Home"

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Private Sub HomeLoan_btn_Click(sender As Object, e As EventArgs) Handles HomeLoan_btn.Click
        loan_type = "Home"
        'Me.Hide()
        'Banking_LoanDetails.Show()

        'ChildForm(Banking_Main.Panel1, Banking_LoanDetails)
    End Sub

    Private Sub EduLoan_btn_Click(sender As Object, e As EventArgs) Handles EduLoan_btn.Click
        loan_type = "Education"
        'Me.Hide()
        'Banking_LoanDetails.Show()

        ' ChildForm(Banking_Main.Panel1, Banking_LoanDetails)
    End Sub

    Private Sub PersLoan_btn_Click(sender As Object, e As EventArgs) Handles PersLoan_btn.Click
        loan_type = "Personal"
        'Me.Hide()
        'Banking_LoanDetails.Show()

        ' ChildForm(Banking_Main.Panel1, Banking_LoanDetails)
    End Sub

    Private Sub TranspLoan_btn_Click(sender As Object, e As EventArgs) Handles TranspLoan_btn.Click
        loan_type = "Transport"
        'Me.Hide()
        'Banking_LoanDetails.Show()

        '  ChildForm(Banking_Main.Panel1, Banking_LoanDetails)
    End Sub

    Private Sub BusnLoan_btn_Click(sender As Object, e As EventArgs) Handles BusnLoan_btn.Click
        loan_type = "Business"
        'Me.Hide()
        'Banking_LoanDetails.Show()

        'ChildForm(Banking_Main.Panel1, Banking_LoanDetails)
    End Sub
End Class