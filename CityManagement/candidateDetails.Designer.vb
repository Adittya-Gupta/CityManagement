<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class candidateDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(candidateDetails))
        Name2 = New Label()
        CheckBox = New CheckBox()
        Agenda = New Label()
        OpenManifesto = New Label()
        profilePhoto = New PictureBox()
        CType(profilePhoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Name2
        ' 
        Name2.BackColor = Color.Black
        Name2.Font = New Font("Exo 2", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name2.ForeColor = Color.White
        Name2.Location = New Point(135, 49)
        Name2.Name = "Name2"
        Name2.Size = New Size(105, 26)
        Name2.TabIndex = 0
        ' 
        ' CheckBox
        ' 
        CheckBox.BackColor = Color.Black
        CheckBox.Location = New Point(210, 29)
        CheckBox.Name = "CheckBox"
        CheckBox.Size = New Size(30, 28)
        CheckBox.TabIndex = 1
        CheckBox.UseVisualStyleBackColor = False
        ' 
        ' Agenda
        ' 
        Agenda.BackColor = Color.White
        Agenda.Font = New Font("Exo 2", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Agenda.ForeColor = Color.Black
        Agenda.Location = New Point(293, 64)
        Agenda.Name = "Agenda"
        Agenda.Size = New Size(453, 58)
        Agenda.TabIndex = 2
        ' 
        ' OpenManifesto
        ' 
        OpenManifesto.BackColor = Color.Transparent
        OpenManifesto.Location = New Point(135, 75)
        OpenManifesto.Name = "OpenManifesto"
        OpenManifesto.Size = New Size(115, 37)
        OpenManifesto.TabIndex = 3
        ' 
        ' profilePhoto
        ' 
        profilePhoto.BackgroundImage = CType(resources.GetObject("profilePhoto.BackgroundImage"), Image)
        profilePhoto.BackgroundImageLayout = ImageLayout.Stretch
        profilePhoto.Location = New Point(20, 20)
        profilePhoto.Name = "profilePhoto"
        profilePhoto.Size = New Size(109, 111)
        profilePhoto.TabIndex = 4
        profilePhoto.TabStop = False
        ' 
        ' candidateDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        Controls.Add(profilePhoto)
        Controls.Add(OpenManifesto)
        Controls.Add(Agenda)
        Controls.Add(CheckBox)
        Controls.Add(Name2)
        DoubleBuffered = True
        ForeColor = Color.White
        Name = "candidateDetails"
        Size = New Size(755, 152)
        CType(profilePhoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Name2 As Label
    Friend WithEvents CheckBox As CheckBox
    Friend WithEvents Agenda As Label
    Friend WithEvents OpenManifesto As Label
    Friend WithEvents profilePhoto As PictureBox

End Class
