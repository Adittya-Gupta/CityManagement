Public Class cspecialisation
    Public Sub New(Optional ByVal name As String = "Default Name", Optional ByVal Hos As String = "Default Address", Optional ByVal Gender As String = "0 ratings", Optional ByVal Exp As String = "+91 9049381111", Optional ByVal Loc As String = "Default Address", Optional ByVal Contact As String = "Default Address", Optional ByVal rating As Double = 3.0)
        'this call Is required by the designer.
        InitializeComponent()
        ' Set the values to the controls
        Label1.Text = name
        Label3.Text = Hos
        Label4.Text = Gender
        Label6.Text = Exp
        Label12.Text = rating
        Label10.Text = Loc
        Label8.Text = Contact
    End Sub
End Class
