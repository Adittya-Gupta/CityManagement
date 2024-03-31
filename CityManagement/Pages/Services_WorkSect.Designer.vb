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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel2 = New Panel()
        Label4 = New Label()
        Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.Location = New Point(72, 176)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1110, 727)
        Panel2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(96), CByte(85), CByte(85))
        Label4.Location = New Point(437, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(253, 49)
        Label4.TabIndex = 6
        Label4.Text = "List of Service Requests"
        ' 
        ' Guna2ComboBox1
        ' 
        Guna2ComboBox1.BackColor = Color.Transparent
        Guna2ComboBox1.BorderColor = Color.Transparent
        Guna2ComboBox1.BorderRadius = 10
        Guna2ComboBox1.CustomizableEdges = CustomizableEdges1
        Guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed
        Guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Guna2ComboBox1.FillColor = Color.Black
        Guna2ComboBox1.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2ComboBox1.Font = New Font("Segoe UI", 10F)
        Guna2ComboBox1.ForeColor = SystemColors.Control
        Guna2ComboBox1.IntegralHeight = False
        Guna2ComboBox1.ItemHeight = 30
        Guna2ComboBox1.Location = New Point(1001, 68)
        Guna2ComboBox1.Name = "Guna2ComboBox1"
        Guna2ComboBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ComboBox1.Size = New Size(181, 36)
        Guna2ComboBox1.TabIndex = 7
        ' 
        ' Services_WorkSect
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1254, 953)
        Controls.Add(Guna2ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Services_WorkSect"
        Text = "Services_WorkSect"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
End Class
