<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployOrgList
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Abhaya Libre Medium", 20F)
        Label1.Location = New Point(344, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(328, 53)
        Label1.TabIndex = 0
        Label1.Text = "List of Organizations"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Exo 2", 15F)
        Label2.Location = New Point(126, 299)
        Label2.Name = "Label2"
        Label2.Size = New Size(262, 100)
        Label2.TabIndex = 1
        Label2.Text = "Hospital"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Exo 2", 15F)
        Label3.Location = New Point(614, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(262, 100)
        Label3.TabIndex = 2
        Label3.Text = "Regular Services"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Exo 2", 15F)
        Label4.Location = New Point(614, 400)
        Label4.Name = "Label4"
        Label4.Size = New Size(262, 100)
        Label4.TabIndex = 3
        Label4.Text = "Police Station"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Exo 2", 15F)
        Label5.Location = New Point(126, 509)
        Label5.Name = "Label5"
        Label5.Size = New Size(262, 100)
        Label5.TabIndex = 4
        Label5.Text = "Education"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Font = New Font("Exo 2", 15F)
        Label6.Location = New Point(614, 599)
        Label6.Name = "Label6"
        Label6.Size = New Size(262, 100)
        Label6.TabIndex = 5
        Label6.Text = "Transport"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' EmployOrgList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1011, 849)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "EmployOrgList"
        Text = "EmployOrgList"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
