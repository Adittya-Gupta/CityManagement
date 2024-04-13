Imports MySql.Data.MySqlClient

Public Class FestivalEvents_Approval
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Private isApproved As Boolean = False ' Variable to track approval status

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FestivalEvents_Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim query As String = "SELECT isApproved FROM festivals WHERE id = @CurrEvent"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CurrEvent", Module1.CurrEventID)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    isApproved = Convert.ToBoolean(result)
                    ' Update button appearance based on the approval status
                    If isApproved Then
                        ToggleButton.Text = "Remove Approval"
                        ToggleButton.BackColor = Color.Gray
                    Else
                        ToggleButton.Text = "Approve"
                        ToggleButton.BackColor = Color.Black
                    End If
                Else
                    MessageBox.Show("No approval status found for the event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching approval status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ToggleButton_Click(sender As Object, e As EventArgs) Handles ToggleButton.Click
        ' Toggle the approval status
        isApproved = Not isApproved

        ' Update button appearance based on the approval status
        If isApproved Then
            ToggleButton.Text = "Remove Approval"
            ToggleButton.BackColor = Color.Gray
        Else
            ToggleButton.Text = "Approve"
            ToggleButton.BackColor = Color.Black
        End If

        ' Update the database with the new approval status
        Try
            conn.Open()
            Dim query As String = "UPDATE festivals SET isApproved = @IsApproved WHERE id = @CurrEvent"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IsApproved", isApproved)
                cmd.Parameters.AddWithValue("@CurrEvent", Module1.CurrEventID)
                cmd.ExecuteNonQuery()
            End Using
            ' Show a success message
            MessageBox.Show("Approval status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
