<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class complaints_law
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(complaints_law))
        Label3 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(569, 41)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(114, 13, 114, 13)
        Label3.Size = New Size(283, 52)
        Label3.TabIndex = 5
        Label3.Text = "Law"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Location = New Point(26, 87)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(370, 410)
        Panel2.TabIndex = 6
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Location = New Point(0, 505)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1107, 255)
        Panel3.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.White
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Location = New Point(417, 114)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(654, 439)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Book Antiqua", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 18)
        Label2.TabIndex = 12
        Label2.Text = "Complaint Portal  >"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Book Antiqua", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(180, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 19)
        Label1.TabIndex = 11
        Label1.Text = "Law"
        ' 
        ' complaints_law
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1107, 760)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label3)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "complaints_law"
        Text = "complaints_Hospital"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
