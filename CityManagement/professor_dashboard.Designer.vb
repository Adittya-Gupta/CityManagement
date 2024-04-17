<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class professor_dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(professor_dashboard))
        PictureBox1 = New PictureBox()
        Btnadd = New Button()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Education = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(166, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 23)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Btnadd
        ' 
        Btnadd.BackColor = SystemColors.WindowText
        Btnadd.FlatStyle = FlatStyle.Popup
        Btnadd.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnadd.ForeColor = Color.WhiteSmoke
        Btnadd.Location = New Point(566, 29)
        Btnadd.Name = "Btnadd"
        Btnadd.Size = New Size(301, 87)
        Btnadd.TabIndex = 23
        Btnadd.Text = "ADD NEW COURSE"
        Btnadd.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Location = New Point(81, 156)
        Button1.Name = "Button1"
        Button1.Size = New Size(176, 60)
        Button1.TabIndex = 24
        Button1.Text = "My Courses"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(873, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(182, 156)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' Education
        ' 
        Education.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Education.ForeColor = SystemColors.ActiveBorder
        Education.Location = New Point(21, 12)
        Education.Name = "Education"
        Education.Size = New Size(139, 41)
        Education.TabIndex = 47
        Education.Text = "Education"
        Education.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(206, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(209, 39)
        Button2.TabIndex = 48
        Button2.Text = "Professor Dashboard"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' professor_dashboard
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 760)
        Controls.Add(Button2)
        Controls.Add(Education)
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        Controls.Add(Btnadd)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "professor_dashboard"
        Text = "professor_dashboard"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btnadd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Education As Button
    Friend WithEvents Button2 As Button
End Class
