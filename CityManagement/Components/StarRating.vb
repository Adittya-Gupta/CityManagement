Public Class Star_Rating
    Private Const TotalStars As Integer = 5
    Private Const StarSize As Integer = 50
    Private ReadOnly Stars As New List(Of PictureBox)
    Public _highlightedStars As Integer = 0

    Public Sub New()
        InitializeComponent()
        InitializeStars()
    End Sub

    Public Property HighlightedStars As Integer
        Get
            Return _highlightedStars
        End Get
        Set(value As Integer)
            If value >= 0 AndAlso value <= TotalStars Then
                _highlightedStars = value
                UpdateStars()
            End If
        End Set
    End Property

    Private Sub InitializeStars()
        For i As Integer = 1 To TotalStars
            Dim star As New PictureBox()
            With star
                .Image = My.Resources.Star_12__3_ ' Set default gray star image
                .Size = New Size(StarSize, StarSize)
                .SizeMode = PictureBoxSizeMode.Zoom
                .Location = New Point((StarSize + 5) * (i - 1), 0)
                .Tag = i ' Set tag to represent star number
                .Cursor = Cursors.Hand
                AddHandler .Click, AddressOf Star_Click
            End With
            Stars.Add(star)
            Me.Controls.Add(star)
        Next
        UpdateStars()
    End Sub

    Private Sub Star_Click(sender As Object, e As EventArgs)
        Dim clickedStar As PictureBox = DirectCast(sender, PictureBox)
        Dim clickedStarNumber As Integer = CInt(clickedStar.Tag)
        HighlightedStars = clickedStarNumber
    End Sub

    Private Sub UpdateStars()
        For Each star As PictureBox In Stars
            If CInt(star.Tag) <= HighlightedStars Then
                star.Image = My.Resources.Star_12__2_
            Else
                star.Image = My.Resources.Star_12__3_
            End If
        Next
    End Sub

End Class
