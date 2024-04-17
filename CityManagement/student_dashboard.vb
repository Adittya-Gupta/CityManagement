Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.ComponentModel
Imports System.Diagnostics.Metrics
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.IO
Imports Org.BouncyCastle.Tls
Imports System.Net.Mail
Imports Org.BouncyCastle.Security


Public Class student_dashboard
    Public Property course_name As String
    Public Property user
    Private userid As Integer

    Public Sub SetUserID(id As Integer)
        userid = id
    End Sub
    Dim courseId As Integer
    Dim connstrig As String = Module1.connString
    Dim conn As New MySqlConnection(connstrig)
    Dim conn1 As New MySqlConnection(connstrig)
    Dim vertical = 20
    Dim count1 = 0
    Dim count2 = 0
    Dim count = 0
    Dim h = 0
    Private Function ByteArrayToImage(byteArray As Byte()) As Image
        Using ms As New MemoryStream(byteArray)
            Dim image As Image = Image.FromStream(ms)
            Return image
        End Using
    End Function
    Dim s1 As String
    Dim s3 As String
    Dim s2 As String


    Private Sub student_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conn.Open()
            b1.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#FBD0A0")
            Me.Size = New Size(1107, 760)
            Me.AutoScroll = True
            Me.HorizontalScroll.Maximum = 1300
            Dim query4 As String = "SELECT Name FROM User WHERE SID = @userid "
            Dim query3 As String = "SELECT Institutes.name
                                    FROM courses
                                    INNER JOIN Institutes ON Courses.user_id  = Institutes.Owner_id  
                                    WHERE  Courses.course_id = @par"
            Dim query2 As String = "SELECT 
                           cr.course_id, 
                           cr.request_status,
                           cr.paymemt_status,
                              c.course_name,
                              c.course_photo
                      FROM 
        CourseRequests cr
              JOIN 
        Courses c ON cr.course_id = c.course_id
              WHERE 
        cr.user_id = @userid"

            Dim query As String = "
    SELECT 
        CourseRequests.course_id, 
        CourseRequests.paymemt_status,
        Courses.course_photo, 
        Courses.course_name, 
        Courses.course_id,
        CourseProgress.no_of_sec_completed, 
        Courses.sections
    FROM 
        CourseRequests
    JOIN 
        Courses ON CourseRequests.course_id = Courses.course_id
    LEFT JOIN 
        CourseProgress  ON CourseRequests.course_id = CourseProgress.course_id
    WHERE 
        CourseRequests.request_status = 1 
        AND CourseRequests.user_id = @userid"


            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@userid", userid)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        If (Convert.ToDouble(reader("paymemt_status"))) = 1 Then
                            courseId = reader.GetInt32("course_id")
                            Dim groupBox As New GroupBox()
                            groupBox.BackColor = ColorTranslator.FromHtml("#F5F5F5")
                            groupBox.Size = New Size(330, 100)
                            groupBox.Location = New Point((count Mod 3) * 350 + 40, Int(count / 3) * 110 + 155)
                            vertical = Int(count / 3) * 100 + 155
                            Dim picturebox As New PictureBox()
                            picturebox.Size = New Size(80, 80)
                            picturebox.Location = New Point(12, 12)
                            Dim photoData As Byte() = DirectCast(reader("course_photo"), Byte())
                            picturebox.SizeMode = PictureBoxSizeMode.Zoom
                            Dim image As Image = ByteArrayToImage(photoData)
                            picturebox.Image = image

                            Dim label As New Label()
                            label.Font = New Font("Arial", 8)
                            label.Location = New Point(picturebox.Width + 30, 15)
                            label.Text = reader("course_name").ToString()
                            label.Size() = New Size(200, 15)
                            Dim btn As New System.Windows.Forms.Button
                            btn.FlatStyle = FlatStyle.Flat
                            btn.FlatAppearance.BorderSize = 0
                            btn.BackColor = ColorTranslator.FromHtml("#0E91BA")
                            btn.Font = New Font("Arial", 6)
                            btn.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#0E91BA")
                            btn.Location = New Point(picturebox.Width + 30, 65)
                            btn.Size = New Size(70, 20)
                            btn.Text = "Resume"
                            btn.TextAlign = ContentAlignment.TopCenter

                            Dim gp1 As New GroupBox()
                            Dim gp2 As New GroupBox()
                            gp2.Size = New Size(200, 7)
                            gp2.BackColor = ColorTranslator.FromHtml("#CECACA")
                            Dim length = (Convert.ToDouble(reader("no_of_sec_completed")) / Convert.ToDouble(reader("sections"))) * 200
                            gp1.Size = New Size(Convert.ToInt32(length), 7)
                            gp1.BackColor = ColorTranslator.FromHtml("#35A955")
                            gp1.Location = New Point(picturebox.Width + 30, 45)
                            gp2.Location = New Point(picturebox.Width + 30, 45)

                            groupBox.Controls.Add(picturebox)
                            groupBox.Controls.Add(btn)
                            groupBox.Controls.Add(gp1)
                            groupBox.Controls.Add(gp2)
                            groupBox.Controls.Add(label)
                            AddHandler groupBox.MouseEnter, AddressOf GroupBox_MouseEnter
                            AddHandler groupBox.MouseLeave, AddressOf GroupBox_MouseLeave
                            AddHandler btn.Click, Sub() resume_click(courseId)


                            If length < 200 Then
                                Me.Controls.Add(groupBox)
                                count = count + 1
                            End If
                        End If

                    End While
                End Using
            End Using


            Using command As New MySqlCommand(query4, conn)
                command.Parameters.AddWithValue("@userid", userid)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        s1 = reader("Name")
                    End While
                End Using
            End Using
            Dim label2 As New Label()
            label2.Location = New Point(48, vertical + 130)
            label2.Size = New Size(90, 21)
            label2.Font = New Font("Regular", 8)
            label2.Text = "Completed"
            label2.BackColor = ColorTranslator.FromHtml("#E4E4E4")
            Me.Controls.Add(label2)
            h = vertical
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@userid", userid)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        If (Convert.ToDouble(reader("paymemt_status"))) = 1 Then


                            If Convert.ToDouble(reader("no_of_sec_completed")) = Convert.ToDouble(reader("sections")) Then
                                Dim groupBox As New GroupBox()
                                Dim picturebox As New PictureBox()
                                picturebox.Size = New Size(80, 80)
                                picturebox.Location = New Point(12, 12)
                                picturebox.SizeMode = PictureBoxSizeMode.Zoom
                                Dim photoData As Byte() = DirectCast(reader("course_photo"), Byte())
                                Dim image As Image = ByteArrayToImage(photoData)
                                picturebox.Image = image
                                groupBox.BackColor = ColorTranslator.FromHtml("#F5F5F5")
                                Dim label As New Label()
                                'label.Text = "Course title"
                                label.Font = New Font("Arial", 8)
                                label.Location = New Point(2, 160)
                                label.Text = reader("course_name").ToString()
                                label.Font = New Font("Arial", 8)
                                label.Location = New Point(picturebox.Width + 30, 15)

                                groupBox.Location = New Point((count1 Mod 3) * 350 + 40, Int(count1 / 3) * 110 + h + 155)  ' Adjust location as needed
                                groupBox.Size = New Size(330, 100)  ' Adjust size as needed

                                vertical = Int(count1 / 3) * 100 + 155 + h
                                Dim gp2 As New GroupBox()
                                gp2.Size = New Size(200, 7)
                                gp2.BackColor = ColorTranslator.FromHtml("#35A955")
                                gp2.Location = New Point(picturebox.Width + 30, 45)
                                groupBox.Controls.Add(gp2)
                                groupBox.Controls.Add(label)
                                groupBox.Controls.Add(picturebox)

                                Dim btn As New System.Windows.Forms.Button
                                btn.FlatStyle = FlatStyle.Flat

                                btn.FlatAppearance.BorderSize = 0
                                btn.BackColor = ColorTranslator.FromHtml("#1AE879")
                                btn.Font = New Font("Arial", 6)
                                'btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255) ' Set to transparent'
                                btn.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#1AE879")
                                btn.Location = New Point(picturebox.Width + 30, 65)
                                ' btn.BackColor = ColorTranslator.FromHtml("#0E91BA")
                                btn.Size = New Size(70, 20)

                                btn.Text = "Certificate"
                                btn.TextAlign = ContentAlignment.TopCenter
                                Dim c_i As Integer
                                s3 = reader("course_name").ToString()
                                c_i = reader("course_id")
                                AddHandler btn.Click,
                                Sub()
                                    Try
                                        conn1.Open()
                                        Using cmd As New MySqlCommand(query3, conn1)
                                            cmd.Parameters.AddWithValue("@par", c_i)
                                            Using read As MySqlDataReader = cmd.ExecuteReader()
                                                While read.Read()
                                                    s2 = read("name")
                                                End While
                                            End Using
                                        End Using
                                    Catch ex As Exception
                                        ' Handle exceptions
                                    Finally
                                        conn1.Close()
                                    End Try
                                End Sub
                                groupBox.Controls.Add(btn)

                                AddHandler btn.Click, AddressOf Certificate_click
                                AddHandler groupBox.MouseEnter, AddressOf GroupBox_MouseEnter
                                AddHandler groupBox.MouseLeave, AddressOf GroupBox_MouseLeave
                                ' Add the GroupBox control to the form.
                                Me.Controls.Add(groupBox)
                                count1 = count1 + 1

                            End If

                        End If
                    End While
                End Using
            End Using

            h = vertical
            Dim label3 As New Label()
            label3.Location = New Point(48, h + 150)
            label3.Size = New Size(122S, 21)
            label3.Font = New Font("Regular", 8)
            label3.Text = "Requests Sent"
            label3.BackColor = ColorTranslator.FromHtml("#E4E4E4")
            Me.Controls.Add(label3)
            h = vertical
            h = h + 10

            Using command As New MySqlCommand(query2, conn)
                command.Parameters.AddWithValue("@userid", userid)
                Using reader As MySqlDataReader = command.ExecuteReader()

                    While reader.Read()
                        If (Convert.ToDouble(reader("paymemt_status"))) = 0 Then
                            Dim groupBox As New GroupBox()
                            Dim picturebox As New PictureBox()
                            Dim label As New Label
                            label.Text = reader("course_name").ToString()
                            label.Font = New Font("Arial", 8)
                            label.Location = New Point(2, 120)
                            label.AutoSize = False ' Set AutoSize to False
                            label.Width = 120 ' Set the width of the label
                            label.Height = 40
                            picturebox.Size = New Size(120, 120)  ' Set image size
                            picturebox.Location = New Point(0, 0)
                            picturebox.SizeMode = PictureBoxSizeMode.Zoom
                            Dim photoData As Byte() = DirectCast(reader("course_photo"), Byte())
                            Dim image As Image = ByteArrayToImage(photoData)
                            picturebox.Image = image


                            Dim btn As New System.Windows.Forms.Button
                            btn.FlatStyle = FlatStyle.Flat
                            btn.FlatAppearance.BorderSize = 0
                            Dim req As Integer
                            If Convert.ToDouble(reader("request_status")) Then
                                req = 1
                                btn.Text = "PAY"
                                btn.BackColor = ColorTranslator.FromHtml("#0E91BA")
                                label.BackColor = ColorTranslator.FromHtml("#1AE879")
                            Else
                                req = 0
                                btn.Text = "PAY"
                                btn.BackColor = ColorTranslator.FromHtml("#A2DDF0")
                                label.BackColor = ColorTranslator.FromHtml("#FC0404")
                            End If

                            btn.Font = New Font("Arial", 6)
                            'btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255) ' Set to transparent'
                            btn.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#1AE879")
                            btn.Location = New Point(32, 170)
                            ' btn.BackColor = ColorTranslator.FromHtml("#0E91BA")
                            btn.Size = New Size(60, 20)

                            btn.TextAlign = ContentAlignment.TopCenter
                            groupBox.Controls.Add(btn)
                            groupBox.Controls.Add(picturebox)
                            groupBox.Controls.Add(label)
                            groupBox.Location = New Point((count2 Mod 6) * 220 + 48, Int(count2 / 6) * 250 + h + 160)
                            vertical = Int(count2 / 3) * 100 + 155 + h
                            groupBox.Size = New Size(120, 200)  ' Adjust size as needed
                            groupBox.Controls.Add(picturebox)
                            Me.Controls.Add(groupBox)
                            count2 = count2 + 1
                            AddHandler btn.Click,
                            Sub()
                                If req Then
                                    MessageBox.Show("You are being directed to payment")

                                Else
                                    MessageBox.Show("Your request is under process")
                                End If
                            End Sub
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions
        Finally

            conn.Close()
        End Try
    End Sub
    Private Sub Certificate_click()
        mypanel.panel1.Controls.Clear()
        Dim form As New certificate()
        form.SetUserID(userid)
        form.SetUserName(s3)
        form.SetInstName(s2)
        form.SetcourcetName(s1)
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub GroupBox_MouseEnter(sender As Object, e As EventArgs)
        ' Change the color of the GroupBox when the mouse enters
        Dim groupBox As GroupBox = DirectCast(sender, GroupBox)
        groupBox.BackColor = ColorTranslator.FromHtml("#E4E4E4") ' Change to desired color
    End Sub

    ' Event handler for dynamically created GroupBox controls' MouseLeave event
    Private Sub GroupBox_MouseLeave(sender As Object, e As EventArgs)
        ' Change the color of the GroupBox back when the mouse leaves
        Dim groupBox As GroupBox = DirectCast(sender, GroupBox)
        groupBox.BackColor = SystemColors.Control ' Change back to default color or desired color
    End Sub
    Private Sub resume_click(courseId As Integer)
        mypanel.panel1.Controls.Clear()
        Dim form As New my_learning(courseId)
        ' form.SetUserID(userid)
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New allcourses_page()
        form.SetUserID(userid)

        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class
