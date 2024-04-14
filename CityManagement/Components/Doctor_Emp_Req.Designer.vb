<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Doctor_Emp_Req
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
        Button2 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label1 = New Label()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(27, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 24)
        Label3.TabIndex = 22
        Label3.Text = "Department : "
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderColor = SystemColors.Control
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Image = My.Resources.Resources.Group_190
        Button2.Location = New Point(589, 56)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 34)
        Button2.TabIndex = 20
        Button2.Text = "Accept"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = SystemColors.Control
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.Group_1891
        Button1.Location = New Point(735, 56)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 34)
        Button1.TabIndex = 19
        Button1.Text = "Reject"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold)
        Label2.Location = New Point(79, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 24)
        Label2.TabIndex = 18
        Label2.Text = "Name : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label4.Location = New Point(168, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 25)
        Label4.TabIndex = 24
        Label4.Text = "Dr. S. K. Ghosh"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label5.Location = New Point(168, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 25)
        Label5.TabIndex = 27
        Label5.Text = "Cardiology"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(672, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 25)
        Label1.TabIndex = 28
        Label1.Text = "Label1"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Black
        Button4.FlatAppearance.BorderColor = SystemColors.Control
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button4.ForeColor = Color.Transparent
        Button4.Location = New Point(387, 52)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(114, 34)
        Button4.TabIndex = 30
        Button4.Text = "Resume.pdf"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Doctor_Emp_Req
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Doctor_Emp_Req"
        Size = New Size(863, 112)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button

End Class
