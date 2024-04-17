<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LIstofWorkers_Citizen
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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Panel1 = New Panel()
        Timer1 = New Timer(components)
        Button1 = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Image = Frame_1054__2_
        Label1.Location = New Point(709, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 67)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Image = Group_183
        Label2.Location = New Point(64, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(340, 50)
        Label2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Microsoft Sans Serif", 12F)
        TextBox1.ForeColor = Color.Gray
        TextBox1.Location = New Point(80, 82)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(256, 34)
        TextBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Black
        Label3.Image = Search_icon
        Label3.Location = New Point(342, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 47)
        Label3.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(65, 145)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(964, 511)
        Panel1.TabIndex = 4
        ' 
        ' Timer1
        ' 
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Abhaya Libre Medium", 14F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(944, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 51)
        Button1.TabIndex = 14
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(96), CByte(85), CByte(85))
        Label4.Location = New Point(65, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(311, 61)
        Label4.TabIndex = 15
        Label4.Text = "List of Workers"
        ' 
        ' ListofWorkers_Citizen
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1107, 685)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Exo 2", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlLightLight
        FormBorderStyle = FormBorderStyle.None
        Name = "ListofWorkers_Citizen"
        Text = "ListofWorkers_Citizen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListItem1 As ListItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class