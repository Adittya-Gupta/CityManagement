<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email_inbox
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
        DataGridView1 = New DataGridView()
        To_TextBox = New TextBox()
        Subject_TextBox = New TextBox()
        Content_TextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(144, 355)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(794, 225)
        DataGridView1.TabIndex = 7
        ' 
        ' To_TextBox
        ' 
        To_TextBox.Location = New Point(260, 23)
        To_TextBox.Name = "To_TextBox"
        To_TextBox.Size = New Size(585, 27)
        To_TextBox.TabIndex = 8
        ' 
        ' Subject_TextBox
        ' 
        Subject_TextBox.Location = New Point(260, 100)
        Subject_TextBox.Name = "Subject_TextBox"
        Subject_TextBox.Size = New Size(585, 27)
        Subject_TextBox.TabIndex = 9
        ' 
        ' Content_TextBox
        ' 
        Content_TextBox.Location = New Point(260, 170)
        Content_TextBox.Multiline = True
        Content_TextBox.Name = "Content_TextBox"
        Content_TextBox.Size = New Size(585, 159)
        Content_TextBox.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(166, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 11
        Label1.Text = "From"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(166, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 12
        Label2.Text = "Subject"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(166, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 13
        Label3.Text = "Content"
        ' 
        ' Email_inbox
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1089, 592)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Content_TextBox)
        Controls.Add(Subject_TextBox)
        Controls.Add(To_TextBox)
        Controls.Add(DataGridView1)
        Name = "Email_inbox"
        Text = "Email_inbox"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents To_TextBox As TextBox
    Friend WithEvents Subject_TextBox As TextBox
    Friend WithEvents Content_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
