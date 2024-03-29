Public Class Rate
    ' Public property to store the number of stars selected by the user
    Public Property SelectedStars As Integer

    Private Sub CurvedLabel1_Click(sender As Object, e As EventArgs) Handles CurvedLabel1.Click
        ' Set the SelectedStars property to the number of highlighted stars
        If Star_Rating1._highlightedStars = 0 Then
            MessageBox.Show("Please select a rating between 1 and 5 stars.")
        Else
            SelectedStars = Star_Rating1._highlightedStars
            ' Close the form
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
