Imports MySql.Data.MySqlClient



Public Class ListofWorkers_Citizen
    Public Class Worker
        Public Property WorkerId As String
        Public Property WorkerName As String
        Public Property OrgLocation As String
        Public Property WorkerRating As Double
        Public Property WorkerNumberOfRatings As Integer
        Public Property WorkerPhoneNumber As String

        ' Constructor to initialize properties
        Public Sub New(ByVal id As String, ByVal name As String, ByVal location As String, ByVal rating As Double, ByVal numberOfRatings As Integer, ByVal phoneNumber As String)
            WorkerId = id
            WorkerName = name
            OrgLocation = location
            WorkerRating = rating
            WorkerNumberOfRatings = numberOfRatings
            WorkerPhoneNumber = phoneNumber
        End Sub
    End Class
    Private Filterform As New Workersfilter()
    Private OriginalWorkersList As New List(Of Worker)() ' List to store original list of workers
    Private WorkerCount As Integer ' Member variable to store the count of workers

    Public Sub New()
        InitializeComponent()
        AddHandler Me.VisibleChanged, AddressOf ListofWorkers_Citizen_VisibleChanged
        ' Subscribe to the Job_SelectedChanged event
        AddHandler Globals.Job_SelectedChanged, AddressOf Job_SelectedChanged_Handler
        ' Initialize WorkerCount
        WorkerCount = 0
        MessageBox.Show("List of Workers Citizen")
        ' Start the timer
        Timer1.Interval = 5000 ' Set the interval to 1 second
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        If Globals.Job_Selected = "1" Then
            Timer1.Enabled = True
            Return
        End If
        ' Execute SQL query to fetch count of workers from the database
        Dim countQuery As String = "SELECT COUNT(*) FROM serviceWorkers SW JOIN User U ON SW.userID = U.SID JOIN serviceOrganizations O ON SW.orgID = O.OrgID WHERE U.Designation = @Designation"

        ' Create MySQL connection
        Using connection As New MySqlConnection(Globals.connectionstring)
            ' Open the connection
            connection.Open()

            ' Create MySqlCommand
            Using command As New MySqlCommand(countQuery, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@Designation", Globals.Job_Selected)

                ' Execute the command and get the count
                Dim newCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' Check if the count has changed
                If newCount <> WorkerCount Then
                    ' Update WorkerCount
                    MessageBox.Show("WorkerCount: " & WorkerCount)
                    WorkerCount = newCount
                    MessageBox.Show("WorkerCount: " & WorkerCount)
                    ' Call the Job_SelectedChanged_Handler to update the UI
                    Job_SelectedChanged_Handler(Nothing, EventArgs.Empty)

                    ' Reset the timer interval to 1 second
                    Timer1.Interval = 5000
                Else
                    ' If count has not changed, double the interval up to 128 seconds
                    If Timer1.Interval < 128000 Then
                        Timer1.Interval *= 2
                    End If
                End If
            End Using
        End Using
        Timer1.Enabled = True
    End Sub

    Private Sub ListofWorkers_Citizen_VisibleChanged(sender As Object, e As EventArgs)
        If Not Me.Visible Then
            Filterform.Hide()
        End If
    End Sub

    Private Sub Job_SelectedChanged_Handler(sender As Object, e As EventArgs)
        Timer1.Enabled = False
        MessageBox.Show("Job_SelectedChanged_Handler")
        WorkerCount = 0
        ' Clear existing controls from Panel1
        Panel1.Controls.Clear()
        OriginalWorkersList.Clear()
        Filterform = New Workersfilter()
        ' Execute SQL query to fetch data from the database
        Dim query As String = "SELECT SW.workerID as WorkerId, U.Name AS WorkerName, O.Location AS OrgLocation, SW.rating AS WorkerRating, SW.noOfRatings AS WorkerNumberOfRatings, U.ContactNo AS WorkerPhoneNumber FROM serviceWorkers SW JOIN User U ON SW.userID = U.SID JOIN serviceOrganizations O ON SW.orgID = O.OrgID WHERE U.Designation = @Designation"

        ' Create MySQL connection
        ' Create MySQL connection
        Using connection As New MySqlConnection(Globals.connectionstring)
            ' Open the connection
            connection.Open()

            ' Create MySqlCommand
            Using command As New MySqlCommand(query, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@Designation", Globals.Job_Selected)

                ' Execute the command and create a reader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Initialize variable to track top position
                    Dim topPosition As Integer = 0

                    ' Loop through the results and create ListItems
                    While reader.Read()
                        ' Read data from the reader
                        Dim workerId As String = reader("WorkerId").ToString()
                        Dim workerName As String = reader("WorkerName").ToString()
                        Dim orgLocation As String = reader("OrgLocation").ToString()
                        Dim workerRating As String = reader("WorkerRating").ToString()
                        Dim workerNumberOfRatings As Integer = reader.GetInt32(reader.GetOrdinal("WorkerNumberOfRatings"))
                        Dim workerPhoneNumber As String = reader("WorkerPhoneNumber").ToString()

                        ' Create Worker object
                        Dim worker As New Worker(workerId, workerName, orgLocation, Double.Parse(workerRating), workerNumberOfRatings, workerPhoneNumber)
                        'Dim listItem As New ListItem(worker.WorkerId, worker.WorkerName, worker.OrgLocation, workerNumberOfRatings, worker.WorkerPhoneNumber, worker.WorkerRating)

                        '' Set the top position of the ListItem
                        'listItem.Top = topPosition

                        '' Add the ListItem to Panel1
                        'Panel1.Controls.Add(listItem)
                        WorkerCount += 1
                        '' Increment top position for the next ListItem
                        'topPosition += 200
                        ' Add worker to original list
                        OriginalWorkersList.Add(worker)
                    End While
                End Using
            End Using
        End Using
        Timer1.Enabled = True
        ' Update UI to display filtered list of workers
        UpdateUIWithFilteredWorkers()
    End Sub

    ' Method to update UI with filtered list of workers
    Public Sub UpdateUIWithFilteredWorkers()
        ' Clear existing controls from Panel1
        Panel1.SuspendLayout()
        Panel1.Controls.Clear()

        ' Filter and sort the workers based on the TrackBar and CheckBox controls
        Dim filteredAndSortedWorkers = FilterAndSortWorkers()
        'MessageBox.Show("Update UI with filtered workers")
        ' Initialize variable to track top position
        Dim topPosition As Integer = 0

        ' Loop through the filtered and sorted workers list and create ListItems
        For Each worker As Worker In filteredAndSortedWorkers
            ' Create ListItem
            Dim listItem As New ListItem(worker.WorkerId, worker.WorkerName, worker.OrgLocation, worker.WorkerNumberOfRatings.ToString() & " ratings", worker.WorkerPhoneNumber, worker.WorkerRating)

            ' Set the top position of the ListItem
            listItem.Top = topPosition

            ' Add the ListItem to Panel1
            Panel1.Controls.Add(listItem)

            ' Increment top position for the next ListItem
            topPosition += 120
        Next
        Panel1.ResumeLayout()
    End Sub

    Private Function FilterAndSortWorkers() As List(Of Worker)
        ' Apply filtering based on Rating
        Dim filteredWorkers = OriginalWorkersList.Where(Function(w) Double.Parse(w.WorkerRating) > Double.Parse(Filterform.Label2.Text.Split(" ")(0))).ToList()

        ' Apply sorting based on CheckBox state for WorkerRating
        Select Case Filterform.CheckBox1.CheckState
            Case CheckState.Checked
                ' Sort in decreasing order of WorkerRating
                filteredWorkers = filteredWorkers.OrderByDescending(Function(w) Double.Parse(w.WorkerRating)).ToList()
            Case CheckState.Indeterminate
                ' Sort in increasing order of WorkerRating
                filteredWorkers = filteredWorkers.OrderBy(Function(w) Double.Parse(w.WorkerRating)).ToList()
        End Select

        ' Apply sorting based on CheckBox state for WorkerNumberOfRatings
        Select Case Filterform.CheckBox2.CheckState
            Case CheckState.Checked
                ' Sort in decreasing order of WorkerNumberOfRatings
                filteredWorkers = filteredWorkers.OrderByDescending(Function(w) Double.Parse(w.WorkerNumberOfRatings)).ToList()
            Case CheckState.Indeterminate
                ' Sort in increasing order of WorkerNumberOfRatings
                filteredWorkers = filteredWorkers.OrderBy(Function(w) Double.Parse(w.WorkerNumberOfRatings)).ToList()
        End Select

        ' Return the filtered and sorted workers
        Return filteredWorkers
    End Function


    Private Sub CurvedLabel9_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Show list of Workers form inside Panel1
        Globals.listofServicesForm = New ListofServices_Citizen
        Globals.HomePage = Globals.listofServicesForm
        Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.HomePage)
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Search for Vendors" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.White ' Change text color to normal
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            TextBox1.Text = "Search for  Vendors"
            TextBox1.ForeColor = Color.Gray ' Change text color to placeholder color
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Check if Filterform is already visible
        If Filterform.Visible Then
            ' If Filterform is already visible, hide it
            Filterform.Hide()
        Else
            Filterform.BringToFront()
            ' If Filterform is not visible, show it
            Filterform.Show()
        End If
    End Sub

End Class
