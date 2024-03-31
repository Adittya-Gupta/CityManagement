Public Class IncomingEmploymentReq
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub IncomingEmploymentReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listItem1 As New Incoming_Emp_Req(Me, "Shally")
        Panel1.Controls.Add(listItem1)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class