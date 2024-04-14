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
        Label2 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        Label5 = New Label()
        TrackBar1 = New Guna.UI2.WinForms.Guna2TrackBar()
        Button1 = New Button()
        Button2 = New Button()
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
        ' Label2
        ' 
        Label2.Font = New Font("Abhaya Libre Medium", 10F)
        Label2.Location = New Point(209, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 25)
        Label2.TabIndex = 2
        Label2.Text = "1.0 and above"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Appearance = Appearance.Button
        CheckBox1.BackColor = Color.Black
        CheckBox1.Font = New Font("Abhaya Libre Medium", 10F)
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(9, 156)
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
        CheckBox2.Location = New Point(181, 156)
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
        Label5.Location = New Point(116, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 25)
        Label5.TabIndex = 8
        Label5.Text = "Sort By"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TrackBar1
        ' 
        TrackBar1.Cursor = Cursors.Hand
        TrackBar1.DisplayFocus = True
        TrackBar1.FillColor = Color.LightGray
        TrackBar1.IndicateFocus = True
        TrackBar1.LargeChange = 2
        TrackBar1.Location = New Point(12, 52)
        TrackBar1.Maximum = 10
        TrackBar1.Minimum = 2
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Size = New Size(335, 29)
        TrackBar1.TabIndex = 9
        TrackBar1.ThumbColor = Color.Black
        TrackBar1.Value = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(37), CByte(2), CByte(156))
        Button1.Font = New Font("Abhaya Libre Medium", 10F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(12, 224)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 51)
        Button1.TabIndex = 12
        Button1.Text = "Apply"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(166), CByte(2), CByte(2))
        Button2.Font = New Font("Abhaya Libre Medium", 10F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(181, 224)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 51)
        Button2.TabIndex = 13
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Workersfilter
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(362, 295)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TrackBar1)
        Controls.Add(Label5)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Location = New Point(925, 310)
        Name = "Workersfilter"
        StartPosition = FormStartPosition.Manual
        Text = "FilterForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TrackBar1 As Guna.UI2.WinForms.Guna2TrackBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
