Public Class cListHospitals
    Public Sub New(Optional ByVal name As String = "Default Name", Optional ByVal Loc As String = "Default Address", Optional ByVal Contact As String = "0 ratings")
        ' This call is required by the designer.
        InitializeComponent()
        ' Set the values to the controls
        CurvedLabel1.Text = name
        CurvedLabel2.Text = Loc
        CurvedLabel3.Text = Contact
    End Sub
    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        makeAppointment.Show()
        ParentForm.Close()
    End Sub
End Class
