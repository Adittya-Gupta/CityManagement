<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Banking_Homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Banking_Homepage))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.Module_5.My.Resources.Resources.bank_img2
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(809, 641)
        Me.Panel4.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label3.Location = New System.Drawing.Point(52, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(701, 641)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Black
        Me.Button18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Bodoni MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.White
        Me.Button18.Location = New System.Drawing.Point(851, 371)
        Me.Button18.Margin = New System.Windows.Forms.Padding(0)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(220, 74)
        Me.Button18.TabIndex = 44
        Me.Button18.Text = "EMPLOYEE"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.Black
        Me.Button19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button19.FlatAppearance.BorderSize = 0
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Bodoni MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.White
        Me.Button19.Location = New System.Drawing.Point(851, 236)
        Me.Button19.Margin = New System.Windows.Forms.Padding(0)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(220, 74)
        Me.Button19.TabIndex = 43
        Me.Button19.Text = "REGISTER"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Black
        Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button20.FlatAppearance.BorderSize = 0
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("Bodoni MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.Color.White
        Me.Button20.Location = New System.Drawing.Point(851, 126)
        Me.Button20.Margin = New System.Windows.Forms.Padding(0)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(220, 74)
        Me.Button20.TabIndex = 42
        Me.Button20.Text = "LOGIN"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Banking_Homepage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1107, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button20)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Banking_Homepage"
        Me.Text = "Banking_Homepage"
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
End Class
