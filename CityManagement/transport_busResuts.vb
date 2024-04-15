Imports MySql.Data.MySqlClient

Public Class transport_busResuts
    ' Define properties to store start point, end point, and other variables
    Private _startPoint As String
    Private _endPoint As String
    Private _selectedDate As String

    ' Property for StartPoint
    Public Property StartPoint As String
        Get
            Return _startPoint
        End Get
        Set(value As String)
            _startPoint = value
            Label1.Text = value
        End Set
    End Property

    ' Property for EndPoint
    Public Property EndPoint As String
        Get
            Return _endPoint
        End Get
        Set(value As String)
            _endPoint = value
            Label5.Text = value
        End Set
    End Property

    ' Property for SelectedDate
    Public Property SelectedDate As String
        Get
            Return _selectedDate
        End Get
        Set(value As String)
            _selectedDate = value
            Label6.Text = value
        End Set
    End Property

    Private Property EdgeWeights As Dictionary(Of String, Integer)
    Private Function CheckString(pathString As String, startPoint As String, endPoint As String) As Boolean
        ' Convert both start and end points to uppercase
        Dim str As String = Label1.Text
        Dim characterStartPoint As String = str.Substring(str.Length - 2, 1)
        str = Label5.Text
        Dim characterEndPoint As String = str.Substring(str.Length - 2, 1)

        ' Check if both start and end points appear in the pathString
        Dim startIndex As Integer = pathString.IndexOf(characterStartPoint)
        Dim endIndex As Integer = pathString.IndexOf(characterEndPoint)

        ' Return true if both start and end points are found, and start point appears before end point
        Return startIndex <> -1 AndAlso endIndex <> -1 AndAlso startIndex < endIndex
    End Function

    Private Function FindTime(pathString As String, point As String, departTime As DateTime) As DateTime
        ' Initialize the current time as the departure time
        Dim currentTime As DateTime = departTime
        point = point.Substring(point.Length - 2, 1)
        ' Iterate through each edge in the path until the target point is reached
        Dim startIndex As Integer = 0
        Dim endIndex As Integer = 1
        If pathString.Substring(startIndex, 1) = point Then
            Return currentTime
        End If
        While endIndex < pathString.Length
            ' Get the edge between the current point and the next point
            Dim edge As String = pathString.Substring(startIndex, 2)

            ' Calculate the travel time for the current edge using the edge weights dictionary
            Dim travelTime As Integer = 0
            travelTime = EdgeWeights(edge)


            ' If the next point is the target point, return the arrival time
            If pathString.Substring(endIndex, 1) = point Then
                Return currentTime.AddMinutes(travelTime)
            End If

            ' Update the current time based on the travel time
            currentTime = currentTime.AddMinutes(travelTime)

            ' Move to the next edge
            startIndex += 1
            endIndex += 1
        End While

        ' If the target point is not found in the path, return the departure time
        Return departTime
    End Function


    Private Sub transport_busResuts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve data from the bus table
        Dim query As String = "SELECT b.*, p.path_string FROM bus b JOIN path p ON b.path_id = p.path_id"
        Dim connString As String = Globals.connectionstring
        EdgeWeights = New Dictionary(Of String, Integer) From {
            {"AB", 20},
            {"BC", 30},
            {"CD", 30},
            {"BL", 10},
            {"LM", 20},
            {"BJ", 10},
            {"JK", 20},
            {"BI", 40},
            {"IE", 30},
            {"EG", 40},
            {"GF", 50},
            {"EP", 20},
            {"PQ", 20},
            {"EN", 10},
            {"ND", 30},
            {"BA", 20},
            {"CB", 30},
            {"DC", 30},
            {"LB", 10},
            {"ML", 20},
            {"JB", 10},
            {"KJ", 20},
            {"IB", 40},
            {"EI", 30},
            {"GE", 40},
            {"FG", 50},
            {"PE", 20},
            {"QP", 20},
            {"NE", 10},
            {"DN", 30}
        }
        Dim store As Integer = 0
        Using connection As New MySqlConnection(connString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim pathString As String = reader("path_string").ToString()
                        If checkString(pathString, StartPoint, EndPoint) Then
                            ' Create an instance of the searchComponent user control
                            store = store + 1
                            Dim searchControl As New searchComponent()
                            Dim departureTime As DateTime = DateTime.Parse(reader("depart_time").ToString())
                            ' Populate the properties of the searchComponent user control with data from the database
                            searchControl.BusId = reader("bus_id").ToString()
                            searchControl.DriverName = reader("driver_name").ToString()
                            searchControl.Fprice = reader("girls_price").ToString()
                            searchControl.Mprice = reader("boys_price").ToString()
                            searchControl.From = StartPoint
                            searchControl.EndPoint = EndPoint
                            searchControl.StartTime = FindTime(pathString, StartPoint, departureTime).TimeOfDay.ToString("hh\:mm\:ss")
                            searchControl.EndTime = FindTime(pathString, EndPoint, departureTime).TimeOfDay.ToString("hh\:mm\:ss")

                            ' Populate other properties as needed...

                            ' Add the searchComponent user control to the form
                            FlowLayoutPanel1.Controls.Add(searchControl) ' Assuming you have a FlowLayoutPanel named flowLayoutPanel1
                        End If
                    End While
                End Using
            End Using
        End Using
        If store = 0 Then
            Dim noBusesLabel As New Label()
            noBusesLabel.Text = "No buses available for the selected route."
            noBusesLabel.Font = New Font("Arial", 12, FontStyle.Bold)
            noBusesLabel.ForeColor = Color.Red
            noBusesLabel.AutoSize = True
            noBusesLabel.Location = New Point((FlowLayoutPanel1.Width - noBusesLabel.Width) \ 2, (FlowLayoutPanel1.Height - noBusesLabel.Height) \ 2)
            ' Add the label to the form or any appropriate container
            FlowLayoutPanel1.Controls.Add(noBusesLabel)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim busResultsForm As New transport_busSearch
        mypanel.panel1.Controls.Clear()
        busResultsForm.TopLevel = False
        mypanel.panel1.Controls.Add(busResultsForm)
        busResultsForm.Show()
    End Sub
End Class
