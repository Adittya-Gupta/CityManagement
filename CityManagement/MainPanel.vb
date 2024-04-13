Public Class MainPanel



    'Make this form full screen
    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged, MyBase.Load
        If Me.Visible Then
            mypanel.panel1 = Panel1
            Button1_Click(sender, e)
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShowFormInPanel(specialisation)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New transport_landingPage
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Create an instance of the admin_home form
        'Dim adminHomeForm As New admin_home()

        mypanel.panel1.Controls.Clear()
        Dim form As New admin_home
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ShowFormInPanel(Globals.UrbanClapNavForm)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New complaints()
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New User_Profile
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New FestivalEvents_MainMenu
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New Redressal()
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
    Public Sub ShowFormInPanel(formToShow As Form)
        ' Clear Panel1
        Me.Panel1.Controls.Clear()

        ' Set the properties of the form to be displayed inside Panel1
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill

        ' Add the form to Panel1
        Me.Panel1.Controls.Add(formToShow)

        ' Show the form
        formToShow.Show()

    End Sub
    Public Sub ShowChildFormInPanel(formToShow As Form)
        ' Check if the panel already contains any controls
        Me.Panel1.Controls.Clear()

        ' Set the properties of the form to be displayed inside Panel1
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill

        ' Add the form to Panel1
        Me.Panel1.Controls.Add(formToShow)

        ' Show the form
        formToShow.Show()
    End Sub

    'Private Sub Button10_Click(sender As Object, e As EventArgs)
    'Dim form2 As New transport_landingPage
    '
    ' Show Form2
    'Hide()
    'form2.ShowDialog()
    'Show()
    'End Sub
End Class