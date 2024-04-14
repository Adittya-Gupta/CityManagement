
Public Class Hos_Vac_Description

    Public Sub New(Optional ByVal description As String = "Need to be experienced.")
        InitializeComponent()



        ' Set the values of the components based on the parameters
        RichTextBox3.Text = description
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

