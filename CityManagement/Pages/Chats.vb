Imports System.Drawing.Drawing2D
Imports System.Windows.Media.Effects

Public Class Chats
    Public username As String
    Public MsgBox As MessageBox
    Public Sub New(Optional ByVal Username As String = "John Doe")
        InitializeComponent()
        Me.username = Username
    End Sub

    Private Sub CurvedLabel9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CurvedLabel9.Click
        Globals.Chatspage = Globals.listofChatsForm
        Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.Chatspage)
    End Sub
    Private Sub MakePictureBoxRound(ByVal pictureBox As PictureBox)
        ' Create a GraphicsPath to define a circle
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height)

        ' Set the PictureBox's region to the circle defined by the GraphicsPath
        pictureBox.Region = New Region(path)
    End Sub
    Private Sub Chats_Show(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.VisibleChanged
        Panel1.AutoScrollPosition = New Point(0, Panel1.VerticalScroll.Maximum)
    End Sub
    Private Sub Chats_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Label2.Text = username
        MakePictureBoxRound(PictureBox1)
        ' Create a new ChatElement with the message text
        Dim newChatElement As New ChatElement("Hi there")
        newChatElement.Top = 10 ' Set the initial position
        ' Add the new ChatElement to the panel
        Panel1.Controls.Add(newChatElement)

    End Sub

    Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.Click
        ' Get the text from RichTextBox1 and trim whitespace
        Dim message As String = RichTextBox1.Text.Trim()
        If message.Length > 0 And message <> "Type a message" Then
            ' Create a new ChatElement with the message text
            Dim newChatElement As New ChatElement(message)

            ' Find the last control in the panel
            Dim lastControl As Control = Panel1.Controls.Cast(Of Control)().LastOrDefault()

            ' Set the position of the new ChatElement below the last control
            If lastControl IsNot Nothing Then
                newChatElement.Top = lastControl.Bottom + 10 ' Add some spacing
            End If
            newChatElement.Left = Panel1.Width - newChatElement.Width - 25 ' Align to the right side

            ' Add the new ChatElement to the panel
            Panel1.Controls.Add(newChatElement)
            RichTextBox1.Clear()
        Else
            ' Start the timer
            Timer1.Start()
            ' Show an error message if the message is empty
            MessageBox.Show("Please enter a message.", "Empty Text", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub RichTextBox1_GotFocus(sender As Object, e As EventArgs) Handles RichTextBox1.GotFocus
        If RichTextBox1.Text = "Type a message" Then
            RichTextBox1.Text = ""
            RichTextBox1.ForeColor = Color.White ' Change text color to normal
        End If
    End Sub

    Private Sub RichTextBox1_LostFocus(sender As Object, e As EventArgs) Handles RichTextBox1.LostFocus
        If String.IsNullOrWhiteSpace(RichTextBox1.Text) Then
            RichTextBox1.Text = "Type a message"
            RichTextBox1.ForeColor = Color.Gray ' Change text color to placeholder color
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Close the form when the timer ticks
    End Sub


    Private Sub Label2_Paint(sender As Object, e As PaintEventArgs) Handles Label2.Paint
        Dim rect As Rectangle = Label2.ClientRectangle

        ' Define gradient colors
        Dim color1 As Color = Color.FromArgb(128, 68, 0, 255) ' RGBA(68,0,255,1)
        Dim color2 As Color = Color.FromArgb(128, 0, 36, 255) ' RGBA(1,220,255,1)

        ' Create linear gradient brush
        Dim brush As New LinearGradientBrush(rect, color1, color2, LinearGradientMode.Horizontal)

        ' Fill rectangle with gradient brush
        e.Graphics.FillRectangle(brush, rect)
    End Sub

End Class
