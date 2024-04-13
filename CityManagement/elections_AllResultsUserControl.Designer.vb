<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class elections_AllResultsUserControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(elections_AllResultsUserControl))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        VoteCount = New Label()
        votes_secured = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Location = New Point(30, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 102)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(158, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 25)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(149, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 43)
        Label2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(360, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(570, 102)
        Label3.TabIndex = 3
        Label3.Text = "Label3"
        ' 
        ' VoteCount
        ' 
        VoteCount.BackColor = SystemColors.ActiveCaptionText
        VoteCount.Font = New Font("Exo 2", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        VoteCount.ForeColor = Color.White
        VoteCount.Location = New Point(360, 117)
        VoteCount.Name = "VoteCount"
        VoteCount.Size = New Size(253, 31)
        VoteCount.TabIndex = 4
        VoteCount.Text = "Number Of Votes Secured : "
        ' 
        ' votes_secured
        ' 
        votes_secured.BackColor = SystemColors.ActiveCaptionText
        votes_secured.Font = New Font("Exo 2", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        votes_secured.ForeColor = Color.White
        votes_secured.Location = New Point(619, 117)
        votes_secured.Name = "votes_secured"
        votes_secured.Size = New Size(72, 31)
        votes_secured.TabIndex = 5
        votes_secured.Text = " "
        ' 
        ' AllResultsUserControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(votes_secured)
        Controls.Add(VoteCount)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "AllResultsUserControl"
        Size = New Size(949, 161)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents VoteCount As Label
    Friend WithEvents votes_secured As Label

End Class
