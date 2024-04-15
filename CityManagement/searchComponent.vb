Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class searchComponent
    ' Private fields to store property values
    Private _busId As String
    Private _driverName As String
    Private _from As String
    Private _endpoint As String
    Private _boysprice As String
    Private _girlsprice As String
    Private _starttime As String
    Private _endtime As String
    ' Public property for BusId
    Public Property BusId As String
        Get
            Return _busId
        End Get
        Set(value As String)
            _busId = value
            Label8.Text = value
            Label9.Text = FindPathName(value)
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    ' Public property for DriverName
    Public Property DriverName As String
        Get
            Return _driverName
        End Get
        Set(value As String)
            _driverName = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    ' Public property for DriverName
    Public Property From As String
        Get
            Return _from
        End Get
        Set(value As String)
            _from = value
            Label4.Text = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    Public Property EndPoint As String
        Get
            Return _endpoint
        End Get
        Set(value As String)
            _endpoint = value
            Label6.Text = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    Public Property FPrice As String
        Get
            Return _boysprice
        End Get
        Set(value As String)
            _boysprice = value
            Label12.Text = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    Public Property MPrice As String
        Get
            Return _girlsprice
        End Get
        Set(value As String)
            _girlsprice = value
            Label13.Text = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    Public Property StartTime As String
        Get
            Return _starttime
        End Get
        Set(value As String)
            _starttime = value
            Label3.Text = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    Public Property EndTime As String
        Get
            Return _endtime
        End Get
        Set(value As String)
            _endtime = value
            Label5.Text = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    ' Add more properties as needed...
    Private Function FindPathName(busId As String) As String
        Dim pathName As String = ""

        ' Your connection string
        Dim connectionString As String = Globals.connectionstring

        ' Your SQL query to retrieve path name based on busId
        Dim query As String = "SELECT p.path_name FROM bus b JOIN path p ON b.path_id = p.path_id WHERE b.bus_id = @busId"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@busId", busId)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    pathName = reader("path_name").ToString()
                End If
            End Using
        End Using

        Return pathName
    End Function
    ' Constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Assuming busId is stored in a property named BusId
        Dim busId As String = Me.BusId

        ' Create an instance of the transport_busbooking form
        Dim bookingForm As New transport_busbooking()

        ' Pass the busId to the transport_busbooking form
        bookingForm.BusId = busId
        ' Parse the time strings into DateTime objects
        Dim time1 As DateTime = DateTime.ParseExact(StartTime, "HH:mm:ss", CultureInfo.InvariantCulture)
        Dim time2 As DateTime = DateTime.ParseExact(EndTime, "HH:mm:ss", CultureInfo.InvariantCulture)

        ' Calculate the time difference
        Dim timeDifference As TimeSpan = time2 - time1
        bookingForm.totTime = CInt(timeDifference.TotalMinutes)
        bookingForm.StartPoint = Label4.Text
        bookingForm.EndPoint = Label6.Text
        ' Show the transport_busbooking form
        mypanel.panel1.Controls.Clear()
        bookingForm.TopLevel = False
        mypanel.panel1.Controls.Add(bookingForm)
        bookingForm.Show()
 

        ' Optionally, you can hide the current form if needed
        ' Me.ParentForm.Hide()
    End Sub


End Class