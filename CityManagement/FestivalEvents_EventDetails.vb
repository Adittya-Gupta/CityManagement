Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class FestivalEvents_EventDetails

    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Private Sub FestivalEvents_EventDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make this form full screen
        'Me.WindowState = FormWindowState.Maximized
        'Hide the title bar
        'Me.Width = Screen.PrimaryScreen.Bounds.Width - 200
        'Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Text = String.Empty
        Me.ControlBox = False
        Label7.MaximumSize = New Size(Panel1.Size.Width - 100, 0) ' Adjust the width as needed
        Label7.AutoSize = True

        Request_Button.Visible = False
        Approve_Button.Visible = False
        Choose_service_button.Visible = False
        Restrictions_Button.Visible = False
        Edit_event_button.Visible = False



        Dim designation As String = ""
        Dim Owner_id As Integer = -1

        Try
            conn.Open()
            ' Query to fetch user's designation and ownership status from the database based on SID
            Dim query As String = "SELECT designation FROM User WHERE SID = @UserID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", Module1.CurrUserSID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        designation = Convert.ToString(reader("designation"))
                    End If
                End Using
            End Using

            query = "SELECT owner_sid FROM festivals WHERE id = @CurrEventID "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CurrEventID", Module1.CurrEventID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Owner_id = Convert.ToInt32(reader("owner_sid"))
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        Debug.WriteLine(Module1.CurrUserSID)
        Debug.WriteLine(Owner_id)

        ' Display buttons based on user's designation and ownership
        Select Case designation
            Case "Merchant"
                Request_Button.Visible = True
            Case "Municipal Officer"
                Approve_Button.Visible = True
        End Select

        If Module1.CurrUserSID = Owner_id Then
            Edit_event_button.Visible = True
            Restrictions_Button.Visible = True
            Choose_service_button.Visible = True
        End If







        Try
            conn.Open()
            Dim query As String = "SELECT * FROM festivals WHERE id = @CurrEventID "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CurrEventID", Module1.CurrEventID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                reader.Read()
                Dim isApproved As Boolean = reader("isapproved")
                Dim isOpen As Boolean = reader("isopen")

                ''Dim eventCard As New FestivalEvents_Cards()
                Label3.Text = reader("name")
                Label2.Text = reader("name")
                Label4.Text = "Venue: " + reader("Venue")
                Dim datetime As DateTime = reader("dateTime")
                Dim date1 As String = "Date: " + datetime.ToString("dd/MM/yyyy")
                Dim time As String = "Time: " + datetime.ToString("hh:mm tt")
                Label5.Text = date1
                Label6.Text = time
                Label7.Text = reader("description")
                If Not IsDBNull(reader("Image")) Then
                    Dim img As Byte() = DirectCast(reader("Image"), Byte())
                    Dim ms As New IO.MemoryStream(img)
                    Me.PictureBox1.Image = Image.FromStream(ms)
                End If

                'eventCard.Label1.Text = "Venue: " + reader("Venue")
                'eventCard.Label2.Text = reader("name")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Choose_service_button.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New FestivalEvents_ChooseServices
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New FestivalEvents_MainMenu
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Restrictions_Button.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New FestivalEvents_RegRestrictions
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Approve_Button.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New FestivalEvents_Approval
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Edit_event_button.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New FestivalEvents_EditEvent
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Request_Button.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New FestivalEvents_Offer_Service2
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Register_Button.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New FestivalEvents_Participation2
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class