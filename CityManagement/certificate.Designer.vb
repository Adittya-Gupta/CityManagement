<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class certificate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(certificate))
        b1 = New Button()
        Label1 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' b1
        ' 
        b1.BackColor = Color.White
        b1.Font = New Font("Segoe UI", 9F)
        b1.ForeColor = SystemColors.ActiveBorder
        b1.Location = New Point(12, 8)
        b1.Margin = New Padding(3, 2, 3, 2)
        b1.Name = "b1"
        b1.Size = New Size(94, 26)
        b1.TabIndex = 7
        b1.Text = "Education"
        b1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(121, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(21, 21)
        Label1.TabIndex = 5
        Label1.Text = ">"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI", 9F)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(149, 8)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 26)
        Button1.TabIndex = 9
        Button1.Text = "Certificate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(140, 59)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(240, 170)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' certificate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 270)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(b1)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "certificate"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents b1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
