Imports System.Drawing.Drawing2D
Imports System.Windows.Documents
Public Class ListItem
    Public Sub New(Optional ByVal name As String = "Default Name", Optional ByVal address As String = "Default Address", Optional ByVal numberOfRatings As String = "0 ratings", Optional ByVal phoneNumber As String = "+91 9049381111", Optional ByVal rating As Double = 3.0)
        ' This call is required by the designer.
        InitializeComponent()
        ' Set the values to the controls
        Label1.Text = name
        Label2.Text = address
        Label3.Text = numberOfRatings
        Label7.Text = phoneNumber

        ' Set the RatingValue property of the Rating UserControl
        Rating1.RatingValue = rating

        ' Make the PictureBox round
        MakePictureBoxRound(PictureBox1)
    End Sub

    Private Sub MakePictureBoxRound(pictureBox As PictureBox)
        ' Create a GraphicsPath to define a circle
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height)

        ' Set the PictureBox's region to the circle defined by the GraphicsPath
        pictureBox.Region = New Region(path)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Globals.chatsForm.Label2.Text = Label1.Text
        Globals.UrbanClapNavForm.ShowFormInPanel(Globals.chatsForm)
        Globals.UrbanClapNavForm.ShowCurvedLabels_chats()
    End Sub

End Class
