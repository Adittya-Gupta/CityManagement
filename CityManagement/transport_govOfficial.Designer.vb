<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transport_govOfficial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transport_govOfficial))
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        PictureBox2 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox8 = New TextBox()
        Label3 = New Label()
        DateTimePicker2 = New DateTimePicker()
        Button1 = New Button()
        Label12 = New Label()
        TextBox9 = New TextBox()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(642, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 48)
        Label1.TabIndex = 4
        Label1.Text = "         ADD BUS          "
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(834, 249)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 34)
        Label2.TabIndex = 7
        Label2.Text = "Path Id:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(862, 298)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 34)
        Label4.TabIndex = 9
        Label4.Text = "Daily:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(609, 346)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 34)
        Label5.TabIndex = 10
        Label5.Text = "Date:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(609, 393)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 34)
        Label6.TabIndex = 11
        Label6.Text = "M seat:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label7.ForeColor = Color.DimGray
        Label7.Location = New Point(609, 444)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 34)
        Label7.TabIndex = 12
        Label7.Text = "F seat:"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label8.ForeColor = Color.DimGray
        Label8.Location = New Point(784, 439)
        Label8.Name = "Label8"
        Label8.Size = New Size(123, 34)
        Label8.TabIndex = 13
        Label8.Text = "F price($):"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label9.ForeColor = Color.DimGray
        Label9.Location = New Point(784, 388)
        Label9.Name = "Label9"
        Label9.Size = New Size(131, 34)
        Label9.TabIndex = 14
        Label9.Text = "M price($):"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.BorderStyle = BorderStyle.Fixed3D
        Label10.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label10.ForeColor = Color.DimGray
        Label10.Location = New Point(607, 249)
        Label10.Name = "Label10"
        Label10.Size = New Size(89, 34)
        Label10.TabIndex = 15
        Label10.Text = "Bus Id:"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.BorderStyle = BorderStyle.Fixed3D
        Label11.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label11.ForeColor = Color.DimGray
        Label11.Location = New Point(609, 489)
        Label11.Name = "Label11"
        Label11.Size = New Size(162, 34)
        Label11.TabIndex = 16
        Label11.Text = "Driver Name:"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(524, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(564, 147)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(725, 249)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(31, 27)
        TextBox1.TabIndex = 18
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(725, 444)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(31, 27)
        TextBox2.TabIndex = 19
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(725, 393)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(31, 27)
        TextBox3.TabIndex = 20
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(946, 298)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(31, 27)
        TextBox4.TabIndex = 21
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(946, 253)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(31, 27)
        TextBox5.TabIndex = 22
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(905, 443)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(31, 27)
        TextBox6.TabIndex = 23
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(905, 392)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(31, 27)
        TextBox7.TabIndex = 24
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(706, 346)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(138, 27)
        DateTimePicker1.TabIndex = 25
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(784, 489)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(142, 27)
        TextBox8.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(608, 298)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 34)
        Label3.TabIndex = 27
        Label3.Text = "Time:"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarMonthBackground = SystemColors.Info
        DateTimePicker2.CustomFormat = "hh:mm:ss tt"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Location = New Point(706, 298)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.ShowUpDown = True
        DateTimePicker2.Size = New Size(109, 27)
        DateTimePicker2.TabIndex = 28
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(895, 626)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 38)
        Button1.TabIndex = 29
        Button1.Text = "Confirm"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.BorderStyle = BorderStyle.Fixed3D
        Label12.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label12.ForeColor = Color.DimGray
        Label12.Location = New Point(609, 536)
        Label12.Name = "Label12"
        Label12.Size = New Size(150, 34)
        Label12.TabIndex = 30
        Label12.Text = "Driver Num:"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(784, 536)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(142, 27)
        TextBox9.TabIndex = 31
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(516, 755)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.BackColor = Color.Black
        Button2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(12, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(156, 55)
        Button2.TabIndex = 33
        Button2.Text = "Main Page"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' transport_govOfficial
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1091, 760)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox9)
        Controls.Add(Label12)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker2)
        Controls.Add(Label3)
        Controls.Add(TextBox8)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox2)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "transport_govOfficial"
        Text = "transport_govOfficial"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
End Class
