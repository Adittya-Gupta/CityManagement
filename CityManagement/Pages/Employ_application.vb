Imports System.IO
Imports MySql.Data.MySqlClient

Public Class EmployApplication
    Private EmploymentPortalForm As EmploymentPortal
    Private Organization As String
    Private initialImage As Image

    'Dim connString As String = "server=localhost;userid=root;password=pwd;database=smart_city_management"
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)

    'Dim userID As Integer = 984584 ' User ID of the applicant
    Dim userID As Integer = Module1.CurrUserSID
    Dim orgID As Integer ' Organization ID where the applicant is applying

    Dim tempProfilePictureBytes As Byte() ' Temporary storage for profile picture bytes
    Dim resumeFileBytes As Byte() ' Storage for resume file bytes

    'Constructor
    Public Sub New(ParentForm As EmploymentPortal, Org As String)
        InitializeComponent()
        Me.EmploymentPortalForm = ParentForm ' Initialize EmploymentPortalForm
        Me.Organization = Org
    End Sub

    Private Sub EmployApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the label text to the organization name
        orgName.Text = Organization.ToUpper()

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
                orgName.Text = "TEACHER"
                Document.Text = "Upload Teaching Certificate or Resume*"
            Case "Police"
                orgID = 102
                orgName.Text = "POLICE OFFICER"
                Document.Text = "Upload Police Clearance Certificate*"
            Case "Transport"
                orgID = 107
                orgName.Text = "DRIVER"
                Document.Text = "Upload Driving License*"
        End Select

        docName.Text = ""
        initialImage = profPic.Image
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        EmploymentPortalForm.LoadListOfOrgForm()
    End Sub

    ' Click event handler for the apply button
    Private Sub applyBtn_Click(sender As Object, e As EventArgs) Handles applyBtn.Click
        ' Check if any required field is empty
        If String.IsNullOrWhiteSpace(personName.Text) OrElse
           String.IsNullOrWhiteSpace(contactInfo.Text) OrElse
           String.IsNullOrWhiteSpace(address.Text) OrElse
           String.IsNullOrWhiteSpace(bankAcc.Text) OrElse
            String.IsNullOrWhiteSpace(emailAddr.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Incomplete Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If String.IsNullOrEmpty(emailAddr.Text) OrElse Not emailAddr.Text.Contains("@") OrElse Not emailAddr.Text.Contains(".") Then
            MessageBox.Show("Please enter correct email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' All required fields are filled, proceed with further processing
        ' Extract data from RichTextBoxes
        Dim name As String = personName.Text
        Dim contactDetails As String = contactInfo.Text
        Dim addressDetails As String = address.Text
        Dim email As String = emailAddr.Text
        Dim bankAccountDetails As String = bankAcc.Text
        Dim prevWork As String = Details.Text

        If docName.Text = "" Then
            If orgName.Text = "TEACHER" Or orgName.Text = "POLICE OFFICER" Or orgName.Text = "DRIVER" Then
                MessageBox.Show("Please upload the required document.", "Incomplete Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        End If

        ' Save the details along with the profile picture to the database
        SaveDetailsToDatabase(name, contactDetails, addressDetails, email, bankAccountDetails, prevWork)

        ' Clear all fields after successful validation and processing
        personName.Clear()
        contactInfo.Clear()
        emailAddr.Clear()
        bankAcc.Clear()
        address.Clear()
        Details.Clear()
        docName.Text = ""
        profPic.Image = initialImage
    End Sub

    ' Function to save application details to the database
    Private Sub SaveDetailsToDatabase(name As String, contactDetails As String, addressDetails As String, email As String, bankAccountDetails As String, prevWork As String)
        Try
            ' Connect to the database
            conn.Open()

            ' SQL query to insert the details into the database
            Dim query As String = "INSERT INTO workerEmployReq (userID, orgID, resume, detailsPrevWork, profile_picture, date, bank_account_no, name, contactDetails, email, address) " &
                                  "VALUES (@userID, @orgID, @resume, @detailsPrevWork, @profile_picture, @date, @bank_account_no, @name, @contactDetails, @email, @address)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userID", userID)
                cmd.Parameters.AddWithValue("@orgID", orgID)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@contactDetails", contactDetails)
                cmd.Parameters.AddWithValue("@address", addressDetails)
                cmd.Parameters.AddWithValue("@bank_account_no", bankAccountDetails)
                cmd.Parameters.AddWithValue("@email", email)

                ' Optional parameters - check if they are provided before adding them
                If Not String.IsNullOrWhiteSpace(prevWork) Then
                    cmd.Parameters.AddWithValue("@detailsPrevWork", prevWork)
                Else
                    cmd.Parameters.AddWithValue("@detailsPrevWork", DBNull.Value)
                End If

                ' Set the current date and time for the 'date' column
                cmd.Parameters.AddWithValue("@date", DateTime.Now)

                ' If tempProfilePictureBytes is not null, add it to the parameters, otherwise, set it as DBNull.Value
                If tempProfilePictureBytes IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@profile_picture", tempProfilePictureBytes)
                Else
                    cmd.Parameters.AddWithValue("@profile_picture", DBNull.Value)
                End If

                ' If resumeFileBytes is not null, add it to the parameters, otherwise, set it as DBNull.Value
                If resumeFileBytes IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@resume", resumeFileBytes)
                Else
                    cmd.Parameters.AddWithValue("@resume", DBNull.Value)
                End If

                cmd.ExecuteNonQuery()
            End Using

            'If orgID = 103 Then
            '    Dim query2 As String = "UPDATE User SET Designation = 'Teacher' WHERE SID = @userID"
            '    Using cmd2 As New MySqlCommand(query2, conn)
            '        cmd2.Parameters.AddWithValue("@userID", userID)
            '        cmd2.ExecuteNonQuery()
            '    End Using
            'ElseIf orgID = 107 Then
            '    Dim query2 As String = "UPDATE User SET Designation = 'Driver' WHERE SID = @userID"
            '    Using cmd2 As New MySqlCommand(query2, conn)
            '        cmd2.Parameters.AddWithValue("@userID", userID)
            '        cmd2.ExecuteNonQuery()
            '    End Using
            'End If

            MessageBox.Show("Application submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error submitting application: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MessageBox.Show("Error submitting application: Incorrect values in some fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    ' Click event handler for the Document label
    Private Sub Document_Click(sender As Object, e As EventArgs) Handles Document.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Title = "Select a Resume File"
        openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf|Word Documents (*.doc;*.docx)|*.doc;*.docx|All Files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            docName.Text = Path.GetFileName(openFileDialog1.FileName)
            resumeFileBytes = File.ReadAllBytes(openFileDialog1.FileName)
        End If
    End Sub

    ' Drag and drop event handlers for the Document label
    Private Sub Document_DragEnter(sender As Object, e As DragEventArgs) Handles Document.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Document_DragDrop(sender As Object, e As DragEventArgs) Handles Document.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        For Each filePath As String In files
            docName.Text = Path.GetFileName(filePath)
            resumeFileBytes = File.ReadAllBytes(filePath)
        Next
    End Sub

    ' Click event handler for the upload label
    Private Sub upload_Click(sender As Object, e As EventArgs) Handles upload.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Title = "Select an Image File"
        openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim image As Image = Image.FromFile(openFileDialog1.FileName)
            profPic.SizeMode = PictureBoxSizeMode.Zoom ' Set SizeMode to Zoom
            profPic.Image = image
            tempProfilePictureBytes = File.ReadAllBytes(openFileDialog1.FileName)
        End If
    End Sub

End Class
