<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Banking_Login
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
        CheckBox1 = New CheckBox()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        ButtonLogin = New Button()
        Label9 = New Label()
        TextBoxUsername = New TextBox()
        Label8 = New Label()
        TextBoxpassword = New TextBox()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackgroundImageLayout = ImageLayout.None
        CheckBox1.Cursor = Cursors.Hand
        CheckBox1.Location = New Point(524, 365)
        CheckBox1.Margin = New Padding(4, 5, 4, 5)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 24)
        CheckBox1.TabIndex = 40
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(35, 194)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(0, 20)
        Label13.TabIndex = 39
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Cursor = Cursors.Hand
        Label12.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.Highlight
        Label12.Location = New Point(531, 495)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(67, 20)
        Label12.TabIndex = 38
        Label12.Text = "Register"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(365, 495)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(178, 20)
        Label11.TabIndex = 37
        Label11.Text = "Don't  Have An Account ?"
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.BackColor = SystemColors.Highlight
        ButtonLogin.Cursor = Cursors.Hand
        ButtonLogin.Location = New Point(365, 423)
        ButtonLogin.Margin = New Padding(4, 5, 4, 5)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(236, 45)
        ButtonLogin.TabIndex = 36
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(365, 218)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 25)
        Label9.TabIndex = 35
        Label9.Text = "Username"
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.BackColor = SystemColors.Info
        TextBoxUsername.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxUsername.Location = New Point(365, 249)
        TextBoxUsername.Margin = New Padding(4, 5, 4, 5)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(235, 24)
        TextBoxUsername.TabIndex = 34
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(365, 295)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 25)
        Label8.TabIndex = 33
        Label8.Text = "Password"
        ' 
        ' TextBoxpassword
        ' 
        TextBoxpassword.BackColor = SystemColors.Info
        TextBoxpassword.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxpassword.Location = New Point(365, 325)
        TextBoxpassword.Margin = New Padding(4, 5, 4, 5)
        TextBoxpassword.Name = "TextBoxpassword"
        TextBoxpassword.Size = New Size(235, 24)
        TextBoxpassword.TabIndex = 32
        TextBoxpassword.UseSystemPasswordChar = True
        ' 
        ' Banking_Login
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 802)
        ControlBox = False
        Controls.Add(CheckBox1)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(ButtonLogin)
        Controls.Add(Label9)
        Controls.Add(TextBoxUsername)
        Controls.Add(Label8)
        Controls.Add(TextBoxpassword)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "Banking_Login"
        Text = "Banking_Login"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ButtonPhoto As Button
    Friend WithEvents ButtonSign As Button
    Friend WithEvents PictureBoxSign As PictureBox
    Friend WithEvents PictureBoxPhoto As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxConfermPassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxDOB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxGender As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxIndentificationNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxpassword As TextBox
End Class
