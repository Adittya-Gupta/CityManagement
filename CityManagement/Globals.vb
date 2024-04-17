Public Class Globals
    'Global Variables and  Events
    Public Shared Property UserId As Integer = Module1.CurrUserSID
    Public Shared Property WorkerId As Integer = -2
    Public Shared Property connectionstring As String = GlobalConnString.str

    Private Shared _ChatIdAsCitizen As Integer = 1
    Public Shared Property ChatIdAsCitizen As Integer
        Get
            Return _ChatIdAsCitizen
        End Get
        Set(value As Integer)
            If _ChatIdAsCitizen <> value Then
                _ChatIdAsCitizen = value
                RaiseEvent ChatIdAsCitizenChanged(Nothing, EventArgs.Empty)
            End If
        End Set
    End Property

    ' Declare event for ChatIdAsCitizen change
    Public Shared Event ChatIdAsCitizenChanged(ByVal sender As Object, ByVal e As EventArgs)

    Public Shared ChatIdAsWorker As Integer = 1
    Private Shared _job_Selected As String = "1"
    Public Shared Property Job_Selected As String
        Get
            Return _job_Selected
        End Get
        Set(value As String)
            If _job_Selected <> value Then
                _job_Selected = value
                Select Case _job_Selected
                    Case "Electrician"
                        OrgId = 101
                    Case "Househelp"
                        OrgId = 104
                    Case "Merchant"
                        OrgId = 105
                    Case "Plumbing"
                        OrgId = 106
                End Select
                RaiseEvent Job_SelectedChanged(Nothing, EventArgs.Empty)
            End If
        End Set
    End Property

    Public Shared Event Job_SelectedChanged(ByVal sender As Object, ByVal e As EventArgs)

    Public Shared Property OrgId As Integer = 1

    ' Forms
    Public Shared WithEvents listofServicesForm As New ListofServices_Citizen()
    Public Shared WithEvents ServiceHistoryForm As New ServiceHistory()
    Public Shared WithEvents chatsForm As New Chats()
    Public Shared WithEvents listofChatsForm As New ListOfChats()
    Public Shared WithEvents listofWorkersForm As New ListofWorkers_Citizen()
    Public Shared WithEvents WorkPage As New Services_WorkSect()
    Public Shared WithEvents OrgHeadWorkSection As New OrgHeadWorkSection()

    ' Used for Back reference
    Public Shared HomePage As Object = listofServicesForm
    Public Shared Chatspage As Object = listofChatsForm

    ' Navigation
    Public Shared UrbanClapNavForm As New UrbanClapNav()

    ' Method to reset class member..

    ' Method to reset class members and forms
    Public Shared Sub ResetMembersAndForms()
        ' Reset class members
        UserId = Module1.CurrUserSID
        connectionstring = GlobalConnString.str
        ChatIdAsCitizen = 1
        ChatIdAsWorker = 1
        Job_Selected = "1"
        OrgId = 1

        ' Get the workerID of the user
        WorkerId = GetWorkerIDByUserID(UserId)
        'MessageBox.Show(WorkerId)
        ' Reset forms
        listofServicesForm.Dispose()
        ServiceHistoryForm.Dispose()
        chatsForm.Dispose()
        listofChatsForm.Dispose()
        listofWorkersForm.Dispose()
        WorkPage.Dispose()
        OrgHeadWorkSection.Dispose()
        UrbanClapNavForm.Dispose()

        ' Reinstantiate forms
        listofServicesForm = New ListofServices_Citizen()
        ServiceHistoryForm = New ServiceHistory()
        chatsForm = New Chats()
        listofChatsForm = New ListOfChats()
        listofWorkersForm = New ListofWorkers_Citizen()
        WorkPage = New Services_WorkSect()
        OrgHeadWorkSection = New OrgHeadWorkSection()
        UrbanClapNavForm = New UrbanClapNav()


        ' Update back references
        HomePage = listofServicesForm
        Chatspage = listofChatsForm
    End Sub
    Public Shared Function GetWorkerIDByUserID(userID As Integer) As Integer
        Dim workerID As Integer = -1

        ' Define the SQL query to retrieve the workerID based on the userID
        Dim query As String = "SELECT workerID FROM serviceWorkers WHERE userID = @userID"

        ' Create a MySQL connection
        Using connection As New MySqlConnection(connectionstring)
            ' Open the connection
            connection.Open()

            ' Create MySqlCommand
            Using command As New MySqlCommand(query, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@userID", userID)

                ' Execute the command and get the workerID
                Dim result As Object = command.ExecuteScalar()

                ' Check if the result is not null
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    workerID = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return workerID
    End Function

End Class