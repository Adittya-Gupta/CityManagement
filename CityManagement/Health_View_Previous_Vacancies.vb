Public Class Health_View_Previous_Vacancies
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Health_Create_New_Vacancy.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Health_Doctor_Employment_Requests.Show()
        Me.Close()
    End Sub

End Class