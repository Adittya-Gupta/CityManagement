<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class elections_apply_for_voter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(elections_apply_for_voter))
        apply = New Label()
        back = New Label()
        SuspendLayout()
        ' 
        ' apply
        ' 
        apply.BackColor = Color.Transparent
        apply.Location = New Point(491, 403)
        apply.Name = "apply"
        apply.Size = New Size(326, 45)
        apply.TabIndex = 8
        ' 
        ' back
        ' 
        back.BackColor = Color.Transparent
        back.Location = New Point(824, 9)
        back.Name = "back"
        back.Size = New Size(89, 40)
        back.TabIndex = 9
        ' 
        ' elections_apply_for_voter
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1089, 713)
        Controls.Add(back)
        Controls.Add(apply)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "elections_apply_for_voter"
        Text = "electionPortal"
        ResumeLayout(False)
    End Sub

    Friend WithEvents apply As Label
    Friend WithEvents back As Label
End Class
