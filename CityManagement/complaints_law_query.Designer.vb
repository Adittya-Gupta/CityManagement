<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class complaints_law_query
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(complaints_law_query))
        Panel3 = New Panel()
        Button1 = New Button()
        RichTextBox1 = New RichTextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Location = New Point(0, 673)
        Panel3.Margin = New Padding(3, 5, 3, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1265, 340)
        Panel3.TabIndex = 36
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Bell MT", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(835, 445)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 61)
        Button1.TabIndex = 10
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(607, 115)
        RichTextBox1.Margin = New Padding(3, 5, 3, 5)
        RichTextBox1.MaxLength = 300
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(618, 273)
        RichTextBox1.TabIndex = 29
        RichTextBox1.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Book Antiqua", 11.25F, FontStyle.Bold)
        Label3.Location = New Point(347, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 19)
        Label3.TabIndex = 33
        Label3.Text = "Police_station_name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 20)
        Label2.TabIndex = 32
        Label2.Text = "Complaint Portal  >"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(213, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 31
        Label1.Text = "Law  >"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(607, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(179, 23)
        Label4.TabIndex = 35
        Label4.Text = "Describe the issue :"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Location = New Point(14, 115)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(568, 291)
        Panel2.TabIndex = 34
        ' 
        ' complaints_law_query
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1265, 788)
        Controls.Add(Button1)
        Controls.Add(Panel3)
        Controls.Add(RichTextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "complaints_law_query"
        Text = "complaints_law_query"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
End Class
