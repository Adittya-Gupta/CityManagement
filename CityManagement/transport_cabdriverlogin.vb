Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class transport_cabdriverlogin
    Dim connString As String = Globals.connectionstring
    Dim conn As New MySqlConnection(connString)
    Dim conn2 As New MySqlConnection(connString)
    Public Shared name As String
    Public Shared fromLocation As String
    Public Shared toLocation As String
    Public Shared email As String
    Public Shared cabId As Integer
    Private Sub transport_cabdriverlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        TextBox3.UseSystemPasswordChar = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            email = TextBox4.Text
            Dim password As String = TextBox3.Text

            Dim query As String = "SELECT name, cab_id FROM cab_driver WHERE email = @Email AND password = @Password;"
            Dim cabIdQuery As String = "SELECT from_location, to_location FROM running_cabs WHERE cab_id = @CabID;"


            conn.Open()

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@Password", password)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        name = reader.GetString(0)
                        cabId = reader.GetInt32(1)
                        conn2.Open()
                        ' Fetch from_location and to_location using cab_id
                        Using cabIdCommand As New MySqlCommand(cabIdQuery, conn2)
                            cabIdCommand.Parameters.AddWithValue("@CabID", cabId)

                            Using cabIdReader As MySqlDataReader = cabIdCommand.ExecuteReader()
                                If cabIdReader.Read() Then
                                    fromLocation = cabIdReader.GetString(0)
                                    toLocation = cabIdReader.GetString(1)

                                    ' Now you have all the required information
                                    MessageBox.Show($"Welcome, {name}! Your cab is currently from {fromLocation} to {toLocation}.")
                                    Dim form2 As New transport_cabdriverinfo()

                                    ' Show Form2
                                    Me.Hide()
                                    form2.ShowDialog()
                                    Me.Show()
                                Else
                                    MessageBox.Show("Unable to fetch cab details.")
                                End If
                            End Using
                        End Using
                    Else
                        MessageBox.Show("Invalid email or password.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
            conn2.Close()
        End Try
    End Sub


End Class