<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quer1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quer1))
        Save = New Button()
        Submit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        response = New TextBox()
        description = New Label()
        SuspendLayout()
        ' 
        ' Save
        ' 
        Save.Anchor = AnchorStyles.None
        Save.BackColor = Color.DodgerBlue
        Save.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Save.ForeColor = SystemColors.Control
        Save.Location = New Point(189, 561)
        Save.Name = "Save"
        Save.Size = New Size(158, 49)
        Save.TabIndex = 0
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = False
        ' 
        ' Submit
        ' 
        Submit.Anchor = AnchorStyles.None
        Submit.BackColor = Color.LimeGreen
        Submit.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Submit.ForeColor = SystemColors.Control
        Submit.Location = New Point(714, 561)
        Submit.Name = "Submit"
        Submit.Size = New Size(168, 49)
        Submit.TabIndex = 1
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 39)
        Label1.TabIndex = 2
        Label1.Text = "Description :-"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 290)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 39)
        Label2.TabIndex = 3
        Label2.Text = "Reply :-"
        ' 
        ' response
        ' 
        response.Anchor = AnchorStyles.Left
        response.BorderStyle = BorderStyle.FixedSingle
        response.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        response.Location = New Point(91, 347)
        response.Multiline = True
        response.Name = "response"
        response.Size = New Size(825, 187)
        response.TabIndex = 4
        ' 
        ' description
        ' 
        description.BackColor = Color.Transparent
        description.BorderStyle = BorderStyle.FixedSingle
        description.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        description.Location = New Point(91, 102)
        description.Name = "description"
        description.Padding = New Padding(10)
        description.Size = New Size(825, 197)
        description.TabIndex = 5
        ' 
        ' Quer1
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1107, 760)
        Controls.Add(description)
        Controls.Add(response)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Submit)
        Controls.Add(Save)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Quer1"
        Text = "Quer1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Save As Button
    Friend WithEvents Submit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents response As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents description As Label
End Class
