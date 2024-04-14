Imports MySql.Data.MySqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserProfile_ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserProfile_ChangePassword))
        PictureBox1 = New PictureBox()
        TextBox3 = New TextBox()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        TextBox4 = New TextBox()
        Panel2 = New Panel()
        Label11 = New Label()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(371, 100)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(353, 264)
        PictureBox1.TabIndex = 55
        PictureBox1.TabStop = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(368, 522)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Old Password"
        TextBox3.Size = New Size(356, 30)
        TextBox3.TabIndex = 205
        TextBox3.UseSystemPasswordChar = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackgroundImageLayout = ImageLayout.None
        CheckBox1.Cursor = Cursors.Hand
        CheckBox1.Font = New Font("Microsoft YaHei", 7F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(375, 687)
        CheckBox1.Margin = New Padding(3, 4, 3, 4)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(121, 21)
        CheckBox1.TabIndex = 64
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(453, 728)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 45)
        Button1.TabIndex = 63
        Button1.Text = "Change"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(368, 625)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Confirm New Password"
        TextBox2.Size = New Size(353, 30)
        TextBox2.TabIndex = 400
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(368, 574)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "New Password"
        TextBox1.Size = New Size(356, 30)
        TextBox1.TabIndex = 300
        TextBox1.UseSystemPasswordChar = True
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.ControlLight
        TextBox4.Cursor = Cursors.No
        TextBox4.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(368, 470)
        TextBox4.Margin = New Padding(3, 4, 3, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Email"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(356, 30)
        TextBox4.TabIndex = 168
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonShadow
        Panel2.Controls.Add(Label11)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1034, 70)
        Panel2.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(350, 9)
        Label11.Name = "Label11"
        Label11.Size = New Size(379, 56)
        Label11.TabIndex = 40
        Label11.Text = "Change Password"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(349, 388)
        Label3.Name = "Label3"
        Label3.Size = New Size(394, 70)
        Label3.TabIndex = 71
        Label3.Text = "Want to change your password ?" & vbCrLf & "Just enter your Email and Your old password and " & vbCrLf & "Select a password you want to keep now"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' UserProfile_ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoScrollMinSize = New Size(0, 600)
        BackColor = Color.LightGray
        ClientSize = New Size(1055, 735)
        Controls.Add(Label3)
        Controls.Add(Panel2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(CheckBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Name = "UserProfile_ChangePassword"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
End Class
