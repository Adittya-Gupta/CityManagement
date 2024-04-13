<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Banking_Admin_NewAccRegistration
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
        Me.Register_Button = New System.Windows.Forms.Button()
        Me.Refresh_Button = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 58)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(619, 398)
        Me.DataGridView1.TabIndex = 0
        '
        'Register_Button
        '
        Me.Register_Button.BackColor = System.Drawing.Color.DarkBlue
        Me.Register_Button.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Register_Button.Location = New System.Drawing.Point(698, 58)
        Me.Register_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Register_Button.Name = "Register_Button"
        Me.Register_Button.Size = New System.Drawing.Size(144, 40)
        Me.Register_Button.TabIndex = 51
        Me.Register_Button.Text = "Register"
        Me.Register_Button.UseVisualStyleBackColor = False
        '
        'Refresh_Button
        '
        Me.Refresh_Button.BackColor = System.Drawing.Color.DarkBlue
        Me.Refresh_Button.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refresh_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Refresh_Button.Location = New System.Drawing.Point(698, 146)
        Me.Refresh_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Refresh_Button.Name = "Refresh_Button"
        Me.Refresh_Button.Size = New System.Drawing.Size(144, 40)
        Me.Refresh_Button.TabIndex = 52
        Me.Refresh_Button.Text = "Refresh"
        Me.Refresh_Button.UseVisualStyleBackColor = False
        '
        'Banking_Admin_NewAccRegistration
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(872, 475)
        Me.Controls.Add(Me.Refresh_Button)
        Me.Controls.Add(Me.Register_Button)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Banking_Admin_NewAccRegistration"
        Me.Text = "Banking_Admin_NewAccRegistration"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Register_Button As Button
    Friend WithEvents Refresh_Button As Button
End Class
