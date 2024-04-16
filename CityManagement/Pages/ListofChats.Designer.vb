<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListofChats
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
        Label4 = New Label()
        Label1 = New Label()
        SplitContainer1 = New SplitContainer()
        Button1 = New Button()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(96), CByte(85), CByte(85))
        Label4.Location = New Point(196, 53)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 61)
        Label4.TabIndex = 6
        Label4.Text = "New Chats"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(96), CByte(85), CByte(85))
        Label1.Location = New Point(753, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 61)
        Label1.TabIndex = 7
        Label1.Text = "Old Chats"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(32, 117)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.AutoScroll = True
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.AutoScroll = True
        SplitContainer1.Size = New Size(1041, 537)
        SplitContainer1.SplitterDistance = 520
        SplitContainer1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Abhaya Libre Medium", 14F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(935, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 51)
        Button1.TabIndex = 13
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ListOfChats
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1107, 685)
        Controls.Add(Button1)
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
    Friend WithEvents Button1 As Button
End Class