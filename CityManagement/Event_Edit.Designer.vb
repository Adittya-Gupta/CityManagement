﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Event_Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Event_Edit))
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
        FeatureTextBox = New TextBox()
        Label8 = New Label()
        DescTextBox = New TextBox()
        Label9 = New Label()
        Button2 = New Button()
        DateTimePicker1 = New DateTimePicker()
        OpenFileDialog1 = New OpenFileDialog()
        DateTimePicker2 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        Label7 = New Label()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(57, 46)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(364, 46)
        Label1.TabIndex = 22
        Label1.Text = "Events & Festivals  >"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 24F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(441, 46)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 46)
        Label2.TabIndex = 23
        Label2.Text = "Edit Event"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.White
        Button1.Location = New Point(172, 438)
        Button1.Name = "Button1"
        Button1.Size = New Size(174, 45)
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
        PictureBox1.Size = New Size(411, 266)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(514, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 28)
        Label3.TabIndex = 27
        Label3.Text = "Name of event"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(514, 189)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(205, 29)
        NameTextBox.TabIndex = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(815, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 28)
        Label4.TabIndex = 29
        Label4.Text = "Date of event"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(815, 244)
        Label5.Name = "Label5"
        Label5.Size = New Size(229, 28)
        Label5.TabIndex = 33
        Label5.Text = "Expected timing of event"
        ' 
        ' SpaceTextBox
        ' 
        SpaceTextBox.Location = New Point(514, 274)
        SpaceTextBox.Name = "SpaceTextBox"
        SpaceTextBox.Size = New Size(205, 29)
        SpaceTextBox.TabIndex = 32
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(514, 244)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 28)
        Label6.TabIndex = 31
        Label6.Text = "Venue"
        ' 
        ' FeatureTextBox
        ' 
        FeatureTextBox.Location = New Point(514, 347)
        FeatureTextBox.Name = "FeatureTextBox"
        FeatureTextBox.Size = New Size(324, 29)
        FeatureTextBox.TabIndex = 36
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(514, 315)
        Label8.Name = "Label8"
        Label8.Size = New Size(493, 28)
        Label8.TabIndex = 35
        Label8.Text = "Special features (like only for Docs, only 500 seats, etc.) "
        ' 
        ' DescTextBox
        ' 
        DescTextBox.Location = New Point(514, 438)
        DescTextBox.Multiline = True
        DescTextBox.Name = "DescTextBox"
        DescTextBox.Size = New Size(505, 105)
        DescTextBox.TabIndex = 40
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(514, 402)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 21)
        Label9.TabIndex = 39
        Label9.Text = "Description"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.ForeColor = Color.White
        Button2.Location = New Point(723, 566)
        Button2.Name = "Button2"
        Button2.Size = New Size(175, 53)
        Button2.TabIndex = 41
        Button2.Text = "Save Changes"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(815, 189)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(205, 29)
        DateTimePicker1.TabIndex = 44
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(816, 273)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(202, 29)
        DateTimePicker2.TabIndex = 45
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Festival", "Concert"})
        ComboBox1.Location = New Point(886, 344)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(134, 29)
        ComboBox1.TabIndex = 46
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(886, 315)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 28)
        Label7.TabIndex = 47
        Label7.Text = "Category"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(ComboBox1)
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
        Panel1.Controls.Add(FeatureTextBox)
        Panel1.Controls.Add(SpaceTextBox)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(90, 17)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1129, 753)
        Panel1.TabIndex = 48
        ' 
        ' Event_Edit
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1300, 756)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Event_Edit"
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
    Friend WithEvents FeatureTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DescTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
End Class