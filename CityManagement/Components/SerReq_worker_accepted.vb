Imports System.IO
Imports MySql.Data.MySqlClient

Public Class SerReq_worker_accepted
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
                   Optional ByVal serviceTime As String = "Will be updated",
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
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Image = img
            End Using
        Else
            ' If profpic is null or empty, set PictureBox image to a default image
        End If

        TextBox2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "To be Decided" Or TextBox2.Text = "N/A" Then
            ' If TextBox2 value is default, prompt the user to update the bill amt
            MessageBox.Show("Please update the bill amount before marking as done.", "Update Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox2.Focus() ' Set focus to TextBox1 to prompt user attention
        Else
            UpdateStatus("InProgress")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateStatus("Cancelled")
    End Sub

    Private Sub UpdateStatus(ByVal newStatus As String)
        Try
            ' Connect to the database
            conn.Open()
            Dim query As String = "UPDATE serviceBooking SET status = @status" & If(newStatus = "InProgress", ", billAmount = @billAmount", "") & " WHERE serviceBookingId = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@status", newStatus)
                If newStatus = "InProgress" Then
                    cmd.Parameters.AddWithValue("@billAmount", Integer.Parse(TextBox2.Text))
                End If
                cmd.Parameters.AddWithValue("@id", requestId)
                cmd.ExecuteNonQuery()
            End Using

            If newStatus = "InProgress" Then
                ' Insert a notification for the client
                Dim msg As String = "Your service requirement is completed. Payment due: " & TextBox2.Text
                Dim query2 As String = "INSERT INTO Notifications (UserID, Type, Message) " & "VALUES (@clientID, 0, @msg)"
                Using cmd2 As New MySqlCommand(query2, conn)
                    cmd2.Parameters.AddWithValue("@clientID", clientID)
                    cmd2.Parameters.AddWithValue("@msg", msg)
                    cmd2.ExecuteNonQuery()
                End Using
                MessageBox.Show("Work Done. Payment notification sent to the client.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf newStatus = "Cancelled" Then
                ' Insert a notification for the client
                Dim msg As String = "Your service request has been cancelled."
                Dim query2 As String = "INSERT INTO Notifications (UserID, Type, Message) " & "VALUES (@clientID, 0, @msg)"
                Using cmd2 As New MySqlCommand(query2, conn)
                    cmd2.Parameters.AddWithValue("@clientID", clientID)
                    cmd2.Parameters.AddWithValue("@msg", msg)
                    cmd2.ExecuteNonQuery()
                End Using
                MessageBox.Show("Service request cancelled. Notification sent to the client.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' After updating the status, call LoadServiceRequests() from the parent form
            Dim parentForm As Services_WorkSect = TryCast(Me.ParentForm, Services_WorkSect)
            If parentForm IsNot Nothing Then
                parentForm.LoadServiceRequests()
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            conn.Close()
        End Try

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        TextBox2.Enabled = True
    End Sub
End Class