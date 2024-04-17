<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServiceHistory
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
        components = New ComponentModel.Container()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        Timer1 = New Timer(components)
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Black
        Label3.Image = Search_icon
        Label3.Location = New Point(332, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 49)
        Label3.TabIndex = 9
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Microsoft Sans Serif", 12F)
        TextBox1.ForeColor = Color.Gray
        TextBox1.Location = New Point(73, 84)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(256, 34)
        TextBox1.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.Image = Group_183
        Label2.Location = New Point(52, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(340, 50)
        Label2.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.Image = Frame_1054__2_
        Label1.Location = New Point(726, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 67)
        Label1.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(56, 187)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1017, 486)
        Panel1.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Microsoft Sans Serif", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(192, 124)
        Label5.Name = "Label5"
        Label5.Size = New Size(188, 61)
        Label5.TabIndex = 12
        Label5.Text = "Service History"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Microsoft Sans Serif", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(572, 124)
        Label6.Name = "Label6"
        Label6.Size = New Size(211, 61)
        Label6.TabIndex = 13
        Label6.Text = "Status"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Microsoft Sans Serif", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(797, 124)
        Label7.Name = "Label7"
        Label7.Size = New Size(211, 61)
        Label7.TabIndex = 14
        Label7.Text = "Action"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 14F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(944, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 51)
        Button1.TabIndex = 32
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(96), CByte(85), CByte(85))
        Label8.Location = New Point(56, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(311, 61)
        Label8.TabIndex = 33
        Label8.Text = "Service History"
        ' 
        ' ServiceHistory
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1107, 685)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Panel1)
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
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
End Class