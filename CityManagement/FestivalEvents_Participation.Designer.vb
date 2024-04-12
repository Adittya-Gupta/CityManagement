<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Event_Participation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Event_Participation))
        Panel1 = New Panel()
        Label9 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        maxage = New Label()
        capacity = New Label()
        minage = New Label()
        Description = New Label()
        Button1 = New Button()
        EventTime = New Label()
        Label8 = New Label()
        EventDate = New Label()
        Label6 = New Label()
        EventVenue = New Label()
        Label4 = New Label()
        EventName = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(maxage)
        Panel1.Controls.Add(capacity)
        Panel1.Controls.Add(minage)
        Panel1.Controls.Add(Description)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(EventTime)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(EventDate)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(EventVenue)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(EventName)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(29, 140)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1182, 712)
        Panel1.TabIndex = 29
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label9.Location = New Point(766, 343)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 28)
        Label9.TabIndex = 15
        Label9.Text = "Capacity : "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label7.Location = New Point(765, 300)
        Label7.Name = "Label7"
        Label7.Size = New Size(175, 28)
        Label7.TabIndex = 14
        Label7.Text = "Maximum Age :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label3.Location = New Point(766, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(174, 28)
        Label3.TabIndex = 13
        Label3.Text = "Minimum Age :"
        ' 
        ' maxage
        ' 
        maxage.AutoSize = True
        maxage.Font = New Font("Abhaya Libre Medium", 18F)
        maxage.Location = New Point(945, 300)
        maxage.Name = "maxage"
        maxage.Size = New Size(162, 28)
        maxage.TabIndex = 12
        maxage.Text = "Maximum Age :"
        ' 
        ' capacity
        ' 
        capacity.AutoSize = True
        capacity.Font = New Font("Abhaya Libre Medium", 18F)
        capacity.Location = New Point(896, 343)
        capacity.Name = "capacity"
        capacity.Size = New Size(113, 28)
        capacity.TabIndex = 11
        capacity.Text = "Capacity : "
        ' 
        ' minage
        ' 
        minage.AutoSize = True
        minage.Font = New Font("Abhaya Libre Medium", 18F)
        minage.Location = New Point(945, 261)
        minage.Name = "minage"
        minage.Size = New Size(161, 28)
        minage.TabIndex = 10
        minage.Text = "Minimum Age :"
        ' 
        ' Description
        ' 
        Description.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Description.Location = New Point(766, 386)
        Description.Name = "Description"
        Description.Size = New Size(315, 153)
        Description.TabIndex = 9
        Description.Text = "Description"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Abhaya Libre Medium", 24F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(766, 571)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(315, 83)
        Button1.TabIndex = 8
        Button1.Text = "Register Now"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' EventTime
        ' 
        EventTime.AutoSize = True
        EventTime.Font = New Font("Abhaya Libre Medium", 18F)
        EventTime.Location = New Point(859, 222)
        EventTime.Name = "EventTime"
        EventTime.Size = New Size(89, 28)
        EventTime.TabIndex = 7
        EventTime.Text = "7:00 PM"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label8.Location = New Point(766, 222)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 28)
        Label8.TabIndex = 6
        Label8.Text = "Time :"
        ' 
        ' EventDate
        ' 
        EventDate.AutoSize = True
        EventDate.Font = New Font("Abhaya Libre Medium", 18F)
        EventDate.Location = New Point(859, 182)
        EventDate.Name = "EventDate"
        EventDate.Size = New Size(100, 28)
        EventDate.TabIndex = 5
        EventDate.Text = "12/04/24"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label6.Location = New Point(766, 182)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 28)
        Label6.TabIndex = 4
        Label6.Text = "Date :"
        ' 
        ' EventVenue
        ' 
        EventVenue.AutoSize = True
        EventVenue.Font = New Font("Abhaya Libre Medium", 18F)
        EventVenue.Location = New Point(859, 142)
        EventVenue.Name = "EventVenue"
        EventVenue.Size = New Size(175, 28)
        EventVenue.TabIndex = 3
        EventVenue.Text = "Central Stadium"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label4.Location = New Point(766, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 28)
        Label4.TabIndex = 2
        Label4.Text = "Venue :"
        ' 
        ' EventName
        ' 
        EventName.AutoSize = True
        EventName.Font = New Font("Abhaya Libre Medium", 28F)
        EventName.Location = New Point(766, 86)
        EventName.Name = "EventName"
        EventName.Size = New Size(153, 45)
        EventName.TabIndex = 1
        EventName.Text = "DJ Night"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(63, 142)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(622, 453)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Abhaya Libre Medium", 28F)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(29, 62)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 45)
        Label1.TabIndex = 27
        Label1.Text = "Events Festivals  >"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Abhaya Libre Medium", 28F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(320, 62)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(394, 45)
        Label2.TabIndex = 28
        Label2.Text = "Participant Registration"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(96, 12)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1254, 896)
        Panel2.TabIndex = 30
        ' 
        ' Event_Participation
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1444, 900)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Event_Participation"
        Text = "Event_Participation"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EventTime As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EventDate As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents EventVenue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EventName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents maxage As Label
    Friend WithEvents capacity As Label
    Friend WithEvents minage As Label
    Friend WithEvents Description As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
End Class
