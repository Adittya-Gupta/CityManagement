<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Newsletter_Homepage
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
        Button10 = New Button()
        Button15 = New Button()
        Label3 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox13 = New PictureBox()
        PictureBox11 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Black
        Button10.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = Color.White
        Button10.Location = New Point(809, 418)
        Button10.Name = "Button10"
        Button10.Size = New Size(268, 128)
        Button10.TabIndex = 40
        Button10.Text = "NEWSLETTER EDITOR"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.Black
        Button15.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button15.ForeColor = Color.White
        Button15.Location = New Point(31, 414)
        Button15.Name = "Button15"
        Button15.Size = New Size(268, 128)
        Button15.TabIndex = 39
        Button15.Text = "VIEW TRENDING NEWS ARTICLES"
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bodoni MT", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(1, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(1105, 71)
        Label3.TabIndex = 38
        Label3.Text = "Welcome to CITY TIMES NOW Homepage."
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(421, 418)
        Button1.Name = "Button1"
        Button1.Size = New Size(268, 128)
        Button1.TabIndex = 43
        Button1.Text = "PUBLISH SOME NEWS ARICLE/ PROMOTION"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = newspaper
        PictureBox1.Location = New Point(424, 144)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(265, 267)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 44
        PictureBox1.TabStop = False
        ' 
        ' PictureBox13
        ' 
        PictureBox13.Image = editor
        PictureBox13.Location = New Point(812, 144)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(265, 267)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 42
        PictureBox13.TabStop = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = Newspaper_logo
        PictureBox11.Location = New Point(34, 144)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(265, 267)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 41
        PictureBox11.TabStop = False
        ' 
        ' Newsletter_Homepage
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.Cornsilk
        ClientSize = New Size(1107, 641)
        ControlBox = False
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(PictureBox13)
        Controls.Add(PictureBox11)
        Controls.Add(Button10)
        Controls.Add(Button15)
        Controls.Add(Label3)
        Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Newsletter_Homepage"
        Text = "MainPanel"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
