<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chats
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
        CurvedLabel9 = New CurvedLabel()
        SuspendLayout()
        ' 
        ' CurvedLabel9
        ' 
        CurvedLabel9.CornerRadius = 10
        CurvedLabel9.Font = New Font("Exo 2 Medium", 24F)
        CurvedLabel9.ForeColor = Color.MediumBlue
        CurvedLabel9.Location = New Point(1008, 0)
        CurvedLabel9.Name = "CurvedLabel9"
        CurvedLabel9.Size = New Size(148, 52)
        CurvedLabel9.TabIndex = 23
        CurvedLabel9.Text = "< Back"
        CurvedLabel9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Chats
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1156, 908)
        Controls.Add(CurvedLabel9)
        FormBorderStyle = FormBorderStyle.None
        Name = "Chats"
        Text = "Chats"
        ResumeLayout(False)
    End Sub

    Friend WithEvents CurvedLabel9 As CurvedLabel
End Class
