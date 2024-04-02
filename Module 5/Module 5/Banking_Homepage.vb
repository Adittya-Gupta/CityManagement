Public Class Banking_Homepage
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
    Private Sub Banking_Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        'Banking_Homepage.bank_username = bank_username
        ChildForm(Banking_Main.Panel1, Login)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ChildForm(Banking_Main.Panel1, Registration)
    End Sub
End Class