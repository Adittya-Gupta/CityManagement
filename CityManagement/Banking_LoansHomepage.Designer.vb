<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Banking_LoanHomepage
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
        TextBox3 = New TextBox()
        HomeLoan_tb = New RichTextBox()
        Label3 = New Label()
        Label4 = New Label()
        EduLoan_tb = New RichTextBox()
        Label5 = New Label()
        BusinessLowRisk_tb = New RichTextBox()
        Label6 = New Label()
        TransportLoan_tb = New RichTextBox()
        Label7 = New Label()
        PersonalMedical_tb = New RichTextBox()
        BusinessHighRisk_tb = New RichTextBox()
        PersonalOtherwise_tb = New RichTextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Balance_tb = New RichTextBox()
        Label1 = New Label()
        Label2 = New Label()
        CIBILScore_tb = New RichTextBox()
        TableTitle = New TextBox()
        PayNow_btn = New Button()
        CurrentLoans_table = New DataGridView()
        Panel1 = New Panel()
        PendingRequests_btn = New Button()
        ApplyNow_btn = New Button()
        Button16 = New Button()
        CType(CurrentLoans_table, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(0), CByte(103), CByte(199))
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = Color.White
        TextBox3.Location = New Point(878, 12)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(220, 35)
        TextBox3.TabIndex = 23
        TextBox3.Text = "Interest rates today:"
        ' 
        ' HomeLoan_tb
        ' 
        HomeLoan_tb.BackColor = Color.White
        HomeLoan_tb.Font = New Font("Microsoft Sans Serif", 13.8F)
        HomeLoan_tb.Location = New Point(882, 74)
        HomeLoan_tb.Name = "HomeLoan_tb"
        HomeLoan_tb.ReadOnly = True
        HomeLoan_tb.Size = New Size(198, 44)
        HomeLoan_tb.TabIndex = 24
        HomeLoan_tb.Text = "6.75% p.a."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(878, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 25)
        Label3.TabIndex = 25
        Label3.Text = "Home Loans"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(880, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 25)
        Label4.TabIndex = 27
        Label4.Text = "Education Loans"
        ' 
        ' EduLoan_tb
        ' 
        EduLoan_tb.BackColor = Color.White
        EduLoan_tb.Font = New Font("Microsoft Sans Serif", 13.8F)
        EduLoan_tb.Location = New Point(882, 153)
        EduLoan_tb.Name = "EduLoan_tb"
        EduLoan_tb.ReadOnly = True
        EduLoan_tb.Size = New Size(198, 44)
        EduLoan_tb.TabIndex = 26
        EduLoan_tb.Text = "10% p.a."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(878, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 25)
        Label5.TabIndex = 29
        Label5.Text = "Business Loans"
        ' 
        ' BusinessLowRisk_tb
        ' 
        BusinessLowRisk_tb.BackColor = Color.White
        BusinessLowRisk_tb.Font = New Font("Microsoft Sans Serif", 13.8F)
        BusinessLowRisk_tb.Location = New Point(882, 259)
        BusinessLowRisk_tb.Name = "BusinessLowRisk_tb"
        BusinessLowRisk_tb.ReadOnly = True
        BusinessLowRisk_tb.Size = New Size(198, 44)
        BusinessLowRisk_tb.TabIndex = 28
        BusinessLowRisk_tb.Text = "11% p.a."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(878, 379)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 25)
        Label6.TabIndex = 31
        Label6.Text = "Transport Loans"
        ' 
        ' TransportLoan_tb
        ' 
        TransportLoan_tb.BackColor = Color.White
        TransportLoan_tb.Font = New Font("Microsoft Sans Serif", 13.8F)
        TransportLoan_tb.Location = New Point(882, 406)
        TransportLoan_tb.Name = "TransportLoan_tb"
        TransportLoan_tb.ReadOnly = True
        TransportLoan_tb.Size = New Size(198, 44)
        TransportLoan_tb.TabIndex = 30
        TransportLoan_tb.Text = "7% p.a."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(878, 453)
        Label7.Name = "Label7"
        Label7.Size = New Size(148, 25)
        Label7.TabIndex = 33
        Label7.Text = "Personal Loans"
        ' 
        ' PersonalMedical_tb
        ' 
        PersonalMedical_tb.BackColor = Color.White
        PersonalMedical_tb.Font = New Font("Microsoft Sans Serif", 13.8F)
        PersonalMedical_tb.Location = New Point(882, 501)
        PersonalMedical_tb.Name = "PersonalMedical_tb"
        PersonalMedical_tb.ReadOnly = True
        PersonalMedical_tb.Size = New Size(198, 44)
        PersonalMedical_tb.TabIndex = 32
        PersonalMedical_tb.Text = "10% p.a."
        ' 
        ' BusinessHighRisk_tb
        ' 
        BusinessHighRisk_tb.BackColor = Color.White
        BusinessHighRisk_tb.Font = New Font("Microsoft Sans Serif", 13.8F)
        BusinessHighRisk_tb.Location = New Point(882, 329)
        BusinessHighRisk_tb.Name = "BusinessHighRisk_tb"
        BusinessHighRisk_tb.ReadOnly = True
        BusinessHighRisk_tb.Size = New Size(198, 44)
        BusinessHighRisk_tb.TabIndex = 34
        BusinessHighRisk_tb.Text = "19.8% p.a."
        ' 
        ' PersonalOtherwise_tb
        ' 
        PersonalOtherwise_tb.BackColor = Color.White
        PersonalOtherwise_tb.Font = New Font("Microsoft Sans Serif", 13.8F)
        PersonalOtherwise_tb.Location = New Point(882, 567)
        PersonalOtherwise_tb.Name = "PersonalOtherwise_tb"
        PersonalOtherwise_tb.ReadOnly = True
        PersonalOtherwise_tb.Size = New Size(198, 44)
        PersonalOtherwise_tb.TabIndex = 35
        PersonalOtherwise_tb.Text = "17% p.a."
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(882, 240)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 20)
        Label8.TabIndex = 36
        Label8.Text = "Low Risk"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(884, 313)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 20)
        Label9.TabIndex = 37
        Label9.Text = "High Risk"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(882, 482)
        Label10.Name = "Label10"
        Label10.Size = New Size(62, 20)
        Label10.TabIndex = 38
        Label10.Text = "Medical"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(882, 548)
        Label11.Name = "Label11"
        Label11.Size = New Size(75, 20)
        Label11.TabIndex = 39
        Label11.Text = "Otherwise"
        ' 
        ' Balance_tb
        ' 
        Balance_tb.BackColor = Color.White
        Balance_tb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Balance_tb.Location = New Point(106, 17)
        Balance_tb.Name = "Balance_tb"
        Balance_tb.ReadOnly = True
        Balance_tb.Size = New Size(158, 35)
        Balance_tb.TabIndex = 19
        Balance_tb.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 25)
        Label1.TabIndex = 20
        Label1.Text = "Balance"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(297, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 25)
        Label2.TabIndex = 21
        Label2.Text = "CIBIL score"
        ' 
        ' CIBILScore_tb
        ' 
        CIBILScore_tb.BackColor = Color.White
        CIBILScore_tb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CIBILScore_tb.Location = New Point(430, 17)
        CIBILScore_tb.Name = "CIBILScore_tb"
        CIBILScore_tb.ReadOnly = True
        CIBILScore_tb.Size = New Size(158, 35)
        CIBILScore_tb.TabIndex = 40
        CIBILScore_tb.Text = ""
        ' 
        ' TableTitle
        ' 
        TableTitle.BackColor = Color.FromArgb(CByte(0), CByte(103), CByte(199))
        TableTitle.BorderStyle = BorderStyle.None
        TableTitle.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TableTitle.ForeColor = Color.White
        TableTitle.Location = New Point(22, 90)
        TableTitle.Multiline = True
        TableTitle.Name = "TableTitle"
        TableTitle.ReadOnly = True
        TableTitle.Size = New Size(209, 35)
        TableTitle.TabIndex = 41
        TableTitle.Text = "Current Loans:"
        ' 
        ' PayNow_btn
        ' 
        PayNow_btn.BackColor = Color.FromArgb(CByte(1), CByte(0), CByte(70))
        PayNow_btn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PayNow_btn.ForeColor = Color.White
        PayNow_btn.Location = New Point(645, 560)
        PayNow_btn.Name = "PayNow_btn"
        PayNow_btn.Size = New Size(119, 39)
        PayNow_btn.TabIndex = 42
        PayNow_btn.Text = "Pay Now"
        PayNow_btn.UseVisualStyleBackColor = False
        ' 
        ' CurrentLoans_table
        ' 
        CurrentLoans_table.AllowUserToAddRows = False
        CurrentLoans_table.AllowUserToDeleteRows = False
        CurrentLoans_table.BackgroundColor = Color.LightGray
        CurrentLoans_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CurrentLoans_table.Location = New Point(22, 142)
        CurrentLoans_table.Name = "CurrentLoans_table"
        CurrentLoans_table.ReadOnly = True
        CurrentLoans_table.RowHeadersWidth = 51
        CurrentLoans_table.RowTemplate.Height = 24
        CurrentLoans_table.Size = New Size(803, 402)
        CurrentLoans_table.TabIndex = 43
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(CIBILScore_tb)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Balance_tb)
        Panel1.Location = New Point(241, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(612, 71)
        Panel1.TabIndex = 44
        ' 
        ' PendingRequests_btn
        ' 
        PendingRequests_btn.BackColor = Color.FromArgb(CByte(1), CByte(0), CByte(70))
        PendingRequests_btn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PendingRequests_btn.ForeColor = Color.White
        PendingRequests_btn.Location = New Point(97, 560)
        PendingRequests_btn.Name = "PendingRequests_btn"
        PendingRequests_btn.Size = New Size(267, 39)
        PendingRequests_btn.TabIndex = 45
        PendingRequests_btn.Text = "View Pending Requests"
        PendingRequests_btn.UseVisualStyleBackColor = False
        ' 
        ' ApplyNow_btn
        ' 
        ApplyNow_btn.BackColor = Color.FromArgb(CByte(1), CByte(0), CByte(70))
        ApplyNow_btn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ApplyNow_btn.ForeColor = Color.White
        ApplyNow_btn.Location = New Point(446, 560)
        ApplyNow_btn.Name = "ApplyNow_btn"
        ApplyNow_btn.Size = New Size(137, 39)
        ApplyNow_btn.TabIndex = 47
        ApplyNow_btn.Text = "Apply Now"
        ApplyNow_btn.UseVisualStyleBackColor = False
        ' 
        ' Button16
        ' 
        Button16.BackColor = Color.Black
        Button16.Cursor = Cursors.Hand
        Button16.FlatAppearance.BorderSize = 0
        Button16.FlatStyle = FlatStyle.Flat
        Button16.Font = New Font("Bodoni MT", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.ForeColor = Color.White
        Button16.Location = New Point(29, 19)
        Button16.Margin = New Padding(0)
        Button16.Name = "Button16"
        Button16.Size = New Size(145, 53)
        Button16.TabIndex = 52
        Button16.Text = "REFRESH"
        Button16.UseVisualStyleBackColor = False
        ' 
        ' Banking_LoanHomepage
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1107, 641)
        ControlBox = False
        Controls.Add(Button16)
        Controls.Add(PayNow_btn)
        Controls.Add(ApplyNow_btn)
        Controls.Add(PendingRequests_btn)
        Controls.Add(Panel1)
        Controls.Add(CurrentLoans_table)
        Controls.Add(TableTitle)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(PersonalOtherwise_tb)
        Controls.Add(BusinessHighRisk_tb)
        Controls.Add(Label7)
        Controls.Add(PersonalMedical_tb)
        Controls.Add(Label6)
        Controls.Add(TransportLoan_tb)
        Controls.Add(Label5)
        Controls.Add(BusinessLowRisk_tb)
        Controls.Add(Label4)
        Controls.Add(EduLoan_tb)
        Controls.Add(Label3)
        Controls.Add(HomeLoan_tb)
        Controls.Add(TextBox3)
        FormBorderStyle = FormBorderStyle.None
        Name = "Banking_LoanHomepage"
        Text = "Loan Management"
        CType(CurrentLoans_table, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents HomeLoan_tb As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EduLoan_tb As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BusinessLowRisk_tb As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TransportLoan_tb As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PersonalMedical_tb As RichTextBox
    Friend WithEvents BusinessHighRisk_tb As RichTextBox
    Friend WithEvents PersonalOtherwise_tb As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Balance_tb As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CIBILScore_tb As RichTextBox
    Friend WithEvents TableTitle As TextBox
    Friend WithEvents PayNow_btn As Button
    Friend WithEvents CurrentLoans_table As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PendingRequests_btn As Button
    Friend WithEvents ApplyNow_btn As Button
    Friend WithEvents Button16 As Button
End Class
