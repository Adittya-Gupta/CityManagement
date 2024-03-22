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
        PictureBox1 = New PictureBox()
        NotificationPanel = New Panel()
        NameLabel = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        SearchTextBox = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Exo 2", 12F)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(44, 54)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 24)
        Label1.TabIndex = 0
        Label1.Text = "Home  >"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Exo 2", 12F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(140, 54)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 24)
        Label2.TabIndex = 1
        Label2.Text = "Dashboard"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.notification
        PictureBox1.Image = My.Resources.Resources.notification
        PictureBox1.Location = New Point(55, 511)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(27, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' NotificationPanel
        ' 
        NotificationPanel.AutoScroll = True
        NotificationPanel.BackColor = Color.WhiteSmoke
        NotificationPanel.Location = New Point(44, 555)
        NotificationPanel.Margin = New Padding(4, 5, 4, 5)
        NotificationPanel.Name = "NotificationPanel"
        NotificationPanel.Size = New Size(275, 300)
        NotificationPanel.TabIndex = 1
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.BackColor = Color.Transparent
        NameLabel.Font = New Font("Exo 2", 28F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NameLabel.ForeColor = Color.Black
        NameLabel.Location = New Point(448, 322)
        NameLabel.Margin = New Padding(4, 0, 4, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(225, 56)
        NameLabel.TabIndex = 4
        NameLabel.Text = "My Name"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), Image)
        PictureBox2.Location = New Point(55, 239)
        PictureBox2.Margin = New Padding(4, 5, 4, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(245, 245)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Exo 2", 9.6F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(459, 449)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 19)
        Label3.TabIndex = 6
        Label3.Text = "Email :"
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.BackColor = Color.WhiteSmoke
        SearchTextBox.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchTextBox.Location = New Point(55, 140)
        SearchTextBox.Margin = New Padding(4, 5, 4, 5)
        SearchTextBox.Name = "SearchTextBox"
        SearchTextBox.PlaceholderText = "Search"
        SearchTextBox.Size = New Size(751, 30)
        SearchTextBox.TabIndex = 7
        SearchTextBox.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Exo 2", 9.6F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(459, 509)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 19)
        Label4.TabIndex = 8
        Label4.Text = "DOB :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Exo 2", 9.6F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(459, 539)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 19)
        Label5.TabIndex = 9
        Label5.Text = "Designation :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Exo 2", 9.6F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(459, 569)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 19)
        Label6.TabIndex = 10
        Label6.Text = "Contact :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Exo 2", 9.6F)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(459, 479)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 19)
        Label7.TabIndex = 11
        Label7.Text = "Gender :"
        ' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = Color.Transparent
        EmailLabel.Font = New Font("Exo 2", 9.6F)
        EmailLabel.ForeColor = Color.Black
        EmailLabel.Location = New Point(522, 449)
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
        DesignationLabel.Location = New Point(567, 539)
        DesignationLabel.Margin = New Padding(4, 0, 4, 0)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New Size(109, 19)
        DesignationLabel.TabIndex = 13
        DesignationLabel.Text = "Not Logged In"
        ' 
        ' ContactLabel
        ' 
        ContactLabel.AutoSize = True
        ContactLabel.BackColor = Color.Transparent
        ContactLabel.Font = New Font("Exo 2", 9.6F)
        ContactLabel.ForeColor = Color.Black
        ContactLabel.Location = New Point(537, 569)
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
        GenderLabel.Location = New Point(535, 479)
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
        DOBLabel.Location = New Point(522, 509)
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
        Label9.Font = New Font("Exo 2", 9.6F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(459, 416)
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
        SIDLabel.Location = New Point(522, 416)
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
        ListBox1.Location = New Point(55, 171)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(751, 88)
        ListBox1.TabIndex = 20
        ' 
        ' EditProfileButton
        ' 
        EditProfileButton.BackColor = Color.Black
        EditProfileButton.BackgroundImage = CType(resources.GetObject("EditProfileButton.BackgroundImage"), Image)
        EditProfileButton.BackgroundImageLayout = ImageLayout.Stretch
        EditProfileButton.Cursor = Cursors.Hand
        EditProfileButton.ForeColor = Color.White
        EditProfileButton.Location = New Point(766, 39)
        EditProfileButton.Name = "EditProfileButton"
        EditProfileButton.Size = New Size(126, 55)
        EditProfileButton.TabIndex = 21
        EditProfileButton.UseVisualStyleBackColor = False
        ' 
        ' User_Profile
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(957, 896)
        Controls.Add(ListBox1)
        Controls.Add(EditProfileButton)
        Controls.Add(SIDLabel)
        Controls.Add(Label9)
        Controls.Add(Label1)
        Controls.Add(DOBLabel)
        Controls.Add(Label2)
        Controls.Add(GenderLabel)
        Controls.Add(PictureBox1)
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
        Controls.Add(Label5)
        Controls.Add(PictureBox2)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "User_Profile"
        Text = "Profile"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NotificationPanel As Panel
    Friend WithEvents NameLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
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
End Class
