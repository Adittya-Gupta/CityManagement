Imports MySql.Data.MySqlClient

Public Class complaints_transport_query

    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Private Sub transport_TransportOfficer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim hospital_id As Integer = Convert.ToInt32(Environment.GetEnvironmentVariable("hospital_id"))
        'Label1.Text = Environment.GetEnvironmentVariable("hospital_name")
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
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub
End Class