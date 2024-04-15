Public Class complaints
    Private Sub complaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button5.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button5.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button6.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button6.FlatAppearance.MouseDownBackColor = Color.Transparent
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Dim complaints_History As New complaints_History()
        mypanel.Panel1.Controls.Clear()
        Dim form As New complaints_History()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '  Dim complaints_Hospital As New complaints_Hospital()
        mypanel.Panel1.Controls.Clear()
        Dim form As New complaints_Hospital()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Dim law As New complaints_law()
        mypanel.Panel1.Controls.Clear()
        Dim form As New complaints_law()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Dim failed_transaction As New complaints_failed_transaction()
        mypanel.Panel1.Controls.Clear()
        Dim form As New complaints_failed_transaction()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        '  Dim transport As New complaints_Transport()
        mypanel.Panel1.Controls.Clear()
        Dim form As New complaints_transport_query()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim education As New complaints_Education()
        mypanel.Panel1.Controls.Clear()
        Dim form As New complaints_Education()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

End Class