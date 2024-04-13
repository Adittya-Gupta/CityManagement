Public Class elections_voting_rules
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim form As New election_dashboard()
        mypanel.Panel1.Controls.Clear()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles back.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        back.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles back.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        back.Cursor = Cursors.Default
    End Sub
End Class