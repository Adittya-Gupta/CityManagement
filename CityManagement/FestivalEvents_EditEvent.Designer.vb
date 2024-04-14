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
        Label1.Location = New Point(44, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(363, 45)
        Label1.TabIndex = 22
        Label1.Text = "Events and Festivals  >"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Abhaya Libre Medium", 28F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(400, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 45)
        Label2.TabIndex = 23
        Label2.Text = "Edit Event"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Abhaya Libre Medium", 12F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(99, 313)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 39)
        Button1.TabIndex = 25
        Button1.Text = "Upload an Image"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(44, 102)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(272, 190)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Abhaya Libre Medium", 16F)
        Label3.Location = New Point(355, 112)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 25)
        Label3.TabIndex = 27
        Label3.Text = "Name of event"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(355, 135)
        NameTextBox.Margin = New Padding(2, 2, 2, 2)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(160, 23)
        NameTextBox.TabIndex = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Abhaya Libre Medium", 16F)
        Label4.Location = New Point(571, 112)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 25)
        Label4.TabIndex = 29
        Label4.Text = "Date of event"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Abhaya Libre Medium", 16F)
        Label5.Location = New Point(568, 174)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(231, 25)
        Label5.TabIndex = 33
        Label5.Text = "Expected timing of event"
        ' 
        ' SpaceTextBox
        ' 
        SpaceTextBox.Location = New Point(355, 196)
        SpaceTextBox.Margin = New Padding(2, 2, 2, 2)
        SpaceTextBox.Name = "SpaceTextBox"
        SpaceTextBox.Size = New Size(160, 23)
        SpaceTextBox.TabIndex = 32
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Abhaya Libre Medium", 16F)
        Label6.Location = New Point(355, 174)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 25)
        Label6.TabIndex = 31
        Label6.Text = "Venue"
        ' 
        ' DescTextBox
        ' 
        DescTextBox.Location = New Point(353, 313)
        DescTextBox.Margin = New Padding(2, 2, 2, 2)
        DescTextBox.Multiline = True
        DescTextBox.Name = "DescTextBox"
        DescTextBox.Size = New Size(439, 76)
        DescTextBox.TabIndex = 40
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Abhaya Libre Medium", 16F)
        Label9.Location = New Point(353, 287)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(118, 25)
        Label9.TabIndex = 39
        Label9.Text = "Description"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.Font = New Font("Abhaya Libre Medium", 20F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(494, 416)
        Button2.Margin = New Padding(2, 2, 2, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(136, 38)
        Button2.TabIndex = 41
        Button2.Text = "Save Changes"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(571, 135)
        DateTimePicker1.Margin = New Padding(2, 2, 2, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(160, 23)
        DateTimePicker1.TabIndex = 44
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(572, 197)
        DateTimePicker2.Margin = New Padding(2, 2, 2, 2)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(158, 23)
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
        Panel1.Location = New Point(9, 9)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(842, 533)
        Panel1.TabIndex = 48
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Abhaya Libre Medium", 16F)
        RadioButton2.Location = New Point(466, 243)
        RadioButton2.Margin = New Padding(2, 2, 2, 2)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(107, 29)
        RadioButton2.TabIndex = 47
        RadioButton2.TabStop = True
        RadioButton2.Text = "Outdoor"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Abhaya Libre Medium", 16F)
        RadioButton1.Location = New Point(366, 243)
        RadioButton1.Margin = New Padding(2, 2, 2, 2)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(92, 29)
        RadioButton1.TabIndex = 46
        RadioButton1.TabStop = True
        RadioButton1.Text = "Indoor"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' FestivalEvents_EditEvent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1107, 760)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 2, 2, 2)
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
