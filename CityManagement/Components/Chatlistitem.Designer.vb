<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chatlistitem
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CurvedLabel1 = New CurvedLabel()
        CurvedLabel2 = New CurvedLabel()
        Label1 = New Label()
        Label3 = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.White
        Label2.Font = New Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(111, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(248, 39)
        Label2.TabIndex = 36
        Label2.Text = "Label2"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = Mask_group
        PictureBox1.Location = New Point(21, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 65)
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
        CurvedLabel1.Size = New Size(466, 104)
        CurvedLabel1.TabIndex = 33
        ' 
        ' CurvedLabel2
        ' 
        CurvedLabel2.BackColor = Color.FromArgb(CByte(50), CByte(0), CByte(0), CByte(0))
        CurvedLabel2.CornerRadius = 25
        CurvedLabel2.Location = New Point(0, 0)
        CurvedLabel2.Name = "CurvedLabel2"
        CurvedLabel2.Size = New Size(463, 111)
        CurvedLabel2.TabIndex = 40
        CurvedLabel2.Text = "CurvedLabel2"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.White
        Label1.Font = New Font("Abhaya Libre Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(111, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(261, 35)
        Label1.TabIndex = 35
        Label1.Text = "Label1"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.White
        Label3.BorderColor = Color.LawnGreen
        Label3.DisabledState.BorderColor = Color.DarkGray
        Label3.DisabledState.CustomBorderColor = Color.DarkGray
        Label3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Label3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Label3.FillColor = Color.Chartreuse
        Label3.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(404, 11)
        Label3.Name = "Label3"
        Label3.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Label3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Label3.Size = New Size(45, 45)
        Label3.TabIndex = 43
        ' 
        ' Chatlistitem
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(CurvedLabel1)
        Controls.Add(CurvedLabel2)
        Cursor = Cursors.Hand
        Name = "Chatlistitem"
        Size = New Size(477, 119)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CurvedLabel1 As CurvedLabel
    Friend WithEvents CurvedLabel2 As CurvedLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Guna.UI2.WinForms.Guna2CircleButton

End Class