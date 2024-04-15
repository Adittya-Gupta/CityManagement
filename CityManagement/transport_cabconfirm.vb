Imports Google.Protobuf.Reflection.SourceCodeInfo.Types
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class transport_cabconfirm
    Dim connString As String = Globals.connectionstring
    Dim conn As New MySqlConnection(connString)
    Dim conn2 As New MySqlConnection(connString)
    Private Sub transport_cabconfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.ControlBox = False
        Me.Text = ""
        TextBox1.Text = transport_cabbooking.FromLocation
        TextBox2.Text = transport_cabbooking.ToLocation
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim userEmail = TextBox4.Text
            Dim selectedCabId = transport_cabavailable.selected_cab
            conn.Open()
            Dim updateUserCabQuery = "UPDATE cab_user SET current_ride = @selectedCabId, current_from = @from, current_to=@to, current_arrival = @time,current_cost = @price WHERE email = @userEmail"
            Using updateUserCabCommand As New MySqlCommand(updateUserCabQuery, conn)
                updateUserCabCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                updateUserCabCommand.Parameters.AddWithValue("@userEmail", userEmail)
                updateUserCabCommand.Parameters.AddWithValue("@from", transport_cabbooking.FromLocation)
                updateUserCabCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                updateUserCabCommand.Parameters.AddWithValue("@time", transport_cabavailable.cab_arrival)
                updateUserCabCommand.Parameters.AddWithValue("@price", transport_cabavailable.cost)
                updateUserCabCommand.ExecuteNonQuery()
            End Using
            If transport_cabavailable.extended <> 0 Then
                ' Update running_cab with new path ID
                Dim newPathId = GetNewPathId(transport_cabbooking.FromLocation, transport_cabbooking.ToLocation)
                Dim updateRunningCabQuery = "UPDATE running_cabs SET path_id = @newPathId,vacancies = vacancies - 1,to_location=@to WHERE cab_id = @selectedCabId"
                Using updateRunningCabCommand As New MySqlCommand(updateRunningCabQuery, conn)
                    updateRunningCabCommand.Parameters.AddWithValue("@newPathId", transport_cabavailable.extended)
                    updateRunningCabCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                    updateRunningCabCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                    updateRunningCabCommand.ExecuteNonQuery()
                End Using
                MessageBox.Show("Cab booking confirmed. Enjoy the ride!")
            ElseIf transport_cabavailable.newcab = 1 Then
                ' Insert a new entry in running_cabs table
                MessageBox.Show("New cabbbbb")
                MessageBox.Show(selectedCabId)
                MessageBox.Show(transport_cabavailable.fromNodeId & transport_cabavailable.toNodeId)

                Dim isSharable = 1
                Dim vacancyquery = "SELECT max_limit FROM all_cabs WHERE cab_id=@cabId"
                Dim vacancies = -1
                Using command As New MySqlCommand(vacancyquery, conn)
                    command.Parameters.AddWithValue("@cabId", selectedCabId)
                    Dim result = command.ExecuteScalar
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        vacancies = Convert.ToInt32(result)
                    End If
                End Using
                MessageBox.Show(vacancies)
                Dim available = 0
                Dim updatecab = "UPDATE all_cabs SET is_available = @avail WHERE cab_id = @cabId"
                Using cmd As New MySqlCommand(updatecab, conn)
                    cmd.Parameters.AddWithValue("@cabId", selectedCabId)
                    cmd.Parameters.AddWithValue("@avail", available)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("OOF")
                Dim newPathId = -1
                'MessageBox.Show(transport_cabbooking.FromLocation & " " & transport_cabbooking.ToLocation)
                Dim newPathIdQuery = "SELECT path_id FROM cab_path WHERE from_node = @fromLocation AND to_node = @toLocation"
                Using newPathIdCommand As New MySqlCommand(newPathIdQuery, conn)
                    newPathIdCommand.Parameters.AddWithValue("@fromLocation", transport_cabavailable.fromNodeId)
                    newPathIdCommand.Parameters.AddWithValue("@toLocation", transport_cabavailable.toNodeId)
                    Dim result = newPathIdCommand.ExecuteScalar
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        newPathId = Convert.ToInt32(result)
                    End If
                End Using
                MessageBox.Show(newPathId)
                MessageBox.Show(selectedCabId)
                Dim insertRunningCabQuery = "INSERT INTO running_cabs (cab_id, path_id,from_location,to_location,depart_time,vacancies,is_sharable) VALUES (@selectedCabId, @newPathId,@from, @to, @depart,@vacancies, @shared)"
                Using insertRunningCabCommand As New MySqlCommand(insertRunningCabQuery, conn)
                    insertRunningCabCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                    insertRunningCabCommand.Parameters.AddWithValue("@newPathId", newPathId)
                    insertRunningCabCommand.Parameters.AddWithValue("@from", transport_cabbooking.FromLocation)
                    insertRunningCabCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                    insertRunningCabCommand.Parameters.AddWithValue("@depart", transport_cabbooking.sqlFormattedDateTime)
                    insertRunningCabCommand.Parameters.AddWithValue("@vacancies", vacancies - 1)
                    insertRunningCabCommand.Parameters.AddWithValue("@shared", isSharable)
                    insertRunningCabCommand.ExecuteNonQuery()
                End Using
                MessageBox.Show("Cab booking confirmed. Enjoy the ride!")
            Else
                Dim updateRunningCabQuery = "UPDATE running_cabs SET vacancies = vacancies - 1 WHERE cab_id = @selectedCabId"
                Using updateRunningCabCommand As New MySqlCommand(updateRunningCabQuery, conn)
                    updateRunningCabCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                    updateRunningCabCommand.ExecuteNonQuery()
                End Using
                MessageBox.Show("Cab booking confirmed. Enjoy the ride!")
            End If


        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Function GetNewPathId(fromLocation As String, toLocation As String) As Integer
        Dim newPathId As Integer = -1
        Try
            conn2.Open()
            Dim newPathIdQuery As String = "SELECT path_id FROM cab_path WHERE from_node = @fromLocation AND to_node = @toLocation"
            Using newPathIdCommand As New MySqlCommand(newPathIdQuery, conn2)
                newPathIdCommand.Parameters.AddWithValue("@fromLocation", fromLocation)
                newPathIdCommand.Parameters.AddWithValue("@toLocation", toLocation)
                Dim result As Object = newPathIdCommand.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    newPathId = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn2.Close()
        End Try
        Return newPathId
    End Function
    Private Function GetNodeId(location As String) As Integer
        Dim nodeId As Integer = -1

        Try
            conn2.Open()
            Dim query As String = "SELECT node_id FROM cab_nodes WHERE place_name = @Location"
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@Location", location)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    nodeId = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions here
        Finally
            conn2.Close()
        End Try

        Return nodeId
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New transport_cabbooking
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class