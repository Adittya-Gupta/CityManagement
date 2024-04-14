<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Admin
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
        TextBoxName = New TextBox()
        TextBoxEmail = New TextBox()
        TextBoxContact = New TextBox()
        TextBoxPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        GetDetailsButton = New Button()
        AddUserButton = New Button()
        EditUserButton = New Button()
        DeleteUserButton = New Button()
        ClearButton = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(56, 129)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(818, 184)
        DataGridView1.TabIndex = 0
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(187, 379)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(202, 29)
        TextBoxName.TabIndex = 1
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(672, 379)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(202, 29)
        TextBoxEmail.TabIndex = 2
        ' 
        ' TextBoxContact
        ' 
        TextBoxContact.Location = New Point(187, 474)
        TextBoxContact.Name = "TextBoxContact"
        TextBoxContact.Size = New Size(202, 29)
        TextBoxContact.TabIndex = 3
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(672, 474)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(202, 29)
        TextBoxPassword.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(44, 37)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 25)
        Label1.TabIndex = 5
        Label1.Text = "Home  >"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(125, 37)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 25)
        Label2.TabIndex = 6
        Label2.Text = "Dashboard >"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(250, 37)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 25)
        Label3.TabIndex = 7
        Label3.Text = "Admin Page"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Exo 2", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(56, 381)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 20)
        Label4.TabIndex = 8
        Label4.Text = "User Name :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Exo 2", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(531, 382)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 20)
        Label5.TabIndex = 9
        Label5.Text = "Email :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Exo 2", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(56, 477)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 20)
        Label6.TabIndex = 10
        Label6.Text = "Contact :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Exo 2", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(531, 477)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 20)
        Label7.TabIndex = 11
        Label7.Text = "Password :"
        ' 
        ' GetDetailsButton
        ' 
        GetDetailsButton.Location = New Point(911, 129)
        GetDetailsButton.Name = "GetDetailsButton"
        GetDetailsButton.Size = New Size(134, 43)
        GetDetailsButton.TabIndex = 12
        GetDetailsButton.Text = "Fetch Details"
        GetDetailsButton.UseVisualStyleBackColor = True
        ' 
        ' AddUserButton
        ' 
        AddUserButton.Location = New Point(56, 584)
        AddUserButton.Name = "AddUserButton"
        AddUserButton.Size = New Size(134, 43)
        AddUserButton.TabIndex = 13
        AddUserButton.Text = "Add User"
        AddUserButton.UseVisualStyleBackColor = True
        ' 
        ' EditUserButton
        ' 
        EditUserButton.Location = New Point(250, 584)
        EditUserButton.Name = "EditUserButton"
        EditUserButton.Size = New Size(134, 43)
        EditUserButton.TabIndex = 14
        EditUserButton.Text = "Edit Details"
        EditUserButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteUserButton
        ' 
        DeleteUserButton.Location = New Point(442, 584)
        DeleteUserButton.Name = "DeleteUserButton"
        DeleteUserButton.Size = New Size(134, 43)
        DeleteUserButton.TabIndex = 15
        DeleteUserButton.Text = "Delete User"
        DeleteUserButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(911, 193)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(134, 43)
        ClearButton.TabIndex = 16
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' User_Admin
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1107, 760)
        Controls.Add(ClearButton)
        Controls.Add(DeleteUserButton)
        Controls.Add(EditUserButton)
        Controls.Add(AddUserButton)
        Controls.Add(GetDetailsButton)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxContact)
        Controls.Add(TextBoxEmail)
        Controls.Add(TextBoxName)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "User_Admin"
        Text = "User_Admin"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxContact As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GetDetailsButton As Button
    Friend WithEvents AddUserButton As Button
    Friend WithEvents EditUserButton As Button
    Friend WithEvents DeleteUserButton As Button
    Friend WithEvents ClearButton As Button
End Class
