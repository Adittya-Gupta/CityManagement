Imports CityManagement.SerReq_worker_accepted
Imports CityManagement.SerReq_worker_completed
Imports CityManagement.SerReq_worker_pending
Imports MySql.Data.MySqlClient

Public Class Services_WorkSect
    'Public chatsForm As New Chats(Me)
    'Public listofChatsForm As New ListOfChats(Me)
    'Public Chatspage As Object = listofChatsForm
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Public Sub New()
        InitializeComponent()

        ' Populate the ComboBox with filter options
        Guna2ComboBox1.Items.AddRange({"All", "Pending", "Accepted", "Completed", "Payment_Due"})
        Guna2ComboBox1.SelectedIndex = 0 ' Select "All" by default
    End Sub

    Private Sub Services_WorkSect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServiceRequests() ' Load all service requests initially
    End Sub

    Private Sub LoadServiceRequests()
        ' Clear existing controls from Panel2
        Panel2.Controls.Clear()
        ' Create instances of requests with specified values and states
        Dim pendingRequests As New List(Of SerReq_worker_pending)()
        Dim acceptedRequests As New List(Of SerReq_worker_accepted)()
        Dim completedRequests As New List(Of SerReq_worker_completed)()
        Dim paymentDueRequests As New List(Of SerReq_worker_paymentDue)()

        Try
            conn.Open()
            Dim query As String = "SELECT clientName, serviceTime, billAmount, status FROM serviceBooking WHERE workerID = 1"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim name As String = reader.GetString("clientName")
                        Dim time As String = reader.GetDateTime("serviceTime").ToString("yyyy-MM-dd HH:mm:ss")
                        Dim billAmount As Object = reader("billAmount")
                        Dim billAmountString As String = If(IsDBNull(billAmount), "N/A", billAmount.ToString()) ' If billAmount is null, set it to "N/A"
                        Dim status As String = reader.GetString("status")
                        If status = "EnquirySent" Then
                            pendingRequests.Add(New SerReq_worker_pending(name, time))
                        ElseIf status = "Upcoming" Then
                            acceptedRequests.Add(New SerReq_worker_accepted(name, time))
                        ElseIf status = "Completed" Then
                            completedRequests.Add(New SerReq_worker_completed(name, time, billAmountString))
                        ElseIf status = "InProgress" Then
                            paymentDueRequests.Add(New SerReq_worker_paymentDue(name, time, billAmountString))
                        End If

                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching requests: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        '' Sample service requests (you may fetch these from your database or another source)
        'pendingRequests.Add(New SerReq_worker_pending("John Doe"))
        'pendingRequests.Add(New SerReq_worker_pending("Jane Smith"))
        'acceptedRequests.Add(New SerReq_worker_accepted("Bob Johnson", "3 hours"))
        'completedRequests.Add(New SerReq_worker_completed("Alice Williams", "2.5 hours", "$70"))
        'acceptedRequests.Add(New SerReq_worker_accepted("Eve Roberts", "2 hours"))
        'completedRequests.Add(New SerReq_worker_completed("Michael Brown", "1 hour", "$45"))

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
            topOffset += request.Height + 10 ' Adjust top offset for the next control
        Next
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        LoadServiceRequests() ' Filter and load service requests based on the selected option
    End Sub
End Class