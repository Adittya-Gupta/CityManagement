<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transport_busSearch
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
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Button3 = New Button()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        DateTimePicker1 = New DateTimePicker()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(852, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(253, 62)
        Button1.TabIndex = 0
        Button1.Text = "Main Page"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = world_map_homepage_e1619301116606_1
        PictureBox1.Location = New Point(2, 68)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1103, 689)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(302, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(463, 39)
        Label1.TabIndex = 3
        Label1.Text = "BOOK CHEAP BUS TICKETS WITH US"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Rajeev Chowk(B)", "Martin School(A)", "BT hospital(L)", "Public park(M)", "Main Market(J)", "Gym(K)", "RK plaza(I)", "Manipal University(C)", "BHK Mall(D)", "RH Chowraha(E)", "Government Office(N)", "Cricket Ground(O)", "Mk Hospital(P)", "General playground(Q)", "BH Bazar(G)", "Football ground(F)"})
        ComboBox1.Location = New Point(47, 287)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(234, 33)
        ComboBox1.TabIndex = 4
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Rajeev Chowk(B)", "Martin School(A)", "BT hospital(L)", "Public park(M)", "Main Market(J)", "Gym(K)", "RK plaza(I)", "Manipal University(C)", "BHK Mall(D)", "RH Chowraha(E)", "Government Office(N)", "Cricket Ground(O)", "Mk Hospital(P)", "General playground(Q)", "BH Bazar(G)", "Football ground(F)"})
        ComboBox2.Location = New Point(342, 287)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(224, 33)
        ComboBox2.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(47, 250)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 27)
        Label2.TabIndex = 6
        Label2.Text = "From:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(342, 257)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 27)
        Label3.TabIndex = 7
        Label3.Text = "To:"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Transparent
        Button3.Location = New Point(342, 366)
        Button3.Name = "Button3"
        Button3.Size = New Size(224, 56)
        Button3.TabIndex = 8
        Button3.Text = "Search"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(47, 341)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 27)
        Label4.TabIndex = 10
        Label4.Text = "Date"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = bus_homepage
        PictureBox2.Location = New Point(12, 188)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(368, 234)
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(47, 382)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(204, 33)
        DateTimePicker1.TabIndex = 13
        ' 
        ' transport_busSearch
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1107, 760)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        Name = "transport_busSearch"
        Text = "transport_busSearch"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
