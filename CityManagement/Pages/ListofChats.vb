Imports MySql.Data.MySqlClient

Public Class ListOfChats

    'Constructor
    ' Declare a Timer control
    Private WithEvents Timer1 As New Timer()

    ' Declare a dictionary to store worker IDs and their respective total message counts
    Private workerMessageCounts As New Dictionary(Of String, Integer)()
    Public Sub New()
        InitializeComponent()
        ' Set the interval for the timer to 1 second (1000 milliseconds)
        ' Start the timer
        'LoadWorkerMessageCounts()
        Timer1.Interval = 1000
        'smer1.Start()
    End Sub
    Private Sub LoadChats()
        ' Clear panels before reloading chats
        SplitContainer1.Panel1.Controls.Clear()
        SplitContainer1.Panel2.Controls.Clear()

        ' Define the SQL query to fetch worker's name and last message
        Dim query As String = "SELECT NameWorkerCount.WorkerID AS WorkerID,
                                        NameWorkerCount.WorkerName AS WorkerName,
                                        NameWorkerCount.unread_messages AS unread_messages,
                                        LastMessage.LastMessage AS last_message,
                                        NameWorkerCount.ProfilePic AS Profile
                                FROM (
                                    SELECT SW.workerID, U.Name AS workerName, COUNT(C.chatID) AS unread_messages, U.ProfilePic AS ProfilePic
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
                        Dim workerPic As Byte() = Nothing
                        If Not reader.IsDBNull(reader.GetOrdinal("Profile")) Then
                            workerPic = DirectCast(reader("Profile"), Byte())
                        End If
                        ' Create a new ChatListItem
                        Dim chatListItem As New Chatlistitem(workerId, workerName, lastMessage, unreadMessages, workerPic)

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
        UpdateReceivingTime()
    End Sub
    Public Sub UpdateReceivingTime()
        ' Define the SQL query to update receiving time for relevant messages
        Dim query As String = "UPDATE Chats SET Recieving_Time = NOW() " &
                          "WHERE userID = @userID AND SentBy = 1 AND Seen = 0 AND workerID <> @workerID"
        ' Create a MySQL connection
        Using connection As New MySqlConnection(Globals.connectionstring)
            ' Open the connection
            connection.Open()

            ' Create MySqlCommand
            Using command As New MySqlCommand(query, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@userID", Globals.UserId)
                command.Parameters.AddWithValue("@workerID", Globals.ChatIdAsCitizen)
                ' Execute the command
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Function to fetch worker IDs and their respective total message counts
    Private Sub LoadWorkerMessageCounts()

        ' Define the SQL query to fetch worker IDs and their respective total message counts
        Dim query As String = "SELECT workerID, COUNT(chatID) AS total_messages FROM Chats WHERE userID = @userID GROUP BY workerID"
        Dim ChatsChanged As Boolean = False
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
                    ' Loop through the results and populate the dictionary
                    While reader.Read()
                        Dim workerId As String = reader("workerID").ToString()
                        Dim totalMessages As Integer = Convert.ToInt32(reader("total_messages"))
                        ' Update or add the worker ID and its total message count in the dictionary
                        'If the key does nto exist in the ditcionry then make a boolean to true

                        Dim keyExists As Boolean = workerMessageCounts.ContainsKey(workerId)
                        If keyExists Then
                            If workerMessageCounts(workerId) <> totalMessages Then
                                ChatsChanged = True
                                workerMessageCounts(workerId) = totalMessages
                            Else
                                If Timer1.Interval < 20000 Then
                                    Timer1.Interval *= 2
                                End If
                            End If
                        Else
                            workerMessageCounts.Add(workerId, totalMessages)
                            ChatsChanged = True
                        End If
                    End While
                End Using
            End Using
        End Using
        If ChatsChanged Then
            Timer1.Interval = 5000
            LoadChats()
        End If
    End Sub

    ' Event handler for the timer tick event
    Private Sub refreshTimer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        LoadWorkerMessageCounts()
        Timer1.Enabled = True
    End Sub


    Private Sub CurvedLabel9_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Globals.UrbanClapNavForm.HideCurvedLabels()
        Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.HomePage)
    End Sub

End Class
