Public Class Workersfilter

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        ' Calculate the value to be displayed in Label1
        Dim value = TrackBar1.Value
        Dim labelValue = value / 2

        ' Update the text of Label1
        Label2.Text = labelValue.ToString + " and above"
    End Sub
    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        ' Calculate the value to be displayed in Label1
        Dim value = TrackBar2.Value
        Dim labelValue = value

        ' Update the text of Label1
        Label3.Text = "Below " + labelValue.ToString + "km"
    End Sub

    Private Sub CheckBoxes_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged, CheckBox2.CheckStateChanged
        Dim checkBox = DirectCast(sender, CheckBox)
        Dim firstWord As String = checkBox.Text.Split(" "c)(0)
        Select Case checkBox.CheckState
            Case CheckState.Checked
                checkBox.ForeColor = Color.Red ' Set color for checked state
                checkBox.Text = firstWord + " ▼" ' Set text to down arrow
            Case CheckState.Unchecked
                checkBox.ForeColor = Color.White ' Set color for unchecked state
                checkBox.Text = firstWord ' Remove text for unchecked state
            Case CheckState.Indeterminate
                checkBox.ForeColor = Color.Blue ' Set color for indeterminate state
                checkBox.Text = firstWord + " ▲" ' Set text to up arrow
        End Select
    End Sub

End Class