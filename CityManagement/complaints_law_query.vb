Imports MySql.Data.MySqlClient

Public Class complaints_law_query
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Dim user_id As Integer = Module1.CurrUserSID
    Private Sub compl_hospital_query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Environment.GetEnvironmentVariable("station_name")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show("Doctor ID: " + Convert.ToString(docs(item)) + " Doc Name: " + item)
        Dim station_id As Integer = Convert.ToInt32(Environment.GetEnvironmentVariable("station_id"))
        Dim issue As String = RichTextBox1.Text
        Try
            conn.Open()
            Dim query As String = "Insert into Complaints (from_user_id, to_org_id, complaint) values (@userid, @stationid, @complaint)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userid", user_id)
                cmd.Parameters.AddWithValue("@stationid", station_id)
                cmd.Parameters.AddWithValue("@complaint", issue)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New complaints_law
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class