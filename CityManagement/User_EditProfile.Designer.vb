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
        EmailTextBox.Location = New Point(587, 308)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.ReadOnly = True
        EmailTextBox.Size = New Size(289, 31)
        EmailTextBox.TabIndex = 2
        ' 
        ' EmailLabel
        ' 
        EmailLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        EmailLabel.AutoSize = True
        EmailLabel.Font = New Font("Exo 2", 12F)
        EmailLabel.ForeColor = Color.Black
        EmailLabel.Location = New Point(588, 273)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(61, 24)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Centauri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(281, 168)
        Label1.Name = "Label1"
        Label1.Size = New Size(577, 46)
        Label1.TabIndex = 10
        Label1.Text = "Edit Profile"
        ' 
        ' SignUpButton
        ' 
        SignUpButton.Cursor = Cursors.Hand
        SignUpButton.Font = New Font("Exo 2", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SignUpButton.Location = New Point(454, 635)
        SignUpButton.Name = "SignUpButton"
        SignUpButton.Size = New Size(235, 76)
        SignUpButton.TabIndex = 11
        SignUpButton.Text = "Submit"
        SignUpButton.UseVisualStyleBackColor = True
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Font = New Font("Exo 2", 12F)
        NameTextBox.Location = New Point(281, 308)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(289, 31)
        NameTextBox.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Exo 2", 12F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(281, 273)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 24)
        Label3.TabIndex = 20
        Label3.Text = "Name"
        ' 
        ' ContactTextBox
        ' 
        ContactTextBox.Font = New Font("Exo 2", 12F)
        ContactTextBox.Location = New Point(281, 431)
        ContactTextBox.Name = "ContactTextBox"
        ContactTextBox.Size = New Size(289, 31)
        ContactTextBox.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Exo 2", 12F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(281, 396)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 24)
        Label4.TabIndex = 24
        Label4.Text = "Contact"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Exo 2", 12F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(587, 522)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 24)
        Label6.TabIndex = 30
        Label6.Text = "DOB"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Exo 2", 12F)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(281, 522)
        Label8.Name = "Label8"
        Label8.Size = New Size(76, 24)
        Label8.TabIndex = 26
        Label8.Text = "Gender"
        ' 
        ' GenderComboBox
        ' 
        GenderComboBox.Font = New Font("Exo 2", 11F)
        GenderComboBox.FormattingEnabled = True
        GenderComboBox.ItemHeight = 22
        GenderComboBox.Location = New Point(281, 567)
        GenderComboBox.Name = "GenderComboBox"
        GenderComboBox.Size = New Size(194, 30)
        GenderComboBox.TabIndex = 7
        ' 
        ' DateOfBirthDateTimePicker
        ' 
        DateOfBirthDateTimePicker.Font = New Font("Exo 2", 11F)
        DateOfBirthDateTimePicker.Format = DateTimePickerFormat.Short
        DateOfBirthDateTimePicker.Location = New Point(588, 568)
        DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        DateOfBirthDateTimePicker.Size = New Size(194, 29)
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
        Label5.Location = New Point(587, 396)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 24)
        Label5.TabIndex = 37
        Label5.Text = "Profile Image"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(588, 435)
        Button1.Name = "Button1"
        Button1.Size = New Size(289, 34)
        Button1.TabIndex = 4
        Button1.Text = "Upload Picture"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(32, 70)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 35)
        Label2.TabIndex = 38
        Label2.Text = "Dashboard  >"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(228, 70)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(166, 35)
        Label7.TabIndex = 39
        Label7.Text = "Edit Profile"
        ' 
        ' User_EditProfile
        ' 
        AutoScaleMode = AutoScaleMode.None
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
