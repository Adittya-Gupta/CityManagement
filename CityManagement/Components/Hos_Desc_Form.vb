

Public Class Hos_Desc_Form

    Public Sub New(Optional ByVal description As String = "Experience needed")

        InitializeComponent()

        Me.FormBorderStyle = FormBorderStyle.None

        RichTextBox3.Text = description

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class