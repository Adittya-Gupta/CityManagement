Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class SerReq_worker_pending
    'Dim connString As String = "server=localhost;userid=root;password=<password_here>;database=smart_city_management"
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim requestId As Integer

    ' Constructor with optional parameters
    Public Sub New(ByVal id As Integer,
                  Optional ByVal name As String = "Name",
                   Optional ByVal serviceTime As String = "Will be updated",
                   Optional ByVal billAmount As String = "To be Decided")

        InitializeComponent()

        ' Set the values of the components based on the parameters
        Label1.Text = name
        TextBox1.Text = serviceTime
        TextBox2.Text = billAmount
        requestId = id
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateStatus("Upcoming")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateStatus("Rejected")
    End Sub

    Private Sub UpdateStatus(ByVal newStatus As String)
        Try
            ' Connect to the database
            conn.Open()
            Dim query As String = "UPDATE serviceBooking SET status = @status" &
                              If(newStatus = "Upcoming" AndAlso TextBox2.Text <> "To be Decided" AndAlso TextBox2.Text <> "N/A", ", billAmount = @billAmount", "") &
                              " WHERE serviceBookingId = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@status", newStatus)
                If newStatus = "Upcoming" Then
                    If TextBox2.Text <> "To be Decided" AndAlso TextBox2.Text <> "N/A" Then
                        cmd.Parameters.AddWithValue("@billAmount", Integer.Parse(TextBox2.Text))
                    End If
                End If
                cmd.Parameters.AddWithValue("@id", requestId)
                cmd.ExecuteNonQuery()
            End Using

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
