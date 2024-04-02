<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Banking_Apply_Credit_Card
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
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Apply_btn = New System.Windows.Forms.Button()
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.Income_Proof_tb = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Income_tb = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Choose_btn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.Black
        Me.TextBox8.Location = New System.Drawing.Point(649, 391)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(488, 33)
        Me.TextBox8.TabIndex = 132
        Me.TextBox8.Text = "Do you have any outstanding debts?"
        '
        'Apply_btn
        '
        Me.Apply_btn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Apply_btn.Font = New System.Drawing.Font("Adobe Hebrew", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Apply_btn.ForeColor = System.Drawing.Color.White
        Me.Apply_btn.Location = New System.Drawing.Point(707, 464)
        Me.Apply_btn.Name = "Apply_btn"
        Me.Apply_btn.Size = New System.Drawing.Size(147, 57)
        Me.Apply_btn.TabIndex = 131
        Me.Apply_btn.Text = "Apply"
        Me.Apply_btn.UseVisualStyleBackColor = False
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.Location = New System.Drawing.Point(631, 431)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(22, 21)
        Me.CheckBox.TabIndex = 130
        Me.CheckBox.UseVisualStyleBackColor = True
        '
        'Income_Proof_tb
        '
        Me.Income_Proof_tb.BackColor = System.Drawing.Color.DarkGray
        Me.Income_Proof_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Income_Proof_tb.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Income_Proof_tb.ForeColor = System.Drawing.Color.Black
        Me.Income_Proof_tb.Location = New System.Drawing.Point(649, 241)
        Me.Income_Proof_tb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Income_Proof_tb.Multiline = True
        Me.Income_Proof_tb.Name = "Income_Proof_tb"
        Me.Income_Proof_tb.ReadOnly = True
        Me.Income_Proof_tb.Size = New System.Drawing.Size(284, 46)
        Me.Income_Proof_tb.TabIndex = 128
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.Black
        Me.TextBox7.Location = New System.Drawing.Point(667, 200)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(187, 33)
        Me.TextBox7.TabIndex = 127
        Me.TextBox7.Text = "Income Proof"
        '
        'Income_tb
        '
        Me.Income_tb.BackColor = System.Drawing.Color.DarkGray
        Me.Income_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Income_tb.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Income_tb.ForeColor = System.Drawing.Color.Black
        Me.Income_tb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Income_tb.Location = New System.Drawing.Point(649, 135)
        Me.Income_tb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Income_tb.Multiline = True
        Me.Income_tb.Name = "Income_tb"
        Me.Income_tb.Size = New System.Drawing.Size(284, 41)
        Me.Income_tb.TabIndex = 123
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(667, 85)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(187, 33)
        Me.TextBox3.TabIndex = 122
        Me.TextBox3.Text = "Annual Salary" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Choose_btn
        '
        Me.Choose_btn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Choose_btn.Font = New System.Drawing.Font("Adobe Hebrew", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Choose_btn.ForeColor = System.Drawing.Color.White
        Me.Choose_btn.Location = New System.Drawing.Point(722, 307)
        Me.Choose_btn.Name = "Choose_btn"
        Me.Choose_btn.Size = New System.Drawing.Size(109, 46)
        Me.Choose_btn.TabIndex = 133
        Me.Choose_btn.Text = "Choose"
        Me.Choose_btn.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Module_5.My.Resources.Resources.Card_Page
        Me.PictureBox3.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(615, 560)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 124
        Me.PictureBox3.TabStop = False
        '
        'Banking_Apply_Credit_Card
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1798, 843)
        Me.Controls.Add(Me.Choose_btn)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Apply_btn)
        Me.Controls.Add(Me.CheckBox)
        Me.Controls.Add(Me.Income_Proof_tb)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Income_tb)
        Me.Controls.Add(Me.TextBox3)
        Me.Name = "Banking_Apply_Credit_Card"
        Me.Text = "Apply_Credit_Card"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Apply_btn As Button
    Friend WithEvents CheckBox As CheckBox
    Friend WithEvents Income_Proof_tb As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Income_tb As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Choose_btn As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
