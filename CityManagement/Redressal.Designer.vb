<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Redressal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Redressal))
        Label1 = New Label()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        Panel3 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(23, 61)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(0, 5, 0, 0)
        Label1.Size = New Size(296, 53)
        Label1.TabIndex = 0
        Label1.Text = "Pending Complaints"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.AutoSize = True
        Panel2.Controls.Add(DataGridView1)
        Panel2.Location = New Point(12, 180)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1083, 318)
        Panel2.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White
        DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black
        DataGridView1.Size = New Size(1083, 318)
        DataGridView1.TabIndex = 0
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
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(12, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 28)
        Label2.TabIndex = 34
        Label2.Text = "Redressal Portal"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(171, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 28)
        Label3.TabIndex = 35
        Label3.Text = "Query"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(149, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(24, 26)
        Label4.TabIndex = 36
        Label4.Text = ">"
        ' 
        ' Redressal
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 760)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Redressal"
        Text = "Redressal"
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
