Imports MySql.Data.MySqlClient

Public Class Rate
    ' Public property to store the number of stars selected by the user
    Public Property SelectedStars As Integer
    Public Property FinalValue As Double
    ' Private field to store the WorkerID
    Private workerID As Integer

    ' Constructor to initialize the WorkerID
    Public Sub New(ByVal workerID As Integer)
        InitializeComponent()
        Me.workerID = workerID
    End Sub

    Private Sub CurvedLabel1_Click(sender As Object, e As EventArgs) Handles CurvedLabel1.Click
        ' Set the SelectedStars property to the number of highlighted stars
        If Star_Rating1._highlightedStars = 0 Then
            MessageBox.Show("Please select a rating between 1 and 5 stars.")
        Else
            SelectedStars = Star_Rating1._highlightedStars
            Dim updatedRating As Double = UpdateRatingInDatabase()
            Me.FinalValue = updatedRating

            ' Update the rating in the database

            ' Pass the updated rating to the parent form
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    ' Function to update the rating in the database
    ' Function to update the rating in the database and return the updated rating
    Private Function UpdateRatingInDatabase() As Double
        Dim updatedRating As Double = -1

        Try
            ' SQL query to update the rating and noOfRatings fields in the WorkerRating table
            Dim query As String = "UPDATE serviceWorkers " &
                                  "SET rating = ((rating * noOfRatings) + @SelectedStars) / (noOfRatings + 1), " &
                                  "    noOfRatings = noOfRatings + 1 " &
                                  "WHERE workerID = @WorkerID;" &
                                   "SELECT rating FROM serviceWorkers WHERE workerID = @WorkerID"

            ' Create MySqlConnection
            Using connection As New MySqlConnection(Globals.connectionstring)
                ' Open the connection
                connection.Open()

                ' Create MySqlCommand
                Using command As New MySqlCommand(query, connection)
                    'MessageBox.Show(SelectedStars)
                    ' Add parameters
                    command.Parameters.AddWithValue("@SelectedStars", SelectedStars)
                    command.Parameters.AddWithValue("@WorkerID", workerID)

                    ' Execute the command and get the updated rating
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot DBNull.Value Then
                        ' Convert the result to a double and assign it to updatedRating
                        updatedRating = Convert.ToDouble(result)
                    End If
                    'MessageBox.Show(updatedRating)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error occurred while updating rating: " & ex.Message)
        End Try

        ' Return the updated rating
        Return updatedRating
    End Function

End Class
