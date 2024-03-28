Imports MySql.Data.MySqlClient

Public Class FestivalEvents_EventDetails

    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Private Sub FestivalEvents_EventDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make this form full screen
        Me.WindowState = FormWindowState.Maximized
        'Hide the title bar
        Me.Text = String.Empty
        Me.ControlBox = False
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM festivals WHERE name = @CurrEvent "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CurrEvent", Module1.CurrEvent)
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
                Dim img As Byte() = DirectCast(reader("Image"), Byte())
                Dim ms As New IO.MemoryStream(img)
                Me.PictureBox1.Image = Image.FromStream(ms)

                'eventCard.Label1.Text = "Venue: " + reader("Venue")
                'eventCard.Label2.Text = reader("name")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class