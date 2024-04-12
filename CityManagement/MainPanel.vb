Public Class MainPanel

    'Make this form full screen
    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim electionForm As New electionPortal()

        ' Set the TopLevel property to False to allow it to be contained within another control
        electionForm.TopLevel = False

        ' Set the FormBorderStyle property to None to hide the title bar and control buttons
        electionForm.FormBorderStyle = FormBorderStyle.None

        ' Dock the admin_home form inside Panel1
        electionForm.Dock = DockStyle.Fill

        ' Clear any existing controls in Panel1
        Panel1.Controls.Clear()

        ' Add the admin_home form to Panel1
        Panel1.Controls.Add(electionForm)

        ' Show the admin_home form
        electionForm.Show()
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
End Class