Public Class MainPanel



    'Make this form full screen
    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged, MyBase.Load
        If Me.Visible Then
            mypanel.Panel1 = Panel1
            Button1_Click(sender, e)
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Create an instance of the admin_home form
        'Dim adminHomeForm As New admin_home()

        mypanel.Panel1.Controls.Clear()
        Dim form As New admin_home
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        mypanel.Panel1.Controls.Clear()
        Dim form As New complaints()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mypanel.Panel1.Controls.Clear()
        Dim form As New User_Profile
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mypanel.Panel1.Controls.Clear()
        Dim form As New FestivalEvents_MainMenu
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        mypanel.Panel1.Controls.Clear()
        Dim form As New Redressal()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class