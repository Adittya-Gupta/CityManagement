<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rate
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
        CurvedLabel1 = New CurvedLabel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Star_Rating1 = New Star_Rating()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.BackColor = Color.FromArgb(CByte(97), CByte(160), CByte(255))
        CurvedLabel1.CornerRadius = 10
        CurvedLabel1.Font = New Font("Abhaya Libre Medium", 20F)
        CurvedLabel1.ForeColor = Color.White
        CurvedLabel1.Location = New Point(36, 271)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Size = New Size(320, 69)
        CurvedLabel1.TabIndex = 0
        CurvedLabel1.Text = "Submit"
        CurvedLabel1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Abhaya Libre Medium", 10F)
        Label1.Location = New Point(36, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(317, 79)
        Label1.TabIndex = 1
        Label1.Text = "How was the service of " & vbCrLf & "John Miller ?"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.image_2
        PictureBox1.Location = New Point(94, 91)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(212, 89)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Star_Rating1
        ' 
        Star_Rating1.HighlightedStars = 0
        Star_Rating1.Location = New Point(60, 205)
        Star_Rating1.Name = "Star_Rating1"
        Star_Rating1.Size = New Size(276, 63)
        Star_Rating1.TabIndex = 3
        ' 
        ' Rate
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        ClientSize = New Size(388, 385)
        Controls.Add(Star_Rating1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(CurvedLabel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Rate"
        Text = "Rate"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CurvedLabel1 As CurvedLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Star_Rating1 As Star_Rating
End Class
