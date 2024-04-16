Imports MySql.Data.MySqlClient
Imports System.IO

Public Class specific_course
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Private userid As Integer

    Public Sub SetUserID(id As Integer)
        userid = id
    End Sub

    Private Sub specific_course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Query to fetch course information
                Dim query As String = "SELECT course_name, course_photo, course_description, no_of_studenroll FROM Courses"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Clear existing controls
                        Me.Controls.Clear()

                        ' Initialize vertical position for controls
                        Dim verticalPosition As Integer = 100

                        ' Define font and size for labels and buttons
                        Dim fontName As String = "Arial"
                        Dim fontSize As Single = 10
                        Dim labelFont As New Font(fontName, fontSize)
                        Dim buttonFont As New Font(fontName, fontSize, FontStyle.Bold)

                        ' Iterate through the fetched data
                        While reader.Read()
                            ' Fetch course information
                            Dim courseName As String = reader("course_name").ToString()
                            Dim courseDescription As String = reader("course_description").ToString()
                            Dim numStudentsEnrolled As Integer = Convert.ToInt32(reader("no_of_studenroll"))

                            ' Load course photo from database
                            Dim imageData As Byte() = DirectCast(reader("course_photo"), Byte())
                            Dim coursePhoto As Image = Nothing
                            If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                                Using ms As New MemoryStream(imageData)
                                    coursePhoto = Image.FromStream(ms)
                                End Using
                            End If

                            ' Create and configure controls dynamically
                            Dim nameLabel As New Label()
                            nameLabel.Text = "Course Name: " & courseName
                            nameLabel.AutoSize = True
                            nameLabel.Left = 120
                            nameLabel.Top = verticalPosition
                            nameLabel.Top = nameLabel.Bottom + 10
                            nameLabel.Font = New Font("Arial", 12, FontStyle.Bold) ' 
                            Me.Controls.Add(nameLabel)

                            Dim descriptionLabel As New Label()
                            descriptionLabel.Text = "Description: " & courseDescription
                            descriptionLabel.AutoSize = True
                            descriptionLabel.Left = 10
                            descriptionLabel.Top = nameLabel.Bottom + 60 ' Adjusted top position
                            descriptionLabel.Font = labelFont
                            Me.Controls.Add(descriptionLabel)

                            Dim enrolledLabel As New Label()
                            enrolledLabel.Text = "Students Enrolled: " & numStudentsEnrolled.ToString()
                            enrolledLabel.AutoSize = True
                            enrolledLabel.Left = 20
                            enrolledLabel.Top = descriptionLabel.Bottom + 20
                            enrolledLabel.Font = labelFont
                            Me.Controls.Add(enrolledLabel)

                            If coursePhoto IsNot Nothing Then
                                Dim photoPictureBox As New PictureBox()
                                ' Configure PictureBox properties like SizeMode, Size, Location, etc.
                                photoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                                photoPictureBox.Size = New Size(60, 60)
                                photoPictureBox.Image = coursePhoto
                                photoPictureBox.Left = 60
                                photoPictureBox.Top = photoPictureBox.Bottom + 15
                                photoPictureBox.Top = verticalPosition
                                Me.Controls.Add(photoPictureBox)

                                ' Adjust vertical position based on the tallest control
                                Dim maxBottom As Integer = Math.Max(nameLabel.Bottom, photoPictureBox.Bottom)
                                verticalPosition = maxBottom + 20
                            Else
                                ' If photo is not available, adjust position based on the tallest control
                                Dim maxBottom As Integer = Math.Max(nameLabel.Bottom, enrolledLabel.Bottom)
                                verticalPosition = maxBottom + 20
                            End If

                            ' Exit loop after displaying one course
                            Exit While
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Education_Click(sender As Object, e As EventArgs) Handles Education.Click

    End Sub
End Class
