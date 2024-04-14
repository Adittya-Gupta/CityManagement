<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class min_req
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(min_req))
        pbProfile = New PictureBox()
        lbldateTime = New Label()
        lblDetails = New Label()
        lblAccept = New Label()
        lblReject = New Label()
        lblName = New Label()
        lblAccrej = New Label()
        Label1 = New Label()
        Label2 = New Label()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbProfile
        ' 
        pbProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pbProfile.BackColor = Color.Transparent
        pbProfile.Location = New Point(22, 23)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(100, 93)
        pbProfile.TabIndex = 0
        pbProfile.TabStop = False
        ' 
        ' lbldateTime
        ' 
        lbldateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbldateTime.AutoSize = True
        lbldateTime.BackColor = Color.Transparent
        lbldateTime.Location = New Point(427, 87)
        lbldateTime.Name = "lbldateTime"
        lbldateTime.Size = New Size(69, 20)
        lbldateTime.TabIndex = 1
        lbldateTime.Text = "datetime"
        ' 
        ' lblDetails
        ' 
        lblDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblDetails.BackColor = Color.Transparent
        lblDetails.Location = New Point(210, 65)
        lblDetails.Name = "lblDetails"
        lblDetails.Size = New Size(130, 51)
        lblDetails.TabIndex = 2
        ' 
        ' lblAccept
        ' 
        lblAccept.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblAccept.BackColor = Color.Transparent
        lblAccept.Location = New Point(708, 34)
        lblAccept.Name = "lblAccept"
        lblAccept.Size = New Size(56, 60)
        lblAccept.TabIndex = 3
        ' 
        ' lblReject
        ' 
        lblReject.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblReject.BackColor = Color.Transparent
        lblReject.Location = New Point(800, 34)
        lblReject.Name = "lblReject"
        lblReject.Size = New Size(5, 60)
        lblReject.TabIndex = 4
        ' 
        ' lblName
        ' 
        lblName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(341, 23)
        lblName.Name = "lblName"
        lblName.Size = New Size(275, 49)
        lblName.TabIndex = 5
        lblName.Text = "Name:"
        ' 
        ' lblAccrej
        ' 
        lblAccrej.AutoSize = True
        lblAccrej.Location = New Point(616, 87)
        lblAccrej.Name = "lblAccrej"
        lblAccrej.Size = New Size(0, 20)
        lblAccrej.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(346, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 20)
        Label1.TabIndex = 7
        Label1.Text = "Time:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(251, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 28)
        Label2.TabIndex = 8
        Label2.Text = "Name:"
        ' 
        ' min_req
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblAccrej)
        Controls.Add(lblName)
        Controls.Add(lblReject)
        Controls.Add(lblAccept)
        Controls.Add(lblDetails)
        Controls.Add(lbldateTime)
        Controls.Add(pbProfile)
        DoubleBuffered = True
        Name = "min_req"
        Size = New Size(890, 116)
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents lbldateTime As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents lblAccept As Label
    Friend WithEvents lblReject As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAccrej As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
