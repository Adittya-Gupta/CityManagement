Public Class ListofServices_Citizen
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub CurvedLabel_Click(sender As Object, e As EventArgs) Handles CurvedLabel1.Click, CurvedLabel2.Click, CurvedLabel3.Click, CurvedLabel4.Click
        ' Show list of Workers form inside Panel1
        Globals.HomePage = Globals.listofWorkersForm
        Globals.UrbanClapNavForm.ShowFormInPanel(Globals.listofWorkersForm)
    End Sub
End Class
