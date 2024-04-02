<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceHistory
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
        Label4 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CurvedLabel9 = New CurvedLabel()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Exo 2 SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(96), CByte(85), CByte(85))
        Label4.Location = New Point(146, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(406, 61)
        Label4.TabIndex = 10
        Label4.Text = "Service History"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Black
        Label3.Image = My.Resources.Resources.Search_icon
        Label3.Location = New Point(924, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 51)
        Label3.TabIndex = 9
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Exo 2 Medium", 12F)
        TextBox1.ForeColor = Color.Gray
        TextBox1.Location = New Point(642, 88)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(285, 34)
        TextBox1.TabIndex = 8
        TextBox1.Text = "Search History"
        ' 
        ' Label2
        ' 
        Label2.Image = My.Resources.Resources.Group_183
        Label2.Location = New Point(619, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(382, 73)
        Label2.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.Image = My.Resources.Resources.Frame_1054__2_
        Label1.Location = New Point(1079, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 73)
        Label1.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(42, 218)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1102, 678)
        Panel1.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Exo 2", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(173, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(211, 61)
        Label5.TabIndex = 12
        Label5.Text = "Service History"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Exo 2", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(590, 154)
        Label6.Name = "Label6"
        Label6.Size = New Size(211, 61)
        Label6.TabIndex = 13
        Label6.Text = "Status"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Exo 2", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(890, 154)
        Label7.Name = "Label7"
        Label7.Size = New Size(211, 61)
        Label7.TabIndex = 14
        Label7.Text = "Action"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CurvedLabel9
        ' 
        CurvedLabel9.CornerRadius = 10
        CurvedLabel9.Font = New Font("Exo 2 Medium", 24F)
        CurvedLabel9.ForeColor = Color.MediumBlue
        CurvedLabel9.Location = New Point(1107, 0)
        CurvedLabel9.Name = "CurvedLabel9"
        CurvedLabel9.Size = New Size(148, 52)
        CurvedLabel9.TabIndex = 22
        CurvedLabel9.Text = "< Back"
        CurvedLabel9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ServiceHistory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1254, 953)
        Controls.Add(CurvedLabel9)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ServiceHistory"
        Text = "ServiceHistory"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CurvedLabel9 As CurvedLabel
End Class
