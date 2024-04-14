﻿Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class allcourses_page
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Private Const PanelWidth As Integer = 250 ' Width of each panel
    Private Const PanelHeight As Integer = 300 ' Height of each panel
    Private Const PhotoSize As Integer = 150 ' Size of the course photo
    Private Const XSpacing As Integer = 60 ' Horizontal spacing between panels
    Private Const YSpacing As Integer = 20 ' Vertical spacing between panels
    Private Const PanelsPerRow As Integer = 3 ' Number of panels per row

    Private Sub allcourses_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCourses()
        Me.AutoScroll = True ' Enable auto-scrolling
    End Sub


    Private userid As Integer

    Public Sub SetUserID(id As Integer)
        userid = id
    End Sub

    Private Sub DisplayCourses()
        Dim xPos As Integer = XSpacing
        Dim yPos As Integer = 120
        Dim totalPanels As Integer = 0 ' Track total panels displayed

        Try
            conn.Open()
            Dim query As String = "SELECT c.course_photo, c.course_name, i.name , i.pic FROM Courses c INNER JOIN Institutes i ON c.user_id = i.Owner_id"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim panelIndex As Integer = 0

            While reader.Read()
                If panelIndex >= PanelsPerRow Then
                    xPos = XSpacing
                    yPos += YSpacing
                    panelIndex = 0
                End If

                Dim coursePhoto As Byte() = DirectCast(reader("course_photo"), Byte())
                Dim courseTitle As String = reader("course_name").ToString()
                Dim instituteName As String = reader("name").ToString()
                Dim institutePhoto As Byte() = DirectCast(reader("pic"), Byte())

                ' Main panel for each course
                Dim panel As New Panel()
                panel.Size = New Size(PanelWidth, PanelHeight)
                panel.Location = New Point(xPos, yPos)
                panel.BackColor = Color.WhiteSmoke
                AddHandler panel.MouseEnter, AddressOf Panel_MouseEnter
                AddHandler panel.MouseLeave, AddressOf Panel_MouseLeave

                ' PictureBox for course photo
                Dim coursePictureBox As New PictureBox()
                coursePictureBox.Location = New Point(65, 10)
                coursePictureBox.Size = New Size(PhotoSize, PhotoSize)
                coursePictureBox.SizeMode = PictureBoxSizeMode.StretchImage

                If coursePhoto IsNot Nothing Then
                    Using stream As New MemoryStream(coursePhoto)
                        coursePictureBox.Image = Image.FromStream(stream)
                    End Using
                End If

                ' PictureBox for institute photo
                Dim institutePictureBox As New PictureBox()
                institutePictureBox.Location = New Point(40, 240)
                institutePictureBox.Size = New Size(40, 40)
                institutePictureBox.SizeMode = PictureBoxSizeMode.StretchImage

                If institutePhoto IsNot Nothing Then
                    Using stream As New MemoryStream(institutePhoto)
                        institutePictureBox.Image = Image.FromStream(stream)
                    End Using
                End If

                ' Label for institute name
                Dim instituteLabel As New Label()
                instituteLabel.Location = New Point(90, 230)
                instituteLabel.Size = New Size(150, 60)
                instituteLabel.TextAlign = ContentAlignment.MiddleLeft
                instituteLabel.Text = instituteName
                instituteLabel.Font = New Font("Arial", 10, FontStyle.Regular)

                ' Label for course title
                Dim titleLabel As New Label()
                titleLabel.Name = "titleLabel"
                titleLabel.Location = New Point(10, 200)
                titleLabel.Size = New Size(260, 30)
                titleLabel.TextAlign = ContentAlignment.MiddleCenter
                titleLabel.Text = courseTitle
                titleLabel.Font = New Font("Arial", 12, FontStyle.Bold)

                ' Add event handler for panel click
                AddHandler panel.Click, AddressOf Panel_Click

                ' Add controls to panel
                panel.Controls.Add(coursePictureBox)
                panel.Controls.Add(institutePictureBox)
                panel.Controls.Add(instituteLabel)
                panel.Controls.Add(titleLabel)

                ' Add panel to form
                Me.Controls.Add(panel)

                ' Update position for next panel
                xPos += PanelWidth + XSpacing
                panelIndex += 1
                totalPanels += 1

                ' Check if it's time to move to the next row
                If totalPanels Mod PanelsPerRow = 0 Then
                    xPos = XSpacing
                    yPos += PanelHeight + YSpacing
                End If
            End While

        Catch ex As Exception
            MessageBox.Show("Error displaying courses: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        Dim form1Instance As New student_dashboard()
        form1Instance.SetUserID(userid)
        form1Instance.Show()
        Me.Hide()

    End Sub

    ' Event handler for panel mouse enter
    Private Sub Panel_MouseEnter(sender As Object, e As EventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        panel.BackColor = Color.LightGray
    End Sub

    ' Event handler for panel mouse leave
    Private Sub Panel_MouseLeave(sender As Object, e As EventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        panel.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Education_Click(sender As Object, e As EventArgs) Handles Education.Click
        Dim educationLandingForm As New education_landing()
        educationLandingForm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel_Click(sender As Object, e As EventArgs)
        Dim specificCoursePage As New specific_coursepage()

        specificCoursePage.Show()
        Me.Hide()
    End Sub
End Class
