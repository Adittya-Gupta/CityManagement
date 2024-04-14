<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomingEmploymentReq
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
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(2, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1083, 689)
        Panel1.TabIndex = 1
        ' 
        ' IncomingEmploymentReq
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        ClientSize = New Size(1107, 687)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "IncomingEmploymentReq"
        Text = "IncomingEmploymentReq"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
End Class
