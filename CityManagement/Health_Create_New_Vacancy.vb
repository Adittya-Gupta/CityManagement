Public Class Health_Create_New_Vacancy

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Health_View_Previous_Vacancies.Show()
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Health_Doctor_Employment_Requests.Show()
        Me.Close()
    End Sub
End Class