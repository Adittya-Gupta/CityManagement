<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Panel1 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Button3 = New Button()
        Label3 = New Label()
        Label11 = New Label()
        Label1 = New Label()
        Label14 = New Label()
        Label2 = New Label()
        TimeLeftLabel = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TimeLeftLabel)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 556)
        Panel1.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(204, 392)
        Label6.Name = "Label6"
        Label6.Size = New Size(197, 18)
        Label6.TabIndex = 45
        Label6.Text = "Enter OTP recieved on Mail :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(204, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(206, 18)
        Label5.TabIndex = 44
        Label5.Text = "Time left before code expires :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(204, 128)
        Label4.Name = "Label4"
        Label4.Size = New Size(235, 18)
        Label4.TabIndex = 43
        Label4.Text = "Enter your registered email below :"
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(637, 36)
        Button3.Name = "Button3"
        Button3.Size = New Size(151, 30)
        Button3.TabIndex = 42
        Button3.Text = " Back To Login"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(204, 430)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 18)
        Label3.TabIndex = 41
        Label3.Text = "OTP :"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(194, 36)
        Label11.Name = "Label11"
        Label11.Size = New Size(281, 39)
        Label11.TabIndex = 40
        Label11.Text = "OTP Verification"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(204, 176)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 20)
        Label1.TabIndex = 39
        Label1.Text = "Email :"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(413, 604)
        Label14.Name = "Label14"
        Label14.Size = New Size(46, 20)
        Label14.TabIndex = 38
        Label14.Text = "OTP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(102, 234)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 22)
        Label2.TabIndex = 13
        ' 
        ' TimeLeftLabel
        ' 
        TimeLeftLabel.AutoSize = True
        TimeLeftLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TimeLeftLabel.Location = New Point(204, 339)
        TimeLeftLabel.Name = "TimeLeftLabel"
        TimeLeftLabel.Size = New Size(121, 25)
        TimeLeftLabel.TabIndex = 12
        TimeLeftLabel.Text = "Time Left : "
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(283, 170)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(226, 26)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(273, 430)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(226, 26)
        TextBox1.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(306, 483)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 40)
        Button2.TabIndex = 8
        Button2.Text = "VALIDATE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(306, 219)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 40)
        Button1.TabIndex = 7
        Button1.Text = "SEND CODE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ForgotPassword
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(800, 556)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ForgotPassword"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TimeLeftLabel As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
End Class
