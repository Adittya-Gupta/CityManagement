Imports System.IO

Public Class Banking_LoanDetails
    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Private Sub Submit_btn_Click(sender As Object, e As EventArgs) Handles Submit_btn.Click
        'do form validation
        Name_tb.Clear()
        ACno_tb.Clear()
        Purpose_tb.Clear()
        CIBILscore_tb.Clear()
        Email_tb.Clear()
        Aadhar_tb.Clear()
        Principal_tb.Clear()
        InterestRate_tb.Clear()
        Duration_tb.Clear()

        If CheckBox1.Checked = True Then
            MessageBox.Show("Submit Success!")
        Else
            MessageBox.Show("You must agree to the terms and conditions.")
        End If

    End Sub
End Class