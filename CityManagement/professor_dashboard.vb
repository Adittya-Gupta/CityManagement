Imports MySql.Data.MySqlClient
Imports System.IO

Public Class professor_dashboard
    Dim connString As String = Module1.connString
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
            Dim query As String = "SELECT Courses.course_id, Courses.course_photo, Courses.course_name, Courses.no_of_studenroll, " &
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
                Dim courseID As Integer = reader.GetInt32("course_id")
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

                Dim panel As New Panel()
                panel.Location = New Point(82, y + 10)
                panel.Size = New Size(600, 160)
                panel.BackColor = Color.AntiqueWhite
                panel.BorderStyle = BorderStyle.FixedSingle
                panel.Tag = courseID ' Store course_id in panel's Tag property

                Dim imageBox As New PictureBox()
                imageBox.Location = New Point(10, 10)
                imageBox.Size = New Size(120, 160)
                imageBox.SizeMode = PictureBoxSizeMode.Zoom

                If coursePhoto IsNot Nothing Then
                    Using stream As New MemoryStream(coursePhoto)
                        imageBox.Image = Image.FromStream(stream)
                    End Using
                End If

                Dim titleLabel As New Label()
                titleLabel.Location = New Point(180, 50)
                titleLabel.Size = New Size(630, 30)
                titleLabel.Text = courseTitle
                titleLabel.Font = New Font(titleLabel.Font.FontFamily, 16, FontStyle.Bold)

                Dim studentsLabel As New Label()
                studentsLabel.Location = New Point(180, 120)
                studentsLabel.Size = New Size(200, 50)
                studentsLabel.Text = "Students Enrolled: " & enrolledStudents.ToString()

                Dim requestsButton As New Button()
                requestsButton.Text = "Requests"
                requestsButton.Location = New Point(400, 100)
                requestsButton.Size = New Size(120, 50)
                requestsButton.BackColor = Color.DarkCyan
                requestsButton.ForeColor = Color.White

                panel.Controls.Add(imageBox)
                panel.Controls.Add(titleLabel)
                panel.Controls.Add(studentsLabel)
                panel.Controls.Add(requestsButton)
                Me.Controls.Add(nameLabel)
                Me.Controls.Add(instituteLabel)

                AddHandler requestsButton.Click, AddressOf RequestsButton_Click
                Panel1.Controls.Add(panel)

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

    Private Sub InitializePanel1()
        With Panel1
            .Location = New Point(0, 220)
            .Size = New Size(1107, 500)
            .BackColor = Color.White
            .AutoScroll = True
        End With
        Me.Controls.Add(Panel1)
    End Sub

    Private Sub RequestsButton_Click(sender As Object, e As EventArgs)
        Dim requestsButton As Button = DirectCast(sender, Button)
        Dim panel As Panel = DirectCast(requestsButton.Parent, Panel)
        Dim courseID As Integer = CInt(panel.Tag)

        mypanel.panel1.Controls.Clear()
        Dim form As New courserequests_page(courseID)

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
