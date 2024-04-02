<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListofChats
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
        Label1 = New Label()
        SplitContainer1 = New SplitContainer()
        CurvedLabel9 = New CurvedLabel()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Exo 2 SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(96), CByte(85), CByte(85))
        Label4.Location = New Point(242, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 61)
        Label4.TabIndex = 6
        Label4.Text = "New Chats"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Exo 2 SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(96), CByte(85), CByte(85))
        Label1.Location = New Point(846, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 61)
        Label1.TabIndex = 7
        Label1.Text = "Old Chats"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(30, 181)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.AutoScroll = True
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.AutoScroll = True
        SplitContainer1.Size = New Size(1188, 729)
        SplitContainer1.SplitterDistance = 594
        SplitContainer1.TabIndex = 8
        ' 
        ' CurvedLabel9
        ' 
        CurvedLabel9.CornerRadius = 10
        CurvedLabel9.Font = New Font("Exo 2 Medium", 24F)
        CurvedLabel9.ForeColor = Color.MediumBlue
        CurvedLabel9.Location = New Point(1108, 0)
        CurvedLabel9.Name = "CurvedLabel9"
        CurvedLabel9.Size = New Size(148, 52)
        CurvedLabel9.TabIndex = 24
        CurvedLabel9.Text = "< Back"
        CurvedLabel9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ListOfChats
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1254, 953)
        Controls.Add(CurvedLabel9)
        Controls.Add(SplitContainer1)
        Controls.Add(Label1)
        Controls.Add(Label4)
        FormBorderStyle = FormBorderStyle.None
        Name = "ListOfChats"
        Text = "ListofChats"
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents CurvedLabel9 As CurvedLabel
End Class
