<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Services_WorkSect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel2 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.Location = New Point(72, 176)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1110, 727)
        Panel2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.Image = My.Resources.Resources.Frame_1054__2_
        Label3.Location = New Point(1018, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 72)
        Label3.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Exo 2 SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(96), CByte(85), CByte(85))
        Label4.Location = New Point(168, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(406, 61)
        Label4.TabIndex = 6
        Label4.Text = "List of Service Requests"
        ' 
        ' Services_WorkSect
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1254, 953)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        Controls.Add(Label3)
        FormBorderStyle = FormBorderStyle.None
        Name = "Services_WorkSect"
        Text = "Services_WorkSect"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
