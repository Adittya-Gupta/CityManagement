Public Class Banking_LoanDetails
    Private Sub Submit_btn_Click(sender As Object, e As EventArgs) Handles Submit_btn.Click
        'do form validation
        Name_tb.Clear()
        ACno_tb.Clear()
        Purpose_tb.Clear()
        CIBILscore_tb.Clear()
        Email_tb.Clear()
        Aadhar_tb.Clear()
        Principal_tb.Clear()
        InterestRate_tb.Clear()
        Duration_tb.Clear()

        MessageBox.Show("Submit Success!")
    End Sub

    Private Sub Loans_btn_Click(sender As Object, e As EventArgs) Handles Loans_btn.Click
        Me.Hide()
        Banking_LoanHomepage.Show()
    End Sub
End Class