Imports MySql.Data.MySqlClient

Public Class ListofWorkers_Citizen
    Private Filterform As New Workersfilter()
    Public Sub New()
        InitializeComponent()
        AddHandler Me.VisibleChanged, AddressOf ListofWorkers_Citizen_VisibleChanged
        ' Subscribe to the Job_SelectedChanged event
        AddHandler Globals.Job_SelectedChanged, AddressOf Job_SelectedChanged_Handler
    End Sub
    Private Sub ListofWorkers_Citizen_VisibleChanged(sender As Object, e As EventArgs)
        If Not Me.Visible Then
            Filterform.Hide()
        End If
    End Sub
    Private Sub Job_SelectedChanged_Handler(sender As Object, e As EventArgs)

        ' Clear existing controls from Panel1
        Panel1.Controls.Clear()

        ' Execute SQL query to fetch data from the database
        Dim query As String = "SELECT U.Name AS WorkerName, O.Location AS OrgLocation, SW.rating AS WorkerRating, SW.noOfRatings AS WorkerNumberOfRatings, U.ContactNo AS WorkerPhoneNumber FROM serviceWorkers SW JOIN User U ON SW.userID = U.SID JOIN serviceOrganizations O ON SW.orgID = O.OrgID WHERE U.Designation = @Designation"

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
                        Dim workerName As String = reader("WorkerName").ToString()
                        Dim orgLocation As String = reader("OrgLocation").ToString()
                        Dim workerRating As String = reader("WorkerRating").ToString()
                        Dim workerNumberOfRatings As String = reader("WorkerNumberOfRatings").ToString()
                        Dim workerPhoneNumber As String = reader("WorkerPhoneNumber").ToString()

                        ' Create ListItem
                        Dim listItem As New ListItem(workerName, orgLocation, workerNumberOfRatings & " ratings", workerPhoneNumber, Double.Parse(workerRating))

                        ' Set the top position of the ListItem
                        listItem.Top = topPosition

                        ' Add the ListItem to Panel1
                        Panel1.Controls.Add(listItem)

                        ' Increment top position for the next ListItem
                        topPosition += 200
                    End While
                End Using
            End Using
        End Using

    End Sub



    Private Sub CurvedLabel9_Click(sender As Object, e As EventArgs) Handles CurvedLabel9.Click
        ' Show list of Workers form inside Panel1
        Globals.listofServicesForm = New ListofServices_Citizen()
        Globals.HomePage = Globals.listofServicesForm
        Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.HomePage)
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Search for Service Provider" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.White ' Change text color to normal
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            TextBox1.Text = "Search for Service Provider"
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
