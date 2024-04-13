Public Class Globals

    '6 Forms
    Public Shared WithEvents listofServicesForm As New ListofServices_Citizen()
    Public Shared WithEvents ServiceHistoryForm As New ServiceHistory()
    Public Shared WithEvents chatsForm As New Chats()
    Public Shared WithEvents listofChatsForm As New ListOfChats()
    Public Shared WithEvents listofWorkersForm As New ListofWorkers_Citizen()
    Public Shared WithEvents WorkPage As New Services_WorkSect()
    Public OrgHeadWorkSection As New OrgHeadWorkSection()

    'Used for Back reference
    Public Shared HomePage As Object = listofServicesForm
    Public Shared Chatspage As Object = listofChatsForm

    'Navigation
    Public Shared UrbanClapNavForm As New UrbanClapNav()

    'Global Variables and  Events
    Public Shared UserId As Integer = 1
    Public Shared connectionstring As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Public Shared ChatId As Integer
    Private Shared _job_Selected As String = "1"
    Public Shared Property Job_Selected As String
        Get
            Return _job_Selected
        End Get
        Set(value As String)
            If _job_Selected <> value Then
                _job_Selected = value
                MessageBox.Show(_job_Selected)
                RaiseEvent Job_SelectedChanged(Nothing, EventArgs.Empty)
            End If
        End Set
    End Property

    Public Shared Event Job_SelectedChanged(ByVal sender As Object, ByVal e As EventArgs)

End Class
