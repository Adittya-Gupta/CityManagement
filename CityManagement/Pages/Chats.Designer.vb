<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chats
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
        components = New ComponentModel.Container()
        CurvedLabel1 = New CurvedLabel()
        Label1 = New Label()
        Panel1 = New Panel()
        RichTextBox1 = New RichTextBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.BackColor = Color.Black
        CurvedLabel1.CornerRadius = 10
        CurvedLabel1.Location = New Point(27, 600)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Size = New Size(984, 55)
        CurvedLabel1.TabIndex = 25
        CurvedLabel1.Text = "CurvedLabel1"
        ' 
        ' Label1
        ' 
        Label1.Image = Ellipse_25
        Label1.Location = New Point(1017, 600)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 63)
        Label1.TabIndex = 26
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        Panel1.Location = New Point(27, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1040, 507)
        Panel1.TabIndex = 28
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.Black
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Microsoft Sans Serif", 12F)
        RichTextBox1.ForeColor = Color.Gray
        RichTextBox1.Location = New Point(36, 609)
        RichTextBox1.MaxLength = 1000
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox1.Size = New Size(944, 39)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = "Type a message"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.White
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Exo 2", 19.8000011F)
        Label2.Location = New Point(27, 11)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(60, 0, 0, 0)
        Label2.Size = New Size(555, 50)
        Label2.TabIndex = 29
        Label2.Text = "Label2"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = Mask_group
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(36, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 46)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 2000
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Abhaya Libre Medium", 14F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(944, 8)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 51)
        Button1.TabIndex = 30
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Chats
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1107, 685)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(RichTextBox1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(CurvedLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Chats"
        Text = "Chats"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CurvedLabel9 As CurvedLabel
    Friend WithEvents CurvedLabel1 As CurvedLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
End Class
