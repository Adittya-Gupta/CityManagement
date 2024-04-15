<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Health_View_Previous_Vacancies
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
        Label8 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1254, 80)
        Panel1.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Black
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(118, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(187, 28)
        Label8.TabIndex = 2
        Label8.Text = "Create New Vacancy"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Black
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(461, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(220, 28)
        Label7.TabIndex = 1
        Label7.Text = "View Previous Vacancies"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(824, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 28)
        Label1.TabIndex = 0
        Label1.Text = "Doctor Employment Request"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(1041, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 23)
        Label2.TabIndex = 1
        Label2.Text = "Back"
        ' 
        ' Health_View_Previous_Vacancies
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1107, 760)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Health_View_Previous_Vacancies"
        Text = "Health_HospitalListing"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
