Public Class Workersfilter

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        ' Calculate the value to be displayed in Label1
        Dim value = TrackBar1.Value
        Dim labelValue = value / 2

        ' Update the text of Label2
        Label2.Text = labelValue.ToString + " and above"

    End Sub

    Private Sub CheckBoxes_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged, CheckBox2.CheckStateChanged
        Dim checkBox = DirectCast(sender, CheckBox)
        Dim firstWord = checkBox.Text.Split(" "c)(0)
        'If one CheckBoxStateis checked or Indeterminate  then the other should be unchecked
        If checkBox Is CheckBox1 AndAlso (checkBox.CheckState = CheckState.Checked Or checkBox.CheckState = CheckState.Indeterminate) Then
            CheckBox2.CheckState = CheckState.Unchecked
        ElseIf checkBox Is CheckBox2 AndAlso (checkBox.CheckState = CheckState.Checked Or checkBox.CheckState = CheckState.Indeterminate) Then
            CheckBox1.CheckState = CheckState.Unchecked
        End If
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

        'Globals.listofWorkersForm.UpdateUIWithFilteredWorkers()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Reset all the track values and filter button   
        TrackBar1.Value = 2
        Label2.Text = "1 and above"
        CheckBox1.CheckState = CheckState.Unchecked
        CheckBox2.CheckState = CheckState.Unchecked
        Globals.listofWorkersForm.UpdateUIWithFilteredWorkers()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Globals.listofWorkersForm.UpdateUIWithFilteredWorkers()
        Me.Hide()
    End Sub
End Class
