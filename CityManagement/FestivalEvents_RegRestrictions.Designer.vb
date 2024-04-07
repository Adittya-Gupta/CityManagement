<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FestivalEvents_RegRestrictions
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
        Label3 = New Label()
        GroupBoxAgeRestrictions = New GroupBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        LabelMaxAge = New Label()
        LabelMinAge = New Label()
        TrackBarMaxAge = New TrackBar()
        TrackBarMinAge = New TrackBar()
        LabelMaxAgeValue = New Label()
        LabelMinAgeValue = New Label()
        Label1 = New Label()
        TextBoxMaxParticipants = New TextBox()
        ButtonSave = New Button()
        ButtonBack = New Button()
        CheckBoxApplyMaxParticipants = New CheckBox()
        Panel1 = New Panel()
        GroupBoxAgeRestrictions.SuspendLayout()
        CType(TrackBarMaxAge, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBarMinAge, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(329, 37)
        Label3.TabIndex = 32
        Label3.Text = "Event Registration Rules"
        ' 
        ' GroupBoxAgeRestrictions
        ' 
        GroupBoxAgeRestrictions.Controls.Add(CheckBox2)
        GroupBoxAgeRestrictions.Controls.Add(CheckBox1)
        GroupBoxAgeRestrictions.Controls.Add(LabelMaxAge)
        GroupBoxAgeRestrictions.Controls.Add(LabelMinAge)
        GroupBoxAgeRestrictions.Controls.Add(TrackBarMaxAge)
        GroupBoxAgeRestrictions.Controls.Add(TrackBarMinAge)
        GroupBoxAgeRestrictions.Controls.Add(LabelMaxAgeValue)
        GroupBoxAgeRestrictions.Controls.Add(LabelMinAgeValue)
        GroupBoxAgeRestrictions.Font = New Font("Segoe UI", 10F)
        GroupBoxAgeRestrictions.Location = New Point(36, 99)
        GroupBoxAgeRestrictions.Name = "GroupBoxAgeRestrictions"
        GroupBoxAgeRestrictions.Size = New Size(628, 186)
        GroupBoxAgeRestrictions.TabIndex = 33
        GroupBoxAgeRestrictions.TabStop = False
        GroupBoxAgeRestrictions.Text = "Age Restrictions"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 10F)
        CheckBox2.Location = New Point(395, 28)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(143, 27)
        CheckBox2.TabIndex = 42
        CheckBox2.Text = "Maximum Age"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 10F)
        CheckBox1.Location = New Point(24, 28)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(140, 27)
        CheckBox1.TabIndex = 41
        CheckBox1.Text = "Minimum Age"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' LabelMaxAge
        ' 
        LabelMaxAge.AutoSize = True
        LabelMaxAge.Location = New Point(436, 136)
        LabelMaxAge.Name = "LabelMaxAge"
        LabelMaxAge.Size = New Size(81, 23)
        LabelMaxAge.TabIndex = 5
        LabelMaxAge.Text = "Max Age:"
        ' 
        ' LabelMinAge
        ' 
        LabelMinAge.AutoSize = True
        LabelMinAge.Location = New Point(24, 136)
        LabelMinAge.Name = "LabelMinAge"
        LabelMinAge.Size = New Size(78, 23)
        LabelMinAge.TabIndex = 4
        LabelMinAge.Text = "Min Age:"
        ' 
        ' TrackBarMaxAge
        ' 
        TrackBarMaxAge.Location = New Point(395, 61)
        TrackBarMaxAge.Maximum = 120
        TrackBarMaxAge.Name = "TrackBarMaxAge"
        TrackBarMaxAge.Size = New Size(200, 56)
        TrackBarMaxAge.TabIndex = 3
        TrackBarMaxAge.TickFrequency = 10
        ' 
        ' TrackBarMinAge
        ' 
        TrackBarMinAge.Location = New Point(24, 61)
        TrackBarMinAge.Maximum = 120
        TrackBarMinAge.Name = "TrackBarMinAge"
        TrackBarMinAge.Size = New Size(200, 56)
        TrackBarMinAge.TabIndex = 2
        TrackBarMinAge.TickFrequency = 10
        ' 
        ' LabelMaxAgeValue
        ' 
        LabelMaxAgeValue.AutoSize = True
        LabelMaxAgeValue.Location = New Point(534, 136)
        LabelMaxAgeValue.Name = "LabelMaxAgeValue"
        LabelMaxAgeValue.Size = New Size(19, 23)
        LabelMaxAgeValue.TabIndex = 1
        LabelMaxAgeValue.Text = "0"
        ' 
        ' LabelMinAgeValue
        ' 
        LabelMinAgeValue.AutoSize = True
        LabelMinAgeValue.Location = New Point(176, 136)
        LabelMinAgeValue.Name = "LabelMinAgeValue"
        LabelMinAgeValue.Size = New Size(19, 23)
        LabelMinAgeValue.TabIndex = 0
        LabelMinAgeValue.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(239, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 23)
        Label1.TabIndex = 34
        Label1.Text = "Maximum Participants:"
        ' 
        ' TextBoxMaxParticipants
        ' 
        TextBoxMaxParticipants.Font = New Font("Segoe UI", 10F)
        TextBoxMaxParticipants.Location = New Point(455, 28)
        TextBoxMaxParticipants.Name = "TextBoxMaxParticipants"
        TextBoxMaxParticipants.Size = New Size(100, 30)
        TextBoxMaxParticipants.TabIndex = 35
        ' 
        ' ButtonSave
        ' 
        ButtonSave.BackColor = Color.Black
        ButtonSave.FlatAppearance.BorderSize = 0
        ButtonSave.FlatStyle = FlatStyle.Flat
        ButtonSave.Font = New Font("Segoe UI", 10F)
        ButtonSave.ForeColor = Color.White
        ButtonSave.Location = New Point(30, 406)
        ButtonSave.Name = "ButtonSave"
        ButtonSave.Size = New Size(100, 40)
        ButtonSave.TabIndex = 36
        ButtonSave.Text = "Save"
        ButtonSave.UseVisualStyleBackColor = False
        ' 
        ' ButtonBack
        ' 
        ButtonBack.BackColor = Color.Black
        ButtonBack.FlatAppearance.BorderSize = 0
        ButtonBack.FlatStyle = FlatStyle.Flat
        ButtonBack.Font = New Font("Segoe UI", 10F)
        ButtonBack.ForeColor = Color.White
        ButtonBack.Location = New Point(187, 406)
        ButtonBack.Name = "ButtonBack"
        ButtonBack.Size = New Size(100, 40)
        ButtonBack.TabIndex = 37
        ButtonBack.Text = "Back"
        ButtonBack.UseVisualStyleBackColor = False
        ' 
        ' CheckBoxApplyMaxParticipants
        ' 
        CheckBoxApplyMaxParticipants.AutoSize = True
        CheckBoxApplyMaxParticipants.Font = New Font("Segoe UI", 10F)
        CheckBoxApplyMaxParticipants.Location = New Point(43, 31)
        CheckBoxApplyMaxParticipants.Name = "CheckBoxApplyMaxParticipants"
        CheckBoxApplyMaxParticipants.Size = New Size(157, 27)
        CheckBoxApplyMaxParticipants.TabIndex = 40
        CheckBoxApplyMaxParticipants.Text = "Max Participants"
        CheckBoxApplyMaxParticipants.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(GroupBoxAgeRestrictions)
        Panel1.Controls.Add(CheckBoxApplyMaxParticipants)
        Panel1.Controls.Add(TextBoxMaxParticipants)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 64)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(742, 315)
        Panel1.TabIndex = 41
        ' 
        ' FestivalEvents_RegRestrictions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(797, 469)
        Controls.Add(ButtonBack)
        Controls.Add(ButtonSave)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Name = "FestivalEvents_RegRestrictions"
        Text = "Festival Events Registration Restrictions"
        GroupBoxAgeRestrictions.ResumeLayout(False)
        GroupBoxAgeRestrictions.PerformLayout()
        CType(TrackBarMaxAge, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBarMinAge, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBoxAgeRestrictions As GroupBox
    Friend WithEvents TrackBarMaxAge As TrackBar
    Friend WithEvents TrackBarMinAge As TrackBar
    Friend WithEvents LabelMaxAgeValue As Label
    Friend WithEvents LabelMinAgeValue As Label
    Friend WithEvents LabelMaxAge As Label
    Friend WithEvents LabelMinAge As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxMaxParticipants As TextBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonBack As Button
    'Friend WithEvents CheckBoxApplyMinAge As CheckBox
    'Friend WithEvents CheckBoxApplyMaxAge As CheckBox
    Friend WithEvents CheckBoxApplyMaxParticipants As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
