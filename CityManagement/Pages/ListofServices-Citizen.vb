Public Class ListofServices_Citizen
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub CurvedLabel_Click(sender As Object, e As EventArgs) Handles CurvedLabel1.Click, CurvedLabel2.Click, CurvedLabel3.Click, CurvedLabel4.Click
        ' Show list of Workers form inside Panel1
        ' Cast sender to CurvedLabel to access its properties
        Dim clickedLabel As CurvedLabel = DirectCast(sender, CurvedLabel)

        ' Set the jobselected global variable to the text of the clicked label
        Globals.Job_Selected = clickedLabel.Text
        Globals.HomePage = Globals.listofWorkersForm
        Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.HomePage)
    End Sub

End Class