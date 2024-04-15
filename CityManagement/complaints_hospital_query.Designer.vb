<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class complaints_hospital_query
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(complaints_hospital_query))
        RichTextBox1 = New RichTextBox()
        Panel1 = New Panel()
        CheckedListBox1 = New CheckedListBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(521, 292)
        RichTextBox1.Margin = New Padding(3, 4, 3, 4)
        RichTextBox1.MaxLength = 300
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(541, 206)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = ""
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.White
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(CheckedListBox1)
        Panel1.Location = New Point(81, 72)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(348, 416)
        Panel1.TabIndex = 3
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.CheckOnClick = True
        CheckedListBox1.Dock = DockStyle.Fill
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(0, 0)
        CheckedListBox1.Margin = New Padding(3, 4, 3, 4)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(348, 416)
        CheckedListBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 20)
        Label2.TabIndex = 8
        Label2.Text = "Complaint Portal  >"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(187, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 7
        Label1.Text = "Hospital  >"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Book Antiqua", 11.25F, FontStyle.Bold)
        Label3.Location = New Point(293, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 19)
        Label3.TabIndex = 9
        Label3.Text = "Hospital_name"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Bell MT", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(717, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 46)
        Button1.TabIndex = 10
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Location = New Point(546, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(497, 218)
        Panel2.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(521, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(179, 23)
        Label4.TabIndex = 12
        Label4.Text = "Describe the issue :"
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(Button1)
        Panel3.Location = New Point(0, 505)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1107, 255)
        Panel3.TabIndex = 20
        ' 
        ' complaints_hospital_query
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1107, 760)
        Controls.Add(Panel3)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(RichTextBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "complaints_hospital_query"
        Text = "compl_hospital_query"
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
End Class
