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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Button4 = New Button()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(28, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 29)
        Label1.TabIndex = 2
        Label1.Text = "Education"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(163, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 23)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(206, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 29)
        Label3.TabIndex = 7
        Label3.Text = "Courses"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Black
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.WhiteSmoke
        Button4.Location = New Point(714, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(351, 62)
        Button4.TabIndex = 22
        Button4.Text = "what do you want to learn?"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(1138, 12)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(86, 62)
        PictureBox6.TabIndex = 44
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = SystemColors.ActiveCaptionText
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox7.BorderStyle = BorderStyle.Fixed3D
        PictureBox7.Location = New Point(1062, 12)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(70, 62)
        PictureBox7.TabIndex = 45
        PictureBox7.TabStop = False
        ' 
        ' allcourses_page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1236, 849)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(Button4)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "allcourses_page"
        Text = "allcourses_page"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
