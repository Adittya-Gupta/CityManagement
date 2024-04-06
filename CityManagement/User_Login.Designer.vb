<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Login
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Login))
        PasswordLabel = New Label()
        EmailLabel = New Label()
        EmailTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        TogglePasswordButton = New PictureBox()
        LoginButton = New Button()
        Label2 = New Label()
        SignUpLabel = New Label()
        LoginPic = New PictureBox()
        Label1 = New Label()
        CType(TogglePasswordButton, ComponentModel.ISupportInitialize).BeginInit()
        CType(LoginPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New Font("Exo 2", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordLabel.ForeColor = Color.White
        PasswordLabel.Location = New Point(756, 389)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(99, 24)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Password"
        ' 
        ' EmailLabel
        ' 
        EmailLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        EmailLabel.AutoSize = True
        EmailLabel.Font = New Font("Exo 2", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmailLabel.ForeColor = Color.White
        EmailLabel.Location = New Point(756, 304)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(61, 24)
        EmailLabel.TabIndex = 3
        EmailLabel.Text = "Email"
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        EmailTextBox.BackColor = Color.LightGray
        EmailTextBox.Font = New Font("Exo 2", 15F)
        EmailTextBox.Location = New Point(756, 334)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(350, 37)
        EmailTextBox.TabIndex = 2
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        PasswordTextBox.BackColor = Color.LightGray
        PasswordTextBox.Font = New Font("Exo 2", 15F)
        PasswordTextBox.Location = New Point(756, 417)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(350, 37)
        PasswordTextBox.TabIndex = 3
        ' 
        ' Timer1
        ' 
        ' 
        ' Timer2
        ' 
        ' 
        ' TogglePasswordButton
        ' 
        TogglePasswordButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TogglePasswordButton.BackColor = Color.LightGray
        TogglePasswordButton.BackgroundImage = CType(resources.GetObject("TogglePasswordButton.BackgroundImage"), Image)
        TogglePasswordButton.BackgroundImageLayout = ImageLayout.Stretch
        TogglePasswordButton.Cursor = Cursors.Hand
        TogglePasswordButton.Location = New Point(1072, 418)
        TogglePasswordButton.Name = "TogglePasswordButton"
        TogglePasswordButton.Size = New Size(34, 30)
        TogglePasswordButton.TabIndex = 5
        TogglePasswordButton.TabStop = False
        ' 
        ' LoginButton
        ' 
        LoginButton.Anchor = AnchorStyles.Right
        LoginButton.BackColor = SystemColors.ControlDarkDark
        LoginButton.Cursor = Cursors.Hand
        LoginButton.FlatAppearance.BorderSize = 0
        LoginButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
        LoginButton.FlatStyle = FlatStyle.Flat
        LoginButton.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginButton.Location = New Point(756, 497)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(350, 50)
        LoginButton.TabIndex = 1
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Microsoft Sans Serif", 9F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(756, 590)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 18)
        Label2.TabIndex = 7
        Label2.Text = "Forgot Password?"
        ' 
        ' SignUpLabel
        ' 
        SignUpLabel.Anchor = AnchorStyles.Right
        SignUpLabel.AutoSize = True
        SignUpLabel.Cursor = Cursors.Hand
        SignUpLabel.Font = New Font("Microsoft Sans Serif", 9F)
        SignUpLabel.ForeColor = Color.White
        SignUpLabel.Location = New Point(974, 590)
        SignUpLabel.Name = "SignUpLabel"
        SignUpLabel.Size = New Size(131, 18)
        SignUpLabel.TabIndex = 8
        SignUpLabel.Text = "New User? Signup"
        ' 
        ' LoginPic
        ' 
        LoginPic.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LoginPic.BackgroundImage = My.Resources.Resources.loginImage
        LoginPic.BackgroundImageLayout = ImageLayout.Stretch
        LoginPic.Location = New Point(-1, -3)
        LoginPic.Margin = New Padding(2)
        LoginPic.Name = "LoginPic"
        LoginPic.Size = New Size(623, 756)
        LoginPic.TabIndex = 10
        LoginPic.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Centauri", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(756, 187)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 62)
        Label1.TabIndex = 1
        Label1.Text = "LOGIN"
        ' 
        ' User_Login
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1206, 753)
        Controls.Add(LoginPic)
        Controls.Add(SignUpLabel)
        Controls.Add(Label2)
        Controls.Add(LoginButton)
        Controls.Add(TogglePasswordButton)
        Controls.Add(PasswordTextBox)
        Controls.Add(EmailTextBox)
        Controls.Add(EmailLabel)
        Controls.Add(PasswordLabel)
        Controls.Add(Label1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "User_Login"
        Text = "Login"
        CType(TogglePasswordButton, ComponentModel.ISupportInitialize).EndInit()
        CType(LoginPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TogglePasswordButton As PictureBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents SignUpLabel As Label
    Friend WithEvents LoginPic As PictureBox
    Friend WithEvents Label1 As Label
End Class
