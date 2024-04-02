<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Historyfilter
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
        Label3 = New Label()
        TrackBar2 = New TrackBar()
        Label2 = New Label()
        Label4 = New Label()
        TrackBar1 = New TrackBar()
        CheckBox1 = New CheckBox()
        Label5 = New Label()
        Label1 = New Label()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        Label6 = New Label()
        CheckBox7 = New CheckBox()
        CType(TrackBar2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Abhaya Libre Medium", 10F)
        Label3.Location = New Point(12, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 25)
        Label3.TabIndex = 0
        Label3.Text = "Time"
        ' 
        ' TrackBar2
        ' 
        TrackBar2.AutoSize = False
        TrackBar2.BackColor = Color.Black
        TrackBar2.Cursor = Cursors.Hand
        TrackBar2.Location = New Point(9, 134)
        TrackBar2.Maximum = 13
        TrackBar2.Minimum = 1
        TrackBar2.Name = "TrackBar2"
        TrackBar2.Size = New Size(341, 45)
        TrackBar2.TabIndex = 1
        TrackBar2.TickStyle = TickStyle.Both
        TrackBar2.Value = 13
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Abhaya Libre Medium", 10F)
        Label2.Location = New Point(212, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 25)
        Label2.TabIndex = 2
        Label2.Text = "Below 10 km"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Abhaya Libre Medium", 10F)
        Label4.Location = New Point(212, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 25)
        Label4.TabIndex = 5
        Label4.Text = "64 years ago"
        ' 
        ' TrackBar1
        ' 
        TrackBar1.AutoSize = False
        TrackBar1.BackColor = Color.Black
        TrackBar1.Cursor = Cursors.Hand
        TrackBar1.Location = New Point(9, 37)
        TrackBar1.Minimum = 1
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Size = New Size(341, 45)
        TrackBar1.TabIndex = 4
        TrackBar1.TickStyle = TickStyle.Both
        TrackBar1.Value = 10
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Appearance = Appearance.Button
        CheckBox1.BackColor = Color.Black
        CheckBox1.Font = New Font("Abhaya Libre Medium", 10F)
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(12, 228)
        CheckBox1.Margin = New Padding(0)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(167, 64)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Time"
        CheckBox1.TextAlign = ContentAlignment.MiddleCenter
        CheckBox1.ThreeState = True
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Abhaya Libre Medium", 10F)
        Label5.Location = New Point(122, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 25)
        Label5.TabIndex = 8
        Label5.Text = "Sort By"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Abhaya Libre Medium", 10F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 25)
        Label1.TabIndex = 9
        Label1.Text = "Location"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.Appearance = Appearance.Button
        CheckBox2.BackColor = Color.Black
        CheckBox2.Font = New Font("Abhaya Libre Medium", 10F)
        CheckBox2.ForeColor = Color.White
        CheckBox2.Location = New Point(9, 342)
        CheckBox2.Margin = New Padding(0)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(167, 64)
        CheckBox2.TabIndex = 13
        CheckBox2.Text = "Enquiry Sent"
        CheckBox2.TextAlign = ContentAlignment.MiddleCenter
        CheckBox2.TextImageRelation = TextImageRelation.ImageBeforeText
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox3
        ' 
        CheckBox3.Appearance = Appearance.Button
        CheckBox3.BackColor = Color.Black
        CheckBox3.Font = New Font("Abhaya Libre Medium", 10F)
        CheckBox3.ForeColor = Color.White
        CheckBox3.Location = New Point(9, 498)
        CheckBox3.Margin = New Padding(0)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(167, 64)
        CheckBox3.TabIndex = 14
        CheckBox3.Text = "Pay"
        CheckBox3.TextAlign = ContentAlignment.MiddleCenter
        CheckBox3.TextImageRelation = TextImageRelation.ImageBeforeText
        CheckBox3.UseVisualStyleBackColor = False
        ' 
        ' CheckBox4
        ' 
        CheckBox4.Appearance = Appearance.Button
        CheckBox4.BackColor = Color.Black
        CheckBox4.Font = New Font("Abhaya Libre Medium", 10F)
        CheckBox4.ForeColor = Color.White
        CheckBox4.Location = New Point(183, 419)
        CheckBox4.Margin = New Padding(0)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(167, 64)
        CheckBox4.TabIndex = 15
        CheckBox4.Text = "Rate"
        CheckBox4.TextAlign = ContentAlignment.MiddleCenter
        CheckBox4.TextImageRelation = TextImageRelation.ImageBeforeText
        CheckBox4.UseVisualStyleBackColor = False
        ' 
        ' CheckBox5
        ' 
        CheckBox5.Appearance = Appearance.Button
        CheckBox5.BackColor = Color.Black
        CheckBox5.Font = New Font("Abhaya Libre Medium", 10F)
        CheckBox5.ForeColor = Color.White
        CheckBox5.Location = New Point(9, 419)
        CheckBox5.Margin = New Padding(0)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(167, 64)
        CheckBox5.TabIndex = 16
        CheckBox5.Text = "In Progress"
        CheckBox5.TextAlign = ContentAlignment.MiddleCenter
        CheckBox5.TextImageRelation = TextImageRelation.ImageBeforeText
        CheckBox5.UseVisualStyleBackColor = False
        ' 
        ' CheckBox6
        ' 
        CheckBox6.Appearance = Appearance.Button
        CheckBox6.BackColor = Color.Black
        CheckBox6.Font = New Font("Abhaya Libre Medium", 10F)
        CheckBox6.ForeColor = Color.White
        CheckBox6.Location = New Point(183, 342)
        CheckBox6.Margin = New Padding(0)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(167, 64)
        CheckBox6.TabIndex = 17
        CheckBox6.Text = "Upcoming"
        CheckBox6.TextAlign = ContentAlignment.MiddleCenter
        CheckBox6.TextImageRelation = TextImageRelation.ImageBeforeText
        CheckBox6.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Abhaya Libre Medium", 10F)
        Label6.Location = New Point(122, 306)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 25)
        Label6.TabIndex = 18
        Label6.Text = "Filter(on Action)"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CheckBox7
        ' 
        CheckBox7.Appearance = Appearance.Button
        CheckBox7.BackColor = Color.Black
        CheckBox7.Font = New Font("Abhaya Libre Medium", 10F)
        CheckBox7.ForeColor = Color.White
        CheckBox7.Location = New Point(183, 498)
        CheckBox7.Margin = New Padding(0)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(167, 64)
        CheckBox7.TabIndex = 19
        CheckBox7.Text = "Done"
        CheckBox7.TextAlign = ContentAlignment.MiddleCenter
        CheckBox7.TextImageRelation = TextImageRelation.ImageBeforeText
        CheckBox7.UseVisualStyleBackColor = False
        ' 
        ' Historyfilter
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(361, 571)
        Controls.Add(CheckBox7)
        Controls.Add(Label6)
        Controls.Add(CheckBox6)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(CheckBox1)
        Controls.Add(Label4)
        Controls.Add(TrackBar1)
        Controls.Add(Label2)
        Controls.Add(TrackBar2)
        Controls.Add(Label3)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Location = New Point(925, 310)
        Name = "Historyfilter"
        StartPosition = FormStartPosition.Manual
        Text = "Historyfilter"
        CType(TrackBar2, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox7 As CheckBox

End Class
