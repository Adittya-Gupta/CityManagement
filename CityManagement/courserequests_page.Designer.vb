<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class courserequests_page
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
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Lucida Console", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(474, 10)
        Button3.Name = "Button3"
        Button3.Size = New Size(468, 285)
        Button3.TabIndex = 8
        Button3.Text = "Requests page"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' courserequests_page
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(953, 535)
        Controls.Add(Button3)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "courserequests_page"
        Text = "courserequests_page"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button3 As Button
End Class
