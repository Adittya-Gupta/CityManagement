Public Class Banking_LoansPayNow
    Private Sub PayNow_btn_Click(sender As Object, e As EventArgs) Handles PayNow_btn.Click
        'redirect to money transfer page
        Me.Hide()
        Money_Management_Homepage.Show()
    End Sub

    Private Sub Loans_btn_Click(sender As Object, e As EventArgs) Handles Loans_btn.Click
        Me.Hide()
        Banking_LoanHomepage.Show()
    End Sub
End Class