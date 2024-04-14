<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Profile))
        Label1 = New Label()
        Label2 = New Label()
        NotificationPanel = New Panel()
        NameLabel = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        SearchTextBox = New TextBox()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        EmailLabel = New Label()
        DesignationLabel = New Label()
        ContactLabel = New Label()
        GenderLabel = New Label()
        DOBLabel = New Label()
        Label9 = New Label()
        SIDLabel = New Label()
        ListBox1 = New ListBox()
        EditProfileButton = New Button()
        ChangePasswordButton = New Button()
        Label8 = New Label()
        Panel1 = New Panel()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        LogoutButton = New Button()
        AdminButton = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(44, 55)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 25)
        Label1.TabIndex = 0
        Label1.Text = "Home  >"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(125, 55)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 25)
        Label2.TabIndex = 1
        Label2.Text = "Dashboard"
        ' 
        ' NotificationPanel
        ' 
        NotificationPanel.Anchor = AnchorStyles.None
        NotificationPanel.AutoScroll = True
        NotificationPanel.BackColor = Color.WhiteSmoke
        NotificationPanel.Location = New Point(44, 437)
        NotificationPanel.Margin = New Padding(4, 6, 4, 6)
        NotificationPanel.Name = "NotificationPanel"
        NotificationPanel.Size = New Size(258, 282)
        NotificationPanel.TabIndex = 1
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.BackColor = Color.Transparent
        NameLabel.Font = New Font("Exo 2", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NameLabel.ForeColor = Color.Black
        NameLabel.Location = New Point(394, 209)
        NameLabel.Margin = New Padding(4, 0, 4, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(239, 60)
        NameLabel.TabIndex = 4
        NameLabel.Text = "My Name"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), Image)
        PictureBox2.Location = New Point(44, 132)
        PictureBox2.Margin = New Padding(4, 6, 4, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(258, 234)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Exo 2", 9.6F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(405, 428)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 19)
        Label3.TabIndex = 6
        Label3.Text = "Email :"
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.BackColor = Color.WhiteSmoke
        SearchTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchTextBox.Location = New Point(276, 55)
        SearchTextBox.Margin = New Padding(4, 6, 4, 6)
        SearchTextBox.Name = "SearchTextBox"
        SearchTextBox.PlaceholderText = "Search"
        SearchTextBox.Size = New Size(410, 30)
        SearchTextBox.TabIndex = 7
        SearchTextBox.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Exo 2", 9.6F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(403, 627)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 19)
        Label4.TabIndex = 8
        Label4.Text = "DOB :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Exo 2", 9.6F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(405, 464)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 19)
        Label6.TabIndex = 10
        Label6.Text = "Contact :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Exo 2", 9.6F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(403, 596)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 19)
        Label7.TabIndex = 11
        Label7.Text = "Gender :"
        ' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = Color.Transparent
        EmailLabel.Font = New Font("Exo 2", 9.6F)
        EmailLabel.ForeColor = Color.Black
        EmailLabel.Location = New Point(549, 428)
        EmailLabel.Margin = New Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(109, 19)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Not Logged In"
        ' 
        ' DesignationLabel
        ' 
        DesignationLabel.AutoSize = True
        DesignationLabel.BackColor = Color.Transparent
        DesignationLabel.Font = New Font("Exo 2", 9.6F)
        DesignationLabel.ForeColor = Color.Black
        DesignationLabel.Location = New Point(405, 283)
        DesignationLabel.Margin = New Padding(4, 0, 4, 0)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New Size(96, 19)
        DesignationLabel.TabIndex = 13
        DesignationLabel.Text = "Designation"
        ' 
        ' ContactLabel
        ' 
        ContactLabel.AutoSize = True
        ContactLabel.BackColor = Color.Transparent
        ContactLabel.Font = New Font("Exo 2", 9.6F)
        ContactLabel.ForeColor = Color.Black
        ContactLabel.Location = New Point(549, 464)
        ContactLabel.Margin = New Padding(4, 0, 4, 0)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New Size(109, 19)
        ContactLabel.TabIndex = 14
        ContactLabel.Text = "Not Logged In"
        ' 
        ' GenderLabel
        ' 
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = Color.Transparent
        GenderLabel.Font = New Font("Exo 2", 9.6F)
        GenderLabel.ForeColor = Color.Black
        GenderLabel.Location = New Point(549, 596)
        GenderLabel.Margin = New Padding(4, 0, 4, 0)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New Size(109, 19)
        GenderLabel.TabIndex = 15
        GenderLabel.Text = "Not Logged In"
        ' 
        ' DOBLabel
        ' 
        DOBLabel.AutoSize = True
        DOBLabel.BackColor = Color.Transparent
        DOBLabel.Font = New Font("Exo 2", 9.6F)
        DOBLabel.ForeColor = Color.Black
        DOBLabel.Location = New Point(546, 627)
        DOBLabel.Margin = New Padding(4, 0, 4, 0)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New Size(109, 19)
        DOBLabel.TabIndex = 16
        DOBLabel.Text = "Not Logged In"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Exo 2", 9.6F, FontStyle.Bold)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(405, 395)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(41, 19)
        Label9.TabIndex = 17
        Label9.Text = "SID :"
        ' 
        ' SIDLabel
        ' 
        SIDLabel.AutoSize = True
        SIDLabel.BackColor = Color.Transparent
        SIDLabel.Font = New Font("Exo 2", 9.6F)
        SIDLabel.ForeColor = Color.Black
        SIDLabel.Location = New Point(549, 395)
        SIDLabel.Margin = New Padding(4, 0, 4, 0)
        SIDLabel.Name = "SIDLabel"
        SIDLabel.Size = New Size(109, 19)
        SIDLabel.TabIndex = 18
        SIDLabel.Text = "Not Logged In"
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Segoe UI", 12F)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 28
        ListBox1.Location = New Point(276, 86)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(410, 32)
        ListBox1.TabIndex = 20
        ' 
        ' EditProfileButton
        ' 
        EditProfileButton.BackColor = Color.Transparent
        EditProfileButton.BackgroundImage = CType(resources.GetObject("EditProfileButton.BackgroundImage"), Image)
        EditProfileButton.BackgroundImageLayout = ImageLayout.Stretch
        EditProfileButton.Cursor = Cursors.Hand
        EditProfileButton.FlatAppearance.BorderSize = 0
        EditProfileButton.FlatStyle = FlatStyle.Flat
        EditProfileButton.ForeColor = Color.White
        EditProfileButton.Location = New Point(903, 158)
        EditProfileButton.Name = "EditProfileButton"
        EditProfileButton.Size = New Size(154, 44)
        EditProfileButton.TabIndex = 21
        EditProfileButton.UseVisualStyleBackColor = False
        ' 
        ' ChangePasswordButton
        ' 
        ChangePasswordButton.BackColor = Color.Black
        ChangePasswordButton.Font = New Font("Exo 2", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ChangePasswordButton.Location = New Point(737, 42)
        ChangePasswordButton.Margin = New Padding(4)
        ChangePasswordButton.Name = "ChangePasswordButton"
        ChangePasswordButton.Size = New Size(169, 55)
        ChangePasswordButton.TabIndex = 22
        ChangePasswordButton.Text = "Change Password"
        ChangePasswordButton.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Abhaya Libre Medium", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(400, 158)
        Label8.Name = "Label8"
        Label8.Size = New Size(144, 41)
        Label8.TabIndex = 23
        Label8.Text = "PROFILE"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Label10)
        Panel1.Location = New Point(44, 404)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(258, 32)
        Panel1.TabIndex = 24
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(65, 1)
        Label10.Name = "Label10"
        Label10.Size = New Size(124, 28)
        Label10.TabIndex = 25
        Label10.Text = "Notifications"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F)
        Label11.ForeColor = Color.DarkGray
        Label11.Location = New Point(403, 348)
        Label11.Name = "Label11"
        Label11.Size = New Size(205, 23)
        Label11.TabIndex = 25
        Label11.Text = "CONTACT INFORMATION"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F)
        Label12.ForeColor = Color.DarkGray
        Label12.Location = New Point(405, 536)
        Label12.Name = "Label12"
        Label12.Size = New Size(175, 23)
        Label12.TabIndex = 26
        Label12.Text = "BASIC INFORMATION"
        ' 
        ' LogoutButton
        ' 
        LogoutButton.BackColor = Color.Black
        LogoutButton.Font = New Font("Exo 2", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LogoutButton.Location = New Point(931, 42)
        LogoutButton.Margin = New Padding(4)
        LogoutButton.Name = "LogoutButton"
        LogoutButton.Size = New Size(126, 55)
        LogoutButton.TabIndex = 27
        LogoutButton.Text = "Logout"
        LogoutButton.UseVisualStyleBackColor = False
        ' 
        ' AdminButton
        ' 
        AdminButton.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AdminButton.ForeColor = Color.DarkGray
        AdminButton.Location = New Point(903, 209)
        AdminButton.Name = "AdminButton"
        AdminButton.Size = New Size(154, 38)
        AdminButton.TabIndex = 28
        AdminButton.Text = "ADMIN PAGE"
        AdminButton.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel2.Location = New Point(407, 313)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(654, 1)
        Panel2.TabIndex = 29
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel3.Location = New Point(44, 382)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(257, 1)
        Panel3.TabIndex = 30
        ' 
        ' User_Profile
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1107, 760)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(ListBox1)
        Controls.Add(AdminButton)
        Controls.Add(LogoutButton)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Panel1)
        Controls.Add(Label8)
        Controls.Add(ChangePasswordButton)
        Controls.Add(EditProfileButton)
        Controls.Add(SIDLabel)
        Controls.Add(Label9)
        Controls.Add(Label1)
        Controls.Add(DOBLabel)
        Controls.Add(Label2)
        Controls.Add(GenderLabel)
        Controls.Add(ContactLabel)
        Controls.Add(NotificationPanel)
        Controls.Add(DesignationLabel)
        Controls.Add(NameLabel)
        Controls.Add(EmailLabel)
        Controls.Add(Label3)
        Controls.Add(Label7)
        Controls.Add(SearchTextBox)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(PictureBox2)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 6, 4, 6)
        Name = "User_Profile"
        Text = "Profile"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NotificationPanel As Panel
    Friend WithEvents NameLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents DesignationLabel As Label
    Friend WithEvents ContactLabel As Label
    Friend WithEvents GenderLabel As Label
    Friend WithEvents DOBLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents SIDLabel As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents EditProfileButton As Button
    Friend WithEvents ChangePasswordButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LogoutButton As Button
    Friend WithEvents AdminButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
