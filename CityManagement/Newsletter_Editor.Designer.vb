<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Newsletter_Editor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Newsletter_Editor))
        TextBox3 = New TextBox()
        Label10 = New Label()
        Button19 = New Button()
        Button18 = New Button()
        Button17 = New Button()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        DataGridView1 = New DataGridView()
        Button16 = New Button()
        Button15 = New Button()
        Button14 = New Button()
        Button13 = New Button()
        Button12 = New Button()
        Label12 = New Label()
        TextBox7 = New TextBox()
        TextBox5 = New TextBox()
        Label9 = New Label()
        TextBox4 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        PictureBox15 = New PictureBox()
        TextBox2 = New TextBox()
        Label6 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        PictureBox13 = New PictureBox()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.WhiteSmoke
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(536, 113)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(89, 23)
        TextBox3.TabIndex = 64
        TextBox3.Text = "--"
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Bodoni MT", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(428, 113)
        Label10.Name = "Label10"
        Label10.Size = New Size(102, 23)
        Label10.TabIndex = 63
        Label10.Text = "NEWS ID: "
        ' 
        ' Button19
        ' 
        Button19.BackColor = Color.Black
        Button19.FlatStyle = FlatStyle.Popup
        Button19.Font = New Font("Bodoni MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button19.ForeColor = Color.White
        Button19.Location = New Point(5, 351)
        Button19.Name = "Button19"
        Button19.Size = New Size(118, 47)
        Button19.TabIndex = 62
        Button19.Text = "REFRESH"
        Button19.UseVisualStyleBackColor = False
        ' 
        ' Button18
        ' 
        Button18.BackColor = Color.Bisque
        Button18.Cursor = Cursors.Hand
        Button18.FlatAppearance.BorderSize = 0
        Button18.Font = New Font("Bodoni MT", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button18.ForeColor = Color.Black
        Button18.Location = New Point(5, 75)
        Button18.Margin = New Padding(0)
        Button18.Name = "Button18"
        Button18.Size = New Size(133, 63)
        Button18.TabIndex = 61
        Button18.Text = "Search By Publisher:"
        Button18.UseVisualStyleBackColor = False
        ' 
        ' Button17
        ' 
        Button17.BackColor = Color.DarkOrange
        Button17.Cursor = Cursors.Hand
        Button17.FlatAppearance.BorderSize = 0
        Button17.Font = New Font("Bodoni MT", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button17.ForeColor = Color.Black
        Button17.Location = New Point(5, 6)
        Button17.Margin = New Padding(0)
        Button17.Name = "Button17"
        Button17.Size = New Size(133, 63)
        Button17.TabIndex = 60
        Button17.Text = "Search By Type:"
        Button17.UseVisualStyleBackColor = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = Color.Silver
        ComboBox3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(156, 22)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(254, 28)
        ComboBox3.TabIndex = 59
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.Silver
        ComboBox2.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(642, 196)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(181, 24)
        ComboBox2.TabIndex = 58
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Silver
        ComboBox1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(710, 110)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(208, 28)
        ComboBox1.TabIndex = 57
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(5, 426)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 24
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(883, 212)
        DataGridView1.TabIndex = 56
        ' 
        ' Button16
        ' 
        Button16.BackColor = Color.Black
        Button16.FlatStyle = FlatStyle.Popup
        Button16.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.ForeColor = Color.White
        Button16.Location = New Point(924, 374)
        Button16.Name = "Button16"
        Button16.Size = New Size(160, 47)
        Button16.TabIndex = 55
        Button16.Text = "DELETE"
        Button16.UseVisualStyleBackColor = False
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.Black
        Button15.FlatStyle = FlatStyle.Popup
        Button15.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button15.ForeColor = Color.White
        Button15.Location = New Point(924, 162)
        Button15.Name = "Button15"
        Button15.Size = New Size(160, 47)
        Button15.TabIndex = 54
        Button15.Text = "HOME"
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Button14
        ' 
        Button14.BackColor = Color.Black
        Button14.FlatStyle = FlatStyle.Popup
        Button14.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button14.ForeColor = Color.White
        Button14.Location = New Point(924, 321)
        Button14.Name = "Button14"
        Button14.Size = New Size(160, 47)
        Button14.TabIndex = 53
        Button14.Text = "ADD NEW"
        Button14.UseVisualStyleBackColor = False
        ' 
        ' Button13
        ' 
        Button13.BackColor = Color.Black
        Button13.FlatStyle = FlatStyle.Popup
        Button13.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button13.ForeColor = Color.White
        Button13.Location = New Point(924, 268)
        Button13.Name = "Button13"
        Button13.Size = New Size(160, 47)
        Button13.TabIndex = 52
        Button13.Text = "UPDATE"
        Button13.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.Black
        Button12.FlatStyle = FlatStyle.Popup
        Button12.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = Color.White
        Button12.Location = New Point(924, 215)
        Button12.Name = "Button12"
        Button12.Size = New Size(160, 47)
        Button12.TabIndex = 51
        Button12.Text = "PUBLISH"
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Bodoni MT", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(417, 197)
        Label12.Name = "Label12"
        Label12.Size = New Size(219, 23)
        Label12.TabIndex = 50
        Label12.Text = "PUBLISHED ON PAGE: "
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.WhiteSmoke
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(161, 84)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(249, 32)
        TextBox7.TabIndex = 49
        TextBox7.Text = "National Press"
        TextBox7.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.WhiteSmoke
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(131, 227)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(787, 189)
        TextBox5.TabIndex = 48
        TextBox5.Text = resources.GetString("TextBox5.Text")
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Bodoni MT", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(3, 245)
        Label9.Name = "Label9"
        Label9.Size = New Size(107, 23)
        Label9.TabIndex = 47
        Label9.Text = "CONTENT: "
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.WhiteSmoke
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(794, 153)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(110, 23)
        TextBox4.TabIndex = 46
        TextBox4.Text = "18-11-2024"
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Bodoni MT", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(715, 153)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 23)
        Label8.TabIndex = 45
        Label8.Text = "DATE: "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bodoni MT", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(643, 113)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 23)
        Label7.TabIndex = 44
        Label7.Text = "TYPE: "
        ' 
        ' PictureBox15
        ' 
        PictureBox15.BorderStyle = BorderStyle.FixedSingle
        PictureBox15.Location = New Point(901, 426)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(194, 212)
        PictureBox15.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox15.TabIndex = 43
        PictureBox15.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.WhiteSmoke
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(171, 196)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(229, 25)
        TextBox2.TabIndex = 42
        TextBox2.Text = "National Press"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bodoni MT", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(3, 198)
        Label6.Name = "Label6"
        Label6.Size = New Size(162, 23)
        Label6.TabIndex = 41
        Label6.Text = "PUBLISHED BY: "
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(161, 153)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(539, 36)
        TextBox1.TabIndex = 40
        TextBox1.Text = "Historic Voter Turnout Expected in Upcoming National Elections News"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bodoni MT", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(3, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 23)
        Label5.TabIndex = 39
        Label5.Text = "HEADLINE: "
        ' 
        ' PictureBox13
        ' 
        PictureBox13.Image = My.Resources.Resources.editor
        PictureBox13.Location = New Point(924, 4)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(160, 158)
        PictureBox13.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox13.TabIndex = 38
        PictureBox13.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bodoni MT", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(482, 6)
        Label3.Name = "Label3"
        Label3.Size = New Size(278, 78)
        Label3.TabIndex = 37
        Label3.Text = "EDITOR"
        ' 
        ' Newsletter_Editor
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.Cornsilk
        ClientSize = New Size(1107, 641)
        ControlBox = False
        Controls.Add(TextBox3)
        Controls.Add(Label10)
        Controls.Add(Button19)
        Controls.Add(Button18)
        Controls.Add(Button17)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Button16)
        Controls.Add(Button15)
        Controls.Add(Button14)
        Controls.Add(Button13)
        Controls.Add(Button12)
        Controls.Add(Label12)
        Controls.Add(TextBox7)
        Controls.Add(TextBox5)
        Controls.Add(Label9)
        Controls.Add(TextBox4)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(PictureBox15)
        Controls.Add(TextBox2)
        Controls.Add(Label6)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(PictureBox13)
        Controls.Add(Label3)
        Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Newsletter_Editor"
        Text = "Newsletter_Editor"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button19 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Label3 As Label
End Class
