<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Newsletter_AddNews
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Newsletter_AddNews))
        Button10 = New Button()
        ComboBox1 = New ComboBox()
        Button15 = New Button()
        Button12 = New Button()
        PictureBox11 = New PictureBox()
        TextBox5 = New TextBox()
        Label9 = New Label()
        PictureBox15 = New PictureBox()
        Label7 = New Label()
        TextBox2 = New TextBox()
        Label6 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Goldenrod
        Button10.Cursor = Cursors.Hand
        Button10.FlatAppearance.BorderSize = 0
        Button10.Font = New Font("Bodoni MT", 13.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = Color.Black
        Button10.Location = New Point(863, 96)
        Button10.Margin = New Padding(0)
        Button10.Name = "Button10"
        Button10.Size = New Size(226, 53)
        Button10.TabIndex = 49
        Button10.Text = "UPLOAD IMAGE: "
        Button10.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.WhiteSmoke
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(348, 215)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(473, 32)
        ComboBox1.TabIndex = 48
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.Black
        Button15.FlatStyle = FlatStyle.Popup
        Button15.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button15.ForeColor = Color.White
        Button15.Location = New Point(882, 419)
        Button15.Name = "Button15"
        Button15.Size = New Size(160, 84)
        Button15.TabIndex = 47
        Button15.Text = "SEND TO PUBLISH"
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.Black
        Button12.FlatStyle = FlatStyle.Popup
        Button12.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = Color.White
        Button12.Location = New Point(882, 509)
        Button12.Name = "Button12"
        Button12.Size = New Size(160, 47)
        Button12.TabIndex = 46
        Button12.Text = "PAY NOW"
        Button12.UseVisualStyleBackColor = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = My.Resources.Resources.newspaper
        PictureBox11.Location = New Point(12, 100)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(167, 155)
        PictureBox11.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox11.TabIndex = 45
        PictureBox11.TabStop = False
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.WhiteSmoke
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(113, 333)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(737, 259)
        TextBox5.TabIndex = 44
        TextBox5.Text = resources.GetString("TextBox5.Text")
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Bodoni MT", 10.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(8, 443)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 21)
        Label9.TabIndex = 43
        Label9.Text = "CONTENT: "
        ' 
        ' PictureBox15
        ' 
        PictureBox15.BorderStyle = BorderStyle.FixedSingle
        PictureBox15.Location = New Point(856, 152)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(233, 220)
        PictureBox15.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox15.TabIndex = 42
        PictureBox15.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bodoni MT", 10.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(202, 221)
        Label7.Name = "Label7"
        Label7.Size = New Size(134, 21)
        Label7.TabIndex = 41
        Label7.Text = "SELECT TYPE: "
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.WhiteSmoke
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(350, 168)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(471, 32)
        TextBox2.TabIndex = 40
        TextBox2.Text = "National Press"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bodoni MT", 10.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(187, 169)
        Label6.Name = "Label6"
        Label6.Size = New Size(149, 21)
        Label6.TabIndex = 39
        Label6.Text = "PUBLISHED BY: "
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(348, 100)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(471, 56)
        TextBox1.TabIndex = 38
        TextBox1.Text = "Historic Voter Turnout Expected in Upcoming National Elections News"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bodoni MT", 10.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(223, 120)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 21)
        Label5.TabIndex = 37
        Label5.Text = "HEADLINE: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bodoni MT", 35F, FontStyle.Bold)
        Label3.Location = New Point(5, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(1084, 71)
        Label3.TabIndex = 36
        Label3.Text = "Want to publish some news/Advertisement?"
        ' 
        ' Newsletter_AddNews
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.Cornsilk
        ClientSize = New Size(1107, 641)
        ControlBox = False
        Controls.Add(Button10)
        Controls.Add(ComboBox1)
        Controls.Add(Button15)
        Controls.Add(Button12)
        Controls.Add(PictureBox11)
        Controls.Add(TextBox5)
        Controls.Add(Label9)
        Controls.Add(PictureBox15)
        Controls.Add(Label7)
        Controls.Add(TextBox2)
        Controls.Add(Label6)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Newsletter_AddNews"
        Text = "MainPanel"
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button10 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button15 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
