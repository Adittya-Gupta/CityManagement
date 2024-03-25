Public Class UrbanClapNav
    ' Declare instances of the forms
    Public ServiceHistoryForm As New ServiceHistory(Me)
    Public chatsForm As New Chats(Me)
    Public listofServicesForm As New ListofServices_Citizen(Me)
    Public listofWorkersForm As New ListofWorkers_Citizen(Me)
    Public HomePage As Object = listofServicesForm

    Private Sub UrbanClapNav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the UrbanClapNav form with Panel1 initially empty
        Panel1.Controls.Clear()
        ShowFormInPanel(listofServicesForm)
        HideCurvedLabels()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Show ListofWorkersForm inside Panel1
        ShowFormInPanel(ServiceHistoryForm)

        ' Show curved label 1 and hide curved label 2
        CurvedLabel1.Visible = True
        CurvedLabel2.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Show ChatsForm inside Panel1
        ShowFormInPanel(chatsForm)

        ' Show curved label 2 and hide curved label 1
        CurvedLabel1.Visible = False
        CurvedLabel2.Visible = True

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

    Protected Friend Sub HideCurvedLabels()
        ' Hide both curved labels
        CurvedLabel1.Visible = False
        CurvedLabel2.Visible = False
    End Sub

End Class
