<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class complaints_Education
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(complaints_Education))
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.White
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Location = New Point(417, 102)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(654, 439)
        Panel1.TabIndex = 8
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Location = New Point(0, 493)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1107, 255)
        Panel3.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Location = New Point(28, 152)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(370, 245)
        Panel2.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(569, 29)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(114, 13, 114, 13)
        Label3.Size = New Size(369, 59)
        Label3.TabIndex = 11
        Label3.Text = "Education"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Book Antiqua", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(14, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 22)
        Label2.TabIndex = 10
        Label2.Text = "Complaint Portal  >"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Book Antiqua", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(182, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 22)
        Label1.TabIndex = 9
        Label1.Text = "Education"
        ' 
        ' complaints_Education
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1107, 760)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "complaints_Education"
        Text = "education"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
