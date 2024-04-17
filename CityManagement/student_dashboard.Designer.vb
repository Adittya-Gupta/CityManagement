<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class student_dashboard
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
        Label1 = New Label()
        b2 = New Button()
        b1 = New Button()
        Lab2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(204, 11)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 28)
        Label1.TabIndex = 0
        Label1.Text = ">"
        ' 
        ' b2
        ' 
        b2.BackColor = Color.White
        b2.Font = New Font("Segoe UI", 9F)
        b2.ForeColor = SystemColors.ActiveCaptionText
        b2.Location = New Point(259, 12)
        b2.Margin = New Padding(4)
        b2.Name = "b2"
        b2.Size = New Size(134, 44)
        b2.TabIndex = 3
        b2.Text = "Dashboard"
        b2.UseVisualStyleBackColor = False
        ' 
        ' b1
        ' 
        b1.BackColor = Color.White
        b1.Font = New Font("Segoe UI", 9F)
        b1.ForeColor = SystemColors.ActiveBorder
        b1.Location = New Point(48, 12)
        b1.Margin = New Padding(4)
        b1.Name = "b1"
        b1.Size = New Size(134, 44)
        b1.TabIndex = 4
        b1.Text = "Education"
        b1.UseVisualStyleBackColor = False
        ' 
        ' Lab2
        ' 
        Lab2.AutoSize = True
        Lab2.Location = New Point(48, 73)
        Lab2.Margin = New Padding(4, 0, 4, 0)
        Lab2.Name = "Lab2"
        Lab2.Size = New Size(117, 25)
        Lab2.TabIndex = 5
        Lab2.Text = "My Learning"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Silver
        Label3.Font = New Font("Segoe UI", 8F)
        Label3.Location = New Point(48, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 19)
        Label3.TabIndex = 6
        Label3.Text = "In progress"
        ' 
        ' student_dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1107, 760)
        Controls.Add(Label3)
        Controls.Add(Lab2)
        Controls.Add(b1)
        Controls.Add(b2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 11F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "student_dashboard"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents b2 As Button
    Friend WithEvents b1 As Button
    Friend WithEvents Lab2 As Label
    Friend WithEvents Label3 As Label

End Class
