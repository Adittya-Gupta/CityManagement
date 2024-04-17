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
        components = New ComponentModel.Container()
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
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        ComboBox2 = New ComboBox()
        PictureBox1 = New PictureBox()
        CurvedBorderLabel1 = New CurvedBorderLabel(components)
        CurvedBorderLabel2 = New CurvedBorderLabel(components)
        Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Guna2ResizeForm1 = New Guna.UI2.WinForms.Guna2ResizeForm(components)
        RichTextBox2 = New RichTextBox()
        Guna2GradientTileButton1 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Guna2GradientTileButton2 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Guna2GradientTileButton3 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Guna2GradientTileButton4 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        ComboBox2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        ComboBox2.ForeColor = Color.Black
        ComboBox2.FormattingEnabled = True
        ComboBox2.ImeMode = ImeMode.NoControl
        ComboBox2.ItemHeight = 31
        ComboBox2.Items.AddRange(New Object() {"Cardiology", "Orthopedics", "Psychiatrist", "Neurologist", "Ophthalmologist", "Dermatologist"})
        ComboBox2.Location = New Point(809, 82)
        ComboBox2.Margin = New Padding(3, 4, 3, 4)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.RightToLeft = RightToLeft.No
        ComboBox2.Size = New Size(234, 39)
        ComboBox2.TabIndex = 1
        ComboBox2.Text = "      Specialisation"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightGray
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1390, 56)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(16, 15)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Guna2ContextMenuStrip1
        ' 
        Guna2ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(CByte(151), CByte(143), CByte(255))
        Guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro
        Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White
        Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White
        Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro
        Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        Guna2ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = Color.Black
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Location = New Point(-24, -1)
        RichTextBox2.Margin = New Padding(3, 4, 3, 4)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(1442, 64)
        RichTextBox2.TabIndex = 18
        RichTextBox2.Text = ""
        ' 
        ' Guna2GradientTileButton1
        ' 
        Guna2GradientTileButton1.CustomizableEdges = CustomizableEdges1
        Guna2GradientTileButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientTileButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientTileButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientTileButton1.FillColor = Color.Black
        Guna2GradientTileButton1.FillColor2 = Color.Black
        Guna2GradientTileButton1.Font = New Font("Segoe UI", 13F)
        Guna2GradientTileButton1.ForeColor = Color.White
        Guna2GradientTileButton1.Location = New Point(53, 9)
        Guna2GradientTileButton1.Margin = New Padding(3, 4, 3, 4)
        Guna2GradientTileButton1.Name = "Guna2GradientTileButton1"
        Guna2GradientTileButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientTileButton1.Size = New Size(165, 33)
        Guna2GradientTileButton1.TabIndex = 19
        Guna2GradientTileButton1.Text = "Specialisations"
        ' 
        ' Guna2GradientTileButton2
        ' 
        Guna2GradientTileButton2.CustomizableEdges = CustomizableEdges3
        Guna2GradientTileButton2.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientTileButton2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientTileButton2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton2.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientTileButton2.FillColor = Color.Black
        Guna2GradientTileButton2.FillColor2 = Color.Black
        Guna2GradientTileButton2.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Guna2GradientTileButton2.ForeColor = Color.White
        Guna2GradientTileButton2.Location = New Point(305, 7)
        Guna2GradientTileButton2.Margin = New Padding(3, 4, 3, 4)
        Guna2GradientTileButton2.Name = "Guna2GradientTileButton2"
        Guna2GradientTileButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientTileButton2.Size = New Size(166, 33)
        Guna2GradientTileButton2.TabIndex = 20
        Guna2GradientTileButton2.Text = "Hospitals"
        ' 
        ' Guna2GradientTileButton3
        ' 
        Guna2GradientTileButton3.CustomizableEdges = CustomizableEdges5
        Guna2GradientTileButton3.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientTileButton3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientTileButton3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton3.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientTileButton3.FillColor = Color.Black
        Guna2GradientTileButton3.FillColor2 = Color.Black
        Guna2GradientTileButton3.Font = New Font("Segoe UI", 13F)
        Guna2GradientTileButton3.ForeColor = Color.White
        Guna2GradientTileButton3.Location = New Point(592, 7)
        Guna2GradientTileButton3.Margin = New Padding(3, 4, 3, 4)
        Guna2GradientTileButton3.Name = "Guna2GradientTileButton3"
        Guna2GradientTileButton3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2GradientTileButton3.Size = New Size(191, 35)
        Guna2GradientTileButton3.TabIndex = 21
        Guna2GradientTileButton3.Text = "Health Record"
        ' 
        ' Guna2GradientTileButton4
        ' 
        Guna2GradientTileButton4.CustomizableEdges = CustomizableEdges7
        Guna2GradientTileButton4.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientTileButton4.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientTileButton4.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton4.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton4.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientTileButton4.FillColor = Color.Black
        Guna2GradientTileButton4.FillColor2 = Color.Black
        Guna2GradientTileButton4.Font = New Font("Segoe UI", 13F)
        Guna2GradientTileButton4.ForeColor = Color.White
        Guna2GradientTileButton4.Location = New Point(849, 7)
        Guna2GradientTileButton4.Margin = New Padding(3, 4, 3, 4)
        Guna2GradientTileButton4.Name = "Guna2GradientTileButton4"
        Guna2GradientTileButton4.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2GradientTileButton4.Size = New Size(180, 35)
        Guna2GradientTileButton4.TabIndex = 22
        Guna2GradientTileButton4.Text = "Work"
        ' 
        ' Guna2DateTimePicker1
        ' 
        Guna2DateTimePicker1.Checked = True
        Guna2DateTimePicker1.CustomizableEdges = CustomizableEdges9
        Guna2DateTimePicker1.FillColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        Guna2DateTimePicker1.Font = New Font("Segoe UI", 14F)
        Guna2DateTimePicker1.ForeColor = Color.Black
        Guna2DateTimePicker1.Format = DateTimePickerFormat.Long
        Guna2DateTimePicker1.ImeMode = ImeMode.NoControl
        Guna2DateTimePicker1.Location = New Point(290, 86)
        Guna2DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2DateTimePicker1.Size = New Size(181, 30)
        Guna2DateTimePicker1.TabIndex = 24
        Guna2DateTimePicker1.Value = New Date(2024, 3, 29, 0, 0, 0, 0)
        ' 
        ' Guna2Button4
        ' 
        Guna2Button4.CustomizableEdges = CustomizableEdges11
        Guna2Button4.DisabledState.BorderColor = Color.DarkGray
        Guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button4.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button4.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button4.FillColor = Color.Black
        Guna2Button4.Font = New Font("Segoe UI Semibold", 13F, FontStyle.Bold)
        Guna2Button4.ForeColor = Color.White
        Guna2Button4.ImageAlign = HorizontalAlignment.Left
        Guna2Button4.Location = New Point(524, 145)
        Guna2Button4.Margin = New Padding(3, 4, 3, 4)
        Guna2Button4.Name = "Guna2Button4"
        Guna2Button4.PressedColor = Color.Lime
        Guna2Button4.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Button4.Size = New Size(102, 38)
        Guna2Button4.TabIndex = 25
        Guna2Button4.Text = "Apply"
        Guna2Button4.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(545, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(254, 32)
        Label1.TabIndex = 28
        Label1.Text = "Doctor's Specialisation"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(43, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(241, 32)
        Label2.TabIndex = 29
        Label2.Text = "Date of Appointment"
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(62, 205)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 469)
        Panel1.TabIndex = 30
        ' 
        ' Guna2TileButton1
        ' 
        Guna2TileButton1.CustomizableEdges = CustomizableEdges13
        Guna2TileButton1.DefaultAutoSize = True
        Guna2TileButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2TileButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2TileButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2TileButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2TileButton1.FillColor = Color.Lime
        Guna2TileButton1.Font = New Font("Bahnschrift SemiBold", 12F, FontStyle.Bold)
        Guna2TileButton1.ForeColor = Color.Black
        Guna2TileButton1.Location = New Point(447, 695)
        Guna2TileButton1.Margin = New Padding(3, 4, 3, 4)
        Guna2TileButton1.Name = "Guna2TileButton1"
        Guna2TileButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2TileButton1.Size = New Size(204, 32)
        Guna2TileButton1.TabIndex = 31
        Guna2TileButton1.Text = "Make Appointment"
        ' 
        ' makeAppointment
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 760)
        Controls.Add(Guna2TileButton1)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Guna2Button4)
        Controls.Add(Guna2DateTimePicker1)
        Controls.Add(Guna2GradientTileButton4)
        Controls.Add(Guna2GradientTileButton3)
        Controls.Add(Guna2GradientTileButton2)
        Controls.Add(Guna2GradientTileButton1)
        Controls.Add(RichTextBox2)
        Controls.Add(PictureBox1)
        Controls.Add(ComboBox2)
        ForeColor = SystemColors.MenuHighlight
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "makeAppointment"
        Text = "makeAppointment"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CurvedBorderLabel1 As CurvedBorderLabel
    Friend WithEvents CurvedBorderLabel2 As CurvedBorderLabel
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Guna2ResizeForm1 As Guna.UI2.WinForms.Guna2ResizeForm
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Guna2GradientTileButton1 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2GradientTileButton2 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2GradientTileButton3 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2GradientTileButton4 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CurvedBorderLabel3 As CurvedBorderLabel

    Friend WithEvents CurvedBorderLabel5 As CurvedBorderLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
End Class
