<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rating
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
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.LawnGreen
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Exo 2", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(0, 0)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 25)
        Label5.TabIndex = 29
        Label5.Text = "3.5"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Rating
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(Label5)
        Name = "Rating"
        Size = New Size(35, 25)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label5 As Label

End Class
