Public Class Incoming_Emp_Req
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
        MsgBox(_i.ToString() & " accepted")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' api call
        ' to be changed
        MsgBox(_i.ToString() & " rejected")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim childForm As New IncomingDetailsForm("1231231231", "0987654321", "CEO at google")
        '_parentForm.Controls.Add(childUserControl)
        childForm.Show()


        'Me.Hide()
        'MsgBox("hello")
    End Sub

    Private Sub Incoming_Emp_Req_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
