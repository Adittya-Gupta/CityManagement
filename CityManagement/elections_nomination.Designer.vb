<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class elections_nomination
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(elections_nomination))
        back = New Label()
        UploadManifesto = New Label()
        PayDeposit = New Label()
        Agenda = New RichTextBox()
        Minister = New Label()
        SuspendLayout()
        ' 
        ' back
        ' 
        back.BackColor = Color.Transparent
        back.Location = New Point(860, 9)
        back.Name = "back"
        back.Size = New Size(89, 40)
        back.TabIndex = 10
        ' 
        ' UploadManifesto
        ' 
        UploadManifesto.BackColor = Color.Transparent
        UploadManifesto.Location = New Point(183, 441)
        UploadManifesto.Name = "UploadManifesto"
        UploadManifesto.Size = New Size(271, 53)
        UploadManifesto.TabIndex = 11
        ' 
        ' PayDeposit
        ' 
        PayDeposit.BackColor = Color.Transparent
        PayDeposit.Location = New Point(732, 441)
        PayDeposit.Name = "PayDeposit"
        PayDeposit.Size = New Size(193, 53)
        PayDeposit.TabIndex = 12
        ' 
        ' Agenda
        ' 
        Agenda.Font = New Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Agenda.Location = New Point(186, 234)
        Agenda.Name = "Agenda"
        Agenda.Size = New Size(739, 167)
        Agenda.TabIndex = 13
        Agenda.Text = ""
        ' 
        ' Minister
        ' 
        Minister.BackColor = Color.White
        Minister.Font = New Font("Microsoft Sans Serif", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Minister.Location = New Point(174, 66)
        Minister.Name = "Minister"
        Minister.Size = New Size(775, 47)
        Minister.TabIndex = 14
        ' 
        ' elections_nomination
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1089, 713)
        Controls.Add(Minister)
        Controls.Add(Agenda)
        Controls.Add(PayDeposit)
        Controls.Add(UploadManifesto)
        Controls.Add(back)
        DoubleBuffered = True
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Name = "elections_nomination"
        Text = "nomination"
        ResumeLayout(False)
    End Sub

    Friend WithEvents back As Label
    Friend WithEvents UploadManifesto As Label
    Friend WithEvents PayDeposit As Label
    Friend WithEvents Agenda As RichTextBox
    Friend WithEvents Minister As Label
End Class
