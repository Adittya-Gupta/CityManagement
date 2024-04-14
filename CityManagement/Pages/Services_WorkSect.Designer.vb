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
        Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.Location = New Point(59, 107)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(994, 550)
        Panel2.TabIndex = 5
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
        Guna2ComboBox1.Location = New Point(872, 33)
        Guna2ComboBox1.Name = "Guna2ComboBox1"
        Guna2ComboBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ComboBox1.Size = New Size(181, 36)
        Guna2ComboBox1.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Abhaya Libre Medium", 30F)
        Label8.Location = New Point(224, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(519, 58)
        Label8.TabIndex = 48
        Label8.Text = "List of Service Requests"
        ' 
        ' Services_WorkSect
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        ClientSize = New Size(1107, 705)
        Controls.Add(Label8)
        Controls.Add(Guna2ComboBox1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Services_WorkSect"
        Text = "Services_WorkSect"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
End Class
