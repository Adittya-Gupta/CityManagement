<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class my_learning
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
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Education
        ' 
        Education.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Education.ForeColor = SystemColors.ActiveBorder
        Education.Location = New Point(37, 33)
        Education.Name = "Education"
        Education.Size = New Size(139, 41)
        Education.TabIndex = 47
        Education.Text = "Education"
        Education.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(358, 35)
        Button1.Name = "Button1"
        Button1.Size = New Size(123, 39)
        Button1.TabIndex = 48
        Button1.Text = "My learning"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(181, 43)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(19, 20)
        Label1.TabIndex = 49
        Label1.Text = ">"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ActiveBorder
        Button2.Location = New Point(205, 33)
        Button2.Name = "Button2"
        Button2.Size = New Size(124, 41)
        Button2.TabIndex = 50
        Button2.Text = "Courses"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(334, 43)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(19, 20)
        Label2.TabIndex = 51
        Label2.Text = ">"
        ' 
        ' my_learning
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1089, 713)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Education)
        FormBorderStyle = FormBorderStyle.None
        Name = "my_learning"
        Text = "specific_coursepage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Education As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
End Class
