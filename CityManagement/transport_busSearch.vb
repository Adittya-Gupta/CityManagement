Public Class transport_busSearch
    Private Sub transport_busSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Retrieve starting point, ending point, and date values
        Dim startPoint As String = ComboBox1.SelectedItem.ToString()
        Dim endPoint As String = ComboBox2.SelectedItem.ToString()
        Dim selectedDate As String = DateTimePicker1.Value.ToShortDateString()

        ' Create an instance of transport_busResults page
        Dim busResultsForm As New transport_busResuts()

        ' Pass values to busResultsForm
        busResultsForm.StartPoint = startPoint
        busResultsForm.EndPoint = endPoint
        busResultsForm.SelectedDate = selectedDate

        ' Navigate to busResultsForm
        busResultsForm.Show()
        Me.Hide() ' Optional: Hide current form if needed
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class