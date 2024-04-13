<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        email_tb = New TextBox()
        Label4 = New Label()
        PictureBox12 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        pass1_tb = New TextBox()
        Label5 = New Label()
        Login_btn = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(email_tb)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(284, 369)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(545, 44)
        Panel1.TabIndex = 129
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
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 0
        Label4.Text = "Email ID :"
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Image = My.Resources.Resources.profile_pic
        PictureBox12.Location = New Point(460, 146)
        PictureBox12.Margin = New Padding(3, 2, 3, 2)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(147, 122)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 128
        PictureBox12.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(129, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 34)
        Label3.TabIndex = 127
        Label3.Text = "Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(94, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 34)
        Label2.TabIndex = 126
        Label2.Text = ">"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 34)
        Label1.TabIndex = 125
        Label1.Text = "Email"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.Controls.Add(pass1_tb)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(284, 438)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(545, 46)
        Panel2.TabIndex = 130
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
        ' Login_btn
        ' 
        Login_btn.BackColor = SystemColors.ActiveBorder
        Login_btn.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login_btn.Location = New Point(460, 534)
        Login_btn.Margin = New Padding(3, 2, 3, 2)
        Login_btn.Name = "Login_btn"
        Login_btn.Size = New Size(167, 56)
        Login_btn.TabIndex = 132
        Login_btn.Text = "Login"
        Login_btn.UseVisualStyleBackColor = False
        ' 
        ' Email_Login
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 760)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(PictureBox12)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Login_btn)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Email_Login"
        Text = "Email_Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents email_tb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pass1_tb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Login_btn As Button
End Class
