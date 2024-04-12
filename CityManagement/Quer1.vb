Imports MySql.Data.MySqlClient

Public Class Quer1
    Dim connString As String = "server=172.16.114.244;userid=admin;password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)



    Private c_id As Integer

    Private Sub Quer1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim c_id As Integer = Environment.GetEnvironmentVariable("ComplaintID")
            'c_id = If(Integer.TryParse(complaint_id_str, c_id), c_id, 1)

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
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub description_Click(sender As Object, e As EventArgs) Handles description.Click

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            Dim c_id As Integer = Environment.GetEnvironmentVariable("ComplaintID")
            ' c_id = If(Integer.TryParse(complaint_id_str, c_id), c_id, 1)
            conn.Open()
            Dim newReply As String = response.Text
            Dim currentTime As DateTime = DateTime.Now
            Dim updateQuery As String = "UPDATE Complaints SET reply = @reply, reply_time = @reply_time, status = False WHERE complaint_id = @complaint_id"
            Dim cmd As New MySqlCommand(updateQuery, conn)
            cmd.Parameters.AddWithValue("@reply", newReply)
            cmd.Parameters.AddWithValue("@reply_time", currentTime)
            cmd.Parameters.AddWithValue("@complaint_id", c_id) ' Assuming c_id holds the complaint ID
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        Dim Redressal As New Redressal()
        MainPanel.switchPanel(Redressal)
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim c_id As Integer = Environment.GetEnvironmentVariable("ComplaintID")
            ' Open connection to the database
            conn.Open()

            ' Retrieve the new reply from the answer TextBox
            Dim newReply As String = response.Text

            ' Get the current time
            Dim currentTime As DateTime = DateTime.Now

            ' Update the reply, reply_time, and status fields in the database
            Dim updateQuery As String = "UPDATE Complaints SET reply = @reply, reply_time = @reply_time, status = True WHERE complaint_id = @complaint_id"
            Dim cmd As New MySqlCommand(updateQuery, conn)
            cmd.Parameters.AddWithValue("@reply", newReply)
            cmd.Parameters.AddWithValue("@reply_time", currentTime)
            cmd.Parameters.AddWithValue("@complaint_id", c_id) ' Assuming c_id holds the complaint ID

            ' Execute the query
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection to the database
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        Dim Redressal As New Redressal()
        MainPanel.switchPanel(Redressal)
    End Sub

End Class