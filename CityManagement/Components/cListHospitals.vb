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
        Dim makeAppointment As New makeAppointment()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim Temp2 As Temp2 = CType(Application.OpenForms("Temp2"), Temp2)

        ' Check if the main form instance is not null
        If Temp2 IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            Temp2.ShowChildFormInPanel(makeAppointment)
        End If
    End Sub
End Class

