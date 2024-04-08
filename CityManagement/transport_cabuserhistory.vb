Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class transport_cabuserhistory
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim conn2 As New MySqlConnection(connString)
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub transport_cabuserhistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim email As String = TextBox1.Text
            conn.Open()

            ' Query cab_user table to get current ride
            Dim userId As Integer = -1
            Dim currentRide As Integer = -1
            Dim currentRideQuery As String = "SELECT user_id, current_ride FROM cab_user WHERE email = @Email"
            Using command As New MySqlCommand(currentRideQuery, conn)
                command.Parameters.AddWithValue("@Email", email)
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    userId = reader.GetInt32(0)
                    currentRide = reader.GetInt32(1)
                End If
                reader.Close()
            End Using

            If currentRide = 0 Then
                MessageBox.Show("You don't have any ongoing rides.")
            Else
                ' Query all_cabs and cab_user tables to get details of the current ride
                Dim cabDetailsQuery As String = "SELECT all_cabs.driver_name, cab_user.current_from, cab_user.current_to, cab_user.current_arrival,cab_user.current_cost " &
                                                "FROM all_cabs " &
                                                "INNER JOIN cab_user ON all_cabs.cab_id = cab_user.current_ride " &
                                                "WHERE all_cabs.cab_id = @CabId"

                Using cabDetailsCommand As New MySqlCommand(cabDetailsQuery, conn)
                    cabDetailsCommand.Parameters.AddWithValue("@CabId", currentRide)
                    Dim reader As MySqlDataReader = cabDetailsCommand.ExecuteReader()

                    If reader.Read() Then
                        Dim driverName As String = reader.GetString(0)
                        Dim fromLocation As String = reader.GetString(1)
                        Dim toLocation As String = reader.GetString(2)
                        Dim departureTime As DateTime = reader.GetDateTime(3)
                        Dim cost As Decimal = reader.GetDecimal(4)
                        ' Display details of the current ride
                        MessageBox.Show($"Driver: {driverName}{Environment.NewLine}" &
                                        $"From Location: {fromLocation}{Environment.NewLine}" &
                                        $"To Location: {toLocation}{Environment.NewLine}" &
                                        $"Departure Time: {departureTime}{Environment.NewLine}" &
                                        $"cost: {cost}{Environment.NewLine}")

                        Dim card As New ongoingride
                        card.Label6.Text = fromLocation
                        card.Label7.Text = toLocation
                        card.Label5.Text = driverName.ToString
                        card.Label8.Text = departureTime.ToString
                        card.Label3.Text = "Rs. " & cost.ToString
                        AddHandler card.Button4.Click, Sub()
                                                           conn2.Open()
                                                           ' Insert the ride details into cab_history
                                                           Dim insertQuery As String = "INSERT INTO cab_history (user_id, from_location, to_location, cab_arrival,cost) " &
                                                                                             "VALUES (@UserId, @FromLocation, @ToLocation, @CabArrival,@cost)"
                                                           Using insertCommand As New MySqlCommand(insertQuery, conn2)
                                                               insertCommand.Parameters.AddWithValue("@UserId", userId)
                                                               insertCommand.Parameters.AddWithValue("@FromLocation", fromLocation)
                                                               insertCommand.Parameters.AddWithValue("@ToLocation", toLocation)

                                                               insertCommand.Parameters.AddWithValue("@CabArrival", departureTime) ' Assuming cab_arrival is current time
                                                               insertCommand.Parameters.AddWithValue("@cost", cost)
                                                               insertCommand.ExecuteNonQuery()
                                                           End Using
                                                           Dim updateUserQuery As String = "UPDATE cab_user SET current_ride = 0, current_from = '', current_to = '', current_arrival = NULL,current_cost = 0 WHERE user_id = @UserId"
                                                           Using updateCommand As New MySqlCommand(updateUserQuery, conn2)
                                                               updateCommand.Parameters.AddWithValue("@UserId", userId)
                                                               updateCommand.ExecuteNonQuery()
                                                           End Using

                                                           ' Get max_limit from all_cabs
                                                           Dim maxLimit As Integer = 0
                                                           Dim maxLimitQuery As String = "SELECT max_limit FROM all_cabs WHERE cab_id = @CabId"
                                                           Using maxLimitCommand As New MySqlCommand(maxLimitQuery, conn2)
                                                               maxLimitCommand.Parameters.AddWithValue("@CabId", currentRide)
                                                               Dim result As Object = maxLimitCommand.ExecuteScalar()
                                                               If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                                                                   maxLimit = Convert.ToInt32(result)
                                                               End If
                                                           End Using

                                                           ' Update running_cabs vacancies
                                                           Dim vacanciesQuery As String = "UPDATE running_cabs SET vacancies = vacancies + 1 WHERE cab_id = @CabId"
                                                           Using vacanciesCommand As New MySqlCommand(vacanciesQuery, conn2)
                                                               vacanciesCommand.Parameters.AddWithValue("@CabId", currentRide)
                                                               vacanciesCommand.ExecuteNonQuery()
                                                           End Using

                                                           ' Check if vacancies equal to max_limit, then delete entry from running_cabs
                                                           If maxLimit > 0 Then
                                                               Dim checkDeleteQuery As String = "SELECT vacancies FROM running_cabs WHERE cab_id = @CabId"
                                                               Using checkDeleteCommand As New MySqlCommand(checkDeleteQuery, conn2)
                                                                   checkDeleteCommand.Parameters.AddWithValue("@CabId", currentRide)
                                                                   Dim vacancies As Integer = Convert.ToInt32(checkDeleteCommand.ExecuteScalar())
                                                                   If vacancies = maxLimit Then
                                                                       Dim deleteQuery As String = "DELETE FROM running_cabs WHERE cab_id = @CabId"
                                                                       Using deleteCommand As New MySqlCommand(deleteQuery, conn2)
                                                                           deleteCommand.Parameters.AddWithValue("@CabId", currentRide)
                                                                           deleteCommand.ExecuteNonQuery()
                                                                       End Using
                                                                       Dim update As String = "UPDATE all_cabs SET is_available = 1 WHERE cab_id = @CabId"
                                                                       Using cmd As New MySqlCommand(update, conn2)
                                                                           cmd.Parameters.AddWithValue("@CabId", currentRide)
                                                                           cmd.ExecuteNonQuery()
                                                                       End Using
                                                                   End If
                                                               End Using
                                                           End If
                                                           MessageBox.Show("Ride ended successfully and details added to cab_history.")
                                                           ' Optionally, you may also update the cab_user table to indicate that the ride has ended.
                                                       End Sub
                        FlowLayoutPanel1.Controls.Add(card)
                    Else
                        MessageBox.Show("No details found for the current ride.")
                    End If

                    reader.Close()
                End Using
            End If
            Dim historyQuery As String = "SELECT from_location, to_location, cab_arrival,cost " &
                                 "FROM cab_history " &
                                 "WHERE user_id = @UserId"

            Using command As New MySqlCommand(historyQuery, conn)
                command.Parameters.AddWithValue("@UserId", userId)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim fromLocation As String = reader.GetString(0)
                    Dim toLocation As String = reader.GetString(1)
                    Dim cabArrival As DateTime = reader.GetDateTime(2)
                    Dim cost As Decimal = reader.GetDecimal(3)
                    ' Create a new card or UI element to display the ride details
                    Dim card As New previousRideCard()
                    card.Label13.Text = fromLocation
                    card.Label15.Text = toLocation
                    card.Label11.Text = cabArrival.ToString()
                    card.Label10.Text = "Rs. " & cost.ToString()
                    ' Add the card to your UI container (e.g., FlowLayoutPanel)
                    FlowLayoutPanel2.Controls.Add(card)
                End While

                reader.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class