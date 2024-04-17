Imports System.Drawing.Drawing2D
Imports System.Windows.Documents
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CityManagement.ServiceHistory
Imports System.IO
Public Class ListItem

    Public Worker_ID As String
    Public Sub New(
    Optional ByVal worker As String = "1",
    Optional ByVal name As String = "Default Name",
    Optional ByVal address As String = "Default Address",
    Optional ByVal numberOfRatings As String = "0 ratings",
    Optional ByVal phoneNumber As String = "+91 9049381111",
    Optional ByVal rating As Double = 3.0,
    Optional ByVal imageBytes As Byte() = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Set the values to the controls
        Worker_ID = worker
        Label1.Text = name
        Label2.Text = address
        Label3.Text = numberOfRatings
        Label7.Text = phoneNumber

        ' Set the RatingValue property of the Rating UserControl
        Rating1.RatingValue = rating

        ' Set the image for PictureBox1 if imageBytes are provided
        If imageBytes IsNot Nothing Then
            'log outpt to system degugger
            Debug.WriteLine("An error occurred:  Listitem 11111111111111111111")
            Try
                'MessageBox.Show("Image bytes are not null")
                ' Output the exception details to the system debugger


                Using stream As New MemoryStream(imageBytes)
                    PictureBox1.Image = Image.FromStream(stream)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If

        ' Make the PictureBox round
        MakePictureBoxRound(PictureBox1)
    End Sub

    Private Sub MakePictureBoxRound(pictureBox As PictureBox)
        ' Create a GraphicsPath to define a circle
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height)

        ' Set the PictureBox's region to the circle defined by the GraphicsPath
        pictureBox.Region = New Region(path)
    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        ' Define the SQL query to insert into the serviceBooking table

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed with the service booking?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' Ask for confirmation before proceeding
        ' Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed with the service booking?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check if the user clicked Yes
        If result = DialogResult.Yes Then
            Try
                ' Define the SQL query to insert into the serviceBooking table
                Dim query As String = "INSERT INTO serviceBooking (workerID, orgID, clientID, status) VALUES (@workerID, @orgID, @clientID, @status)"

                ' Create MySQL connection
                Using connection As New MySqlConnection(Globals.connectionstring)
                    ' Open the connection
                    connection.Open()

                    ' Create MySqlCommand
                    Using command As New MySqlCommand(query, connection)
                        ' Add parameters
                        command.Parameters.AddWithValue("@workerID", Me.Worker_ID)
                        command.Parameters.AddWithValue("@orgID", Globals.OrgId)
                        command.Parameters.AddWithValue("@clientID", Globals.UserId)
                        command.Parameters.AddWithValue("@status", "EnquirySent")

                        ' Execute the command
                        command.ExecuteNonQuery()

                        ' Show message box to confirm the action
                        MessageBox.Show("Service booking has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Load the service history
                        Globals.ServiceHistoryForm.ServiceHistory_Load()
                    End Using
                End Using

                ' Update the form in the UrbanClapNav panel to Globals.servicehistory
                Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.ServiceHistoryForm)
            Catch ex As Exception
                ' Show message box for any error that occurred
                MessageBox.Show("An error occurred while adding the service booking. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class