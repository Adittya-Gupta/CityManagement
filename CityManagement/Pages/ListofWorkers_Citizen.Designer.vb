<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIstofWorkers_Citizen
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        Timer1 = New Timer(components)
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Image = My.Resources.Resources.Frame_1054__2_
        Label1.Location = New Point(1029, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 73)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Image = My.Resources.Resources.Group_183
        Label2.Location = New Point(569, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(382, 73)
        Label2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Exo 2 Medium", 12F)
        TextBox1.ForeColor = Color.Gray
        TextBox1.Location = New Point(592, 97)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(285, 34)
        TextBox1.TabIndex = 2
        TextBox1.Text = "Search for Service Provider"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Black
        Label3.Image = My.Resources.Resources.Search_icon
        Label3.Location = New Point(874, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 51)
        Label3.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(42, 177)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1102, 719)
        Panel1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Exo 2 SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(96), CByte(85), CByte(85))
        Label4.Location = New Point(102, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(406, 61)
        Label4.TabIndex = 5
        Label4.Text = "List of Service Providers"
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
        Button1.Location = New Point(1091, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 51)
        Button1.TabIndex = 14
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ListofWorkers_Citizen
        ' 
        AutoScaleDimensions = New SizeF(8F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1254, 953)
        Controls.Add(Button1)
        Controls.Add(Label4)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
End Class
