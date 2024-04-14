Imports MySql.Data.MySqlClient
Imports System.IO

Public Class professor_dashboard
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Private userid As Integer

    Public Sub SetUserID(id As Integer)
        userid = id
    End Sub
    Private WithEvents Panel1 As New Panel()

    Private Sub professor_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializePanel1()
        Try
            conn.Open()
            Dim query As String = "SELECT Courses.course_photo, Courses.course_name, Courses.no_of_studenroll, " &
                                  "User.name AS UserName, User.ProfilePic AS UserPhoto, Institutes.name AS InstituteName " &
                                  "FROM Courses " &
                                  "INNER JOIN User ON Courses.user_id = User.SID " &
                                  "LEFT JOIN Institutes ON User.SID = Institutes.Owner_id " &
                                  "WHERE Courses.user_id = @userid AND User.Designation = 'Teacher'"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@userid", userid)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim y As Integer = 20
            Dim spacingY As Integer = 200

            While reader.Read()
                Dim coursePhoto As Byte() = DirectCast(reader("course_photo"), Byte())
                Dim courseTitle As String = reader("course_name").ToString()
                Dim enrolledStudents As Integer = If(reader("no_of_studenroll") IsNot DBNull.Value, Convert.ToInt32(reader("no_of_studenroll")), 0)
                Dim userName As String = reader("UserName").ToString()
                Dim instituteName As String = reader("InstituteName").ToString()

                Dim nameLabel As New Label()
                nameLabel.Location = New Point(920, 159)
                nameLabel.Size = New Size(630, 30)
                nameLabel.Font = New Font(nameLabel.Font.FontFamily, 14, FontStyle.Bold)
                nameLabel.Text = userName

                Dim instituteLabel As New Label()
                instituteLabel.Location = New Point(950, 189)
                instituteLabel.Size = New Size(630, 30)
                instituteLabel.Text = instituteName

                ' Main panel for each course
                Dim panel As New Panel()
                panel.Location = New Point(82, y + 10)
                panel.Size = New Size(600, 160) ' Adjust the height to make the panel smaller
                panel.BackColor = Color.AntiqueWhite
                panel.BorderStyle = BorderStyle.FixedSingle

                ' PictureBox for photo
                Dim imageBox As New PictureBox()
                imageBox.Location = New Point(10, 10)
                imageBox.Size = New Size(120, 160) ' Adjust the size of the photo relative to the panel size
                imageBox.SizeMode = PictureBoxSizeMode.Zoom

                If coursePhoto IsNot Nothing Then
                    Using stream As New MemoryStream(coursePhoto)
                        imageBox.Image = Image.FromStream(stream)
                    End Using
                End If

                ' Label for course title
                Dim titleLabel As New Label()
                titleLabel.Location = New Point(180, 50)
                titleLabel.Size = New Size(630, 30) ' Adjust the size of the title label relative to the panel size
                titleLabel.Text = courseTitle
                titleLabel.Font = New Font(titleLabel.Font.FontFamily, 16, FontStyle.Bold)

                ' Label for enrolled students
                Dim studentsLabel As New Label()
                studentsLabel.Location = New Point(180, 120)
                studentsLabel.Size = New Size(200, 50) ' Adjust the size of the students label relative to the panel size
                studentsLabel.Text = "Students Enrolled: " & enrolledStudents.ToString()

                ' Button for requests
                Dim requestsButton As New Button()
                requestsButton.Text = "Requests"
                requestsButton.Location = New Point(400, 100)
                requestsButton.Size = New Size(120, 50) ' Adjust the size of the button relative to the panel size
                requestsButton.BackColor = Color.DarkCyan
                requestsButton.ForeColor = Color.White
                ' Add controls to panels
                panel.Controls.Add(imageBox)
                panel.Controls.Add(titleLabel)
                panel.Controls.Add(studentsLabel)
                panel.Controls.Add(requestsButton)
                Me.Controls.Add(nameLabel)
                Me.Controls.Add(instituteLabel)

                AddHandler requestsButton.Click, AddressOf RequestsButton_Click
                Panel1.Controls.Add(panel)

                ' Increment y position for the next row
                y += spacingY
            End While
            Panel1.VerticalScroll.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error displaying courses: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Me.AutoScroll = True
    End Sub



    ' Function to initialize Panel1
    Private Sub InitializePanel1()
        With Panel1
            .Location = New Point(0, 220)
            .Size = New Size(1254, 696)
            .BackColor = Color.White
            .AutoScroll = True ' Enable auto-scrolling
        End With
        Me.Controls.Add(Panel1)
    End Sub

    Private Sub DisplayCoursesForProfessor(userID As String)
        Try
            conn.Open()
            Dim query As String = "SELECT Courses.course_photo, Courses.course_name, Courses.no_of_studenroll, " &
                                  "User.name AS UserName, User.ProfilePic AS UserPhoto, Institutes.name AS InstituteName " &
                                  "FROM Courses " &
                                  "INNER JOIN User ON Courses.user_id = User.SID " &
                                  "LEFT JOIN Institutes ON User.SID = Institutes.Owner_id " &
                                  "WHERE Courses.user_id = @userid AND User.Designation = 'Teacher'"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@userid", userID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim y As Integer = 20
            Dim spacingY As Integer = 200

            While reader.Read()
                Dim coursePhoto As Byte() = DirectCast(reader("course_photo"), Byte())
                Dim courseTitle As String = reader("course_name").ToString()
                Dim enrolledStudents As Integer = If(reader("no_of_studenroll") IsNot DBNull.Value, Convert.ToInt32(reader("no_of_studenroll")), 0)
                Dim userName As String = reader("UserName").ToString()
                Dim instituteName As String = reader("InstituteName").ToString()

                Dim nameLabel As New Label()
                nameLabel.Location = New Point(920, 159)
                nameLabel.Size = New Size(630, 30)
                nameLabel.Font = New Font(nameLabel.Font.FontFamily, 14, FontStyle.Bold)
                nameLabel.Text = userName

                Dim instituteLabel As New Label()
                instituteLabel.Location = New Point(950, 189)
                instituteLabel.Size = New Size(630, 30)
                instituteLabel.Text = instituteName

                ' Main panel for each course
                Dim panel As New Panel()
                panel.Location = New Point(82, y + 10)
                panel.Size = New Size(600, 160) ' Adjust the height to make the panel smaller
                panel.BackColor = Color.AntiqueWhite
                panel.BorderStyle = BorderStyle.FixedSingle

                ' PictureBox for photo
                Dim imageBox As New PictureBox()
                imageBox.Location = New Point(10, 10)
                imageBox.Size = New Size(120, 160) ' Adjust the size of the photo relative to the panel size
                imageBox.SizeMode = PictureBoxSizeMode.Zoom

                If coursePhoto IsNot Nothing Then
                    Using stream As New MemoryStream(coursePhoto)
                        imageBox.Image = Image.FromStream(stream)
                    End Using
                End If

                ' Label for course title
                Dim titleLabel As New Label()
                titleLabel.Location = New Point(180, 50)
                titleLabel.Size = New Size(630, 30) ' Adjust the size of the title label relative to the panel size
                titleLabel.Text = courseTitle
                titleLabel.Font = New Font(titleLabel.Font.FontFamily, 16, FontStyle.Bold)

                ' Label for enrolled students
                Dim studentsLabel As New Label()
                studentsLabel.Location = New Point(180, 120)
                studentsLabel.Size = New Size(200, 50) ' Adjust the size of the students label relative to the panel size
                studentsLabel.Text = "Students Enrolled: " & enrolledStudents.ToString()

                ' Button for requests
                Dim requestsButton As New Button()
                requestsButton.Text = "Requests"
                requestsButton.Location = New Point(400, 100)
                requestsButton.Size = New Size(120, 50) ' Adjust the size of the button relative to the panel size
                requestsButton.BackColor = Color.DarkCyan
                requestsButton.ForeColor = Color.White
                ' Add controls to panels
                panel.Controls.Add(imageBox)
                panel.Controls.Add(titleLabel)
                panel.Controls.Add(studentsLabel)
                panel.Controls.Add(requestsButton)
                Me.Controls.Add(nameLabel)
                Me.Controls.Add(instituteLabel)

                AddHandler requestsButton.Click, AddressOf RequestsButton_Click
                Panel1.Controls.Add(panel)

                ' Increment y position for the next row
                y += spacingY
            End While
            Panel1.VerticalScroll.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error displaying courses: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub RequestsButton_Click(sender As Object, e As EventArgs)

        mypanel.panel1.Controls.Clear()
        Dim form As New courserequests_page()
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Education_Click(sender As Object, e As EventArgs) Handles Education.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New education_landing()
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New addcourse_page()
        form.SetUserID(userid)
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class
