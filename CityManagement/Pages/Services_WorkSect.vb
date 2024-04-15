Imports System.IO
Imports CityManagement.SerReq_worker_accepted
Imports CityManagement.SerReq_worker_completed
Imports CityManagement.SerReq_worker_pending
Imports MySql.Data.MySqlClient

Public Class Services_WorkSect
    'Dim connString As String = "server=localhost;userid=root;password=pwd;database=smart_city_management"
    Dim connString As String = Module1.connString
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim workerID As Integer ' Worker ID of the current user
    'Dim userID As Integer = 112546 ' User ID of the applicant
    Dim userID As Integer = Module1.CurrUserSID
    Public Sub New()
        InitializeComponent()

        ' Populate the ComboBox with filter options
        Guna2ComboBox1.Items.AddRange({"All", "Pending", "Accepted", "Completed", "Payment_Due"})
        Guna2ComboBox1.SelectedIndex = 0 ' Select "All" by default
    End Sub

    Private Sub Services_WorkSect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the worker ID corresponding to the logged-in user
        'Dim loggedInUserID As Integer ' Assuming you have a way to get the logged-in user ID
        workerID = GetWorkerID(userID)

        If workerID <> -1 Then ' Check if worker ID retrieval was successful
            LoadServiceRequests() ' Load service requests for the logged-in user
        Else
            MessageBox.Show("Worker ID retrieval failed. Unable to load service requests.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'LoadServiceRequests() ' Load all service requests initially
    End Sub

    Private Function GetWorkerID(userID As Integer) As Integer
        Dim query As String = "SELECT workerID FROM serviceWorkers WHERE userID = @userID"
        Dim result As Integer = -1 ' Default value if retrieval fails

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userID", userID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    result = reader.GetInt32("workerID")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving worker ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        Return result
    End Function

    Public Sub LoadServiceRequests()
        ' Clear existing controls from Panel2
        Panel2.Controls.Clear()
        ' Create instances of requests with specified values and states
        Dim pendingRequests As New List(Of SerReq_worker_pending)()
        Dim acceptedRequests As New List(Of SerReq_worker_accepted)()
        Dim completedRequests As New List(Of SerReq_worker_completed)()
        Dim paymentDueRequests As New List(Of SerReq_worker_paymentDue)()

        conn.Open()
        Try
            'Dim query As String = "SELECT serviceBookingId, clientName, serviceTime, billAmount, status FROM serviceBooking WHERE workerID = @workerID"

            Dim query As String = "SELECT sb.serviceBookingId, sb.clientID, u.Name, sb.serviceTime, sb.billAmount, sb.status, u.ProfilePic " &
                      "FROM serviceBooking sb " &
                      "INNER JOIN User u ON sb.clientID = u.SID " &
                      "WHERE sb.workerID = @workerID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@workerID", workerID) ' Add workerID as a parameter
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim reqId As Integer = reader.GetInt32("serviceBookingId")
                        Dim clientID As Integer = reader.GetInt32("clientID")
                        Dim name As String = reader.GetString("Name")
                        Dim time As String = If(reader.IsDBNull(reader.GetOrdinal("serviceTime")), "To be Decided", reader.GetDateTime("serviceTime").ToString("yyyy-MM-dd HH:mm:ss"))
                        'Dim time As String = reader.GetDateTime("serviceTime").ToString("yyyy-MM-dd HH:mm:ss")
                        Dim billAmount As Object = reader("billAmount")
                        Dim billAmountString As String = If(IsDBNull(billAmount), "N/A", billAmount.ToString()) ' If billAmount is null, set it to "N/A"
                        Dim status As String = reader.GetString("status")
                        ' Retrieve the ProfilePic column value from the database
                        Dim profpic As Byte() = If(reader("ProfilePic") IsNot DBNull.Value, DirectCast(reader("ProfilePic"), Byte()), Nothing)


                        If status = "EnquirySent" Then
                            pendingRequests.Add(New SerReq_worker_pending(reqId, clientID, name, time, billAmountString, profpic))
                        ElseIf status = "Upcoming" Then
                            acceptedRequests.Add(New SerReq_worker_accepted(reqId, clientID, name, time, billAmountString, profpic))
                        ElseIf status = "Completed" Then
                            completedRequests.Add(New SerReq_worker_completed(name, time, billAmountString, profpic))
                        ElseIf status = "InProgress" Then
                            paymentDueRequests.Add(New SerReq_worker_paymentDue(name, time, billAmountString, profpic))
                        End If

                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching requests: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        ' Filter service requests based on selected status
        Dim filteredRequests As New List(Of Control)()
        Select Case Guna2ComboBox1.SelectedItem.ToString()
            Case "Pending"
                filteredRequests.AddRange(pendingRequests)
            Case "Accepted"
                filteredRequests.AddRange(acceptedRequests)
            Case "Completed"
                filteredRequests.AddRange(completedRequests)
            Case "Payment_Due"
                filteredRequests.AddRange(paymentDueRequests)
            Case Else ' Display all requests if "All" or an invalid option is selected
                filteredRequests.AddRange(pendingRequests)
                filteredRequests.AddRange(acceptedRequests)
                filteredRequests.AddRange(completedRequests)
                filteredRequests.AddRange(paymentDueRequests)
        End Select

        ' Add the filtered requests to Panel2
        Dim topOffset As Integer = 0
        For Each request As Control In filteredRequests
            request.Top = topOffset
            Panel2.Controls.Add(request)
            topOffset += request.Height + 20 ' Adjust top offset for the next control
        Next
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        LoadServiceRequests() ' Filter and load service requests based on the selected option
    End Sub
End Class