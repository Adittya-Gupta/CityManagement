<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class organization_details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(organization_details))
        Name2 = New Label()
        profilePhoto = New PictureBox()
        CType(profilePhoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Name2
        ' 
        Name2.BackColor = Color.Black
        Name2.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold)
        Name2.ForeColor = Color.White
        Name2.Location = New Point(279, 67)
        Name2.Name = "Name2"
        Name2.Size = New Size(240, 72)
        Name2.TabIndex = 1
        ' 
        ' profilePhoto
        ' 
        profilePhoto.BackgroundImage = CType(resources.GetObject("profilePhoto.BackgroundImage"), Image)
        profilePhoto.BackgroundImageLayout = ImageLayout.Stretch
        profilePhoto.Location = New Point(48, 23)
        profilePhoto.Name = "profilePhoto"
        profilePhoto.Size = New Size(200, 192)
        profilePhoto.TabIndex = 8
        profilePhoto.TabStop = False
        ' 
        ' organization_details
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        Controls.Add(profilePhoto)
        Controls.Add(Name2)
        Name = "organization_details"
        Size = New Size(632, 233)
        CType(profilePhoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Name2 As Label
    Friend WithEvents profilePhoto As PictureBox

End Class
