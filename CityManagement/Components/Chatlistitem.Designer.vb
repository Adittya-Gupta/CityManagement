<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chatlistitem
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
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CurvedLabel1 = New CurvedLabel()
        CurvedLabel2 = New CurvedLabel()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.White
        Label2.Font = New Font("Exo 2 Semi Bold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(133, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(365, 39)
        Label2.TabIndex = 36
        Label2.Text = "Label2"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Electrician2
        PictureBox1.Location = New Point(25, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(93, 93)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 34
        PictureBox1.TabStop = False
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.BackColor = Color.White
        CurvedLabel1.CornerRadius = 20
        CurvedLabel1.Location = New Point(0, 0)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Size = New Size(510, 124)
        CurvedLabel1.TabIndex = 33
        ' 
        ' CurvedLabel2
        ' 
        CurvedLabel2.BackColor = Color.FromArgb(CByte(50), CByte(0), CByte(0), CByte(0))
        CurvedLabel2.CornerRadius = 25
        CurvedLabel2.Location = New Point(0, 0)
        CurvedLabel2.Name = "CurvedLabel2"
        CurvedLabel2.Size = New Size(516, 129)
        CurvedLabel2.TabIndex = 40
        CurvedLabel2.Text = "CurvedLabel2"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.White
        Label1.Font = New Font("Exo 2", 11F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(133, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(304, 35)
        Label1.TabIndex = 35
        Label1.Text = "Label1"
        ' 
        ' Chatlistitem
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(CurvedLabel1)
        Controls.Add(CurvedLabel2)
        Name = "Chatlistitem"
        Size = New Size(521, 138)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CurvedLabel1 As CurvedLabel
    Friend WithEvents CurvedLabel2 As CurvedLabel
    Friend WithEvents Label1 As Label

End Class
