<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hos_Vac_Description
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        RichTextBox3 = New RichTextBox()
        Label3 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.Location = New Point(31, 74)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(370, 158)
        RichTextBox3.TabIndex = 5
        RichTextBox3.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Label3.Location = New Point(31, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 20)
        Label3.TabIndex = 4
        Label3.Text = "Description"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(97), CByte(160), CByte(255))
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(31, 265)
        Button1.Name = "Button1"
        Button1.Size = New Size(370, 58)
        Button1.TabIndex = 6
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Hos_Vac_Description
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(Button1)
        Controls.Add(RichTextBox3)
        Controls.Add(Label3)
        Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Hos_Vac_Description"
        Size = New Size(434, 345)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button

End Class
