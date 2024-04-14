<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Newsletter_Main
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
        Panel1 = New Panel()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox12 = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.Cornsilk
        Panel1.Location = New Point(3, 115)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1107, 641)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Bodoni MT", 49.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(0, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(1104, 10)
        Label4.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bodoni MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(987, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 21)
        Label2.TabIndex = 15
        Label2.Text = "+123-456-789"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bodoni MT", 45F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(266, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(623, 88)
        Label1.TabIndex = 14
        Label1.Text = "CITY TIMES NOW"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Cornsilk
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox12)
        Panel2.Location = New Point(3, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1107, 118)
        Panel2.TabIndex = 4
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Image = My.Resources.Resources.Newspaper_logo
        PictureBox12.Location = New Point(9, 9)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(91, 91)
        PictureBox12.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox12.TabIndex = 16
        PictureBox12.TabStop = False
        ' 
        ' Newsletter_Main
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(29), CByte(28), CByte(23))
        ClientSize = New Size(1107, 760)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Newsletter_Main"
        Text = "Newsletter_Main"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
