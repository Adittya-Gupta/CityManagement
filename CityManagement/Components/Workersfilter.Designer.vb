<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Workersfilter
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
        Label1 = New Label()
        TrackBar1 = New TrackBar()
        Label2 = New Label()
        Label3 = New Label()
        TrackBar2 = New TrackBar()
        Label4 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        Label5 = New Label()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Abhaya Libre Medium", 10F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 25)
        Label1.TabIndex = 0
        Label1.Text = "Rating"
        ' 
        ' TrackBar1
        ' 
        TrackBar1.AutoSize = False
        TrackBar1.BackColor = Color.Black
        TrackBar1.Cursor = Cursors.Hand
        TrackBar1.Location = New Point(12, 37)
        TrackBar1.Minimum = 2
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Size = New Size(341, 45)
        TrackBar1.TabIndex = 1
        TrackBar1.TickStyle = TickStyle.Both
        TrackBar1.Value = 2
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Abhaya Libre Medium", 10F)
        Label2.Location = New Point(209, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 25)
        Label2.TabIndex = 2
        Label2.Text = "1.0 and above"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Abhaya Libre Medium", 10F)
        Label3.Location = New Point(209, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 25)
        Label3.TabIndex = 5
        Label3.Text = "Below 2km"
        ' 
        ' TrackBar2
        ' 
        TrackBar2.AutoSize = False
        TrackBar2.BackColor = Color.Black
        TrackBar2.Cursor = Cursors.Hand
        TrackBar2.Location = New Point(12, 134)
        TrackBar2.Minimum = 1
        TrackBar2.Name = "TrackBar2"
        TrackBar2.Size = New Size(341, 45)
        TrackBar2.TabIndex = 4
        TrackBar2.TickStyle = TickStyle.Both
        TrackBar2.Value = 10
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Abhaya Libre Medium", 10F)
        Label4.Location = New Point(12, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 25)
        Label4.TabIndex = 3
        Label4.Text = "Location"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Appearance = Appearance.Button
        CheckBox1.BackColor = Color.Black
        CheckBox1.Font = New Font("Abhaya Libre Medium", 10F)
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(12, 231)
        CheckBox1.Margin = New Padding(0)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(172, 51)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Rating"
        CheckBox1.TextAlign = ContentAlignment.MiddleCenter
        CheckBox1.ThreeState = True
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.Appearance = Appearance.Button
        CheckBox2.BackColor = Color.Black
        CheckBox2.Font = New Font("Abhaya Libre Medium", 10F)
        CheckBox2.ForeColor = Color.White
        CheckBox2.Location = New Point(181, 231)
        CheckBox2.Margin = New Padding(0)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(172, 51)
        CheckBox2.TabIndex = 7
        CheckBox2.Text = "No_of_Ratings"
        CheckBox2.TextAlign = ContentAlignment.MiddleCenter
        CheckBox2.ThreeState = True
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Abhaya Libre Medium", 10F)
        Label5.Location = New Point(112, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 25)
        Label5.TabIndex = 8
        Label5.Text = "Sort By"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FilterForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(362, 310)
        Controls.Add(Label5)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label3)
        Controls.Add(TrackBar2)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(TrackBar1)
        Controls.Add(Label1)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Location = New Point(925, 310)
        Name = "FilterForm"
        StartPosition = FormStartPosition.Manual
        Text = "FilterForm"
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label5 As Label

End Class
