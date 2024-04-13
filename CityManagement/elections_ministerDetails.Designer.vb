<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class elections_ministerDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(elections_ministerDetails))
        Name2 = New Label()
        OpenManifesto = New Label()
        Ministry = New Label()
        VoteCount = New Label()
        VictoryMargin = New Label()
        profilePhoto = New PictureBox()
        CType(profilePhoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Name2
        ' 
        Name2.BackColor = Color.Black
        Name2.Font = New Font("Exo 2", 11F, FontStyle.Bold)
        Name2.ForeColor = Color.White
        Name2.Location = New Point(137, 49)
        Name2.Name = "Name2"
        Name2.Size = New Size(97, 25)
        Name2.TabIndex = 1
        ' 
        ' OpenManifesto
        ' 
        OpenManifesto.BackColor = Color.Transparent
        OpenManifesto.Location = New Point(128, 74)
        OpenManifesto.Name = "OpenManifesto"
        OpenManifesto.Size = New Size(97, 41)
        OpenManifesto.TabIndex = 4
        ' 
        ' Ministry
        ' 
        Ministry.BackColor = Color.White
        Ministry.Font = New Font("Exo 2", 11F, FontStyle.Bold)
        Ministry.ForeColor = Color.Black
        Ministry.Location = New Point(404, 29)
        Ministry.Name = "Ministry"
        Ministry.Size = New Size(319, 30)
        Ministry.TabIndex = 5
        ' 
        ' VoteCount
        ' 
        VoteCount.BackColor = Color.White
        VoteCount.Font = New Font("Exo 2", 11F, FontStyle.Bold)
        VoteCount.ForeColor = Color.Black
        VoteCount.Location = New Point(589, 59)
        VoteCount.Name = "VoteCount"
        VoteCount.Size = New Size(47, 31)
        VoteCount.TabIndex = 6
        ' 
        ' VictoryMargin
        ' 
        VictoryMargin.BackColor = Color.White
        VictoryMargin.Font = New Font("Exo 2", 11F, FontStyle.Bold)
        VictoryMargin.ForeColor = Color.Black
        VictoryMargin.Location = New Point(504, 84)
        VictoryMargin.Name = "VictoryMargin"
        VictoryMargin.Size = New Size(56, 31)
        VictoryMargin.TabIndex = 7
        ' 
        ' profilePhoto
        ' 
        profilePhoto.BackgroundImage = CType(resources.GetObject("profilePhoto.BackgroundImage"), Image)
        profilePhoto.BackgroundImageLayout = ImageLayout.Stretch
        profilePhoto.Location = New Point(14, 29)
        profilePhoto.Name = "profilePhoto"
        profilePhoto.Size = New Size(108, 104)
        profilePhoto.TabIndex = 8
        profilePhoto.TabStop = False
        ' 
        ' ministerDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        Controls.Add(profilePhoto)
        Controls.Add(VictoryMargin)
        Controls.Add(VoteCount)
        Controls.Add(Ministry)
        Controls.Add(OpenManifesto)
        Controls.Add(Name2)
        DoubleBuffered = True
        Name = "ministerDetails"
        Size = New Size(762, 150)
        CType(profilePhoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Name2 As Label
    Friend WithEvents OpenManifesto As Label
    Friend WithEvents Ministry As Label
    Friend WithEvents VoteCount As Label
    Friend WithEvents VictoryMargin As Label
    Friend WithEvents profilePhoto As PictureBox

End Class
