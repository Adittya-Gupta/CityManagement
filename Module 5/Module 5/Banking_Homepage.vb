Public Class Banking_Homepage
    Public bank_account_no As String = "1"
    Public bank_username As String = "samuel"
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
        'Me.Size = New Size(1107, 641)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        ChildForm(Banking_Main.Panel1, Banking_Login)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ChildForm(Banking_Main.Panel1, Banking_Registration)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        ChildForm(Banking_Main.Panel1, Banking_Admin_Login)
    End Sub
End Class