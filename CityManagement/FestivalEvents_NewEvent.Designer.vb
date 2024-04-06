<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FestivalEvents_NewEvent
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FestivalEvents_NewEvent))
        Label3 = New Label()
        EmailLabel = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Button2 = New Button()
        NameTextBox = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        Label10 = New Label()
        TextBox6 = New TextBox()
        PictureBox1 = New PictureBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label8 = New Label()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(124, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 29)
        Label3.TabIndex = 24
        Label3.Text = "Name"
        ' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.Font = New Font("Microsoft Sans Serif", 12F)
        EmailLabel.ForeColor = Color.White
        EmailLabel.Location = New Point(466, 132)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(74, 29)
        EmailLabel.TabIndex = 22
        EmailLabel.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(371, 90)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(226, 29)
        Label2.TabIndex = 26
        Label2.Text = "Register an Event "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(44, 90)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(295, 29)
        Label1.TabIndex = 25
        Label1.Text = "Events and Festivals    >"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.Location = New Point(733, 590)
        Button2.Name = "Button2"
        Button2.Size = New Size(210, 68)
        Button2.TabIndex = 42
        Button2.Text = "Request"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Font = New Font("Microsoft Sans Serif", 12F)
        NameTextBox.Location = New Point(484, 80)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(287, 35)
        NameTextBox.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(483, 42)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 24)
        Label4.TabIndex = 27
        Label4.Text = "Name of Event"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(902, 42)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 24)
        Label5.TabIndex = 29
        Label5.Text = "Date of Event"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 12F)
        TextBox2.Location = New Point(484, 191)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(287, 35)
        TextBox2.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(483, 154)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(233, 24)
        Label6.TabIndex = 31
        Label6.Text = "Expected space required"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(902, 154)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(273, 24)
        Label7.TabIndex = 33
        Label7.Text = "Expected timing of the event"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(133, 372)
        Button1.Name = "Button1"
        Button1.Size = New Size(210, 68)
        Button1.TabIndex = 38
        Button1.Text = "Upload an Image"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(482, 360)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(230, 24)
        Label10.TabIndex = 39
        Label10.Text = "Description of the event"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Microsoft Sans Serif", 12F)
        TextBox6.Location = New Point(483, 400)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(705, 150)
        TextBox6.TabIndex = 40
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(31, 42)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(384, 307)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 43
        PictureBox1.TabStop = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Abhaya Libre Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(902, 80)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(287, 31)
        DateTimePicker1.TabIndex = 45
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarFont = New Font("Abhaya Libre Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker2.DropDownAlign = LeftRightAlignment.Right
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(902, 196)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(287, 31)
        DateTimePicker2.TabIndex = 46
        DateTimePicker2.Value = New Date(2024, 4, 2, 13, 1, 0, 0)
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Exo 2", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(485, 308)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(80, 23)
        RadioButton1.TabIndex = 47
        RadioButton1.TabStop = True
        RadioButton1.Text = "Indoor"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Exo 2", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(571, 308)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(93, 23)
        RadioButton2.TabIndex = 48
        RadioButton2.TabStop = True
        RadioButton2.Text = "Outdoor"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(484, 266)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 24)
        Label8.TabIndex = 49
        Label8.Text = "Event Type" & vbCrLf
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Controls.Add(DateTimePicker2)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(NameTextBox)
        Panel1.Location = New Point(34, 174)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1277, 729)
        Panel1.TabIndex = 50
        ' 
        ' FestivalEvents_NewEvent
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1387, 970)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(EmailLabel)
        FormBorderStyle = FormBorderStyle.None
        Name = "FestivalEvents_NewEvent"
        Text = "FestivalEvents_NewEvent"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Button2 As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
End Class
