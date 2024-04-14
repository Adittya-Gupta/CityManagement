Imports MySql.Data.MySqlClient
Imports System.IO

Public Class allcourses_page
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Private WithEvents Panel1 As New Panel()

    Private Sub allcourses_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializePanel1()
        DisplayCourses()
    End Sub

    ' Function to initialize Panel1
    Private Sub InitializePanel1()
        With Panel1
            .Location = New Point(0, 100)
            .Size = New Size(1254, 796)
            .BackColor = Color.FromArgb(240, 240, 240)
            .AutoScroll = True ' Enable auto-scrolling
        End With
        Me.Controls.Add(Panel1)
    End Sub


    Private Sub DisplayCourses()
        Try
            conn.Open()
            Dim query As String = "SELECT course_photo, course_name FROM Courses"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim x As Integer = 122
            Dim y As Integer = 80
            Dim spacingX As Integer = 370
            Dim spacingY As Integer = 300

            While reader.Read()
                Dim coursePhoto As Byte() = DirectCast(reader("course_photo"), Byte())
                Dim courseTitle As String = reader("course_name").ToString()

                ' Main panel for each course
                Dim panel As New Panel()
                panel.Location = New Point(x, y)
                panel.Size = New Size(205, 260)
                panel.BackColor = Color.White

                ' Panel for photo
                Dim photoPanel As New Panel()
                photoPanel.Location = New Point(0, 0)
                photoPanel.Size = New Size(205, 180)
                photoPanel.BackColor = Color.White

                ' PictureBox for photo
                Dim imageBox As New PictureBox()
                imageBox.Location = New Point(0, 0)
                imageBox.Size = New Size(205, 180)
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage

                If coursePhoto IsNot Nothing Then
                    Using stream As New MemoryStream(coursePhoto)
                        imageBox.Image = Image.FromStream(stream)
                    End Using
                End If

                ' Panel for label
                Dim labelPanel As New Panel()
                labelPanel.Location = New Point(0, 180)
                labelPanel.Size = New Size(205, 80) ' Adjust label panel size
                labelPanel.BackColor = Color.FromArgb(220, 220, 220) ' Set label panel background color

                ' Label for course title
                Dim titleLabel As New Label()
                titleLabel.Location = New Point(0, 10) ' Adjust label location
                titleLabel.Size = New Size(205, 60) ' Adjust label size
                titleLabel.TextAlign = ContentAlignment.MiddleCenter
                titleLabel.Text = courseTitle
                titleLabel.BackColor = Color.Transparent ' Set label background color

                ' Add controls to panels
                photoPanel.Controls.Add(imageBox)
                labelPanel.Controls.Add(titleLabel)
                panel.Controls.Add(photoPanel)
                panel.Controls.Add(labelPanel)

                AddHandler panel.Click, AddressOf Panel_Click
                Panel1.Controls.Add(panel)

                ' Increment x position for the next panel
                x += spacingX

                ' Check if we need to move to the next row
                If x + spacingX > Panel1.Width Then
                    x = 122 ' Reset x position for the next row
                    y += spacingY ' Increment y position for the next row
                End If
            End While

        Catch ex As Exception
            MessageBox.Show("Error displaying courses: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub Panel_Click(sender As Object, e As EventArgs)
        ' Handle panel click event
        Dim clickedPanel As Panel = DirectCast(sender, Panel)
        ' Add your panel click logic here
        MessageBox.Show("Panel clicked")
    End Sub

End Class
