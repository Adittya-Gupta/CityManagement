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
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(2, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(914, 600)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Yellow
        Label1.Font = New Font("Exo 2", 18F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(257, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(461, 36)
        Label1.TabIndex = 0
        Label1.Text = "You don't have any requests now"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' IncomingEmploymentReq
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        ClientSize = New Size(930, 846)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "IncomingEmploymentReq"
        Text = "IncomingEmploymentReq"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
