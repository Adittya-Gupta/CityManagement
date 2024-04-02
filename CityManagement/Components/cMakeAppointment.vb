Public Class cMakeAppointment
    Public Sub New(Optional ByVal name As String = "Default Name", Optional ByVal Exp As String = "Default Address", Optional ByVal Gender As String = "0 ratings", Optional ByVal Time As String = "+91 9049381111", Optional ByVal rating As Double = 3.0)
        'this call Is required by the designer.
        InitializeComponent()
        ' Set the values to the controls
        CurvedLabel5.Text = name
        CurvedLabel3.Text = Exp
        CurvedLabel1.Text = Gender
        CurvedLabel4.Text = Time
        CurvedLabel2.Text = rating
    End Sub
End Class
