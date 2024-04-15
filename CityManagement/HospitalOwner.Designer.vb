<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HospitalOwner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HospitalOwner))
        Panel3 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Panel1 = New Panel()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Location = New Point(0, 505)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1107, 255)
        Panel3.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(28, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 15
        Label1.Text = "Administration  "
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(135, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 20)
        Label2.TabIndex = 16
        Label2.Text = ">  "
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(158, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 20)
        Label3.TabIndex = 17
        Label3.Text = "Hospital Owner"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(271, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(18, 20)
        Label4.TabIndex = 18
        Label4.Text = ">"
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(295, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 20)
        Label5.TabIndex = 19
        Label5.Text = "Requests"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(322, 54)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(5)
        Label6.Size = New Size(352, 68)
        Label6.TabIndex = 20
        Label6.Text = "Hospital Owner"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(74, 144)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(931, 362)
        Panel1.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Black
        Label7.Font = New Font("Segoe UI", 14F)
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(834, 54)
        Label7.Name = "Label7"
        Label7.Size = New Size(207, 55)
        Label7.TabIndex = 22
        Label7.Text = "Approved"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' HospitalOwner
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 760)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "HospitalOwner"
        Text = "HospitalOwner"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
End Class
