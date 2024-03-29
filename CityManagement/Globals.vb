Module Globals
    'Navigation
    Public UrbanClapNavForm As New UrbanClapNav()

    '5 Forms
    Public ServiceHistoryForm As New ServiceHistory()
    Public chatsForm As New Chats()
    Public listofChatsForm As New ListOfChats()
    Public listofServicesForm As New ListofServices_Citizen()
    Public listofWorkersForm As New ListofWorkers_Citizen()

    'Used for Back reference
    Public HomePage As Object = listofServicesForm
    Public Chatspage As Object = listofChatsForm

    'Global Variables
    Public UserId As Integer
    Public connectionstring As String
    Public ChatId As Integer
    Public Job_Selected As String = "Electrician"

End Module
