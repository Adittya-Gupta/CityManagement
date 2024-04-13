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
        EmploymentPortalForm.LoadRegularServicesForm()

    End Sub

    Private Sub CurvedLabel4_Click(sender As Object, e As EventArgs) Handles CurvedLabel4.Click
        EmploymentPortalForm.LoadApplicationForm("Transport")

    End Sub

    Private Sub CurvedLabel2_Click(sender As Object, e As EventArgs) Handles CurvedLabel2.Click
        ' Load LoadApplicationForm when Regular Services button is clicked
        EmploymentPortalForm.LoadApplicationForm("Police")
    End Sub

    Private Sub CurvedLabel1_Click(sender As Object, e As EventArgs) Handles CurvedLabel1.Click
        EmploymentPortalForm.LoadDoctorEmploymentForm()
    End Sub

    Private Sub CurvedLabel3_Click(sender As Object, e As EventArgs) Handles CurvedLabel3.Click
        EmploymentPortalForm.LoadApplicationForm("Education")
    End Sub

End Class