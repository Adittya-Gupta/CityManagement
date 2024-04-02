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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Button4 = New Button()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(47, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 29)
        Label1.TabIndex = 3
        Label1.Text = "Education"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(182, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 23)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(212, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(260, 29)
        Label3.TabIndex = 8
        Label3.Text = "Professor Dashboard"
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.WindowText
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.WhiteSmoke
        Button4.Location = New Point(670, 38)
        Button4.Name = "Button4"
        Button4.Size = New Size(301, 87)
        Button4.TabIndex = 23
        Button4.Text = "ADD NEW COURSE"
        Button4.UseVisualStyleBackColor = False
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
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(1054, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(182, 156)
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' professor_dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1236, 849)
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "professor_dashboard"
        Text = "professor_dashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
