Public Class MainPanel

    'Make this form full screen
    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.WindowState = FormWindowState.Maximized
    End Sub
    Sub switchPanel(ByVal panel As Form)
        ' Check if the panel is already added
        Dim existingPanel As Form = Panel1.Controls.OfType(Of Form)().FirstOrDefault(Function(f) f.GetType() = panel.GetType())

        If existingPanel IsNot Nothing Then
            ' Panel already exists, bring it to front
            existingPanel.BringToFront()
        Else
            ' Panel not added, add it to Panel1.Controls
            Panel1.Controls.Clear()
            panel.TopLevel = False
            panel.FormBorderStyle = FormBorderStyle.None
            panel.Dock = DockStyle.Fill ' Set DockStyle To Fill
            Panel1.Controls.Add(panel)
            panel.Show()
        End If
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

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Redressal As New Redressal()
        switchPanel(Redressal)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class