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
        SpaceRequired = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        DescriptionTextBox = New Label()
        EventDescription = New TextBox()
        EventImage = New PictureBox()
        EventDatePicker = New DateTimePicker()
        EventTimePicker = New DateTimePicker()
        Indoor = New RadioButton()
        Outdoor = New RadioButton()
        Label8 = New Label()
        Panel1 = New Panel()
        VenueTextBox = New TextBox()
        Label9 = New Label()
        CType(EventImage, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12.0F)
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
        EmailLabel.Font = New Font("Microsoft Sans Serif", 12.0F)
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
        Label2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        NameTextBox.Font = New Font("Microsoft Sans Serif", 12.0F)
        NameTextBox.Location = New Point(484, 80)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(287, 35)
        NameTextBox.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Exo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        Label5.Font = New Font("Exo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(902, 42)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 24)
        Label5.TabIndex = 29
        Label5.Text = "Date of Event"
        ' 
        ' SpaceRequired
        ' 
        SpaceRequired.Font = New Font("Microsoft Sans Serif", 12.0F)
        SpaceRequired.Location = New Point(484, 191)
        SpaceRequired.Name = "SpaceRequired"
        SpaceRequired.Size = New Size(287, 35)
        SpaceRequired.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Exo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        Label7.Font = New Font("Exo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        ' DescriptionTextBox
        ' 
        DescriptionTextBox.AutoSize = True
        DescriptionTextBox.Font = New Font("Exo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DescriptionTextBox.Location = New Point(482, 360)
        DescriptionTextBox.Margin = New Padding(4, 0, 4, 0)
        DescriptionTextBox.Name = "DescriptionTextBox"
        DescriptionTextBox.Size = New Size(230, 24)
        DescriptionTextBox.TabIndex = 39
        DescriptionTextBox.Text = "Description of the event"
        ' 
        ' EventDescription
        ' 
        EventDescription.Font = New Font("Microsoft Sans Serif", 12.0F)
        EventDescription.Location = New Point(483, 400)
        EventDescription.Multiline = True
        EventDescription.Name = "EventDescription"
        EventDescription.Size = New Size(705, 150)
        EventDescription.TabIndex = 40
        ' 
        ' EventImage
        ' 
        EventImage.Image = CType(resources.GetObject("EventImage.Image"), Image)
        EventImage.Location = New Point(31, 42)
        EventImage.Margin = New Padding(4, 5, 4, 5)
        EventImage.Name = "EventImage"
        EventImage.Size = New Size(384, 307)
        EventImage.SizeMode = PictureBoxSizeMode.StretchImage
        EventImage.TabIndex = 43
        EventImage.TabStop = False
        ' 
        ' EventDatePicker
        ' 
        EventDatePicker.CalendarFont = New Font("Abhaya Libre Medium", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EventDatePicker.Format = DateTimePickerFormat.Short
        EventDatePicker.Location = New Point(902, 80)
        EventDatePicker.Name = "EventDatePicker"
        EventDatePicker.Size = New Size(287, 31)
        EventDatePicker.TabIndex = 45
        ' 
        ' EventTimePicker
        ' 
        EventTimePicker.CalendarFont = New Font("Abhaya Libre Medium", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EventTimePicker.DropDownAlign = LeftRightAlignment.Right
        EventTimePicker.Format = DateTimePickerFormat.Time
        EventTimePicker.Location = New Point(902, 196)
        EventTimePicker.Name = "EventTimePicker"
        EventTimePicker.Size = New Size(287, 31)
        EventTimePicker.TabIndex = 46
        EventTimePicker.Value = New Date(2024, 4, 2, 13, 1, 0, 0)
        ' 
        ' Indoor
        ' 
        Indoor.AutoSize = True
        Indoor.Font = New Font("Exo 2", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Indoor.Location = New Point(485, 308)
        Indoor.Name = "Indoor"
        Indoor.Size = New Size(80, 23)
        Indoor.TabIndex = 47
        Indoor.TabStop = True
        Indoor.Text = "Indoor"
        Indoor.UseVisualStyleBackColor = True
        ' 
        ' Outdoor
        ' 
        Outdoor.AutoSize = True
        Outdoor.Font = New Font("Exo 2", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Outdoor.Location = New Point(571, 308)
        Outdoor.Name = "Outdoor"
        Outdoor.Size = New Size(93, 23)
        Outdoor.TabIndex = 48
        Outdoor.TabStop = True
        Outdoor.Text = "Outdoor"
        Outdoor.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Exo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        Panel1.Controls.Add(VenueTextBox)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Outdoor)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Indoor)
        Panel1.Controls.Add(EventTimePicker)
        Panel1.Controls.Add(EventDatePicker)
        Panel1.Controls.Add(EventImage)
        Panel1.Controls.Add(EventDescription)
        Panel1.Controls.Add(DescriptionTextBox)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(SpaceRequired)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(NameTextBox)
        Panel1.Location = New Point(34, 174)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1277, 729)
        Panel1.TabIndex = 50
        ' 
        ' VenueTextBox
        ' 
        VenueTextBox.Font = New Font("Microsoft Sans Serif", 12.0F)
        VenueTextBox.Location = New Point(902, 300)
        VenueTextBox.Name = "VenueTextBox"
        VenueTextBox.Size = New Size(287, 35)
        VenueTextBox.TabIndex = 51
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Exo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(900, 266)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 24)
        Label9.TabIndex = 50
        Label9.Text = "Event Venue"
        ' 
        ' FestivalEvents_NewEvent
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
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
        CType(EventImage, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SpaceRequired As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DescriptionTextBox As Label
    Friend WithEvents EventDescription As TextBox
    Friend WithEvents EventImage As PictureBox
    Friend WithEvents EventDatePicker As DateTimePicker
    Friend WithEvents EventTimePicker As DateTimePicker
    Friend WithEvents Indoor As RadioButton
    Friend WithEvents Outdoor As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents VenueTextBox As TextBox
End Class
