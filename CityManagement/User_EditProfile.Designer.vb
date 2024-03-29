<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_EditProfile
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
        EmailTextBox = New TextBox()
        EmailLabel = New Label()
        Label1 = New Label()
        SignUpButton = New Button()
        NameTextBox = New TextBox()
        Label3 = New Label()
        ContactTextBox = New TextBox()
        Label4 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        GenderComboBox = New ComboBox()
        DateOfBirthDateTimePicker = New DateTimePicker()
        LoginPic = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        Label5 = New Label()
        Button1 = New Button()
        CType(LoginPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        EmailTextBox.Cursor = Cursors.No
        EmailTextBox.Font = New Font("Exo 2", 12F)
        EmailTextBox.Location = New Point(996, 181)
        EmailTextBox.Margin = New Padding(2)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.ReadOnly = True
        EmailTextBox.Size = New Size(202, 27)
        EmailTextBox.TabIndex = 2
        ' 
        ' EmailLabel
        ' 
        EmailLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        EmailLabel.AutoSize = True
        EmailLabel.Font = New Font("Exo 2", 12F)
        EmailLabel.ForeColor = Color.White
        EmailLabel.Location = New Point(997, 156)
        EmailLabel.Margin = New Padding(2, 0, 2, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(50, 19)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Centauri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(758, 51)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(458, 37)
        Label1.TabIndex = 10
        Label1.Text = "Edit Profile"
        ' 
        ' SignUpButton
        ' 
        SignUpButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SignUpButton.Cursor = Cursors.Hand
        SignUpButton.Font = New Font("Exo 2", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SignUpButton.Location = New Point(882, 522)
        SignUpButton.Margin = New Padding(2)
        SignUpButton.Name = "SignUpButton"
        SignUpButton.Size = New Size(183, 54)
        SignUpButton.TabIndex = 11
        SignUpButton.Text = "Submit"
        SignUpButton.UseVisualStyleBackColor = True
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        NameTextBox.Font = New Font("Exo 2", 12F)
        NameTextBox.Location = New Point(758, 181)
        NameTextBox.Margin = New Padding(2)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(202, 27)
        NameTextBox.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Exo 2", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(758, 156)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 19)
        Label3.TabIndex = 20
        Label3.Text = "Name"
        ' 
        ' ContactTextBox
        ' 
        ContactTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        ContactTextBox.Font = New Font("Exo 2", 12F)
        ContactTextBox.Location = New Point(758, 269)
        ContactTextBox.Margin = New Padding(2)
        ContactTextBox.Name = "ContactTextBox"
        ContactTextBox.Size = New Size(202, 27)
        ContactTextBox.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Exo 2", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(758, 244)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 19)
        Label4.TabIndex = 24
        Label4.Text = "Contact"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Exo 2", 12F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(997, 334)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 19)
        Label6.TabIndex = 30
        Label6.Text = "DOB"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Exo 2", 12F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(758, 334)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 19)
        Label8.TabIndex = 26
        Label8.Text = "Gender"
        ' 
        ' GenderComboBox
        ' 
        GenderComboBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        GenderComboBox.Font = New Font("Exo 2", 11F)
        GenderComboBox.FormattingEnabled = True
        GenderComboBox.ItemHeight = 18
        GenderComboBox.Location = New Point(758, 366)
        GenderComboBox.Margin = New Padding(2)
        GenderComboBox.Name = "GenderComboBox"
        GenderComboBox.Size = New Size(128, 26)
        GenderComboBox.TabIndex = 7
        ' 
        ' DateOfBirthDateTimePicker
        ' 
        DateOfBirthDateTimePicker.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        DateOfBirthDateTimePicker.Font = New Font("Exo 2", 11F)
        DateOfBirthDateTimePicker.Format = DateTimePickerFormat.Short
        DateOfBirthDateTimePicker.Location = New Point(997, 367)
        DateOfBirthDateTimePicker.Margin = New Padding(2)
        DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        DateOfBirthDateTimePicker.Size = New Size(128, 25)
        DateOfBirthDateTimePicker.TabIndex = 8
        ' 
        ' LoginPic
        ' 
        LoginPic.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LoginPic.BackgroundImage = My.Resources.Resources.loginImage
        LoginPic.BackgroundImageLayout = ImageLayout.Stretch
        LoginPic.Location = New Point(-2, -1)
        LoginPic.Margin = New Padding(2)
        LoginPic.Name = "LoginPic"
        LoginPic.Size = New Size(730, 895)
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
        Label5.Font = New Font("Exo 2", 12F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(996, 244)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 19)
        Label5.TabIndex = 37
        Label5.Text = "Profile Image"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.Location = New Point(997, 272)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(201, 23)
        Button1.TabIndex = 4
        Button1.Text = "Upload Picture"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' User_EditProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1238, 881)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(DateOfBirthDateTimePicker)
        Controls.Add(GenderComboBox)
        Controls.Add(Label6)
        Controls.Add(Label8)
        Controls.Add(ContactTextBox)
        Controls.Add(Label4)
        Controls.Add(NameTextBox)
        Controls.Add(Label3)
        Controls.Add(EmailTextBox)
        Controls.Add(EmailLabel)
        Controls.Add(Label1)
        Controls.Add(SignUpButton)
        Controls.Add(LoginPic)
        Margin = New Padding(2)
        Name = "User_EditProfile"
        Text = "SignUpForm"
        CType(LoginPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SignUpButton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents LoginPic As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
