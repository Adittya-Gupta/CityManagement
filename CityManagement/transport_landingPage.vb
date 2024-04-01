Public Class transport_landingPage
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Hide the current form

        ' Create an instance of Form2
        Dim form2 As New transport_busSearch

        ' Show Form2
        form2.Show
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Hide the current form

        ' Create an instance of Form2
        Dim form2 As New transport_govOfficial()

        ' Show Form2
        form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form2 As New transport_citymap()

        ' Show Form2
        Me.Hide()

        form2.ShowDialog()
        Me.Show()
    End Sub
End Class