Public Class RegularServicesList
    Private EmploymentPortalForm As EmploymentPortal

    'Constructor
    Public Sub New(ParentForm As EmploymentPortal)
        InitializeComponent()
        Me.EmploymentPortalForm = ParentForm ' Initialize EmploymentPortalForm
    End Sub

    Private Sub CurvedLabel1_Click(sender As Object, e As EventArgs) Handles CurvedLabel1.Click
        EmploymentPortalForm.LoadApplicationForm("Electrician")
    End Sub

    Private Sub CurvedLabel2_Click(sender As Object, e As EventArgs) Handles CurvedLabel2.Click
        EmploymentPortalForm.LoadApplicationForm("Plumber")
    End Sub

    Private Sub CurvedLabel3_Click(sender As Object, e As EventArgs) Handles CurvedLabel3.Click
        EmploymentPortalForm.LoadApplicationForm("Merchant")
    End Sub

    Private Sub CurvedLabel4_Click(sender As Object, e As EventArgs) Handles CurvedLabel4.Click
        EmploymentPortalForm.LoadApplicationForm("Househelp")
    End Sub


    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        ' Navigate back to ListOfOrgForm when Back button is clicked
        EmploymentPortalForm.LoadListOfOrgForm
    End Sub

    Private Sub CurvedLabel5_Click(sender As Object, e As EventArgs) Handles CurvedLabel5.Click
        EmploymentPortalForm.LoadApplicationForm("Electrician")
    End Sub

    Private Sub CurvedLabel6_Click(sender As Object, e As EventArgs) Handles CurvedLabel6.Click
        EmploymentPortalForm.LoadApplicationForm("Plumber")
    End Sub

    Private Sub CurvedLabel7_Click(sender As Object, e As EventArgs) Handles CurvedLabel7.Click
        EmploymentPortalForm.LoadApplicationForm("Merchant")
    End Sub

    Private Sub CurvedLabel8_Click(sender As Object, e As EventArgs) Handles CurvedLabel8.Click
        EmploymentPortalForm.LoadApplicationForm("Househelp")
    End Sub
End Class