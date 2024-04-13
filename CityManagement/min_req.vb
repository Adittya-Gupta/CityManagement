Public Class min_req

    Private Sub lblDetails_MouseEnter(sender As Object, e As EventArgs) Handles lblDetails.MouseEnter
        ' Change the cursor to Hand when mouse enters lblDetails
        lblDetails.Cursor = Cursors.Hand
    End Sub

    Private Sub lblDetails_MouseLeave(sender As Object, e As EventArgs) Handles lblDetails.MouseLeave
        ' Revert back to Default cursor when mouse leaves lblDetails
        lblDetails.Cursor = Cursors.Default
    End Sub

    Private Sub lblAccept_MouseEnter(sender As Object, e As EventArgs) Handles lblAccept.MouseEnter
        ' Change the cursor to Hand when mouse enters lblAccept
        lblAccept.Cursor = Cursors.Hand
    End Sub

    Private Sub lblAccept_MouseLeave(sender As Object, e As EventArgs) Handles lblAccept.MouseLeave
        ' Revert back to Default cursor when mouse leaves lblAccept
        lblAccept.Cursor = Cursors.Default
    End Sub

    Private Sub lblReject_MouseEnter(sender As Object, e As EventArgs) Handles lblReject.MouseEnter
        ' Change the cursor to Hand when mouse enters lblReject
        lblReject.Cursor = Cursors.Hand
    End Sub

    Private Sub lblReject_MouseLeave(sender As Object, e As EventArgs) Handles lblReject.MouseLeave
        ' Revert back to Default cursor when mouse leaves lblReject
        lblReject.Cursor = Cursors.Default
    End Sub



End Class
