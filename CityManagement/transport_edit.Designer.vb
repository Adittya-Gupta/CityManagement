<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transport_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transport_edit))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        Label7 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Panel2 = New Panel()
        TextBox5 = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label11 = New Label()
        TextBox4 = New TextBox()
        Panel3 = New Panel()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Button4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(26, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 27)
        Label1.TabIndex = 11
        Label1.Text = "Transport Services"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(238, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 23)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(268, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 27)
        Label3.TabIndex = 15
        Label3.Text = "Edit"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lucida Sans", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(41, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(397, 39)
        Label2.TabIndex = 16
        Label2.Text = "Traveller Information"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label4)
        Panel1.Font = New Font("Abhaya Libre Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(41, 132)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1083, 203)
        Panel1.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(21, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(313, 32)
        Label4.TabIndex = 18
        Label4.Text = "Contact Information"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(106), CByte(104), CByte(104))
        Label7.Location = New Point(46, 85)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 27)
        Label7.TabIndex = 19
        Label7.Text = "Email*"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Gainsboro
        TextBox3.Font = New Font("Abhaya Libre Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(46, 127)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "abc@email.com"
        TextBox3.Size = New Size(254, 39)
        TextBox3.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(106), CByte(104), CByte(104))
        Label5.Location = New Point(500, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(181, 27)
        Label5.TabIndex = 21
        Label5.Text = "Mobile Number*"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gainsboro
        TextBox1.Font = New Font("Abhaya Libre Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(546, 127)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(254, 39)
        TextBox1.TabIndex = 22
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gainsboro
        TextBox2.Font = New Font("Abhaya Libre Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(485, 127)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(64, 39)
        TextBox2.TabIndex = 23
        TextBox2.Text = "+91"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(RadioButton2)
        Panel2.Controls.Add(RadioButton1)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label9)
        Panel2.Font = New Font("Abhaya Libre Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(41, 352)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1083, 203)
        Panel2.TabIndex = 24
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Gainsboro
        TextBox5.Font = New Font("Abhaya Libre Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(485, 48)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(315, 39)
        TextBox5.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(106), CByte(104), CByte(104))
        Label6.Location = New Point(485, 16)
        Label6.Name = "Label6"
        Label6.Size = New Size(131, 27)
        Label6.TabIndex = 21
        Label6.Text = "First name*"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(106), CByte(104), CByte(104))
        Label8.Location = New Point(45, 101)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 27)
        Label8.TabIndex = 19
        Label8.Text = "Title*"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(21, 16)
        Label9.Name = "Label9"
        Label9.Size = New Size(259, 32)
        Label9.TabIndex = 18
        Label9.Text = "Passenger, adult"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Abhaya Libre Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(106), CByte(104), CByte(104))
        Label10.Location = New Point(34, 48)
        Label10.Name = "Label10"
        Label10.Size = New Size(143, 20)
        Label10.TabIndex = 24
        Label10.Text = "* Fields required"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(45, 131)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(57, 28)
        RadioButton1.TabIndex = 25
        RadioButton1.TabStop = True
        RadioButton1.Text = "Mr"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(120, 131)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(101, 28)
        RadioButton2.TabIndex = 26
        RadioButton2.TabStop = True
        RadioButton2.Text = "Mrs/Ms"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(106), CByte(104), CByte(104))
        Label11.Location = New Point(485, 112)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 27)
        Label11.TabIndex = 27
        Label11.Text = "Surname*"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Gainsboro
        TextBox4.Font = New Font("Abhaya Libre Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(485, 146)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(315, 39)
        TextBox4.TabIndex = 28
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label12)
        Panel3.Font = New Font("Abhaya Libre Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel3.Location = New Point(41, 565)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1083, 112)
        Panel3.TabIndex = 29
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(23, 43)
        Label12.Name = "Label12"
        Label12.Size = New Size(215, 32)
        Label12.TabIndex = 29
        Label12.Text = "Your Booking"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(106), CByte(104), CByte(104))
        Label13.Location = New Point(293, 14)
        Label13.Name = "Label13"
        Label13.Size = New Size(0, 27)
        Label13.TabIndex = 24
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(106), CByte(104), CByte(104))
        Label14.Location = New Point(324, 14)
        Label14.Name = "Label14"
        Label14.Size = New Size(0, 27)
        Label14.TabIndex = 30
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.FromArgb(CByte(106), CByte(104), CByte(104))
        Label15.Location = New Point(330, 14)
        Label15.Name = "Label15"
        Label15.Size = New Size(0, 27)
        Label15.TabIndex = 31
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.FromArgb(CByte(106), CByte(104), CByte(104))
        Label16.Location = New Point(315, 14)
        Label16.Name = "Label16"
        Label16.Size = New Size(64, 27)
        Label16.TabIndex = 24
        Label16.Text = "Date "
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.FromArgb(CByte(106), CByte(104), CByte(104))
        Label17.Location = New Point(315, 76)
        Label17.Name = "Label17"
        Label17.Size = New Size(92, 27)
        Label17.TabIndex = 32
        Label17.Text = "to-from"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(315, 47)
        Label18.Name = "Label18"
        Label18.Size = New Size(69, 26)
        Label18.TabIndex = 33
        Label18.Text = "Time"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(731, 43)
        Label19.Name = "Label19"
        Label19.Size = New Size(80, 32)
        Label19.TabIndex = 34
        Label19.Text = "Cost"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Black
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(885, 36)
        Button4.Name = "Button4"
        Button4.Size = New Size(165, 53)
        Button4.TabIndex = 35
        Button4.Text = "Pay"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' transport_edit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1369, 689)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "transport_edit"
        Text = "transport_edit"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Button4 As Button
End Class
