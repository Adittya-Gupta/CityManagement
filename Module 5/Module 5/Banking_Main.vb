Public Class Banking_Main

    'Make this form full screen
    Public bank_account_no As Integer = 1
    Public bank_username As String = "admin"
    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub


    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        Panel2.BackColor = Color.FromArgb(1, 12, 40)
        Panel3.BackColor = Color.FromArgb(1, 0, 70)
        Button10.BackColor = Color.FromArgb(1, 0, 70)
        Button11.BackColor = Color.FromArgb(1, 0, 70)
        Button12.BackColor = Color.FromArgb(1, 0, 70)
        Button13.BackColor = Color.FromArgb(1, 0, 70)
        Button14.BackColor = Color.FromArgb(1, 0, 70)
        Button15.BackColor = Color.FromArgb(1, 0, 70)
        Button16.BackColor = Color.FromArgb(1, 0, 70)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Banking_Homepage" Then
                Return
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Login" Then
                Return
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Registration" Then
                Return
            End If
        Next
        Banking_ContactUs.bank_username = bank_username
        ChildForm(Panel1, Banking_ContactUs)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ' Iterate through each control within Panel1
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Banking_Homepage" Then
                Return
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Login" Then
                Return
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Registration" Then
                Return
            End If
        Next

        Banking_Passbook.bank_username = bank_username
        ChildForm(Panel1, Banking_Passbook)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Banking_Homepage" Then
                Return
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Login" Then
                Return
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Registration" Then
                Return
            End If
        Next
        Banking_Card_Management.bank_username = bank_username
        'ChildForm(Panel1, Banking_Card_Management)
        'ChildForm(Panel1, Banking_Debit_Card_Page)
        'ChildForm(Panel1, Banking_Credit_Card_Page)
        ChildForm(Panel1, Banking_Apply_Credit_Card)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Banking_Homepage" Then
                Return
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Login" Then
                Return
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Registration" Then
                Return
            End If
        Next
        Banking_LoanHomepage.bank_username = bank_username
        ChildForm(Panel1, Banking_LoanHomepage)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Banking_Homepage.bank_username = bank_username
        ChildForm(Panel1, Banking_Homepage)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ' Iterate through each control within Panel1
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Banking_Homepage" Then
                Return
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Login" Then
                Return
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Registration" Then
                Return
            End If
        Next
        Login.bank_username = bank_username
        ChildForm(Panel1, Login)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class