Public Class Doctor_Emp_Req
    Private _parentForm As Form
    Private _i As Integer

    Public Sub New(ParentForm As Form, ByVal dateValue As Date, Optional ByVal name As String = "Name", Optional ByVal i As Integer = 1)
        InitializeComponent()

        _parentForm = ParentForm

        ' Set the values of the components based on the parameters
        Label1.Text = dateValue.ToString("dd MMM yyyy")
        Label4.Text = name
        _i = i
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' api call
        ' to be changed
        MsgBox("Employment request accepted")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' api call
        ' to be changed
        MsgBox("Employment request rejected")

    End Sub



    Private Sub Doctor_Emp_Req_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        MsgBox("Resume downloaded.")
    End Sub
End Class
