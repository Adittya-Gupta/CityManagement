Imports System.Drawing.Drawing2D

Public Class CurvedLabel
    Inherits Label

    Private _cornerRadius As Integer = 10

    Public Sub New()
        MyBase.New()
    End Sub

    Public Overrides Property AutoSize As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Set(value As Boolean)
            MyBase.AutoSize = value
            Me.Invalidate() ' Redraw the control when the AutoSize property changes
        End Set
    End Property


    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Me.Invalidate() ' Redraw the control when the corner radius changes
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim path As New GraphicsPath()
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias ' Set smoothing mode to AntiAlias for high-quality rendering

        ' Define the number of points along the curve
        Dim numPoints As Integer = 10 ' Increase the number of points for smoother corners

        ' Calculate the angle increment based on the number of points
        Dim angleIncrement As Single = 90 / numPoints

        ' Add points along the curve to create a smoother arc
        For i As Integer = 0 To numPoints - 1
            Dim angle As Single = 180 + i * angleIncrement
            Dim x As Single = rect.Left + _cornerRadius * Math.Cos(angle * Math.PI / 180)
            Dim y As Single = rect.Top + _cornerRadius * Math.Sin(angle * Math.PI / 180)
            path.AddLine(x, y, x, y)
        Next

        ' Create rounded rectangle path
        path.AddArc(rect.Left, rect.Top, _cornerRadius * 2, _cornerRadius * 2, 180, 90)
        path.AddArc(rect.Right - _cornerRadius * 2, rect.Top, _cornerRadius * 2, _cornerRadius * 2, 270, 90)
        path.AddArc(rect.Right - _cornerRadius * 2, rect.Bottom - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 90, 90)
        path.CloseFigure()

        Me.Region = New Region(path)

        MyBase.OnPaint(e)
    End Sub

End Class
