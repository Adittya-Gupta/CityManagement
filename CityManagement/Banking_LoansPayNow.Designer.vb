<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Banking_LoansPayNow
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
        Label1 = New Label()
        RichTextBox1 = New RichTextBox()
        Label2 = New Label()
        Label3 = New Label()
        RichTextBox2 = New RichTextBox()
        Label4 = New Label()
        RichTextBox3 = New RichTextBox()
        Label5 = New Label()
        RichTextBox4 = New RichTextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label6 = New Label()
        Label7 = New Label()
        RichTextBox5 = New RichTextBox()
        PayNow_btn = New Button()
        Label8 = New Label()
        Label9 = New Label()
        RichTextBox6 = New RichTextBox()
        Label10 = New Label()
        RichTextBox7 = New RichTextBox()
        Label11 = New Label()
        RichTextBox8 = New RichTextBox()
        Label12 = New Label()
        RichTextBox9 = New RichTextBox()
        Label13 = New Label()
        RichTextBox10 = New RichTextBox()
        RichTextBox11 = New RichTextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 29)
        Label1.TabIndex = 47
        Label1.Text = "Verify details of payment:"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(229, 84)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(277, 44)
        RichTextBox1.TabIndex = 48
        RichTextBox1.Text = ""
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(30, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 22)
        Label2.TabIndex = 49
        Label2.Text = "Principal Amount (Rs):"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 509)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 22)
        Label3.TabIndex = 51
        Label3.Text = "Amount Pending:"
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(229, 497)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(277, 44)
        RichTextBox2.TabIndex = 50
        RichTextBox2.Text = ""
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(30, 440)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 22)
        Label4.TabIndex = 53
        Label4.Text = "Amount to be paid:"
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.Location = New Point(229, 427)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(277, 44)
        RichTextBox3.TabIndex = 52
        RichTextBox3.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(96, 159)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 22)
        Label5.TabIndex = 55
        Label5.Text = "Interest Rate:"
        ' 
        ' RichTextBox4
        ' 
        RichTextBox4.Location = New Point(229, 147)
        RichTextBox4.Name = "RichTextBox4"
        RichTextBox4.ReadOnly = True
        RichTextBox4.Size = New Size(277, 44)
        RichTextBox4.TabIndex = 54
        RichTextBox4.Text = ""
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(229, 336)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(145, 24)
        RadioButton1.TabIndex = 56
        RadioButton1.TabStop = True
        RadioButton1.Text = "Pay full amount"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(229, 375)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(169, 24)
        RadioButton2.TabIndex = 57
        RadioButton2.TabStop = True
        RadioButton2.Text = "Pay partial amount"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(41, 297)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 22)
        Label6.TabIndex = 58
        Label6.Text = "Payment Option:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(30, 240)
        Label7.Name = "Label7"
        Label7.Size = New Size(179, 22)
        Label7.TabIndex = 60
        Label7.Text = "Current Amount Due:"
        ' 
        ' RichTextBox5
        ' 
        RichTextBox5.Location = New Point(229, 228)
        RichTextBox5.Name = "RichTextBox5"
        RichTextBox5.ReadOnly = True
        RichTextBox5.Size = New Size(277, 44)
        RichTextBox5.TabIndex = 59
        RichTextBox5.Text = ""
        ' 
        ' PayNow_btn
        ' 
        PayNow_btn.BackColor = Color.FromArgb(CByte(1), CByte(0), CByte(70))
        PayNow_btn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PayNow_btn.ForeColor = Color.White
        PayNow_btn.Location = New Point(725, 492)
        PayNow_btn.Name = "PayNow_btn"
        PayNow_btn.Size = New Size(186, 39)
        PayNow_btn.TabIndex = 61
        PayNow_btn.Text = "Pay Now"
        PayNow_btn.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.MenuHighlight
        Label8.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(595, 46)
        Label8.Name = "Label8"
        Label8.Size = New Size(152, 29)
        Label8.TabIndex = 62
        Label8.Text = "Loan Details:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.MenuHighlight
        Label9.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(641, 110)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 22)
        Label9.TabIndex = 64
        Label9.Text = "Loan ID:"
        ' 
        ' RichTextBox6
        ' 
        RichTextBox6.Location = New Point(771, 102)
        RichTextBox6.Name = "RichTextBox6"
        RichTextBox6.ReadOnly = True
        RichTextBox6.Size = New Size(277, 44)
        RichTextBox6.TabIndex = 63
        RichTextBox6.Text = ""
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.MenuHighlight
        Label10.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(617, 175)
        Label10.Name = "Label10"
        Label10.Size = New Size(101, 22)
        Label10.TabIndex = 66
        Label10.Text = "Loan Type:"
        ' 
        ' RichTextBox7
        ' 
        RichTextBox7.Location = New Point(771, 165)
        RichTextBox7.Name = "RichTextBox7"
        RichTextBox7.ReadOnly = True
        RichTextBox7.Size = New Size(277, 44)
        RichTextBox7.TabIndex = 65
        RichTextBox7.Text = ""
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.MenuHighlight
        Label11.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(572, 247)
        Label11.Name = "Label11"
        Label11.Size = New Size(156, 22)
        Label11.TabIndex = 68
        Label11.Text = "Maturation Period:"
        ' 
        ' RichTextBox8
        ' 
        RichTextBox8.Location = New Point(771, 235)
        RichTextBox8.Name = "RichTextBox8"
        RichTextBox8.ReadOnly = True
        RichTextBox8.Size = New Size(277, 44)
        RichTextBox8.TabIndex = 67
        RichTextBox8.Text = ""
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = SystemColors.MenuHighlight
        Label12.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(632, 395)
        Label12.Name = "Label12"
        Label12.Size = New Size(90, 22)
        Label12.TabIndex = 70
        Label12.Text = "End Date:"
        ' 
        ' RichTextBox9
        ' 
        RichTextBox9.Location = New Point(771, 383)
        RichTextBox9.Name = "RichTextBox9"
        RichTextBox9.ReadOnly = True
        RichTextBox9.Size = New Size(277, 44)
        RichTextBox9.TabIndex = 69
        RichTextBox9.Text = ""
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = SystemColors.MenuHighlight
        Label13.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(626, 325)
        Label13.Name = "Label13"
        Label13.Size = New Size(96, 22)
        Label13.TabIndex = 72
        Label13.Text = "Start Date:"
        ' 
        ' RichTextBox10
        ' 
        RichTextBox10.Location = New Point(771, 308)
        RichTextBox10.Name = "RichTextBox10"
        RichTextBox10.ReadOnly = True
        RichTextBox10.Size = New Size(277, 44)
        RichTextBox10.TabIndex = 71
        RichTextBox10.Text = ""
        ' 
        ' RichTextBox11
        ' 
        RichTextBox11.BackColor = SystemColors.Highlight
        RichTextBox11.Location = New Point(548, 29)
        RichTextBox11.Name = "RichTextBox11"
        RichTextBox11.Size = New Size(535, 439)
        RichTextBox11.TabIndex = 73
        RichTextBox11.Text = ""
        ' 
        ' Banking_LoansPayNow
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1107, 641)
        ControlBox = False
        Controls.Add(Label13)
        Controls.Add(RichTextBox10)
        Controls.Add(Label12)
        Controls.Add(RichTextBox9)
        Controls.Add(Label11)
        Controls.Add(RichTextBox8)
        Controls.Add(Label10)
        Controls.Add(RichTextBox7)
        Controls.Add(Label9)
        Controls.Add(RichTextBox6)
        Controls.Add(Label8)
        Controls.Add(PayNow_btn)
        Controls.Add(Label7)
        Controls.Add(RichTextBox5)
        Controls.Add(Label6)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label5)
        Controls.Add(RichTextBox4)
        Controls.Add(Label4)
        Controls.Add(RichTextBox3)
        Controls.Add(Label3)
        Controls.Add(RichTextBox2)
        Controls.Add(Label2)
        Controls.Add(RichTextBox1)
        Controls.Add(Label1)
        Controls.Add(RichTextBox11)
        FormBorderStyle = FormBorderStyle.None
        Name = "Banking_LoansPayNow"
        Text = "Banking_LoansPayNow"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RichTextBox5 As RichTextBox
    Friend WithEvents PayNow_btn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RichTextBox6 As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents RichTextBox7 As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents RichTextBox8 As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents RichTextBox9 As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents RichTextBox10 As RichTextBox
    Friend WithEvents RichTextBox11 As RichTextBox
End Class
