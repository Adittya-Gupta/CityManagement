<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transport_cabCards
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transport_cabCards))
        Panel3 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        Label7 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Panel2 = New Panel()
        Button2 = New Button()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkGray
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(-1, 21)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(922, 45)
        Panel3.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(834, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 25)
        Label3.TabIndex = 1
        Label3.Text = "150 Rs" & vbCrLf
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(5, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 22)
        Label4.TabIndex = 2
        Label4.Text = "Departure Time"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(169, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 20)
        Label5.TabIndex = 3
        Label5.Text = "11:00 AM"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(922, 193)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(411, 96)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(125, 61)
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(632, 113)
        Label7.Name = "Label7"
        Label7.Size = New Size(40, 22)
        Label7.TabIndex = 9
        Label7.Text = "To "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(239, 113)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 22)
        Label6.TabIndex = 8
        Label6.Text = "From"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(26, 136)
        Label8.Name = "Label8"
        Label8.Size = New Size(127, 22)
        Label8.TabIndex = 7
        Label8.Text = "Driver Name "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 22)
        Label2.TabIndex = 6
        Label2.Text = "Driver Name "
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Tomato
        Button1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(776, 104)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 45)
        Button1.TabIndex = 2
        Button1.Text = "Book"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightSkyBlue
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1173, 37)
        Panel2.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.YellowGreen
        Button2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(673, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 42)
        Button2.TabIndex = 11
        Button2.Text = "Pay"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' transport_cabCards
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "transport_cabCards"
        Size = New Size(922, 193)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button

End Class
