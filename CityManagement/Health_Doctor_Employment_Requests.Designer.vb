<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Health_Doctor_Employment_Requests
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
        Panel1 = New Panel()
        Label8 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        ComboBox2 = New ComboBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1097, 60)
        Panel1.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Black
        Label8.Font = New Font("Segoe UI", 12.0F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(103, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(151, 21)
        Label8.TabIndex = 2
        Label8.Text = "Create New Vacancy"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Black
        Label7.Font = New Font("Segoe UI", 12.0F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(462, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(179, 21)
        Label7.TabIndex = 1
        Label7.Text = "View Previous Vacancies"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Segoe UI", 12.0F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(800, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 21)
        Label1.TabIndex = 0
        Label1.Text = "Doctor Employment Request"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 15)
        Label2.TabIndex = 1
        Label2.Text = "Work Section"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label3.Location = New Point(101, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(173, 15)
        Label3.TabIndex = 2
        Label3.Text = "Doctor Employment Requests"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources.arrow_icons
        PictureBox1.Location = New Point(82, 73)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(13, 11)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        ComboBox2.DrawMode = DrawMode.OwnerDrawVariable
        ComboBox2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox2.ForeColor = Color.Black
        ComboBox2.FormattingEnabled = True
        ComboBox2.IntegralHeight = False
        ComboBox2.ItemHeight = 24
        ComboBox2.Location = New Point(274, 107)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.RightToLeft = RightToLeft.No
        ComboBox2.Size = New Size(215, 30)
        ComboBox2.TabIndex = 32
        ComboBox2.Text = "    Select  Specialisation"
        ' 
        ' Health_Doctor_Employment_Requests
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1097, 690)
        Controls.Add(ComboBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Health_Doctor_Employment_Requests"
        Text = "Health_HospitalListing"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox2 As ComboBox
End Class
