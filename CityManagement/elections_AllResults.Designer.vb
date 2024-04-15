<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class elections_AllResults
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
        ComboBox1 = New ComboBox()
        Panel1 = New Panel()
        back = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(163, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 57)
        Label1.TabIndex = 0
        Label1.Text = "Select Ministry"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Black
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.ForeColor = SystemColors.InactiveBorder
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Education", "Health", "Transport", "Finance", "Home"})
        ComboBox1.Location = New Point(423, 65)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(548, 49)
        ComboBox1.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(42, 145)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(975, 574)
        Panel1.TabIndex = 2
        ' 
        ' back
        ' 
        back.BackColor = SystemColors.ActiveCaptionText
        back.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        back.Location = New Point(931, 9)
        back.Name = "back"
        back.Size = New Size(86, 42)
        back.TabIndex = 4
        back.Text = "Back"
        back.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' elections_AllResults
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1107, 760)
        Controls.Add(back)
        Controls.Add(Panel1)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        DoubleBuffered = True
        ForeColor = SystemColors.ButtonHighlight
        FormBorderStyle = FormBorderStyle.None
        Name = "elections_AllResults"
        Text = "AllResults"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents back As Label
End Class
