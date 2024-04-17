Imports CityManagement.HistoryItem

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
        mypanel.panel1.Controls.Clear()
        childform.TopLevel = False
        mypanel.Panel1.Controls.Add(childform)
        childform.Show()
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Banking_Money_Management_Homepage.Close()
        If Global_Attributes.Go_Back = 0 Then
            Global_Attributes.Go_Back = 0
            ChildForm(Banking_Main.Panel1, Global_Attributes.Go_Back_Form)
        ElseIf Global_Attributes.Go_Back = 1 Then
            Global_Attributes.Go_Back = 0
            Banking_Main.Panel1.Controls.Clear()
            Newsletter_Main.Panel1.Controls.Clear()
            Newsletter_AddNews.payment_done = 1
            ChildForm(Newsletter_Main.Panel1, Global_Attributes.Go_Back_Form)
            mypanel.panel1.Controls.Clear()
            ChildForm2(Newsletter_Main)
        ElseIf Global_Attributes.Go_Back = 2 Then
            Global_Attributes.Go_Back = 0
            Banking_Main.Panel1.Controls.Clear()
            Newsletter_Main.Panel1.Controls.Clear()
            ChildForm2(Global_Attributes.Go_Back_Form)
            'Dim form As New election_dashboard()
            'mypanel.panel1.Controls.Clear()
            'Form.TopLevel = False
            'mypanel.panel1.Controls.Add(form)
            'Form'.Show()
        ElseIf Global_Attributes.Go_Back = 3 Then

            Global_Attributes.banking_payment_done = 0
            Global_Attributes.HistoryItem.HandleAction(CustomerAction.Pay)
            Global_Attributes.Go_Back = 0
            Banking_Main.Panel1.Controls.Clear()
            Newsletter_Main.Panel1.Controls.Clear()
            ChildForm2(Global_Attributes.Go_Back_Form)
        End If
    End Sub

    Private Sub Banking_Money_Management_Final_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Global_Attributes.banking_recv_username = ""
        Global_Attributes.banking_recv_name = ""
        Global_Attributes.banking_payment_amount = 0
        Global_Attributes.banking_payment_done = 1
    End Sub
End Class