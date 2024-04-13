<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Banking_Debit_Card_Page
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
        Card_Number_lbl = New Label()
        Name_lbl = New Label()
        Valid_Thru_lbl = New Label()
        Member_Since_lbl = New Label()
        Label11 = New Label()
        Label6 = New Label()
        PictureBox3 = New PictureBox()
        Label2 = New Label()
        PictureBox4 = New PictureBox()
        Label5 = New Label()
        Label3 = New Label()
        Credit_Limit_lbl = New Label()
        Label1 = New Label()
        PictureBox12 = New PictureBox()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Card_Number_lbl
        ' 
        Card_Number_lbl.AutoSize = True
        Card_Number_lbl.BackColor = Color.Black
        Card_Number_lbl.Font = New Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Card_Number_lbl.ForeColor = Color.White
        Card_Number_lbl.Location = New Point(344, 279)
        Card_Number_lbl.Name = "Card_Number_lbl"
        Card_Number_lbl.Size = New Size(297, 36)
        Card_Number_lbl.TabIndex = 168
        Card_Number_lbl.Text = "4592 0000 0000 0000"
        ' 
        ' Name_lbl
        ' 
        Name_lbl.AutoSize = True
        Name_lbl.BackColor = Color.Black
        Name_lbl.Font = New Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name_lbl.ForeColor = Color.White
        Name_lbl.Location = New Point(199, 417)
        Name_lbl.Name = "Name_lbl"
        Name_lbl.Size = New Size(190, 36)
        Name_lbl.TabIndex = 167
        Name_lbl.Text = "Avinav Yadav"
        ' 
        ' Valid_Thru_lbl
        ' 
        Valid_Thru_lbl.AutoSize = True
        Valid_Thru_lbl.BackColor = Color.Black
        Valid_Thru_lbl.Font = New Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Valid_Thru_lbl.ForeColor = Color.White
        Valid_Thru_lbl.Location = New Point(458, 357)
        Valid_Thru_lbl.Name = "Valid_Thru_lbl"
        Valid_Thru_lbl.Size = New Size(46, 24)
        Valid_Thru_lbl.TabIndex = 166
        Valid_Thru_lbl.Text = "07/28"
        ' 
        ' Member_Since_lbl
        ' 
        Member_Since_lbl.AutoSize = True
        Member_Since_lbl.BackColor = Color.Black
        Member_Since_lbl.Font = New Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Member_Since_lbl.ForeColor = Color.White
        Member_Since_lbl.Location = New Point(301, 357)
        Member_Since_lbl.Name = "Member_Since_lbl"
        Member_Since_lbl.Size = New Size(46, 24)
        Member_Since_lbl.TabIndex = 165
        Member_Since_lbl.Text = "07/24"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Black
        Label11.Font = New Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(386, 353)
        Label11.Name = "Label11"
        Label11.Size = New Size(43, 48)
        Label11.TabIndex = 164
        Label11.Text = "Valid" & vbCrLf & "Thru"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Black
        Label6.Font = New Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(211, 353)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 48)
        Label6.TabIndex = 163
        Label6.Text = "Member" & vbCrLf & "Since"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Image = My.Resources.Resources.Bank_Logo
        PictureBox3.Location = New Point(201, 193)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(78, 56)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 162
        PictureBox3.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Font = New Font("Bahnschrift", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(318, 208)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 33)
        Label2.TabIndex = 161
        Label2.Text = "CITY BANK"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.Card
        PictureBox4.Location = New Point(175, 171)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(421, 295)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 160
        PictureBox4.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(665, 358)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 25)
        Label5.TabIndex = 158
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(331, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(177, 41)
        Label3.TabIndex = 157
        Label3.Text = "Debit Card"
        ' 
        ' Credit_Limit_lbl
        ' 
        Credit_Limit_lbl.AutoSize = True
        Credit_Limit_lbl.Font = New Font("Bahnschrift", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Credit_Limit_lbl.Location = New Point(807, 326)
        Credit_Limit_lbl.Name = "Credit_Limit_lbl"
        Credit_Limit_lbl.Size = New Size(85, 29)
        Credit_Limit_lbl.TabIndex = 156
        Credit_Limit_lbl.Text = "34,450"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(675, 326)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 36)
        Label1.TabIndex = 155
        Label1.Text = "A/c Balance : "
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Image = My.Resources.Resources.profile_pic
        PictureBox12.Location = New Point(712, 171)
        PictureBox12.Margin = New Padding(3, 2, 3, 2)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(116, 106)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 154
        PictureBox12.TabStop = False
        ' 
        ' Banking_Debit_Card_Page
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 641)
        ControlBox = False
        Controls.Add(Card_Number_lbl)
        Controls.Add(Name_lbl)
        Controls.Add(Valid_Thru_lbl)
        Controls.Add(Member_Since_lbl)
        Controls.Add(Label11)
        Controls.Add(Label6)
        Controls.Add(PictureBox3)
        Controls.Add(Label2)
        Controls.Add(PictureBox4)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Credit_Limit_lbl)
        Controls.Add(Label1)
        Controls.Add(PictureBox12)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Banking_Debit_Card_Page"
        Text = "Banking_Debit_Card_Page"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Card_Number_lbl As Label
    Friend WithEvents Name_lbl As Label
    Friend WithEvents Valid_Thru_lbl As Label
    Friend WithEvents Member_Since_lbl As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Credit_Limit_lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox12 As PictureBox
End Class
