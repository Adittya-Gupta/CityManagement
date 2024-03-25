Imports System.CodeDom

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

    Private Sub PendingRequests_btn_Click(sender As Object, e As EventArgs) Handles PendingRequests_btn.Click
        'Display pending requests in the same table, with same headers
    End Sub

    Private Sub Home_btn_Click(sender As Object, e As EventArgs) Handles Home_btn.Click
        'redirect to home page
    End Sub

    Private Sub Loans_btn_Click(sender As Object, e As EventArgs) Handles Loans_btn.Click
        'redirect to loans home page
    End Sub

    Private Sub MoneyTransfer_btn_Click(sender As Object, e As EventArgs) Handles MoneyTransfer_btn.Click
        'redirect to money transfer page
    End Sub

    Private Sub Passbook_btn_Click(sender As Object, e As EventArgs) Handles Passbook_btn.Click
        'redirect to passbook page
    End Sub

    Private Sub ContactUs_btn_Click(sender As Object, e As EventArgs) Handles ContactUs_btn.Click
        'redirect to complaints page
    End Sub

    Private Sub Logout_btn_Click(sender As Object, e As EventArgs) Handles Logout_btn.Click
        'logout and redirect to login page
    End Sub

    Private Sub ApplyNow_btn_Click(sender As Object, e As EventArgs) Handles ApplyNow_btn.Click
        'Open loans apply page
    End Sub
<<<<<<< HEAD:Module 5/Module 5/Banking_LoansHomepage.vb

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
=======
>>>>>>> 7a0b7499ca40b7f46c7ff5ff947adc5d1360e87d:Banking Module/Banking/Banking_LoansHomepage.vb
End Class