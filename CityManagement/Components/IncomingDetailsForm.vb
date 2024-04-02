Public Class IncomingDetailsForm

    Public Sub New(Optional ByVal contactDetails As String = "Contact Details",
               Optional ByVal bankAccountNumber As String = "Bank account number",
               Optional ByVal anyPreviousWork As String = "Any previous work")

        InitializeComponent()

        Me.FormBorderStyle = FormBorderStyle.None

        RichTextBox1.Text = contactDetails
        RichTextBox2.Text = bankAccountNumber
        RichTextBox3.Text = anyPreviousWork

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class