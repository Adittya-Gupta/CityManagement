<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Email_Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox12 = New PictureBox()
        Panel1 = New Panel()
        email_tb = New TextBox()
        Label4 = New Label()
        Panel2 = New Panel()
        pass1_tb = New TextBox()
        Label5 = New Label()
        Panel3 = New Panel()
        pass2_tb = New TextBox()
        Label6 = New Label()
        SignUp_btn = New Button()
        Panel4 = New Panel()
        Label7 = New Label()
        username_tb = New TextBox()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(129, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 34)
        Label3.TabIndex = 5
        Label3.Text = "Register"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(94, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 34)
        Label2.TabIndex = 4
        Label2.Text = ">"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 34)
        Label1.TabIndex = 3
        Label1.Text = "Email"
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Image = My.Resources.Resources.profile_pic
        PictureBox12.Location = New Point(483, 113)
        PictureBox12.Margin = New Padding(3, 2, 3, 2)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(147, 122)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 120
        PictureBox12.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(email_tb)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(308, 336)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(545, 44)
        Panel1.TabIndex = 121
        ' 
        ' email_tb
        ' 
        email_tb.BackColor = SystemColors.ActiveBorder
        email_tb.BorderStyle = BorderStyle.None
        email_tb.Location = New Point(196, 14)
        email_tb.Margin = New Padding(3, 2, 3, 2)
        email_tb.Name = "email_tb"
        email_tb.Size = New Size(346, 20)
        email_tb.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(47, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 20)
        Label4.TabIndex = 0
        Label4.Text = "New Email ID :"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.Controls.Add(pass1_tb)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(308, 405)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(545, 46)
        Panel2.TabIndex = 122
        ' 
        ' pass1_tb
        ' 
        pass1_tb.BackColor = SystemColors.ActiveBorder
        pass1_tb.BorderStyle = BorderStyle.None
        pass1_tb.Location = New Point(196, 14)
        pass1_tb.Margin = New Padding(3, 2, 3, 2)
        pass1_tb.Name = "pass1_tb"
        pass1_tb.Size = New Size(346, 20)
        pass1_tb.TabIndex = 124
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(31, 14)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 20)
        Label5.TabIndex = 1
        Label5.Text = "Enter PassWord :"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveBorder
        Panel3.Controls.Add(pass2_tb)
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(308, 473)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(545, 50)
        Panel3.TabIndex = 123
        ' 
        ' pass2_tb
        ' 
        pass2_tb.BackColor = SystemColors.ActiveBorder
        pass2_tb.BorderStyle = BorderStyle.None
        pass2_tb.Location = New Point(199, 15)
        pass2_tb.Margin = New Padding(3, 2, 3, 2)
        pass2_tb.Name = "pass2_tb"
        pass2_tb.Size = New Size(346, 20)
        pass2_tb.TabIndex = 124
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(5, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(169, 20)
        Label6.TabIndex = 2
        Label6.Text = "Re-Enter PassWord :"
        ' 
        ' SignUp_btn
        ' 
        SignUp_btn.BackColor = SystemColors.ActiveBorder
        SignUp_btn.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUp_btn.Location = New Point(483, 554)
        SignUp_btn.Margin = New Padding(3, 2, 3, 2)
        SignUp_btn.Name = "SignUp_btn"
        SignUp_btn.Size = New Size(167, 56)
        SignUp_btn.TabIndex = 124
        SignUp_btn.Text = "Sign Up"
        SignUp_btn.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveBorder
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(username_tb)
        Panel4.Location = New Point(308, 271)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(545, 44)
        Panel4.TabIndex = 125
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(47, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 20)
        Label7.TabIndex = 0
        Label7.Text = "Enter Username"
        ' 
        ' username_tb
        ' 
        username_tb.BackColor = SystemColors.ActiveBorder
        username_tb.BorderStyle = BorderStyle.None
        username_tb.Location = New Point(196, 12)
        username_tb.Margin = New Padding(3, 2, 3, 2)
        username_tb.Name = "username_tb"
        username_tb.Size = New Size(346, 20)
        username_tb.TabIndex = 1
        ' 
        ' Email_Register
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 760)
        ControlBox = False
        Controls.Add(Panel4)
        Controls.Add(SignUp_btn)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox12)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Email_Register"
        Text = "Email_Register"
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents email_tb As TextBox
    Friend WithEvents pass1_tb As TextBox
    Friend WithEvents pass2_tb As TextBox
    Friend WithEvents SignUp_btn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents username_tb As TextBox
    Friend WithEvents Label7 As Label
End Class
