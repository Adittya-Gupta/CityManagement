<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryItem
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
        Rating1 = New Rating()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CurvedLabel1 = New CurvedLabel()
        CurvedLabel3 = New CurvedLabel()
        CurvedLabel4 = New CurvedLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CurvedLabel2
        ' 
        CurvedLabel2.BackColor = SystemColors.WindowFrame
        CurvedLabel2.CornerRadius = 25
        CurvedLabel2.Location = New Point(0, 0)
        CurvedLabel2.Name = "CurvedLabel2"
        CurvedLabel2.Size = New Size(441, 128)
        CurvedLabel2.TabIndex = 40
        CurvedLabel2.Text = "CurvedLabel2"
        ' 
        ' Rating1
        ' 
        Rating1.Location = New Point(92, 7)
        Rating1.Name = "Rating1"
        Rating1.RatingValue = 5R
        Rating1.Size = New Size(35, 25)
        Rating1.TabIndex = 41
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Electrician2
        PictureBox1.Location = New Point(29, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(93, 93)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(133, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(278, 25)
        Label1.TabIndex = 32
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.White
        Label2.Font = New Font("Exo 2", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(133, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(289, 25)
        Label2.TabIndex = 33
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.White
        Label3.Font = New Font("Abhaya Libre Medium", 9F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(133, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(278, 25)
        Label3.TabIndex = 34
        Label3.Text = "Label3"
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.BackColor = Color.White
        CurvedLabel1.CornerRadius = 20
        CurvedLabel1.Location = New Point(0, 0)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Size = New Size(438, 124)
        CurvedLabel1.TabIndex = 30
        ' 
        ' CurvedLabel3
        ' 
        CurvedLabel3.BackColor = Color.FromArgb(CByte(254), CByte(186), CByte(49))
        CurvedLabel3.CornerRadius = 20
        CurvedLabel3.Font = New Font("Exo 2", 18F)
        CurvedLabel3.ForeColor = Color.White
        CurvedLabel3.Location = New Point(553, 25)
        CurvedLabel3.Name = "CurvedLabel3"
        CurvedLabel3.Padding = New Padding(0, 5, 0, 0)
        CurvedLabel3.Size = New Size(199, 65)
        CurvedLabel3.TabIndex = 42
        CurvedLabel3.Text = "EnquirySent"
        CurvedLabel3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' CurvedLabel4
        ' 
        CurvedLabel4.BackColor = Color.FromArgb(CByte(254), CByte(0), CByte(0))
        CurvedLabel4.CornerRadius = 20
        CurvedLabel4.Font = New Font("Exo 2", 20F)
        CurvedLabel4.ForeColor = Color.White
        CurvedLabel4.Location = New Point(853, 25)
        CurvedLabel4.Name = "CurvedLabel4"
        CurvedLabel4.Padding = New Padding(0, 2, 0, 0)
        CurvedLabel4.Size = New Size(199, 65)
        CurvedLabel4.TabIndex = 43
        CurvedLabel4.Text = "Withdraw"
        CurvedLabel4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' HistoryItem
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(CurvedLabel4)
        Controls.Add(CurvedLabel3)
        Controls.Add(Rating1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(CurvedLabel1)
        Controls.Add(CurvedLabel2)
        Name = "HistoryItem"
        Size = New Size(1075, 129)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CurvedLabel2 As CurvedLabel
    Friend WithEvents Rating1 As Rating
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CurvedLabel1 As CurvedLabel
    Friend WithEvents CurvedLabel3 As CurvedLabel
    Friend WithEvents CurvedLabel4 As CurvedLabel

End Class
