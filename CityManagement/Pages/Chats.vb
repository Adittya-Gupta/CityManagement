Public Class Chats
    Private UrbanClapNavForm As UrbanClapNav
    Public Sub New(ParentForm As UrbanClapNav)
        InitializeComponent()
        Me.UrbanClapNavForm = ParentForm
    End Sub

    Private Sub CurvedLabel9_Click(sender As Object, e As EventArgs) Handles CurvedLabel9.Click
        UrbanClapNavForm.ShowFormInPanel(UrbanClapNavForm.HomePage)
        UrbanClapNavForm.HideCurvedLabels()
    End Sub
End Class