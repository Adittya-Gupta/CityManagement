Public Class EmployOrgList
    'New instance of EmploymentPortal
    Private EmploymentPortalForm As EmploymentPortal

    'Constructor
    Public Sub New(ParentForm As EmploymentPortal)
        InitializeComponent()
        Me.EmploymentPortalForm = ParentForm
    End Sub

    'Load the form
    Private Sub EmployOrgList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CurvedLabel10_Click(sender As Object, e As EventArgs) Handles CurvedLabel10.Click
        ' Load RegularServicesForm when Regular Services button is clicked
        EmploymentPortalForm.LoadRegularServicesForm()
    End Sub

End Class