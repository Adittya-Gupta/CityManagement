<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class specific_course
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
        Education = New Button()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Education
        ' 
        Education.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Education.ForeColor = SystemColors.ActiveBorder
        Education.Location = New Point(49, 46)
        Education.Name = "Education"
        Education.Size = New Size(139, 41)
        Education.TabIndex = 51
        Education.Text = "Education"
        Education.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(193, 56)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(19, 20)
        Label1.TabIndex = 53
        Label1.Text = ">"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveBorder
        Button1.Location = New Point(217, 46)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 41)
        Button1.TabIndex = 54
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(361, 56)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(19, 20)
        Label2.TabIndex = 55
        Label2.Text = ">"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(385, 48)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 39)
        Button2.TabIndex = 56
        Button2.Text = "Course"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Lime
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Location = New Point(557, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(113, 39)
        Button3.TabIndex = 57
        Button3.Text = "Pay Now"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' specific_course
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1089, 713)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Education)
        Name = "specific_course"
        Text = "specific_course"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Education As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
