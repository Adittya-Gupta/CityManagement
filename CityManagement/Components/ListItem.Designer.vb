<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListItem
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
        CurvedLabel2 = New CurvedLabel()
        CurvedLabel1 = New CurvedLabel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        Rating1 = New Rating()
        Label5 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CurvedLabel2
        ' 
        CurvedLabel2.BackColor = SystemColors.WindowFrame
        CurvedLabel2.CornerRadius = 25
        CurvedLabel2.Location = New Point(3, 0)
        CurvedLabel2.Name = "CurvedLabel2"
        CurvedLabel2.Size = New Size(997, 130)
        CurvedLabel2.TabIndex = 28
        CurvedLabel2.Text = "CurvedLabel2"
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.BackColor = Color.White
        CurvedLabel1.CornerRadius = 20
        CurvedLabel1.Location = New Point(3, 0)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Size = New Size(993, 124)
        CurvedLabel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Electrician2
        PictureBox1.Location = New Point(32, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(93, 93)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.White
        Label1.Font = New Font("Exo 2", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(136, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(406, 25)
        Label1.TabIndex = 2
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.White
        Label2.Font = New Font("Exo 2 Semi Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(171, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(464, 25)
        Label2.TabIndex = 3
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.White
        Label3.Font = New Font("Exo 2 Thin", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(136, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(406, 25)
        Label3.TabIndex = 4
        Label3.Text = "Label3"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Location
        PictureBox2.Location = New Point(136, 43)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(15, 22)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Rating1
        ' 
        Rating1.Location = New Point(95, 7)
        Rating1.Name = "Rating1"
        Rating1.RatingValue = 5R
        Rating1.Size = New Size(35, 25)
        Rating1.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.White
        Label5.Image = My.Resources.Resources.Frame_1051
        Label5.Location = New Point(721, 70)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 34)
        Label5.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.White
        Label6.Image = My.Resources.Resources.Frame_1050
        Label6.Location = New Point(803, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 34)
        Label6.TabIndex = 31
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.White
        Label4.Image = My.Resources.Resources.Frame_1013
        Label4.Location = New Point(715, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(224, 45)
        Label4.TabIndex = 32
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.FromArgb(CByte(107), CByte(255), CByte(11))
        Label7.Font = New Font("Exo 2", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(770, 29)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 26)
        Label7.TabIndex = 23
        Label7.Text = "+91 9149502910"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ListItem
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Rating1)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(CurvedLabel1)
        Controls.Add(CurvedLabel2)
        Name = "ListItem"
        Size = New Size(1001, 131)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CurvedLabel2 As CurvedLabel
    Friend WithEvents CurvedLabel1 As CurvedLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Rating1 As Rating
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label

End Class
