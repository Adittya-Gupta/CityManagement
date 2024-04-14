Imports System.Windows.Forms.Design.WindowsFormsDesignerOptionService


Public Class Banking_Panel

    Sub childform(ByVal form As Form)
        form.TopLevel = False ' Set TopLevel property to False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        Panel3.Controls.Clear()
        Panel3.Controls.Add(form)
        form.Show()
    End Sub






    Private Sub Home_Button_Click(sender As Object, e As EventArgs) Handles Home_Button.Click
        childform(Banking_Admin_Home)
    End Sub

    Private Sub NewAcc_Button_Click(sender As Object, e As EventArgs) Handles NewAcc_Button.Click
        childform(Banking_Admin_NewAccRegistration)
    End Sub

    Private Sub LoanApproval_Button_Click(sender As Object, e As EventArgs) Handles LoanApproval_Button.Click
        childform(Banking_LoanManagement)
    End Sub

    Private Sub Queries_Button_Click(sender As Object, e As EventArgs) Handles Queries_Button.Click
        childform(Banking_QueryLog)
    End Sub

    Private Sub Banking_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
