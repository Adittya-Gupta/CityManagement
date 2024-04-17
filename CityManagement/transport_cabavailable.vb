Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Text
Imports Org.BouncyCastle.Asn1.Ocsp
Imports System.Globalization
Public Class transport_cabavailable
    Dim connString As String = Globals.connectionstring
    Dim conn As New MySqlConnection(connString)
    Dim conn2 As New MySqlConnection(connString)
    Dim pathNodesMap As New Dictionary(Of Integer, List(Of Integer))
    Dim relpathNodesMap As New Dictionary(Of Integer, List(Of Integer))
    Public Shared fromNodeId As Integer
    Public Shared toNodeId As Integer
    Public Shared cab_arrival_times As New Dictionary(Of Integer, DateTime)
    Public Shared selected_cab As Integer
    Public Shared extended As Integer = 0
    Public Shared newcab As Integer = 0
    Public Shared cab_arrival As DateTime
    Public Shared cost As Decimal
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
        pathNodesMap.Clear()
        relpathNodesMap.Clear()
        cab_arrival_times.Clear()
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.ControlBox = False
        Me.Text = ""
        Try
            conn2.Open()
            Dim query As String = "Select * from running_cabs"
            'Create a list of dictionary to store the data
            Dim data As New List(Of Dictionary(Of String, Object))
            Dim cmd As New MySqlCommand(query, conn2)

            ' Retrieve the node IDs for the from and to locations
            fromNodeId = GetNodeId(transport_cabbooking.FromLocation)
            toNodeId = GetNodeId(transport_cabbooking.ToLocation)
            ' MessageBox.Show(fromNodeId & toNodeId)
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
                        Dim pricequery As String = "SELECT price FROM all_cabs WHERE cab_id = @CabId"
                        Dim price As Decimal = 0.0
                        Using command As New MySqlCommand(pricequery, conn2)
                            command.Parameters.AddWithValue("@CabId", cabId)
                            Dim result As Object = command.ExecuteScalar()

                            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                                price = Convert.ToDecimal(result)
                                ' Do something with the price (e.g., display it, use it in calculations, etc.)
                                'MessageBox.Show($"The price for cab ID {cabId} is {price}")
                            Else
                                ' MessageBox.Show("No price found for the specified cab ID.")
                            End If
                        End Using
                        'MessageBox.Show(fromNodeId & " " & toNodeId)
                        Dim nodequery As String = "SELECT nodes_list FROM cab_path WHERE from_node = @fromNodeId AND to_node = @toNodeId"
                        Dim cabPathNodesList As New List(Of Integer)
                        Using command As New MySqlCommand(nodequery, conn2)
                            command.Parameters.AddWithValue("@fromNodeId", fromNodeId)
                            command.Parameters.AddWithValue("@toNodeId", toNodeId)
                            ' MessageBox.Show(fromNodeId & " " & toNodeId & transport_cabbooking.FromLocation & " " & transport_cabbooking.ToLocation)
                            ' Execute the command and get the result (nodes list)
                            Dim result As Object = command.ExecuteScalar()
                            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                                'MessageBox.Show("Inside ectend 3")

                                Dim nodesListString As String = result.ToString()
                                ' MessageBox.Show(nodesListString)
                                nodesListString = nodesListString.Trim({"{"c, "}"c})
                                'MessageBox.Show("nodes list str trimmed")
                                Dim nodesArray As String() = nodesListString.Split(","c)
                                ' MessageBox.Show("nodes list str split")
                                For Each nodeStr As String In nodesArray
                                    'MessageBox.Show(Integer.Parse(nodeStr.Trim()))
                                    cabPathNodesList.Add(Integer.Parse(nodeStr.Trim()))
                                    'MessageBox.Show("done")
                                Next
                            End If
                        End Using
                        'MessageBox.Show("out")
                        Dim totalMinutes As Integer = 0
                        For i As Integer = 0 To cabPathNodesList.Count - 2
                            'MessageBox.Show("just")
                            Dim sourceNodeId As Integer = cabPathNodesList(i)
                            'MessageBox.Show("inside")
                            Dim targetNodeId As Integer = cabPathNodesList(i + 1)
                            ' MessageBox.Show("Inside for")
                            ' Find the edge weight (minutes) from sourceNodeId to targetNodeId
                            Dim edgeWeight As Integer = GetEdgeWeight(sourceNodeId, targetNodeId)

                            ' Add edge weight to total time
                            totalMinutes += edgeWeight

                        Next
                        'MessageBox.Show(totalMinutes)
                        price = price * totalMinutes
                        'MessageBox.Show(price)
                        ' Check if fromNodeId and toNodeId are in the nodes list
                        Dim fromNodeIndex As Integer = nodesList.IndexOf(fromNodeId)
                        Dim toNodeIndex As Integer = nodesList.IndexOf(toNodeId)
                        'MessageBox.Show("from: " & fromNodeIndex & " to: " & toNodeIndex)
                        ' Check if both fromNodeId and toNodeId are present and toNodeId occurs after fromNodeId
                        If fromNodeIndex <> -1 AndAlso toNodeIndex <> -1 AndAlso toNodeIndex > fromNodeIndex Then
                            MessageBox.Show("Cab ID: " & cabId & " contains the required route as subpath of current cab route.")

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
                                card.Label3.Text = "Rs. " & price
                                AddHandler card.Button2.Click, Sub()
                                                                   banking_recv_username = "transport"
                                                                   banking_recv_name = "transport"

                                                                   Go_Back = 2
                                                                   Go_Back_Form = Me
                                                                   banking_payment_amount = price

                                                                   Banking_Main.Panel1.Controls.Clear()
                                                                   Newsletter_Main.Panel1.Controls.Clear()

                                                                   ChildForm(Banking_Main.Panel1, Banking_Homepage)
                                                                   mypanel.panel1.Controls.Clear()
                                                                   ChildForm2(Banking_Main)
                                                               End Sub
                                AddHandler card.Button1.Click, Sub()
                                                                   ' Open the page here
                                                                   ' For example, you can open a new form
                                                                   If Global_Attributes.banking_payment_done = 0 Then
                                                                       MessageBox.Show("Please make payment first!")
                                                                       Return
                                                                   End If
                                                                   Global_Attributes.banking_payment_done = 0
                                                                   cost = price
                                                                   selected_cab = cabId
                                                                   cab_arrival = arrivalTime
                                                                   'Dim newForm As New transport_cabconfirm()
                                                                   'Dim newForm As New transport_cabconfirm()



                                                                   Dim email As String = ""
                                                                   Dim contactNo As String = ""
                                                                   Dim name As String = ""
                                                                   Dim sid As Integer = transport_landingPage.SID

                                                                   ' SQL query to fetch data from the User table based on SID
                                                                   Dim selectQuery As String = "SELECT Name, EmailAddress, ContactNo FROM User WHERE SID = @sid"


                                                                   ' Open the connection
                                                                   conn2.Open()

                                                                   ' Create a command for SELECT query
                                                                   Using selectCommand As New MySqlCommand(selectQuery, conn2)
                                                                       ' Add parameters for SID
                                                                       selectCommand.Parameters.AddWithValue("@SID", sid)

                                                                       ' Execute the SELECT query and get the reader
                                                                       Using reader As MySqlDataReader = selectCommand.ExecuteReader()

                                                                           ' Check if there are rows returned
                                                                           If reader.HasRows Then
                                                                               ' Read the data and store it in variables
                                                                               reader.Read()
                                                                               name = reader("Name").ToString()
                                                                               email = reader("EmailAddress").ToString()
                                                                               contactNo = reader("ContactNo").ToString()
                                                                           Else
                                                                               MessageBox.Show("No data found for the given SID.")
                                                                           End If
                                                                       End Using


                                                                   End Using
                                                                   Dim userEmail = email
                                                                   Dim selectedCabId = selected_cab

                                                                   Dim checksqlQuery As String = "SELECT COUNT(*) FROM cab_user WHERE user_id = @SID"
                                                                   Using command As New MySqlCommand(checksqlQuery, conn2)
                                                                       command.Parameters.AddWithValue("@SID", transport_landingPage.SID)

                                                                       Dim rowCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                                                                       If rowCount = 0 Then
                                                                           ' SQL query to insert data into cab_users table
                                                                           Dim insertQuery As String = "INSERT INTO cab_user (user_id, name, email, phone, current_ride, current_from, current_to, current_arrival, current_cost) 
                                                    VALUES (@SID, @Name, @EmailAddress, @ContactNo, @selectedCabId, @from, @to, @time, @price)"

                                                                           ' Create a command for INSERT query
                                                                           Using insertCommand As New MySqlCommand(insertQuery, conn2)
                                                                               ' Add parameters for INSERT query
                                                                               insertCommand.Parameters.AddWithValue("@SID", transport_landingPage.SID)
                                                                               insertCommand.Parameters.AddWithValue("@Name", name)
                                                                               insertCommand.Parameters.AddWithValue("@EmailAddress", email)
                                                                               insertCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                                                                               insertCommand.Parameters.AddWithValue("@ContactNo", contactNo)
                                                                               insertCommand.Parameters.AddWithValue("@from", transport_cabbooking.FromLocation)
                                                                               insertCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                                                                               insertCommand.Parameters.AddWithValue("@time", cab_arrival)
                                                                               insertCommand.Parameters.AddWithValue("@price", cost)

                                                                               ' Execute the INSERT query
                                                                               insertCommand.ExecuteNonQuery()
                                                                               'MessageBox.Show("Data inserted successfully into cab_users table.")
                                                                           End Using
                                                                       Else
                                                                           Dim updateUserCabQuery = "UPDATE cab_user SET current_ride = @selectedCabId, current_from = @from, current_to=@to, current_arrival = @time,current_cost = @price WHERE user_id = @id"
                                                                           Using updateUserCabCommand As New MySqlCommand(updateUserCabQuery, conn2)
                                                                               updateUserCabCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                                                                               updateUserCabCommand.Parameters.AddWithValue("@id", transport_landingPage.SID)
                                                                               updateUserCabCommand.Parameters.AddWithValue("@from", transport_cabbooking.FromLocation)
                                                                               updateUserCabCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                                                                               updateUserCabCommand.Parameters.AddWithValue("@time", cab_arrival)
                                                                               updateUserCabCommand.Parameters.AddWithValue("@price", cost)
                                                                               updateUserCabCommand.ExecuteNonQuery()
                                                                           End Using
                                                                       End If
                                                                   End Using
                                                                   Dim updateRunningCabQuery = "UPDATE running_cabs SET vacancies = vacancies - 1 WHERE cab_id = @selectedCabId"
                                                                   Using updateRunningCabCommand As New MySqlCommand(updateRunningCabQuery, conn2)
                                                                       updateRunningCabCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                                                                       updateRunningCabCommand.ExecuteNonQuery()
                                                                   End Using

                                                                   MessageBox.Show("Cab booking confirmed. Enjoy the ride!")
                                                                   'newForm.ShowDialog()
                                                                   conn2.Close()
                                                               End Sub

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
                                    card.Label3.Text = "Rs. " & price
                                    AddHandler card.Button2.Click, Sub()
                                                                       banking_recv_username = "transport"
                                                                       banking_recv_name = "transport"

                                                                       Go_Back = 2
                                                                       Go_Back_Form = Me
                                                                       banking_payment_amount = price

                                                                       Banking_Main.Panel1.Controls.Clear()
                                                                       Newsletter_Main.Panel1.Controls.Clear()

                                                                       ChildForm(Banking_Main.Panel1, Banking_Homepage)
                                                                       mypanel.panel1.Controls.Clear()
                                                                       ChildForm2(Banking_Main)
                                                                   End Sub
                                    AddHandler card.Button1.Click, Sub()
                                                                       ' Open the page here
                                                                       ' For example, you can open a new form
                                                                       If Global_Attributes.banking_payment_done = 0 Then
                                                                           MessageBox.Show("Please make payment first!")
                                                                           Return
                                                                       End If
                                                                       cost = price
                                                                       extended = newPathId
                                                                       selected_cab = cabId
                                                                       cab_arrival = arrivalTime
                                                                       'Dim newForm As New transport_cabconfirm()
                                                                       Dim email As String = ""
                                                                       Dim contactNo As String = ""
                                                                       Dim name As String = ""
                                                                       Dim sid As Integer = transport_landingPage.SID

                                                                       ' SQL query to fetch data from the User table based on SID
                                                                       Dim selectQuery As String = "SELECT Name, EmailAddress, ContactNo FROM User WHERE SID = @sid"


                                                                       ' Open the connection

                                                                       conn2.Open()
                                                                       ' Create a command for SELECT query
                                                                       Using selectCommand As New MySqlCommand(selectQuery, conn2)
                                                                           ' Add parameters for SID
                                                                           selectCommand.Parameters.AddWithValue("@SID", sid)

                                                                           ' Execute the SELECT query and get the reader
                                                                           Using reader As MySqlDataReader = selectCommand.ExecuteReader()

                                                                               ' Check if there are rows returned
                                                                               If reader.HasRows Then
                                                                                   ' Read the data and store it in variables
                                                                                   reader.Read()
                                                                                   name = reader("Name").ToString()
                                                                                   email = reader("EmailAddress").ToString()
                                                                                   contactNo = reader("ContactNo").ToString()
                                                                               Else
                                                                                   MessageBox.Show("No data found for the given SID.")
                                                                               End If
                                                                           End Using


                                                                       End Using
                                                                       Dim userEmail = email
                                                                       Dim selectedCabId = selected_cab

                                                                       Dim checksqlQuery As String = "SELECT COUNT(*) FROM cab_user WHERE user_id = @SID"
                                                                       Using command As New MySqlCommand(checksqlQuery, conn2)
                                                                           command.Parameters.AddWithValue("@SID", transport_landingPage.SID)

                                                                           Dim rowCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                                                                           If rowCount = 0 Then
                                                                               ' SQL query to insert data into cab_users table
                                                                               Dim insertQuery As String = "INSERT INTO cab_user (user_id, name, email, phone, current_ride, current_from, current_to, current_arrival, current_cost) 
                                                    VALUES (@SID, @Name, @EmailAddress, @ContactNo, @selectedCabId, @from, @to, @time, @price)"

                                                                               ' Create a command for INSERT query
                                                                               Using insertCommand As New MySqlCommand(insertQuery, conn2)
                                                                                   ' Add parameters for INSERT query
                                                                                   insertCommand.Parameters.AddWithValue("@SID", transport_landingPage.SID)
                                                                                   insertCommand.Parameters.AddWithValue("@Name", name)
                                                                                   insertCommand.Parameters.AddWithValue("@EmailAddress", email)
                                                                                   insertCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                                                                                   insertCommand.Parameters.AddWithValue("@ContactNo", contactNo)
                                                                                   insertCommand.Parameters.AddWithValue("@from", transport_cabbooking.FromLocation)
                                                                                   insertCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                                                                                   insertCommand.Parameters.AddWithValue("@time", cab_arrival)
                                                                                   insertCommand.Parameters.AddWithValue("@price", cost)

                                                                                   ' Execute the INSERT query
                                                                                   insertCommand.ExecuteNonQuery()
                                                                                   'MessageBox.Show("Data inserted successfully into cab_users table.")
                                                                               End Using
                                                                           Else
                                                                               Dim updateUserCabQuery = "UPDATE cab_user SET current_ride = @selectedCabId, current_from = @from, current_to=@to, current_arrival = @time,current_cost = @price WHERE user_id = @id"
                                                                               Using updateUserCabCommand As New MySqlCommand(updateUserCabQuery, conn2)
                                                                                   updateUserCabCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                                                                                   updateUserCabCommand.Parameters.AddWithValue("@id", transport_landingPage.SID)
                                                                                   updateUserCabCommand.Parameters.AddWithValue("@from", transport_cabbooking.FromLocation)
                                                                                   updateUserCabCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                                                                                   updateUserCabCommand.Parameters.AddWithValue("@time", cab_arrival)
                                                                                   updateUserCabCommand.Parameters.AddWithValue("@price", cost)
                                                                                   updateUserCabCommand.ExecuteNonQuery()
                                                                               End Using
                                                                           End If
                                                                       End Using
                                                                       ' Update running_cab with new path ID
                                                                       'Dim newPathId = GetNewPathId(transport_cabbooking.FromLocation, transport_cabbooking.ToLocation)
                                                                       Dim updateRunningCabQuery = "UPDATE running_cabs SET path_id = @newPathId,vacancies = vacancies - 1,to_location=@to WHERE cab_id = @selectedCabId"
                                                                       Using updateRunningCabCommand As New MySqlCommand(updateRunningCabQuery, conn2)
                                                                           updateRunningCabCommand.Parameters.AddWithValue("@newPathId", extended)
                                                                           updateRunningCabCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                                                                           updateRunningCabCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                                                                           updateRunningCabCommand.ExecuteNonQuery()
                                                                       End Using
                                                                       MessageBox.Show("Cab booking confirmed. Enjoy the ride!")
                                                                       conn2.Close()
                                                                       'newForm.ShowDialog()
                                                                   End Sub
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
                    ' MessageBox.Show("arey bc nahi mili? " & availableCabId)
                    'MessageBox.Show(fromNodeId & " " & toNodeId & transport_cabbooking.FromLocation & " " & transport_cabbooking.ToLocation)
                    'Dim nodesList As List(Of Integer) = pathNodesMap(availableCabId)
                    Dim pricequery As String = "SELECT price FROM all_cabs WHERE cab_id = @CabId"
                    Dim price As Decimal = 0.0
                    Using command As New MySqlCommand(pricequery, conn2)
                        command.Parameters.AddWithValue("@CabId", availableCabId)
                        Dim result As Object = command.ExecuteScalar()

                        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                            price = Convert.ToDecimal(result)
                            ' Do something with the price (e.g., display it, use it in calculations, etc.)
                            MessageBox.Show($"The price for cab ID {availableCabId} is {price}")
                        Else
                            MessageBox.Show("No price found for the specified cab ID.")
                        End If
                    End Using

                    Dim nodequery As String = "SELECT nodes_list FROM cab_path WHERE from_node = @fromNodeId AND to_node = @toNodeId"
                    Dim cabPathNodesList As New List(Of Integer)
                    Using command As New MySqlCommand(nodequery, conn2)
                        command.Parameters.AddWithValue("@fromNodeId", fromNodeId)
                        command.Parameters.AddWithValue("@toNodeId", toNodeId)
                        'MessageBox.Show(fromNodeId & " " & toNodeId & transport_cabbooking.FromLocation & " " & transport_cabbooking.ToLocation)
                        ' Execute the command and get the result (nodes list)
                        Dim result As Object = command.ExecuteScalar()
                        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                            'MessageBox.Show("Inside ectend 3")

                            Dim nodesListString As String = result.ToString()
                            nodesListString = nodesListString.Trim({"{"c, "}"c})
                            Dim nodesArray As String() = nodesListString.Split(","c)
                            For Each nodeStr As String In nodesArray
                                cabPathNodesList.Add(Integer.Parse(nodeStr.Trim()))
                                'MessageBox.Show(Integer.Parse(nodeStr.Trim()) + " ")
                            Next
                        End If
                    End Using
                    Dim totalMinutes As Integer = 0
                    For i As Integer = 0 To cabPathNodesList.Count - 2
                        Dim sourceNodeId As Integer = cabPathNodesList(i)
                        Dim targetNodeId As Integer = cabPathNodesList(i + 1)

                        ' Find the edge weight (minutes) from sourceNodeId to targetNodeId
                        Dim edgeWeight As Integer = GetEdgeWeight(sourceNodeId, targetNodeId)

                        ' Add edge weight to total time
                        totalMinutes += edgeWeight

                    Next
                    price = price * totalMinutes
                    Dim driverName As String = ""
                    Dim driverquery As String = "SELECT driver_name FROM all_cabs WHERE cab_id=@cabId"

                    Using command As New MySqlCommand(driverquery, conn2)
                        command.Parameters.AddWithValue("@cabId", availableCabId)
                        Dim result As Object = command.ExecuteScalar()
                        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                            driverName = Convert.ToString(result)
                        End If
                    End Using

                    cab_arrival = transport_cabbooking.sqlFormattedDateTime
                    Dim card As New transport_cabCards
                    card.Label6.Text = transport_cabbooking.FromLocation
                    card.Label7.Text = transport_cabbooking.ToLocation
                    card.Label5.Text = transport_cabbooking.sqlFormattedDateTime.ToString
                    card.Label8.Text = driverName
                    card.Label3.Text = "Rs. " & price
                    AddHandler card.Button2.Click, Sub()
                                                       banking_recv_username = "transport"
                                                       banking_recv_name = "transport"

                                                       Go_Back = 2
                                                       Go_Back_Form = Me
                                                       banking_payment_amount = price

                                                       Banking_Main.Panel1.Controls.Clear()
                                                       Newsletter_Main.Panel1.Controls.Clear()

                                                       ChildForm(Banking_Main.Panel1, Banking_Homepage)
                                                       mypanel.panel1.Controls.Clear()
                                                       ChildForm2(Banking_Main)
                                                   End Sub
                    AddHandler card.Button1.Click, Sub()
                                                       If Global_Attributes.banking_payment_done = 0 Then
                                                           MessageBox.Show("Please make payment first!")
                                                           Return
                                                       End If
                                                       selected_cab = availableCabId
                                                       newcab = 1
                                                       cost = price
                                                       Dim email As String = ""
                                                       Dim contactNo As String = ""
                                                       Dim name As String = ""
                                                       Dim sid As Integer = transport_landingPage.SID

                                                       ' SQL query to fetch data from the User table based on SID
                                                       Dim selectQuery As String = "SELECT Name, EmailAddress, ContactNo FROM User WHERE SID = @sid"


                                                       ' Open the connection
                                                       conn2.Open()

                                                       ' Create a command for SELECT query
                                                       Using selectCommand As New MySqlCommand(selectQuery, conn2)
                                                           ' Add parameters for SID
                                                           selectCommand.Parameters.AddWithValue("@SID", sid)

                                                           ' Execute the SELECT query and get the reader
                                                           Using reader As MySqlDataReader = selectCommand.ExecuteReader()

                                                               ' Check if there are rows returned
                                                               If reader.HasRows Then
                                                                   ' Read the data and store it in variables
                                                                   reader.Read()
                                                                   name = reader("Name").ToString()
                                                                   email = reader("EmailAddress").ToString()
                                                                   contactNo = reader("ContactNo").ToString()
                                                               Else
                                                                   MessageBox.Show("No data found for the given SID.")
                                                               End If
                                                           End Using


                                                       End Using
                                                       Dim userEmail = email
                                                       Dim selectedCabId = selected_cab

                                                       Dim checksqlQuery As String = "SELECT COUNT(*) FROM cab_user WHERE user_id = @SID"
                                                       Using command As New MySqlCommand(checksqlQuery, conn2)
                                                           command.Parameters.AddWithValue("@SID", transport_landingPage.SID)

                                                           Dim rowCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                                                           If rowCount = 0 Then
                                                               ' SQL query to insert data into cab_users table
                                                               Dim insertQuery As String = "INSERT INTO cab_user (user_id, name, email, phone, current_ride, current_from, current_to, current_arrival, current_cost) 
                                                    VALUES (@SID, @Name, @EmailAddress, @ContactNo, @selectedCabId, @from, @to, @time, @price)"

                                                               ' Create a command for INSERT query
                                                               Using insertCommand As New MySqlCommand(insertQuery, conn2)
                                                                   ' Add parameters for INSERT query
                                                                   insertCommand.Parameters.AddWithValue("@SID", transport_landingPage.SID)
                                                                   insertCommand.Parameters.AddWithValue("@Name", name)
                                                                   insertCommand.Parameters.AddWithValue("@EmailAddress", email)
                                                                   insertCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                                                                   insertCommand.Parameters.AddWithValue("@ContactNo", contactNo)
                                                                   insertCommand.Parameters.AddWithValue("@from", transport_cabbooking.FromLocation)
                                                                   insertCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                                                                   insertCommand.Parameters.AddWithValue("@time", cab_arrival)
                                                                   insertCommand.Parameters.AddWithValue("@price", cost)

                                                                   ' Execute the INSERT query
                                                                   insertCommand.ExecuteNonQuery()
                                                                   'MessageBox.Show("Data inserted successfully into cab_users table.")
                                                               End Using
                                                           Else
                                                               Dim updateUserCabQuery = "UPDATE cab_user SET current_ride = @selectedCabId, current_from = @from, current_to=@to, current_arrival = @time,current_cost = @price WHERE user_id = @id"
                                                               Using updateUserCabCommand As New MySqlCommand(updateUserCabQuery, conn2)
                                                                   updateUserCabCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                                                                   updateUserCabCommand.Parameters.AddWithValue("@id", transport_landingPage.SID)
                                                                   updateUserCabCommand.Parameters.AddWithValue("@from", transport_cabbooking.FromLocation)
                                                                   updateUserCabCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                                                                   updateUserCabCommand.Parameters.AddWithValue("@time", cab_arrival)
                                                                   updateUserCabCommand.Parameters.AddWithValue("@price", cost)
                                                                   updateUserCabCommand.ExecuteNonQuery()
                                                               End Using
                                                           End If
                                                       End Using
                                                       Dim isSharable = 1
                                                       Dim vacancyquery = "SELECT max_limit FROM all_cabs WHERE cab_id=@cabId"
                                                       Dim vacancies = -1
                                                       Using command As New MySqlCommand(vacancyquery, conn2)
                                                           command.Parameters.AddWithValue("@cabId", selectedCabId)
                                                           Dim result = command.ExecuteScalar
                                                           If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                                                               vacancies = Convert.ToInt32(result)
                                                           End If
                                                       End Using
                                                       'MessageBox.Show(vacancies)
                                                       Dim available = 0
                                                       Dim updatecab = "UPDATE all_cabs SET is_available = @avail WHERE cab_id = @cabId"
                                                       Using cmd2 As New MySqlCommand(updatecab, conn2)
                                                           cmd2.Parameters.AddWithValue("@cabId", selectedCabId)
                                                           cmd2.Parameters.AddWithValue("@avail", available)
                                                           cmd2.ExecuteNonQuery()
                                                       End Using
                                                       'MessageBox.Show("OOF")
                                                       Dim newPathId = -1
                                                       'MessageBox.Show(transport_cabbooking.FromLocation & " " & transport_cabbooking.ToLocation)
                                                       Dim newPathIdQuery = "SELECT path_id FROM cab_path WHERE from_node = @fromLocation AND to_node = @toLocation"
                                                       Using newPathIdCommand As New MySqlCommand(newPathIdQuery, conn2)
                                                           newPathIdCommand.Parameters.AddWithValue("@fromLocation", fromNodeId)
                                                           newPathIdCommand.Parameters.AddWithValue("@toLocation", toNodeId)
                                                           Dim result = newPathIdCommand.ExecuteScalar
                                                           If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                                                               newPathId = Convert.ToInt32(result)
                                                           End If
                                                       End Using
                                                       'MessageBox.Show(newPathId)
                                                       'MessageBox.Show(selectedCabId)
                                                       Dim insertRunningCabQuery = "INSERT INTO running_cabs (cab_id, path_id,from_location,to_location,depart_time,vacancies,is_sharable) VALUES (@selectedCabId, @newPathId,@from, @to, @depart,@vacancies, @shared)"
                                                       Using insertRunningCabCommand As New MySqlCommand(insertRunningCabQuery, conn2)
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
                                                       conn2.Close()
                                                   End Sub
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

    Private Sub CardButton_Click(sender As Object, e As EventArgs)
        Dim email As String = ""
        Dim contactNo As String = ""
        Dim name As String = ""
        Try
            Dim sid As Integer = transport_landingPage.SID

            ' SQL query to fetch data from the User table based on SID
            Dim selectQuery As String = "SELECT Name, EmailAddress, ContactNo FROM User WHERE SID = @sid"


            ' Open the connection
            conn.Open()

            ' Create a command for SELECT query
            Using selectCommand As New MySqlCommand(selectQuery, conn)
                ' Add parameters for SID
                selectCommand.Parameters.AddWithValue("@SID", sid)

                ' Execute the SELECT query and get the reader
                Using reader As MySqlDataReader = selectCommand.ExecuteReader()

                    ' Check if there are rows returned
                    If reader.HasRows Then
                        ' Read the data and store it in variables
                        reader.Read()
                        name = reader("Name").ToString()
                        email = reader("EmailAddress").ToString()
                        contactNo = reader("ContactNo").ToString()
                    Else
                        MessageBox.Show("No data found for the given SID.")
                    End If
                End Using


            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Try
            Dim userEmail = email
            Dim selectedCabId = selected_cab
            conn.Open()

            Dim checksqlQuery As String = "SELECT COUNT(*) FROM cab_user WHERE user_id = @SID"
            Using command As New MySqlCommand(checksqlQuery, conn)
                command.Parameters.AddWithValue("@SID", transport_landingPage.SID)

                Dim rowCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                If rowCount = 0 Then
                    ' SQL query to insert data into cab_users table
                    Dim insertQuery As String = "INSERT INTO cab_user (user_id, name, email, phone, current_ride, current_from, current_to, current_arrival, current_cost) 
                                                    VALUES (@SID, @Name, @EmailAddress, @ContactNo, @selectedCabId, @from, @to, @time, @price)"

                    ' Create a command for INSERT query
                    Using insertCommand As New MySqlCommand(insertQuery, conn)
                        ' Add parameters for INSERT query
                        insertCommand.Parameters.AddWithValue("@SID", transport_landingPage.SID)
                        insertCommand.Parameters.AddWithValue("@Name", name)
                        insertCommand.Parameters.AddWithValue("@EmailAddress", email)
                        insertCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                        insertCommand.Parameters.AddWithValue("@ContactNo", contactNo)
                        insertCommand.Parameters.AddWithValue("@from", transport_cabbooking.FromLocation)
                        insertCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                        insertCommand.Parameters.AddWithValue("@time", cab_arrival)
                        insertCommand.Parameters.AddWithValue("@price", cost)

                        ' Execute the INSERT query
                        insertCommand.ExecuteNonQuery()
                        'MessageBox.Show("Data inserted successfully into cab_users table.")
                    End Using
                Else
                    Dim updateUserCabQuery = "UPDATE cab_user SET current_ride = @selectedCabId, current_from = @from, current_to=@to, current_arrival = @time,current_cost = @price WHERE user_id = @id"
                    Using updateUserCabCommand As New MySqlCommand(updateUserCabQuery, conn)
                        updateUserCabCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                        updateUserCabCommand.Parameters.AddWithValue("@id", transport_landingPage.SID)
                        updateUserCabCommand.Parameters.AddWithValue("@from", transport_cabbooking.FromLocation)
                        updateUserCabCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                        updateUserCabCommand.Parameters.AddWithValue("@time", cab_arrival)
                        updateUserCabCommand.Parameters.AddWithValue("@price", cost)
                        updateUserCabCommand.ExecuteNonQuery()
                    End Using
                End If
            End Using

            If extended <> 0 Then
                ' Update running_cab with new path ID
                Dim newPathId = GetNewPathId(transport_cabbooking.FromLocation, transport_cabbooking.ToLocation)
                Dim updateRunningCabQuery = "UPDATE running_cabs SET path_id = @newPathId,vacancies = vacancies - 1,to_location=@to WHERE cab_id = @selectedCabId"
                Using updateRunningCabCommand As New MySqlCommand(updateRunningCabQuery, conn)
                    updateRunningCabCommand.Parameters.AddWithValue("@newPathId", extended)
                    updateRunningCabCommand.Parameters.AddWithValue("@to", transport_cabbooking.ToLocation)
                    updateRunningCabCommand.Parameters.AddWithValue("@selectedCabId", selectedCabId)
                    updateRunningCabCommand.ExecuteNonQuery()
                End Using
                MessageBox.Show("Cab booking confirmed. Enjoy the ride!")
            ElseIf newcab = 1 Then
                ' Insert a new entry in running_cabs table
                'MessageBox.Show("New cabbbbb")
                'MessageBox.Show(selectedCabId)
                'MessageBox.Show(fromNodeId & toNodeId)

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
                'MessageBox.Show(vacancies)
                Dim available = 0
                Dim updatecab = "UPDATE all_cabs SET is_available = @avail WHERE cab_id = @cabId"
                Using cmd As New MySqlCommand(updatecab, conn)
                    cmd.Parameters.AddWithValue("@cabId", selectedCabId)
                    cmd.Parameters.AddWithValue("@avail", available)
                    cmd.ExecuteNonQuery()
                End Using
                'MessageBox.Show("OOF")
                Dim newPathId = -1
                'MessageBox.Show(transport_cabbooking.FromLocation & " " & transport_cabbooking.ToLocation)
                Dim newPathIdQuery = "SELECT path_id FROM cab_path WHERE from_node = @fromLocation AND to_node = @toLocation"
                Using newPathIdCommand As New MySqlCommand(newPathIdQuery, conn)
                    newPathIdCommand.Parameters.AddWithValue("@fromLocation", fromNodeId)
                    newPathIdCommand.Parameters.AddWithValue("@toLocation", toNodeId)
                    Dim result = newPathIdCommand.ExecuteScalar
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        newPathId = Convert.ToInt32(result)
                    End If
                End Using
                'MessageBox.Show(newPathId)
                'MessageBox.Show(selectedCabId)
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
                'MessageBox.Show(fromNodeId & " " & toNodeId & transport_cabbooking.FromLocation & " " & transport_cabbooking.ToLocation)
                ' Execute the command and get the result (nodes list)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    'MessageBox.Show("Inside ectend 3")
                    Dim cabPathNodesList As New List(Of Integer)
                    Dim nodesListString As String = result.ToString()
                    nodesListString = nodesListString.Trim({"{"c, "}"c})
                    Dim nodesArray As String() = nodesListString.Split(","c)
                    For Each nodeStr As String In nodesArray
                        cabPathNodesList.Add(Integer.Parse(nodeStr.Trim()))
                        'MessageBox.Show(Integer.Parse(nodeStr.Trim()) + " ")
                    Next


                    ' Compare the path starting from fromNodeId to the end node of the path in nodesList
                    ' with the path found between fromNodeId and toNodeId from the cab_paths table
                    If cabPathNodesList.Count >= toNodeIndex - fromNodeIndex + 1 Then
                        'MessageBox.Show("this one 2")
                        For i As Integer = 0 To toNodeIndex - fromNodeIndex
                            'MessageBox.Show(cabPathNodesList(i) & " " & nodesList1(fromNodeIndex + i) & " " & cabId)
                            If cabPathNodesList(i) <> nodesList1(fromNodeIndex + i) Then
                                isPrefixPath = False
                                Exit For
                            End If
                        Next
                    Else
                        'MessageBox.Show("this one 1")
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New transport_cabbooking
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Public Shared Sub ChildForm2(ByVal childform As Form)
        mypanel.panel1.Controls.Clear()
        childform.TopLevel = False
        mypanel.panel1.Controls.Add(childform)
        childform.Show()
    End Sub
End Class