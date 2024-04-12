Public Class nomination_rules
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim electiondashboard As New election_dashboard()
        electiondashboard.Show()
        Me.Hide()
    End Sub
End Class