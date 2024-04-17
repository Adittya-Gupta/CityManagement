<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerReq_worker_pending
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label8 = New Label()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = Mask_group
        PictureBox1.InitialImage = Mask_group
        PictureBox1.Location = New Point(22, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 88)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(142, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 27)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Exo 2", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(142, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 20)
        Label2.TabIndex = 2
        Label2.Text = "Service Time: "
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = SystemColors.Control
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Exo 2", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Image = Group_1891
        Button1.Location = New Point(794, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 39)
        Button1.TabIndex = 7
        Button1.Text = "Reject"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = SystemColors.Control
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Exo 2", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Image = Group_190
        Button2.Location = New Point(794, 20)
        Button2.Name = "Button2"
        Button2.Size = New Size(158, 39)
        Button2.TabIndex = 8
        Button2.Text = "Confirm"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.Image = Group_194
        Label6.Location = New Point(581, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 67)
        Label6.TabIndex = 9
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(264, 54)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(177, 27)
        TextBox1.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(284, 86)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(166, 27)
        TextBox2.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.Cursor = Cursors.Hand
        Label8.Image = Vector
        Label8.Location = New Point(481, 89)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 22)
        Label8.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Exo 2", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(142, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 20)
        Label3.TabIndex = 17
        Label3.Text = "Bill Amount: Rs. "
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(447, 54)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(18, 27)
        DateTimePicker1.TabIndex = 20
        ' 
        ' SerReq_worker_pending
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox2)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "SerReq_worker_pending"
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker

End Class
