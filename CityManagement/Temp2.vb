Public Class Temp2

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShowFormInPanel(specialisation)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ShowFormInPanel(Globals.UrbanClapNavForm)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ShowFormInPanel(New EmploymentPortal())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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

End Class