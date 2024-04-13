Public Class transport_addbus
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label10.Text = (Integer.Parse(Label10.Text) + 1).ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value As Integer = Integer.Parse(Label10.Text)
        If value > 0 Then
            Label10.Text = (value - 1).ToString()
        End If
    End Sub
End Class