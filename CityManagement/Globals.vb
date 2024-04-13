Public Class Globals

    'Global Variables and  Events
    Public Shared UserId As Integer = 1
    Public Shared connectionstring As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    'Public Shared connectionstring As String = "Server=RASHAADPC\SQLEXPRESS;Database=City;Uid=Rashaad;Pwd=Poiuy$098;"

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
    Public Shared OrgId As Integer = "1"
    Public Shared Property Job_Selected As String
        Get
            Return _job_Selected
        End Get
        Set(value As String)
            If _job_Selected <> value Then
                _job_Selected = value
                'Depending on _job_selected Set the orgID
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
                'MessageBox.Show(_job_Selected)
                RaiseEvent Job_SelectedChanged(Nothing, EventArgs.Empty)
            End If
        End Set
    End Property


    Public Shared Event Job_SelectedChanged(ByVal sender As Object, ByVal e As EventArgs)
    '6 Forms
    Public Shared WithEvents listofServicesForm As New ListofServices_Citizen()
    Public Shared WithEvents ServiceHistoryForm As New ServiceHistory()
    Public Shared WithEvents chatsForm As New Chats()
    Public Shared WithEvents listofChatsForm As New ListOfChats()
    Public Shared WithEvents listofWorkersForm As New ListofWorkers_Citizen()
    Public Shared WithEvents WorkPage As New Services_WorkSect()

    'Used for Back reference
    Public Shared HomePage As Object = listofServicesForm
    Public Shared Chatspage As Object = listofChatsForm

    'Navigation
    Public Shared UrbanClapNavForm As New UrbanClapNav()



End Class
