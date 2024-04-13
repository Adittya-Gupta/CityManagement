Imports MySql.Data.MySqlClient
Imports System.IO
Public Class nomination
    Dim idOfCurrentUser As Integer = 984571
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
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Private Sub nomination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mapping("Teacher") = "Education Minister"
        mapping("Educational Institute Owner") = "Education Minister"
        mapping("Education Minister") = "Education Minister"
        mapping("Doctor") = "Health Minister"
        mapping("Hospital Owner") = "Health Minister"
        mapping("Health Minister") = "Health Minister"
        mapping("Driver") = "Transportation Minister"
        mapping("Transportation Minister") = "Transportation Minister"
        mapping("Finance Minister") = "Finance Minister"
        mapping("Home Minister") = "Home Minister"
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

    Private Sub PayDeposit_Click(sender As Object, e As EventArgs) Handles PayDeposit.Click
        'Link banking database and banking forms for further process here
        Dim paidDeposit = True


        'To check if the contestant has uploaded manifesto and written his agenda(non empty)
        If uploaded And Agenda.Text.Length > 0 And paidDeposit Then
            Try
                conn.Open()
                'To check if the nominee already present in the table
                Dim query = "select SID from Nominees where SID=?"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", idOfCurrentUser)
                    Dim reader = cmd.ExecuteReader
                    If reader.Read Then
                        MessageBox.Show("You have already entered your agenda and manifesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                    End If
                End Using
                'MessageBox.Show("Checked for duplicate entry in Nominees table successfully")
            Catch ex As Exception

            Finally
                conn.Close()
            End Try

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
                Dim electiondashboard As New election_dashboard()
                electiondashboard.Show()
                Me.Hide()
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