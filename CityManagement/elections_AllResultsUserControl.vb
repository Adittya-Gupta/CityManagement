Public Class elections_AllResultsUserControl
    Private Votes As Integer

    Private Sub AllResultsUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        votes_secured.Text = Votes.ToString()
    End Sub

    Public Property voteC As Integer
        Get
            Return Votes
        End Get
        Set(value As Integer)
            Votes = value
        End Set
    End Property

End Class
