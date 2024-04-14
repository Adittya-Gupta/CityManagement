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
        TextBox8 = New TextBox()
        Apply_btn = New Button()
        CheckBox = New CheckBox()
        Income_Proof_tb = New TextBox()
        TextBox7 = New TextBox()
        Income_tb = New TextBox()
        TextBox3 = New TextBox()
        Choose_btn = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        PictureBox3 = New PictureBox()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = Color.White
        TextBox8.BorderStyle = BorderStyle.None
        TextBox8.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox8.ForeColor = Color.Black
        TextBox8.Location = New Point(648, 400)
        TextBox8.Multiline = True
        TextBox8.Name = "TextBox8"
        TextBox8.ReadOnly = True
        TextBox8.Size = New Size(434, 26)
        TextBox8.TabIndex = 132
        TextBox8.Text = "Do you have any outstanding debts?"
        ' 
        ' Apply_btn
        ' 
        Apply_btn.BackColor = SystemColors.HotTrack
        Apply_btn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Apply_btn.ForeColor = Color.White
        Apply_btn.Location = New Point(699, 458)
        Apply_btn.Margin = New Padding(3, 2, 3, 2)
        Apply_btn.Name = "Apply_btn"
        Apply_btn.Size = New Size(131, 46)
        Apply_btn.TabIndex = 131
        Apply_btn.Text = "Apply"
        Apply_btn.UseVisualStyleBackColor = False
        ' 
        ' CheckBox
        ' 
        CheckBox.AutoSize = True
        CheckBox.Location = New Point(632, 432)
        CheckBox.Margin = New Padding(3, 2, 3, 2)
        CheckBox.Name = "CheckBox"
        CheckBox.Size = New Size(18, 17)
        CheckBox.TabIndex = 130
        CheckBox.UseVisualStyleBackColor = True
        ' 
        ' Income_Proof_tb
        ' 
        Income_Proof_tb.BackColor = Color.DarkGray
        Income_Proof_tb.BorderStyle = BorderStyle.None
        Income_Proof_tb.Font = New Font("Bahnschrift SemiCondensed", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Income_Proof_tb.ForeColor = Color.Black
        Income_Proof_tb.Location = New Point(648, 280)
        Income_Proof_tb.Multiline = True
        Income_Proof_tb.Name = "Income_Proof_tb"
        Income_Proof_tb.ReadOnly = True
        Income_Proof_tb.Size = New Size(252, 37)
        Income_Proof_tb.TabIndex = 128
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.White
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Font = New Font("Bahnschrift SemiCondensed", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox7.ForeColor = Color.Black
        TextBox7.Location = New Point(664, 247)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.ReadOnly = True
        TextBox7.Size = New Size(166, 26)
        TextBox7.TabIndex = 127
        TextBox7.Text = "Income Proof"
        ' 
        ' Income_tb
        ' 
        Income_tb.BackColor = Color.DarkGray
        Income_tb.BorderStyle = BorderStyle.None
        Income_tb.Font = New Font("Bahnschrift SemiCondensed", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Income_tb.ForeColor = Color.Black
        Income_tb.ImeMode = ImeMode.NoControl
        Income_tb.Location = New Point(648, 195)
        Income_tb.Multiline = True
        Income_tb.Name = "Income_tb"
        Income_tb.Size = New Size(252, 33)
        Income_tb.TabIndex = 123
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.White
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Bahnschrift SemiCondensed", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = Color.Black
        TextBox3.Location = New Point(664, 155)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(166, 26)
        TextBox3.TabIndex = 122
        TextBox3.Text = "Annual Salary" & vbCrLf
        ' 
        ' Choose_btn
        ' 
        Choose_btn.BackColor = SystemColors.HotTrack
        Choose_btn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Choose_btn.ForeColor = Color.White
        Choose_btn.Location = New Point(713, 333)
        Choose_btn.Margin = New Padding(3, 2, 3, 2)
        Choose_btn.Name = "Choose_btn"
        Choose_btn.Size = New Size(97, 37)
        Choose_btn.TabIndex = 133
        Choose_btn.Text = "Choose"
        Choose_btn.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Card_Page
        PictureBox3.Location = New Point(69, 86)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(547, 448)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 124
        PictureBox3.TabStop = False
        ' 
        ' Banking_Apply_Credit_Card
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 641)
        ControlBox = False
        Controls.Add(Choose_btn)
        Controls.Add(TextBox8)
        Controls.Add(Apply_btn)
        Controls.Add(CheckBox)
        Controls.Add(Income_Proof_tb)
        Controls.Add(TextBox7)
        Controls.Add(PictureBox3)
        Controls.Add(Income_tb)
        Controls.Add(TextBox3)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Banking_Apply_Credit_Card"
        Text = "Apply_Credit_Card"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

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
