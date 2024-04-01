Public Class Newsletter_Main

    'Make this form full screen

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub


    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        Panel1.BackColor = Color.FromArgb(246, 246, 233)
        Panel2.BackColor = Color.FromArgb(246, 246, 233)
        ChildForm(Panel1, Newsletter_Homepage)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        ChildForm(Panel1, Newsletter_Editor)
    End Sub
End Class