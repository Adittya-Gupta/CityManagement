Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Text
Public Class transport_cabavailable
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim conn2 As New MySqlConnection(connString)
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

    'Create a function that returns a list of integer and takes string as input
    Function getPathFromString(ByVal query As String) As List(Of Integer)
        Dim inputString As String = query
        Dim numbersList As New List(Of Integer)

        ' Extracting numbers using regular expression
        Dim matches As MatchCollection = Regex.Matches(inputString, "\d+")
        For Each match As Match In matches
            numbersList.Add(Integer.Parse(match.Value))
        Next

        Return numbersList
    End Function


    Function getFinalPath(ByVal pathOfUser As List(Of Integer), ByVal pathOfCab As List(Of Integer)) As Tuple(Of List(Of Integer), Boolean)
        Try
            ' Checking that if path of user is a subset of path of cab
            Dim isSubset As Boolean = False
            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim finalPath As New List(Of Integer)
            While i < Math.Max(pathOfCab.Count - pathOfUser.Count + 1, 0)
                Dim k As Integer = 0
                isSubset = True
                While k < pathOfUser.Count
                    If pathOfCab(i + k) <> pathOfUser(k) Then
                        isSubset = False
                        Exit While
                    End If
                    k += 1
                End While
                If isSubset Then
                    Exit While
                End If
                i += 1
            End While
            If isSubset Then
                Dim ret As Tuple(Of List(Of Integer), Boolean) = Tuple.Create(pathOfCab, True)
                Return ret
            End If

            'Checking that if suffix of path of user is prefix of path of cab
            i = pathOfCab.Count - 1
            While i >= pathOfCab.Count - pathOfUser.Count
                Dim k As Integer = 0
                Dim flg As Boolean = True
                While i + k < pathOfCab.Count
                    If pathOfCab(i + k) <> pathOfUser(k) Then
                        flg = False
                        Exit While
                    End If
                    k += 1
                End While
                If flg Then
                    Dim retList As List(Of Integer) = New List(Of Integer)
                    For k = 0 To i - 1
                        retList.Add(pathOfCab(k))
                    Next
                    For k = 0 To pathOfUser.Count - 1
                        retList.Add(pathOfUser(k))
                    Next
                    Dim ret As Tuple(Of List(Of Integer), Boolean) = Tuple.Create(retList, True)
                    Return ret
                End If
                i -= 1
            End While


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Dim ret1 As Tuple(Of List(Of Integer), Boolean) = Tuple.Create(pathOfCab, False)
        Return ret1

        'Checking that if prefix of path of user is suffix of path of cab

    End Function


    Private Sub transport_cabavailable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data, available_cabs As New List(Of Dictionary(Of String, Object))
        Try
            conn.Open()
            Dim query As String = "SELECT node_id, place_name FROM cab_nodes WHERE place_name IN ('" & transport_cabbooking.FromLocation & "')"
            Dim nodeIdFromLocation, nodeIdToLocation As Integer
            Using command As New MySqlCommand(query, conn)
                ' Execute the query
                Using reader1 As MySqlDataReader = command.ExecuteReader()
                    ' Check if there are rows returned
                    If reader1.HasRows Then

                        ' Iterate through the rows
                        While reader1.Read()
                            nodeIdFromLocation = reader1.GetInt32(0) ' Assuming node_id is stored in the first colum
                        End While
                    Else
                        Console.WriteLine("No records found.")
                    End If
                End Using
            End Using
            query = "SELECT node_id, place_name FROM cab_nodes WHERE place_name IN ('" & transport_cabbooking.ToLocation & "')"

            Using command As New MySqlCommand(query, conn)
                ' Execute the query
                Using reader1 As MySqlDataReader = command.ExecuteReader()
                    ' Check if there are rows returned
                    If reader1.HasRows Then

                        ' Iterate through the rows
                        While reader1.Read()
                            nodeIdToLocation = reader1.GetInt32(0) ' Assuming node_id is stored in the first colum
                        End While
                    Else
                        Console.WriteLine("No records found.")
                    End If
                End Using
            End Using
            'Display a message box  
            ' MessageBox.Show("From Location: " & nodeIdFromLocation & " To Location: " & nodeIdToLocation)
            query = "Select * from cab_path where from_node = " & nodeIdFromLocation & " and to_node = " & nodeIdToLocation
            Dim pathOfUser As List(Of Integer) = New List(Of Integer)
            Using command As New MySqlCommand(query, conn)
                ' Execute the query
                Using reader1 As MySqlDataReader = command.ExecuteReader()
                    ' Check if there are rows returned
                    If reader1.HasRows Then

                        ' Iterate through the rows
                        While reader1.Read()
                            pathOfUser = getPathFromString(reader1("nodes_list"))
                        End While
                    Else
                        MessageBox.Show("No records found 1.")
                    End If
                End Using
            End Using
            ' MessageBox.Show("Path of user: " & String.Join(",", pathOfUser))
            query = "Select * from running_cabs"
            'Create a list of dictionary to store the data
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            'First finding all the running cabs and storing it in data
            While reader.Read()
                Dim dict As New Dictionary(Of String, Object)
                For i As Integer = 0 To reader.FieldCount - 1
                    dict.Add(reader.GetName(i), reader.GetValue(i))
                Next
                Data.Add(dict)
            End While
            reader.Close()

            'Next we will filter out the available cabs
            For i As Integer = 0 To Data.Count - 1
                Dim path_id As Integer = Data(i)("path_id")
                query = "Select * from cab_path where path_id = " & path_id
                Dim cmd1 As New MySqlCommand(query, conn)
                Dim path As String = ""
                Using reader2 As MySqlDataReader = cmd1.ExecuteReader()
                    While reader2.Read()
                        path = reader2("nodes_list")
                    End While
                End Using
                Dim pathOfCab As List(Of Integer) = getPathFromString(path)
                Dim time As Integer = 0
                'Now we calculate the time required for the cab to reach from it's starting point to final destination
                For j As Integer = 0 To pathOfCab.Count - 2
                    query = "Select edge_weight from cab_edges where source_node_id = " & pathOfCab(j) & " and target_node_id = " & pathOfCab(j + 1)
                    Dim cmd2 As New MySqlCommand(query, conn)
                    Using reader3 As MySqlDataReader = cmd2.ExecuteReader()
                        While reader3.Read()
                            time += reader3("edge_weight")
                        End While
                    End Using
                Next
                ' MessageBox.Show("Time: " & time)
                Dim depart_time As DateTime = data(i)("depart_time")
                data(i)("reach_time") = depart_time.AddMinutes(time)
                'MessageBox.Show("Path of cab: " & String.Join(",", pathOfCab))
                Dim ret As Tuple(Of List(Of Integer), Boolean) = getFinalPath(pathOfUser, pathOfCab)
                ' MessageBox.Show(ret.Item2)
                If ret.Item2 Then
                    Dim finalPath As List(Of Integer) = ret.Item1
                    data(i)("final_path") = String.Join(",", finalPath)

                    available_cabs.Add(Data(i))
                    ' MessageBox.Show("Final Path: " & String.Join(",", finalPath))
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        For i As Integer = 0 To available_cabs.Count - 1
            Dim Card As New transport_cabCards
            Card.Label6.Text = available_cabs(i)("from_location")
            Card.Label7.Text = available_cabs(i)("to_location")
            'Get the time from the date time object
            Dim depart_time As DateTime = available_cabs(i)("depart_time")
            Dim reach_time As DateTime = available_cabs(i)("reach_time")
            ' MessageBox.Show(available_cabs(i)("depart_time"))
            Card.Label4.Text = depart_time.ToString("HH:mm tt")
            Card.Label5.Text = reach_time.ToString("HH:mm tt")
            FlowLayoutPanel1.Controls.Add(Card)
        Next
    End Sub
End Class