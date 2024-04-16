<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class education_landing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(education_landing))
        PictureBox4 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Btnstud = New Button()
        Btnteach = New Button()
        Button3 = New Button()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(62, 536)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(149, 135)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(223, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(869, 483)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(661, 536)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(155, 135)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Btnstud
        ' 
        Btnstud.BackColor = Color.Black
        Btnstud.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnstud.ForeColor = Color.White
        Btnstud.Location = New Point(837, 585)
        Btnstud.Margin = New Padding(3, 4, 3, 4)
        Btnstud.Name = "Btnstud"
        Btnstud.Size = New Size(198, 44)
        Btnstud.TabIndex = 4
        Btnstud.Text = "Student"
        Btnstud.UseVisualStyleBackColor = False
        ' 
        ' Btnteach
        ' 
        Btnteach.BackColor = Color.Black
        Btnteach.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnteach.ForeColor = Color.White
        Btnteach.Location = New Point(235, 585)
        Btnteach.Margin = New Padding(3, 4, 3, 4)
        Btnteach.Name = "Btnteach"
        Btnteach.Size = New Size(198, 44)
        Btnteach.TabIndex = 5
        Btnteach.Text = "Teacher"
        Btnteach.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Lucida Console", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(-5, -3)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(232, 489)
        Button3.TabIndex = 6
        Button3.Text = "WELCOME TO EDUCATION MODULE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' education_landing
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1089, 713)
        Controls.Add(Button3)
        Controls.Add(Btnteach)
        Controls.Add(Btnstud)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "education_landing"
        Text = "election_landing"
        WindowState = FormWindowState.Maximized
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btnstud As Button
    Friend WithEvents Btnteach As Button
    Friend WithEvents Button3 As Button
End Class
