<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_ChangePassword))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Label11 = New Label()
        PictureBox1 = New PictureBox()
        Button3 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(298, 454)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Password"
        TextBox1.Size = New Size(352, 30)
        TextBox1.TabIndex = 24
        TextBox1.UseSystemPasswordChar = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(298, 500)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Confirm Password"
        TextBox2.Size = New Size(352, 30)
        TextBox2.TabIndex = 30
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(401, 582)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 43)
        Button1.TabIndex = 5
        Button1.Text = "RESET"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackgroundImageLayout = ImageLayout.None
        CheckBox1.Cursor = Cursors.Hand
        CheckBox1.Font = New Font("Microsoft YaHei", 7F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(298, 538)
        CheckBox1.Margin = New Padding(3, 4, 3, 4)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(121, 21)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(938, 700)
        Panel1.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(298, 379)
        Label4.Name = "Label4"
        Label4.Size = New Size(350, 48)
        Label4.TabIndex = 53
        Label4.Text = "What would you like your " & vbCrLf & "new password to be ?"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(329, 340)
        Label3.Name = "Label3"
        Label3.Size = New Size(300, 39)
        Label3.TabIndex = 1
        Label3.Text = "Reset your password"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonShadow
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Label11)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(938, 67)
        Panel2.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(329, 13)
        Label11.Name = "Label11"
        Label11.Size = New Size(280, 39)
        Label11.TabIndex = 40
        Label11.Text = "Reset Password"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(244, 106)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(466, 220)
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.BackColor = Color.Black
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(761, 13)
        Button3.Name = "Button3"
        Button3.Size = New Size(151, 41)
        Button3.TabIndex = 54
        Button3.Text = " Back To Login"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' User_ChangePassword
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        ClientSize = New Size(938, 700)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "User_ChangePassword"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
End Class
