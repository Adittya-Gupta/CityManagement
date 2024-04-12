<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Newsletter_articlespage
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Home_btn = New System.Windows.Forms.Button()
        Me.Promotions_btn = New System.Windows.Forms.Button()
        Me.Festivals_btn = New System.Windows.Forms.Button()
        Me.EduHealth_btn = New System.Windows.Forms.Button()
        Me.Employment_btn = New System.Windows.Forms.Button()
        Me.Transport_btn = New System.Windows.Forms.Button()
        Me.Display_panel = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Home_btn)
        Me.Panel2.Controls.Add(Me.Promotions_btn)
        Me.Panel2.Controls.Add(Me.Festivals_btn)
        Me.Panel2.Controls.Add(Me.EduHealth_btn)
        Me.Panel2.Controls.Add(Me.Employment_btn)
        Me.Panel2.Controls.Add(Me.Transport_btn)
        Me.Panel2.Location = New System.Drawing.Point(12, 586)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1081, 54)
        Me.Panel2.TabIndex = 5
        '
        'Home_btn
        '
        Me.Home_btn.BackColor = System.Drawing.Color.DarkKhaki
        Me.Home_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Home_btn.Location = New System.Drawing.Point(-2, -2)
        Me.Home_btn.Name = "Home_btn"
        Me.Home_btn.Size = New System.Drawing.Size(132, 54)
        Me.Home_btn.TabIndex = 0
        Me.Home_btn.Text = "Home"
        Me.Home_btn.UseVisualStyleBackColor = False
        '
        'Promotions_btn
        '
        Me.Promotions_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Promotions_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Promotions_btn.Location = New System.Drawing.Point(896, -2)
        Me.Promotions_btn.Name = "Promotions_btn"
        Me.Promotions_btn.Size = New System.Drawing.Size(181, 54)
        Me.Promotions_btn.TabIndex = 5
        Me.Promotions_btn.Text = "Promotions, Advertisements"
        Me.Promotions_btn.UseVisualStyleBackColor = False
        '
        'Festivals_btn
        '
        Me.Festivals_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Festivals_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Festivals_btn.Location = New System.Drawing.Point(127, -2)
        Me.Festivals_btn.Name = "Festivals_btn"
        Me.Festivals_btn.Size = New System.Drawing.Size(168, 54)
        Me.Festivals_btn.TabIndex = 4
        Me.Festivals_btn.Text = "Festivals, Events," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Election"
        Me.Festivals_btn.UseVisualStyleBackColor = False
        '
        'EduHealth_btn
        '
        Me.EduHealth_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.EduHealth_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EduHealth_btn.Location = New System.Drawing.Point(292, -2)
        Me.EduHealth_btn.Name = "EduHealth_btn"
        Me.EduHealth_btn.Size = New System.Drawing.Size(199, 54)
        Me.EduHealth_btn.TabIndex = 3
        Me.EduHealth_btn.Text = "Education, Healthcare"
        Me.EduHealth_btn.UseVisualStyleBackColor = False
        '
        'Employment_btn
        '
        Me.Employment_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Employment_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employment_btn.Location = New System.Drawing.Point(702, -2)
        Me.Employment_btn.Name = "Employment_btn"
        Me.Employment_btn.Size = New System.Drawing.Size(197, 54)
        Me.Employment_btn.TabIndex = 2
        Me.Employment_btn.Text = "Employment, Services"
        Me.Employment_btn.UseVisualStyleBackColor = False
        '
        'Transport_btn
        '
        Me.Transport_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Transport_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transport_btn.Location = New System.Drawing.Point(487, -2)
        Me.Transport_btn.Name = "Transport_btn"
        Me.Transport_btn.Size = New System.Drawing.Size(219, 54)
        Me.Transport_btn.TabIndex = 1
        Me.Transport_btn.Text = "Transport, Communication"
        Me.Transport_btn.UseVisualStyleBackColor = False
        '
        'Display_panel
        '
        Me.Display_panel.AutoScroll = True
        Me.Display_panel.Location = New System.Drawing.Point(12, 12)
        Me.Display_panel.Name = "Display_panel"
        Me.Display_panel.Size = New System.Drawing.Size(1083, 568)
        Me.Display_panel.TabIndex = 6
        '
        'Newsletter_articlespage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1107, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Display_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Newsletter_articlespage"
        Me.Text = "Newsletter_articlespage"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Home_btn As Button
    Friend WithEvents Promotions_btn As Button
    Friend WithEvents Festivals_btn As Button
    Friend WithEvents EduHealth_btn As Button
    Friend WithEvents Employment_btn As Button
    Friend WithEvents Transport_btn As Button
    Friend WithEvents Display_panel As Panel
End Class
