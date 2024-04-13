Imports System.Drawing.Drawing2D

Public Class Chatlistitem
    Public Worker_id As Integer
    'Constructor
    Public Sub New(Optional ByVal ID As Integer = 1, Optional ByVal name As String = "Default Name", Optional ByVal lastmessage As String = "Sure What time works for you?", Optional ByVal unreadcount As Integer = 0)
        ' This call is required by the designer.
        InitializeComponent()
        ' Set the values to the controls
        Worker_id = ID
        Label1.Text = name

        ' Check if lastmessage is longer than 30 characters
        If lastmessage.Length > 30 Then
            Label2.Text = lastmessage.Substring(0, 30) & "..."
        Else
            Label2.Text = lastmessage
        End If

        ' Check if unreadcount is 0
        If unreadcount = 0 Then
            Label3.Hide()
        Else
            Label3.Text = unreadcount.ToString()
            Label3.Show()
        End If

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

    Private Sub CurvedLabel1_Click(sender As Object, e As EventArgs) Handles CurvedLabel1.Click, Label1.Click, Label2.Click, PictureBox1.Click, Label3.Click
        Globals.ChatIdAsCitizen = Worker_id
        Globals.Chatspage = Globals.chatsForm
        Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.Chatspage)
        Globals.chatsForm.Label2.Text = Label1.Text
    End Sub

    Private Sub Chatlistitem_Load(sender As Object, e As EventArgs)

    End Sub
End Class