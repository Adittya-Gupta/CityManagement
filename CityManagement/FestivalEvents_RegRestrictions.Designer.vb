<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FestivalEvents_RegRestrictions
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
        Label3 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Panel1 = New Panel()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(28, 45)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(388, 31)
        Label3.TabIndex = 31
        Label3.Text = "Event Registration Restrictions"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(12, 27)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(58, 24)
        CheckBox1.TabIndex = 32
        CheckBox1.Text = "Age"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(12, 106)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(183, 24)
        CheckBox2.TabIndex = 33
        CheckBox2.Text = "Number of Participants"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(276, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 34
        Label1.Text = "Minimum Age"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(521, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 20)
        Label2.TabIndex = 35
        Label2.Text = "Maximum Age"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(201, 27)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(71, 27)
        TextBox1.TabIndex = 36
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(445, 27)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(71, 27)
        TextBox2.TabIndex = 37
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(276, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(228, 20)
        Label4.TabIndex = 38
        Label4.Text = "Maximum number of Participants"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(201, 106)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(71, 27)
        TextBox3.TabIndex = 39
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(28, 101)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(653, 173)
        Panel1.TabIndex = 41
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(40, 315)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 42)
        Button1.TabIndex = 43
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FestivalEvents_RegRestrictions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(711, 429)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Name = "FestivalEvents_RegRestrictions"
        Text = "FestivalEvents_RegRestrictions"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
