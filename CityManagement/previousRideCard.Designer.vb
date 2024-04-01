<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class previousRideCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(previousRideCard))
        Panel4 = New Panel()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label10 = New Label()
        PictureBox1 = New PictureBox()
        Label11 = New Label()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ButtonHighlight
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(PictureBox1)
        Panel4.Location = New Point(3, 2)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(470, 123)
        Panel4.TabIndex = 5
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label15.Location = New Point(126, 62)
        Label15.Name = "Label15"
        Label15.Size = New Size(67, 19)
        Label15.TabIndex = 6
        Label15.Text = "RK Plaza"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(101, 64)
        Label14.Name = "Label14"
        Label14.Size = New Size(18, 15)
        Label14.TabIndex = 5
        Label14.Text = "to"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label13.Location = New Point(6, 63)
        Label13.Name = "Label13"
        Label13.Size = New Size(91, 19)
        Label13.TabIndex = 4
        Label13.Text = "Rajiv Chowk"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(6, 39)
        Label12.Name = "Label12"
        Label12.Size = New Size(102, 15)
        Label12.TabIndex = 3
        Label12.Text = "Prime Sedan from"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label10.Location = New Point(285, 11)
        Label10.Name = "Label10"
        Label10.Size = New Size(44, 19)
        Label10.TabIndex = 1
        Label10.Text = "97 Rs"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(261, 39)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 41)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label11.Location = New Point(3, 11)
        Label11.Name = "Label11"
        Label11.Size = New Size(180, 19)
        Label11.TabIndex = 2
        Label11.Text = "Tue, 3rd March, 10:05 AM"
        ' 
        ' previousRideCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel4)
        Name = "previousRideCard"
        Size = New Size(364, 91)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label

End Class
