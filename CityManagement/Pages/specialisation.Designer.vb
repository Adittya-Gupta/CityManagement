<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class specialisation
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
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(specialisation))
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        ComboBox2 = New ComboBox()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        ComboBox1 = New ComboBox()
        ComboBox3 = New ComboBox()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2GradientTileButton4 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Guna2GradientTileButton3 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Guna2GradientTileButton2 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Guna2GradientTileButton1 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        RichTextBox2 = New RichTextBox()
        Panel1 = New Panel()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        ComboBox2.Font = New Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.ForeColor = Color.Black
        ComboBox2.FormattingEnabled = True
        ComboBox2.ImeMode = ImeMode.NoControl
        ComboBox2.ItemHeight = 24
        ComboBox2.Items.AddRange(New Object() {"Heart Center", "Cardiology", "Orthopedics", "Psychiatrist", "Neurologist", "Ophthalmologist", "Dermatologist"})
        ComboBox2.Location = New Point(427, 112)
        ComboBox2.Margin = New Padding(3, 4, 3, 4)
        ComboBox2.MaxLength = 20
        ComboBox2.Name = "ComboBox2"
        ComboBox2.RightToLeft = RightToLeft.No
        ComboBox2.Size = New Size(323, 32)
        ComboBox2.TabIndex = 31
        ComboBox2.Text = "    Select  Specialisation"
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.AutoSize = True
        Guna2TextBox1.BorderThickness = 0
        Guna2TextBox1.CustomizableEdges = CustomizableEdges13
        Guna2TextBox1.DefaultText = "Doctors of City " & vbCrLf & "as per Specialisation" & vbCrLf
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2TextBox1.ForeColor = Color.Black
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(82, 101)
        Guna2TextBox1.Margin = New Padding(5)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2TextBox1.Size = New Size(343, 51)
        Guna2TextBox1.TabIndex = 32
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.BorderRadius = 1
        Guna2PictureBox2.BorderStyle = BorderStyle.FixedSingle
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges11
        Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), Image)
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(819, 109)
        Guna2PictureBox2.Margin = New Padding(3, 4, 3, 4)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2PictureBox2.Size = New Size(25, 31)
        Guna2PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox2.TabIndex = 34
        Guna2PictureBox2.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 10F)
        ComboBox1.ForeColor = Color.Black
        ComboBox1.FormattingEnabled = True
        ComboBox1.ItemHeight = 23
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4"})
        ComboBox1.Location = New Point(843, 109)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(86, 31)
        ComboBox1.TabIndex = 35
        ComboBox1.Text = " Rating"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Segoe UI", 11F)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox3.Location = New Point(974, 106)
        ComboBox3.Margin = New Padding(3, 4, 3, 4)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(104, 33)
        ComboBox3.TabIndex = 36
        ComboBox3.Text = " Gender"
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BorderRadius = 1
        Guna2PictureBox1.BorderStyle = BorderStyle.FixedSingle
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges9
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(950, 106)
        Guna2PictureBox1.Margin = New Padding(3, 4, 3, 4)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2PictureBox1.Size = New Size(25, 33)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox1.TabIndex = 45
        Guna2PictureBox1.TabStop = False
        ' 
        ' Guna2GradientTileButton4
        ' 
        Guna2GradientTileButton4.CustomizableEdges = CustomizableEdges1
        Guna2GradientTileButton4.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientTileButton4.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientTileButton4.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton4.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton4.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientTileButton4.FillColor = Color.Black
        Guna2GradientTileButton4.FillColor2 = Color.Black
        Guna2GradientTileButton4.Font = New Font("Segoe UI", 13F)
        Guna2GradientTileButton4.ForeColor = Color.White
        Guna2GradientTileButton4.Location = New Point(918, 12)
        Guna2GradientTileButton4.Margin = New Padding(3, 4, 3, 4)
        Guna2GradientTileButton4.Name = "Guna2GradientTileButton4"
        Guna2GradientTileButton4.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientTileButton4.Size = New Size(206, 47)
        Guna2GradientTileButton4.TabIndex = 50
        Guna2GradientTileButton4.Text = "Work"
        ' 
        ' Guna2GradientTileButton3
        ' 
        Guna2GradientTileButton3.CustomizableEdges = CustomizableEdges3
        Guna2GradientTileButton3.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientTileButton3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientTileButton3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton3.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientTileButton3.FillColor = Color.Black
        Guna2GradientTileButton3.FillColor2 = Color.Black
        Guna2GradientTileButton3.Font = New Font("Segoe UI", 13F)
        Guna2GradientTileButton3.ForeColor = Color.White
        Guna2GradientTileButton3.Location = New Point(623, 11)
        Guna2GradientTileButton3.Margin = New Padding(3, 4, 3, 4)
        Guna2GradientTileButton3.Name = "Guna2GradientTileButton3"
        Guna2GradientTileButton3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientTileButton3.Size = New Size(206, 47)
        Guna2GradientTileButton3.TabIndex = 49
        Guna2GradientTileButton3.Text = "Health Record"
        ' 
        ' Guna2GradientTileButton2
        ' 
        Guna2GradientTileButton2.CustomizableEdges = CustomizableEdges5
        Guna2GradientTileButton2.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientTileButton2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientTileButton2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton2.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientTileButton2.FillColor = Color.Black
        Guna2GradientTileButton2.FillColor2 = Color.Black
        Guna2GradientTileButton2.Font = New Font("Segoe UI", 13F)
        Guna2GradientTileButton2.ForeColor = Color.White
        Guna2GradientTileButton2.Location = New Point(314, 9)
        Guna2GradientTileButton2.Margin = New Padding(3, 4, 3, 4)
        Guna2GradientTileButton2.Name = "Guna2GradientTileButton2"
        Guna2GradientTileButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2GradientTileButton2.Size = New Size(206, 47)
        Guna2GradientTileButton2.TabIndex = 48
        Guna2GradientTileButton2.Text = "Hospitals"
        ' 
        ' Guna2GradientTileButton1
        ' 
        Guna2GradientTileButton1.CustomizableEdges = CustomizableEdges7
        Guna2GradientTileButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientTileButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientTileButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientTileButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientTileButton1.FillColor = Color.Black
        Guna2GradientTileButton1.FillColor2 = Color.Black
        Guna2GradientTileButton1.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Guna2GradientTileButton1.ForeColor = Color.White
        Guna2GradientTileButton1.Location = New Point(30, 9)
        Guna2GradientTileButton1.Margin = New Padding(3, 4, 3, 4)
        Guna2GradientTileButton1.Name = "Guna2GradientTileButton1"
        Guna2GradientTileButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2GradientTileButton1.Size = New Size(231, 47)
        Guna2GradientTileButton1.TabIndex = 47
        Guna2GradientTileButton1.Text = "Specialisations"
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = Color.Black
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Location = New Point(-26, 0)
        RichTextBox2.Margin = New Padding(3, 4, 3, 4)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(1442, 64)
        RichTextBox2.TabIndex = 46
        RichTextBox2.Text = ""
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(71, 184)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(998, 541)
        Panel1.TabIndex = 51
        ' 
        ' specialisation
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 760)
        Controls.Add(Panel1)
        Controls.Add(Guna2GradientTileButton4)
        Controls.Add(Guna2GradientTileButton3)
        Controls.Add(Guna2GradientTileButton2)
        Controls.Add(Guna2GradientTileButton1)
        Controls.Add(RichTextBox2)
        Controls.Add(Guna2PictureBox1)
        Controls.Add(Guna2PictureBox2)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox1)
        Controls.Add(Guna2TextBox1)
        Controls.Add(ComboBox2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "specialisation"
        Text = "Form1"
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Guna2GradientTileButton4 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2GradientTileButton3 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2GradientTileButton2 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2GradientTileButton1 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Panel1 As Panel
End Class
