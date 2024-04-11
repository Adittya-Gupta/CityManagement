Public Class MainPanel

    'Make this form full screen


    Public Shared Sub ChildForm(ByVal childform As Form)
        mypanel.Panel1.Controls.Clear()
        childform.TopLevel = False
        mypanel.Panel1.Controls.Add(childform)
        childform.Show()
    End Sub
    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(100, 0)
        mypanel.Panel1 = Panel1
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ChildForm(Banking_Main)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class