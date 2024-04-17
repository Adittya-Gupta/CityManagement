<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UrbanClapNav
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
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CurvedLabel1 = New CurvedLabel()
        CurvedLabel2 = New CurvedLabel()
        Panel1 = New Panel()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1108, 73)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.Black
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Exo 2", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(24, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(333, 73)
        Button1.TabIndex = 1
        Button1.Text = "Service History"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.BackColor = Color.Black
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Exo 2", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(439, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(236, 73)
        Button2.TabIndex = 2
        Button2.Text = "Chats"
        Button2.UseVisualStyleBackColor = False
        Button2.Visible = False
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.BackColor = Color.White
        CurvedLabel1.CornerRadius = 5
        CurvedLabel1.Location = New Point(45, -5)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Size = New Size(287, 11)
        CurvedLabel1.TabIndex = 3
        ' 
        ' CurvedLabel2
        ' 
        CurvedLabel2.BackColor = Color.White
        CurvedLabel2.CornerRadius = 5
        CurvedLabel2.Location = New Point(493, -5)
        CurvedLabel2.Name = "CurvedLabel2"
        CurvedLabel2.Size = New Size(119, 11)
        CurvedLabel2.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(0, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1108, 685)
        Panel1.TabIndex = 6
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Exo 2", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(721, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(363, 73)
        Button3.TabIndex = 7
        Button3.Text = "Work Section"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' UrbanClapNav
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1107, 760)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Controls.Add(CurvedLabel2)
        Controls.Add(CurvedLabel1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "UrbanClapNav"
        Text = "UrbanClapNav"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CurvedLabel1 As CurvedLabel
    Friend WithEvents CurvedLabel2 As CurvedLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents CurvedLabel3 As CurvedLabel
End Class
