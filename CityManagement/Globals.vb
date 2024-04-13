Module Globals

    '5 Forms
    Public listofServicesForm As New ListofServices_Citizen()
    Public ServiceHistoryForm As New ServiceHistory()
    Public chatsForm As New Chats()
    Public listofChatsForm As New ListOfChats()
    Public listofWorkersForm As New ListofWorkers_Citizen()
    Public WorkPage As New Services_WorkSect()
    Public OrgHeadWorkSection As New OrgHeadWorkSection()
    'Used for Back reference
    Public HomePage As Object = listofServicesForm
    Public Chatspage As Object = listofChatsForm

    'Navigation
    Public UrbanClapNavForm As New UrbanClapNav()

    'Public MainPanelForm As New MainPanel()

    'Global Variables
    Public UserId As Integer
    Public connectionstring As String
    Public ChatId As Integer
    Public Job_Selected As String = "Electrician"


End Module
