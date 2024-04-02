Public Class Health_HospitalListing
    Private EmploymentPortalForm As EmploymentPortal

    'Constructor
    Public Sub New(ParentForm As EmploymentPortal)
        InitializeComponent()
        Me.EmploymentPortalForm = ParentForm ' Initialize EmploymentPortalForm
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        EmploymentPortalForm.LoadRegularServicesForm()
    End Sub
End Class