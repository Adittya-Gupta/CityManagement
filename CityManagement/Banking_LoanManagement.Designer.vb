<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Banking_LoanManagement
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Refresh_Button = New System.Windows.Forms.Button()
        Me.Approve_Button = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(62, 50)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(619, 398)
        Me.DataGridView1.TabIndex = 1
        '
        'Refresh_Button
        '
        Me.Refresh_Button.BackColor = System.Drawing.Color.DarkBlue
        Me.Refresh_Button.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refresh_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Refresh_Button.Location = New System.Drawing.Point(716, 119)
        Me.Refresh_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Refresh_Button.Name = "Refresh_Button"
        Me.Refresh_Button.Size = New System.Drawing.Size(144, 40)
        Me.Refresh_Button.TabIndex = 53
        Me.Refresh_Button.Text = "Refresh"
        Me.Refresh_Button.UseVisualStyleBackColor = False
        '
        'Approve_Button
        '
        Me.Approve_Button.BackColor = System.Drawing.Color.DarkBlue
        Me.Approve_Button.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Approve_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Approve_Button.Location = New System.Drawing.Point(716, 50)
        Me.Approve_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Approve_Button.Name = "Approve_Button"
        Me.Approve_Button.Size = New System.Drawing.Size(144, 40)
        Me.Approve_Button.TabIndex = 54
        Me.Approve_Button.Text = "Approve"
        Me.Approve_Button.UseVisualStyleBackColor = False
        '
        'Banking_LoanManagement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(872, 475)
        Me.Controls.Add(Me.Approve_Button)
        Me.Controls.Add(Me.Refresh_Button)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Banking_LoanManagement"
        Me.Text = "Banking_LoanManagement"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Refresh_Button As Button
    Friend WithEvents Approve_Button As Button
End Class
