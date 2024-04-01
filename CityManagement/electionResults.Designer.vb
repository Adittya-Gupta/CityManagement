<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class electionResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(electionResults))
        Candidates = New Panel()
        SuspendLayout()
        ' 
        ' Candidates
        ' 
        Candidates.Location = New Point(12, 161)
        Candidates.Name = "Candidates"
        Candidates.Size = New Size(1133, 494)
        Candidates.TabIndex = 0
        ' 
        ' electionResults
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1236, 873)
        Controls.Add(Candidates)
        DoubleBuffered = True
        Name = "electionResults"
        Text = "electionResults"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Candidates As Panel
End Class
