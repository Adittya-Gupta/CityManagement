Imports MySql.Data.MySqlClient

Public Class complaints_transport_query
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Dim drivers As New Dictionary(Of String, Integer)
    Dim user_id As Integer = Module1.CurrUserSID
    Private Sub compl_transport_query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim transport_id As Integer = Convert.ToInt32(Environment.GetEnvironmentVariable("transport_id"))
        'MessageBox.Show("Owner: " + owner_id.ToString())
        Try
            conn.Open()
            Dim query As String = "select SID, Name from User where Designation = 'Driver'"
            Using cmd As New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                While reader.Read()
                    drivers.Add(Convert.ToString(reader("Name")), Convert.ToInt32(reader("SID")))
                    CheckedListBox1.Items.Add(reader("Name"))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item As String In CheckedListBox1.CheckedItems
            'MessageBox.Show("Doctor ID: " + Convert.ToString(docs(item)) + " Doc Name: " + item)
            Dim driver_id As Integer = drivers(item)
            Dim issue As String = RichTextBox1.Text
            Try
                conn.Open()
                Dim query As String = "Insert into Complaints (from_user_id, to_user_id, complaint) values (@userid, @driverid, @complaint)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userid", user_id)
                    cmd.Parameters.AddWithValue("@driverid", driver_id)
                    cmd.Parameters.AddWithValue("@complaint", issue)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Close()
            End Try
        Next
        MessageBox.Show("Complaint registered successfully")
        mypanel.panel1.Controls.Clear()
        Dim form As New complaints
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New complaints
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class