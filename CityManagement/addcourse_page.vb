Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Bcpg
Imports System.Collections.Specialized.BitVector32
Imports System.IO

Public Class addcourse_page

    Private userid As Integer

    Public Sub SetUserID(id As Integer)
        userid = id
    End Sub

    Dim description As New TextBox
    Dim link As New TextBox
    Dim count As Integer = 1
    Private buttonStack As New Stack(Of Button)()
    Private lastButton As Button
    Dim present_section As Integer = 1
    Dim selectedSections As New List(Of Tuple(Of String, String))
    Private sectionVideoPath As String
    Private sectionDescription As String
    Private Sub addcourse_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1107, 786)
        Me.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
        Dim groupbox As New GroupBox()
        groupbox.BackColor = ColorTranslator.FromHtml("#D9D9D9")
        groupbox.Location = New Point(80, 270)
        groupbox.Size = New Size(620, 400)

        Dim buton1 As New Button() 'video
        Dim buton2 As New Button() 'delete course
        Dim buton3 As New Button() 'add course
        Dim button4 As New Button() 'add section
        Dim button5 As New Button() 'delete section
        Dim label3 As New Label()   'descrition label

        buton1.Location = New Point(900, 700)
        Dim video_link As New Label()
        video_link.Text = "Video"
        video_link.Font = New Font("Segoe UI", 12)
        video_link.BackColor = ColorTranslator.FromHtml("#0642DE")
        video_link.Size() = New Size(70, 40)
        video_link.Location = New Point(95, 40)

        buton2.Text = "Delete Course"
        buton2.Font = New Font("Segoe UI", 10)
        buton2.BackColor = ColorTranslator.FromHtml("#FC0404")
        buton2.Size() = New Size(150, 40)
        buton2.Location = New Point(80, 680)


        buton3.Text = "Add Course"
        buton3.Font = New Font("Segoe UI", 10)
        buton3.BackColor = ColorTranslator.FromHtml("#04FC2C")
        buton3.Size() = New Size(150, 40)
        buton3.Location = New Point(900, 680)

        button4.Location = New Point(420, 320)
        button4.Text = "Add Section"
        button4.Font = New Font("Segoe UI", 10)
        button4.BackColor = ColorTranslator.FromHtml("#04FC2C")
        button4.Size() = New Size(135, 40)

        button5.Location = New Point(50, 320)
        button5.Text = "Delete Section"
        button5.Font = New Font("Segoe UI", 10)
        button5.BackColor = ColorTranslator.FromHtml("#FC0404")
        button5.Size() = New Size(155, 40)


        label3.Text = "Description    "
        label3.Font = New Font("Segoe UI", 10)
        label3.Location = New Point(70, 120)
        label3.Size() = New Size(120, 40)


        link.Location = New Point(300, 50)
        link.MaxLength = 1000
        link.Multiline = True
        link.Size = New Size(300, 30)
        description.Location = New Point(300, 120)
        description.Multiline = True
        description.Size = New Size(300, 100)

        groupbox.Controls.Add(video_link)
        groupbox.Controls.Add(label3)
        groupbox.Controls.Add(button4)
        groupbox.Controls.Add(button5)
        groupbox.Controls.Add(description)
        groupbox.Controls.Add(link)



        Me.Controls.Add(buton2)
        Me.Controls.Add(buton3)
        Me.Controls.Add(groupbox)
        Panel.AutoScroll = True
        Addbuttontopanel()

        AddHandler button4.Click, AddressOf button4_click_handler
        AddHandler buton3.Click, AddressOf button3_Click
        AddHandler Button2.Click, AddressOf Button2_click_handler
        AddHandler buton2.Click, AddressOf function_redirect

        AddHandler button5.Click,
        Sub()

            count = count - 1
            If selectedSections.Count = 0 Then
                MessageBox.Show("There are no sections added to delete")
                Return
            End If

            ' Prompt the user to confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this section?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' Remove the section from selectedSections based on the present_section
                If present_section <= selectedSections.Count Then
                    selectedSections.RemoveAt(present_section - 1)
                End If

                ' Remove the button from Panel
                If buttonStack.Count > 0 Then
                    Dim buttonToRemove As Button = buttonStack.Pop()
                    Panel.Controls.Remove(buttonToRemove)
                End If

                ' Decrement count and present_section

                present_section -= 1

                ' Update the textboxes if present_section is not equal to count - 1
                If present_section <> count - 1 Then
                    section_button(present_section)
                Else
                    description.Text = ""
                    link.Text = ""
                End If
            End If

        End Sub

    End Sub



    Private Sub Addbuttontopanel()
        Dim b As New Button()
        b.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        b.Text = "Section " & count.ToString()
        b.Location = New Point(35, (count - 1) * 50 + 10)
        count = count + 1
        b.Size = New Size(120, 40)
        Panel.Controls.Add(b)
        buttonStack.Push(b)
        AddHandler b.Click,
         Sub()
             section_button(1)
         End Sub
    End Sub
    Private Sub Button2_click_handler(sender As Object, e As EventArgs) 'Course Image
        ' Show OpenFileDialog to select an image
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim imagePath As String = openFileDialog.FileName

            ' Load and display the selected image in the PictureBox
            Dim originalImage As New Bitmap(imagePath)
            Dim newWidth As Integer = 90
            Dim newHeight As Integer = 90
            Dim resizedImage As New Bitmap(newWidth, newHeight)
            Using g As Graphics = Graphics.FromImage(resizedImage)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight)
            End Using
            originalImage.Dispose()
            PictureBox1.Image = resizedImage
        End If
        ' Convert the selected image to byte array
        ' Continue with your code using the imageBytes array
    End Sub


    Private Sub button4_click_handler(sender As Object, e As EventArgs) 'ADD Section
        If link.Text = "" Then
            MessageBox.Show("Please give link of video")
            Return
        End If
        If description.Text = "" Then
            MessageBox.Show("Please give secction description")
            Return
        End If
        sectionDescription = description.Text
        sectionVideoPath = link.Text
        selectedSections.Add(New Tuple(Of String, String)(sectionVideoPath, sectionDescription))
        Dim b As New Button()
        b.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        b.Text = "Section " & count.ToString()
        b.Location = New Point(35, (count - 1) * 50 + 10)
        present_section = count
        count = count + 1
        b.Size = New Size(120, 40)
        Panel.Controls.Add(b)
        buttonStack.Push(b)

        ' Capture the current value of count inside the lambda expression
        Dim currentCount As Integer = count
        description.Text = ""
        link.Text = ""
        description.Text = ""
        ' Add a click event handler using a lambda expression
        AddHandler b.Click,
        Sub()
            section_button(currentCount - 1)
        End Sub

    End Sub

    Private Sub section_button(ByVal myInteger As Integer)
        ' Use the passed parameter directly
        present_section = myInteger
        Dim sectionIndex As Integer = present_section - 1
        If sectionIndex = -1 Then
            link.Text = ""
            description.Text = ""
            Return
        End If
        If present_section = count - 1 Then
            description.Text = ""
            link.Text = ""
        Else
            Dim section As Tuple(Of String, String) = selectedSections(sectionIndex)
            link.Text = section.Item1
            ' Display description in textbox
            description.Text = section.Item2
        End If
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(TextBox1.Text) OrElse
        String.IsNullOrEmpty(TextBox2.Text) OrElse
        String.IsNullOrEmpty(TextBox3.Text) OrElse
        String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If
        Dim price As Decimal
        If Not Decimal.TryParse(TextBox4.Text, price) Then
            MessageBox.Show("Please enter a valid price.")
            Return
        End If
        Dim li As Decimal
        If Not Decimal.TryParse(TextBox3.Text, li) Then
            MessageBox.Show("Please enter a valid limit.")
            Return
        End If
        If selectedSections.Count = 0 Then
            MessageBox.Show("Please add atleast one section")
            Return
        End If

        Dim imageBytes As Byte()
        Using ms As New MemoryStream()
            ' Check if PictureBox1.Image is not null before saving
            If PictureBox1.Image IsNot Nothing Then
                ' Save the image with a specific format (e.g., PNG)
                PictureBox1.Image.Save(ms, Imaging.ImageFormat.Png)
                ' Convert the MemoryStream to byte array
                imageBytes = ms.ToArray()
            Else
                ' Handle the case when PictureBox1.Image is null
                MessageBox.Show("PictureBox1.Image is null.")
                ' Return or exit the method since there's no image to save
                Return
            End If
        End Using
        Dim connstrig As String = Module1.connString
        Dim conn As New MySqlConnection(connstrig)
        Try
            conn.Open()
            Dim rowCount As Integer = 0
            Dim sqlRowCount As String = "SELECT COUNT(*) FROM Courses"
            Dim commandRowCount As New MySqlCommand(sqlRowCount, conn)
            rowCount = Convert.ToInt32(commandRowCount.ExecuteScalar())
            Dim sqlInsert As String = "INSERT INTO Courses (`course_id`, `user_id`, `course_name`, `course_description`, `course_photo`, `sections`, `no_of_studenroll`, `limit`, `rating`,`course_price`) " &
                              "VALUES (@c_id, @u_id, @c_name, @c_description, @c_photo, @sec, @no_of_s, @l, @r,@price)"
            Dim commandInsert As New MySqlCommand(sqlInsert, conn)
            commandInsert.Parameters.AddWithValue("@c_id", rowCount + 1)
            commandInsert.Parameters.AddWithValue("@u_id", userid)
            commandInsert.Parameters.AddWithValue("@c_name", TextBox1.Text)
            commandInsert.Parameters.AddWithValue("@c_description", TextBox2.Text)
            commandInsert.Parameters.AddWithValue("@c_photo", imageBytes)
            commandInsert.Parameters.AddWithValue("@sec", selectedSections.Count)
            commandInsert.Parameters.AddWithValue("@no_of_s", 0)
            commandInsert.Parameters.AddWithValue("@l", TextBox3.Text)
            commandInsert.Parameters.AddWithValue("@r", 0)
            commandInsert.Parameters.AddWithValue("@price", TextBox4.Text)
            commandInsert.ExecuteNonQuery()
            Dim row As Integer = 1

            For Each section As Tuple(Of String, String) In selectedSections
                Dim query As String = "INSERT INTO CourseData (`course_id`,`section_id`,`section_description`,`section_video`) " &
                          "VALUES (@c_id,@section,@sec_des,@sec_vide)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@c_id", rowCount + 1)
                    cmd.Parameters.AddWithValue("@section", row)
                    cmd.Parameters.AddWithValue("@sec_des", section.Item2)
                    cmd.Parameters.AddWithValue("@sec_vide", section.Item1)
                    row = row + 1
                    cmd.ExecuteNonQuery()
                End Using
            Next
            MessageBox.Show("Course added succesfully")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        function_redirect()

    End Sub
    Private Sub function_redirect()
        mypanel.panel1.Controls.Clear()
        Dim form As New education_landing()
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New professor_dashboard()
        form.SetUserID(userid)
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub


End Class
