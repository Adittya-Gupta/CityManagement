<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email_SentEmails
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
        From_TextBox = New TextBox()
        Subject_TextBox = New TextBox()
        Content_TextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Refresh_Button = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(161, 340)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(794, 225)
        DataGridView1.TabIndex = 8
        ' 
        ' From_TextBox
        ' 
        From_TextBox.Location = New Point(267, 56)
        From_TextBox.Name = "From_TextBox"
        From_TextBox.Size = New Size(585, 27)
        From_TextBox.TabIndex = 9
        ' 
        ' Subject_TextBox
        ' 
        Subject_TextBox.Location = New Point(267, 107)
        Subject_TextBox.Name = "Subject_TextBox"
        Subject_TextBox.Size = New Size(585, 27)
        Subject_TextBox.TabIndex = 10
        ' 
        ' Content_TextBox
        ' 
        Content_TextBox.Location = New Point(267, 163)
        Content_TextBox.Multiline = True
        Content_TextBox.Name = "Content_TextBox"
        Content_TextBox.Size = New Size(585, 159)
        Content_TextBox.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(145, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 20)
        Label1.TabIndex = 12
        Label1.Text = "To"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(145, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 13
        Label2.Text = "Subject"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(145, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 14
        Label3.Text = "Content"
        ' 
        ' Refresh_Button
        ' 
        Refresh_Button.Location = New Point(949, 92)
        Refresh_Button.Name = "Refresh_Button"
        Refresh_Button.Size = New Size(91, 56)
        Refresh_Button.TabIndex = 15
        Refresh_Button.Text = "Refresh"
        Refresh_Button.UseVisualStyleBackColor = True
        ' 
        ' Email_SentEmails
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1107, 639)
        ControlBox = False
        Controls.Add(Refresh_Button)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Content_TextBox)
        Controls.Add(Subject_TextBox)
        Controls.Add(From_TextBox)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Email_SentEmails"
        Text = "Email_SentEmails"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents From_TextBox As TextBox
    Friend WithEvents Subject_TextBox As TextBox
    Friend WithEvents Content_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Refresh_Button As Button
End Class
