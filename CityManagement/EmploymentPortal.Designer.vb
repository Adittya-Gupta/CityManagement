<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmploymentPortal
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
        Button1 = New Button()
        CurvedLabel1 = New CurvedLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1254, 73)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(0, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1254, 953)
        Panel1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.Black
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Exo 2", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(809, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(445, 73)
        Button1.TabIndex = 7
        Button1.Text = "New Hospital Proposal"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.BackColor = Color.White
        CurvedLabel1.CornerRadius = 5
        CurvedLabel1.Location = New Point(809, -4)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Size = New Size(445, 11)
        CurvedLabel1.TabIndex = 8
        ' 
        ' EmploymentPortal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1254, 1026)
        Controls.Add(CurvedLabel1)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "EmploymentPortal"
        Text = "EmploymentPortal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents CurvedLabel1 As CurvedLabel
End Class
