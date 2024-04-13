Imports MySql.Data.MySqlClient

Public Class ListOfChats

    'Constructor
    Public Sub New()
        InitializeComponent()

    End Sub

    ' Function to execute the query and populate the panels
    Private Sub LoadChats()
        ' Define the SQL query to fetch worker's name and last message
        Dim query As String = " SELECT NameWorkerCount.WorkerID AS WorkerID,
                                                               NameWorkerCount.WorkerName AS WorkerName,
                                                               NameWorkerCount.unread_messages AS unread_messages,
                                                               LastMessage.LastMessage AS last_message
                                                        FROM (
                                                           SELECT SW.workerID, U.Name AS workerName, COUNT(C.chatID) AS unread_messages
                                                            FROM serviceWorkers SW 
                                                            LEFT JOIN Chats C ON C.workerID = SW.workerID AND C.SentBy = 1 AND C.Seen = 0 AND C.userID = @userID
                                                            JOIN User U ON SW.userID = U.SID 
                                                            GROUP BY SW.workerID, U.Name
                                                        ) AS NameWorkerCount
                                                        JOIN (
                                                            SELECT C.workerID AS WorkerID,
                                                                   MAX(CASE WHEN C.Sent_Time = (SELECT MAX(Sent_Time) FROM Chats WHERE workerID = C.workerID AND userID = @userID) THEN C.Content ELSE 'HI' END) AS LastMessage
                                                            FROM Chats C
                                                            WHERE C.userID = @userID
                                                            GROUP BY C.workerID
                                                        ) AS LastMessage ON NameWorkerCount.WorkerID = LastMessage.WorkerID;"
        ' Create a MySQL connection
        Using connection As New MySqlConnection(Globals.connectionstring)
            ' Open the connection
            connection.Open()

            ' Create MySqlCommand
            Using command As New MySqlCommand(query, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@userID", Globals.UserId)

                ' Execute the command and create a reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Loop through the results and create ChatListItems
                    While reader.Read()
                        Dim workerId As String = reader("WorkerID").ToString()
                        Dim workerName As String = reader("WorkerName").ToString()
                        Dim unreadMessages As Integer = Convert.ToInt32(reader("unread_messages"))
                        Dim lastMessage As String = reader("last_message").ToString()

                        ' Create a new ChatListItem
                        Dim chatListItem As New Chatlistitem(workerId, workerName, lastMessage, unreadMessages)

                        ' Add the ChatListItem to the appropriate panel if there are unread messages
                        If unreadMessages = 0 Then
                            SplitContainer1.Panel2.Controls.Add(chatListItem)
                            ' Add the ChatListItem to the appropriate panel if there are no unread messages
                        Else
                            SplitContainer1.Panel1.Controls.Add(chatListItem)
                        End If
                        chatListItem.Dock = DockStyle.Top
                    End While
                End Using
            End Using
        End Using
        MessageBox.Show("Done")
    End Sub


    'Load the form
    Private Sub ListOfChats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadChats()
    End Sub

    Private Sub CurvedLabel9_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Globals.UrbanClapNavForm.HideCurvedLabels()
        Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.HomePage)
    End Sub

End Class
