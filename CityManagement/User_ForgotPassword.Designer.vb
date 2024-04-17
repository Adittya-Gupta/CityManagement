<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        Panel1 = New Panel()
        ResendLabel = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Panel2 = New Panel()
        Button3 = New Button()
        Label11 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Email_tb = New TextBox()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ResendLabel)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Email_tb)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(938, 1100)
        Panel1.TabIndex = 7
        ' 
        ' ResendLabel
        ' 
        ResendLabel.Anchor = AnchorStyles.None
        ResendLabel.AutoSize = True
        ResendLabel.Cursor = Cursors.Hand
        ResendLabel.Location = New Point(553, 469)
        ResendLabel.Name = "ResendLabel"
        ResendLabel.Size = New Size(196, 20)
        ResendLabel.TabIndex = 54
        ResendLabel.Text = "Having Issues? Resend Code"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(309, 884)
        Label9.Name = "Label9"
        Label9.Size = New Size(350, 31)
        Label9.TabIndex = 53
        Label9.Text = "We just emailed you an OTP to reset the password."
        Label9.TextAlign = ContentAlignment.MiddleCenter
        Label9.Visible = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(335, 846)
        Label8.Name = "Label8"
        Label8.Size = New Size(282, 39)
        Label8.TabIndex = 52
        Label8.Text = "Check in your mail ! "
        Label8.TextAlign = ContentAlignment.MiddleCenter
        Label8.Visible = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(335, 315)
        Label7.Name = "Label7"
        Label7.Size = New Size(282, 39)
        Label7.TabIndex = 51
        Label7.Text = "Forgot Password ?"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonShadow
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Label11)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(938, 67)
        Panel2.TabIndex = 50
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.BackColor = Color.Black
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(746, 14)
        Button3.Name = "Button3"
        Button3.Size = New Size(151, 41)
        Button3.TabIndex = 42
        Button3.Text = " Back To Login"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(326, 14)
        Label11.Name = "Label11"
        Label11.Size = New Size(291, 39)
        Label11.TabIndex = 40
        Label11.Text = "Forgot Password"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(287, 91)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(389, 212)
        PictureBox3.TabIndex = 48
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(287, 640)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(389, 194)
        PictureBox1.TabIndex = 46
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(330, 557)
        Label5.Name = "Label5"
        Label5.Size = New Size(256, 23)
        Label5.TabIndex = 44
        Label5.Text = "Time left before code expires :"
        Label5.Visible = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(309, 358)
        Label4.Name = "Label4"
        Label4.Size = New Size(350, 48)
        Label4.TabIndex = 43
        Label4.Text = "Enter your e-mail address and we will send " & vbCrLf & "you an OTP to reset your password"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Abhaya Libre Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(326, 366)
        Label1.Name = "Label1"
        Label1.Size = New Size(309, 29)
        Label1.TabIndex = 39
        Label1.Text = "Forgot Your Password ?"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(300, 500)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 22)
        Label2.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(330, 590)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 25)
        Label6.TabIndex = 12
        Label6.Text = "Time Left : "
        Label6.Visible = False
        ' 
        ' Email_tb
        ' 
        Email_tb.Anchor = AnchorStyles.None
        Email_tb.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Email_tb.Location = New Point(326, 425)
        Email_tb.Margin = New Padding(3, 4, 3, 4)
        Email_tb.Name = "Email_tb"
        Email_tb.PlaceholderText = "Email Address"
        Email_tb.Size = New Size(309, 26)
        Email_tb.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(326, 936)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "OTP"
        TextBox1.Size = New Size(309, 26)
        TextBox1.TabIndex = 9
        TextBox1.Visible = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.BackColor = Color.Black
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(398, 970)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 40)
        Button2.TabIndex = 8
        Button2.Text = "VALIDATE"
        Button2.UseVisualStyleBackColor = False
        Button2.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackColor = Color.Black
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(395, 459)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 40)
        Button1.TabIndex = 7
        Button1.Text = "SEND CODE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ForgotPassword
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        AutoScrollMinSize = New Size(0, 1100)
        BackColor = Color.LightGray
        ClientSize = New Size(959, 700)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ForgotPassword"
        Text = "Forgot Password"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Email_tb As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ResendLabel As Label
End Class
