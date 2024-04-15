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
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Button1 = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        backButton = New Button()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(235), CByte(231), CByte(231))
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(67, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(259, 49)
        Label2.TabIndex = 31
        Label2.Text = "Select Specialization"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 18F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(460, 31)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(385, 49)
        ComboBox1.TabIndex = 32
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(235), CByte(231), CByte(231))
        Label3.Font = New Font("Segoe UI", 18F)
        Label3.Location = New Point(67, 520)
        Label3.Name = "Label3"
        Label3.Size = New Size(459, 52)
        Label3.TabIndex = 34
        Label3.Text = "Browse Your Resume"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(92), CByte(137), CByte(181))
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 18F)
        Button1.Location = New Point(478, 587)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 51)
        Button1.TabIndex = 35
        Button1.Text = "Apply"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(67, 161)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(973, 336)
        FlowLayoutPanel1.TabIndex = 36
        ' 
        ' backButton
        ' 
        backButton.AutoSize = True
        backButton.BackColor = Color.Black
        backButton.Cursor = Cursors.Hand
        backButton.FlatAppearance.BorderSize = 0
        backButton.FlatStyle = FlatStyle.Flat
        backButton.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backButton.ForeColor = Color.White
        backButton.Location = New Point(950, 31)
        backButton.Name = "backButton"
        backButton.Size = New Size(90, 49)
        backButton.TabIndex = 37
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(610, 520)
        Label1.Name = "Label1"
        Label1.Size = New Size(430, 52)
        Label1.TabIndex = 38
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 18F)
        Label4.Location = New Point(243, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 48)
        Label4.TabIndex = 39
        Label4.Text = "Hospital"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 18F)
        Label5.Location = New Point(554, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 37)
        Label5.TabIndex = 40
        Label5.Text = "Location"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 18F)
        Label6.Location = New Point(745, 98)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 48)
        Label6.TabIndex = 41
        Label6.Text = "Vacancy"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Health_DoctorsEmployment
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 705)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(backButton)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Health_DoctorsEmployment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Health_DoctorsEmployment"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents backButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
