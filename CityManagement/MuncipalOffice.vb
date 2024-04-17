Imports MySql.Data.MySqlClient
Imports System.IO


Public Class MuncipalOffice

    Private isPendingView As Boolean = False ' Flag to track if pending view is active
    Private InstituteID As Integer ' Variable to store the Institute ID

    ' Constructor to initialize the form with Institute ID
    Public Sub New(instituteID As Integer)
        InitializeComponent()
        Me.InstituteID = instituteID
    End Sub

    Private Sub EducationOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOwnerRequests()
    End Sub

    Private Sub LoadOwnerRequests()
        ' Establish connection to the database
        'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Dim connString As String = Module1.connString
        Dim conn As New MySqlConnection(connString)

        Try
            ' Open the database connection
            conn.Open()

            ' Create a MySqlCommand object to execute SQL queries
            Dim cmd As New MySqlCommand()

            ' Set the command text to retrieve data from workerEmployReq and User tables based on status
            ' Dim statusFilter As String = If(isPendingView, "1 OR mr.Status = -1", "0")
            Dim statusFilter As String = If(isPendingView, "wer.Status = 'Accepted' OR wer.Status = 'Rejected'", "wer.Status = 'Submitted'")

            cmd.CommandText = "SELECT wer.userID, u.Name, u.ProfilePic, wer.Date, wer.resume, wer.Status FROM workerEmployReq wer JOIN User u ON wer.userID = u.SID WHERE wer.orgID = @InstituteID AND wer.Status IN (" & statusFilter & ")"

            ' Set the parameters for the command
            cmd.Parameters.AddWithValue("@InstituteID", InstituteID)

            ' Set the connection for the command
            cmd.Connection = conn

            ' Execute the command and retrieve the data
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing controls in Panel1
            Panel1.Controls.Clear()

            ' Create a FlowLayoutPanel to hold the workerEmployReq controls
            Dim flowLayoutPanel As New FlowLayoutPanel()
            flowLayoutPanel.Dock = DockStyle.Fill
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown

            ' Set AutoScroll property of FlowLayoutPanel to True to enable vertical scrolling
            flowLayoutPanel.AutoScroll = True

            ' Set WrapContents property to False to ensure vertical arrangement
            flowLayoutPanel.WrapContents = False

            ' Add the FlowLayoutPanel to Panel1
            Panel1.Controls.Add(flowLayoutPanel)

            ' Iterate through the rows returned by the query
            While reader.Read()
                ' Create a new instance of workerEmployReq user control
                Dim workerReqControl As New workerEmployReq

                ' Populate the workerEmployReq control with data from the reader
                workerReqControl.lbldateTime.Text = reader("Date").ToString()
                workerReqControl.lblName.Text = reader("Name").ToString()

                ' Convert ProfilePic from byte array to Image and assign to PictureBox
                Dim imageData As Byte() = If(reader("ProfilePic") Is DBNull.Value, Nothing, DirectCast(reader("ProfilePic"), Byte()))
                If imageData IsNot Nothing Then
                    Using ms As New MemoryStream(imageData)
                        workerReqControl.pbProfile.SizeMode = PictureBoxSizeMode.StretchImage
                        workerReqControl.pbProfile.Image = Image.FromStream(ms)
                    End Using
                End If

                ' Store userID in Tag property of workerEmployReq control for reference
                workerReqControl.Tag = reader("userID")

                ' Attach event handlers for lblDetails, lblAccept, and lblReject
                AddHandler workerReqControl.lblDetails.Click, AddressOf lblDetails_Click
                AddHandler workerReqControl.lblAccept.Click, AddressOf lblAccept_Click
                AddHandler workerReqControl.lblReject.Click, AddressOf lblReject_Click
                Dim status As String = reader("Status").ToString()
                Select Case status
                    Case "Submitted"
                        workerReqControl.lblAccrej.Text = "Pending"
                    Case "Accepted"
                        workerReqControl.lblAccrej.Text = "Approved"
                    Case "Rejected"
                        workerReqControl.lblAccrej.Text = "Rejected"
                End Select

                ' Add the workerEmployReq control to the FlowLayoutPanel
                flowLayoutPanel.Controls.Add(workerReqControl)
            End While

            ' Close the reader
            reader.Close()

        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub

    Private Sub lblDetails_Click(sender As Object, e As EventArgs)
        ' Handle lblDetails click event
        Dim workerReqControl As workerEmployReq = DirectCast(sender.Parent, workerEmployReq)

        ' Extract userID from Tag property
        Dim userID As Integer = Convert.ToInt32(workerReqControl.Tag)

        ' Retrieve resume details from the database for the given userID
        Dim connString As String = Module1.connString
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT resume FROM workerEmployReq WHERE userID = @userID", conn)
                cmd.Parameters.AddWithValue("@userID", userID)
                Dim resumeData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
                If resumeData IsNot Nothing Then
                    ' Generate a unique temporary file name with .pdf extension in the temp folder
                    Dim tempPdfFilePath As String = Path.Combine(Application.StartupPath, "..\..\..\MediaFiles", Guid.NewGuid().ToString() & ".pdf")

                    ' Write the binary data to the temporary PDF file
                    File.WriteAllBytes(tempPdfFilePath, resumeData)
                    MessageBox.Show("PDF downloaded in  " & tempPdfFilePath)
                Else
                    MessageBox.Show("Resume not found for userID: " & userID)
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        ' Reload the workerEmployReq after processing the click event
        LoadOwnerRequests()
    End Sub

    Private Sub lblAccept_Click(sender As Object, e As EventArgs)
        ' Handle lblAccept click event
        Dim workerReqControl As workerEmployReq = DirectCast(sender.Parent, workerEmployReq)

        ' Extract userID from Tag property
        Dim userID As Integer = Convert.ToInt32(workerReqControl.Tag)

        ' Update the Status column to 'Accepted' in the workerEmployReq table for the given userID
        UpdateStatus(userID, "Accepted")

        ' Reload the workerEmployReq after processing the click event
        LoadOwnerRequests()
    End Sub

    Private Sub lblReject_Click(sender As Object, e As EventArgs)
        ' Handle lblReject click event
        Dim workerReqControl As workerEmployReq = DirectCast(sender.Parent, workerEmployReq)

        ' Extract userID from Tag property
        Dim userID As Integer = Convert.ToInt32(workerReqControl.Tag)

        ' Update the Status column to 'Rejected' in the workerEmployReq table for the given userID
        UpdateStatus(userID, "Rejected")

        ' Reload the workerEmployReq after processing the click event
        LoadOwnerRequests()
    End Sub


    Private Sub UpdateStatus(userID As Integer, status As String)
        ' Update the Status column in the workerEmployReq table for the given userID
        Dim connString As String = Module1.connString
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE workerEmployReq SET Status = @Status WHERE userID = @userID", conn)
                cmd.Parameters.AddWithValue("@userID", userID)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Status updated successfully for userID: " & userID)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        ' Toggle between pending and approved views
        isPendingView = Not isPendingView
        Label1.Text = If(isPendingView, "Pending", "Approved")
        LoadOwnerRequests()
    End Sub
End Class
