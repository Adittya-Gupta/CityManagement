<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class elections_final_results
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(elections_final_results))
        back = New Label()
        Label1 = New Label()
        Candidates = New Panel()
        SuspendLayout()
        ' 
        ' back
        ' 
        back.BackColor = Color.Transparent
        back.Location = New Point(500, 336)
        back.Name = "back"
        back.Size = New Size(89, 40)
        back.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(863, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 40)
        Label1.TabIndex = 11
        ' 
        ' Candidates
        ' 
        Candidates.Location = New Point(153, 130)
        Candidates.Name = "Candidates"
        Candidates.Size = New Size(765, 375)
        Candidates.TabIndex = 12
        ' 
        ' elections_final_results
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1089, 713)
        Controls.Add(Candidates)
        Controls.Add(Label1)
        Controls.Add(back)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "elections_final_results"
        Text = "electionResults"
        ResumeLayout(False)
    End Sub

    Friend WithEvents back As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Candidates As Panel
End Class
