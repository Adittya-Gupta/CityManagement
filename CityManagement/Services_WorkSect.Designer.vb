<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Services_WorkSect
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CurvedLabel2 = New CurvedLabel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.Location = New Point(0, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(1254, 73)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(0, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1254, 953)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.Location = New Point(120, 161)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1060, 727)
        Panel2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.Cursor = Cursors.Hand
        Label3.Image = My.Resources.Resources.Frame_1054__2_
        Label3.Location = New Point(1016, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 72)
        Label3.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Abhaya Libre Medium", 34.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(255, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(623, 71)
        Label2.TabIndex = 0
        Label2.Text = "List of Service Requests"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Abhaya Libre Medium", 20F)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(873, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(178, 73)
        Button1.TabIndex = 3
        Button1.Text = "Chats"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Abhaya Libre Medium", 20F)
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(1051, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(203, 73)
        Button2.TabIndex = 4
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CurvedLabel2
        ' 
        CurvedLabel2.BackColor = Color.White
        CurvedLabel2.CornerRadius = 5
        CurvedLabel2.Location = New Point(896, -5)
        CurvedLabel2.Name = "CurvedLabel2"
        CurvedLabel2.Size = New Size(119, 11)
        CurvedLabel2.TabIndex = 6
        ' 
        ' Services_WorkSect
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1254, 1026)
        Controls.Add(CurvedLabel2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Services_WorkSect"
        Text = "Services_WorkSect"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents CurvedLabel2 As CurvedLabel
End Class
