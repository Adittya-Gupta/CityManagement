Imports System.IO
Imports MySql.Data.MySqlClient

Public Class EmployApplication
    Private EmploymentPortalForm As EmploymentPortal
    Private Organization As String

    'Dim connString As String = "server=localhost;userid=root;password=<password_here>;database=smart_city_management"
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Dim userID As Integer = 1005 ' User ID of the applicant
    Dim orgID As Integer ' Organization ID where the applicant is applying
    'Constructor
    Public Sub New(ParentForm As EmploymentPortal, Org As String)
        InitializeComponent()
        Me.EmploymentPortalForm = ParentForm ' Initialize EmploymentPortalForm
        Me.Organization = Org
    End Sub

    Private Sub EmployApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the label text to the organization name
        'Label2.Text = Organization

        ' Set the orgID based on the organization name
        Select Case Organization
            Case "Electrician"
                orgID = 101
            Case "Plumber"
                orgID = 106
            Case "Merchant"
                orgID = 105
            Case "Househelp"
                orgID = 104
            Case "Education"
                orgID = 103
            Case "Police"
                orgID = 102
                'Case "Transport"
                '   orgID = 107
        End Select

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        EmploymentPortalForm.LoadListOfOrgForm()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if any required field is empty
        If String.IsNullOrWhiteSpace(RichTextBox4.Text) OrElse
       String.IsNullOrWhiteSpace(RichTextBox2.Text) OrElse
       String.IsNullOrWhiteSpace(RichTextBox3.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Incomplete Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' All required fields are filled, proceed with further processing
        ' Extract data from RichTextBoxes
        Dim name As String = RichTextBox4.Text
        Dim contactDetails As String = RichTextBox2.Text
        Dim bankAccountDetails As String = RichTextBox3.Text
        Dim prevWork As String = RichTextBox1.Text

        ' Extract profile picture (if an image is loaded)
        'Dim profilePicture As Image = PictureBox1.Image
        ' Convert the image to a byte array
        Dim profilePictureBytes As Byte() = Nothing
        'If profilePicture IsNot Nothing Then
        'Using ms As New MemoryStream()
        'profilePicture.Save(ms, profilePicture.RawFormat)
        'profilePictureBytes = ms.ToArray()
        'End Using
        'End If

        ' Process or display the extracted data as required
        'MessageBox.Show($"Name: {name}, Contact Details: {contactDetails}, Bank Account Details: {bankAccountDetails}")

        ' Extract resume file name and convert it to byte array
        Dim resumeFileName As String = Label9.Text
        Dim resumeFileBytes As Byte() = Nothing

        If Not String.IsNullOrEmpty(resumeFileName) AndAlso File.Exists(resumeFileName) Then
            ' Read the file contents into a byte array
            resumeFileBytes = File.ReadAllBytes(resumeFileName)
        End If

        Try
            ' Connect to the database
            conn.Open()

            Dim query As String = "INSERT INTO workeremployreq (userID, orgID, resume, detailsPrevWork, profile_picture, date, bank_account_no, name, contactDetails) " &
                                      "VALUES (@userID, @orgID, @resume, @detailsPrevWork, @profile_picture, @date, @bank_account_no, @name, @contactDetails)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userID", userID)
                cmd.Parameters.AddWithValue("@orgID", orgID)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@contactDetails", contactDetails)
                cmd.Parameters.AddWithValue("@bank_account_no", bankAccountDetails)

                ' Optional parameters - check if they are provided before adding them
                If Not String.IsNullOrWhiteSpace(prevWork) Then
                    cmd.Parameters.AddWithValue("@detailsPrevWork", prevWork)
                Else
                    cmd.Parameters.AddWithValue("@detailsPrevWork", DBNull.Value)
                End If

                ' Set the current date and time for the 'date' column
                cmd.Parameters.AddWithValue("@date", DateTime.Now)

                ' If resumeFileBytes is not null, add it to the parameters, otherwise, set it as DBNull.Value
                If resumeFileBytes IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@resume", resumeFileBytes)
                Else
                    cmd.Parameters.AddWithValue("@resume", DBNull.Value)
                End If

                ' If profilePictureBytes is not null, add it to the parameters, otherwise, set it as DBNull.Value
                If profilePictureBytes IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@profile_picture", profilePictureBytes)
                Else
                    cmd.Parameters.AddWithValue("@profile_picture", DBNull.Value)
                End If

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Application submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear all fields after successful validation and processing
            RichTextBox4.Clear()
            RichTextBox2.Clear()
            RichTextBox3.Clear()
            RichTextBox1.Clear()
            Label9.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error submitting application: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim openFileDialog1 As New OpenFileDialog()

        ' Set the file dialog properties
        openFileDialog1.Title = "Select a Resume File"
        openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf|Word Documents (*.doc;*.docx)|*.doc;*.docx|All Files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        ' Show the dialog and check if the user selected a file
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Display the selected file path in a label (you can use it as you wish)
            Label9.Text = Path.GetFileName(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub Label6_DragEnter(sender As Object, e As DragEventArgs) Handles Label6.DragEnter
        ' Check if the data being dragged is a file
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            ' Allow the file(s) to be copied to the label
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Label6_DragDrop(sender As Object, e As DragEventArgs) Handles Label6.DragDrop
        ' Get the file(s) dropped onto the label
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        ' Process each dropped file
        For Each filePath As String In files
            ' Display only the file name without the path
            Dim fileName As String = Path.GetFileName(filePath)
            ' Display the file name in a label or handle it as you wish
            Label9.Text = fileName
        Next
    End Sub
End Class