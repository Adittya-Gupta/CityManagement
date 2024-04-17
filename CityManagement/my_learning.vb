Imports MySql.Data.MySqlClient
Imports System.Diagnostics ' For Process class

Public Class my_learning
    Private Const MAX_LIMIT As Integer = 100 ' Define the maximum limit
    Private WithEvents Button3 As Button
    Private totalSections As Integer = 0
    Private sectionIds As New List(Of Integer)
    Private videoUrls As New List(Of String)
    Private currentVideoIndex As Integer = 0

    Private courseId As Integer ' Variable to hold the course ID

    ' Constructor with courseId argument
    Public Sub New(courseId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize courseId
        Me.courseId = courseId
    End Sub
    Private Sub specific_coursepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connect to the database
        Dim connString As String = Module1.connString
        MessageBox.Show(courseId)
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Fetch course data for the specific courseId from courses and CourseData tables
                Dim query As String = "SELECT c.course_name, c.sections, cd.section_id, cd.section_description, cd.section_video " &
                                      "FROM Courses c INNER JOIN CourseData cd ON c.course_id = cd.course_id " &
                                      "WHERE c.course_id = @courseId" ' Add WHERE clause to filter by courseId
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@courseId", courseId) ' Add parameter for courseId
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Iterate through the fetched data and populate the form dynamically
                        Dim verticalPosition As Integer = 90 ' Initial vertical position

                        While reader.Read()
                            ' Read the section ID, section description, and number of sections from the database
                            Dim sectionId As Integer = Convert.ToInt32(reader("section_id"))
                            Dim sectionDescription As String = reader("section_description").ToString()
                            totalSections = Convert.ToInt32(reader("sections"))
                            sectionIds.Add(sectionId)
                            videoUrls.Add(reader("section_video").ToString())

                            ' Create a panel to encapsulate each section's information
                            Dim sectionPanel As New Panel()
                            sectionPanel.BorderStyle = BorderStyle.FixedSingle
                            sectionPanel.Width = Me.ClientSize.Width - 90 ' Adjust width as needed
                            sectionPanel.Left = 20
                            sectionPanel.Top = verticalPosition
                            sectionPanel.Height = 160 ' Adjust height as needed
                            Me.Controls.Add(sectionPanel)

                            ' Create labels to display section information
                            Dim sectionIdLabel As New Label()
                            sectionIdLabel.Text = "Section ID: " & sectionId.ToString()
                            sectionIdLabel.AutoSize = True
                            sectionIdLabel.Left = 10
                            sectionIdLabel.Top = 10
                            sectionIdLabel.Font = New Font("Arial", 12, FontStyle.Bold) ' Change font to Arial, size 12, bold
                            sectionPanel.Controls.Add(sectionIdLabel)

                            Dim sectionDescLabel As New Label()
                            sectionDescLabel.Text = "Description: " & sectionDescription
                            sectionDescLabel.AutoSize = True
                            sectionDescLabel.Left = 10
                            sectionDescLabel.Top = sectionIdLabel.Bottom + 10
                            sectionDescLabel.Font = New Font("Arial", 10) ' Change font to Arial, size 10
                            sectionPanel.Controls.Add(sectionDescLabel)

                            ' Create buttons to navigate between videos
                            Dim prevButton As New Button()
                            prevButton.Text = "Previous Video"
                            prevButton.AutoSize = True
                            prevButton.Left = 10
                            prevButton.Top = sectionDescLabel.Bottom + 40
                            prevButton.Font = New Font("Arial", 10) ' Change font to Arial, size 10
                            AddHandler prevButton.Click, Sub()
                                                             NavigateToPreviousVideo()
                                                         End Sub
                            sectionPanel.Controls.Add(prevButton)

                            Dim nextButton As New Button()
                            nextButton.Text = "Next Video"
                            nextButton.AutoSize = True
                            nextButton.Left = prevButton.Right + 10
                            nextButton.Top = sectionDescLabel.Bottom + 40
                            nextButton.Font = New Font("Arial", 10) ' Change font to Arial, size 10
                            AddHandler nextButton.Click, Sub()
                                                             NavigateToNextVideo()
                                                         End Sub
                            sectionPanel.Controls.Add(nextButton)

                            ' Increment vertical position for the next section
                            verticalPosition += sectionPanel.Height + 20
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub NavigateToPreviousVideo()
        ' Decrease the current video index
        currentVideoIndex -= 1

        ' Ensure the index stays within bounds
        If currentVideoIndex < 0 Then
            currentVideoIndex = 0
        End If

        ' Retrieve the section ID based on the current video index
        Dim sectionId As Integer = sectionIds(currentVideoIndex)

        ' Retrieve the URL of the previous video
        Dim videoUrl As String = videoUrls(currentVideoIndex)

        ' Update the CourseProgress table
        UpdateCourseProgress(sectionId, totalSections)

        ' Open the video URL
        Process.Start("cmd", "/c start " & videoUrl)
    End Sub

    Private Sub NavigateToNextVideo()
        ' Increase the current video index
        currentVideoIndex += 1

        ' Ensure the index stays within bounds
        If currentVideoIndex >= totalSections Then
            currentVideoIndex = totalSections - 1
        End If

        ' Retrieve the section ID based on the current video index
        Dim sectionId As Integer = sectionIds(currentVideoIndex)

        ' Retrieve the URL of the next video
        Dim videoUrl As String = videoUrls(currentVideoIndex)

        ' Update the CourseProgress table
        UpdateCourseProgress(sectionId, totalSections)

        ' Open the video URL
        Process.Start("cmd", "/c start " & videoUrl)
    End Sub

    Private Sub UpdateCourseProgress(sectionId As Integer, totalSections As Integer)
        Try
            Dim connString As String = Module1.connString

            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Fetch the course_id associated with the section_id
                Dim courseId As Integer = 0
                Dim querySelectCourseId As String = "SELECT course_id FROM CourseData WHERE section_id = @sectionId"
                Using cmdSelectCourseId As New MySqlCommand(querySelectCourseId, conn)
                    cmdSelectCourseId.Parameters.AddWithValue("@sectionId", sectionId)
                    Dim result As Object = cmdSelectCourseId.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        courseId = Convert.ToInt32(result)
                    End If
                End Using

                ' Update the no_of_sec_completed value, ensuring it doesn't exceed the total sections
                Dim currentCompletedSections As Integer = 0
                Dim querySelectCompletedSections As String = "SELECT no_of_sec_completed FROM CourseProgress WHERE course_id = @courseId"
                Using cmdSelectCompletedSections As New MySqlCommand(querySelectCompletedSections, conn)
                    cmdSelectCompletedSections.Parameters.AddWithValue("@courseId", courseId)
                    Dim result As Object = cmdSelectCompletedSections.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        currentCompletedSections = Convert.ToInt32(result)
                    End If
                End Using

                If currentCompletedSections < totalSections Then
                    ' Update the no_of_sec_completed value by incrementing it by 1
                    Dim queryUpdate As String = "UPDATE CourseProgress SET no_of_sec_completed = no_of_sec_completed + 1 WHERE course_id = @courseId"
                    Using cmdUpdate As New MySqlCommand(queryUpdate, conn)
                        cmdUpdate.Parameters.AddWithValue("@courseId", courseId)
                        cmdUpdate.ExecuteNonQuery()
                    End Using
                End If
            End Using

            ' Highlight the panel associated with the completed section
            HighlightPanel(sectionId, color:=Color.Gray)
        Catch ex As Exception
            MessageBox.Show("Error updating course progress: " & ex.Message)
        End Try
    End Sub

    Private Sub HighlightPanel(sectionId As Integer, ByVal color As Color)
        ' Declare a variable to hold the reference to the panel control
        Dim panelControl As Panel = Nothing

        ' Assuming each section has a corresponding panel control named Panel1, Panel2, etc.
        Dim panelName As String = "Panel" & sectionId

        ' Find the panel control with the specified name within the form's controls collection
        For Each ctrl As Control In Me.Controls
            If ctrl.Name = panelName AndAlso TypeOf ctrl Is Panel Then
                ' Assign the found panel control to the variable
                panelControl = DirectCast(ctrl, Panel)
                Exit For ' Exit the loop once the panel control is found
            End If
        Next

        ' Check if the panel control was found
        If panelControl IsNot Nothing Then
            ' Change the background color of the panel control
            panelControl.BackColor = color
        End If
    End Sub
End Class
