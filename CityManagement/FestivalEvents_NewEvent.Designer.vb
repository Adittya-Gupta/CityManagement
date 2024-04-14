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
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(112, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 25)
        Label3.TabIndex = 24
        Label3.Text = "Name"
        ' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.Font = New Font("Microsoft Sans Serif", 12F)
        EmailLabel.ForeColor = Color.White
        EmailLabel.Location = New Point(419, 111)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(60, 25)
        EmailLabel.TabIndex = 22
        EmailLabel.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(280, 68)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 25)
        Label2.TabIndex = 26
        Label2.Text = "Register an Event "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(23, 68)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 25)
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
        Button2.BackColor = Color.Black
        Button2.ForeColor = Color.White
        Button2.Location = New Point(618, 492)
        Button2.Name = "Button2"
        Button2.Size = New Size(189, 57)
        Button2.TabIndex = 42
        Button2.Text = "Request"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Font = New Font("Microsoft Sans Serif", 12F)
        NameTextBox.Location = New Point(436, 67)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(259, 30)
        NameTextBox.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(435, 35)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 20)
        Label4.TabIndex = 27
        Label4.Text = "Name of Event"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(738, 35)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 20)
        Label5.TabIndex = 29
        Label5.Text = "Date of Event"
        ' 
        ' SpaceRequired
        ' 
        SpaceRequired.Font = New Font("Microsoft Sans Serif", 12F)
        SpaceRequired.Location = New Point(436, 160)
        SpaceRequired.Name = "SpaceRequired"
        SpaceRequired.Size = New Size(259, 30)
        SpaceRequired.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(435, 129)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(199, 20)
        Label6.TabIndex = 31
        Label6.Text = "Expected space required"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(738, 129)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(228, 20)
        Label7.TabIndex = 33
        Label7.Text = "Expected timing of the event"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(92, 313)
        Button1.Name = "Button1"
        Button1.Size = New Size(189, 57)
        Button1.TabIndex = 38
        Button1.Text = "Upload an Image"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DescriptionTextBox
        ' 
        DescriptionTextBox.AutoSize = True
        DescriptionTextBox.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DescriptionTextBox.Location = New Point(434, 302)
        DescriptionTextBox.Margin = New Padding(4, 0, 4, 0)
        DescriptionTextBox.Name = "DescriptionTextBox"
        DescriptionTextBox.Size = New Size(193, 20)
        DescriptionTextBox.TabIndex = 39
        DescriptionTextBox.Text = "Description of the event"
        ' 
        ' EventDescription
        ' 
        EventDescription.Font = New Font("Microsoft Sans Serif", 12F)
        EventDescription.Location = New Point(435, 336)
        EventDescription.Multiline = True
        EventDescription.Name = "EventDescription"
        EventDescription.Size = New Size(562, 127)
        EventDescription.TabIndex = 40
        ' 
        ' EventImage
        ' 
        EventImage.Image = CType(resources.GetObject("EventImage.Image"), Image)
        EventImage.Location = New Point(28, 35)
        EventImage.Margin = New Padding(4)
        EventImage.Name = "EventImage"
        EventImage.Size = New Size(330, 258)
        EventImage.SizeMode = PictureBoxSizeMode.StretchImage
        EventImage.TabIndex = 43
        EventImage.TabStop = False
        ' 
        ' EventDatePicker
        ' 
        EventDatePicker.CalendarFont = New Font("Abhaya Libre Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EventDatePicker.Format = DateTimePickerFormat.Short
        EventDatePicker.Location = New Point(738, 67)
        EventDatePicker.Name = "EventDatePicker"
        EventDatePicker.Size = New Size(259, 29)
        EventDatePicker.TabIndex = 45
        ' 
        ' EventTimePicker
        ' 
        EventTimePicker.CalendarFont = New Font("Abhaya Libre Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EventTimePicker.DropDownAlign = LeftRightAlignment.Right
        EventTimePicker.Format = DateTimePickerFormat.Time
        EventTimePicker.Location = New Point(738, 165)
        EventTimePicker.Name = "EventTimePicker"
        EventTimePicker.Size = New Size(259, 29)
        EventTimePicker.TabIndex = 46
        EventTimePicker.Value = New Date(2024, 4, 2, 13, 1, 0, 0)
        ' 
        ' Indoor
        ' 
        Indoor.AutoSize = True
        Indoor.Font = New Font("Exo 2", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Indoor.Location = New Point(436, 259)
        Indoor.Name = "Indoor"
        Indoor.Size = New Size(71, 21)
        Indoor.TabIndex = 47
        Indoor.TabStop = True
        Indoor.Text = "Indoor"
        Indoor.UseVisualStyleBackColor = True
        ' 
        ' Outdoor
        ' 
        Outdoor.AutoSize = True
        Outdoor.Font = New Font("Exo 2", 7.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Outdoor.Location = New Point(514, 259)
        Outdoor.Name = "Outdoor"
        Outdoor.Size = New Size(81, 21)
        Outdoor.TabIndex = 48
        Outdoor.TabStop = True
        Outdoor.Text = "Outdoor"
        Outdoor.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(436, 223)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(95, 20)
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
        Panel1.Location = New Point(31, 111)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1043, 616)
        Panel1.TabIndex = 50
        ' 
        ' VenueTextBox
        ' 
        VenueTextBox.Font = New Font("Microsoft Sans Serif", 12F)
        VenueTextBox.Location = New Point(738, 252)
        VenueTextBox.Name = "VenueTextBox"
        VenueTextBox.Size = New Size(259, 30)
        VenueTextBox.TabIndex = 51
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Exo 2", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(736, 223)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 20)
        Label9.TabIndex = 50
        Label9.Text = "Event Venue"
        ' 
        ' FestivalEvents_NewEvent
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 760)
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
