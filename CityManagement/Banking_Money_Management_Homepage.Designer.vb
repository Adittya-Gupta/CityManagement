<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Banking_Money_Management_Homepage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBox_Mode_of_Payment = New System.Windows.Forms.ComboBox()
        Me.RichTextBox_Name = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_Account_Number = New System.Windows.Forms.RichTextBox()
        Me.Button_Continue_Payment = New System.Windows.Forms.Button()
        Me.RichTextBox_Amount = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 641)
        Me.Panel1.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(380, 58)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "With No Charge"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(452, 58)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "World In Real Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 58)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Across"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(377, 58)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Transfer Money"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.ComboBox_Mode_of_Payment)
        Me.Panel2.Controls.Add(Me.RichTextBox_Name)
        Me.Panel2.Controls.Add(Me.RichTextBox_Account_Number)
        Me.Panel2.Controls.Add(Me.Button_Continue_Payment)
        Me.Panel2.Controls.Add(Me.RichTextBox_Amount)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(556, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(553, 641)
        Me.Panel2.TabIndex = 60
        '
        'ComboBox_Mode_of_Payment
        '
        Me.ComboBox_Mode_of_Payment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Mode_of_Payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Mode_of_Payment.FormattingEnabled = True
        Me.ComboBox_Mode_of_Payment.Items.AddRange(New Object() {"Net Banking", "Credit Card", "Debit Card"})
        Me.ComboBox_Mode_of_Payment.Location = New System.Drawing.Point(39, 472)
        Me.ComboBox_Mode_of_Payment.Name = "ComboBox_Mode_of_Payment"
        Me.ComboBox_Mode_of_Payment.Size = New System.Drawing.Size(485, 39)
        Me.ComboBox_Mode_of_Payment.TabIndex = 16
        '
        'RichTextBox_Name
        '
        Me.RichTextBox_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox_Name.Location = New System.Drawing.Point(39, 354)
        Me.RichTextBox_Name.Multiline = False
        Me.RichTextBox_Name.Name = "RichTextBox_Name"
        Me.RichTextBox_Name.Size = New System.Drawing.Size(485, 59)
        Me.RichTextBox_Name.TabIndex = 14
        Me.RichTextBox_Name.Text = ""
        '
        'RichTextBox_Account_Number
        '
        Me.RichTextBox_Account_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox_Account_Number.Location = New System.Drawing.Point(39, 239)
        Me.RichTextBox_Account_Number.Multiline = False
        Me.RichTextBox_Account_Number.Name = "RichTextBox_Account_Number"
        Me.RichTextBox_Account_Number.Size = New System.Drawing.Size(485, 59)
        Me.RichTextBox_Account_Number.TabIndex = 12
        Me.RichTextBox_Account_Number.Text = ""
        '
        'Button_Continue_Payment
        '
        Me.Button_Continue_Payment.BackColor = System.Drawing.Color.Navy
        Me.Button_Continue_Payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Continue_Payment.ForeColor = System.Drawing.Color.White
        Me.Button_Continue_Payment.Location = New System.Drawing.Point(39, 539)
        Me.Button_Continue_Payment.Name = "Button_Continue_Payment"
        Me.Button_Continue_Payment.Size = New System.Drawing.Size(485, 57)
        Me.Button_Continue_Payment.TabIndex = 11
        Me.Button_Continue_Payment.Text = "Continue Payment"
        Me.Button_Continue_Payment.UseVisualStyleBackColor = False
        '
        'RichTextBox_Amount
        '
        Me.RichTextBox_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox_Amount.Location = New System.Drawing.Point(39, 113)
        Me.RichTextBox_Amount.Multiline = False
        Me.RichTextBox_Amount.Name = "RichTextBox_Amount"
        Me.RichTextBox_Amount.Size = New System.Drawing.Size(485, 59)
        Me.RichTextBox_Amount.TabIndex = 6
        Me.RichTextBox_Amount.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 429)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 29)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Mode of Payment"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 29)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 29)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Account Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Send Money"
        '
        'Banking_Money_Management_Homepage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1107, 641)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Banking_Money_Management_Homepage"
        Me.Text = "Money_Management_Homepage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RichTextBox_Amount As RichTextBox
    Friend WithEvents Button_Continue_Payment As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox_Name As RichTextBox
    Friend WithEvents RichTextBox_Account_Number As RichTextBox
    Friend WithEvents ComboBox_Mode_of_Payment As ComboBox
End Class
