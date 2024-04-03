Public Class FestivalEvents_NewEvent
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        mypanel.Panel1.Controls.Clear()
        Dim form As New FestivalEvents_MainMenu
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class