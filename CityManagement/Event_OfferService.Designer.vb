﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Event_OfferService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Event_OfferService))
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label10 = New Label()
        FlowLayoutPanelVendorServices = New FlowLayoutPanel()
        EventTime = New Label()
        Label8 = New Label()
        EventDate = New Label()
        Label6 = New Label()
        EventVenue = New Label()
        Label4 = New Label()
        EventName = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 24F)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(25, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(293, 37)
        Label1.TabIndex = 24
        Label1.Text = "Events & Festivals  >"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 24F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(317, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(217, 37)
        Label2.TabIndex = 25
        Label2.Text = "Offer Services"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(FlowLayoutPanelVendorServices)
        Panel1.Controls.Add(EventTime)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(EventDate)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(EventVenue)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(EventName)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(25, 50)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(828, 469)
        Panel1.TabIndex = 26
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 24F)
        Label10.Location = New Point(38, 288)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(205, 45)
        Label10.TabIndex = 8
        Label10.Text = "Services Tags"
        ' 
        ' FlowLayoutPanelVendorServices
        ' 
        FlowLayoutPanelVendorServices.Location = New Point(38, 329)
        FlowLayoutPanelVendorServices.Margin = New Padding(2, 2, 2, 2)
        FlowLayoutPanelVendorServices.Name = "FlowLayoutPanelVendorServices"
        FlowLayoutPanelVendorServices.Size = New Size(754, 126)
        FlowLayoutPanelVendorServices.TabIndex = 9
        ' 
        ' EventTime
        ' 
        EventTime.AutoSize = True
        EventTime.Location = New Point(639, 204)
        EventTime.Margin = New Padding(2, 0, 2, 0)
        EventTime.Name = "EventTime"
        EventTime.Size = New Size(49, 15)
        EventTime.TabIndex = 7
        EventTime.Text = "7:00 PM"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(573, 204)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 15)
        Label8.TabIndex = 6
        Label8.Text = "Time :"
        ' 
        ' EventDate
        ' 
        EventDate.AutoSize = True
        EventDate.Location = New Point(639, 181)
        EventDate.Margin = New Padding(2, 0, 2, 0)
        EventDate.Name = "EventDate"
        EventDate.Size = New Size(53, 15)
        EventDate.TabIndex = 5
        EventDate.Text = "12/04/24"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(573, 181)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 15)
        Label6.TabIndex = 4
        Label6.Text = "Date :"
        ' 
        ' EventVenue
        ' 
        EventVenue.AutoSize = True
        EventVenue.Location = New Point(639, 156)
        EventVenue.Margin = New Padding(2, 0, 2, 0)
        EventVenue.Name = "EventVenue"
        EventVenue.Size = New Size(92, 15)
        EventVenue.TabIndex = 3
        EventVenue.Text = "Central Stadium"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(573, 156)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 2
        Label4.Text = "Venue :"
        ' 
        ' EventName
        ' 
        EventName.AutoSize = True
        EventName.Font = New Font("Segoe UI", 18F)
        EventName.Location = New Point(573, 122)
        EventName.Margin = New Padding(2, 0, 2, 0)
        EventName.Name = "EventName"
        EventName.Size = New Size(107, 32)
        EventName.TabIndex = 1
        EventName.Text = "DJ Night"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(38, 29)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(471, 227)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(60, 14)
        Panel2.Margin = New Padding(2, 2, 2, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(878, 538)
        Panel2.TabIndex = 27
        ' 
        ' Event_OfferService
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1011, 540)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 2, 2, 2)
        Name = "Event_OfferService"
        Text = "Event_OfferService"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EventTime As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EventDate As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents EventVenue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EventName As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents FlowLayoutPanelVendorServices As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
End Class
