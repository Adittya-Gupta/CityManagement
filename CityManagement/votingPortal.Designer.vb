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
        Vote = New Button()
        selectMinister = New ComboBox()
        Candidates = New Panel()
        Label1 = New Label()
        NOTA = New Button()
        SuspendLayout()
        ' 
        ' Vote
        ' 
        Vote.BackColor = Color.FromArgb(CByte(0), CByte(2), CByte(135), CByte(64))
        Vote.Font = New Font("Exo 2", 16F, FontStyle.Bold)
        Vote.ForeColor = SystemColors.Control
        Vote.Location = New Point(517, 668)
        Vote.Name = "Vote"
        Vote.Size = New Size(204, 56)
        Vote.TabIndex = 2
        Vote.Text = "Vote"
        Vote.UseVisualStyleBackColor = False
        ' 
        ' selectMinister
        ' 
        selectMinister.BackColor = Color.Black
        selectMinister.DropDownStyle = ComboBoxStyle.DropDownList
        selectMinister.Font = New Font("Exo 2", 27F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        selectMinister.ForeColor = Color.White
        selectMinister.FormattingEnabled = True
        selectMinister.Location = New Point(357, 65)
        selectMinister.Name = "selectMinister"
        selectMinister.Size = New Size(552, 62)
        selectMinister.TabIndex = 3
        ' 
        ' Candidates
        ' 
        Candidates.AutoScroll = True
        Candidates.Location = New Point(42, 152)
        Candidates.Name = "Candidates"
        Candidates.Size = New Size(1130, 499)
        Candidates.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Exo 2", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(79, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(254, 50)
        Label1.TabIndex = 5
        Label1.Text = "Select Ministry"
        ' 
        ' NOTA
        ' 
        NOTA.BackColor = Color.FromArgb(CByte(0), CByte(2), CByte(135), CByte(64))
        NOTA.Font = New Font("Exo 2", 16F, FontStyle.Bold)
        NOTA.ForeColor = SystemColors.Control
        NOTA.Location = New Point(968, 668)
        NOTA.Name = "NOTA"
        NOTA.Size = New Size(204, 56)
        NOTA.TabIndex = 6
        NOTA.Text = "NOTA"
        NOTA.UseVisualStyleBackColor = False
        ' 
        ' votingPortal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1236, 873)
        Controls.Add(selectMinister)
        Controls.Add(Label1)
        Controls.Add(NOTA)
        Controls.Add(Vote)
        Controls.Add(Candidates)
        DoubleBuffered = True
        Name = "votingPortal"
        Text = "votingPortal"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Vote As Button
    Friend WithEvents selectMinister As ComboBox
    Friend WithEvents Candidates As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NOTA As Button
End Class
