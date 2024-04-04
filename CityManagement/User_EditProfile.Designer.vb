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
        OpenFileDialog1 = New OpenFileDialog()
        Label5 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Cursor = Cursors.No
        EmailTextBox.Font = New Font("Exo 2", 12F)
        EmailTextBox.Location = New Point(583, 254)
        EmailTextBox.Margin = New Padding(2)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.ReadOnly = True
        EmailTextBox.Size = New Size(226, 27)
        EmailTextBox.TabIndex = 2
        ' 
        ' EmailLabel
        ' 
        EmailLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        EmailLabel.AutoSize = True
        EmailLabel.Font = New Font("Exo 2", 12F)
        EmailLabel.ForeColor = Color.Black
        EmailLabel.Location = New Point(584, 229)
        EmailLabel.Margin = New Padding(2, 0, 2, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(50, 19)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Centauri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(335, 147)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(458, 37)
        Label1.TabIndex = 10
        Label1.Text = "Edit Profile"
        ' 
        ' SignUpButton
        ' 
        SignUpButton.Cursor = Cursors.Hand
        SignUpButton.Font = New Font("Exo 2", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SignUpButton.Location = New Point(492, 595)
        SignUpButton.Margin = New Padding(2)
        SignUpButton.Name = "SignUpButton"
        SignUpButton.Size = New Size(183, 54)
        SignUpButton.TabIndex = 11
        SignUpButton.Text = "Submit"
        SignUpButton.UseVisualStyleBackColor = True
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Font = New Font("Exo 2", 12F)
        NameTextBox.Location = New Point(345, 254)
        NameTextBox.Margin = New Padding(2)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(226, 27)
        NameTextBox.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Exo 2", 12F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(345, 229)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 19)
        Label3.TabIndex = 20
        Label3.Text = "Name"
        ' 
        ' ContactTextBox
        ' 
        ContactTextBox.Font = New Font("Exo 2", 12F)
        ContactTextBox.Location = New Point(345, 342)
        ContactTextBox.Margin = New Padding(2)
        ContactTextBox.Name = "ContactTextBox"
        ContactTextBox.Size = New Size(226, 27)
        ContactTextBox.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Exo 2", 12F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(345, 317)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 19)
        Label4.TabIndex = 24
        Label4.Text = "Contact"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Exo 2", 12F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(583, 407)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 19)
        Label6.TabIndex = 30
        Label6.Text = "DOB"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Exo 2", 12F)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(345, 407)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 19)
        Label8.TabIndex = 26
        Label8.Text = "Gender"
        ' 
        ' GenderComboBox
        ' 
        GenderComboBox.Font = New Font("Exo 2", 11F)
        GenderComboBox.FormattingEnabled = True
        GenderComboBox.ItemHeight = 18
        GenderComboBox.Location = New Point(345, 439)
        GenderComboBox.Margin = New Padding(2)
        GenderComboBox.Name = "GenderComboBox"
        GenderComboBox.Size = New Size(152, 26)
        GenderComboBox.TabIndex = 7
        ' 
        ' DateOfBirthDateTimePicker
        ' 
        DateOfBirthDateTimePicker.Font = New Font("Exo 2", 11F)
        DateOfBirthDateTimePicker.Format = DateTimePickerFormat.Short
        DateOfBirthDateTimePicker.Location = New Point(584, 440)
        DateOfBirthDateTimePicker.Margin = New Padding(2)
        DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        DateOfBirthDateTimePicker.Size = New Size(152, 25)
        DateOfBirthDateTimePicker.TabIndex = 8
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
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Exo 2", 12F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(583, 317)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 19)
        Label5.TabIndex = 37
        Label5.Text = "Profile Image"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(584, 345)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(225, 24)
        Button1.TabIndex = 4
        Button1.Text = "Upload Picture"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(25, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 28)
        Label2.TabIndex = 38
        Label2.Text = "Dashboard  >"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(183, 50)
        Label7.Name = "Label7"
        Label7.Size = New Size(136, 28)
        Label7.TabIndex = 39
        Label7.Text = "Edit Profile"
        ' 
        ' User_EditProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1107, 760)
        Controls.Add(Label2)
        Controls.Add(Label7)
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
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "User_EditProfile"
        Text = "EditProfileForm"
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
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
End Class
