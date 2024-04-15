Imports MySql.Data.MySqlClient

Public Class complaints_hospital_query
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Dim docs As New Dictionary(Of String, Integer)
    Dim user_id As Integer = Module1.CurrUserSID
    Private Sub compl_hospital_query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hospital_id As Integer = Convert.ToInt32(Environment.GetEnvironmentVariable("hospital_id"))
        Label3.Text = Environment.GetEnvironmentVariable("hospital_name")
        Dim owner_id As Integer
        Try
            conn.Open()
            Dim query As String = "select Owner_ID from Institutes where ID = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", hospital_id)
                Dim reader = cmd.ExecuteReader
                reader.Read()
                owner_id = Convert.ToInt32(reader("Owner_ID"))
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.Open()
            Dim query As String = "select Name from User where SID = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", owner_id)
                Dim reader = cmd.ExecuteReader
                reader.Read()
                CheckedListBox1.Items.Add(reader("Name"))
                docs.Add(reader("Name"), owner_id)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        'MessageBox.Show("Owner: " + owner_id.ToString())
        Dim doc_ids As New List(Of Integer)
        Try
            conn.Open()
            Dim query As String = "select doctor_id from Doctors where hos_id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", hospital_id)
                Dim reader = cmd.ExecuteReader
                While reader.Read()
                    doc_ids.Add(Convert.ToInt32(reader("doctor_id")))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Try
            conn.Open()
            While doc_ids.Count > 0
                Dim doc_id As New Integer
                doc_id = doc_ids(0)
                doc_ids.RemoveAt(0)
                Dim query As String = "select Name from User where SID = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", doc_id)
                    Dim reader = cmd.ExecuteReader
                    reader.Read()
                    CheckedListBox1.Items.Add(reader("Name"))
                    docs.Add(reader("Name"), doc_id)
                    reader.Close()
                End Using
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item As String In CheckedListBox1.CheckedItems
            'MessageBox.Show("Doctor ID: " + Convert.ToString(docs(item)) + " Doc Name: " + item)
            Dim doc_id As Integer = docs(item)
            Dim issue As String = RichTextBox1.Text
            Try
                conn.Open()
                Dim query As String = "Insert into Complaints (from_user_id, to_user_id, complaint) values (@userid, @docid, @complaint)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userid", user_id)
                    cmd.Parameters.AddWithValue("@docid", doc_id)
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New complaints_Hospital
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