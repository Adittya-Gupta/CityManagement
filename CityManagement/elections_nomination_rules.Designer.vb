<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class elections_nomination_rules
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(elections_nomination_rules))
        back = New Label()
        SuspendLayout()
        ' 
        ' back
        ' 
        back.BackColor = Color.Transparent
        back.Location = New Point(839, 18)
        back.Name = "back"
        back.Size = New Size(89, 40)
        back.TabIndex = 10
        ' 
        ' elections_nomination_rules
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1089, 713)
        Controls.Add(back)
        FormBorderStyle = FormBorderStyle.None
        Name = "elections_nomination_rules"
        Text = "nomination_rules"
        ResumeLayout(False)
    End Sub

    Friend WithEvents back As Label
End Class
