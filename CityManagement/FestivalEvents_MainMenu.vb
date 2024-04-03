Imports CityManagement.FestivalEvents_Cards
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class FestivalEvents_MainMenu
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
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
        'Make this form full scree
        Me.Width = Screen.PrimaryScreen.Bounds.Width - 200
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        'Hide the title bar
        Me.Text = String.Empty
        Me.ControlBox = False
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM festivals "
            Using cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim isApproved As Boolean = reader("isapproved")
                    Dim isOpen As Boolean = reader("isopen")
                    If Not isApproved Or Not isOpen Then
                        Continue While
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
                    Dim img As Byte() = DirectCast(reader("Image"), Byte())
                    Dim ms As New IO.MemoryStream(img)
                    eventCard.PictureBox1.Image = Image.FromStream(ms)
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