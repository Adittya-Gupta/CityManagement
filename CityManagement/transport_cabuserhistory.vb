Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class transport_cabuserhistory
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim conn2 As New MySqlConnection(connString)
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub transport_cabuserhistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim email As String = TextBox1.Text
            'conn.Open()
            ' Query cab_user table to get current ride
            Dim currentRideQuery As String = "SELECT current_ride FROM cab_user WHERE email = @Email"
            Using command As New MySqlCommand(currentRideQuery, conn)
                command.Parameters.AddWithValue("@Email", email)
                conn.Open()
                Dim currentRide As Integer = Convert.ToInt32(command.ExecuteScalar())

                If currentRide = 0 Then
                    MessageBox.Show("You don't have any ongoing rides.")
                Else
                    ' Query all_cabs and running_cabs tables to get details of the current ride
                    Dim cabDetailsQuery As String = "SELECT c.driver_name, r.from_location, r.to_location, r.depart_time " &
                                                 "FROM all_cabs c INNER JOIN running_cabs r ON c.cab_id = r.cab_id " &
                                                 "WHERE r.cab_id = @CabId"
                    Using cabDetailsCommand As New MySqlCommand(cabDetailsQuery, conn)
                        cabDetailsCommand.Parameters.AddWithValue("@CabId", currentRide)
                        Dim reader As MySqlDataReader = cabDetailsCommand.ExecuteReader()

                        If reader.Read() Then
                            Dim driverName As String = reader.GetString(0)
                            Dim fromLocation As String = reader.GetString(1)
                            Dim toLocation As String = reader.GetString(2)
                            Dim departureTime As DateTime = reader.GetDateTime(3)

                            ' Display details of the current ride
                            MessageBox.Show($"Driver: {driverName}{Environment.NewLine}" &
                                        $"From Location: {fromLocation}{Environment.NewLine}" &
                                        $"To Location: {toLocation}{Environment.NewLine}" &
                                        $"Departure Time: {departureTime}")
                            Dim card As New ongoingride
                            card.Label6.Text = fromLocation
                            card.Label7.Text = toLocation
                            card.Label5.Text = driverName.ToString
                            card.Label8.Text = departureTime.ToString
                            FlowLayoutPanel1.Controls.Add(card)
                        Else
                            MessageBox.Show("No details found for the current ride.")
                        End If

                        reader.Close()
                    End Using
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub
End Class