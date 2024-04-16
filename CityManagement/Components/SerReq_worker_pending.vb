Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class SerReq_worker_pending
    'Dim connString As String = "server=localhost;userid=root;password=pwd;database=smart_city_management"
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Dim requestId As Integer
    Dim clientID As Integer

    ' Constructor with optional parameters
    Public Sub New(ByVal id As Integer,
                   Optional ByVal clientId As Integer = -1,
                  Optional ByVal name As String = "Name",
                   Optional ByVal serviceTime As String = "To be Decided",
                   Optional ByVal billAmount As String = "To be Decided",
                   Optional ByVal profpic As Byte() = Nothing)

        InitializeComponent()

        ' Set the values of the components based on the parameters
        Label1.Text = name
        TextBox1.Text = serviceTime
        TextBox2.Text = billAmount
        requestId = id
        Me.clientID = clientId

        If profpic IsNot Nothing AndAlso profpic.Length > 0 Then
            ' Convert byte array to image
            Using ms As New MemoryStream(profpic)
                Dim img As Image = Image.FromStream(ms)
                'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Image = img
            End Using
        Else
            ' If profpic is null or empty, set PictureBox image to a default image
        End If

        TextBox2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "To be Decided" Then
            MessageBox.Show("Please select a service time before accepting the request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Convert the selected service time to a DateTime object
            Dim selectedServiceTime As DateTime = DateTime.ParseExact(TextBox1.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)

            UpdateStatusServiceTimeAndBillAmount("Upcoming", selectedServiceTime, TextBox2.Text.Trim())

        End If
        'UpdateStatus("Upcoming")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'UpdateStatus("Rejected")
        UpdateStatusServiceTimeAndBillAmount("Rejected", Nothing, Nothing)

    End Sub

    Private Sub UpdateStatusServiceTimeAndBillAmount(ByVal newStatus As String, ByVal selectedServiceTime As DateTime?, ByVal billAmount As String)
        Try
            ' Connect to the database
            conn.Open()
            Dim query As String = "UPDATE serviceBooking SET status = @status, serviceTime = @serviceTime, billAmount = @billAmount WHERE serviceBookingId = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@status", newStatus)
                If selectedServiceTime.HasValue Then
                    cmd.Parameters.AddWithValue("@serviceTime", selectedServiceTime.Value)
                Else
                    cmd.Parameters.AddWithValue("@serviceTime", DBNull.Value)
                End If
                If Not String.IsNullOrEmpty(billAmount) AndAlso billAmount <> "To be Decided" AndAlso billAmount <> "N/A" Then
                    cmd.Parameters.AddWithValue("@billAmount", CInt(billAmount))
                Else
                    cmd.Parameters.AddWithValue("@billAmount", DBNull.Value)
                End If
                cmd.Parameters.AddWithValue("@id", requestId)
                cmd.ExecuteNonQuery()
            End Using

            If newStatus = "Upcoming" Then
                ' Insert a notification for the client
                Dim msg As String = "Your service request has been confirmed. Service Time: " & selectedServiceTime.Value.ToString("yyyy-MM-dd HH:mm:ss")
                Dim query2 As String = "INSERT INTO Notifications (UserID, Type, Message) " & "VALUES (@clientID, 0, @msg)"
                Using cmd2 As New MySqlCommand(query2, conn)
                    cmd2.Parameters.AddWithValue("@clientID", clientID)
                    cmd2.Parameters.AddWithValue("@msg", msg)
                    cmd2.ExecuteNonQuery()
                End Using
                MessageBox.Show("Service request confirmed. Notification sent to the client.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf newStatus = "Rejected" Then
                ' Insert a notification for the client
                Dim msg As String = "Your service request has been rejected."
                Dim query2 As String = "INSERT INTO Notifications (UserID, Type, Message) " & "VALUES (@clientID, 0, @msg)"
                Using cmd2 As New MySqlCommand(query2, conn)
                    cmd2.Parameters.AddWithValue("@clientID", clientID)
                    cmd2.Parameters.AddWithValue("@msg", msg)
                    cmd2.ExecuteNonQuery()
                End Using
                MessageBox.Show("Service request rejected. Notification sent to the client.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            ' After updating the status, service time, and bill amount, call LoadServiceRequests() from the parent form
            Dim parentForm As Services_WorkSect = TryCast(Me.ParentForm, Services_WorkSect)
                If parentForm IsNot Nothing Then
                parentForm.LoadServiceRequests()
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating status, service time, and bill amount: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            conn.Close()
        End Try


    End Sub

    'Private Sub UpdateStatus(ByVal newStatus As String)
    '    Try
    '        ' Connect to the database
    '        conn.Open()
    '        Dim query As String = "UPDATE serviceBooking SET status = @status" &
    '                          If(newStatus = "Upcoming" AndAlso TextBox2.Text <> "To be Decided" AndAlso TextBox2.Text <> "N/A", ", billAmount = @billAmount", "") &
    '                          " WHERE serviceBookingId = @id"
    '        Using cmd As New MySqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@status", newStatus)
    '            If newStatus = "Upcoming" Then
    '                If TextBox2.Text <> "To be Decided" AndAlso TextBox2.Text <> "N/A" Then
    '                    cmd.Parameters.AddWithValue("@billAmount", Integer.Parse(TextBox2.Text))
    '                End If
    '            End If
    '            cmd.Parameters.AddWithValue("@id", requestId)
    '            cmd.ExecuteNonQuery()
    '        End Using

    '        ' After updating the status, call LoadServiceRequests() from the parent form
    '        Dim parentForm As Services_WorkSect = TryCast(Me.ParentForm, Services_WorkSect)
    '        If parentForm IsNot Nothing Then
    '            parentForm.LoadServiceRequests()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error updating status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        ' Close the database connection
    '        conn.Close()
    '    End Try

    'End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        TextBox2.Enabled = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' Update the text of the textbox to reflect the selected service time
        TextBox1.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub
End Class
