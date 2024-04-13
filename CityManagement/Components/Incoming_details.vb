Public Class Incoming_details
    Public Sub New(Optional ByVal contactDetails As String = "Contact Details",
               Optional ByVal bankAccountNumber As String = "Will be updated",
               Optional ByVal anyPreviousWork As String = "To be Decided")

        InitializeComponent()


        RichTextBox1.Text = contactDetails
        RichTextBox2.Text = bankAccountNumber
        RichTextBox3.Text = anyPreviousWork


        ' Set the values of the components based on the parameters

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get the parent control of the user control
        Dim parentControl As Control = Me.Parent

        ' Check if the parent control is not null
        If parentControl IsNot Nothing Then
            ' Remove the user control from its parent control
            parentControl.Controls.Remove(Me)
        End If
    End Sub
End Class
