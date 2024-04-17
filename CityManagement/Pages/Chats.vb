Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports Windows.ApplicationModel.Chat

Public Class Chats
    Public Class ChatInfo
        Public Property ChatID As Integer
        Public Property SentBy As Integer
        Public Property Seen As Integer

        Public Property Image As Byte()
    End Class

    Public username As String
    ' Declare a variable to store the last chat ID
    Private lastMessageID As Integer = -1
    ' Declare a list to store chat information
    Private chatList As New List(Of ChatInfo)()

    Public Sub New(Optional ByVal Username As String = "John Doe")
        InitializeComponent()
        Me.username = Username
        'dHandler Globals.ChatIdAsCitizenChanged, AddressOf LoadChatMessages
        'MessageBox.Show("List of Workers Citizen")
        ' Start the timer
        Timer1.Interval = 5000 ' Set the interval to 1 second
        'Timer1.Start()
        MakePictureBoxRound(PictureBox1)
    End Sub

    Private Sub MakePictureBoxRound(ByVal pictureBox As PictureBox)
        ' Create a GraphicsPath to define a circle
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height)

        ' Set the PictureBox's region to the circle defined by the GraphicsPath
        pictureBox.Region = New Region(path)
    End Sub
    Private Sub Chats_Show(ByVal sender As Object, ByVal e As EventArgs) Handles Panel1.ControlAdded

        Panel1.AutoScrollPosition = New Point(0, Panel1.VerticalScroll.Maximum)
    End Sub

    Private Sub LoadChatMessages()
        'MessageBox.Show("Loading chat messages")
        'Label2.Text = Globals.ChatIdAsCitizen
        Panel1.Controls.Clear()
        ' Define the SQL query to retrieve chat messages
        Dim query As String = "SELECT chatID, Content, Sent_Time, Recieving_Time, SentBy, Seen FROM Chats WHERE userID = @userID AND workerID = @workerID"
        ' Create a list to store chatIDs where Seen = 0
        Dim unseenChatIDs As New List(Of Integer)
        ' Create a MySQL connection
        Using connection As New MySqlConnection(Globals.connectionstring)
            ' Open the connection
            connection.Open()

            ' Create MySqlCommand
            Using command As New MySqlCommand(query, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@userID", Globals.UserId) ' Provide the actual user ID
                command.Parameters.AddWithValue("@workerID", Globals.ChatIdAsCitizen) ' Provide the actual worker ID

                ' Execute the command and create a reader
                Using reader As MySqlDataReader = command.ExecuteReader()

                    ' Loop through the results and create ChatElement controls
                    While reader.Read()
                        Dim content As String = reader("Content").ToString()
                        Dim sentTime As DateTime = Convert.ToDateTime(reader("Sent_Time"))
                        Dim sentBy As Integer = Convert.ToInt32(reader("SentBy"))
                        Dim seen As Integer = Convert.ToInt32(reader("Seen"))

                        ' Determine the side of the chat element based on sentBy
                        Dim isSentByWorker As Boolean = (sentBy = 1)

                        ' Check if the message has been seen
                        'Dim receivedTime As DateTime = If(isSentByWorker = 1 & seen = 0, DateTime.Now, Convert.ToDateTime(reader("Recieving_Time")))

                        ' Create a new ChatElement with the message content and sent time
                        Dim newChatElement As New ChatElement(content, sentTime,)
                        ' Add chat information to the chatList
                        Dim chatInfo As New ChatInfo()
                        chatInfo.ChatID = Convert.ToInt32(reader("chatID"))
                        chatInfo.SentBy = sentBy
                        chatInfo.Seen = seen
                        chatList.Add(chatInfo)
                        lastMessageID = chatInfo.ChatID
                        ' Set the position of the chat element based on who sent it
                        ' position them one below the other
                        Dim lastControl As Control = Panel1.Controls.Cast(Of Control)().LastOrDefault()
                        If lastControl IsNot Nothing Then
                            newChatElement.Top = lastControl.Bottom + 10 ' Add some spacing
                        End If
                        If isSentByWorker Then
                            newChatElement.Left = 0
                        Else
                            newChatElement.Left = Panel1.Width - newChatElement.Width - 25 ' Align to the right side
                        End If

                        ' Add the new ChatElement to the panel
                        Panel1.Controls.Add(newChatElement)

                        ' If message has not been seen, add chatID to the list
                        If isSentByWorker = 1 & seen = 0 Then
                            unseenChatIDs.Add(reader("chatID"))
                        End If
                    End While
                End Using
            End Using
        End Using
        ' Update receive time for messages that have not been seen
        UpdateReceiveTime(unseenChatIDs)
        ' Start the timer
        Timer1.Start()
    End Sub


    Private Sub UpdateReceiveTime(ByVal unseenChatIDs As List(Of Integer))
        For Each chatInfo In chatList
            If unseenChatIDs.Contains(chatInfo.ChatID) AndAlso chatInfo.SentBy = 1 AndAlso chatInfo.Seen = 0 Then
                ' Update the receive time for the chat message
                ' Other code...
            End If
        Next

        ' Create a new MySQL connection
        Using connection As New MySqlConnection(Globals.connectionstring)
            ' Open the connection
            connection.Open()

            ' Define the SQL query to update receive time
            Dim query As String = "UPDATE Chats SET Recieving_Time = @receiveTime , Seen = 1 WHERE chatID = @chatID"

            ' Create MySqlCommand
            Using command As New MySqlCommand(query, connection)
                ' Add receiveTime parameter (constant for all chatIDs)
                'command.Parameters.AddWithValue("@receiveTime", DateTime.Now)

                For Each chatID In unseenChatIDs
                   ' MessageBox.Show(chatID.ToString())
                    ' Clear previous parameters
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@receiveTime", DateTime.Now)
                    'MessageBox.Show(DateTime.Now.ToString())
                    ' Add chatID parameter
                    command.Parameters.AddWithValue("@chatID", chatID)

                    ' Execute the command
                    command.ExecuteNonQuery()
                Next
            End Using
        End Using
    End Sub

    Private Sub CurvedLabel9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Globals.Chatspage = Globals.listofChatsForm
        Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.Chatspage)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'MessageBox.Show("Hello")
        ' Call a method to check for new messages
        ' Disable the timer to prevent re-triggering while CheckForNewMessages is still executing
        Timer1.Enabled = False
        CheckForNewMessages()
        ' Re-enable the timer
        Timer1.Enabled = True
    End Sub

    Private Sub CheckForNewMessages()
        ' Get the last message ID from the database
        Dim currentLastMessageID As Integer = GetLastMessageIDFromDatabase()

        ' If the current last message ID is different from the stored last message ID
        If currentLastMessageID <> lastMessageID Then
            ' Fetch new messages from the database
            GetNewMessagesFromDatabase(lastMessageID)

            ' Update the last message ID
            lastMessageID = currentLastMessageID

            ' If new messages are found, set timer interval to 1 second
            ' Otherwise, double the current timer interval up to a maximum of 16 seconds
            Timer1.Interval = 1000 ' 1 second
        Else
            Timer1.Interval *= 2
            If Timer1.Interval > 16000 Then
                Timer1.Interval = 16000 ' Maximum interval of 16 seconds
            End If
        End If
    End Sub


    Private Function GetLastMessageIDFromDatabase() As Integer
        Dim lastMessageID As Integer = -1

        ' Define the SQL query to retrieve the last message ID from the database
        Dim query As String = "SELECT MAX(chatID) FROM Chats WHERE userID = @userID AND workerID = @workerID"

        Try
            ' Create a new MySQL connection
            Using connection As New MySqlConnection(Globals.connectionstring)
                ' Open the connection
                connection.Open()

                ' Create MySqlCommand
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters
                    command.Parameters.AddWithValue("@userID", Globals.UserId)
                    command.Parameters.AddWithValue("@workerID", Globals.ChatIdAsCitizen)

                    ' Execute the command and retrieve the result
                    Dim result As Object = command.ExecuteScalar()

                    ' Check if the result is not null
                    If result IsNot DBNull.Value Then
                        ' Convert the result to an integer and assign it to lastMessageID
                        lastMessageID = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error occurred while fetching last message ID: " & ex.Message)
        End Try

        ' Return the last message ID
        Return lastMessageID
    End Function

    Private Function GetNewMessagesFromDatabase(ByVal lastMessageID As Integer) As List(Of String)
        Dim newMessages As New List(Of String)()

        ' Define the SQL query to retrieve new messages from the database
        Dim query As String = "SELECT Content FROM Chats WHERE userID = @userID AND workerID = @workerID AND chatID > @LastMessageID"

        Try
            ' Create a new MySQL connection
            Using connection As New MySqlConnection(Globals.connectionstring)
                ' Open the connection
                connection.Open()

                ' Create MySqlCommand
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters
                    command.Parameters.AddWithValue("@userID", Globals.UserId)
                    command.Parameters.AddWithValue("@workerID", Globals.ChatIdAsCitizen)
                    command.Parameters.AddWithValue("@LastMessageID", lastMessageID)

                    ' Execute the command and create a reader
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Loop through the results
                        While reader.Read()
                            ' Read content from the reader and add it to the list of new messages
                            Dim content As String = reader("Content").ToString()
                            newMessages.Add(content)
                        End While
                    End Using
                End Using
            End Using


            ' Add new messages to the UI
            For Each message As String In newMessages
                ' Create a new ChatElement with the message text
                Dim newChatElement As New ChatElement(message)

                ' Find the last control in the panel
                Dim lastControl As Control = Panel1.Controls.Cast(Of Control)().LastOrDefault()

                ' Set the position of the new ChatElement below the last control
                If lastControl IsNot Nothing Then
                    newChatElement.Top = lastControl.Bottom + 10 ' Add some spacing
                End If
                newChatElement.Left = Panel1.Width - newChatElement.Width - 25 ' Align to the right side
                ' Assuming AddChatElementToUI method adds the message content to the UI
                ' Add the new ChatElement to the panel
                Panel1.Controls.Add(newChatElement)
            Next
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error occurred while fetching new messages: " & ex.Message)
        End Try

        ' Return the list of new messages
        Return newMessages
    End Function


    Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.Click
        Timer1.Enabled = False
        ' Get the text from RichTextBox1 and trim whitespace
        Dim message As String = RichTextBox1.Text.Trim()
        If message.Length > 0 And message <> "Type a message" Then

            ' Create a new ChatElement with the message text
            Dim newChatElement As New ChatElement(message)

            ' Find the last control in the panel
            Dim lastControl As Control = Panel1.Controls.Cast(Of Control)().LastOrDefault()

            ' Set the position of the new ChatElement below the last control
            If lastControl IsNot Nothing Then
                newChatElement.Top = lastControl.Bottom + 10 ' Add some spacing
            End If
            newChatElement.Left = Panel1.Width - newChatElement.Width - 25 ' Align to the right side

            ' Insert message into Chats table
            InsertMessageIntoChatsTable(message)

            ' Add the new ChatElement to the panel
            Panel1.Controls.Add(newChatElement)
            RichTextBox1.Text = "Type a message"
        Else

            ' Show an error message if the message is empty
            MessageBox.Show("Please enter a message.", "Empty Text", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub InsertMessageIntoChatsTable(ByVal message As String)
        ' Define the SQL query to insert message into Chats table
        Dim queryInsert As String = "INSERT INTO Chats (Content, Sent_Time, SentBy, Seen, userID, workerID) VALUES (@content, NOW(), 0, 0, @userID, @workerID)"
        ' Define the SQL query to retrieve the last inserted ID
        Dim querySelectLastID As String = "SELECT LAST_INSERT_ID()"

        ' Create a MySQL connection
        Using connection As New MySqlConnection(Globals.connectionstring)
            ' Open the connection
            connection.Open()

            ' Begin a transaction
            Dim transaction As MySqlTransaction = connection.BeginTransaction()

            Try
                ' Create MySqlCommand for insertion
                Using commandInsert As New MySqlCommand(queryInsert, connection, transaction)
                    ' Add parameters
                    commandInsert.Parameters.AddWithValue("@content", message)
                    commandInsert.Parameters.AddWithValue("@userID", Globals.UserId)
                    commandInsert.Parameters.AddWithValue("@workerID", Globals.ChatIdAsCitizen)

                    ' Execute the insertion command
                    commandInsert.ExecuteNonQuery()
                End Using

                ' Create MySqlCommand for selecting last inserted ID
                Dim lastInsertedID As Integer
                Using commandSelect As New MySqlCommand(querySelectLastID, connection, transaction)
                    ' Retrieve the last inserted ID
                    lastInsertedID = Convert.ToInt32(commandSelect.ExecuteScalar())
                End Using

                ' Commit the transaction if everything succeeded
                transaction.Commit()

                ' Do something with the last inserted ID if needed
                'Console.WriteLine("Last inserted ID: " & lastInsertedID)
            Catch ex As Exception
                ' Rollback the transaction if an exception occurred
                transaction.Rollback()
                MessageBox.Show("Error occurred while inserting message: " & ex.Message)
            End Try
        End Using
    End Sub



    Private Sub RichTextBox1_GotFocus(sender As Object, e As EventArgs) Handles RichTextBox1.GotFocus
        If RichTextBox1.Text = "Type a message" Then
            RichTextBox1.Text = ""
            RichTextBox1.ForeColor = Color.White ' Change text color to normal
        End If
    End Sub

    Private Sub RichTextBox1_LostFocus(sender As Object, e As EventArgs) Handles RichTextBox1.LostFocus
        If String.IsNullOrWhiteSpace(RichTextBox1.Text) Then
            RichTextBox1.Text = "Type a message"
            RichTextBox1.ForeColor = Color.Gray ' Change text color to placeholder color
        End If
    End Sub


    Private Sub Label2_Paint(sender As Object, e As PaintEventArgs) Handles Label2.Paint
        Dim rect As Rectangle = Label2.ClientRectangle

        ' Define gradient colors
        Dim color1 As Color = Color.FromArgb(128, 68, 0, 255) ' RGBA(68,0,255,1)
        Dim color2 As Color = Color.FromArgb(128, 0, 36, 255) ' RGBA(1,220,255,1)

        ' Create linear gradient brush
        Dim brush As New LinearGradientBrush(rect, color1, color2, LinearGradientMode.Horizontal)

        ' Fill rectangle with gradient brush
        e.Graphics.FillRectangle(brush, rect)
    End Sub
End Class