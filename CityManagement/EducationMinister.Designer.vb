<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EducationMinister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EducationMinister))
        Panel1 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(72, 142)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(931, 339)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(774, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 63)
        Label1.TabIndex = 1
        Label1.Text = "Approved"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Location = New Point(0, 505)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1107, 255)
        Panel3.TabIndex = 33
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(313, 56)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(5)
        Label6.Size = New Size(352, 68)
        Label6.TabIndex = 44
        Label6.Text = "Education Minister"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(291, 14)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 20)
        Label5.TabIndex = 43
        Label5.Text = "Requests"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(272, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(18, 20)
        Label4.TabIndex = 42
        Label4.Text = ">"
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(143, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 20)
        Label3.TabIndex = 41
        Label3.Text = "Education Minister"
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(126, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 20)
        Label2.TabIndex = 40
        Label2.Text = ">  "
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(19, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 20)
        Label7.TabIndex = 39
        Label7.Text = "Administration  "
        ' 
        ' EducationMinister
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1107, 760)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "EducationMinister"
        Text = "EducationMinister"
        TopMost = True
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
End Class
