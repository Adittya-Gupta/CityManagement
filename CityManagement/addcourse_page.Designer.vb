<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addcourse_page
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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Panel = New Panel()
        TextBox4 = New TextBox()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.ForeColor = SystemColors.ActiveBorder
        Button1.Location = New Point(51, 14)
        Button1.Margin = New Padding(2, 3, 2, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 27)
        Button1.TabIndex = 0
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(176, 17)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(19, 20)
        Label1.TabIndex = 3
        Label1.Text = ">"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(199, 17)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 20)
        Label2.TabIndex = 4
        Label2.Text = "Add course"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(253, 79)
        TextBox1.Margin = New Padding(2, 3, 2, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(242, 27)
        TextBox1.TabIndex = 7
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlDark
        Button2.Font = New Font("Segoe UI", 10F)
        Button2.Location = New Point(663, 152)
        Button2.Margin = New Padding(2, 3, 2, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 42)
        Button2.TabIndex = 8
        Button2.Text = "Course Image"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(820, 127)
        PictureBox1.Margin = New Padding(2, 3, 2, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(116, 127)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(253, 152)
        TextBox2.Margin = New Padding(2, 3, 2, 3)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(302, 69)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(651, 79)
        TextBox3.Margin = New Padding(2, 3, 2, 3)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(50, 27)
        TextBox3.TabIndex = 14
        ' 
        ' Panel
        ' 
        Panel.BackColor = SystemColors.ControlLight
        Panel.Location = New Point(734, 270)
        Panel.Margin = New Padding(2, 3, 2, 3)
        Panel.Name = "Panel"
        Panel.Size = New Size(163, 386)
        Panel.TabIndex = 15
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(904, 79)
        TextBox4.Margin = New Padding(2, 3, 2, 3)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(73, 27)
        TextBox4.TabIndex = 17
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ControlDark
        Button3.Font = New Font("Segoe UI", 10F)
        Button3.Location = New Point(792, 70)
        Button3.Margin = New Padding(2, 3, 2, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(78, 42)
        Button3.TabIndex = 18
        Button3.Text = "Price"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ControlDark
        Button4.Font = New Font("Segoe UI", 10F)
        Button4.Location = New Point(554, 70)
        Button4.Margin = New Padding(2, 3, 2, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(78, 42)
        Button4.TabIndex = 19
        Button4.Text = "Limit"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ControlDark
        Button5.Font = New Font("Segoe UI", 10F)
        Button5.Location = New Point(109, 70)
        Button5.Margin = New Padding(2, 3, 2, 3)
        Button5.Name = "Button5"
        Button5.Size = New Size(140, 42)
        Button5.TabIndex = 20
        Button5.Text = "Course Name"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ControlDark
        Button6.Font = New Font("Segoe UI", 10F)
        Button6.Location = New Point(58, 152)
        Button6.Margin = New Padding(2, 3, 2, 3)
        Button6.Name = "Button6"
        Button6.Size = New Size(191, 42)
        Button6.TabIndex = 21
        Button6.Text = "Course Description"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' addcourse_page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1107, 760)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(TextBox4)
        Controls.Add(Panel)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 3, 2, 3)
        Name = "addcourse_page"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button

End Class
