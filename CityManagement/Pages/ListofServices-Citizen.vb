Public Class ListofServices_Citizen
    Private UrbanClapNavForm As UrbanClapNav
    Private Sub ListofServices_Citizen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New(ParentForm As UrbanClapNav)
        InitializeComponent()
        Me.UrbanClapNavForm = ParentForm
    End Sub

    Private Sub CurvedLabel_Click(sender As Object, e As EventArgs) Handles CurvedLabel1.Click, CurvedLabel2.Click, CurvedLabel3.Click, CurvedLabel4.Click
        ' Show list of Workers form inside Panel1
        UrbanClapNavForm.HomePage = UrbanClapNavForm.listofWorkersForm
        UrbanClapNavForm.ShowFormInPanel(UrbanClapNavForm.listofWorkersForm)
    End Sub
End Class
