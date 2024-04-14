<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class workerEmployReq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(workerEmployReq))
        Label2 = New Label()
        Label1 = New Label()
        lblAccrej = New Label()
        lblName = New Label()
        lblReject = New Label()
        lblAccept = New Label()
        lblDetails = New Label()
        lbldateTime = New Label()
        pbProfile = New PictureBox()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(312, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 28)
        Label2.TabIndex = 17
        Label2.Text = "Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(376, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 20)
        Label1.TabIndex = 16
        Label1.Text = "Time:"
        ' 
        ' lblAccrej
        ' 
        lblAccrej.AutoSize = True
        lblAccrej.Location = New Point(644, 100)
        lblAccrej.Name = "lblAccrej"
        lblAccrej.Size = New Size(0, 20)
        lblAccrej.TabIndex = 15
        ' 
        ' lblName
        ' 
        lblName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(376, 36)
        lblName.Name = "lblName"
        lblName.Size = New Size(311, 35)
        lblName.TabIndex = 14
        lblName.Text = "Name:"
        ' 
        ' lblReject
        ' 
        lblReject.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblReject.BackColor = Color.Transparent
        lblReject.Location = New Point(816, 36)
        lblReject.Name = "lblReject"
        lblReject.Size = New Size(64, 67)
        lblReject.TabIndex = 13
        ' 
        ' lblAccept
        ' 
        lblAccept.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblAccept.BackColor = Color.Transparent
        lblAccept.Location = New Point(713, 36)
        lblAccept.Name = "lblAccept"
        lblAccept.Size = New Size(65, 57)
        lblAccept.TabIndex = 12
        ' 
        ' lblDetails
        ' 
        lblDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblDetails.BackColor = Color.Transparent
        lblDetails.Location = New Point(219, 76)
        lblDetails.Name = "lblDetails"
        lblDetails.Size = New Size(140, 44)
        lblDetails.TabIndex = 11
        ' 
        ' lbldateTime
        ' 
        lbldateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbldateTime.AutoSize = True
        lbldateTime.BackColor = Color.Transparent
        lbldateTime.Location = New Point(445, 100)
        lbldateTime.Name = "lbldateTime"
        lbldateTime.Size = New Size(69, 20)
        lbldateTime.TabIndex = 10
        lbldateTime.Text = "datetime"
        ' 
        ' pbProfile
        ' 
        pbProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pbProfile.BackColor = Color.Transparent
        pbProfile.Location = New Point(22, 27)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(87, 94)
        pbProfile.TabIndex = 9
        pbProfile.TabStop = False
        ' 
        ' workerEmployReq
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblAccrej)
        Controls.Add(lblName)
        Controls.Add(lblReject)
        Controls.Add(lblAccept)
        Controls.Add(lblDetails)
        Controls.Add(lbldateTime)
        Controls.Add(pbProfile)
        Name = "workerEmployReq"
        Size = New Size(919, 151)
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAccrej As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblReject As Label
    Friend WithEvents lblAccept As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents lbldateTime As Label
    Friend WithEvents pbProfile As PictureBox

End Class
