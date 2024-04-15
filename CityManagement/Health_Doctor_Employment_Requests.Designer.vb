<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Health_Doctor_Employment_Requests
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
        Panel1 = New Panel()
        Label8 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1254, 80)
        Panel1.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Black
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(118, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(187, 28)
        Label8.TabIndex = 2
        Label8.Text = "Create New Vacancy"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Black
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(462, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(220, 28)
        Label7.TabIndex = 1
        Label7.Text = "View Previous Vacancies"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(824, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 28)
        Label1.TabIndex = 0
        Label1.Text = "Doctor Employment Request"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaptionText
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(1042, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 23)
        Label4.TabIndex = 33
        Label4.Text = "Back"
        ' 
        ' Guna2ComboBox1
        ' 
        Guna2ComboBox1.BackColor = Color.Transparent
        Guna2ComboBox1.CustomizableEdges = CustomizableEdges1
        Guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed
        Guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Guna2ComboBox1.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2ComboBox1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Guna2ComboBox1.ForeColor = Color.Black
        Guna2ComboBox1.ItemHeight = 30
        Guna2ComboBox1.Items.AddRange(New Object() {"Select Specialisation", "Cardiology", "Pulmonology", "Orthopedics", "Neurology", "Homeopathy", "General Physician"})
        Guna2ComboBox1.Location = New Point(453, 133)
        Guna2ComboBox1.Margin = New Padding(3, 4, 3, 4)
        Guna2ComboBox1.Name = "Guna2ComboBox1"
        Guna2ComboBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ComboBox1.Size = New Size(245, 36)
        Guna2ComboBox1.StartIndex = 0
        Guna2ComboBox1.TabIndex = 34
        ' 
        ' Health_Doctor_Employment_Requests
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1107, 760)
        Controls.Add(Guna2ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Health_Doctor_Employment_Requests"
        Text = "Health_HospitalListing"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
End Class
