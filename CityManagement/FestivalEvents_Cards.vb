Public Class FestivalEvents_Cards
    ' This is the class for the cards that will be displayed on the FestivalEvents_MainMenu form

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FestivalEvents_Cards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.CurrEvent = Label2.Text
    End Sub
End Class
