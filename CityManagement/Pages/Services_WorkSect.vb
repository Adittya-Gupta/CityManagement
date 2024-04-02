Imports CityManagement.SerReq_worker_accepted
Imports CityManagement.SerReq_worker_completed
Imports CityManagement.SerReq_worker_pending

Public Class Services_WorkSect
    'Public chatsForm As New Chats(Me)
    'Public listofChatsForm As New ListOfChats(Me)
    'Public Chatspage As Object = listofChatsForm

    Public Sub New()
        InitializeComponent()

        ' Populate the ComboBox with filter options
        Guna2ComboBox1.Items.AddRange({"All", "Pending", "Accepted", "Completed"})
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

        ' Sample service requests (you may fetch these from your database or another source)
        pendingRequests.Add(New SerReq_worker_pending("John Doe"))
        pendingRequests.Add(New SerReq_worker_pending("Jane Smith"))
        acceptedRequests.Add(New SerReq_worker_accepted("Bob Johnson", "3 hours"))
        completedRequests.Add(New SerReq_worker_completed("Alice Williams", "2.5 hours", "$70"))
        acceptedRequests.Add(New SerReq_worker_accepted("Eve Roberts", "2 hours"))
        completedRequests.Add(New SerReq_worker_completed("Michael Brown", "1 hour", "$45"))

        ' Filter service requests based on selected status
        Dim filteredRequests As New List(Of Control)()
        Select Case Guna2ComboBox1.SelectedItem.ToString()
            Case "Pending"
                filteredRequests.AddRange(pendingRequests)
            Case "Accepted"
                filteredRequests.AddRange(acceptedRequests)
            Case "Completed"
                filteredRequests.AddRange(completedRequests)
            Case Else ' Display all requests if "All" or an invalid option is selected
                filteredRequests.AddRange(pendingRequests)
                filteredRequests.AddRange(acceptedRequests)
                filteredRequests.AddRange(completedRequests)
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