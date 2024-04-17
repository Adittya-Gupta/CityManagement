<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FestivalEvents_EditEvent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FestivalEvents_EditEvent))
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        NameTextBox = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        SpaceTextBox = New TextBox()
        Label6 = New Label()
        DescTextBox = New TextBox()
        Label9 = New Label()
        Button2 = New Button()
        DateTimePicker1 = New DateTimePicker()
        OpenFileDialog1 = New OpenFileDialog()
        DateTimePicker2 = New DateTimePicker()
        Panel1 = New Panel()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Abhaya Libre Medium", 28F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(57, 46)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(449, 55)
        Label1.TabIndex = 22
        Label1.Text = "Events and Festivals  >"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Abhaya Libre Medium", 28F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(514, 46)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(221, 55)
        Label2.TabIndex = 23
        Label2.Text = "Edit Event"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Abhaya Libre Medium", 12F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(127, 438)
        Button1.Name = "Button1"
        Button1.Size = New Size(198, 55)
        Button1.TabIndex = 25
        Button1.Text = "Upload an Image"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(57, 143)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(350, 266)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Abhaya Libre Medium", 16F)
        Label3.Location = New Point(456, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 32)
        Label3.TabIndex = 27
        Label3.Text = "Name of event"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(456, 189)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(205, 27)
        NameTextBox.TabIndex = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Abhaya Libre Medium", 16F)
        Label4.Location = New Point(734, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 32)
        Label4.TabIndex = 29
        Label4.Text = "Date of event"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Abhaya Libre Medium", 16F)
        Label5.Location = New Point(730, 244)
        Label5.Name = "Label5"
        Label5.Size = New Size(287, 32)
        Label5.TabIndex = 33
        Label5.Text = "Expected timing of event"
        ' 
        ' SpaceTextBox
        ' 
        SpaceTextBox.Location = New Point(456, 274)
        SpaceTextBox.Name = "SpaceTextBox"
        SpaceTextBox.Size = New Size(205, 27)
        SpaceTextBox.TabIndex = 32
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Abhaya Libre Medium", 16F)
        Label6.Location = New Point(456, 244)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 32)
        Label6.TabIndex = 31
        Label6.Text = "Venue"
        ' 
        ' DescTextBox
        ' 
        DescTextBox.Location = New Point(454, 438)
        DescTextBox.Multiline = True
        DescTextBox.Name = "DescTextBox"
        DescTextBox.Size = New Size(563, 105)
        DescTextBox.TabIndex = 40
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Abhaya Libre Medium", 16F)
        Label9.Location = New Point(454, 402)
        Label9.Name = "Label9"
        Label9.Size = New Size(147, 32)
        Label9.TabIndex = 39
        Label9.Text = "Description"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.Font = New Font("Abhaya Libre Medium", 20F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(635, 582)
        Button2.Name = "Button2"
        Button2.Size = New Size(175, 53)
        Button2.TabIndex = 41
        Button2.Text = "Save Changes"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(734, 189)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(205, 27)
        DateTimePicker1.TabIndex = 44
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(735, 276)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(202, 27)
        DateTimePicker2.TabIndex = 45
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(DateTimePicker2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(NameTextBox)
        Panel1.Controls.Add(DescTextBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(SpaceTextBox)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(12, 13)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1083, 735)
        Panel1.TabIndex = 48
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Abhaya Libre Medium", 16F)
        RadioButton2.Location = New Point(599, 340)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(132, 36)
        RadioButton2.TabIndex = 47
        RadioButton2.TabStop = True
        RadioButton2.Text = "Outdoor"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Abhaya Libre Medium", 16F)
        RadioButton1.Location = New Point(471, 340)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(113, 36)
        RadioButton1.TabIndex = 46
        RadioButton1.TabStop = True
        RadioButton1.Text = "Indoor"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' FestivalEvents_EditEvent
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.Control
        ClientSize = New Size(1107, 760)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FestivalEvents_EditEvent"
        Text = "Edit_Event"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SpaceTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DescTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
