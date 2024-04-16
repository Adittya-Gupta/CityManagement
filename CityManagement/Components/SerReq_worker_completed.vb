Imports System.IO

Public Class SerReq_worker_completed


    ' Constructor with optional parameters
    Public Sub New(Optional ByVal name As String = "Name",
                   Optional ByVal serviceTime As String = "Will be updated",
                   Optional ByVal billAmount As String = "Will be updated",
                   Optional ByVal profpic As Byte() = Nothing)

        InitializeComponent()

        ' Set the values of the components based on the parameters
        Label1.Text = name
        TextBox1.Text = serviceTime
        TextBox2.Text = billAmount

        If profpic IsNot Nothing AndAlso profpic.Length > 0 Then
            ' Convert byte array to image
            Using ms As New MemoryStream(profpic)
                Dim img As Image = Image.FromStream(ms)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Image = img
            End Using
        Else
            ' If profpic is null or empty, set PictureBox image to a default image
        End If
    End Sub
End Class
