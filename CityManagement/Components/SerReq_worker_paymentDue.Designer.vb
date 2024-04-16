<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerReq_worker_paymentDue
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
        Label6 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.Image = Frame_1060
        Label6.Location = New Point(581, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 67)
        Label6.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(142, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 27)
        Label1.TabIndex = 13
        Label1.Text = "Label1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = Mask_group
        PictureBox1.InitialImage = Mask_group
        PictureBox1.Location = New Point(22, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 88)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(285, 86)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(177, 27)
        TextBox2.TabIndex = 22
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(270, 55)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(177, 27)
        TextBox1.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Exo 2", 10.2F, FontStyle.Bold)
        Label7.Location = New Point(142, 86)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 20)
        Label7.TabIndex = 20
        Label7.Text = "Bill Amount: Rs. "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Exo 2", 10.2F, FontStyle.Bold)
        Label8.Location = New Point(142, 57)
        Label8.Name = "Label8"
        Label8.Size = New Size(122, 20)
        Label8.TabIndex = 19
        Label8.Text = "Service Time: "
        ' 
        ' SerReq_worker_paymentDue
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "SerReq_worker_paymentDue"
        Size = New Size(986, 127)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

End Class
