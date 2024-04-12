<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class votingPortal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(votingPortal))
        back = New Label()
        Vote = New Label()
        Candidates = New Panel()
        selectMinister = New ComboBox()
        NOTA = New Button()
        SuspendLayout()
        ' 
        ' back
        ' 
        back.BackColor = Color.Transparent
        back.Location = New Point(873, 19)
        back.Name = "back"
        back.Size = New Size(89, 34)
        back.TabIndex = 10
        ' 
        ' Vote
        ' 
        Vote.BackColor = Color.Transparent
        Vote.Location = New Point(455, 552)
        Vote.Name = "Vote"
        Vote.Size = New Size(142, 34)
        Vote.TabIndex = 11
        ' 
        ' Candidates
        ' 
        Candidates.Location = New Point(167, 141)
        Candidates.Name = "Candidates"
        Candidates.Size = New Size(752, 370)
        Candidates.TabIndex = 12
        ' 
        ' selectMinister
        ' 
        selectMinister.Font = New Font("Exo 2 Extra Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        selectMinister.FormattingEnabled = True
        selectMinister.Location = New Point(345, 79)
        selectMinister.Name = "selectMinister"
        selectMinister.Size = New Size(438, 32)
        selectMinister.TabIndex = 13
        ' 
        ' NOTA
        ' 
        NOTA.BackColor = Color.Red
        NOTA.Font = New Font("Exo 2", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NOTA.ForeColor = Color.White
        NOTA.Location = New Point(790, 544)
        NOTA.Name = "NOTA"
        NOTA.Size = New Size(159, 42)
        NOTA.TabIndex = 14
        NOTA.Text = "NOTA"
        NOTA.UseVisualStyleBackColor = False
        ' 
        ' votingPortal
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1089, 713)
        Controls.Add(NOTA)
        Controls.Add(selectMinister)
        Controls.Add(Candidates)
        Controls.Add(Vote)
        Controls.Add(back)
        DoubleBuffered = True
        Font = New Font("Microsoft Sans Serif", 8.25F)
        Name = "votingPortal"
        Text = "votingPortal"
        ResumeLayout(False)
    End Sub

    Friend WithEvents back As Label
    Friend WithEvents Vote As Label
    Friend WithEvents Candidates As Panel
    Friend WithEvents selectMinister As ComboBox
    Friend WithEvents NOTA As Button
End Class
