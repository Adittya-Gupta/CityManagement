<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Banking_Panel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Home_Button = New System.Windows.Forms.Button()
        Me.LoanApproval_Button = New System.Windows.Forms.Button()
        Me.Queries_Button = New System.Windows.Forms.Button()
        Me.NewAcc_Button = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1083, 63)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(187, 65)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(899, 510)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.Home_Button)
        Me.Panel2.Controls.Add(Me.LoanApproval_Button)
        Me.Panel2.Controls.Add(Me.Queries_Button)
        Me.Panel2.Controls.Add(Me.NewAcc_Button)
        Me.Panel2.Location = New System.Drawing.Point(3, 62)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 513)
        Me.Panel2.TabIndex = 1
        '
        'Home_Button
        '
        Me.Home_Button.BackColor = System.Drawing.Color.DarkBlue
        Me.Home_Button.Font = New System.Drawing.Font("Corbel", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Home_Button.Location = New System.Drawing.Point(0, 0)
        Me.Home_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Home_Button.Name = "Home_Button"
        Me.Home_Button.Size = New System.Drawing.Size(187, 76)
        Me.Home_Button.TabIndex = 31
        Me.Home_Button.Text = "Home"
        Me.Home_Button.UseVisualStyleBackColor = False
        '
        'LoanApproval_Button
        '
        Me.LoanApproval_Button.BackColor = System.Drawing.Color.DarkBlue
        Me.LoanApproval_Button.Font = New System.Drawing.Font("Corbel", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanApproval_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LoanApproval_Button.Location = New System.Drawing.Point(3, 189)
        Me.LoanApproval_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LoanApproval_Button.Name = "LoanApproval_Button"
        Me.LoanApproval_Button.Size = New System.Drawing.Size(187, 76)
        Me.LoanApproval_Button.TabIndex = 30
        Me.LoanApproval_Button.Text = "Loan Approvals"
        Me.LoanApproval_Button.UseVisualStyleBackColor = False
        '
        'Queries_Button
        '
        Me.Queries_Button.BackColor = System.Drawing.Color.DarkBlue
        Me.Queries_Button.Font = New System.Drawing.Font("Corbel", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Queries_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Queries_Button.Location = New System.Drawing.Point(3, 281)
        Me.Queries_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Queries_Button.Name = "Queries_Button"
        Me.Queries_Button.Size = New System.Drawing.Size(187, 76)
        Me.Queries_Button.TabIndex = 29
        Me.Queries_Button.Text = "Queries and Complaints"
        Me.Queries_Button.UseVisualStyleBackColor = False
        '
        'NewAcc_Button
        '
        Me.NewAcc_Button.BackColor = System.Drawing.Color.DarkBlue
        Me.NewAcc_Button.Font = New System.Drawing.Font("Corbel", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewAcc_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NewAcc_Button.Location = New System.Drawing.Point(0, 95)
        Me.NewAcc_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NewAcc_Button.Name = "NewAcc_Button"
        Me.NewAcc_Button.Size = New System.Drawing.Size(187, 76)
        Me.NewAcc_Button.TabIndex = 27
        Me.NewAcc_Button.Text = "New Account Registrations"
        Me.NewAcc_Button.UseVisualStyleBackColor = False
        '
        'Banking_Panel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1089, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Banking_Panel"
        Me.Text = "Banking_Panel"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LoanApproval_Button As Button
    Friend WithEvents Queries_Button As Button
    Friend WithEvents NewAcc_Button As Button
    Friend WithEvents Home_Button As Button
    Friend WithEvents Panel3 As Panel

End Class
