<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Banking_LoanDetails
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Name_tb = New System.Windows.Forms.RichTextBox()
        Me.ACno_tb = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Purpose_tb = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Email_tb = New System.Windows.Forms.RichTextBox()
        Me.Aadhar_tb = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Principal_tb = New System.Windows.Forms.RichTextBox()
        Me.InterestRate_tb = New System.Windows.Forms.RichTextBox()
        Me.CIBILscore_tb = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Duration_tb = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Submit_btn = New System.Windows.Forms.Button()
        Me.RichTextBox10 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Name"
        '
        'Name_tb
        '
        Me.Name_tb.BackColor = System.Drawing.Color.White
        Me.Name_tb.Location = New System.Drawing.Point(130, 79)
        Me.Name_tb.Name = "Name_tb"
        Me.Name_tb.Size = New System.Drawing.Size(294, 41)
        Me.Name_tb.TabIndex = 36
        Me.Name_tb.Text = ""
        '
        'ACno_tb
        '
        Me.ACno_tb.BackColor = System.Drawing.Color.White
        Me.ACno_tb.Location = New System.Drawing.Point(130, 145)
        Me.ACno_tb.Name = "ACno_tb"
        Me.ACno_tb.Size = New System.Drawing.Size(294, 41)
        Me.ACno_tb.TabIndex = 38
        Me.ACno_tb.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "A/C no."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(684, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Type:"
        '
        'Purpose_tb
        '
        Me.Purpose_tb.BackColor = System.Drawing.Color.White
        Me.Purpose_tb.Location = New System.Drawing.Point(126, 209)
        Me.Purpose_tb.Name = "Purpose_tb"
        Me.Purpose_tb.Size = New System.Drawing.Size(424, 163)
        Me.Purpose_tb.TabIndex = 42
        Me.Purpose_tb.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 25)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Purpose"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Home", "Education", "Personal (Medical)", "Personal (Otherwise)", "Business (Low Risk)", "Business (High Risk)", "Transport"})
        Me.ListBox1.Location = New System.Drawing.Point(788, 181)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(254, 36)
        Me.ListBox1.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 467)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 25)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "ID Proof:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 517)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 25)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 567)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 25)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Aadhar No."
        '
        'Email_tb
        '
        Me.Email_tb.BackColor = System.Drawing.Color.White
        Me.Email_tb.Location = New System.Drawing.Point(166, 501)
        Me.Email_tb.Name = "Email_tb"
        Me.Email_tb.Size = New System.Drawing.Size(294, 41)
        Me.Email_tb.TabIndex = 47
        Me.Email_tb.Text = ""
        '
        'Aadhar_tb
        '
        Me.Aadhar_tb.BackColor = System.Drawing.Color.White
        Me.Aadhar_tb.Location = New System.Drawing.Point(166, 567)
        Me.Aadhar_tb.Name = "Aadhar_tb"
        Me.Aadhar_tb.Size = New System.Drawing.Size(294, 41)
        Me.Aadhar_tb.TabIndex = 48
        Me.Aadhar_tb.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(332, 29)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Please enter personal details:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(583, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(266, 29)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Enter Loan Plan details:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(593, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 25)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Principal Amount:"
        '
        'Principal_tb
        '
        Me.Principal_tb.BackColor = System.Drawing.Color.White
        Me.Principal_tb.Location = New System.Drawing.Point(788, 120)
        Me.Principal_tb.Name = "Principal_tb"
        Me.Principal_tb.Size = New System.Drawing.Size(254, 41)
        Me.Principal_tb.TabIndex = 52
        Me.Principal_tb.Text = ""
        '
        'InterestRate_tb
        '
        Me.InterestRate_tb.BackColor = System.Drawing.Color.White
        Me.InterestRate_tb.Location = New System.Drawing.Point(788, 239)
        Me.InterestRate_tb.Name = "InterestRate_tb"
        Me.InterestRate_tb.Size = New System.Drawing.Size(254, 41)
        Me.InterestRate_tb.TabIndex = 54
        Me.InterestRate_tb.Text = ""
        '
        'CIBILscore_tb
        '
        Me.CIBILscore_tb.BackColor = System.Drawing.Color.White
        Me.CIBILscore_tb.Location = New System.Drawing.Point(166, 406)
        Me.CIBILscore_tb.Name = "CIBILscore_tb"
        Me.CIBILscore_tb.Size = New System.Drawing.Size(294, 41)
        Me.CIBILscore_tb.TabIndex = 55
        Me.CIBILscore_tb.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(32, 406)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 25)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "CIBIL Score"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(623, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 25)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Interest Rate:"
        '
        'Duration_tb
        '
        Me.Duration_tb.BackColor = System.Drawing.Color.White
        Me.Duration_tb.Location = New System.Drawing.Point(788, 303)
        Me.Duration_tb.Name = "Duration_tb"
        Me.Duration_tb.Size = New System.Drawing.Size(254, 41)
        Me.Duration_tb.TabIndex = 58
        Me.Duration_tb.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(656, 303)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 25)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Duration:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(637, 427)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(365, 20)
        Me.CheckBox1.TabIndex = 59
        Me.CheckBox1.Text = "I agree to the Terms and Conditions for availing the Loan."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Submit_btn
        '
        Me.Submit_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Submit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit_btn.ForeColor = System.Drawing.Color.White
        Me.Submit_btn.Location = New System.Drawing.Point(637, 477)
        Me.Submit_btn.Name = "Submit_btn"
        Me.Submit_btn.Size = New System.Drawing.Size(119, 39)
        Me.Submit_btn.TabIndex = 60
        Me.Submit_btn.Text = "Submit"
        Me.Submit_btn.UseVisualStyleBackColor = False
        '
        'RichTextBox10
        '
        Me.RichTextBox10.BackColor = System.Drawing.SystemColors.Highlight
        Me.RichTextBox10.Location = New System.Drawing.Point(569, 40)
        Me.RichTextBox10.Name = "RichTextBox10"
        Me.RichTextBox10.Size = New System.Drawing.Size(506, 344)
        Me.RichTextBox10.TabIndex = 61
        Me.RichTextBox10.Text = ""
        '
        'Banking_LoanDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1107, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Submit_btn)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Duration_tb)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CIBILscore_tb)
        Me.Controls.Add(Me.InterestRate_tb)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Principal_tb)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Aadhar_tb)
        Me.Controls.Add(Me.Email_tb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Purpose_tb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ACno_tb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Name_tb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Banking_LoanDetails"
        Me.Text = "Banking_LoanDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Name_tb As RichTextBox
    Friend WithEvents ACno_tb As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Purpose_tb As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Email_tb As RichTextBox
    Friend WithEvents Aadhar_tb As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Principal_tb As RichTextBox
    Friend WithEvents InterestRate_tb As RichTextBox
    Friend WithEvents CIBILscore_tb As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Duration_tb As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Submit_btn As Button
    Friend WithEvents RichTextBox10 As RichTextBox
End Class
