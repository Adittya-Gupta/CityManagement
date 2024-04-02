Public Class Banking_LoansPayNow
    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Private Sub PayNow_btn_Click(sender As Object, e As EventArgs) Handles PayNow_btn.Click
        'redirect to money transfer page
        'Me.Hide()
        'Money_Management_Homepage.Show()

        ChildForm(Banking_Main.Panel1, Money_Management_Homepage)
    End Sub
End Class