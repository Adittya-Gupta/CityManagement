Public Class IncomingEmploymentReq

    Private EmploymentPortalForm As EmploymentPortal

    'Constructor
    'Public Sub New(ParentForm As EmploymentPortal)
    '    InitializeComponent()
    '    'Me.EmployOrgListForm = ParentForm
    '    Me.EmploymentPortalForm = ParentForm ' Initialize EmploymentPortalForm
    '    Me.FormBorderStyle = FormBorderStyle.None
    'End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub IncomingEmploymentReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        For i As Integer = 1 To 4
            Dim listItem As New Incoming_Emp_Req(Me, Date.Now, "Rashaad", i)
            Panel1.Controls.Add(listItem)
            listItem.Left = 80

            ' Set margin top for ListItem2 to ListItem4
            If i > 1 Then
                listItem.Top += (i - 1) * 130
            End If
        Next

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class