<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Banking_Card_Management
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
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Logout_btn = New System.Windows.Forms.Button()
        Me.Debit_Card_btn = New System.Windows.Forms.Button()
        Me.Credit_Card_btn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Bodoni MT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(1465, 141)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(62, 16)
        Me.TextBox5.TabIndex = 103
        Me.TextBox5.Text = "123456789"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1279, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 17)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "BANK ACCOUNT NUMBER :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Logout_btn
        '
        Me.Logout_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Logout_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout_btn.ForeColor = System.Drawing.Color.White
        Me.Logout_btn.Location = New System.Drawing.Point(1422, 82)
        Me.Logout_btn.Name = "Logout_btn"
        Me.Logout_btn.Size = New System.Drawing.Size(112, 39)
        Me.Logout_btn.TabIndex = 98
        Me.Logout_btn.Text = "Logout"
        Me.Logout_btn.UseVisualStyleBackColor = False
        '
        'Debit_Card_btn
        '
        Me.Debit_Card_btn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Debit_Card_btn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Debit_Card_btn.ForeColor = System.Drawing.Color.White
        Me.Debit_Card_btn.Location = New System.Drawing.Point(717, 198)
        Me.Debit_Card_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Debit_Card_btn.Name = "Debit_Card_btn"
        Me.Debit_Card_btn.Size = New System.Drawing.Size(248, 61)
        Me.Debit_Card_btn.TabIndex = 132
        Me.Debit_Card_btn.Text = "My Debit Card"
        Me.Debit_Card_btn.UseVisualStyleBackColor = False
        '
        'Credit_Card_btn
        '
        Me.Credit_Card_btn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Credit_Card_btn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credit_Card_btn.ForeColor = System.Drawing.Color.White
        Me.Credit_Card_btn.Location = New System.Drawing.Point(717, 300)
        Me.Credit_Card_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Credit_Card_btn.Name = "Credit_Card_btn"
        Me.Credit_Card_btn.Size = New System.Drawing.Size(248, 59)
        Me.Credit_Card_btn.TabIndex = 133
        Me.Credit_Card_btn.Text = "My Credit Card"
        Me.Credit_Card_btn.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Module_5.My.Resources.Resources.Card_Page
        Me.PictureBox3.Location = New System.Drawing.Point(81, 70)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(560, 444)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 101
        Me.PictureBox3.TabStop = False
        '
        'Banking_Card_Management
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1107, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Credit_Card_btn)
        Me.Controls.Add(Me.Debit_Card_btn)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Logout_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Banking_Card_Management"
        Me.Text = "CardManagement"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Logout_btn As Button
    Friend WithEvents Debit_Card_btn As Button
    Friend WithEvents Credit_Card_btn As Button
End Class
