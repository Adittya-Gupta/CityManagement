<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployApplication
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
        backButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        applyBtn = New Button()
        profPic = New PictureBox()
        Details = New RichTextBox()
        contactInfo = New RichTextBox()
        personName = New RichTextBox()
        Document = New Label()
        upload = New Label()
        Label8 = New Label()
        docName = New Label()
        orgName = New Label()
        address = New RichTextBox()
        Label6 = New Label()
        emailAddr = New RichTextBox()
        Label7 = New Label()
        bankAcc = New RichTextBox()
        Label4 = New Label()
        CType(profPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.AutoSize = True
        backButton.BackColor = Color.Black
        backButton.Cursor = Cursors.Hand
        backButton.FlatAppearance.BorderSize = 0
        backButton.FlatStyle = FlatStyle.Flat
        backButton.Font = New Font("Exo 2", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backButton.ForeColor = Color.White
        backButton.Location = New Point(995, 12)
        backButton.Name = "backButton"
        backButton.Size = New Size(100, 50)
        backButton.TabIndex = 30
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Exo 2", 15F, FontStyle.Bold)
        Label1.Location = New Point(43, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 30)
        Label1.TabIndex = 31
        Label1.Text = "Name*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Exo 2", 15F, FontStyle.Bold)
        Label2.Location = New Point(43, 329)
        Label2.Name = "Label2"
        Label2.Size = New Size(413, 30)
        Label2.TabIndex = 32
        Label2.Text = "Details of any previous work done"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Exo 2", 15F, FontStyle.Bold)
        Label3.Location = New Point(397, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(216, 30)
        Label3.TabIndex = 33
        Label3.Text = "Contact Number*"
        ' 
        ' applyBtn
        ' 
        applyBtn.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        applyBtn.BackgroundImage = Employ_button
        applyBtn.Cursor = Cursors.Hand
        applyBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        applyBtn.FlatStyle = FlatStyle.Flat
        applyBtn.Font = New Font("Exo 2", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        applyBtn.ForeColor = Color.White
        applyBtn.Location = New Point(483, 626)
        applyBtn.Name = "applyBtn"
        applyBtn.Size = New Size(161, 60)
        applyBtn.TabIndex = 36
        applyBtn.Text = "Apply"
        applyBtn.UseVisualStyleBackColor = False
        ' 
        ' profPic
        ' 
        profPic.Image = Employ_prof_pic
        profPic.InitialImage = Employ_prof_pic
        profPic.Location = New Point(745, 93)
        profPic.Name = "profPic"
        profPic.Size = New Size(231, 227)
        profPic.TabIndex = 37
        profPic.TabStop = False
        ' 
        ' Details
        ' 
        Details.Font = New Font("Exo 2", 12F)
        Details.Location = New Point(43, 368)
        Details.Name = "Details"
        Details.Size = New Size(654, 123)
        Details.TabIndex = 41
        Details.Text = ""
        ' 
        ' contactInfo
        ' 
        contactInfo.Font = New Font("Exo 2", 12F)
        contactInfo.Location = New Point(397, 158)
        contactInfo.Name = "contactInfo"
        contactInfo.Size = New Size(300, 35)
        contactInfo.TabIndex = 42
        contactInfo.Text = ""
        ' 
        ' personName
        ' 
        personName.Font = New Font("Exo 2", 12F)
        personName.Location = New Point(43, 158)
        personName.Name = "personName"
        personName.Size = New Size(300, 35)
        personName.TabIndex = 44
        personName.Text = ""
        ' 
        ' Document
        ' 
        Document.AllowDrop = True
        Document.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        Document.Cursor = Cursors.Hand
        Document.Font = New Font("Exo 2", 17F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Document.Image = Employ_rect
        Document.Location = New Point(181, 513)
        Document.Name = "Document"
        Document.Size = New Size(766, 76)
        Document.TabIndex = 45
        Document.Text = "Upload Resume or any other Important Document"
        Document.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' upload
        ' 
        upload.Cursor = Cursors.Hand
        upload.Image = Employ_Upload
        upload.Location = New Point(957, 278)
        upload.Name = "upload"
        upload.Size = New Size(58, 52)
        upload.TabIndex = 46
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Abhaya Libre Medium", 30F)
        Label8.Location = New Point(168, 25)
        Label8.Name = "Label8"
        Label8.Size = New Size(264, 50)
        Label8.TabIndex = 47
        Label8.Text = "APPLY FOR"
        ' 
        ' docName
        ' 
        docName.Anchor = AnchorStyles.None
        docName.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        docName.Font = New Font("Exo 2", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        docName.Location = New Point(355, 589)
        docName.Name = "docName"
        docName.Size = New Size(415, 28)
        docName.TabIndex = 48
        docName.Text = "fileName"
        docName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' orgName
        ' 
        orgName.AutoSize = True
        orgName.Font = New Font("Abhaya Libre Medium", 30F)
        orgName.Location = New Point(417, 25)
        orgName.Name = "orgName"
        orgName.Size = New Size(95, 59)
        orgName.TabIndex = 49
        orgName.Text = "Job"
        ' 
        ' address
        ' 
        address.Font = New Font("Exo 2", 12F)
        address.Location = New Point(43, 239)
        address.Name = "address"
        address.Size = New Size(654, 81)
        address.TabIndex = 51
        address.Text = ""
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Exo 2", 15F, FontStyle.Bold)
        Label6.Location = New Point(43, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 30)
        Label6.TabIndex = 50
        Label6.Text = "Address*"
        ' 
        ' emailAddr
        ' 
        emailAddr.Font = New Font("Exo 2", 12F)
        emailAddr.Location = New Point(745, 369)
        emailAddr.Name = "emailAddr"
        emailAddr.Size = New Size(301, 35)
        emailAddr.TabIndex = 53
        emailAddr.Text = ""
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Exo 2", 15F, FontStyle.Bold)
        Label7.Location = New Point(745, 330)
        Label7.Name = "Label7"
        Label7.Size = New Size(191, 30)
        Label7.TabIndex = 52
        Label7.Text = "Email Address*"
        ' 
        ' bankAcc
        ' 
        bankAcc.Font = New Font("Exo 2", 12F)
        bankAcc.Location = New Point(745, 456)
        bankAcc.Name = "bankAcc"
        bankAcc.Size = New Size(301, 35)
        bankAcc.TabIndex = 55
        bankAcc.Text = ""
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Exo 2", 15F, FontStyle.Bold)
        Label4.Location = New Point(745, 417)
        Label4.Name = "Label4"
        Label4.Size = New Size(285, 30)
        Label4.TabIndex = 54
        Label4.Text = "Bank Account Number*"
        ' 
        ' EmployApplication
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        ClientSize = New Size(1107, 705)
        Controls.Add(bankAcc)
        Controls.Add(Label4)
        Controls.Add(emailAddr)
        Controls.Add(Label7)
        Controls.Add(address)
        Controls.Add(Label6)
        Controls.Add(orgName)
        Controls.Add(docName)
        Controls.Add(Label8)
        Controls.Add(upload)
        Controls.Add(Document)
        Controls.Add(personName)
        Controls.Add(contactInfo)
        Controls.Add(Details)
        Controls.Add(profPic)
        Controls.Add(applyBtn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(backButton)
        FormBorderStyle = FormBorderStyle.None
        Name = "EmployApplication"
        Text = "EmployApplication"
        CType(profPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents applyBtn As Button
    Friend WithEvents profPic As PictureBox
    Friend WithEvents Details As RichTextBox
    Friend WithEvents contactInfo As RichTextBox
    Friend WithEvents personName As RichTextBox
    Friend WithEvents Document As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents docName As Label
    Friend WithEvents orgName As Label
    Friend WithEvents upload As Label
    Friend WithEvents address As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents emailAddr As RichTextBox
    Friend WithEvents bankAcc As RichTextBox
    Friend WithEvents Label4 As Label
End Class
