Imports System.Drawing.Drawing2D
Imports System.Windows.Documents
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CityManagement.ServiceHistory
Public Class ListItem

    Public Worker_ID As String
    Public Sub New(Optional ByVal worker As String = "1", Optional ByVal name As String = "Default Name", Optional ByVal address As String = "Default Address", Optional ByVal numberOfRatings As String = "0 ratings", Optional ByVal phoneNumber As String = "+91 9049381111", Optional ByVal rating As Double = 3.0)
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Globals.chatsForm.Label2.Text = Label1.Text
        Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.chatsForm)
        Globals.UrbanClapNavForm.ShowCurvedLabels_chats()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
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

                ' Load the service history
                Globals.ServiceHistoryForm.ServiceHistory_Load()
            End Using
        End Using

        ' Update the form in the UrbanClapNav panel to Globals.servicehistory
        Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.ServiceHistoryForm)
    End Sub


End Class