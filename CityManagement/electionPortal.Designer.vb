<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class electionPortal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(electionPortal))
        Apply = New Button()
        Results = New Button()
        SuspendLayout()
        ' 
        ' Apply
        ' 
        Apply.BackColor = Color.FromArgb(CByte(0), CByte(2), CByte(135), CByte(64))
        Apply.Font = New Font("Exo 2", 12F, FontStyle.Bold)
        Apply.ForeColor = SystemColors.Control
        Apply.Location = New Point(447, 457)
        Apply.Name = "Apply"
        Apply.Size = New Size(207, 53)
        Apply.TabIndex = 0
        Apply.Text = "Button1"
        Apply.UseVisualStyleBackColor = False
        ' 
        ' Results
        ' 
        Results.BackColor = Color.FromArgb(CByte(0), CByte(2), CByte(135), CByte(64))
        Results.Font = New Font("Exo 2", 12F, FontStyle.Bold)
        Results.ForeColor = SystemColors.Control
        Results.Location = New Point(916, 463)
        Results.Name = "Results"
        Results.Size = New Size(219, 47)
        Results.TabIndex = 2
        Results.Text = "Button2"
        Results.UseVisualStyleBackColor = False
        ' 
        ' electionPortal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1236, 873)
        Controls.Add(Results)
        Controls.Add(Apply)
        DoubleBuffered = True
        Name = "electionPortal"
        Text = "electionPortal"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Apply As Button
    Friend WithEvents Results As Button
End Class
