<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Incoming_details
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
        Label1 = New Label()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        Label2 = New Label()
        RichTextBox3 = New RichTextBox()
        Label3 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Exo 2", 10F, FontStyle.Bold)
        Label1.Location = New Point(31, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 20)
        Label1.TabIndex = 0
        Label1.Text = "Contact details"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(31, 59)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(305, 32)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(31, 148)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(305, 32)
        RichTextBox2.TabIndex = 3
        RichTextBox2.Text = ""
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Exo 2", 10F, FontStyle.Bold)
        Label2.Location = New Point(31, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 20)
        Label2.TabIndex = 2
        Label2.Text = "Bank Account No."
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.Location = New Point(31, 235)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(370, 117)
        RichTextBox3.TabIndex = 5
        RichTextBox3.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Exo 2", 10F, FontStyle.Bold)
        Label3.Location = New Point(31, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(171, 20)
        Label3.TabIndex = 4
        Label3.Text = "Any Previous Works"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(97), CByte(160), CByte(255))
        Button1.Font = New Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(31, 408)
        Button1.Name = "Button1"
        Button1.Size = New Size(370, 58)
        Button1.TabIndex = 6
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Incoming_details
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(Button1)
        Controls.Add(RichTextBox3)
        Controls.Add(Label3)
        Controls.Add(RichTextBox2)
        Controls.Add(Label2)
        Controls.Add(RichTextBox1)
        Controls.Add(Label1)
        Font = New Font("Exo 2", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Incoming_details"
        Size = New Size(434, 491)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button

End Class
