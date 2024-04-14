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
        Label3 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Panel = New Panel()
        Label6 = New Label()
        TextBox4 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.ForeColor = SystemColors.ActiveBorder
        Button1.Location = New Point(33, 8)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 20)
        Button1.TabIndex = 0
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(122, 10)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 15)
        Label1.TabIndex = 3
        Label1.Text = ">"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(144, 10)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 4
        Label2.Text = "Add course"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.AppWorkspace
        Label3.Location = New Point(64, 46)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 6
        Label3.Text = "Course Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(172, 46)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(212, 23)
        TextBox1.TabIndex = 7
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlDark
        Button2.Location = New Point(542, 86)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 20)
        Button2.TabIndex = 8
        Button2.Text = "Course Image"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(665, 86)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(62, 54)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(172, 86)
        TextBox2.Margin = New Padding(2)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(314, 53)
        TextBox2.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.AppWorkspace
        Label4.Location = New Point(33, 86)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 15)
        Label4.TabIndex = 12
        Label4.Text = "Course Description"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.AppWorkspace
        Label5.Location = New Point(450, 49)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 15)
        Label5.TabIndex = 13
        Label5.Text = "Limit"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(514, 46)
        TextBox3.Margin = New Padding(2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(44, 23)
        TextBox3.TabIndex = 14
        ' 
        ' Panel
        ' 
        Panel.BackColor = SystemColors.ControlLight
        Panel.Location = New Point(665, 207)
        Panel.Margin = New Padding(2)
        Panel.Name = "Panel"
        Panel.Size = New Size(143, 267)
        Panel.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.AppWorkspace
        Label6.Location = New Point(607, 46)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(33, 15)
        Label6.TabIndex = 16
        Label6.Text = "Price"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(665, 45)
        TextBox4.Margin = New Padding(2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(64, 23)
        TextBox4.TabIndex = 17
        ' 
        ' addcourse_page
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(953, 535)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(Panel)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "addcourse_page"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox

End Class
