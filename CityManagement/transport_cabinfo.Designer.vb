<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transport_cabinfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transport_cabinfo))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        TextBox4 = New TextBox()
        Label9 = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label6 = New Label()
        TextBox2 = New TextBox()
        Button4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(26, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 27)
        Label1.TabIndex = 10
        Label1.Text = "Transport Services"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(226, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 23)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(256, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 27)
        Label2.TabIndex = 12
        Label2.Text = "Cab Service"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(394, 21)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(24, 23)
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(424, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 27)
        Label3.TabIndex = 14
        Label3.Text = "Cab Info"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(170), CByte(0), CByte(0), CByte(0))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(158, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1034, 604)
        Panel1.TabIndex = 15
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(152, 76)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(745, 512)
        Panel2.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(125, 131)
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
        Label9.Location = New Point(125, 101)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 27)
        Label9.TabIndex = 15
        Label9.Text = "Vacancies"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(125, 48)
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
        Label7.Location = New Point(125, 18)
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
        Label4.Location = New Point(318, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(358, 42)
        Label4.TabIndex = 8
        Label4.Text = "Cab Info"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(125, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 27)
        Label5.TabIndex = 22
        Label5.Text = "Car Number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(125, 234)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(254, 35)
        TextBox1.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(125, 299)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 27)
        Label6.TabIndex = 24
        Label6.Text = "Car Model"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(125, 338)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(254, 35)
        TextBox2.TabIndex = 25
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Black
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(1144, 14)
        Button4.Name = "Button4"
        Button4.Size = New Size(178, 53)
        Button4.TabIndex = 26
        Button4.Text = "Find cab"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' transport_cabinfo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1370, 689)
        Controls.Add(Button4)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "transport_cabinfo"
        Text = "transport_cabinfo"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
End Class
