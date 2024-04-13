<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeScreen))
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Centauri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(14, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(719, 34)
        Label1.TabIndex = 0
        Label1.Text = "City Management System"
        Label1.UseCompatibleTextRendering = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Exo 2", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(14, 104)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(170, 40)
        Button1.TabIndex = 1
        Button1.Text = "Get Started >"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Exo 2", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(481, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(397, 25)
        Label2.TabIndex = 2
        Label2.Text = "- The best way to predict the future is to invent it. "
        ' 
        ' WelcomeScreen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1114, 853)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "WelcomeScreen"
        Text = "Welcome"
        TransparencyKey = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label

End Class
