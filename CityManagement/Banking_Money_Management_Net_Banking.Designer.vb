<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Banking_Money_Management_Net_Banking
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
        Panel1 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        RichTextBox_Remark = New RichTextBox()
        RichTextBox_Password = New RichTextBox()
        RichTextBox_Username = New RichTextBox()
        Button1 = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
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
        Panel1.TabIndex = 75
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
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Panel3.Controls.Add(RichTextBox_Remark)
        Panel3.Controls.Add(RichTextBox_Password)
        Panel3.Controls.Add(RichTextBox_Username)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(554, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(553, 641)
        Panel3.TabIndex = 76
        ' 
        ' RichTextBox_Remark
        ' 
        RichTextBox_Remark.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox_Remark.Location = New Point(39, 351)
        RichTextBox_Remark.Multiline = False
        RichTextBox_Remark.Name = "RichTextBox_Remark"
        RichTextBox_Remark.Size = New Size(485, 59)
        RichTextBox_Remark.TabIndex = 22
        RichTextBox_Remark.Text = ""
        ' 
        ' RichTextBox_Password
        ' 
        RichTextBox_Password.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox_Password.Location = New Point(39, 232)
        RichTextBox_Password.Multiline = False
        RichTextBox_Password.Name = "RichTextBox_Password"
        RichTextBox_Password.Size = New Size(485, 59)
        RichTextBox_Password.TabIndex = 21
        RichTextBox_Password.Text = ""
        ' 
        ' RichTextBox_Username
        ' 
        RichTextBox_Username.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox_Username.Location = New Point(39, 113)
        RichTextBox_Username.Multiline = False
        RichTextBox_Username.Name = "RichTextBox_Username"
        RichTextBox_Username.Size = New Size(485, 59)
        RichTextBox_Username.TabIndex = 20
        RichTextBox_Username.Text = ""
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(39, 486)
        Button1.Name = "Button1"
        Button1.Size = New Size(485, 57)
        Button1.TabIndex = 19
        Button1.Text = "Verify Password"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(33, 307)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 29)
        Label8.TabIndex = 18
        Label8.Text = "Remark"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(33, 187)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 29)
        Label7.TabIndex = 17
        Label7.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(33, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 29)
        Label2.TabIndex = 16
        Label2.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 39)
        Label1.TabIndex = 15
        Label1.Text = "Net Banking"
        ' 
        ' Banking_Money_Management_Net_Banking
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1107, 641)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Banking_Money_Management_Net_Banking"
        Text = "Money_Management_Net_Banking"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RichTextBox_Remark As RichTextBox
    Friend WithEvents RichTextBox_Password As RichTextBox
    Friend WithEvents RichTextBox_Username As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
