<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class election_dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(election_dashboard))
        apply_to_become_voter = New Label()
        voting_portal = New Label()
        nomination_rules = New Label()
        voting_rules = New Label()
        nomination_portal = New Label()
        nominees_details = New Label()
        results_portal = New Label()
        back = New Label()
        AllResults = New Label()
        SuspendLayout()
        ' 
        ' apply_to_become_voter
        ' 
        apply_to_become_voter.BackColor = Color.Transparent
        apply_to_become_voter.Location = New Point(137, 126)
        apply_to_become_voter.Name = "apply_to_become_voter"
        apply_to_become_voter.Size = New Size(410, 40)
        apply_to_become_voter.TabIndex = 0
        ' 
        ' voting_portal
        ' 
        voting_portal.BackColor = Color.Transparent
        voting_portal.Location = New Point(137, 192)
        voting_portal.Name = "voting_portal"
        voting_portal.Size = New Size(410, 40)
        voting_portal.TabIndex = 1
        ' 
        ' nomination_rules
        ' 
        nomination_rules.BackColor = Color.Transparent
        nomination_rules.Location = New Point(137, 258)
        nomination_rules.Name = "nomination_rules"
        nomination_rules.Size = New Size(410, 107)
        nomination_rules.TabIndex = 2
        ' 
        ' voting_rules
        ' 
        voting_rules.BackColor = Color.Transparent
        voting_rules.Location = New Point(137, 391)
        voting_rules.Name = "voting_rules"
        voting_rules.Size = New Size(410, 64)
        voting_rules.TabIndex = 3
        ' 
        ' nomination_portal
        ' 
        nomination_portal.BackColor = Color.Transparent
        nomination_portal.Location = New Point(563, 126)
        nomination_portal.Name = "nomination_portal"
        nomination_portal.Size = New Size(410, 106)
        nomination_portal.TabIndex = 4
        ' 
        ' nominees_details
        ' 
        nominees_details.BackColor = Color.Transparent
        nominees_details.Location = New Point(563, 248)
        nominees_details.Name = "nominees_details"
        nominees_details.Size = New Size(410, 117)
        nominees_details.TabIndex = 5
        ' 
        ' results_portal
        ' 
        results_portal.BackColor = Color.Transparent
        results_portal.Location = New Point(563, 391)
        results_portal.Name = "results_portal"
        results_portal.Size = New Size(201, 64)
        results_portal.TabIndex = 6
        ' 
        ' back
        ' 
        back.BackColor = Color.Transparent
        back.Location = New Point(819, 9)
        back.Name = "back"
        back.Size = New Size(98, 40)
        back.TabIndex = 7
        ' 
        ' AllResults
        ' 
        AllResults.BackColor = Color.Transparent
        AllResults.Location = New Point(772, 391)
        AllResults.Name = "AllResults"
        AllResults.Size = New Size(201, 64)
        AllResults.TabIndex = 8
        ' 
        ' election_dashboard
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1089, 713)
        Controls.Add(AllResults)
        Controls.Add(back)
        Controls.Add(results_portal)
        Controls.Add(nominees_details)
        Controls.Add(nomination_portal)
        Controls.Add(voting_rules)
        Controls.Add(nomination_rules)
        Controls.Add(voting_portal)
        Controls.Add(apply_to_become_voter)
        FormBorderStyle = FormBorderStyle.None
        Name = "election_dashboard"
        Text = "election_dashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents apply_to_become_voter As Label
    Friend WithEvents voting_portal As Label
    Friend WithEvents nomination_rules As Label
    Friend WithEvents voting_rules As Label
    Friend WithEvents nomination_portal As Label
    Friend WithEvents nominees_details As Label
    Friend WithEvents results_portal As Label
    Friend WithEvents back As Label
    Friend WithEvents AllResults As Label
End Class
