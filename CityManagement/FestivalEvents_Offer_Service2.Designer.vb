<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FestivalEvents_Offer_Service2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FestivalEvents_Offer_Service2))
        Label1 = New Label()
        Panel1 = New Panel()
        Description = New Label()
        EventTime = New Label()
        Label8 = New Label()
        EventDate = New Label()
        Label6 = New Label()
        EventVenue = New Label()
        Label4 = New Label()
        EventName = New Label()
        Label10 = New Label()
        FlowLayoutPanelVendorServices = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Abhaya Libre Medium", 16F)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(33, 22)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 32)
        Label1.TabIndex = 24
        Label1.Text = "Events Festivals  >"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.Controls.Add(Description)
        Panel1.Controls.Add(EventTime)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(EventDate)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(EventVenue)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(EventName)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(FlowLayoutPanelVendorServices)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(32, 70)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1034, 631)
        Panel1.TabIndex = 26
        ' 
        ' Description
        ' 
        Description.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Description.Location = New Point(678, 216)
        Description.Name = "Description"
        Description.Size = New Size(328, 98)
        Description.TabIndex = 18
        Description.Text = "Label3"
        ' 
        ' EventTime
        ' 
        EventTime.AutoSize = True
        EventTime.Font = New Font("Abhaya Libre Medium", 18F)
        EventTime.Location = New Point(794, 173)
        EventTime.Name = "EventTime"
        EventTime.Size = New Size(112, 35)
        EventTime.TabIndex = 16
        EventTime.Text = "7:00 PM"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label8.Location = New Point(675, 173)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 35)
        Label8.TabIndex = 15
        Label8.Text = "Time :"
        ' 
        ' EventDate
        ' 
        EventDate.AutoSize = True
        EventDate.Font = New Font("Abhaya Libre Medium", 18F)
        EventDate.Location = New Point(794, 141)
        EventDate.Name = "EventDate"
        EventDate.Size = New Size(125, 35)
        EventDate.TabIndex = 14
        EventDate.Text = "12/04/24"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label6.Location = New Point(675, 139)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 35)
        Label6.TabIndex = 13
        Label6.Text = "Date :"
        ' 
        ' EventVenue
        ' 
        EventVenue.AutoSize = True
        EventVenue.Font = New Font("Abhaya Libre Medium", 18F)
        EventVenue.Location = New Point(786, 106)
        EventVenue.Name = "EventVenue"
        EventVenue.Size = New Size(220, 35)
        EventVenue.TabIndex = 12
        EventVenue.Text = "Central Stadium"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Abhaya Libre Medium", 18F, FontStyle.Bold)
        Label4.Location = New Point(675, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 35)
        Label4.TabIndex = 11
        Label4.Text = "Venue :"
        ' 
        ' EventName
        ' 
        EventName.AutoSize = True
        EventName.Font = New Font("Abhaya Libre Medium", 28F)
        EventName.Location = New Point(675, 51)
        EventName.Name = "EventName"
        EventName.Size = New Size(188, 55)
        EventName.TabIndex = 10
        EventName.Text = "DJ Night"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Abhaya Libre Medium", 16F)
        Label10.Location = New Point(49, 282)
        Label10.Name = "Label10"
        Label10.Size = New Size(239, 32)
        Label10.TabIndex = 8
        Label10.Text = "Vendor Service Tags"
        ' 
        ' FlowLayoutPanelVendorServices
        ' 
        FlowLayoutPanelVendorServices.Location = New Point(49, 317)
        FlowLayoutPanelVendorServices.Name = "FlowLayoutPanelVendorServices"
        FlowLayoutPanelVendorServices.Padding = New Padding(18, 17, 18, 17)
        FlowLayoutPanelVendorServices.Size = New Size(957, 293)
        FlowLayoutPanelVendorServices.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(49, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(500, 225)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Abhaya Libre Medium", 16F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(254, 22)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 32)
        Label2.TabIndex = 25
        Label2.Text = "Offer Services"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(-1, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1090, 713)
        Panel2.TabIndex = 28
        ' 
        ' FestivalEvents_Offer_Service2
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1107, 760)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "FestivalEvents_Offer_Service2"
        Text = "FestivalEvents_Offer_Service2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Description As Label
    Friend WithEvents EventTime As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EventDate As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents EventVenue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EventName As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents FlowLayoutPanelVendorServices As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
End Class
