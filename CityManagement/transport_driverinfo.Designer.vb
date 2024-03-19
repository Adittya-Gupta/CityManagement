<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transport_driverinfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transport_driverinfo))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Label6 = New Label()
        Panel3 = New Panel()
        Label5 = New Label()
        PictureBox3 = New PictureBox()
        TextBox4 = New TextBox()
        Label9 = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Button4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(38, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 27)
        Label1.TabIndex = 10
        Label1.Text = "Transport Services"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(271, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 27)
        Label2.TabIndex = 12
        Label2.Text = "Bus"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(357, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 27)
        Label3.TabIndex = 13
        Label3.Text = "Driver Info"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(241, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 23)
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(327, 33)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(24, 23)
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(170), CByte(0), CByte(0), CByte(0))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(163, 86)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1034, 604)
        Panel1.TabIndex = 16
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(152, 81)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(745, 507)
        Panel2.TabIndex = 13
        ' 
        ' Panel4
        ' 
        Panel4.AutoScroll = True
        Panel4.BackColor = Color.FromArgb(CByte(66), CByte(92), CByte(89))
        Panel4.Location = New Point(69, 384)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(587, 102)
        Panel4.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(69, 344)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 27)
        Label6.TabIndex = 25
        Label6.Text = "My Rides"
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.BackColor = Color.FromArgb(CByte(66), CByte(92), CByte(89))
        Panel3.Location = New Point(69, 223)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(587, 102)
        Panel3.TabIndex = 24
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(69, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 27)
        Label5.TabIndex = 23
        Label5.Text = "Ride Requests"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(527, 26)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(153, 152)
        PictureBox3.TabIndex = 22
        PictureBox3.TabStop = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(69, 143)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(254, 35)
        TextBox4.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(69, 101)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 27)
        Label9.TabIndex = 15
        Label9.Text = "Email"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(69, 48)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(254, 35)
        TextBox3.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(69, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(156, 27)
        Label7.TabIndex = 14
        Label7.Text = "Driver's Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(256, 101)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 27)
        Label8.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Centauri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(276, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(473, 42)
        Label4.TabIndex = 8
        Label4.Text = "Driver Info"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Black
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(1095, 16)
        Button4.Name = "Button4"
        Button4.Size = New Size(178, 53)
        Button4.TabIndex = 26
        Button4.Text = "Look for bus"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' transport_driverinfo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1338, 709)
        Controls.Add(Button4)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "transport_driverinfo"
        Text = "transport_driverinfo"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
End Class
