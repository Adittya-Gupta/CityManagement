<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class courserequests_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(courserequests_page))
        Button2 = New Button()
        Education = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(421, 37)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 39)
        Button2.TabIndex = 49
        Button2.Text = "Requests"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Education
        ' 
        Education.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Education.ForeColor = SystemColors.ActiveBorder
        Education.Location = New Point(34, 36)
        Education.Name = "Education"
        Education.Size = New Size(139, 41)
        Education.TabIndex = 50
        Education.Text = "Education"
        Education.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveBorder
        Button1.Location = New Point(202, 36)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 41)
        Button1.TabIndex = 51
        Button1.Text = "Professor Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(178, 48)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(19, 20)
        Label1.TabIndex = 52
        Label1.Text = ">"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(397, 48)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(19, 20)
        Label2.TabIndex = 53
        Label2.Text = ">"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(866, 36)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(182, 156)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 54
        PictureBox2.TabStop = False
        ' 
        ' courserequests_page
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1089, 713)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Education)
        Controls.Add(Button2)
        FormBorderStyle = FormBorderStyle.None
        Name = "courserequests_page"
        Text = "courserequests_page"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Education As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
