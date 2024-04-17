<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrgHeadWorkSection
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        CurvedLabel1 = New CurvedLabel()
        Panel1 = New Panel()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges9
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Font = New Font("Exo 2", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(101, 29)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Button1.Size = New Size(225, 56)
        Guna2Button1.TabIndex = 0
        Guna2Button1.Text = "View Employees"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomizableEdges = CustomizableEdges11
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.Font = New Font("Exo 2", 12F, FontStyle.Bold)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(790, 29)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Button2.Size = New Size(225, 56)
        Guna2Button2.TabIndex = 1
        Guna2Button2.Text = "Employment Requests"
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.AutoSize = True
        CurvedLabel1.CornerRadius = 10
        CurvedLabel1.Font = New Font("Exo 2", 19.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel1.Location = New Point(355, 117)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Size = New Size(167, 38)
        CurvedLabel1.TabIndex = 3
        CurvedLabel1.Text = "Welcome, "
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.Location = New Point(101, 184)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(914, 760)
        Panel1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Exo 2", 25.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(205, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(527, 50)
        Label1.TabIndex = 2
        Label1.Text = "Employment Requests for "
        ' 
        ' OrgHeadWorkSection
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        ClientSize = New Size(1107, 687)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(CurvedLabel1)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "OrgHeadWorkSection"
        Text = "OrgHeadWorkSection"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CurvedLabel1 As CurvedLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
