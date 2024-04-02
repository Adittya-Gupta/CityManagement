<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ongoingride
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ongoingride))
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        PictureBox3 = New PictureBox()
        Label2 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Button4 = New Button()
        Label1 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(922, 163)
        Panel1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(151, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 28)
        Label5.TabIndex = 13
        Label5.Text = "Driver name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(151, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 28)
        Label4.TabIndex = 12
        Label4.Text = "Driver name"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(473, 78)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(125, 61)
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.OliveDrab
        Label2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label2.Location = New Point(782, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 6
        Label2.Text = "Ongoing"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(632, 97)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 28)
        Label7.TabIndex = 5
        Label7.Text = "RK Plaza"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(311, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 28)
        Label6.TabIndex = 4
        Label6.Text = "Rajiv Chowk"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 28)
        Label3.TabIndex = 1
        Label3.Text = "150 Rs" & vbCrLf
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.OliveDrab
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(922, 27)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkGray
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(0, 33)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(922, 39)
        Panel3.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Black
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(744, -3)
        Button4.Name = "Button4"
        Button4.Size = New Size(178, 46)
        Button4.TabIndex = 29
        Button4.Text = "End Ride"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(15, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 0
        Label1.Text = "DEPARTURE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(136, 4)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 28)
        Label8.TabIndex = 14
        Label8.Text = "TIME"
        ' 
        ' ongoingride
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "ongoingride"
        Size = New Size(927, 168)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label

End Class
