<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Health_DoctorsEmployment
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
        Label1 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Button1 = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1254, 80)
        Panel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Segoe UI", 18.0F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(55, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 41)
        Label1.TabIndex = 0
        Label1.Text = "Apply For Work"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(235), CByte(231), CByte(231))
        Label2.Font = New Font("Segoe UI", 18.0F)
        Label2.Location = New Point(117, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(333, 57)
        Label2.TabIndex = 31
        Label2.Text = "Select Specialization"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 18.0F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(750, 148)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(385, 49)
        ComboBox1.TabIndex = 32
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(235), CByte(231), CByte(231))
        Label3.Font = New Font("Segoe UI", 18.0F)
        Label3.Location = New Point(277, 859)
        Label3.Name = "Label3"
        Label3.Size = New Size(700, 52)
        Label3.TabIndex = 34
        Label3.Text = "Browse or Drag n Drop Your Resume"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(92), CByte(137), CByte(181))
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 18.0F)
        Button1.Location = New Point(532, 931)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 63)
        Button1.TabIndex = 35
        Button1.Text = "Apply"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(117, 239)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1018, 583)
        FlowLayoutPanel1.TabIndex = 36
        ' 
        ' Health_DoctorsEmployment
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1254, 1026)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Health_DoctorsEmployment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Health_DoctorsEmployment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
