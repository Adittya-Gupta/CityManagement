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
        Panel1 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        ComboBox_Mode_of_Payment = New ComboBox()
        RichTextBox_Name = New RichTextBox()
        RichTextBox_Account_Number = New RichTextBox()
        Button_Continue_Payment = New Button()
        RichTextBox_Amount = New RichTextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(553, 641)
        Panel1.TabIndex = 59
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(6, 382)
        Label6.Name = "Label6"
        Label6.Size = New Size(380, 58)
        Label6.TabIndex = 3
        Label6.Text = "With No Charge"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(6, 307)
        Label5.Name = "Label5"
        Label5.Size = New Size(452, 58)
        Label5.TabIndex = 2
        Label5.Text = "World In Real Time"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(6, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 58)
        Label4.TabIndex = 1
        Label4.Text = "Across"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(6, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(377, 58)
        Label3.TabIndex = 0
        Label3.Text = "Transfer Money"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Panel2.Controls.Add(ComboBox_Mode_of_Payment)
        Panel2.Controls.Add(RichTextBox_Name)
        Panel2.Controls.Add(RichTextBox_Account_Number)
        Panel2.Controls.Add(Button_Continue_Payment)
        Panel2.Controls.Add(RichTextBox_Amount)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(556, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(553, 641)
        Panel2.TabIndex = 60
        ' 
        ' ComboBox_Mode_of_Payment
        ' 
        ComboBox_Mode_of_Payment.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_Mode_of_Payment.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox_Mode_of_Payment.FormattingEnabled = True
        ComboBox_Mode_of_Payment.Items.AddRange(New Object() {"Net Banking", "Credit Card", "Debit Card"})
        ComboBox_Mode_of_Payment.Location = New Point(39, 472)
        ComboBox_Mode_of_Payment.Name = "ComboBox_Mode_of_Payment"
        ComboBox_Mode_of_Payment.Size = New Size(485, 39)
        ComboBox_Mode_of_Payment.TabIndex = 16
        ' 
        ' RichTextBox_Name
        ' 
        RichTextBox_Name.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox_Name.Location = New Point(39, 354)
        RichTextBox_Name.Multiline = False
        RichTextBox_Name.Name = "RichTextBox_Name"
        RichTextBox_Name.Size = New Size(485, 59)
        RichTextBox_Name.TabIndex = 14
        RichTextBox_Name.Text = ""
        ' 
        ' RichTextBox_Account_Number
        ' 
        RichTextBox_Account_Number.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox_Account_Number.Location = New Point(39, 239)
        RichTextBox_Account_Number.Multiline = False
        RichTextBox_Account_Number.Name = "RichTextBox_Account_Number"
        RichTextBox_Account_Number.Size = New Size(485, 59)
        RichTextBox_Account_Number.TabIndex = 12
        RichTextBox_Account_Number.Text = ""
        ' 
        ' Button_Continue_Payment
        ' 
        Button_Continue_Payment.BackColor = Color.Navy
        Button_Continue_Payment.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Continue_Payment.ForeColor = Color.White
        Button_Continue_Payment.Location = New Point(39, 539)
        Button_Continue_Payment.Name = "Button_Continue_Payment"
        Button_Continue_Payment.Size = New Size(485, 57)
        Button_Continue_Payment.TabIndex = 11
        Button_Continue_Payment.Text = "Continue Payment"
        Button_Continue_Payment.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox_Amount
        ' 
        RichTextBox_Amount.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox_Amount.Location = New Point(39, 113)
        RichTextBox_Amount.Multiline = False
        RichTextBox_Amount.Name = "RichTextBox_Amount"
        RichTextBox_Amount.Size = New Size(485, 59)
        RichTextBox_Amount.TabIndex = 6
        RichTextBox_Amount.Text = ""
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(33, 429)
        Label10.Name = "Label10"
        Label10.Size = New Size(200, 29)
        Label10.TabIndex = 5
        Label10.Text = "Mode of Payment"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(33, 312)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 29)
        Label9.TabIndex = 4
        Label9.Text = "Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(33, 188)
        Label7.Name = "Label7"
        Label7.Size = New Size(191, 29)
        Label7.TabIndex = 2
        Label7.Text = "Account Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(33, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 29)
        Label2.TabIndex = 1
        Label2.Text = "Amount"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(218, 39)
        Label1.TabIndex = 0
        Label1.Text = "Send Money"
        ' 
        ' Banking_Money_Management_Homepage
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1107, 641)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Banking_Money_Management_Homepage"
        Text = "Money_Management_Homepage"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)

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
