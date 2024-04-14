<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomingDetailsForm
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
        Button1 = New Button()
        RichTextBox3 = New RichTextBox()
        Label3 = New Label()
        RichTextBox2 = New RichTextBox()
        Label2 = New Label()
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(97), CByte(160), CByte(255))
        Button1.Font = New Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(22, 385)
        Button1.Name = "Button1"
        Button1.Size = New Size(370, 58)
        Button1.TabIndex = 13
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.Location = New Point(22, 212)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(370, 117)
        RichTextBox3.TabIndex = 12
        RichTextBox3.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Exo 2", 10F, FontStyle.Bold)
        Label3.Location = New Point(22, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(171, 20)
        Label3.TabIndex = 11
        Label3.Text = "Any Previous Works"
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(22, 125)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(305, 32)
        RichTextBox2.TabIndex = 10
        RichTextBox2.Text = ""
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Exo 2", 10F, FontStyle.Bold)
        Label2.Location = New Point(22, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 20)
        Label2.TabIndex = 9
        Label2.Text = "Bank Account No."
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(22, 36)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(305, 32)
        RichTextBox1.TabIndex = 8
        RichTextBox1.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Exo 2", 10F, FontStyle.Bold)
        Label1.Location = New Point(22, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 20)
        Label1.TabIndex = 7
        Label1.Text = "Contact details"
        ' 
        ' IncomingDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(416, 461)
        Controls.Add(Button1)
        Controls.Add(RichTextBox3)
        Controls.Add(Label3)
        Controls.Add(RichTextBox2)
        Controls.Add(Label2)
        Controls.Add(RichTextBox1)
        Controls.Add(Label1)
        Name = "IncomingDetailsForm"
        Text = "IncomingDetailsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
End Class
