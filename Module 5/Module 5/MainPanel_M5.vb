Public Class MainPanel_M5

    'Make this form full screen


    Public Shared Sub CLearPanels()
        Banking_Main.Panel1.Controls.Clear()
        Newsletter_Main.Panel1.Controls.Clear()
    End Sub
    Public Shared Sub ChildForm(ByVal childform As Form)
        mypanel.Panel1.Controls.Clear()
        childform.TopLevel = False
        mypanel.Panel1.Controls.Add(childform)
        childform.Show()
    End Sub

    Public Shared Sub ChildForm2(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub
    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged, MyBase.Load
        Me.Location = New Point(100, 0)
        mypanel.Panel1 = Panel1
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CLearPanels()
        ChildForm2(Banking_Main.Panel1, Banking_Homepage)
        mypanel.Panel1.Controls.Clear()
        ChildForm(Banking_Main)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        CLearPanels()
        ChildForm2(Newsletter_Main.Panel1, Newsletter_Homepage)
        mypanel.Panel1.Controls.Clear()
        ChildForm(Newsletter_Main)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Banking_Main.Panel1.Controls.Clear()
        Newsletter_Main.Panel1.Controls.Clear()
        mypanel.Panel1.Controls.Clear()
        ChildForm(Email_Landing)
    End Sub
End Class