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
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(EventTime)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(EventDate)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(EventVenue)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(EventName)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(132, 137)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(991, 605)
        Panel1.TabIndex = 29
        ' 
        ' EventTime
        ' 
        EventTime.AutoSize = True
        EventTime.Location = New Point(610, 264)
        EventTime.Name = "EventTime"
        EventTime.Size = New Size(77, 25)
        EventTime.TabIndex = 7
        EventTime.Text = "7:00 PM"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(516, 264)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 25)
        Label8.TabIndex = 6
        Label8.Text = "Time :"
        ' 
        ' EventDate
        ' 
        EventDate.AutoSize = True
        EventDate.Location = New Point(610, 224)
        EventDate.Name = "EventDate"
        EventDate.Size = New Size(86, 25)
        EventDate.TabIndex = 5
        EventDate.Text = "12/04/24"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(516, 224)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 25)
        Label6.TabIndex = 4
        Label6.Text = "Date :"
        ' 
        ' EventVenue
        ' 
        EventVenue.AutoSize = True
        EventVenue.Location = New Point(610, 184)
        EventVenue.Name = "EventVenue"
        EventVenue.Size = New Size(137, 25)
        EventVenue.TabIndex = 3
        EventVenue.Text = "Central Stadium"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(516, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 25)
        Label4.TabIndex = 2
        Label4.Text = "Venue :"
        ' 
        ' EventName
        ' 
        EventName.AutoSize = True
        EventName.Font = New Font("Segoe UI", 18F)
        EventName.Location = New Point(516, 127)
        EventName.Name = "EventName"
        EventName.Size = New Size(107, 32)
        EventName.TabIndex = 1
        EventName.Text = "DJ Night"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(41, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(460, 260)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(132, 78)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 20)
        Label1.TabIndex = 27
        Label1.Text = "Events & Festivals  >"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(285, 78)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 20)
        Label2.TabIndex = 28
        Label2.Text = "Participant Registration"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightSkyBlue
        Button1.Font = New Font("Segoe UI", 20F)
        Button1.Location = New Point(41, 354)
        Button1.Name = "Button1"
        Button1.Size = New Size(318, 67)
        Button1.TabIndex = 8
        Button1.Text = "Register Now"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Event_Participation
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1395, 786)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "Event_Participation"
        Text = "Event_Participation"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
End Class
