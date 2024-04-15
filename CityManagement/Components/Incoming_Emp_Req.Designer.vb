<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Incoming_Emp_Req
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
        Label3 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Button3 = New Button()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Exo 2", 14F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(122), CByte(121), CByte(121))
        Label3.Location = New Point(148, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 29)
        Label3.TabIndex = 22
        Label3.Text = "Details : "
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderColor = SystemColors.Control
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Image = Group_190
        Button2.Location = New Point(545, 81)
        Button2.Name = "Button2"
        Button2.Size = New Size(130, 45)
        Button2.TabIndex = 20
        Button2.Text = "Approve"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = SystemColors.Control
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Image = Group_1891
        Button1.Location = New Point(708, 81)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 45)
        Button1.TabIndex = 19
        Button1.Text = "Reject"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Exo 2", 14F, FontStyle.Bold)
        Label2.Location = New Point(148, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 29)
        Label2.TabIndex = 18
        Label2.Text = "Name : "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = Mask_group
        PictureBox1.InitialImage = Mask_group
        PictureBox1.Location = New Point(30, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 88)
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(248, 53)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 24
        Label4.Text = "Label4"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(264, 81)
        Button3.Name = "Button3"
        Button3.Size = New Size(67, 29)
        Button3.TabIndex = 25
        Button3.Text = "View"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(733, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 26
        Label1.Text = "Label1"
        ' 
        ' Incoming_Emp_Req
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Name = "Incoming_Emp_Req"
        Size = New Size(882, 150)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label

End Class
