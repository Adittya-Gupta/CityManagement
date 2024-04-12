Public Class Newsletter_Homepage

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub
    'Make this form full screen
    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.WindowState = FormWindowState.Maximized
        'Panel1.BackColor = Color.FromArgb(246, 246, 233)
        Me.BackColor = Color.FromArgb(246, 246, 233)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ChildForm(Newsletter_Main.Panel1, Newsletter_EditorLogin)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ChildForm(Newsletter_Main.Panel1, Newsletter_articlespage)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Newsletter_AddNews.payment_done = 0
        ChildForm(Newsletter_Main.Panel1, Newsletter_AddNews)
    End Sub
End Class