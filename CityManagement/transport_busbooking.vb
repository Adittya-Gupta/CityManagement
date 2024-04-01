
Imports MySql.Data.MySqlClient

Public Class transport_busbooking
    Private _busId As String
    Private _from As String
    Private _endpoint As String
    Private _tottime As Integer
    Public Property BusId As String
        Get
            Return _busId
        End Get
        Set(value As String)
            _busId = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property
    Public Property StartPoint As String
        Get
            Return _from
        End Get
        Set(value As String)
            _from = value
            Label16.Text = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    Public Property EndPoint As String
        Get
            Return _endpoint
        End Get
        Set(value As String)
            _endpoint = value
            Label17.Text = value
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    Public Property totTime As String
        Get
            Return _tottime
        End Get
        Set(value As String)
            _tottime = value
            Label25.Text = value + "min"
            ' Optionally, update UI elements or perform other actions when the property value changes
        End Set
    End Property

    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Private Sub transport_busbooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim busIdToRetrieve = _busId
            RetrieveBusInfo(busIdToRetrieve)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub RetrieveBusInfo(busId As Integer)
        Dim query As String = "SELECT * FROM bus WHERE bus_id = @busId"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@busId", busId)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' Retrieve bus information
                Dim driverName As String = reader.GetString("driver_name")
                Dim driverNumber As String = reader.GetString("driver_numner")
                Dim girlsSeat As Integer = reader.GetInt32("girls_seat")
                Dim boysSeat As Integer = reader.GetInt32("boys_seat")
                Dim girlsPrice As Double = reader.GetDouble("girls_price") * totTime
                Dim boysPrice As Double = reader.GetDouble("boys_price") * totTime
                Dim pathId As Integer = reader.GetInt32("path_id")
                Label18.Text = girlsSeat
                Label19.Text = boysSeat
                Label20.Text = girlsPrice
                Label21.Text = boysPrice
                reader.Close()
            Else
                MessageBox.Show("Bus not found with ID: " & busId)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function RetrieveFromAndEndPt(pathId As Integer) As Tuple(Of String, String)
        Dim fromPt As String = ""
        Dim endPt As String = ""
        Dim query As String = "SELECT p.from_pt, p.end_pt FROM path p WHERE p.path_id = @pathId"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@pathId", pathId)

        Try
            Dim reader1 As MySqlDataReader = cmd.ExecuteReader()
            If reader1.Read() Then
                fromPt = reader1.GetString("from_pt")
                endPt = reader1.GetString("end_pt")
            End If
            reader1.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return New Tuple(Of String, String)(fromPt, endPt)
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label22.Text = TextBox7.Text * Label20.Text + TextBox8.Text * Label21.Text
        Label24.Text = Label22.Text
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class