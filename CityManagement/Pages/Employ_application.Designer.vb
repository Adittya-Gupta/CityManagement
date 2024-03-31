<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployApplication
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
        backButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        RichTextBox3 = New RichTextBox()
        RichTextBox4 = New RichTextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.AutoSize = True
        backButton.BackColor = Color.Black
        backButton.Cursor = Cursors.Hand
        backButton.FlatAppearance.BorderSize = 0
        backButton.FlatStyle = FlatStyle.Flat
        backButton.Font = New Font("Exo 2", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backButton.ForeColor = Color.White
        backButton.Location = New Point(1131, 12)
        backButton.Name = "backButton"
        backButton.Size = New Size(111, 43)
        backButton.TabIndex = 30
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(91, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 35)
        Label1.TabIndex = 31
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(91, 306)
        Label2.Name = "Label2"
        Label2.Size = New Size(399, 44)
        Label2.TabIndex = 32
        Label2.Text = "Details of any previous work done"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(477, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 35)
        Label3.TabIndex = 33
        Label3.Text = "Contact Details"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(868, 440)
        Label4.Name = "Label4"
        Label4.Size = New Size(276, 36)
        Label4.TabIndex = 34
        Label4.Text = "Bank Account Details"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.Location = New Point(906, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(179, 35)
        Label5.TabIndex = 35
        Label5.Text = "Profile Picture"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 15F)
        Button1.Location = New Point(563, 824)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 55)
        Button1.TabIndex = 36
        Button1.Text = "Apply"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Mask_group
        PictureBox1.InitialImage = My.Resources.Resources.Mask_group
        PictureBox1.Location = New Point(949, 272)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 87)
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI", 12F)
        RichTextBox1.Location = New Point(91, 368)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(711, 346)
        RichTextBox1.TabIndex = 41
        RichTextBox1.Text = ""
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Font = New Font("Segoe UI", 12F)
        RichTextBox2.Location = New Point(477, 194)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(330, 41)
        RichTextBox2.TabIndex = 42
        RichTextBox2.Text = ""
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.Font = New Font("Segoe UI", 12F)
        RichTextBox3.Location = New Point(848, 506)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(330, 144)
        RichTextBox3.TabIndex = 43
        RichTextBox3.Text = ""
        ' 
        ' RichTextBox4
        ' 
        RichTextBox4.Font = New Font("Segoe UI", 12F)
        RichTextBox4.Location = New Point(91, 194)
        RichTextBox4.Name = "RichTextBox4"
        RichTextBox4.Size = New Size(330, 41)
        RichTextBox4.TabIndex = 44
        RichTextBox4.Text = ""
        ' 
        ' Label6
        ' 
        Label6.BackColor = SystemColors.ControlDark
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(412, 756)
        Label6.Name = "Label6"
        Label6.Size = New Size(445, 41)
        Label6.TabIndex = 45
        Label6.Text = "Browse or Drag n Drop any Document"
        ' 
        ' Label7
        ' 
        Label7.Cursor = Cursors.Hand
        Label7.Image = My.Resources.Resources.Vector
        Label7.Location = New Point(1021, 337)
        Label7.Name = "Label7"
        Label7.Size = New Size(30, 30)
        Label7.TabIndex = 46
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Abhaya Libre Medium", 25F)
        Label8.Location = New Point(473, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(329, 58)
        Label8.TabIndex = 47
        Label8.Text = "Application Form"
        ' 
        ' EmployApplication
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1254, 953)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(RichTextBox4)
        Controls.Add(RichTextBox3)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(backButton)
        FormBorderStyle = FormBorderStyle.None
        Name = "EmployApplication"
        Text = "EmployApplication"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
