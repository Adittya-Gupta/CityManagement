<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email_Draft
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
        To_TextBox = New TextBox()
        Subject_TextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Content_TextBox = New TextBox()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        Draft_Button = New Button()
        Send_Button = New Button()
        Clear_Button = New Button()
        Delete_Button = New Button()
        Refresh_Button = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' To_TextBox
        ' 
        To_TextBox.Location = New Point(100, 34)
        To_TextBox.Name = "To_TextBox"
        To_TextBox.Size = New Size(585, 27)
        To_TextBox.TabIndex = 0
        ' 
        ' Subject_TextBox
        ' 
        Subject_TextBox.Location = New Point(100, 106)
        Subject_TextBox.Name = "Subject_TextBox"
        Subject_TextBox.Size = New Size(585, 27)
        Subject_TextBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 20)
        Label1.TabIndex = 2
        Label1.Text = "To"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 3
        Label2.Text = "Subject"
        ' 
        ' Content_TextBox
        ' 
        Content_TextBox.Location = New Point(100, 183)
        Content_TextBox.Multiline = True
        Content_TextBox.Name = "Content_TextBox"
        Content_TextBox.Size = New Size(585, 159)
        Content_TextBox.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 5
        Label3.Text = "Content"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(51, 357)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(794, 225)
        DataGridView1.TabIndex = 6
        ' 
        ' Draft_Button
        ' 
        Draft_Button.Location = New Point(939, 5)
        Draft_Button.Name = "Draft_Button"
        Draft_Button.Size = New Size(91, 56)
        Draft_Button.TabIndex = 7
        Draft_Button.Text = "Draft"
        Draft_Button.UseVisualStyleBackColor = True
        ' 
        ' Send_Button
        ' 
        Send_Button.Location = New Point(939, 88)
        Send_Button.Name = "Send_Button"
        Send_Button.Size = New Size(91, 56)
        Send_Button.TabIndex = 8
        Send_Button.Text = "Send"
        Send_Button.UseVisualStyleBackColor = True
        ' 
        ' Clear_Button
        ' 
        Clear_Button.Location = New Point(939, 168)
        Clear_Button.Name = "Clear_Button"
        Clear_Button.Size = New Size(91, 56)
        Clear_Button.TabIndex = 9
        Clear_Button.Text = "Clear"
        Clear_Button.UseVisualStyleBackColor = True
        ' 
        ' Delete_Button
        ' 
        Delete_Button.Location = New Point(939, 251)
        Delete_Button.Name = "Delete_Button"
        Delete_Button.Size = New Size(91, 56)
        Delete_Button.TabIndex = 10
        Delete_Button.Text = "Delete"
        Delete_Button.UseVisualStyleBackColor = True
        ' 
        ' Refresh_Button
        ' 
        Refresh_Button.Location = New Point(939, 345)
        Refresh_Button.Name = "Refresh_Button"
        Refresh_Button.Size = New Size(91, 56)
        Refresh_Button.TabIndex = 11
        Refresh_Button.Text = "Refresh"
        Refresh_Button.UseVisualStyleBackColor = True
        ' 
        ' Email_Draft
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1089, 594)
        Controls.Add(Refresh_Button)
        Controls.Add(Delete_Button)
        Controls.Add(Clear_Button)
        Controls.Add(Send_Button)
        Controls.Add(Draft_Button)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Content_TextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Subject_TextBox)
        Controls.Add(To_TextBox)
        Name = "Email_Draft"
        Text = "l"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents To_TextBox As TextBox
    Friend WithEvents Subject_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Content_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Draft_Button As Button
    Friend WithEvents Send_Button As Button
    Friend WithEvents Clear_Button As Button
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Refresh_Button As Button
End Class
