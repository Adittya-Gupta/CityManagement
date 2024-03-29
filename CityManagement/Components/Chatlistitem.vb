Imports System.Drawing.Drawing2D

Public Class Chatlistitem
    'Constructor
    Public Sub New(Optional ByVal name As String = "Default Name", Optional ByVal lastmessage As String = "Default Address")
        ' This call is required by the designer.
        InitializeComponent()
        ' Set the values to the controls
        Label1.Text = name
        Label2.Text = lastmessage

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

    Private Sub CurvedLabel1_Click(sender As Object, e As EventArgs) Handles CurvedLabel1.Click, Label1.Click, Label2.Click
        Globals.Chatspage = Globals.chatsForm
        Globals.UrbanClapNavForm.ShowFormInPanel(Globals.Chatspage)
    End Sub
End Class
