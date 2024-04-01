<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transport_cabbooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transport_cabbooking))
        Panel3 = New Panel()
        RadioButton1 = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel1 = New Panel()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlLightLight
        Panel3.Controls.Add(RadioButton1)
        Panel3.Controls.Add(DateTimePicker1)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(502, 283)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(397, 349)
        Panel3.TabIndex = 2
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Exo 2", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(65, 264)
        RadioButton1.Margin = New Padding(3, 4, 3, 4)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(78, 22)
        RadioButton1.TabIndex = 5
        RadioButton1.TabStop = True
        RadioButton1.Text = "Private"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Exo 2", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(65, 205)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(277, 31)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(152, 291)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 37)
        Button1.TabIndex = 3
        Button1.Text = "Request Now" & vbCrLf
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Silver
        TextBox2.Font = New Font("Exo 2", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(65, 147)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Enter Destination"
        TextBox2.Size = New Size(277, 34)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Silver
        TextBox1.Font = New Font("Exo 2", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(65, 96)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter Pickup location"
        TextBox1.Size = New Size(277, 34)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(75, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 41)
        Label1.TabIndex = 0
        Label1.Text = "Request a Ride"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLightLight
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(502, 194)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(397, 83)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(170, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(75, 83)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(32, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(234, 29)
        Label2.TabIndex = 11
        Label2.Text = "Transport Services"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = SystemColors.ActiveCaptionText
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(1042, 14)
        Button3.Name = "Button3"
        Button3.Size = New Size(110, 45)
        Button3.TabIndex = 4
        Button3.Text = "My Activity" & vbCrLf
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button4.BackColor = SystemColors.ActiveCaptionText
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(1214, 14)
        Button4.Name = "Button4"
        Button4.Size = New Size(110, 45)
        Button4.TabIndex = 5
        Button4.Text = "Look for Bus" & vbCrLf
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Silver
        Label3.Location = New Point(315, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 29)
        Label3.TabIndex = 16
        Label3.Text = "Cab"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(436, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 29)
        Label4.TabIndex = 17
        Label4.Text = "Book"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(272, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 23)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(394, 25)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(24, 23)
        PictureBox3.TabIndex = 19
        PictureBox3.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(0, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1377, 72)
        Panel1.TabIndex = 2
        ' 
        ' transport_cabbooking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1370, 689)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "transport_cabbooking"
        Text = "Form1"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
