Public Class Incoming_Emp_Req
    Private _parentForm As Form
    Public Sub New(ParentForm As Form, Optional ByVal name As String = "Name")

        InitializeComponent()

        _parentForm = ParentForm

        ' Set the values of the components based on the parameters
        Label4.Text = name
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' api call
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' api call

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim childUserControl As New Incoming_details("1231231231", "0987654321", "CEO at google")
        _parentForm.Controls.Add(childUserControl)
        childUserControl.Show()
        'Me.Hide()
        'MsgBox("hello")
    End Sub

    Private Sub Incoming_Emp_Req_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
