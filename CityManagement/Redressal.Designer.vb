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
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(27, 96)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(0, 5, 0, 0)
        Label1.Size = New Size(296, 53)
        Label1.TabIndex = 0
        Label1.Text = "Pending Complaints"
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.AutoSize = True
        Panel2.Controls.Add(DataGridView1)
        Panel2.Location = New Point(27, 176)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1197, 511)
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
        DataGridView1.Size = New Size(1197, 511)
        DataGridView1.TabIndex = 0
        ' 
        ' Redressal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1089, 713)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        DoubleBuffered = True
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
End Class
