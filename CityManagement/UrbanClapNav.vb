Imports MySql.Data.MySqlClient

Public Class UrbanClapNav
    Dim userID As Integer = Module1.CurrUserSID ' User ID of the applicant (Electrician)
    'Dim userID As Integer = 112547 ' User ID of the applicant (Head Electrician)
    'Dim userID As Integer = 124918 ' User ID of the applicant (unemployed)
    'Dim connString As String = "server=localhost;userid=root;password=pwd;database=smart_city_management"
    Dim connString As String = Module1.connString
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim designation As String

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
            'tton2.Visible = True
            ShowFormInPanel1(Globals.WorkPage)
        ElseIf Button1.Text = "Employment Request" Then
            'utton2.Visible = False
            ShowFormInPanel1(Globals.OrgHeadWorkSection)
        Else
            'Button2.Visible = True
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
            'Button1.Text = "Service Request"
            Button3.Text = "Back"

            Try
                conn.Open()
                Dim query As String = "SELECT Designation FROM User WHERE SID = @userID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userID", userID)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim designation As String = reader.GetString("Designation")
                        If designation = "Electrician" OrElse designation = "Plumber" OrElse designation = "Househelp" OrElse designation = "Merchant" Then
                            Button1.Text = "Service Request"
                            'utton2.Visible = True
                            ShowFormInPanel1(Globals.WorkPage)
                            ShowCurvedLabels_history()
                        ElseIf designation = "Head Electrician" OrElse designation = "Head Plumber" OrElse designation = "Head Househelp" OrElse designation = "Head Merchant" Then
                            Button1.Text = "Employment Request"
                            'utton2.Visible = False
                            ShowFormInPanel1(Globals.OrgHeadWorkSection)
                            ShowCurvedLabels_history()
                        Else
                            Button1.Text = "Service History"
                            'utton2.Visible = True
                            Button3.Text = "Work Section"
                            MessageBox.Show("You are not employed as a Service Worker")
                            Return
                        End If
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error accessing page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the database connection
                conn.Close()
            End Try
        Else
            Button1.Text = "Service History"
            'utton2.Visible = True
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
