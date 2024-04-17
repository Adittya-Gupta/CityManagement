Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CityManagement.HistoryItem
Imports CityManagement.ListofWorkers_Citizen
Imports MySql.Data.MySqlClient

Public Class ServiceHistory
    Public Class BookingItem
        Public Property BookingId As String
        Public Property WorkerName As String
        Public Property ServiceTime As String
        Public Property BillAmount As String
        Public Property WorkerRating As Double
        Public Property Status As AppointmentState
        Public Property WorkerPic As Byte()


        ' Constructor to initialize properties
        Public Sub New(ByVal bookingId As String, ByVal workerName As String, ByVal serviceTime As String, ByVal billAmount As String, ByVal workerRating As Double, ByVal status As AppointmentState, Optional ByVal profpic As Byte() = Nothing)
            Me.BookingId = bookingId
            Me.WorkerName = workerName
            Me.ServiceTime = serviceTime
            Me.BillAmount = billAmount
            Me.WorkerRating = workerRating
            Me.Status = status
            Me.WorkerPic = profpic
        End Sub
    End Class

    Private Historyfilterform As New Historyfilter()
    Public OriginalBookingsList As New List(Of BookingItem)()
    Public HistoryCount As Integer = -1
    Public OriginalStatusCount As New Dictionary(Of AppointmentState, Integer)()
    Public semaphore As New Semaphore(initialCount:=1, maximumCount:=1)

    ' Declare a Global Lock on the OriginalStatusCount Datastructure
    Private Sub InitializeStatusCount()
        ' Initialize status count dictionary with all status set to 0
        For Each state As AppointmentState In [Enum].GetValues(GetType(AppointmentState))
            OriginalStatusCount(state) = 0
        Next
    End Sub

    Public Sub New()
        InitializeComponent()
        InitializeStatusCount()
        HistoryCount = 0
        'MessageBox.Show("Service History")
        ' Start the timer
        Timer1.Interval = 5000 ' Set the interval to 1 second
        Timer1.Start()
        ServiceHistory_Load()
    End Sub
    Private Sub ServiceHistory_VisibleChanged(sender As Object, e As EventArgs)
        If Not Me.Visible Then
            Historyfilterform.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Debug.WriteLine("Service History disabled")
        'MessageBox.Show("H I")
        ' Define the SQL query to fetch count of each status for a user
        Dim countQuery As String = "SELECT status, COUNT(*) FROM serviceBooking SB WHERE SB.clientID = @UserID GROUP BY status"

        ' Create a dictionary to store the count of each status
        Dim statusCount As New Dictionary(Of String, Integer)()

        ' Create MySQL connection
        Using connection As New MySqlConnection(Globals.connectionstring)
            ' Open the connection
            connection.Open()

            ' Create MySqlCommand
            Using command As New MySqlCommand(countQuery, connection)
                command.Parameters.AddWithValue("@UserID", Globals.UserId)

                ' Execute the command and get the count for each status
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Read status and count from the reader
                        Dim status As String = reader("status").ToString()
                        Dim currentState As AppointmentState = MapStatusToAppointmentState(status)
                        Dim count As Integer = Convert.ToInt32(reader("COUNT(*)"))
                        statusCount(currentState) = count
                    End While
                End Using
            End Using
        End Using
        ' Declare a Global Lock on the OriginalStatusCount

        ' Check if the count for each status has changed
        semaphore.WaitOne() ' Acquire semaphore

        Dim statusChanged As Boolean = False
        For Each kvp As KeyValuePair(Of String, Integer) In statusCount
            Dim status As String = kvp.Key
            Dim count As Integer = kvp.Value
            If Not OriginalStatusCount.ContainsKey(status) OrElse OriginalStatusCount(status) <> count Then
                statusChanged = True
                Exit For
            End If
        Next
        ' Critical section - access shared resource
        semaphore.Release() ' Release semaphore
        If statusChanged Then
            'MessageBox.Show("Status Changed")
            ' Call the ServiceHistory_Load method to update the UI
            ServiceHistory_Load()

            ' Reset the timer interval to 5 seconds
            Timer1.Interval = 5000
        Else
            ' If count has not changed, double the interval up to 128 seconds
            If Timer1.Interval < 10000 Then
                Timer1.Interval *= 2
            End If
        End If
        Debug.WriteLine("Service History Enabled")
        Timer1.Enabled = True
    End Sub


    Public Sub ServiceHistory_Load() Handles MyBase.Load
        InitializeStatusCount
        Timer1.Enabled = False
        Debug.WriteLine("Service History disabled")
        Panel1.Controls.Clear
        OriginalBookingsList.Clear
        HistoryCount = 0
        Historyfilterform = New Historyfilter
        'MessageBox.Show("Service")

        Try
            ' SQL query to retrieve service history information
            Dim query = "SELECT SB.serviceBookingId AS BookingId, U.Name AS WorkerName, SW.rating AS WorkerRating, SB.serviceTime, SB.billAmount, SB.status ,U.ContactNo AS WorkerPhoneNumber, U.ProfilePic As Profile " &
                                  "FROM serviceBooking SB " &
                                  "JOIN serviceWorkers SW ON SB.workerID = SW.workerID " &
                                  "JOIN User U ON SW.userID = U.SID " &
                                  "WHERE SB.clientID = @UserID;"

            ' Suspends the layout during initialization
            Panel1.SuspendLayout

            ' Database connection and command setup
            Using connection As New MySqlConnection(Globals.connectionstring)
                Using command As New MySqlCommand(query, connection)
                    ' Set the UserID parameter value
                    command.Parameters.AddWithValue("@UserID", Globals.UserId)

                    ' Open the connection
                    connection.Open

                    ' Execute the command and create a reader
                    Using reader = command.ExecuteReader
                        ' Check if the reader has rows
                        If reader.HasRows Then
                            ' Loop through the results and create HistoryItem controls
                            Dim topPosition = 0
                            While reader.Read
                                ' Read data from the reader
                                Dim bookingId = reader("BookingId").ToString
                                Dim workerName = reader("WorkerName").ToString
                                Dim workerRating = Convert.ToDouble(reader("WorkerRating"))
                                Dim serviceTime As String
                                Dim billAmount As String
                                ' Check for DBNull values and assign default values if necessary
                                If reader("serviceTime") IsNot DBNull.Value Then
                                    serviceTime = Convert.ToDateTime(reader("serviceTime")).ToString
                                Else
                                    serviceTime = "To be declared"
                                End If

                                If reader("billAmount") IsNot DBNull.Value Then
                                    billAmount = reader("billAmount").ToString
                                Else
                                    billAmount = "To be Updated"
                                End If

                                ' Map status string to AppointmentState enum
                                Dim status = reader("status").ToString
                                Dim currentState = MapStatusToAppointmentState(status)
                                Dim workerPhoneNumber = reader("WorkerPhoneNumber").ToString

                                Dim workerPic As Byte() = Nothing
                                If Not reader.IsDBNull(reader.GetOrdinal("Profile")) Then
                                    workerPic = DirectCast(reader("Profile"), Byte())
                                End If
                                ' Create BookingItem object
                                Dim bookingItem As New BookingItem(bookingId, workerName, serviceTime, billAmount, workerRating, currentState, workerPic)
                                HistoryCount += 1
                                ' Increment the count for the corresponding status
                                If OriginalStatusCount.ContainsKey(currentState) Then
                                    OriginalStatusCount(currentState) += 1
                                End If
                                ' Add the BookingItem object to OriginalBookingsList
                                OriginalBookingsList.Add(bookingItem)

                            End While
                        Else
                            ' Handle case where no service history is found for the user
                            'MessageBox.Show("No service history found for the user.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Timer1.Enabled = False
            Debug.WriteLine("Service History disabled")
            ' Handle any exceptions that occur during database operations
            MessageBox.Show("An error occurred while loading service history: " & ex.Message)
        Finally
            Timer1.Enabled = True
            Debug.WriteLine("Service History Enabled")
            UpdateUIWithFilteredBookings()
            ' Resume layout after initialization
            Panel1.ResumeLayout()
        End Try

    End Sub

    Private Function MapStatusToAppointmentState(status As String) As AppointmentState
        ' Map status string to AppointmentState enum
        Select Case status
            Case "EnquirySent"
                Return AppointmentState.EnquirySent
            Case "Rejected"
                Return AppointmentState.Rejected
            Case "Withdrawn"
                Return AppointmentState.Withdrawn
            Case "Upcoming"
                Return AppointmentState.Upcoming
            Case "Cancelled"
                Return AppointmentState.Cancelled
            Case "InProgress"
                Return AppointmentState.InProgress
            Case "Completed"
                Return AppointmentState.Completed
            Case "Finished"
                Return AppointmentState.Finished
            Case Else
                Return AppointmentState.EnquirySent ' Default to EnquirySent if status is not recognized
        End Select
    End Function

    Private Sub CurvedLabel9_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.HomePage)
        Globals.UrbanClapNavForm.HideCurvedLabels()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Check if Filterform is already visible
        If Historyfilterform.Visible Then
            ' If Filterform is already visible, hide it
            Historyfilterform.Hide()
        Else
            Historyfilterform.BringToFront()
            ' If Filterform is not visible, show it
            Historyfilterform.Show()
        End If
    End Sub
    Public Sub UpdateUIWithFilteredBookings()
        ' Get the filtered and sorted list of bookings
        Dim filteredBookings = FilterAndSortBookings()

        ' Clear existing controls from Panel1
        Panel1.Controls.Clear()

        ' Initialize variable to track top position
        Dim topPosition As Integer = 0

        ' Loop through the filtered bookings list and create HistoryItem controls
        For Each booking As BookingItem In filteredBookings
            ' Create HistoryItem control
            Dim historyItem As New HistoryItem(booking.BookingId, booking.WorkerName, booking.ServiceTime, booking.BillAmount, booking.WorkerRating, booking.Status, booking.WorkerPic)

            ' Add the HistoryItem control to Panel1
            Panel1.Controls.Add(historyItem)

            ' Set the position of the HistoryItem control
            historyItem.Top = topPosition
            topPosition += historyItem.Height + 10
        Next
    End Sub


    Private Function FilterAndSortBookings() As List(Of BookingItem)

        Dim filteredBookings = OriginalBookingsList

        Select Case Historyfilterform.CheckBox1.CheckState
            Case CheckState.Checked
                ' Sort in decreasing order of WorkerRating
                filteredBookings = filteredBookings.OrderByDescending(Function(booking) booking.ServiceTime).ToList()
            Case CheckState.Indeterminate
                ' Sort in increasing order of WorkerRating
                filteredBookings = filteredBookings.OrderBy(Function(booking) booking.ServiceTime).ToList()
        End Select



        ' Apply filtering based on CheckBox state for status
        If Historyfilterform.CheckBox2.Checked OrElse
       Historyfilterform.CheckBox3.Checked OrElse
       Historyfilterform.CheckBox4.Checked OrElse
       Historyfilterform.CheckBox5.Checked OrElse
       Historyfilterform.CheckBox6.Checked OrElse
       Historyfilterform.CheckBox7.Checked Then

            Dim NewfilteredBookings As New List(Of BookingItem)
            ' Define mapping of checkboxes to AppointmentState
            Dim stateMapping As New Dictionary(Of CheckBox, AppointmentState) From {
            {Historyfilterform.CheckBox2, AppointmentState.EnquirySent},
            {Historyfilterform.CheckBox3, AppointmentState.InProgress},
            {Historyfilterform.CheckBox4, AppointmentState.Completed},
            {Historyfilterform.CheckBox5, AppointmentState.Cancelled},
            {Historyfilterform.CheckBox6, AppointmentState.Upcoming},
            {Historyfilterform.CheckBox7, AppointmentState.Finished}
        }


            ' Check each checkbox from CheckBox2 to CheckBox7
            For i As Integer = 2 To 7
                Dim checkBox As CheckBox = DirectCast(Historyfilterform.Controls("CheckBox" & i.ToString()), CheckBox)
                ' If checkbox is checked
                If checkBox.Checked Then
                    ' Get the corresponding AppointmentState from mapping
                    Dim status As AppointmentState = stateMapping(checkBox)
                    ' Filter bookings where the Status matches the mapped AppointmentState
                    Dim filteredByStatus = filteredBookings.Where(Function(booking) booking.Status = status).ToList()
                    Dim filteredByStatus2 As List(Of BookingItem)
                    If i = 5 Then
                        filteredByStatus2 = filteredBookings.Where(Function(booking) booking.Status = AppointmentState.Withdrawn).ToList()
                        NewfilteredBookings.AddRange(filteredByStatus2)
                    End If
                    If i = 6 Then
                        filteredByStatus2 = filteredBookings.Where(Function(booking) booking.Status = AppointmentState.Rejected).ToList()
                        NewfilteredBookings.AddRange(filteredByStatus2)
                    End If
                    NewfilteredBookings.AddRange(filteredByStatus)
                End If
            Next i
            Return NewfilteredBookings
        End If

        ' Return the filtered and sorted bookings
        Return filteredBookings
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Get the search query from the TextBox
        Dim searchQuery As String = TextBox1.Text.Trim()
        Timer1.Enabled = False
        Debug.WriteLine("Service History disabled")
        ' Acquire the semaphore to avoid concurrent access to OriginalBookingsList
        semaphore.WaitOne()
        Dim topPosition As Integer = 0
        Try
            ' Clear any previous results from the panel
            Panel1.Controls.Clear()

            ' Iterate through the original bookings list
            For Each booking As BookingItem In OriginalBookingsList
                ' Check if the worker name contains the search query (case-insensitive)
                If booking.WorkerName.ToLower().Contains(searchQuery) Then
                    ' Create a new instance of the BookingListItem with the matching booking
                    ' Create HistoryItem control
                    Dim historyItem As New HistoryItem(booking.BookingId, booking.WorkerName, booking.ServiceTime, booking.BillAmount, booking.WorkerRating, booking.Status, booking.WorkerPic)

                    ' Add the HistoryItem control to Panel1
                    Panel1.Controls.Add(historyItem)

                    ' Set the position of the HistoryItem control
                    historyItem.Top = topPosition
                    topPosition += historyItem.Height + 10
                End If
            Next
        Finally
            ' Release the semaphore
            semaphore.Release()
        End Try
        Timer1.Enabled = True
        Debug.WriteLine("Service History Enabled")
    End Sub
End Class