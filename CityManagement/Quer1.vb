Imports MySql.Data.MySqlClient

Public Class Quer1
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)

    Private c_id As Integer

    Private Sub Quer1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim c_id As Integer = Environment.GetEnvironmentVariable("ComplaintID")
            conn.Open()
            Dim query As String = "SELECT complaint, reply, reply_time, status FROM Complaints WHERE complaint_id = @ComplaintID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ComplaintID", c_id)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim complaint As String = reader("complaint").ToString()
                Dim reply As String = reader("reply").ToString()
                Dim status As Integer = Convert.ToInt32(reader("status"))

                ' Set fetched complaint to the Description text box
                description.Text = complaint
                response.Text = reply
            Else
                MessageBox.Show("No data found for complaint_id = " & c_id.ToString(), "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            reader.Close()

            ' Set status to 1 (open) when the form is loaded
            UpdateStatusInDatabase(c_id, 1)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            Dim c_id As Integer = Environment.GetEnvironmentVariable("ComplaintID")
            conn.Open()
            Dim newReply As String = response.Text
            Dim currentTime As DateTime = DateTime.Now
            Dim updateQuery As String = "UPDATE Complaints SET reply = @reply, reply_time = @reply_time, status = 0 WHERE complaint_id = @complaint_id"
            Dim cmd As New MySqlCommand(updateQuery, conn)
            cmd.Parameters.AddWithValue("@reply", newReply)
            cmd.Parameters.AddWithValue("@reply_time", currentTime)
            cmd.Parameters.AddWithValue("@complaint_id", c_id)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        mypanel.Panel1.Controls.Clear()
        Dim form As New Redressal()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim c_id As Integer = Environment.GetEnvironmentVariable("ComplaintID")
            conn.Open()
            Dim newReply As String = response.Text
            Dim currentTime As DateTime = DateTime.Now
            Dim updateQuery As String = "UPDATE Complaints SET reply = @reply, reply_time = @reply_time, status = 2 WHERE complaint_id = @complaint_id"
            Dim cmd As New MySqlCommand(updateQuery, conn)
            cmd.Parameters.AddWithValue("@reply", newReply)
            cmd.Parameters.AddWithValue("@reply_time", currentTime)
            cmd.Parameters.AddWithValue("@complaint_id", c_id)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        mypanel.Panel1.Controls.Clear()
        Dim form As New Redressal()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    ' Update status to 0 when the form is closed
    Private Sub Quer1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim c_id As Integer = Environment.GetEnvironmentVariable("ComplaintID")
        UpdateStatusInDatabase(c_id, 0)
    End Sub

    ' Function to update status in the database
    Private Sub UpdateStatusInDatabase(complaintID As Integer, newStatus As Integer)
        Try
            ' conn.Open()
            Dim query As String = "UPDATE Complaints SET status = @Status WHERE complaint_id = @ComplaintID"
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@Status", newStatus)
                command.Parameters.AddWithValue("@ComplaintID", complaintID)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating status in database: " & ex.Message)

        End Try
    End Sub
End Class
