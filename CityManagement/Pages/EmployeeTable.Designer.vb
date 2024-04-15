<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeTable
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
        Label1 = New Label()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Exo 2", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(366, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 41)
        Label1.TabIndex = 0
        Label1.Text = "Employees"
        Label1.UseMnemonic = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Font = New Font("Exo 2", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(0, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(914, 332)
        Panel1.TabIndex = 1
        ' 
        ' EmployeeTable
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1107, 687)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "EmployeeTable"
        Text = "EmployeeTable"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
