Public Class HistoryFilter

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        ' Calculate the value to be displayed in Label1
        Dim value = TrackBar1.Value
        Dim labelValue = value

        ' Update the text of Label1
        Label2.Text = "Below " + labelValue.ToString + " km"
    End Sub
    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        ' Calculate the value to be displayed in Label1
        Dim value = TrackBar2.Value
        Dim labelValue As Integer
        If value < 5 Then
            'set the label value 2 to the power value
            labelValue = 2 ^ value
            Label4.Text = labelValue.ToString + " Days ago"
        ElseIf value < 8 Then
            'set the label value 2 to the power value
            labelValue = 2 ^ (value - 4)
            Label4.Text = labelValue.ToString + " Months ago"
        Else
            'set the label value 2 to the power value
            labelValue = 2 ^ (value - 7)
            Label4.Text = labelValue.ToString + " Years ago"
        End If
    End Sub

    Private Sub CheckBoxes_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        Dim checkBox = DirectCast(sender, CheckBox)
        Dim firstWord = checkBox.Text.Split(" "c)(0)
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

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged, CheckBox6.CheckedChanged, CheckBox7.CheckedChanged
        Dim checkBox As CheckBox = DirectCast(sender, CheckBox)
        If checkBox.Checked Then
            ' Set the background image and adjust the layout
            checkBox.Image = My.Resources._665939_48x48
            checkBox.TextImageRelation = TextImageRelation.ImageBeforeText
        Else
            ' Clear the background image
            checkBox.Image = Nothing
        End If
    End Sub

End Class