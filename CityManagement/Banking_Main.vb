Public Class Banking_Main

    'Make this form full screen
    Public bank_account_no As String = "1"
    Public bank_username As String = "admin"
    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        childform.Size = parentpanel.Size
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub
    Public Shared Function NavBarCheck() As Boolean
        For Each ctrl As Control In Banking_Main.Panel1.Controls
            If TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Banking_Homepage" Then
                Return True
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Banking_Login" Then
                Return True
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Banking_Registration" Then
                Return True
            ElseIf TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).Name = "Banking_Panel" Then
                Return True
            End If
        Next
        Return False
    End Function


    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Size = New Size(1224, 800)
        'Me.Location = New Point(100, 0)
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
        Global_Attributes.banking_username = "samuel"
        ChildForm(Panel1, Banking_Homepage)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If NavBarCheck() Then
            Return
        End If
        Banking_ContactUs.bank_username = Global_Attributes.banking_username
        ChildForm(Panel1, Banking_ContactUs)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If NavBarCheck() Then
            Return
        End If
        Banking_Passbook.bank_username = Global_Attributes.banking_username
        ChildForm(Panel1, Banking_Passbook)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If NavBarCheck() Then
            Return
        End If
        Banking_Card_Management.bank_username = Global_Attributes.banking_username
        ChildForm(Panel1, Banking_Card_Management)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If NavBarCheck() Then
            Return
        End If
        Dim Banking_Money_Management_Homepage_form As New Banking_Money_Management_Homepage
        'Banking_Money_Management_Homepage.bank_username = Global_Attributes.banking_username
        ChildForm(Panel1, Banking_Money_Management_Homepage_form)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If NavBarCheck() Then
            Return
        End If
        'Banking_Money_Management_Homepage.bank_username = Global_Attributes.banking_username

        ChildForm(Panel1, Banking_LoanHomepage)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Global_Attributes.banking_username = "none"
        ChildForm(Panel1, Banking_Homepage)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If NavBarCheck() Then
            Return
        End If
        Banking_Profile.bank_username = Global_Attributes.banking_username
        ChildForm(Panel1, Banking_Profile)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class