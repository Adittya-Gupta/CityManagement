<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_SignUpForm
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
        EmailTextBox = New TextBox()
        EmailLabel = New Label()
        Label1 = New Label()
        LoginLabel = New Label()
        SignUpButton = New Button()
        NameTextBox = New TextBox()
        Label3 = New Label()
        ContactTextBox = New TextBox()
        Label4 = New Label()
        ConfirmPasswordTextBox = New TextBox()
        Label2 = New Label()
        Label6 = New Label()
        PasswordTextBox = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        GenderComboBox = New ComboBox()
        DateOfBirthDateTimePicker = New DateTimePicker()
        LoginPic = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        Label5 = New Label()
        Button1 = New Button()
        StrengthCheckLabel = New Label()
        CType(LoginPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        EmailTextBox.Font = New Font("Microsoft Sans Serif", 12F)
        EmailTextBox.Location = New Point(803, 179)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(231, 30)
        EmailTextBox.TabIndex = 2
        ' 
        ' EmailLabel
        ' 
        EmailLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        EmailLabel.AutoSize = True
        EmailLabel.Font = New Font("Microsoft Sans Serif", 12F)
        EmailLabel.ForeColor = Color.White
        EmailLabel.Location = New Point(796, 145)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(68, 25)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "Email*"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(617, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 58)
        Label1.TabIndex = 10
        Label1.Text = "SIGN UP"
        ' 
        ' LoginLabel
        ' 
        LoginLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        LoginLabel.AutoSize = True
        LoginLabel.Cursor = Cursors.Hand
        LoginLabel.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LoginLabel.ForeColor = Color.White
        LoginLabel.Location = New Point(524, 588)
        LoginLabel.Name = "LoginLabel"
        LoginLabel.Size = New Size(143, 18)
        LoginLabel.TabIndex = 18
        LoginLabel.Text = "Existing User? Login"
        ' 
        ' SignUpButton
        ' 
        SignUpButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SignUpButton.Cursor = Cursors.Hand
        SignUpButton.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SignUpButton.Location = New Point(672, 619)
        SignUpButton.Name = "SignUpButton"
        SignUpButton.Size = New Size(204, 68)
        SignUpButton.TabIndex = 11
        SignUpButton.Text = "Sign Up"
        SignUpButton.UseVisualStyleBackColor = True
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        NameTextBox.Font = New Font("Microsoft Sans Serif", 12F)
        NameTextBox.Location = New Point(529, 179)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(231, 30)
        NameTextBox.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(524, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 25)
        Label3.TabIndex = 20
        Label3.Text = "Name*"
        ' 
        ' ContactTextBox
        ' 
        ContactTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        ContactTextBox.Font = New Font("Microsoft Sans Serif", 12F)
        ContactTextBox.Location = New Point(529, 296)
        ContactTextBox.Name = "ContactTextBox"
        ContactTextBox.Size = New Size(231, 30)
        ContactTextBox.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(524, 263)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 25)
        Label4.TabIndex = 24
        Label4.Text = "Contact*"
        ' 
        ' ConfirmPasswordTextBox
        ' 
        ConfirmPasswordTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        ConfirmPasswordTextBox.Font = New Font("Microsoft Sans Serif", 12F)
        ConfirmPasswordTextBox.Location = New Point(529, 528)
        ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        ConfirmPasswordTextBox.Size = New Size(325, 30)
        ConfirmPasswordTextBox.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(524, 492)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 25)
        Label2.TabIndex = 32
        Label2.Text = "Confirm Password*"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(888, 492)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 25)
        Label6.TabIndex = 30
        Label6.Text = "DOB"
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        PasswordTextBox.Font = New Font("Microsoft Sans Serif", 12F)
        PasswordTextBox.Location = New Point(529, 409)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(325, 30)
        PasswordTextBox.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(524, 374)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 25)
        Label7.TabIndex = 28
        Label7.Text = "Password*"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(888, 374)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 25)
        Label8.TabIndex = 26
        Label8.Text = "Gender"
        ' 
        ' GenderComboBox
        ' 
        GenderComboBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        GenderComboBox.Font = New Font("Microsoft Sans Serif", 11F)
        GenderComboBox.FormattingEnabled = True
        GenderComboBox.ItemHeight = 22
        GenderComboBox.Location = New Point(888, 409)
        GenderComboBox.Name = "GenderComboBox"
        GenderComboBox.Size = New Size(145, 30)
        GenderComboBox.TabIndex = 7
        ' 
        ' DateOfBirthDateTimePicker
        ' 
        DateOfBirthDateTimePicker.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        DateOfBirthDateTimePicker.Font = New Font("Microsoft Sans Serif", 11F)
        DateOfBirthDateTimePicker.Format = DateTimePickerFormat.Short
        DateOfBirthDateTimePicker.Location = New Point(888, 528)
        DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        DateOfBirthDateTimePicker.Size = New Size(145, 28)
        DateOfBirthDateTimePicker.TabIndex = 8
        ' 
        ' LoginPic
        ' 
        LoginPic.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LoginPic.BackgroundImage = loginImage
        LoginPic.BackgroundImageLayout = ImageLayout.Stretch
        LoginPic.Location = New Point(-3, -1)
        LoginPic.Name = "LoginPic"
        LoginPic.Size = New Size(491, 714)
        LoginPic.TabIndex = 9
        LoginPic.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "*.png|*.jpg|*.jpeg|*.bmp"
        OpenFileDialog1.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)"
        OpenFileDialog1.Title = "Upload Picture"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(796, 263)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 25)
        Label5.TabIndex = 37
        Label5.Text = "Profile Image"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI", 9.6F, FontStyle.Bold)
        Button1.Location = New Point(803, 296)
        Button1.Name = "Button1"
        Button1.Size = New Size(230, 30)
        Button1.TabIndex = 4
        Button1.Text = "Upload Picture"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' StrengthCheckLabel
        ' 
        StrengthCheckLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        StrengthCheckLabel.AutoSize = True
        StrengthCheckLabel.BackColor = SystemColors.ActiveCaptionText
        StrengthCheckLabel.ForeColor = Color.White
        StrengthCheckLabel.Location = New Point(530, 451)
        StrengthCheckLabel.Name = "StrengthCheckLabel"
        StrengthCheckLabel.Size = New Size(111, 20)
        StrengthCheckLabel.TabIndex = 38
        StrengthCheckLabel.Text = "Check Strength."
        ' 
        ' User_SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1072, 717)
        Controls.Add(StrengthCheckLabel)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(DateOfBirthDateTimePicker)
        Controls.Add(GenderComboBox)
        Controls.Add(ConfirmPasswordTextBox)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(PasswordTextBox)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(ContactTextBox)
        Controls.Add(Label4)
        Controls.Add(NameTextBox)
        Controls.Add(Label3)
        Controls.Add(EmailTextBox)
        Controls.Add(EmailLabel)
        Controls.Add(Label1)
        Controls.Add(LoginLabel)
        Controls.Add(SignUpButton)
        Controls.Add(LoginPic)
        Name = "User_SignUpForm"
        Text = "SignUpForm"
        CType(LoginPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginLabel As Label
    Friend WithEvents SignUpButton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents LoginPic As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents StrengthCheckLabel As Label
    Friend WithEvents Label9 As Label
End Class
