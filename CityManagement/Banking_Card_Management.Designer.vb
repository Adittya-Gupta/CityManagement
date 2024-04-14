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
        TextBox5 = New TextBox()
        Label4 = New Label()
        Logout_btn = New Button()
        Debit_Card_btn = New Button()
        Credit_Card_btn = New Button()
        PictureBox3 = New PictureBox()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.White
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Font = New Font("Bodoni MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(1465, 141)
        TextBox5.Margin = New Padding(3, 2, 3, 2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(62, 16)
        TextBox5.TabIndex = 103
        TextBox5.Text = "123456789"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bodoni MT", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(1279, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 17)
        Label4.TabIndex = 102
        Label4.Text = "BANK ACCOUNT NUMBER :"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Logout_btn
        ' 
        Logout_btn.BackColor = Color.FromArgb(CByte(1), CByte(0), CByte(70))
        Logout_btn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Logout_btn.ForeColor = Color.White
        Logout_btn.Location = New Point(1422, 82)
        Logout_btn.Name = "Logout_btn"
        Logout_btn.Size = New Size(112, 39)
        Logout_btn.TabIndex = 98
        Logout_btn.Text = "Logout"
        Logout_btn.UseVisualStyleBackColor = False
        ' 
        ' Debit_Card_btn
        ' 
        Debit_Card_btn.BackColor = SystemColors.HotTrack
        Debit_Card_btn.Font = New Font("Bahnschrift SemiCondensed", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Debit_Card_btn.ForeColor = Color.White
        Debit_Card_btn.Location = New Point(717, 198)
        Debit_Card_btn.Margin = New Padding(3, 2, 3, 2)
        Debit_Card_btn.Name = "Debit_Card_btn"
        Debit_Card_btn.Size = New Size(248, 61)
        Debit_Card_btn.TabIndex = 132
        Debit_Card_btn.Text = "My Debit Card"
        Debit_Card_btn.UseVisualStyleBackColor = False
        ' 
        ' Credit_Card_btn
        ' 
        Credit_Card_btn.BackColor = SystemColors.HotTrack
        Credit_Card_btn.Font = New Font("Bahnschrift SemiCondensed", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Credit_Card_btn.ForeColor = Color.White
        Credit_Card_btn.Location = New Point(717, 300)
        Credit_Card_btn.Margin = New Padding(3, 2, 3, 2)
        Credit_Card_btn.Name = "Credit_Card_btn"
        Credit_Card_btn.Size = New Size(248, 59)
        Credit_Card_btn.TabIndex = 133
        Credit_Card_btn.Text = "My Credit Card"
        Credit_Card_btn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Card_Page
        PictureBox3.Location = New Point(81, 70)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(560, 444)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 101
        PictureBox3.TabStop = False
        ' 
        ' Banking_Card_Management
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 641)
        ControlBox = False
        Controls.Add(Credit_Card_btn)
        Controls.Add(Debit_Card_btn)
        Controls.Add(TextBox5)
        Controls.Add(Label4)
        Controls.Add(PictureBox3)
        Controls.Add(Logout_btn)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Banking_Card_Management"
        Text = "CardManagement"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Logout_btn As Button
    Friend WithEvents Debit_Card_btn As Button
    Friend WithEvents Credit_Card_btn As Button
End Class
