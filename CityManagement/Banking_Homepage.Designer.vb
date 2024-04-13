<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Banking_Homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Banking_Homepage))
        Panel4 = New Panel()
        Label3 = New Label()
        Button18 = New Button()
        Button19 = New Button()
        Button20 = New Button()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackgroundImage = My.Resources.Resources.Banking_Home
        Panel4.BackgroundImageLayout = ImageLayout.Stretch
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(809, 641)
        Panel4.TabIndex = 41
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bodoni MT", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.GhostWhite
        Label3.Location = New Point(52, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(701, 641)
        Label3.TabIndex = 0
        Label3.Text = resources.GetString("Label3.Text")
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button18
        ' 
        Button18.BackColor = Color.Black
        Button18.Cursor = Cursors.Hand
        Button18.FlatAppearance.BorderSize = 0
        Button18.FlatStyle = FlatStyle.Flat
        Button18.Font = New Font("Bodoni MT", 19.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button18.ForeColor = Color.White
        Button18.Location = New Point(851, 371)
        Button18.Margin = New Padding(0)
        Button18.Name = "Button18"
        Button18.Size = New Size(220, 74)
        Button18.TabIndex = 44
        Button18.Text = "EMPLOYEE"
        Button18.UseVisualStyleBackColor = False
        ' 
        ' Button19
        ' 
        Button19.BackColor = Color.Black
        Button19.Cursor = Cursors.Hand
        Button19.FlatAppearance.BorderSize = 0
        Button19.FlatStyle = FlatStyle.Flat
        Button19.Font = New Font("Bodoni MT", 19.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button19.ForeColor = Color.White
        Button19.Location = New Point(851, 236)
        Button19.Margin = New Padding(0)
        Button19.Name = "Button19"
        Button19.Size = New Size(220, 74)
        Button19.TabIndex = 43
        Button19.Text = "REGISTER"
        Button19.UseVisualStyleBackColor = False
        ' 
        ' Button20
        ' 
        Button20.BackColor = Color.Black
        Button20.Cursor = Cursors.Hand
        Button20.FlatAppearance.BorderSize = 0
        Button20.FlatStyle = FlatStyle.Flat
        Button20.Font = New Font("Bodoni MT", 19.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button20.ForeColor = Color.White
        Button20.Location = New Point(851, 126)
        Button20.Margin = New Padding(0)
        Button20.Name = "Button20"
        Button20.Size = New Size(220, 74)
        Button20.TabIndex = 42
        Button20.Text = "LOGIN"
        Button20.UseVisualStyleBackColor = False
        ' 
        ' Banking_Homepage
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1107, 641)
        ControlBox = False
        Controls.Add(Panel4)
        Controls.Add(Button18)
        Controls.Add(Button19)
        Controls.Add(Button20)
        FormBorderStyle = FormBorderStyle.None
        Name = "Banking_Homepage"
        Text = "Banking_Homepage"
        Panel4.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
End Class
