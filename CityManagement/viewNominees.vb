Imports MySql.Data.MySqlClient
Imports System.IO

Public Class viewNominees

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LoadNominees()
    End Sub

    Private Sub LoadNominees()
        ' Clear existing controls
        Panel1.Controls.Clear()

        ' Establish connection to the database
        Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Using conn As New MySqlConnection(connString)
            Try
                ' Open the database connection
                conn.Open()

                ' Create a MySqlCommand object to execute SQL queries
                Dim cmd As New MySqlCommand()

                ' Set the command text to retrieve data from Nominees and User tables based on selected ministry
                Dim ministry As String = ComboBox1.SelectedItem.ToString().Replace(" Minister", "") ' Remove "Minister" suffix
                cmd.CommandText = "SELECT n.SID, n.Designation, n.Agenda, u.Name, u.ProfilePic FROM Nominees n JOIN User u ON n.SID = u.SID WHERE n.Designation LIKE @Ministry"
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
                    Dim ucNominee As New UCnominees()

                    ' Populate UCnominees with data from the reader
                    ucNominee.Label1.Text = reader("Name").ToString()
                    ucNominee.Label3.Text = reader("Agenda").ToString()

                    ' Convert ProfilePic from byte array to Image and assign to PictureBox
                    Dim imageData As Byte() = DirectCast(reader("ProfilePic"), Byte())
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
End Class
