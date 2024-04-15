<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class complaints_failed_transaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(complaints_failed_transaction))
        RichTextBox1 = New RichTextBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Panel3 = New Panel()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(181, 158)
        RichTextBox1.Margin = New Padding(3, 4, 3, 4)
        RichTextBox1.MaxLength = 300
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(646, 161)
        RichTextBox1.TabIndex = 8
        RichTextBox1.Text = ""
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(363, 89)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(222, 23)
        TextBox1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Book Antiqua", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 18)
        Label2.TabIndex = 12
        Label2.Text = "Complaint Portal  >"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Book Antiqua", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(248, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 19)
        Label1.TabIndex = 11
        Label1.Text = "Failed Transaction"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Book Antiqua", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(150, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 18)
        Label3.TabIndex = 13
        Label3.Text = "Commerce  >"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(181, 86)
        Label4.Name = "Label4"
        Label4.Size = New Size(157, 26)
        Label4.TabIndex = 14
        Label4.Text = "Transaction ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(181, 128)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 26)
        Label5.TabIndex = 15
        Label5.Text = "Issue"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Bell MT", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(399, 345)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 46)
        Button1.TabIndex = 16
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Location = New Point(0, 505)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1107, 255)
        Panel3.TabIndex = 17
        ' 
        ' complaints_failed_transaction
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1107, 760)
        Controls.Add(Panel3)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(RichTextBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "complaints_failed_transaction"
        Text = "failed_transaction"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
End Class
