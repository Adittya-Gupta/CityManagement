﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerReq_worker_accepted
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label6 = New Label()
        Label3 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Mask_group
        PictureBox1.InitialImage = My.Resources.Resources.Mask_group
        PictureBox1.Location = New Point(22, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 88)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(142, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 28)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Exo 2", 10F)
        Label2.Location = New Point(142, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 2
        Label2.Text = "Service Time: "
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = SystemColors.Control
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = My.Resources.Resources.Group_1891
        Button1.Location = New Point(794, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 39)
        Button1.TabIndex = 7
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = SystemColors.Control
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Image = My.Resources.Resources.Group_190
        Button2.Location = New Point(794, 20)
        Button2.Name = "Button2"
        Button2.Size = New Size(158, 39)
        Button2.TabIndex = 8
        Button2.Text = "Done"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.Image = My.Resources.Resources.Frame_10591
        Label6.Location = New Point(581, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 67)
        Label6.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Exo 2", 10F)
        Label3.Location = New Point(142, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 20)
        Label3.TabIndex = 10
        Label3.Text = "Bill Amount: Rs. "
        ' 
        ' Label7
        ' 
        Label7.Cursor = Cursors.Hand
        Label7.Image = My.Resources.Resources.Vector
        Label7.Location = New Point(467, 55)
        Label7.Name = "Label7"
        Label7.Size = New Size(33, 22)
        Label7.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.Cursor = Cursors.Hand
        Label8.Image = My.Resources.Resources.Vector
        Label8.Location = New Point(466, 87)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 22)
        Label8.TabIndex = 13
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(263, 53)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(177, 27)
        TextBox1.TabIndex = 14
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(274, 84)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(166, 27)
        TextBox2.TabIndex = 15
        ' 
        ' SerReq_worker_accepted
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "SerReq_worker_accepted"
        Size = New Size(986, 127)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox

End Class
