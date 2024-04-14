<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class transport_cabuserhistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transport_cabuserhistory))
        Label8 = New Label()
        Label9 = New Label()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        Label46 = New Label()
        Label47 = New Label()
        Label48 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Button1 = New Button()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12.0F)
        Label8.Location = New Point(57, 42)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 21)
        Label8.TabIndex = 2
        Label8.Text = "Current Ride"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12.0F)
        Label9.Location = New Point(58, 197)
        Label9.Name = "Label9"
        Label9.Size = New Size(112, 21)
        Label9.TabIndex = 3
        Label9.Text = "Previous Rides"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(350, 11)
        PictureBox7.Margin = New Padding(3, 2, 3, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(21, 17)
        PictureBox7.TabIndex = 20
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Location = New Point(266, 11)
        PictureBox8.Margin = New Padding(3, 2, 3, 2)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(21, 17)
        PictureBox8.TabIndex = 19
        PictureBox8.TabStop = False
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.BackColor = Color.Transparent
        Label46.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label46.ForeColor = Color.Black
        Label46.Location = New Point(376, 7)
        Label46.Name = "Label46"
        Label46.Size = New Size(124, 24)
        Label46.TabIndex = 18
        Label46.Text = "User Activity"
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.BackColor = Color.Transparent
        Label47.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label47.ForeColor = Color.Silver
        Label47.Location = New Point(292, 7)
        Label47.Name = "Label47"
        Label47.Size = New Size(47, 24)
        Label47.TabIndex = 17
        Label47.Text = "Cab"
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.BackColor = Color.Transparent
        Label48.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label48.ForeColor = Color.Silver
        Label48.Location = New Point(56, 7)
        Label48.Name = "Label48"
        Label48.Size = New Size(185, 24)
        Label48.TabIndex = 16
        Label48.Text = "Transport Services"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(62, 72)
        FlowLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(834, 123)
        FlowLayoutPanel1.TabIndex = 21
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.AutoScroll = True
        FlowLayoutPanel2.Location = New Point(64, 232)
        FlowLayoutPanel2.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(832, 256)
        FlowLayoutPanel2.TabIndex = 30
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(797, 11)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 26)
        Button1.TabIndex = 31
        Button1.Text = "Book"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' transport_cabuserhistory
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1107, 760)
        Controls.Add(Button1)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox8)
        Controls.Add(Label46)
        Controls.Add(Label47)
        Controls.Add(Label48)
        Controls.Add(Label9)
        Controls.Add(Label8)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "transport_cabuserhistory"
        Text = "transport_cabuserhistory"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
End Class
