<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HistoryItem
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
        CurvedLabel2 = New CurvedLabel()
        Rating1 = New Rating()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CurvedLabel1 = New CurvedLabel()
        CurvedLabel3 = New CurvedLabel()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CurvedLabel4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CurvedLabel2
        ' 
        CurvedLabel2.BackColor = SystemColors.WindowFrame
        CurvedLabel2.CornerRadius = 25
        CurvedLabel2.Location = New Point(0, 0)
        CurvedLabel2.Name = "CurvedLabel2"
        CurvedLabel2.Size = New Size(484, 114)
        CurvedLabel2.TabIndex = 40
        CurvedLabel2.Text = "CurvedLabel2"
        ' 
        ' Rating1
        ' 
        Rating1.Location = New Point(71, 3)
        Rating1.Name = "Rating1"
        Rating1.RatingValue = 5R
        Rating1.Size = New Size(35, 25)
        Rating1.TabIndex = 41
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = Mask_group
        PictureBox1.Location = New Point(21, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(65, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(175, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(278, 25)
        Label1.TabIndex = 32
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.White
        Label2.Font = New Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(175, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 54)
        Label2.TabIndex = 33
        Label2.Text = "Label2"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.White
        Label3.Font = New Font("Microsoft Sans Serif", 10F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(342, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 39)
        Label3.TabIndex = 34
        Label3.Text = "Label3"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.BackColor = Color.White
        CurvedLabel1.CornerRadius = 20
        CurvedLabel1.Location = New Point(0, 0)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Size = New Size(484, 105)
        CurvedLabel1.TabIndex = 30
        ' 
        ' CurvedLabel3
        ' 
        CurvedLabel3.BackColor = Color.Transparent
        CurvedLabel3.CornerRadius = 20
        CurvedLabel3.Font = New Font("Microsoft Sans Serif", 16F)
        CurvedLabel3.ForeColor = Color.Gainsboro
        CurvedLabel3.Location = New Point(529, 25)
        CurvedLabel3.Name = "CurvedLabel3"
        CurvedLabel3.Padding = New Padding(0, 5, 0, 0)
        CurvedLabel3.Size = New Size(186, 57)
        CurvedLabel3.TabIndex = 42
        CurvedLabel3.Text = "EnquirySent"
        CurvedLabel3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(103, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 25)
        Label4.TabIndex = 44
        Label4.Text = "Name"
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(103, 52)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 25)
        Label5.TabIndex = 45
        Label5.Text = "Time"
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(370, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 25)
        Label6.TabIndex = 46
        Label6.Text = "Bill(Rs)"
        ' 
        ' CurvedLabel4
        ' 
        CurvedLabel4.BackColor = Color.FromArgb(CByte(254), CByte(0), CByte(0))
        CurvedLabel4.FlatStyle = FlatStyle.Flat
        CurvedLabel4.Font = New Font("Microsoft Sans Serif", 16F)
        CurvedLabel4.ForeColor = Color.Gainsboro
        CurvedLabel4.Location = New Point(765, 25)
        CurvedLabel4.Name = "CurvedLabel4"
        CurvedLabel4.Size = New Size(171, 54)
        CurvedLabel4.TabIndex = 47
        CurvedLabel4.Text = "Withdraw"
        CurvedLabel4.UseVisualStyleBackColor = False
        ' 
        ' HistoryItem
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(CurvedLabel4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(CurvedLabel3)
        Controls.Add(Rating1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(CurvedLabel1)
        Controls.Add(CurvedLabel2)
        Name = "HistoryItem"
        Size = New Size(963, 114)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CurvedLabel4 As Button

End Class