<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FestivalEvents_Approval
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
        Label3 = New Label()
        ToggleButton = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 30F)
        Label3.Location = New Point(34, 43)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(364, 58)
        Label3.TabIndex = 32
        Label3.Text = "Event Approval"
        ' 
        ' ToggleButton
        ' 
        ToggleButton.BackColor = Color.Black
        ToggleButton.FlatStyle = FlatStyle.Flat
        ToggleButton.Font = New Font("Segoe UI", 10F)
        ToggleButton.ForeColor = Color.White
        ToggleButton.Location = New Point(35, 356)
        ToggleButton.Name = "ToggleButton"
        ToggleButton.Size = New Size(198, 52)
        ToggleButton.TabIndex = 33
        ToggleButton.Text = "Approve"
        ToggleButton.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Bold)
        Label6.Location = New Point(25, 146)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(210, 31)
        Label6.TabIndex = 37
        Label6.Text = "Time : 8:00 Pm"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Bold)
        Label5.Location = New Point(25, 112)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(239, 31)
        Label5.TabIndex = 36
        Label5.Text = "Date: 11/06/2003"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Bold)
        Label4.Location = New Point(25, 79)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(217, 31)
        Label4.TabIndex = 35
        Label4.Text = "Venue : Central"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1, 16)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 46)
        Label1.TabIndex = 34
        Label1.Text = " DJ Night"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(34, 117)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(685, 219)
        Panel1.TabIndex = 38
        ' 
        ' FestivalEvents_Approval
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(ToggleButton)
        Controls.Add(Label3)
        FormBorderStyle = FormBorderStyle.None
        Name = "FestivalEvents_Approval"
        Text = "FestivalEvents_Approval"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents ToggleButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
