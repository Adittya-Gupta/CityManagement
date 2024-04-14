Public Class Banking_Money_Management_Final

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Public Shared Sub ChildForm2(ByVal childform As Form)
        mypanel.Panel1.Controls.Clear()
        childform.TopLevel = False
        mypanel.Panel1.Controls.Add(childform)
        childform.Show()
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Global_Attributes.banking_recv_username = ""
        Global_Attributes.banking_payment_amount = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Global_Attributes.Go_Back = 0 Then
            Global_Attributes.Go_Back = 0
            ChildForm(Banking_Main.Panel1, Global_Attributes.Go_Back_Form)
        ElseIf Global_Attributes.Go_Back = 1 Then
            Global_Attributes.Go_Back = 0
            Banking_Main.Panel1.Controls.Clear()
            Newsletter_Main.Panel1.Controls.Clear()
            Newsletter_AddNews.payment_done = 1
            ChildForm(Newsletter_Main.Panel1, Global_Attributes.Go_Back_Form)
            mypanel.Panel1.Controls.Clear()
            ChildForm2(Newsletter_Main)
        End If
    End Sub
End Class