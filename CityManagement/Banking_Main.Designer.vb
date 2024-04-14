<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Banking_Main
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
        Label1 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        PictureBox11 = New PictureBox()
        Button12 = New Button()
        Button13 = New Button()
        Button10 = New Button()
        Button14 = New Button()
        Button11 = New Button()
        Button15 = New Button()
        Button16 = New Button()
        Panel3 = New Panel()
        Panel2.SuspendLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(2, 118)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1107, 611)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bodoni MT", 25F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(69, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 49)
        Label1.TabIndex = 6
        Label1.Text = "CITY BANK"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bodoni MT", 13.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(723, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(379, 27)
        Label2.TabIndex = 9
        Label2.Text = "Welcome to Personal Internet Banking"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox11)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(1, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1107, 59)
        Panel2.TabIndex = 12
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BorderStyle = BorderStyle.FixedSingle
        PictureBox11.Image = My.Resources.Resources.Bank_Logo
        PictureBox11.Location = New Point(0, 0)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(63, 58)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 8
        PictureBox11.TabStop = False
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.Black
        Button12.Cursor = Cursors.Hand
        Button12.FlatAppearance.BorderSize = 0
        Button12.FlatStyle = FlatStyle.Popup
        Button12.Font = New Font("Bodoni MT", 9F, FontStyle.Bold)
        Button12.ForeColor = Color.White
        Button12.Location = New Point(411, 0)
        Button12.Margin = New Padding(0)
        Button12.Name = "Button12"
        Button12.Size = New Size(182, 40)
        Button12.TabIndex = 3
        Button12.Text = "MONEY TRANSFER"
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Button13
        ' 
        Button13.BackColor = Color.Black
        Button13.Cursor = Cursors.Hand
        Button13.FlatAppearance.BorderSize = 0
        Button13.FlatStyle = FlatStyle.Popup
        Button13.Font = New Font("Bodoni MT", 9F, FontStyle.Bold)
        Button13.ForeColor = Color.White
        Button13.Location = New Point(623, 0)
        Button13.Margin = New Padding(0)
        Button13.Name = "Button13"
        Button13.Size = New Size(183, 40)
        Button13.TabIndex = 4
        Button13.Text = "CREDIT/DEBIT CARD"
        Button13.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Black
        Button10.Cursor = Cursors.Hand
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatStyle = FlatStyle.Popup
        Button10.Font = New Font("Bodoni MT", 9F, FontStyle.Bold)
        Button10.ForeColor = Color.White
        Button10.Location = New Point(9, 0)
        Button10.Margin = New Padding(0)
        Button10.Name = "Button10"
        Button10.Size = New Size(113, 40)
        Button10.TabIndex = 1
        Button10.Text = "HOME"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button14
        ' 
        Button14.BackColor = Color.Black
        Button14.Cursor = Cursors.Hand
        Button14.FlatAppearance.BorderSize = 0
        Button14.FlatStyle = FlatStyle.Popup
        Button14.Font = New Font("Bodoni MT", 9F, FontStyle.Bold)
        Button14.ForeColor = Color.White
        Button14.Location = New Point(835, 0)
        Button14.Margin = New Padding(0)
        Button14.Name = "Button14"
        Button14.Size = New Size(118, 40)
        Button14.TabIndex = 5
        Button14.Text = "PASSBOOK"
        Button14.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.Black
        Button11.Cursor = Cursors.Hand
        Button11.FlatAppearance.BorderSize = 0
        Button11.FlatStyle = FlatStyle.Popup
        Button11.Font = New Font("Bodoni MT", 9F, FontStyle.Bold)
        Button11.ForeColor = Color.White
        Button11.Location = New Point(276, 0)
        Button11.Margin = New Padding(0)
        Button11.Name = "Button11"
        Button11.Size = New Size(112, 40)
        Button11.TabIndex = 2
        Button11.Text = "LOANS"
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.Black
        Button15.Cursor = Cursors.Hand
        Button15.FlatAppearance.BorderSize = 0
        Button15.FlatStyle = FlatStyle.Popup
        Button15.Font = New Font("Bodoni MT", 9F, FontStyle.Bold)
        Button15.ForeColor = Color.White
        Button15.Location = New Point(980, 0)
        Button15.Margin = New Padding(0)
        Button15.Name = "Button15"
        Button15.Size = New Size(117, 40)
        Button15.TabIndex = 6
        Button15.Text = "CONTACT US"
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Button16
        ' 
        Button16.BackColor = Color.Black
        Button16.Cursor = Cursors.Hand
        Button16.FlatAppearance.BorderSize = 0
        Button16.FlatStyle = FlatStyle.Popup
        Button16.Font = New Font("Bodoni MT", 9F, FontStyle.Bold)
        Button16.ForeColor = Color.White
        Button16.Location = New Point(141, 0)
        Button16.Margin = New Padding(0)
        Button16.Name = "Button16"
        Button16.Size = New Size(104, 40)
        Button16.TabIndex = 10
        Button16.Text = "PROFILE"
        Button16.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkBlue
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Button15)
        Panel3.Controls.Add(Button10)
        Panel3.Controls.Add(Button14)
        Panel3.Controls.Add(Button13)
        Panel3.Controls.Add(Button12)
        Panel3.Controls.Add(Button16)
        Panel3.Controls.Add(Button11)
        Panel3.Location = New Point(2, 73)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1106, 42)
        Panel3.TabIndex = 13
        ' 
        ' Banking_Main
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(29), CByte(28), CByte(23))
        ClientSize = New Size(1107, 760)
        ControlBox = False
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Banking_Main"
        Text = "Banking_Main"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Panel3 As Panel
End Class
