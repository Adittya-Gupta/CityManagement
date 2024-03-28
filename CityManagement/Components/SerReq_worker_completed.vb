Public Class SerReq_worker_completed
    ' Constructor with optional parameters
    Public Sub New(Optional ByVal name As String = "Name",
                   Optional ByVal serviceTime As String = "Will be updated",
                   Optional ByVal billAmount As String = "Will be updated")

        InitializeComponent()

        ' Set the values of the components based on the parameters
        Label1.Text = name
        Label4.Text = serviceTime
        Label5.Text = billAmount
    End Sub
End Class
