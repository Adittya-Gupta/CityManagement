Public Class OrgHeadWorkSection

    Private Sub OrgHeadWorkSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add your initialization code here
        ' This code will execute when the UserControl is loaded
        ' For example:
        Label1.Hide()
    End Sub

    Public Sub ShowFormInPanel(formToShow As Form)
        ' Clear Panel1
        Panel1.Controls.Clear()

        ' Set the properties of the form to be displayed inside Panel1
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill

        ' Add the form to Panel1
        Panel1.Controls.Add(formToShow)

        ' Show the form
        formToShow.Show()

    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Label1.Show()
        Label1.BringToFront()
        Panel1.SendToBack()
        LoadIncomingEmploymentReq()
    End Sub

    Public Sub LoadIncomingEmploymentReq()
        ShowFormInPanel(New IncomingEmploymentReq(Me))
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Label1.Hide()
        ShowFormInPanel(New EmployeeTable(Me))
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    'Public Sub LoadEmployeeTable()
    '    ShowFormInPanel(New EmployeeTable(Me))
    'End Sub

End Class