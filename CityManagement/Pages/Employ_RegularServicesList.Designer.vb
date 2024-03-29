<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegularServicesList
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
        CurvedLabel8 = New CurvedLabel()
        CurvedLabel4 = New CurvedLabel()
        CurvedLabel7 = New CurvedLabel()
        CurvedLabel3 = New CurvedLabel()
        CurvedLabel6 = New CurvedLabel()
        CurvedLabel2 = New CurvedLabel()
        CurvedLabel5 = New CurvedLabel()
        CurvedLabel1 = New CurvedLabel()
        Label4 = New Label()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' CurvedLabel8
        ' 
        CurvedLabel8.CornerRadius = 10
        CurvedLabel8.Image = My.Resources.Resources.image_39__1_
        CurvedLabel8.Location = New Point(663, 720)
        CurvedLabel8.Name = "CurvedLabel8"
        CurvedLabel8.Size = New Size(270, 140)
        CurvedLabel8.TabIndex = 28
        ' 
        ' CurvedLabel4
        ' 
        CurvedLabel4.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        CurvedLabel4.CornerRadius = 10
        CurvedLabel4.Cursor = Cursors.Hand
        CurvedLabel4.Font = New Font("Exo 2", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel4.Location = New Point(663, 720)
        CurvedLabel4.Name = "CurvedLabel4"
        CurvedLabel4.Padding = New Padding(0, 0, 10, 10)
        CurvedLabel4.Size = New Size(471, 140)
        CurvedLabel4.TabIndex = 27
        CurvedLabel4.Text = "Househelp"
        CurvedLabel4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' CurvedLabel7
        ' 
        CurvedLabel7.CornerRadius = 10
        CurvedLabel7.Image = My.Resources.Resources.image_39__2_
        CurvedLabel7.Location = New Point(94, 549)
        CurvedLabel7.Name = "CurvedLabel7"
        CurvedLabel7.Size = New Size(270, 140)
        CurvedLabel7.TabIndex = 26
        ' 
        ' CurvedLabel3
        ' 
        CurvedLabel3.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        CurvedLabel3.CornerRadius = 10
        CurvedLabel3.Cursor = Cursors.Hand
        CurvedLabel3.Font = New Font("Exo 2", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel3.Location = New Point(94, 549)
        CurvedLabel3.Name = "CurvedLabel3"
        CurvedLabel3.Padding = New Padding(0, 0, 10, 10)
        CurvedLabel3.Size = New Size(471, 140)
        CurvedLabel3.TabIndex = 25
        CurvedLabel3.Text = "Merchant"
        CurvedLabel3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' CurvedLabel6
        ' 
        CurvedLabel6.CornerRadius = 10
        CurvedLabel6.Image = My.Resources.Resources.image_39
        CurvedLabel6.Location = New Point(663, 380)
        CurvedLabel6.Name = "CurvedLabel6"
        CurvedLabel6.Size = New Size(270, 140)
        CurvedLabel6.TabIndex = 24
        ' 
        ' CurvedLabel2
        ' 
        CurvedLabel2.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        CurvedLabel2.CornerRadius = 10
        CurvedLabel2.Cursor = Cursors.Hand
        CurvedLabel2.Font = New Font("Exo 2", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel2.Location = New Point(663, 380)
        CurvedLabel2.Name = "CurvedLabel2"
        CurvedLabel2.Padding = New Padding(0, 0, 10, 10)
        CurvedLabel2.Size = New Size(471, 140)
        CurvedLabel2.TabIndex = 23
        CurvedLabel2.Text = "Plumber"
        CurvedLabel2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' CurvedLabel5
        ' 
        CurvedLabel5.CornerRadius = 10
        CurvedLabel5.Image = My.Resources.Resources.image_39__3_
        CurvedLabel5.Location = New Point(94, 210)
        CurvedLabel5.Name = "CurvedLabel5"
        CurvedLabel5.Size = New Size(270, 140)
        CurvedLabel5.TabIndex = 22
        ' 
        ' CurvedLabel1
        ' 
        CurvedLabel1.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        CurvedLabel1.CornerRadius = 10
        CurvedLabel1.Cursor = Cursors.Hand
        CurvedLabel1.Font = New Font("Exo 2", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CurvedLabel1.Location = New Point(94, 210)
        CurvedLabel1.Name = "CurvedLabel1"
        CurvedLabel1.Padding = New Padding(0, 0, 10, 10)
        CurvedLabel1.Size = New Size(471, 140)
        CurvedLabel1.TabIndex = 21
        CurvedLabel1.Text = "Electrician"
        CurvedLabel1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(96), CByte(85), CByte(85))
        Label4.Location = New Point(411, 69)
        Label4.Name = "Label4"
        Label4.Size = New Size(400, 61)
        Label4.TabIndex = 20
        Label4.Text = "List of Regular Services"
        ' 
        ' backButton
        ' 
        backButton.AutoSize = True
        backButton.BackColor = Color.Black
        backButton.Cursor = Cursors.Hand
        backButton.FlatAppearance.BorderSize = 0
        backButton.FlatStyle = FlatStyle.Flat
        backButton.Font = New Font("Exo 2", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backButton.ForeColor = Color.White
        backButton.Location = New Point(1098, 12)
        backButton.Name = "backButton"
        backButton.Size = New Size(111, 43)
        backButton.TabIndex = 29
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' RegularServicesList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1236, 979)
        Controls.Add(backButton)
        Controls.Add(CurvedLabel8)
        Controls.Add(CurvedLabel4)
        Controls.Add(CurvedLabel7)
        Controls.Add(CurvedLabel3)
        Controls.Add(CurvedLabel6)
        Controls.Add(CurvedLabel2)
        Controls.Add(CurvedLabel5)
        Controls.Add(CurvedLabel1)
        Controls.Add(Label4)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegularServicesList"
        Text = "RegularServicesList"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CurvedLabel8 As CurvedLabel
    Friend WithEvents CurvedLabel4 As CurvedLabel
    Friend WithEvents CurvedLabel7 As CurvedLabel
    Friend WithEvents CurvedLabel3 As CurvedLabel
    Friend WithEvents CurvedLabel6 As CurvedLabel
    Friend WithEvents CurvedLabel2 As CurvedLabel
    Friend WithEvents CurvedLabel5 As CurvedLabel
    Friend WithEvents CurvedLabel1 As CurvedLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents backButton As Button
End Class
