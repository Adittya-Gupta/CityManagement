Public Class cListHospitals
    Dim hos_id As String
    Public Sub New(Optional ByVal name As String = "Default Name", Optional ByVal Loc As String = "Default Address", Optional ByVal Contact As String = "0 ratings", Optional id As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Set the values to the controls
        CurvedLabel1.Text = name
        CurvedLabel2.Text = Loc
        CurvedLabel3.Text = Contact
        hos_id = id
    End Sub
    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        Dim makeAppointment As New makeAppointment()
        makeAppointment.makeappointment(hos_id)

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(makeAppointment)
        End If
    End Sub
End Class

