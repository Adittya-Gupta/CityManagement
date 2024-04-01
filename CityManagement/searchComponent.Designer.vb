<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchComponent
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(searchComponent))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label9 = New Label()
        Label10 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(912, 23)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(0, 20)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(912, 27)
        Panel2.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(360, 2)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 20)
        Label9.TabIndex = 18
        Label9.Text = "Label9"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(295, 2)
        Label10.Name = "Label10"
        Label10.Size = New Size(45, 20)
        Label10.TabIndex = 17
        Label10.Text = "Path:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(104, 2)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 20)
        Label8.TabIndex = 16
        Label8.Text = "Label8"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(39, 2)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 20)
        Label7.TabIndex = 15
        Label7.Text = "Bus ID:"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(17), CByte(31), CByte(68))
        Button3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Transparent
        Button3.Location = New Point(791, 63)
        Button3.Name = "Button3"
        Button3.Size = New Size(106, 43)
        Button3.TabIndex = 9
        Button3.Text = "Book"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(29, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 17)
        Label1.TabIndex = 10
        Label1.Text = "Female Price"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(29, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 17)
        Label2.TabIndex = 11
        Label2.Text = "Male Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(172, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 21)
        Label3.TabIndex = 12
        Label3.Text = "08:00:00"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(203, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 34)
        Label4.TabIndex = 13
        Label4.Text = "Label4"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(610, 63)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 21)
        Label5.TabIndex = 14
        Label5.Text = "09:00:00"
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(610, 88)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 34)
        Label6.TabIndex = 15
        Label6.Text = "Label6"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(305, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(283, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = SystemColors.ButtonShadow
        Label11.Location = New Point(29, 107)
        Label11.Name = "Label11"
        Label11.Size = New Size(106, 15)
        Label11.TabIndex = 17
        Label11.Text = "*prices are per unit"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(119, 65)
        Label12.Name = "Label12"
        Label12.Size = New Size(47, 15)
        Label12.TabIndex = 18
        Label12.Text = "Label12"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(119, 86)
        Label13.Name = "Label13"
        Label13.Size = New Size(47, 15)
        Label13.TabIndex = 19
        Label13.Text = "Label13"
        ' 
        ' searchComponent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(PictureBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(20, 20, 10, 10)
        Name = "searchComponent"
        Size = New Size(912, 125)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label

End Class
