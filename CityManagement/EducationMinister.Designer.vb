<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EducationMinister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EducationMinister))
        Panel1 = New Panel()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(72, 142)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(931, 401)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(774, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 63)
        Label1.TabIndex = 1
        Label1.Text = "Approved"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' EducationMinister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1089, 713)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "EducationMinister"
        Text = "EducationMinister"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
