﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewNominees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewNominees))
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(206, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 57)
        Label1.TabIndex = 0
        Label1.Text = "Select Ministry"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Black
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.ForeColor = SystemColors.InactiveBorder
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Education", "Health", "Transport", "Finance", "Home"})
        ComboBox1.Location = New Point(458, 89)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(548, 49)
        ComboBox1.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(111, 185)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(975, 574)
        Panel1.TabIndex = 2
        ' 
        ' viewNominees
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1236, 979)
        Controls.Add(Panel1)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        DoubleBuffered = True
        ForeColor = SystemColors.ButtonHighlight
        Name = "viewNominees"
        Text = "viewNominees"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
