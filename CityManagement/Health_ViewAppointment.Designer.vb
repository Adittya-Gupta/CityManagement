<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Health_ViewAppointment
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
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1107, 80)
        Panel1.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Black
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Segoe UI", 18F)
        Label4.ForeColor = SystemColors.GrayText
        Label4.Location = New Point(26, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(199, 41)
        Label4.TabIndex = 3
        Label4.Text = "Specialization"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Segoe UI", 18F)
        Label3.ForeColor = SystemColors.GrayText
        Label3.Location = New Point(614, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(205, 41)
        Label3.TabIndex = 2
        Label3.Text = "Health Record"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Segoe UI", 18F)
        Label2.ForeColor = SystemColors.GrayText
        Label2.Location = New Point(349, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 41)
        Label2.TabIndex = 1
        Label2.Text = "Hospitals"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(958, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 41)
        Label1.TabIndex = 0
        Label1.Text = "Work"
        ' 
        ' Health_ViewAppointment
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 760)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Health_ViewAppointment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Health_ViewAppointment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
