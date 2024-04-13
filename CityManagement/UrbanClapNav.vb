Public Class UrbanClapNav

    Private Sub UrbanClapNav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the UrbanClapNav form with Panel1 initially empty
        'Dim X As Boolean = Me IsNot Globals.UrbanClapNavForm
        'Globals.UrbanClapNavForm.Show()
        Me.Panel1.Controls.Clear()
        ShowFormInPanel1(Globals.listofServicesForm)
        HideCurvedLabels()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Show ListofWorkersForm inside Panel1
        If Button1.Text = "Service Request" Then
            ShowFormInPanel1(Globals.WorkPage)
        Else
            ShowFormInPanel1(Globals.ServiceHistoryForm)
        End If

        ' Show curved label 1 and hide curved label 2
        CurvedLabel1.Visible = True
        CurvedLabel2.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Show ChatsForm inside Panel1
        ShowFormInPanel1(Globals.Chatspage)

        ' Show curved label 2 and hide curved label 1
        CurvedLabel1.Visible = False
        CurvedLabel2.Visible = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Create an instance of Form2
        If Button3.Text = "Work Section" Then
            Button1.Text = "Service Request"
            Button3.Text = "Back"
            ShowFormInPanel1(Globals.WorkPage)
            ShowCurvedLabels_history()
        Else
            Button1.Text = "Service History"
            Button3.Text = "Work Section"
            ShowFormInPanel1(Globals.listofServicesForm)
            HideCurvedLabels()
        End If
        'Me.Hide()
    End Sub

    Private Sub Button1_TextChanged(sender As Object, e As EventArgs) Handles Button1.TextChanged
        If Button1.Text = "Service Request" Then
            Globals.listofChatsForm.Button1.Visible = False ' Hide the back button
        Else
            Globals.listofChatsForm.Button1.Visible = True ' Show the back button
        End If
    End Sub


    Public Sub ShowFormInPanel1(formToShow As Form)
        ' Clear Panel1
        If Panel1.Controls.Count > 0 Then
            Dim firstControl As Control = Panel1.Controls(0)
            firstControl.Hide()
        End If
        Me.Panel1.Controls.Clear()
        ' Set the properties of the form to be displayed inside Panel1

        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.None
        Me.Panel1.Controls.Add(formToShow)

        formToShow.Show()

    End Sub

    Protected Friend Sub HideCurvedLabels()
        ' Hide both curved labels
        CurvedLabel1.Visible = False
        CurvedLabel2.Visible = False
    End Sub
    Protected Friend Sub ShowCurvedLabels_chats()
        ' Show both curved labels
        CurvedLabel1.Visible = False
        CurvedLabel2.Visible = True
    End Sub
    Protected Friend Sub ShowCurvedLabels_history()
        ' Show both curved labels
        CurvedLabel1.Visible = True
        CurvedLabel2.Visible = False
    End Sub

End Class
