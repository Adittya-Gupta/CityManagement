Imports MySql.Data.MySqlClient

Public Class courserequests_page

    Private _courseId As Integer

    ' Constructor to accept course_id as a parameter
    Public Sub New(courseId As Integer)
        InitializeComponent()
        _courseId = courseId
    End Sub
    Private Sub courserequests_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String = Module1.connString

        ' courseId is the course_id passed from another form
        Dim courseId As Integer = _courseId ' Get the course_id from wherever it is passed

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim query As String = "SELECT course_id, user_id FROM CourseRequests WHERE request_status = 0 AND course_id = @courseId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@courseId", courseId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Calculate the vertical position for the first panel to center it vertically
                        Dim yPos As Integer = (Me.ClientSize.Height - 100) \ 2

                        While reader.Read()
                            ' Create a panel to hold the request details
                            Dim requestPanel As New Panel()
                            requestPanel.BorderStyle = BorderStyle.FixedSingle
                            requestPanel.Width = 250
                            requestPanel.Height = 100

                            ' Calculate the horizontal position to center the panel horizontally
                            requestPanel.Left = (Me.ClientSize.Width - requestPanel.Width) \ 2
                            ' Set the vertical position
                            requestPanel.Top = yPos

                            ' Increment the vertical position for the next panel
                            yPos += 110 ' 100 for the panel height + 10 for spacing

                            ' Add PictureBox with the embedded image from resources
                            Dim pictureBox As New PictureBox()
                            pictureBox.Image = My.Resources.Vector ' Add the image from resources
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                            pictureBox.Width = 50
                            pictureBox.Height = 50
                            pictureBox.Location = New Point(5, 5)
                            requestPanel.Controls.Add(pictureBox)

                            ' Add labels for course_id and user_id
                            Dim courseIdLabel As New Label()
                            courseIdLabel.Text = "Course ID: " & reader("course_id").ToString()
                            courseIdLabel.AutoSize = True
                            courseIdLabel.Location = New Point(60, 5)
                            requestPanel.Controls.Add(courseIdLabel)

                            Dim userIdLabel As New Label()
                            userIdLabel.Text = "User ID: " & reader("user_id").ToString()
                            userIdLabel.AutoSize = True
                            userIdLabel.Location = New Point(60, 25)
                            requestPanel.Controls.Add(userIdLabel)

                            ' Add accept button
                            Dim acceptButton As New Button()
                            acceptButton.Text = "Accept"
                            acceptButton.Location = New Point(60, 50)
                            acceptButton.Size = New Size(100, 30) ' Set the size here
                            ' Store the course_id and user_id in the button's Tag property
                            acceptButton.Tag = New Tuple(Of Integer, Integer)(reader("course_id"), reader("user_id"))
                            AddHandler acceptButton.Click, AddressOf AcceptButtonClick
                            requestPanel.Controls.Add(acceptButton)


                            ' Add the request panel to the form
                            Me.Controls.Add(requestPanel)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub AcceptButtonClick(sender As Object, e As EventArgs)
        ' Retrieve the course_id and user_id from the button's Tag property
        Dim button As Button = DirectCast(sender, Button)
        Dim courseId As Integer = DirectCast(button.Tag, Tuple(Of Integer, Integer)).Item1
        Dim userId As Integer = DirectCast(button.Tag, Tuple(Of Integer, Integer)).Item2

        Try
            ' Check if the request has already been accepted
            Dim isAlreadyAccepted As Boolean = False
            Dim connString As String = Module1.connString
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM CourseRequests WHERE course_id = @courseId AND user_id = @userId AND request_status = 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@courseId", courseId)
                    cmd.Parameters.AddWithValue("@userId", userId)
                    isAlreadyAccepted = CInt(cmd.ExecuteScalar()) > 0
                End Using
            End Using

            If Not isAlreadyAccepted Then
                ' Update the request_status to 1 in the database
                Using conn As New MySqlConnection(connString)
                    conn.Open()
                    Dim updateQuery As String = "UPDATE CourseRequests SET request_status = 1 WHERE course_id = @courseId AND user_id = @userId"
                    Using cmd As New MySqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@courseId", courseId)
                        cmd.Parameters.AddWithValue("@userId", userId)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Request accepted successfully.")
            Else
                MessageBox.Show("This request has already been accepted.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error accepting request: " & ex.Message)
        End Try

        ' Remove the request panel from the form
        Dim requestPanel As Panel = DirectCast(button.Parent, Panel)
        Me.Controls.Remove(requestPanel)
    End Sub
End Class
