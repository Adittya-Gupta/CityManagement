<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cMakeAppointment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cMakeAppointment))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CurvedLabel5 = New CurvedLabel()
        CurvedLabel14 = New CurvedLabel()
        CurvedLabel3 = New CurvedLabel()
        CurvedLabel1 = New CurvedLabel()
        CurvedLabel7 = New CurvedLabel()
        CurvedLabel4 = New CurvedLabel()
        CurvedLabel6 = New CurvedLabel()
        CurvedLabel2 = New CurvedLabel()
        CurvedLabel8 = New CurvedLabel()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(48, 3)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox1.Size = New Size(109, 130)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' CurvedLabel5
        ' 
        CurvedLabel5.AutoSize = True
        CurvedLabel5.CornerRadius = 10
        CurvedLabel5.Font = New Font("Bahnschrift", 14F)
        CurvedLabel5.Location = New Point(30, 141)
        CurvedLabel5.Name = "CurvedLabel5"
        CurvedLabel5.Size = New Size(166, 23)
        CurvedLabel5.TabIndex = 1
        CurvedLabel5.Text = "Dr. Aditya Agrawal"
        ' 
        ' CurvedLabel14
        ' 
        CurvedLabel14.AutoSize = True
        CurvedLabel14.CornerRadius = 10
        CurvedLabel14.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel14.Location = New Point(16, 187)
        CurvedLabel14.Name = "CurvedLabel14"
        CurvedLabel14.Size = New Size(82, 18)
        CurvedLabel14.TabIndex = 2
        CurvedLabel14.Text = "Experience"
        ' 
        ' CurvedLabel3
        ' 
        CurvedLabel3.AutoSize = True
        CurvedLabel3.CornerRadius = 10
        CurvedLabel3.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel3.Location = New Point(110, 187)
        CurvedLabel3.Name = "CurvedLabel3"
        CurvedLabel3.Size = New Size(57, 18)
        CurvedLabel3.TabIndex = 3
        CurvedLabel3.Text = "05+ yrs"
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.AutoSize = True
        CurvedLabel1.CornerRadius = 10
        CurvedLabel1.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel1.Location = New Point(110, 217)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Size = New Size(40, 18)
        CurvedLabel1.TabIndex = 5
        CurvedLabel1.Text = "Male"
        ' 
        ' CurvedLabel7
        ' 
        CurvedLabel7.AutoSize = True
        CurvedLabel7.CornerRadius = 10
        CurvedLabel7.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel7.Location = New Point(39, 217)
        CurvedLabel7.Name = "CurvedLabel7"
        CurvedLabel7.Size = New Size(56, 18)
        CurvedLabel7.TabIndex = 4
        CurvedLabel7.Text = "Gender"
        ' 
        ' CurvedLabel4
        ' 
        CurvedLabel4.AutoSize = True
        CurvedLabel4.CornerRadius = 10
        CurvedLabel4.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel4.Location = New Point(110, 247)
        CurvedLabel4.Name = "CurvedLabel4"
        CurvedLabel4.Size = New Size(92, 18)
        CurvedLabel4.TabIndex = 7
        CurvedLabel4.Text = "9am to 12pm"
        ' 
        ' CurvedLabel6
        ' 
        CurvedLabel6.AutoSize = True
        CurvedLabel6.CornerRadius = 10
        CurvedLabel6.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel6.Location = New Point(52, 247)
        CurvedLabel6.Name = "CurvedLabel6"
        CurvedLabel6.Size = New Size(40, 18)
        CurvedLabel6.TabIndex = 6
        CurvedLabel6.Text = "Time"
        ' 
        ' CurvedLabel2
        ' 
        CurvedLabel2.AutoSize = True
        CurvedLabel2.CornerRadius = 10
        CurvedLabel2.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel2.Location = New Point(111, 278)
        CurvedLabel2.Name = "CurvedLabel2"
        CurvedLabel2.Size = New Size(16, 18)
        CurvedLabel2.TabIndex = 9
        CurvedLabel2.Text = "3"
        ' 
        ' CurvedLabel8
        ' 
        CurvedLabel8.AutoSize = True
        CurvedLabel8.CornerRadius = 10
        CurvedLabel8.Font = New Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel8.Location = New Point(53, 278)
        CurvedLabel8.Name = "CurvedLabel8"
        CurvedLabel8.Size = New Size(51, 18)
        CurvedLabel8.TabIndex = 8
        CurvedLabel8.Text = "Rating"
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges3
        Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), Image)
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(133, 279)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2PictureBox2.Size = New Size(16, 16)
        Guna2PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox2.TabIndex = 10
        Guna2PictureBox2.TabStop = False
        ' 
        ' cMakeAppointment
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(Guna2PictureBox2)
        Controls.Add(CurvedLabel2)
        Controls.Add(CurvedLabel8)
        Controls.Add(CurvedLabel4)
        Controls.Add(CurvedLabel6)
        Controls.Add(CurvedLabel1)
        Controls.Add(CurvedLabel7)
        Controls.Add(CurvedLabel3)
        Controls.Add(CurvedLabel14)
        Controls.Add(CurvedLabel5)
        Controls.Add(Guna2PictureBox1)
        Name = "cMakeAppointment"
        Size = New Size(210, 311)
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CurvedLabel5 As CurvedLabel
    Friend WithEvents CurvedLabel14 As CurvedLabel
    Friend WithEvents CurvedLabel3 As CurvedLabel
    Friend WithEvents CurvedLabel1 As CurvedLabel
    Friend WithEvents CurvedLabel7 As CurvedLabel
    Friend WithEvents CurvedLabel4 As CurvedLabel
    Friend WithEvents CurvedLabel6 As CurvedLabel
    Friend WithEvents CurvedLabel2 As CurvedLabel
    Friend WithEvents CurvedLabel8 As CurvedLabel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox

End Class
