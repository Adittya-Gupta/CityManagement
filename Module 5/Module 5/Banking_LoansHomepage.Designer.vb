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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.HomeLoan_tb = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EduLoan_tb = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BusinessLowRisk_tb = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TransportLoan_tb = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PersonalMedical_tb = New System.Windows.Forms.RichTextBox()
        Me.BusinessHighRisk_tb = New System.Windows.Forms.RichTextBox()
        Me.PersonalOtherwise_tb = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Balance_tb = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CIBILScore_tb = New System.Windows.Forms.RichTextBox()
        Me.TableTitle = New System.Windows.Forms.TextBox()
        Me.PayNow_btn = New System.Windows.Forms.Button()
        Me.CurrentLoans_table = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PendingRequests_btn = New System.Windows.Forms.Button()
        Me.ApplyNow_btn = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        CType(Me.CurrentLoans_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(878, 12)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(220, 35)
        Me.TextBox3.TabIndex = 23
        Me.TextBox3.Text = "Interest rates today:"
        '
        'HomeLoan_tb
        '
        Me.HomeLoan_tb.BackColor = System.Drawing.Color.White
        Me.HomeLoan_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.HomeLoan_tb.Location = New System.Drawing.Point(887, 86)
        Me.HomeLoan_tb.Name = "HomeLoan_tb"
        Me.HomeLoan_tb.ReadOnly = True
        Me.HomeLoan_tb.Size = New System.Drawing.Size(198, 44)
        Me.HomeLoan_tb.TabIndex = 24
        Me.HomeLoan_tb.Text = "6.75% p.a."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(883, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Home Loans"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(885, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 25)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Education Loans"
        '
        'EduLoan_tb
        '
        Me.EduLoan_tb.BackColor = System.Drawing.Color.White
        Me.EduLoan_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.EduLoan_tb.Location = New System.Drawing.Point(887, 165)
        Me.EduLoan_tb.Name = "EduLoan_tb"
        Me.EduLoan_tb.ReadOnly = True
        Me.EduLoan_tb.Size = New System.Drawing.Size(198, 44)
        Me.EduLoan_tb.TabIndex = 26
        Me.EduLoan_tb.Text = "10% p.a."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(883, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 25)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Business Loans"
        '
        'BusinessLowRisk_tb
        '
        Me.BusinessLowRisk_tb.BackColor = System.Drawing.Color.White
        Me.BusinessLowRisk_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.BusinessLowRisk_tb.Location = New System.Drawing.Point(887, 271)
        Me.BusinessLowRisk_tb.Name = "BusinessLowRisk_tb"
        Me.BusinessLowRisk_tb.ReadOnly = True
        Me.BusinessLowRisk_tb.Size = New System.Drawing.Size(198, 44)
        Me.BusinessLowRisk_tb.TabIndex = 28
        Me.BusinessLowRisk_tb.Text = "11% p.a."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(883, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 25)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Transport Loans"
        '
        'TransportLoan_tb
        '
        Me.TransportLoan_tb.BackColor = System.Drawing.Color.White
        Me.TransportLoan_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.TransportLoan_tb.Location = New System.Drawing.Point(887, 418)
        Me.TransportLoan_tb.Name = "TransportLoan_tb"
        Me.TransportLoan_tb.ReadOnly = True
        Me.TransportLoan_tb.Size = New System.Drawing.Size(198, 44)
        Me.TransportLoan_tb.TabIndex = 30
        Me.TransportLoan_tb.Text = "7% p.a."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(883, 465)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 25)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Personal Loans"
        '
        'PersonalMedical_tb
        '
        Me.PersonalMedical_tb.BackColor = System.Drawing.Color.White
        Me.PersonalMedical_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.PersonalMedical_tb.Location = New System.Drawing.Point(887, 513)
        Me.PersonalMedical_tb.Name = "PersonalMedical_tb"
        Me.PersonalMedical_tb.ReadOnly = True
        Me.PersonalMedical_tb.Size = New System.Drawing.Size(198, 44)
        Me.PersonalMedical_tb.TabIndex = 32
        Me.PersonalMedical_tb.Text = "10% p.a."
        '
        'BusinessHighRisk_tb
        '
        Me.BusinessHighRisk_tb.BackColor = System.Drawing.Color.White
        Me.BusinessHighRisk_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.BusinessHighRisk_tb.Location = New System.Drawing.Point(887, 341)
        Me.BusinessHighRisk_tb.Name = "BusinessHighRisk_tb"
        Me.BusinessHighRisk_tb.ReadOnly = True
        Me.BusinessHighRisk_tb.Size = New System.Drawing.Size(198, 44)
        Me.BusinessHighRisk_tb.TabIndex = 34
        Me.BusinessHighRisk_tb.Text = "19.8% p.a."
        '
        'PersonalOtherwise_tb
        '
        Me.PersonalOtherwise_tb.BackColor = System.Drawing.Color.White
        Me.PersonalOtherwise_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.PersonalOtherwise_tb.Location = New System.Drawing.Point(887, 579)
        Me.PersonalOtherwise_tb.Name = "PersonalOtherwise_tb"
        Me.PersonalOtherwise_tb.ReadOnly = True
        Me.PersonalOtherwise_tb.Size = New System.Drawing.Size(198, 44)
        Me.PersonalOtherwise_tb.TabIndex = 35
        Me.PersonalOtherwise_tb.Text = "17% p.a."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(887, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Low Risk"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(889, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "High Risk"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(887, 494)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Medical"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(887, 560)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 16)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Otherwise"
        '
        'Balance_tb
        '
        Me.Balance_tb.BackColor = System.Drawing.Color.White
        Me.Balance_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Balance_tb.Location = New System.Drawing.Point(106, 17)
        Me.Balance_tb.Name = "Balance_tb"
        Me.Balance_tb.ReadOnly = True
        Me.Balance_tb.Size = New System.Drawing.Size(158, 35)
        Me.Balance_tb.TabIndex = 19
        Me.Balance_tb.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Balance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "CIBIL score"
        '
        'CIBILScore_tb
        '
        Me.CIBILScore_tb.BackColor = System.Drawing.Color.White
        Me.CIBILScore_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CIBILScore_tb.Location = New System.Drawing.Point(430, 17)
        Me.CIBILScore_tb.Name = "CIBILScore_tb"
        Me.CIBILScore_tb.ReadOnly = True
        Me.CIBILScore_tb.Size = New System.Drawing.Size(158, 35)
        Me.CIBILScore_tb.TabIndex = 40
        Me.CIBILScore_tb.Text = ""
        '
        'TableTitle
        '
        Me.TableTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TableTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableTitle.ForeColor = System.Drawing.Color.White
        Me.TableTitle.Location = New System.Drawing.Point(22, 90)
        Me.TableTitle.Multiline = True
        Me.TableTitle.Name = "TableTitle"
        Me.TableTitle.ReadOnly = True
        Me.TableTitle.Size = New System.Drawing.Size(209, 35)
        Me.TableTitle.TabIndex = 41
        Me.TableTitle.Text = "Current Loans:"
        '
        'PayNow_btn
        '
        Me.PayNow_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PayNow_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayNow_btn.ForeColor = System.Drawing.Color.White
        Me.PayNow_btn.Location = New System.Drawing.Point(577, 590)
        Me.PayNow_btn.Name = "PayNow_btn"
        Me.PayNow_btn.Size = New System.Drawing.Size(119, 39)
        Me.PayNow_btn.TabIndex = 42
        Me.PayNow_btn.Text = "Pay Now"
        Me.PayNow_btn.UseVisualStyleBackColor = False
        '
        'CurrentLoans_table
        '
        Me.CurrentLoans_table.AllowUserToAddRows = False
        Me.CurrentLoans_table.AllowUserToDeleteRows = False
        Me.CurrentLoans_table.BackgroundColor = System.Drawing.Color.LightGray
        Me.CurrentLoans_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CurrentLoans_table.Location = New System.Drawing.Point(22, 142)
        Me.CurrentLoans_table.Name = "CurrentLoans_table"
        Me.CurrentLoans_table.ReadOnly = True
        Me.CurrentLoans_table.RowHeadersWidth = 51
        Me.CurrentLoans_table.RowTemplate.Height = 24
        Me.CurrentLoans_table.Size = New System.Drawing.Size(803, 430)
        Me.CurrentLoans_table.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CIBILScore_tb)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Balance_tb)
        Me.Panel1.Location = New System.Drawing.Point(241, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(612, 71)
        Me.Panel1.TabIndex = 44
        '
        'PendingRequests_btn
        '
        Me.PendingRequests_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PendingRequests_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PendingRequests_btn.ForeColor = System.Drawing.Color.White
        Me.PendingRequests_btn.Location = New System.Drawing.Point(29, 590)
        Me.PendingRequests_btn.Name = "PendingRequests_btn"
        Me.PendingRequests_btn.Size = New System.Drawing.Size(267, 39)
        Me.PendingRequests_btn.TabIndex = 45
        Me.PendingRequests_btn.Text = "View Pending Requests"
        Me.PendingRequests_btn.UseVisualStyleBackColor = False
        '
        'ApplyNow_btn
        '
        Me.ApplyNow_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ApplyNow_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplyNow_btn.ForeColor = System.Drawing.Color.White
        Me.ApplyNow_btn.Location = New System.Drawing.Point(378, 590)
        Me.ApplyNow_btn.Name = "ApplyNow_btn"
        Me.ApplyNow_btn.Size = New System.Drawing.Size(137, 39)
        Me.ApplyNow_btn.TabIndex = 47
        Me.ApplyNow_btn.Text = "Apply Now"
        Me.ApplyNow_btn.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Black
        Me.Button16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.White
        Me.Button16.Location = New System.Drawing.Point(29, 19)
        Me.Button16.Margin = New System.Windows.Forms.Padding(0)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(145, 53)
        Me.Button16.TabIndex = 52
        Me.Button16.Text = "REFRESH"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Banking_LoanHomepage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1107, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.PayNow_btn)
        Me.Controls.Add(Me.ApplyNow_btn)
        Me.Controls.Add(Me.PendingRequests_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CurrentLoans_table)
        Me.Controls.Add(Me.TableTitle)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PersonalOtherwise_tb)
        Me.Controls.Add(Me.BusinessHighRisk_tb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PersonalMedical_tb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TransportLoan_tb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BusinessLowRisk_tb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EduLoan_tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HomeLoan_tb)
        Me.Controls.Add(Me.TextBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Banking_LoanHomepage"
        Me.Text = "Loan Management"
        CType(Me.CurrentLoans_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
