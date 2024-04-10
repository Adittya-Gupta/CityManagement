Public Class Health_View_Previous_Vacancies
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Health_Create_New_Vacancy.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Health_Doctor_Employment_Requests.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Vacancy Deleted")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Vacancy Deleted")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Vacancy Deleted")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Health_Record_Tracker.Show()
        Me.Close()
    End Sub
End Class