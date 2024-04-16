Public Class Email_Draft

    Public Property username_test As String

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String


    'Dim server As String = "localhost"
    'Dim username As String = "root"
    ' Dim password As String = "12345678"
    ' Dim database As String = "emaildatabase"

    'Public server As String = "MYSQL9001.site4now.net"
    'Public username As String = "aa78df_scms"
    'Public password As String = "abcd1234"
    'Public database As String = "db_aa78df_scms"

    ' Dim username_test As String = "achyut@gmail.com"
    'Dim username_test As String = Email_Landing.User_EmailID





    Private Sub Email_Draft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub



    Private Sub updateTable()
        Try
            ' Close the connection before modifying the connection string property
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next

            ' Set the connection string property
            'sqlConn.ConnectionString = "server=MYSQL9001.site4now.net;userid=aa78df_scms;Password=abcd1234;database=db_aa78df_scms;sslmode=none"
            sqlConn.ConnectionString = GlobalConnString.str

            ' Open the connection
            sqlConn.Open()

            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "SELECT * FROM EmailsData WHERE Draft=1 AND Email_From=@Email_From"
            sqlCmd.CommandType = CommandType.Text
            sqlCmd.Parameters.AddWithValue("@Email_From", username_test)

            sqlRd = sqlCmd.ExecuteReader
            sqlCmd.Parameters.Clear()


            sqlDt.Clear()
            sqlDt.Load(sqlRd)
            sqlRd.Close()

            ' Close the connection after use
            sqlConn.Close()

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.ScrollBars = ScrollBars.Both
            DataGridView1.DataSource = sqlDt

        Catch ex As Exception
            MessageBox.Show("Error updating table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub








    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        Try
            'sqlConn.ConnectionString = "server=MYSQL9001.site4now.net;userid=aa78df_scms;Password=abcd1234;database=db_aa78df_scms;sslmode=none"
            sqlConn.ConnectionString = GlobalConnString.str

            sqlConn.Open()

            sqlCmd.Connection = sqlConn

            With sqlCmd
                .CommandText = "DELETE FROM EmailsData WHERE Subject=@Subject AND Content=@Content"
                .CommandType = CommandType.Text

                .Parameters.AddWithValue("@Subject", Subject_TextBox.Text)
                .Parameters.AddWithValue("@Content", Content_TextBox.Text)

                ' Execute the command
                .ExecuteNonQuery()

                ' Clear parameters for next update operation
                .Parameters.Clear()
            End With


            MessageBox.Show("Record Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)




            ' Refresh DataGridView to reflect the updated data
            updateTable()

        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try
    End Sub






    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is in the leftmost column
        If e.ColumnIndex >= 0 Then
            ' If not, exit the event handler without performing any action
            Return
        End If

        ' Now proceed to load data into text boxes only if the clicked cell is in the leftmost column
        Try
            To_TextBox.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            Subject_TextBox.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            Content_TextBox.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString











        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        Try
            ' Clear all text boxes on the form
            For Each ctrl In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    DirectCast(ctrl, TextBox).Text = ""
                End If
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Draft_Button_Click(sender As Object, e As EventArgs) Handles Draft_Button.Click
        Try
            'sqlConn.ConnectionString = "server=MYSQL9001.site4now.net;userid=aa78df_scms;Password=abcd1234;database=db_aa78df_scms;sslmode=none"
            sqlConn.ConnectionString = GlobalConnString.str
            sqlConn.Open()

            sqlCmd.Connection = sqlConn

            With sqlCmd
                .CommandText = "INSERT INTO EmailsData(Email_From,Email_To,Subject,Content,Draft) VALUES (@Email_From,@Email_To,@Subject,@Content,@Draft)"
                .CommandType = CommandType.Text


                ' Add parameters within the With block only
                .Parameters.Clear()
                .Parameters.AddWithValue("@Email_From", username_test)
                .Parameters.AddWithValue("@Email_To", To_TextBox.Text)
                .Parameters.AddWithValue("@Subject", Subject_TextBox.Text)
                .Parameters.AddWithValue("@Content", Content_TextBox.Text)
                .Parameters.AddWithValue("@Draft", 1)


                ' Execute the command
                .ExecuteNonQuery()

                ' Clear parameters for next update operation
                .Parameters.Clear()
            End With


            MessageBox.Show("New record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)




            ' Refresh DataGridView to reflect the updated data
            updateTable()

        Catch ex As Exception
            MessageBox.Show("Error adding new record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try
    End Sub

    Private Sub Send_Button_Click(sender As Object, e As EventArgs) Handles Send_Button.Click
        Try
            'sqlConn.ConnectionString = "server=MYSQL9001.site4now.net;userid=aa78df_scms;Password=abcd1234;database=db_aa78df_scms;sslmode=none"
            sqlConn.ConnectionString = GlobalConnString.str
            sqlConn.Open()

            sqlCmd.Connection = sqlConn

            With sqlCmd
                ' Check if the email already exists
                .CommandText = "SELECT COUNT(*) FROM EmailsData WHERE Email_From = @Email_From AND Email_To = @Email_To AND Subject = @Subject AND Content = @Content"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@Email_From", username_test)
                .Parameters.AddWithValue("@Email_To", To_TextBox.Text)
                .Parameters.AddWithValue("@Subject", Subject_TextBox.Text)
                .Parameters.AddWithValue("@Content", Content_TextBox.Text)

                Dim count As Integer = Convert.ToInt32(.ExecuteScalar())

                ' If email exists, update the Draft bit to 0
                If count > 0 Then
                    .CommandText = "UPDATE EmailsData SET Draft = 0 WHERE Email_From = @Email_From AND Email_To = @Email_To AND Subject = @Subject AND Content = @Content"
                    .ExecuteNonQuery()
                    MessageBox.Show("Email sent successfully. Old Draft Sent)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' If email doesn't exist, add a new record to the database
                    .CommandText = "INSERT INTO EmailsData(Email_From, Email_To, Subject, Content, Draft) VALUES (@Email_From, @Email_To, @Subject, @Content, @Draft)"
                    .Parameters.AddWithValue("@Draft", 0)
                    .ExecuteNonQuery()
                    MessageBox.Show("Email sent successfully. New Email Sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Clear parameters for next operation
                .Parameters.Clear()
            End With



            ' Refresh DataGridView to reflect the updated data
            updateTable()

        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try
    End Sub


    Private Sub Refresh_Button_Click(sender As Object, e As EventArgs) Handles Refresh_Button.Click
        updateTable()
    End Sub
End Class