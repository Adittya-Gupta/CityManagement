Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class HistoryFilter

    Private Sub CheckBoxes_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        Dim checkBox = DirectCast(sender, CheckBox)
        Dim firstWord = checkBox.Text.Split(" "c)(0)
        Select Case checkBox.CheckState
            Case CheckState.Checked
                checkBox.ForeColor = Color.Red ' Set color for checked state
                checkBox.Text = firstWord + " (Newest First)" '  Set text to down arrow
            Case CheckState.Unchecked
                checkBox.ForeColor = Color.White ' Set color for unchecked state
                checkBox.Text = firstWord ' Remove text for unchecked state
            Case CheckState.Indeterminate
                checkBox.ForeColor = Color.Blue ' Set color for indeterminate state
                checkBox.Text = firstWord + " (Oldest First)" ' Set text to up arrow
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Reset all the track values and filter button   
        CheckBox1.CheckState = CheckState.Unchecked
        CheckBox2.CheckState = CheckState.Unchecked
        CheckBox3.CheckState = CheckState.Unchecked
        CheckBox4.CheckState = CheckState.Unchecked
        CheckBox5.CheckState = CheckState.Unchecked
        CheckBox6.CheckState = CheckState.Unchecked
        CheckBox7.CheckState = CheckState.Unchecked
        Globals.ServiceHistoryForm.UpdateUIWithFilteredBookings()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Globals.ServiceHistoryForm.UpdateUIWithFilteredBookings()
        Me.Hide()
    End Sub
End Class