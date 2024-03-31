Imports CityManagement.SerReq_worker_accepted
Imports CityManagement.SerReq_worker_completed
Imports CityManagement.SerReq_worker_pending

Public Class Services_WorkSect
    'Public chatsForm As New Chats(Me)
    'Public listofChatsForm As New ListOfChats(Me)
    'Public Chatspage As Object = listofChatsForm

    Private Sub Services_WorkSect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create new instances of requests with specified values and states
        Dim pendingRequest1 As New SerReq_worker_pending("John Doe")
        Dim pendingRequest2 As New SerReq_worker_pending("Jane Smith")
        Dim acceptedRequest1 As New SerReq_worker_accepted("Bob Johnson", "3 hours")
        Dim completedRequest1 As New SerReq_worker_completed("Alice Williams", "2.5 hours", "$70")
        Dim acceptedRequest2 As New SerReq_worker_accepted("Eve Roberts", "2 hours")
        Dim completedRequest2 As New SerReq_worker_completed("Michael Brown", "1 hour", "$45")

        ' Add the requests to Panel2
        Panel2.Controls.Add(pendingRequest1)
        Panel2.Controls.Add(pendingRequest2)
        Panel2.Controls.Add(acceptedRequest1)
        Panel2.Controls.Add(completedRequest1)
        Panel2.Controls.Add(acceptedRequest2)
        Panel2.Controls.Add(completedRequest2)

        ' Set the positions of the requests
        pendingRequest1.Top = 0
        pendingRequest2.Top = pendingRequest1.Bottom + 10
        acceptedRequest1.Top = pendingRequest2.Bottom + 10
        completedRequest1.Top = acceptedRequest1.Bottom + 10
        acceptedRequest2.Top = completedRequest1.Bottom + 10
        completedRequest2.Top = acceptedRequest2.Bottom + 10
    End Sub

End Class