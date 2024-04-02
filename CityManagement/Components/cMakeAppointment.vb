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

        ' Add a Click event handler to the form
        AddHandler Me.Click, AddressOf Form_Click
    End Sub

    Private Sub Form_Click(sender As Object, e As EventArgs)
        ' Set the clicked form as the active form
        Me.BackColor = Color.LightGray
    End Sub


End Class
