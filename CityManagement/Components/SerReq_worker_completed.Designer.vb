<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerReq_worker_completed
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
        Label6 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
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
        Label2.Location = New Point(142, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 20)
        Label2.TabIndex = 2
        Label2.Text = "Service Time: "
        ' 
        ' Label6
        ' 
        Label6.Image = Group_1931
        Label6.Location = New Point(581, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 67)
        Label6.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Exo 2", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(142, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 20)
        Label3.TabIndex = 10
        Label3.Text = "Bill Amount: Rs. "
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(267, 55)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(177, 27)
        TextBox1.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(279, 86)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(177, 27)
        TextBox2.TabIndex = 16
        ' 
        ' SerReq_worker_completed
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "SerReq_worker_completed"
        Size = New Size(986, 127)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox

End Class
