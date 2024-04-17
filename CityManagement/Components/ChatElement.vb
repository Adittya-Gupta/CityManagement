Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Media.Effects
Public Class ChatElement
    Private Sub Label1_Paint(sender As Object, e As PaintEventArgs) Handles CurvedLabel1.Paint
        ' Get the graphics object
        Dim g As Graphics = e.Graphics

        ' Define the rectangle to be painted (use Label's ClientRectangle to cover the whole label)
        Dim rect As Rectangle = CurvedLabel1.ClientRectangle
        ' Define the diagonal length of the label
        Dim diagonalLength As Single = CSng(Math.Sqrt(rect.Width ^ 2 + rect.Height ^ 2))

        ' Define the center point for the radial gradient
        Dim center As New Point(0, 0) ' Center at the top-left corner of the label
        ' Define the gradient colors
        Dim color1 As Color = Color.FromArgb(128, 196, 0, 255)  ' Start color
        Dim color2 As Color = Color.FromArgb(128, 255, 0, 244) ' End color

        ' Create a  gradient brush
        Dim brush As New LinearGradientBrush(rect, color1, color2, LinearGradientMode.Horizontal)

        ' Create a blend for the gradient brush to achieve the radial effect
        Dim blend As New Blend()
        blend.Positions = New Single() {0.0F, 1.0F}
        blend.Factors = New Single() {0.0F, 1.0F}
        brush.Blend = blend

        ' Fill the rectangle with the gradient brush
        g.FillEllipse(brush, center.X - diagonalLength / 2, center.Y - diagonalLength / 2, 2 * diagonalLength, 2 * diagonalLength)
    End Sub
    Public Sub New(ByVal labelText As String, Optional ByVal specificDateTime As DateTime = Nothing, Optional ByVal imageBytes As Byte() = Nothing)
        InitializeComponent()
        PictureBox1.Image = Globals.chatsForm.PictureBox1.Image
        If (PictureBox1.Image IsNot Nothing) Then
            'Debug.WriteLine("An error occurred:  Listitem22222222222222211")
        End If
        ' Set the text for the CurvedLabel
        CurvedLabel1.Text = labelText

        ' Set the text for the DateTimeLabel
        If specificDateTime = Nothing Then
            specificDateTime = DateTime.Now ' Set default value to current date time
        End If
        ' Set the image for PictureBox1 if imageBytes are provided
        If imageBytes IsNot Nothing Then
            Try
                Using stream As New MemoryStream(imageBytes)
                    PictureBox1.Image = Image.FromStream(stream)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If

        Label1.Text = specificDateTime.ToString("dd MMMM") & vbCrLf & specificDateTime.ToString("HH:mm")
        ' Adjust the size of the label based on the text
        AdjustLabelSize(CurvedLabel1, labelText)
    End Sub

    Private Sub MakePictureBoxRound(ByVal pictureBox As PictureBox)
        ' Create a GraphicsPath to define a circle
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height)

        ' Set the PictureBox's region to the circle defined by the GraphicsPath
        pictureBox.Region = New Region(path)
    End Sub

    Private Sub AdjustLabelSize(ByVal label As Label, ByVal text As String)
        ' Calculate the width of the label based on the text
        label.MaximumSize = New Size(600, 2000)
        Dim maxWidth As Integer = 600 ' Maximum width threshold
        Dim textSize As SizeF = TextRenderer.MeasureText(text, label.Font)
        Dim width As Integer = CInt(textSize.Width)

        ' Set the label's width
        label.Width = width + 70 ' Add padding to the labellabel.Width = width + Label1.Width + 70 ' Add padding to the label

        Me.Width = label.Width + Label1.Width + 10
        ' Adjust the label's height if the text exceeds the maximum width
        If textSize.Width > maxWidth Then
            ' Calculate the required height based on the wrapped text
            Dim height As Integer = CInt(Math.Ceiling(textSize.Width / maxWidth) * textSize.Height)
            label.Height = height ' Add padding to the label
        End If
        Me.Height = label.Height
    End Sub

    Private Sub ChatElement_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        MakePictureBoxRound(PictureBox1)
    End Sub

End Class
