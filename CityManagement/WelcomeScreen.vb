
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text

Public Class WelcomeScreen
    ' Make this form full screen
    Private Sub WelcomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = System.Drawing.Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User_Login.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

    End Sub
End Class
