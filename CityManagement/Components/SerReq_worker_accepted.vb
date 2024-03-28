Public Class SerReq_worker_accepted
    ' Constructor with optional parameters
    Public Sub New(Optional ByVal name As String = "Name",
                   Optional ByVal serviceTime As String = "Will be updated",
                   Optional ByVal billAmount As String = "To be Decided")

        InitializeComponent()

        ' Set the values of the components based on the parameters
        Label1.Text = name
        TextBox1.Text = serviceTime
        TextBox2.Text = billAmount
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        TextBox1.Enabled = True
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        TextBox2.Enabled = True
    End Sub
End Class