<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class makeAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(makeAppointment))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        ComboBox2 = New ComboBox()
        RichTextBox1 = New RichTextBox()
        ComboBox3 = New ComboBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.Gray
        ComboBox2.DrawMode = DrawMode.OwnerDrawVariable
        ComboBox2.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox2.ForeColor = Color.White
        ComboBox2.FormattingEnabled = True
        ComboBox2.IntegralHeight = False
        ComboBox2.ItemHeight = 24
        ComboBox2.Location = New Point(66, 59)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.RightToLeft = RightToLeft.No
        ComboBox2.Size = New Size(181, 30)
        ComboBox2.TabIndex = 1
        ComboBox2.Text = "     Specialisation"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.DimGray
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Comic Sans MS", 12F)
        RichTextBox1.ForeColor = Color.Transparent
        RichTextBox1.Location = New Point(272, 129)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(251, 28)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = "            Available Doctors"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = Color.Gray
        ComboBox3.Font = New Font("Comic Sans MS", 11.25F)
        ComboBox3.ForeColor = Color.Transparent
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(653, 84)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(121, 28)
        ComboBox3.TabIndex = 4
        ComboBox3.Text = "          Date"
        ' 
        ' Button1
        ' 
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(666, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 23)
        Button1.TabIndex = 5
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightGray
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(742, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(14, 11)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = SystemColors.InactiveCaptionText
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DefaultAutoSize = True
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = SystemColors.Info
        Guna2Button1.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.Black
        Guna2Button1.Location = New Point(3, 7)
        Guna2Button1.Margin = New Padding(0)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.PressedColor = SystemColors.Info
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(67, 24)
        Guna2Button1.TabIndex = 8
        Guna2Button1.Text = "Health"
        Guna2Button1.TextAlign = HorizontalAlignment.Right
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BackColor = SystemColors.InactiveCaptionText
        Guna2Button2.CustomizableEdges = CustomizableEdges3
        Guna2Button2.DefaultAutoSize = True
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = SystemColors.Info
        Guna2Button2.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2Button2.ForeColor = Color.Black
        Guna2Button2.Location = New Point(56, 7)
        Guna2Button2.Margin = New Padding(0)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.PressedColor = SystemColors.Info
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button2.Size = New Size(116, 24)
        Guna2Button2.TabIndex = 9
        Guna2Button2.Text = "Specialisation"
        Guna2Button2.TextAlign = HorizontalAlignment.Right
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges5
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(57, 12)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2PictureBox1.Size = New Size(15, 15)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox1.TabIndex = 11
        Guna2PictureBox1.TabStop = False
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges7
        Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), Image)
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(159, 12)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2PictureBox2.Size = New Size(15, 15)
        Guna2PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox2.TabIndex = 12
        Guna2PictureBox2.TabStop = False
        ' 
        ' Guna2PictureBox3
        ' 
        Guna2PictureBox3.CustomizableEdges = CustomizableEdges9
        Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), Image)
        Guna2PictureBox3.ImageRotate = 0F
        Guna2PictureBox3.Location = New Point(233, 12)
        Guna2PictureBox3.Margin = New Padding(0)
        Guna2PictureBox3.Name = "Guna2PictureBox3"
        Guna2PictureBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2PictureBox3.Size = New Size(15, 15)
        Guna2PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox3.TabIndex = 14
        Guna2PictureBox3.TabStop = False
        ' 
        ' Guna2Button4
        ' 
        Guna2Button4.BackColor = SystemColors.InactiveCaptionText
        Guna2Button4.CustomizableEdges = CustomizableEdges11
        Guna2Button4.DefaultAutoSize = True
        Guna2Button4.DisabledState.BorderColor = Color.DarkGray
        Guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button4.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button4.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button4.FillColor = SystemColors.Info
        Guna2Button4.Font = New Font("Consolas", 8.25F)
        Guna2Button4.ForeColor = Color.Black
        Guna2Button4.ImageSize = New Size(0, 0)
        Guna2Button4.Location = New Point(248, 9)
        Guna2Button4.Margin = New Padding(0)
        Guna2Button4.Name = "Guna2Button4"
        Guna2Button4.PressedColor = SystemColors.Info
        Guna2Button4.PressedDepth = 0
        Guna2Button4.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Button4.Size = New Size(26, 10)
        Guna2Button4.TabIndex = 15
        ' 
        ' makeAppointment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(800, 450)
        Controls.Add(Guna2Button4)
        Controls.Add(Guna2PictureBox3)
        Controls.Add(Guna2PictureBox2)
        Controls.Add(Guna2PictureBox1)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2Button1)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(ComboBox3)
        Controls.Add(RichTextBox1)
        Controls.Add(ComboBox2)
        ForeColor = SystemColors.MenuHighlight
        FormBorderStyle = FormBorderStyle.None
        Name = "makeAppointment"
        Text = "makeAppointment"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
End Class
