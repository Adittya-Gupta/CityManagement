<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChatElement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        CurvedLabel1 = New CurvedLabel()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = Mask_group
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 46)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.AutoSize = True
        CurvedLabel1.BackColor = Color.Transparent
        CurvedLabel1.CornerRadius = 10
        CurvedLabel1.Dock = DockStyle.Left
        CurvedLabel1.Font = New Font("Segoe UI", 14F)
        CurvedLabel1.Location = New Point(0, 0)
        CurvedLabel1.Margin = New Padding(0)
        CurvedLabel1.MinimumSize = New Size(100, 60)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Padding = New Padding(50, 10, 10, 10)
        CurvedLabel1.Size = New Size(100, 60)
        CurvedLabel1.TabIndex = 3
        CurvedLabel1.Text = "hi"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Exo 2", 8.25F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(100, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 20)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' ChatElement
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.Transparent
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(CurvedLabel1)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "ChatElement"
        Size = New Size(181, 61)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CurvedLabel1 As CurvedLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label

End Class