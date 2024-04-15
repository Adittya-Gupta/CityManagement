<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinanceMinister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinanceMinister))
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(175, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 27)
        Label3.TabIndex = 9
        Label3.Text = "Finance Minister"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(175, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(543, 48)
        Label2.TabIndex = 8
        Label2.Text = "Finance Minister"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(779, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 63)
        Label1.TabIndex = 7
        Label1.Text = "Approved"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(34, 160)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(917, 401)
        Panel1.TabIndex = 6
        ' 
        ' FinanceMinister
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1089, 713)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "FinanceMinister"
        Text = "FinanceMinister"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
