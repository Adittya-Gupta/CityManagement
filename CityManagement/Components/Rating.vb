Public Class Rating
    ' Define a property to set and get the rating value
    Private _ratingValue As Double = 3.9 ' Default rating value
    Public Property RatingValue As Double
        Get
            Return _ratingValue
        End Get
        Set(value As Double)
            ' Ensure that the value is within the range of 1.0 to 5.0
            If value >= 1.0 AndAlso value <= 5.0 Then
                _ratingValue = value

                ' Update the gradient color based on the new rating value
                UpdateGradientColor()
            Else
                _ratingValue = 3.0
                'Throw New ArgumentOutOfRangeException("Rating value must be between 1.0 and 5.0.")
            End If

        End Set
    End Property

    ' Constructor
    Public Sub New()
        InitializeComponent()

        ' Call the method to set the gradient color
        UpdateGradientColor()
    End Sub

    ' Method to update the background color and text of Label5 based on the rating value
    Private Sub UpdateGradientColor()
        ' Calculate the gradient color based on the rating value
        Dim gradientColor As Color = CalculateGradientColor(_ratingValue)
        ' Set the background color of Label5
        Label5.BackColor = gradientColor

        ' Set the text of Label5 to the rating value
        Label5.Text = _ratingValue.ToString()
    End Sub

    Private Function CalculateGradientColor(ratingValue As Double) As Color
        ' Convert the rating value to a value between 0 and 1
        Dim normalizedRating As Double = (ratingValue - 1.0) / (5.0 - 1.0)

        ' Calculate the gradient color based on the normalized rating
        Dim gradientColor As Color

        If normalizedRating >= 0.5 Then
            ' Green (0,255,21) to Yellow (227,229,0)
            Dim ratio As Double = (normalizedRating - 0.5) / (1.0 - 0.5)
            gradientColor = InterpolateColor(Color.FromArgb(227, 229, 0), Color.FromArgb(0, 255, 21), ratio)
        Else
            ' Yellow (227,229,0) to Red (255,0,0)
            Dim ratio As Double = normalizedRating / 0.5
            gradientColor = InterpolateColor(Color.FromArgb(255, 0, 0), Color.FromArgb(227, 229, 0), ratio)
        End If

        Return gradientColor
    End Function

    Private Function InterpolateColor(color1 As Color, color2 As Color, ratio As Double) As Color
        ' Interpolate between two colors based on the given ratio
        Dim red As Integer = CInt(color1.R * (1.0 - ratio) + color2.R * ratio)
        Dim green As Integer = CInt(color1.G * (1.0 - ratio) + color2.G * ratio)
        Dim blue As Integer = CInt(color1.B * (1.0 - ratio) + color2.B * ratio)
        Return Color.FromArgb(red, green, blue)
    End Function


End Class
