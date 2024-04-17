Imports MySql.Data.MySqlClient
Imports System.IO
Public Class elections_nomination
    Dim idOfCurrentUser As Integer = Module1.CurrUserSID
    'Input to the form is SID
    'Public Sub New(ByVal userInput As Integer)
    '   InitializeComponent()
    '   Me.idOfCurrentUser = userInput
    'End Sub
    'Teacher,EdOwner,EducationMinister,Doctor,HpOwner,HealthMinister,Driver
    Dim Designation As String = "Education Minister"
    Dim mapping As New Dictionary(Of String, String)()
    Dim uploaded As Boolean = False
    Dim fileContent As Byte()
    Dim AgendaText As String = ""
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Private Sub fillMapping()
        mapping("Teacher") = "Education Minister"
        mapping("Education Minister") = "Education Minister"
        mapping("Doctor") = "Health Minister"
        mapping("Health Minister") = "Health Minister"
        mapping("Driver") = "Transport Minister"
        mapping("Transport Minister") = "Transport Minister"
        mapping("Employee") = "Finance Minister"
        mapping("Police") = "Home Minister"
        mapping("Home Minister") = "Home Minister"
        mapping("Finance Minister") = "Finance Minister"
        mapping("Hospital Owner") = "Health Minister"
        Dim Type As String = ""
        Try
            conn.Open()
            Dim query As String = "select Type from Institutes where Owner_ID=@a"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@a", idOfCurrentUser)
                Dim reader = cmd.ExecuteReader
                If reader.Read() Then
                    Type = Convert.ToString(reader("Type"))
                End If
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
        If Not (Type = "") Then
            Select Case Type
                Case "Education"
                    mapping("Owner") = "Education Minister"
                Case "Law"
                    mapping("Owner") = "Home Minister"
                Case "Hospital"
                    mapping("Owner") = "Health Minister"
                Case "Transport"
                    mapping("Owner") = "Transport Minister"
                Case "Finance"
                    mapping("Owner") = "Finance Minister"
            End Select
        End If
    End Sub
    Private Sub nomination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillMapping()
        'PayDeposit.FlatStyle = FlatStyle.Flat
        'PayDeposit.FlatAppearance.BorderSize = 0
        'PayDeposit.BackColor = System.Drawing.ColorTranslator.FromHtml("#0cb43b")
        Agenda.BorderStyle = BorderStyle.None
        Agenda.BackColor = System.Drawing.ColorTranslator.FromHtml("#111f44")
        Agenda.ForeColor = System.Drawing.ColorTranslator.FromHtml("#d5bd6e")
        Minister.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff")
        Minister.ForeColor = System.Drawing.ColorTranslator.FromHtml("#612828")
        'To find the designation and correspondingly assign the labels text to that minister
        'For this we need mapping to what a person can contest to
        Try
            conn.Open()
            Dim query As String = "select Designation from User where SID=@a"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@a", idOfCurrentUser)
                Dim reader = cmd.ExecuteReader
                reader.Read()
                Designation = mapping(Convert.ToString(reader("Designation")))
                Minister.Text = "You are nominating for " & Designation
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try

    End Sub
    'Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
    '    parentpanel.Controls.Clear()
    '    childform.TopLevel = False
    '    childform.FormBorderStyle = FormBorderStyle.None
    '    childform.Dock = DockStyle.Fill
    '    childform.BringToFront()
    '    parentpanel.Controls.Add(childform)
    '    childform.Show()
    'End Sub

    'Public Shared Sub ChildForm2(ByVal childform As Form)
    '    mypanel.panel1.Controls.Clear()
    '    childform.TopLevel = False
    '    mypanel.panel1.Controls.Add(childform)
    '    childform.Show()
    'End Sub
    Private Sub PayDeposit_Click(sender As Object, e As EventArgs) Handles PayDeposit.Click
        Try
            conn.Open()
            'To check if the nominee already present in the table
            Dim query As String = "select SID from Nominees where SID=?"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("?", idOfCurrentUser)
                Dim reader = cmd.ExecuteReader
                If reader.Read Then
                    MessageBox.Show("You have already entered your agenda and manifesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Dim form As New election_dashboard()
                    mypanel.panel1.Controls.Clear()
                    form.TopLevel = False
                    mypanel.panel1.Controls.Add(form)
                    form.Show()
                    Exit Sub
                Else
                End If
            End Using
            'MessageBox.Show("Checked for duplicate entry in Nominees table successfully")
        Catch ex As Exception

        Finally
            conn.Close()
        End Try


        'Link banking database and banking forms for further process here
        Dim paidDeposit = False
        'Dim form As New Banking_Money_Management_Homepage()
        'mypanel.Panel1.Controls.Clear()
        'form.TopLevel = False
        'mypanel.Panel1.Controls.Add(form)
        'form.Show()
        'banking_recv_username = "mayor"
        'Go_Back = 2
        'Go_Back_Form = election_dashboard
        'banking_payment_amount = 100

        'Banking_Main.Panel1.Controls.Clear()
        'Newsletter_Main.Panel1.Controls.Clear()

        'ChildForm(Banking_Main.Panel1, Banking_Homepage)
        'mypanel.panel1.Controls.Clear()
        'ChildForm2(Banking_Main)
        'To check if the current user has bank account
        Dim currentUserBankAccountNumber As Integer
        Try
            conn.Open()
            ' Dim query As String = "use banking_database; select Identification_Number from UserData where Identification_Number=@a"
            Dim query As String = "select Identification_Number,Bank_Account_Number from bankUserData where Identification_Number=@a"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@a", idOfCurrentUser)
                Dim reader = cmd.ExecuteReader
                If Not reader.Read() Then
                    MessageBox.Show("You dont have bank account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Dim form As New election_dashboard()
                    mypanel.panel1.Controls.Clear()
                    form.TopLevel = False
                    mypanel.panel1.Controls.Add(form)
                    form.Show()
                    Exit Sub
                Else
                    currentUserBankAccountNumber = Convert.ToInt32(reader("Bank_Account_Number"))
                End If
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
        'To deduct the money if the bank account exists, now only deducting 100 rupees for convenience
        Try
            conn.Open()
            'Dim query As String = "use banking_database; select Identification_Number,Balance from UserData where Identification_Number=@a"
            Dim query As String = "select Identification_Number from bankuserdata where Identification_Number=@a"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@a", idOfCurrentUser)
                Dim reader = cmd.ExecuteReader
                If Convert.ToInt32(reader("Balance")) < 100 Then
                    MessageBox.Show("You dont have enough balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Dim form As New election_dashboard()
                    mypanel.panel1.Controls.Clear()
                    form.TopLevel = False
                    mypanel.panel1.Controls.Add(form)
                    form.Show()
                    Exit Sub
                End If
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try

        'To deduct the money
        Try
            conn.Open()
            Dim query As String = "update bankUserData set Balance = Balance - 100 where Identification_Number=@a"
            'Dim query As String = "select Identification_Number from bankuserdata where Identification_Number=@a"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@a", idOfCurrentUser.ToString())
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
        'To add money to the mayor john doe
        Try
            conn.Open()
            Dim query As String = "update bankUserData set Balance = Balance + 100 where Identification_Number=@a"
            ' Dim query As String = "select Identification_Number from bankuserdata where Identification_Number=@a"

            Using cmd As New MySqlCommand(query, conn)
                Dim mayor_sid As Integer = 1
                cmd.Parameters.AddWithValue("@a", mayor_sid.ToString())
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try

        Try
            conn.Open()
            Dim query As String = "insert into banktransactionlog (Bank_Account_Number,Involved_Bank_Account_Number,Type_of_Transaction,Amount,Date_Time,Description) values (?,?,?,?,?,?)"
            Using cmd As New MySqlCommand(query, conn)
                Dim currentTime As DateTime = DateTime.Now
                cmd.Parameters.AddWithValue("?", currentUserBankAccountNumber)
                cmd.Parameters.AddWithValue("?", 15)
                cmd.Parameters.AddWithValue("?", "Money transfer via net banking")
                cmd.Parameters.AddWithValue("?", 100)
                cmd.Parameters.AddWithValue("?", currentTime)
                cmd.Parameters.AddWithValue("?", "For Nomination")
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
        paidDeposit = True
        MessageBox.Show("The amount required is deducted from your bank account and is transferred to the authority", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'To check if the contestant has uploaded manifesto and written his agenda(non empty)
        If uploaded And Agenda.Text.Length > 0 And paidDeposit Then


            Try
                conn.Open()
                'To enter into the Nominees table
                Dim query = "INSERT INTO Nominees (SID,Designation,Manifesto,VoteCount,Agenda) VALUES (@a,@b,@c,0,@d)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@a", idOfCurrentUser)
                    cmd.Parameters.AddWithValue("@b", Designation)
                    cmd.Parameters.AddWithValue("@c", fileContent)
                    cmd.Parameters.AddWithValue("@d", AgendaText)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("You have successfully nominated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim form As New election_dashboard()
                mypanel.panel1.Controls.Clear()
                form.TopLevel = False
                mypanel.panel1.Controls.Add(form)
                form.Show()
            Catch ex As Exception

            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please recheck all the entered details!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'Me.Hide()
    End Sub

    Private Sub UploadManifesto_Click(sender As Object, e As EventArgs) Handles UploadManifesto.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
        openFileDialog.Title = "Select a PDF File"
        ' Show the dialog and check if the user selected a file
        If openFileDialog.ShowDialog = DialogResult.OK Then
            Try
                Dim selectedFileName = openFileDialog.FileName
                ' Check if the selected file exists
                If File.Exists(selectedFileName) Then
                    fileContent = File.ReadAllBytes(selectedFileName)
                    uploaded = True
                    'MessageBox.Show(selectedFileName)
                Else
                    ' Handle the case where the selected file does not exist
                    MessageBox.Show("The selected file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception 'This could happen if the file size is large
                MessageBox.Show($"Error loading PDF file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub UploadManifesto_MouseEnter(sender As Object, e As EventArgs) Handles UploadManifesto.MouseEnter
        ' Change the label's background color when mouse enters
        UploadManifesto.Cursor = Cursors.Hand
    End Sub

    Private Sub UploadManifesto_MouseLeave(sender As Object, e As EventArgs) Handles UploadManifesto.MouseLeave
        ' Change the label's background color back to transparent when mouse leaves
        UploadManifesto.BackColor = Color.Transparent
        UploadManifesto.Cursor = Cursors.Default
    End Sub

    Private Sub Agenda_TextChanged(sender As Object, e As EventArgs) Handles Agenda.TextChanged
        AgendaText = Agenda.Text
        'MessageBox.Show(AgendaText)
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim form As New election_dashboard()
        mypanel.Panel1.Controls.Clear()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class