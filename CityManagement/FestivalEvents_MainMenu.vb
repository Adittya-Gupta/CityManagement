Imports CityManagement.FestivalEvents_Cards
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class FestivalEvents_MainMenu
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mypanel.Panel1.Controls.Clear()
        Dim form As New FestivalEvents_NewEvent
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub FestivalEvents_MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make this form full screen
        'Me.Width = Screen.PrimaryScreen.Bounds.Width - 200
        'Me.Height = Screen.PrimaryScreen.Bounds.Height

        ' Hide the title bar
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.WindowState = FormWindowState.Maximized
        Dim Designation As String = ""

        ' Clear existing controls
        FlowLayoutPanel1.Controls.Clear()

        Try
            conn.Open()
            ' Query to check if the current user has designation as "minister"
            Dim query As String = "SELECT designation FROM User WHERE SID = @SID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SID", Module1.CurrUserSID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Check if any rows are returned (i.e., if the current user is a minister)
                If reader.Read() Then
                    Designation = Convert.ToString(reader("designation"))
                    'Designation = "Minister"        'Comment this
                End If
                reader.Close()
            End Using


            query = "SELECT * FROM festivals "
            Using cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Debug.WriteLine(reader("name"))
                    Dim isApproved As Boolean = reader("isapproved")
                    Dim isOpen As Boolean = reader("isopen")

                    If Not isApproved Then
                        If Designation <> "Municipal Officer" Then
                            Continue While
                        End If
                    End If

                    Dim eventCard As New FestivalEvents_Cards()
                    eventCard.EventID.Text = reader("id")
                    eventCard.Label1.Text = "Venue: " + reader("Venue")
                    eventCard.Label2.Text = reader("name")
                    Dim datetime As DateTime = reader("dateTime")
                    Dim date1 As String = "Date: " + datetime.ToString("dd/MM/yyyy")
                    Dim time As String = "Time: " + datetime.ToString("hh:mm tt")
                    eventCard.Label3.Text = date1
                    eventCard.Label4.Text = time
                    ' Check if Image data is NULL
                    If Not IsDBNull(reader("Image")) Then
                        Dim img As Byte() = DirectCast(reader("Image"), Byte())
                        Dim ms As New IO.MemoryStream(img)
                        eventCard.PictureBox1.Image = Image.FromStream(ms)
                    End If

                    ' Add event card to the flow layout panel
                    FlowLayoutPanel1.Controls.Add(eventCard)


                End While

            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

End Class