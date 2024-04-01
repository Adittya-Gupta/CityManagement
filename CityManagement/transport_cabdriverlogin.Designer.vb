<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transport_cabdriverlogin
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
        Panel2 = New Panel()
        Button2 = New Button()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Label9 = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(170), CByte(0), CByte(0), CByte(0))
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(89, 61)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(905, 453)
        Panel1.TabIndex = 29
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(123, 44)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(652, 388)
        Panel2.TabIndex = 13
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.Font = New Font("Abhaya Libre Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(260, 258)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(134, 34)
        Button2.TabIndex = 22
        Button2.Text = "Log In"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(238, 69)
        TextBox4.Margin = New Padding(3, 2, 3, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(223, 29)
        TextBox4.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Centauri", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(11, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(207, 58)
        Label4.TabIndex = 8
        Label4.Text = "Driver " & vbCrLf & "Login"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(238, 38)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 22)
        Label9.TabIndex = 15
        Label9.Text = "Email"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(238, 166)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(223, 29)
        TextBox3.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(238, 121)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 22)
        Label7.TabIndex = 14
        Label7.Text = "Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(224, 76)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 22)
        Label8.TabIndex = 8
        ' 
        ' transport_cabdriverlogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1083, 575)
        Controls.Add(Panel1)
        Name = "transport_cabdriverlogin"
        Text = "transport_cabdriverlogin"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
End Class
