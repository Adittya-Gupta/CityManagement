Imports MySql.Data.MySqlClient
Imports System.IO

Public Class elections_AllResults

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LoadNominees()
    End Sub

    Private Sub LoadNominees()
        ' Clear existing controls
        Panel1.Controls.Clear()
        Panel1.AutoScroll = True

        ' Establish connection to the database
        'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Dim connString As String = Module1.connString
        Using conn As New MySqlConnection(connString)
            Try
                ' Open the database connection
                conn.Open()

                ' Create a MySqlCommand object to execute SQL queries
                Dim cmd As New MySqlCommand()

                ' Set the command text to retrieve data from Nominees and User tables based on selected ministry
                Dim ministry As String = ComboBox1.SelectedItem.ToString().Replace(" Minister", "") ' Remove "Minister" suffix
                cmd.CommandText = "SELECT n.SID, n.Designation,n.VoteCount,n.Agenda, u.Name, u.ProfilePic FROM Nominees n JOIN User u ON n.SID = u.SID WHERE n.Designation LIKE @Ministry"
                cmd.Parameters.AddWithValue("@Ministry", "%" & ministry & "%")

                ' Set the connection for the command
                cmd.Connection = conn

                ' Execute the command and retrieve the data
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Vertical position tracker for dynamically positioning controls
                Dim yPos As Integer = 0

                ' Iterate through the rows returned by the query
                While reader.Read()
                    ' Create a new instance of UCnominees user control
                    Dim ucNominee As New elections_AllResultsUserControl()

                    ' Populate UCnominees with data from the reader
                    ucNominee.Label1.Text = reader("Name").ToString()
                    ucNominee.Label3.Text = reader("Agenda").ToString()
                    ucNominee.voteC = Convert.ToInt32(reader("VoteCount"))

                    ' Convert ProfilePic from byte array to Image and assign to PictureBox
                    Dim imageData As Byte() = If(reader("ProfilePic") Is DBNull.Value, Nothing, DirectCast(reader("ProfilePic"), Byte()))

                    If imageData IsNot Nothing Then
                        Using ms As New MemoryStream(imageData)
                            ucNominee.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                            ucNominee.PictureBox1.Image = Image.FromStream(ms)
                        End Using
                    End If


                    ' Set location of UCnominee within the panel
                    ucNominee.Location = New Point(0, yPos)

                    ' Add the UCnominees control to the panel
                    Panel1.Controls.Add(ucNominee)

                    ' Update vertical position tracker
                    yPos += ucNominee.Height + 10 ' Add some padding between controls
                End While

                ' Close the reader
                reader.Close()
            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub AllResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        back.BackColor = System.Drawing.ColorTranslator.FromHtml("#64b75c")
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim form As New election_dashboard()
        mypanel.Panel1.Controls.Clear()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles back.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        back.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles back.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        back.Cursor = Cursors.Default
    End Sub
End Class
