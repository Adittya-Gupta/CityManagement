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
        Label5 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(274, 86)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 23)
        Label5.TabIndex = 18
        Label5.Text = "Label5"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Exo 2", 10F)
        Label3.Location = New Point(142, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 20)
        Label3.TabIndex = 17
        Label3.Text = "Bill Amount: Rs. "
        ' 
        ' Label6
        ' 
        Label6.Image = My.Resources.Resources.Frame_1060
        Label6.Location = New Point(581, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 67)
        Label6.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(260, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 23)
        Label4.TabIndex = 15
        Label4.Text = "Label4"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Exo 2", 10F)
        Label2.Location = New Point(142, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 14
        Label2.Text = "Service Time: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(142, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 28)
        Label1.TabIndex = 13
        Label1.Text = "Label1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Mask_group
        PictureBox1.InitialImage = My.Resources.Resources.Mask_group
        PictureBox1.Location = New Point(22, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 88)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' SerReq_worker_paymentDue
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "SerReq_worker_paymentDue"
        Size = New Size(986, 127)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
