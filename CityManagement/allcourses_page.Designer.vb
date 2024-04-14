<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allcourses_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(allcourses_page))
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        PictureBox6 = New PictureBox()
        Education = New Button()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(151, 26)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(21, 17)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Black
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.WhiteSmoke
        Button4.Location = New Point(495, 9)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(360, 48)
        Button4.TabIndex = 22
        Button4.Text = "what do you want to learn?"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(851, 9)
        PictureBox6.Margin = New Padding(3, 2, 3, 2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(75, 48)
        PictureBox6.TabIndex = 44
        PictureBox6.TabStop = False
        ' 
        ' Education
        ' 
        Education.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Education.ForeColor = SystemColors.ActiveBorder
        Education.Location = New Point(24, 18)
        Education.Margin = New Padding(3, 2, 3, 2)
        Education.Name = "Education"
        Education.Size = New Size(122, 31)
        Education.TabIndex = 46
        Education.Text = "Education"
        Education.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(178, 20)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 29)
        Button1.TabIndex = 47
        Button1.Text = "Courses"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' allcourses_page
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(953, 535)
        Controls.Add(Button1)
        Controls.Add(Education)
        Controls.Add(PictureBox6)
        Controls.Add(Button4)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "allcourses_page"
        Text = "allcourses_page"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Education As Button
    Friend WithEvents Button1 As Button
End Class
