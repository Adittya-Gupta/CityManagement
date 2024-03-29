Public Class RegularServicesList
    Private EmploymentPortalForm As EmploymentPortal

    'Constructor
    Public Sub New(ParentForm As EmploymentPortal)
        InitializeComponent()
        'Me.EmployOrgListForm = ParentForm
        Me.EmploymentPortalForm = ParentForm ' Initialize EmploymentPortalForm
    End Sub

    Private Sub CurvedLabel_Click(sender As Object, e As EventArgs) Handles CurvedLabel1.Click, CurvedLabel2.Click, CurvedLabel3.Click, CurvedLabel4.Click
        EmploymentPortalForm.LoadApplicationForm()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        ' Navigate back to ListOfOrgForm when Back button is clicked
        EmploymentPortalForm.LoadListOfOrgForm()
    End Sub
End Class