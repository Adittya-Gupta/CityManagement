﻿Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Text
Imports Org.BouncyCastle.Asn1.Ocsp
Imports System.Globalization
Public Class transport_cabavailable
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim conn2 As New MySqlConnection(connString)
    Dim pathNodesMap As New Dictionary(Of Integer, List(Of Integer))
    Dim relpathNodesMap As New Dictionary(Of Integer, List(Of Integer))
    Public Shared fromNodeId As Integer
    Public Shared toNodeId As Integer
    Public Shared cab_arrival_times As New Dictionary(Of Integer, DateTime)
    'Dim arrivalTimes As New List(Of Integer)
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
    Private Sub transport_cabavailable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Try
            conn2.Open()
            Dim query As String = "Select * from running_cabs"
            'Create a list of dictionary to store the data
            Dim data As New List(Of Dictionary(Of String, Object))
            Dim cmd As New MySqlCommand(query, conn2)

            ' Retrieve the node IDs for the from and to locations
            fromNodeId = GetNodeId(transport_cabbooking.FromLocation)
            toNodeId = GetNodeId(transport_cabbooking.ToLocation)

            ' Display the node IDs on the cards
            'Dim card As New transport_cabCards
            'card.Label6.Text = fromNodeId.ToString() & transport_cabbooking.FromLocation
            'card.Label7.Text = toNodeId.ToString() & transport_cabbooking.ToLocation
            'FlowLayoutPanel1.Controls.Add(card)
            RetrieveAndStoreNodesList()

            CalculateArrivalTimes()
            Dim gotCab As Boolean = False
            'MessageBox.Show(cab_arrival_times.Count)
            For Each kvp As KeyValuePair(Of Integer, DateTime) In cab_arrival_times
                Dim cabId As Integer = kvp.Key
                Dim arrivalTime As DateTime = kvp.Value
                Dim driverName As String = ""
                Dim driverquery As String = "SELECT driver_name FROM all_cabs WHERE cab_id=@cabId"

                Using command As New MySqlCommand(driverquery, conn2)
                    command.Parameters.AddWithValue("@cabId", cabId)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        driverName = Convert.ToString(result)
                    End If
                End Using
                ' Parse sqlFormattedDateTime to DateTime
                Dim sqlDateTime As DateTime = DateTime.ParseExact(transport_cabbooking.sqlFormattedDateTime, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                'MessageBox.Show("sql: " & sqlDateTime & "arrival: " & arrivalTime)
                ' Compare arrivalTime with sqlDateTime
                If arrivalTime >= sqlDateTime Then
                    ' Arrival time is greater than or equal to sqlDateTime
                    'MessageBox.Show("hehehehhe")
                    ' Check if cabId exists in pathNodesMap
                    If pathNodesMap.ContainsKey(cabId) Then
                        ' Retrieve nodes list for the cabId
                        Dim nodesList As List(Of Integer) = pathNodesMap(cabId)

                        ' Check if fromNodeId and toNodeId are in the nodes list
                        Dim fromNodeIndex As Integer = nodesList.IndexOf(fromNodeId)
                        Dim toNodeIndex As Integer = nodesList.IndexOf(toNodeId)
                        'MessageBox.Show("from: " & fromNodeIndex & " to: " & toNodeIndex)
                        ' Check if both fromNodeId and toNodeId are present and toNodeId occurs after fromNodeId
                        If fromNodeIndex <> -1 AndAlso toNodeIndex <> -1 AndAlso toNodeIndex > fromNodeIndex Then
                            'MessageBox.Show("Cab ID: " & cabId & " contains the required route as subpath of current cab route.")

                            Dim vacancyquery As String = "SELECT vacancies FROM running_cabs WHERE cab_id=@cabId"
                            Dim vacancies = -1
                            Using command As New MySqlCommand(vacancyquery, conn2)
                                command.Parameters.AddWithValue("@cabId", cabId)
                                Dim result As Object = command.ExecuteScalar()
                                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                                    vacancies = Convert.ToInt32(result)
                                End If
                            End Using
                            If vacancies > 0 Then
                                gotCab = True
                                Dim card As New transport_cabCards
                                card.Label6.Text = transport_cabbooking.FromLocation
                                card.Label7.Text = transport_cabbooking.ToLocation
                                card.Label5.Text = arrivalTime.ToString
                                card.Label8.Text = driverName
                                FlowLayoutPanel1.Controls.Add(card)
                            End If

                        ElseIf fromNodeIndex <> -1 AndAlso toNodeIndex = -1 Then
                            Dim canExtend = extend_path(cabId)
                            If (canExtend) Then
                                'MessageBox.Show("can extend")
                                Dim cabfrom As Integer = -1
                                Dim cabfromstr As String = ""
                                Dim cabfromquery As String = "SELECT from_location FROM running_cabs WHERE cab_id=@cabId"
                                Using command As New MySqlCommand(cabfromquery, conn2)
                                    command.Parameters.AddWithValue("@cabId", cabId)


                                    Dim result As Object = command.ExecuteScalar()
                                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                                        cabfromstr = Convert.ToString(result)
                                        cabfrom = GetNodeId(cabfromstr)
                                    End If
                                End Using
                                Dim newPathquery As String = "SELECT path_id FROM cab_path WHERE from_node = @cabfrom AND to_node = @toNodeId"
                                Dim newPathId As Integer = -1
                                Using command As New MySqlCommand(newPathquery, conn2)
                                    command.Parameters.AddWithValue("cabfrom", cabfrom)
                                    command.Parameters.AddWithValue("@toNodeId", toNodeId)

                                    Dim result As Object = command.ExecuteScalar()
                                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                                        newPathId = Convert.ToInt32(result)
                                    End If
                                End Using
                                'MessageBox.Show("Path extended successfully for Cab ID: " & cabId & "Path id " & newPathId)
                                Dim vacancyquery As String = "SELECT vacancies FROM running_cabs WHERE cab_id=@cabId"
                                Dim vacancies = -1
                                Using command As New MySqlCommand(vacancyquery, conn2)
                                    command.Parameters.AddWithValue("@cabId", cabId)
                                    Dim result As Object = command.ExecuteScalar()
                                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                                        vacancies = Convert.ToInt32(result)
                                    End If
                                End Using
                                If vacancies > 0 Then
                                    gotCab = True
                                    Dim card As New transport_cabCards
                                    card.Label6.Text = transport_cabbooking.FromLocation
                                    card.Label7.Text = transport_cabbooking.ToLocation
                                    card.Label5.Text = arrivalTime.ToString
                                    card.Label8.Text = driverName
                                    FlowLayoutPanel1.Controls.Add(card)
                                End If
                            End If

                        End If
                    Else
                        MessageBox.Show("Cab ID: " & cabId & " does not have corresponding nodes list.")
                    End If

                    ' Arrival time is less than sqlDateTime
                    ' Perform alternative actions here if needed
                    'MessageBox.Show("Cab ID: " & cabId & " has arrival time earlier than the specified date and time.")
                End If
            Next
            If gotCab = False Then
                'MessageBox.Show("gaya kyaaaa")
                Dim availableCabId As Integer = -1

                ' SQL query to select an available cab from the all_cabs table
                Dim falsequery As String = "SELECT cab_id FROM all_cabs WHERE is_available = 1 LIMIT 1"

                Using command As New MySqlCommand(falsequery, conn2)
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        availableCabId = Convert.ToInt32(result)
                    End If
                End Using

                If availableCabId <> -1 Then
                    'MessageBox.Show("arey bc nahi mili? " & availableCabId)
                    Dim driverName As String = ""
                    Dim driverquery As String = "SELECT driver_name FROM all_cabs WHERE cab_id=@cabId"

                    Using command As New MySqlCommand(driverquery, conn2)
                        command.Parameters.AddWithValue("@cabId", availableCabId)
                        Dim result As Object = command.ExecuteScalar()
                        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                            driverName = Convert.ToString(result)
                        End If
                    End Using
                    Dim card As New transport_cabCards
                    card.Label6.Text = transport_cabbooking.FromLocation
                    card.Label7.Text = transport_cabbooking.ToLocation
                    card.Label5.Text = transport_cabbooking.sqlFormattedDateTime.ToString
                    card.Label8.Text = driverName
                    FlowLayoutPanel1.Controls.Add(card)
                Else
                    ' No available cabs
                    MessageBox.Show("No cabs are currently available.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn2.Close()
        End Try
    End Sub

    Private Function extend_path(cabId As Integer) As Boolean
        Dim isPrefixPath As Boolean = True
        Try
            'MessageBox.Show("Inside Extend")
            Dim query As String = "SELECT nodes_list FROM cab_path WHERE from_node = @fromNodeId AND to_node = @toNodeId"
            conn.Open()
            Dim nodesList1 As List(Of Integer)
            Dim fromNodeIndex As Integer
            Dim toNodeIndex As Integer
            If pathNodesMap.ContainsKey(cabId) Then
                ' Retrieve nodes list for the cabId
                nodesList1 = pathNodesMap(cabId)

                ' Check if fromNodeId and toNodeId are in the nodes list
                fromNodeIndex = nodesList1.IndexOf(fromNodeId)
                toNodeIndex = nodesList1.Count - 1
            End If

            Using command As New MySqlCommand(query, conn)
                ' Add parameters to the command
                command.Parameters.AddWithValue("@fromNodeId", fromNodeId)
                command.Parameters.AddWithValue("@toNodeId", toNodeId)

                ' Execute the command and get the result (nodes list)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Dim cabPathNodesList As New List(Of Integer)
                    Dim nodesListString As String = result.ToString()
                    nodesListString = nodesListString.Trim({"{"c, "}"c})
                    Dim nodesArray As String() = nodesListString.Split(","c)
                    For Each nodeStr As String In nodesArray
                        cabPathNodesList.Add(Integer.Parse(nodeStr.Trim()))
                    Next


                    ' Compare the path starting from fromNodeId to the end node of the path in nodesList
                    ' with the path found between fromNodeId and toNodeId from the cab_paths table
                    If cabPathNodesList.Count >= toNodeIndex - fromNodeIndex + 1 Then

                        For i As Integer = 0 To toNodeIndex - fromNodeIndex
                            'MessageBox.Show(cabPathNodesList(i) & " " & nodesList1(fromNodeIndex + i) & " " & cabId)
                            If cabPathNodesList(i) <> nodesList1(fromNodeIndex + i) Then
                                isPrefixPath = False
                                Exit For
                            End If
                        Next
                    Else
                        isPrefixPath = False

                    End If

                    For i As Integer = 0 To fromNodeIndex - 1
                        Dim node As Integer = nodesList1(i)
                        If cabPathNodesList.Contains(node) Then
                            isPrefixPath = False
                            Exit For
                        End If
                    Next
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return isPrefixPath
    End Function

    Private Function GetNodeId(location As String) As Integer
        Dim nodeId As Integer = -1

        Try
            conn.Open()
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
            conn.Close()
        End Try

        Return nodeId
    End Function
    Private Sub RetrieveAndStoreNodesList()
        Try


            conn.Open()

            Dim selectQuery As String = "SELECT r.cab_id, p.nodes_list FROM running_cabs r " &
                                        "INNER JOIN cab_path p ON r.path_id = p.path_id"

            Dim cmd As New MySqlCommand(selectQuery, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim cabId As Integer = 0
            While reader.Read()

                cabId = reader.GetInt32("cab_id")
                Dim nodesList As New List(Of Integer)
                Dim nodesListString As String = reader.GetString("nodes_list")
                ' Parse the nodes_list string and store it as a list of integers
                nodesListString = nodesListString.Trim({"{"c, "}"c})

                Dim nodesArray As String() = nodesListString.Split(","c)
                For Each nodeStr As String In nodesArray
                    nodesList.Add(Integer.Parse(nodeStr.Trim()))
                Next

                ' Add path_id and nodes_list to the dictionary
                pathNodesMap.Add(cabId, nodesList)
            End While

            ' Now you have pathNodesMap containing path_id as key and corresponding nodes_list as value

            ' You can iterate over the dictionary and process the data as needed
            For Each kvp As KeyValuePair(Of Integer, List(Of Integer)) In pathNodesMap
                Dim localId As Integer = kvp.Key
                Dim nodesList As List(Of Integer) = kvp.Value
                For Each nodeValue As Integer In nodesList
                    'MessageBox.Show("Node value" & nodeValue & "from " & fromNodeId)
                    If (nodeValue = fromNodeId) Then
                        'MessageBox.Show("Hehe")
                        ' Add the targetInteger to the foundIntegers list
                        relpathNodesMap.Add(localId, nodesList)
                    End If
                Next

                ' Do something with pathId and nodesList...
                'MessageBox.Show("Cab ID: " & localId & "Nodes List: " & String.Join(",", nodesList))
            Next


        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Function CalculateArrivalTimes()

        'MessageBox.Show(relpathNodesMap.Count)
        ' Iterate through each cab in the relpathNodesMap
        For Each kvp As KeyValuePair(Of Integer, List(Of Integer)) In relpathNodesMap
            Dim cabId As Integer = kvp.Key
            Dim nodesList As List(Of Integer) = kvp.Value
            'MessageBox.Show("Cab ID: " & cabId & "Nodes List: " & String.Join(",", nodesList))
            'Dim arrivalTimes As New List(Of Integer)
            Dim found As Boolean = False
            For Each nodeId As Integer In nodesList
                If nodeId = fromNodeId Then
                    found = True
                    Exit For
                End If
            Next
            ' Check if the nodes_list contains fromNodeid
            If found Then
                Dim totalMinutes As Integer = 0
                'MessageBox.Show("from nodeid found" & cabId)
                ' Iterate through the nodes_list to calculate total time
                For i As Integer = 0 To nodesList.Count - 2
                    Dim sourceNodeId As Integer = nodesList(i)
                    Dim targetNodeId As Integer = nodesList(i + 1)

                    ' Find the edge weight (minutes) from sourceNodeId to targetNodeId
                    Dim edgeWeight As Integer = GetEdgeWeight(sourceNodeId, targetNodeId)

                    ' Add edge weight to total time
                    totalMinutes += edgeWeight
                    If targetNodeId = fromNodeId Then
                        ' Retrieve departure time from the running_cabs table
                        Dim departTime As DateTime = GetDepartureTime(cabId)

                        Dim timeSpan As New TimeSpan(0, totalMinutes, 0)

                        ' Add the TimeSpan to the departure time to get the arrival time
                        Dim arrivalTime As DateTime = departTime.Add(timeSpan)

                        ' Add cabId and arrivalTime to the dictionary
                        cab_arrival_times.Add(cabId, arrivalTime)

                        'MessageBox.Show("Cab Id " & cabId & "Arrival time: " & arrivalTime)
                        ' Exit the loop since the arrival time is determined
                        Exit For


                    End If
                    If i = 0 AndAlso sourceNodeId = fromNodeId Then
                        ' Retrieve departure time from the running_cabs table
                        Dim departTime As DateTime = GetDepartureTime(cabId)

                        ' Add cabId and departTime to the dictionary
                        cab_arrival_times.Add(cabId, departTime)

                        'MessageBox.Show("Cab Id " & cabId & " Departure time: " & departTime)
                    End If
                Next

            End If

        Next

    End Function

    Function GetEdgeWeight(sourceNodeId As Integer, targetNodeId As Integer) As Integer
        Dim edgeWeight As Integer = 0
        'MessageBox.Show("Inside get Edge weight")
        Try

            conn.Open()
            Dim query As String = "SELECT edge_weight FROM cab_edges WHERE source_node_id = @sourceNodeId AND target_node_id = @targetNodeId"

            ' Create SQL connection and command objects
            ' conn.Open()

            Using command As New MySqlCommand(query, conn)
                ' Add parameters to the command
                command.Parameters.AddWithValue("@sourceNodeId", sourceNodeId)
                command.Parameters.AddWithValue("@targetNodeId", targetNodeId)



                ' Execute the command and get the result (edge weight)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    edgeWeight = Convert.ToInt32(result)
                End If
            End Using



        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return edgeWeight
    End Function

    Function GetDepartureTime(cabId As Integer) As DateTime
        Dim departureTime As DateTime = DateTime.MinValue
        'MessageBox.Show("Inside depart time")
        Try
            conn.Open()

            ' SQL query to fetch departure time for the specified cabId
            Dim query As String = "SELECT depart_time FROM running_cabs WHERE cab_id = @cabId"

            ' Create SQL connection and command objects

            Using command As New MySqlCommand(query, conn)
                ' Add parameter to the command
                command.Parameters.AddWithValue("@cabId", cabId)

                ' Open connection


                ' Execute the command and get the result (departure time)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    departureTime = Convert.ToDateTime(result)
                End If

            End Using


        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return departureTime
    End Function

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class