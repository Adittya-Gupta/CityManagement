<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nomination
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nomination))
        PayDeposit = New Button()
        Agenda = New RichTextBox()
        Minister = New Label()
        UploadManifesto = New Button()
        SuspendLayout()
        ' 
        ' PayDeposit
        ' 
        PayDeposit.BackColor = Color.FromArgb(CByte(0), CByte(2), CByte(135), CByte(64))
        PayDeposit.Font = New Font("Exo 2", 10F, FontStyle.Bold)
        PayDeposit.ForeColor = SystemColors.Control
        PayDeposit.Location = New Point(506, 638)
        PayDeposit.Name = "PayDeposit"
        PayDeposit.Size = New Size(249, 52)
        PayDeposit.TabIndex = 1
        PayDeposit.Text = "Pay Deposit"
        PayDeposit.UseVisualStyleBackColor = False
        ' 
        ' Agenda
        ' 
        Agenda.Font = New Font("Exo 2", 10F)
        Agenda.ForeColor = Color.White
        Agenda.Location = New Point(304, 261)
        Agenda.Name = "Agenda"
        Agenda.Size = New Size(790, 177)
        Agenda.TabIndex = 3
        Agenda.Text = ""
        ' 
        ' Minister
        ' 
        Minister.BackColor = Color.WhiteSmoke
        Minister.Font = New Font("Exo 2", 14F, FontStyle.Bold)
        Minister.Location = New Point(696, 152)
        Minister.Name = "Minister"
        Minister.Size = New Size(345, 37)
        Minister.TabIndex = 4
        Minister.Text = "Label1"
        ' 
        ' UploadManifesto
        ' 
        UploadManifesto.BackColor = Color.Transparent
        UploadManifesto.BackgroundImage = CType(resources.GetObject("UploadManifesto.BackgroundImage"), Image)
        UploadManifesto.BackgroundImageLayout = ImageLayout.None
        UploadManifesto.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        UploadManifesto.ForeColor = Color.Transparent
        UploadManifesto.Location = New Point(431, 521)
        UploadManifesto.Name = "UploadManifesto"
        UploadManifesto.Size = New Size(351, 73)
        UploadManifesto.TabIndex = 5
        UploadManifesto.UseVisualStyleBackColor = False
        ' 
        ' nomination
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1236, 873)
        Controls.Add(UploadManifesto)
        Controls.Add(Minister)
        Controls.Add(Agenda)
        Controls.Add(PayDeposit)
        DoubleBuffered = True
        ForeColor = Color.Transparent
        Name = "nomination"
        Text = "nomination"
        ResumeLayout(False)
    End Sub

    Friend WithEvents PayDeposit As Button
    Friend WithEvents Agenda As RichTextBox
    Friend WithEvents Minister As Label
    Friend WithEvents UploadManifesto As Button
End Class
