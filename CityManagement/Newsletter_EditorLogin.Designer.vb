<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Newsletter_EditorLogin
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
        PictureBox13 = New PictureBox()
        Label9 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button15 = New Button()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox13
        ' 
        PictureBox13.Image = My.Resources.Resources.editor
        PictureBox13.Location = New Point(480, 79)
        PictureBox13.Margin = New Padding(3, 4, 3, 4)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(160, 198)
        PictureBox13.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox13.TabIndex = 39
        PictureBox13.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Bodoni MT", 19.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(130, 361)
        Label9.Name = "Label9"
        Label9.Size = New Size(271, 40)
        Label9.TabIndex = 48
        Label9.Text = "Editor Username : "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bodoni MT", 19.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(130, 459)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 40)
        Label1.TabIndex = 49
        Label1.Text = "Editor Password  : "
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(434, 366)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(370, 44)
        TextBox1.TabIndex = 50
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.WhiteSmoke
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(434, 464)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(370, 44)
        TextBox2.TabIndex = 51
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.Black
        Button15.FlatStyle = FlatStyle.Popup
        Button15.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button15.ForeColor = Color.White
        Button15.Location = New Point(480, 570)
        Button15.Margin = New Padding(3, 4, 3, 4)
        Button15.Name = "Button15"
        Button15.Size = New Size(160, 59)
        Button15.TabIndex = 55
        Button15.Text = "LOGIN"
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Newsletter_EditorLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cornsilk
        ClientSize = New Size(1107, 801)
        ControlBox = False
        Controls.Add(Button15)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Label9)
        Controls.Add(PictureBox13)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Newsletter_EditorLogin"
        Text = "Newsletter_EditorLogin"
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button15 As Button
End Class
