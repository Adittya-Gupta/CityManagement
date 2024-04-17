<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Banking_Panel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Home_Button = New Button()
        LoanApproval_Button = New Button()
        Queries_Button = New Button()
        NewAcc_Button = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(3, 4)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1083, 63)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(187, 65)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(899, 510)
        Panel3.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Navy
        Panel2.Controls.Add(Home_Button)
        Panel2.Controls.Add(LoanApproval_Button)
        Panel2.Controls.Add(Queries_Button)
        Panel2.Controls.Add(NewAcc_Button)
        Panel2.Location = New Point(3, 62)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(190, 513)
        Panel2.TabIndex = 1
        ' 
        ' Home_Button
        ' 
        Home_Button.BackColor = Color.DarkBlue
        Home_Button.Font = New Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Home_Button.ForeColor = SystemColors.ButtonHighlight
        Home_Button.Location = New Point(0, 0)
        Home_Button.Margin = New Padding(3, 2, 3, 2)
        Home_Button.Name = "Home_Button"
        Home_Button.Size = New Size(187, 76)
        Home_Button.TabIndex = 31
        Home_Button.Text = "Home"
        Home_Button.UseVisualStyleBackColor = False
        ' 
        ' LoanApproval_Button
        ' 
        LoanApproval_Button.BackColor = Color.DarkBlue
        LoanApproval_Button.Font = New Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LoanApproval_Button.ForeColor = SystemColors.ButtonHighlight
        LoanApproval_Button.Location = New Point(3, 189)
        LoanApproval_Button.Margin = New Padding(3, 2, 3, 2)
        LoanApproval_Button.Name = "LoanApproval_Button"
        LoanApproval_Button.Size = New Size(187, 76)
        LoanApproval_Button.TabIndex = 30
        LoanApproval_Button.Text = "Loan Approvals"
        LoanApproval_Button.UseVisualStyleBackColor = False
        ' 
        ' Queries_Button
        ' 
        Queries_Button.BackColor = Color.DarkBlue
        Queries_Button.Font = New Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Queries_Button.ForeColor = SystemColors.ButtonHighlight
        Queries_Button.Location = New Point(3, 281)
        Queries_Button.Margin = New Padding(3, 2, 3, 2)
        Queries_Button.Name = "Queries_Button"
        Queries_Button.Size = New Size(187, 76)
        Queries_Button.TabIndex = 29
        Queries_Button.Text = "Queries and Complaints"
        Queries_Button.UseVisualStyleBackColor = False
        ' 
        ' NewAcc_Button
        ' 
        NewAcc_Button.BackColor = Color.DarkBlue
        NewAcc_Button.Font = New Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NewAcc_Button.ForeColor = SystemColors.ButtonHighlight
        NewAcc_Button.Location = New Point(0, 95)
        NewAcc_Button.Margin = New Padding(3, 2, 3, 2)
        NewAcc_Button.Name = "NewAcc_Button"
        NewAcc_Button.Size = New Size(187, 76)
        NewAcc_Button.TabIndex = 27
        NewAcc_Button.Text = "New Account Registrations"
        NewAcc_Button.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = Bank_Logo
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(9, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(69, 57)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Banking_Panel
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.Control
        ClientSize = New Size(1089, 570)
        ControlBox = False
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Banking_Panel"
        Text = "Banking_Panel"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LoanApproval_Button As Button
    Friend WithEvents Queries_Button As Button
    Friend WithEvents NewAcc_Button As Button
    Friend WithEvents Home_Button As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox

End Class
