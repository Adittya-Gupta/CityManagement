<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transport_cabbooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transport_cabbooking))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(111, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1171, 592)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1165, 561)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLightLight
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(100, 80)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(397, 83)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(153, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(76, 83)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlLightLight
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(100, 186)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(397, 350)
        Panel3.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(76, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 41)
        Label1.TabIndex = 0
        Label1.Text = "Request a Ride"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Silver
        TextBox1.Font = New Font("Segoe UI Variable Display Light", 13F)
        TextBox1.Location = New Point(65, 96)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(277, 36)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Enter Pickup location"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Silver
        TextBox2.Font = New Font("Segoe UI Variable Display Light", 13F)
        TextBox2.Location = New Point(65, 147)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(277, 36)
        TextBox2.TabIndex = 2
        TextBox2.Text = "Enter Destination"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(65, 211)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 38)
        Button1.TabIndex = 3
        Button1.Text = "Request Now" & vbCrLf
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Silver
        Button2.Location = New Point(187, 211)
        Button2.Name = "Button2"
        Button2.Size = New Size(155, 38)
        Button2.TabIndex = 4
        Button2.Text = "Schedule for Later" & vbCrLf
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaptionText
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(1053, 7)
        Button3.Name = "Button3"
        Button3.Size = New Size(110, 45)
        Button3.TabIndex = 4
        Button3.Text = "My Activity" & vbCrLf
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveCaptionText
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(1169, 7)
        Button4.Name = "Button4"
        Button4.Size = New Size(110, 45)
        Button4.TabIndex = 5
        Button4.Text = "Look for Bus" & vbCrLf
        Button4.UseVisualStyleBackColor = False
        ' 
        ' transport_cabbooking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 689)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Name = "transport_cabbooking"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
