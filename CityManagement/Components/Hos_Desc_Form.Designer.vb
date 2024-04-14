<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hos_Desc_Form
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
        Button1 = New Button()
        RichTextBox3 = New RichTextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(97), CByte(160), CByte(255))
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(19, 175)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(324, 44)
        Button1.TabIndex = 13
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.Location = New Point(19, 49)
        RichTextBox3.Margin = New Padding(3, 2, 3, 2)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(324, 104)
        RichTextBox3.TabIndex = 12
        RichTextBox3.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Label3.Location = New Point(19, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 17)
        Label3.TabIndex = 11
        Label3.Text = "Description : "
        ' 
        ' Hos_Desc_Form
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(364, 247)
        Controls.Add(Button1)
        Controls.Add(RichTextBox3)
        Controls.Add(Label3)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Hos_Desc_Form"
        Text = "IncomingDetailsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Label3 As Label
End Class
