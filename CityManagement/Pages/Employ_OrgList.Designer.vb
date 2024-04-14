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
        CurvedLabel4 = New CurvedLabel()
        CurvedLabel3 = New CurvedLabel()
        CurvedLabel2 = New CurvedLabel()
        CurvedLabel1 = New CurvedLabel()
        CurvedLabel10 = New CurvedLabel()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' CurvedLabel4
        ' 
        CurvedLabel4.BackColor = Color.Black
        CurvedLabel4.CornerRadius = 10
        CurvedLabel4.Cursor = Cursors.Hand
        CurvedLabel4.Font = New Font("Exo 2", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel4.ForeColor = Color.White
        CurvedLabel4.Image = Employ_transport
        CurvedLabel4.ImageAlign = ContentAlignment.TopLeft
        CurvedLabel4.Location = New Point(579, 297)
        CurvedLabel4.Name = "CurvedLabel4"
        CurvedLabel4.Padding = New Padding(0, 0, 10, 10)
        CurvedLabel4.Size = New Size(475, 185)
        CurvedLabel4.TabIndex = 27
        CurvedLabel4.Text = "Transport"
        CurvedLabel4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' CurvedLabel3
        ' 
        CurvedLabel3.BackColor = Color.Black
        CurvedLabel3.CornerRadius = 10
        CurvedLabel3.Cursor = Cursors.Hand
        CurvedLabel3.Font = New Font("Exo 2", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel3.ForeColor = Color.White
        CurvedLabel3.Image = Employ_ed
        CurvedLabel3.ImageAlign = ContentAlignment.TopLeft
        CurvedLabel3.Location = New Point(579, 95)
        CurvedLabel3.Name = "CurvedLabel3"
        CurvedLabel3.Padding = New Padding(0, 0, 10, 10)
        CurvedLabel3.Size = New Size(475, 185)
        CurvedLabel3.TabIndex = 25
        CurvedLabel3.Text = "Education" & vbCrLf & "Institute" & vbCrLf
        CurvedLabel3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' CurvedLabel2
        ' 
        CurvedLabel2.BackColor = Color.Black
        CurvedLabel2.CornerRadius = 10
        CurvedLabel2.Cursor = Cursors.Hand
        CurvedLabel2.Font = New Font("Exo 2", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel2.ForeColor = Color.White
        CurvedLabel2.Image = Employ_police
        CurvedLabel2.ImageAlign = ContentAlignment.TopLeft
        CurvedLabel2.Location = New Point(319, 500)
        CurvedLabel2.Name = "CurvedLabel2"
        CurvedLabel2.Padding = New Padding(0, 0, 10, 10)
        CurvedLabel2.Size = New Size(475, 185)
        CurvedLabel2.TabIndex = 23
        CurvedLabel2.Text = "Police " & vbCrLf & "Station"
        CurvedLabel2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.BackColor = Color.Black
        CurvedLabel1.CornerRadius = 10
        CurvedLabel1.Cursor = Cursors.Hand
        CurvedLabel1.FlatStyle = FlatStyle.Popup
        CurvedLabel1.Font = New Font("Exo 2", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel1.ForeColor = Color.White
        CurvedLabel1.Image = Employ_hosp
        CurvedLabel1.ImageAlign = ContentAlignment.TopLeft
        CurvedLabel1.Location = New Point(62, 95)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Padding = New Padding(0, 0, 10, 10)
        CurvedLabel1.Size = New Size(475, 185)
        CurvedLabel1.TabIndex = 21
        CurvedLabel1.Text = "Hospital"
        CurvedLabel1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' CurvedLabel10
        ' 
        CurvedLabel10.BackColor = Color.Black
        CurvedLabel10.CornerRadius = 10
        CurvedLabel10.Cursor = Cursors.Hand
        CurvedLabel10.Font = New Font("Exo 2", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel10.ForeColor = Color.White
        CurvedLabel10.Image = Employ_service2
        CurvedLabel10.ImageAlign = ContentAlignment.TopLeft
        CurvedLabel10.Location = New Point(68, 298)
        CurvedLabel10.Name = "CurvedLabel10"
        CurvedLabel10.Padding = New Padding(0, 0, 10, 10)
        CurvedLabel10.Size = New Size(475, 185)
        CurvedLabel10.TabIndex = 29
        CurvedLabel10.Text = "Regular " & vbCrLf & "Service"
        CurvedLabel10.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Abhaya Libre Medium", 30F)
        Label8.Location = New Point(319, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(450, 59)
        Label8.TabIndex = 49
        Label8.Text = "List of Organizations"
        ' 
        ' EmployOrgList
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        ClientSize = New Size(1107, 705)
        Controls.Add(Label8)
        Controls.Add(CurvedLabel10)
        Controls.Add(CurvedLabel4)
        Controls.Add(CurvedLabel3)
        Controls.Add(CurvedLabel2)
        Controls.Add(CurvedLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "EmployOrgList"
        Text = "EmployOrgList"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CurvedLabel4 As CurvedLabel
    Friend WithEvents CurvedLabel3 As CurvedLabel
    Friend WithEvents CurvedLabel2 As CurvedLabel
    Friend WithEvents CurvedLabel1 As CurvedLabel
    Friend WithEvents CurvedLabel10 As CurvedLabel
    Friend WithEvents Label8 As Label
End Class
