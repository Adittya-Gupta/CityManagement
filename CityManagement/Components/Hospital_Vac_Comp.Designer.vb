<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hospital_Vac_Comp
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Label3 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(190, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 29)
        Label3.TabIndex = 22
        Label3.Text = "Department  "
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = SystemColors.Control
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Image = Group_1891
        Button1.Location = New Point(821, 50)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 45)
        Button1.TabIndex = 19
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold)
        Label2.Location = New Point(17, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 29)
        Label2.TabIndex = 18
        Label2.Text = "Hos_ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label6.Location = New Point(389, 56)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 32)
        Label6.TabIndex = 29
        Label6.Text = "Vac_Ct"
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(516, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 32)
        Label1.TabIndex = 30
        Label1.Text = "Description :"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.FlatAppearance.BorderColor = SystemColors.Control
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(669, 54)
        Button2.Name = "Button2"
        Button2.Size = New Size(110, 37)
        Button2.TabIndex = 31
        Button2.Text = "View"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Hospital_Vac_Comp
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Name = "Hospital_Vac_Comp"
        Size = New Size(970, 141)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button

End Class
