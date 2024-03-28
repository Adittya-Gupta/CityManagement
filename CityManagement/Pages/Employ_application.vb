Public Class EmployApplication
    Private EmploymentPortalForm As EmploymentPortal

    'Constructor
    Public Sub New(ParentForm As EmploymentPortal)
        InitializeComponent()
        Me.EmploymentPortalForm = ParentForm ' Initialize EmploymentPortalForm
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        EmploymentPortalForm.LoadRegularServicesForm()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Extract data from RichTextBoxes
        Dim name As String = RichTextBox4.Text
        Dim contactDetails As String = RichTextBox2.Text
        Dim bankAccountDetails As String = RichTextBox3.Text
        Dim prevWork As String = RichTextBox1.Text

        ' Extract profile picture (if an image is loaded)
        Dim profilePicture As Image = PictureBox1.Image
        ' You can then process or save this image as needed

        ' Process or display the extracted data as required
        'MessageBox.Show($"Name: {name}, Contact Details: {contactDetails}, Bank Account Details: {bankAccountDetails}")

        ' Example of saving the image to a file
        'If profilePicture IsNot Nothing Then
        'profilePicture.Save("profile_picture.jpg")
        'End If
    End Sub
End Class