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
        Label1 = New Label()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25F)
        Label1.Location = New Point(261, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(699, 57)
        Label1.TabIndex = 0
        Label1.Text = "Employment Requests for Electrician"
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(38, 233)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1157, 689)
        Panel1.TabIndex = 1
        ' 
        ' IncomingEmploymentReq
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1236, 979)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "IncomingEmploymentReq"
        Text = "IncomingEmploymentReq"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
