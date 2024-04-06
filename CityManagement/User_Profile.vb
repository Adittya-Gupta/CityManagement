﻿Imports System.Text
Imports MySql.Data.MySqlClient

Public Class User_Profile
    'Dim connString As String = "server=localhost;userid=root;password=pwd;database=smart_city_management"
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim userDetailsTable As New DataTable()
    Dim notifications As New List(Of (Integer, String))()




    Private Sub User_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' The search box results should be hidden
        ListBox1.Visible = False
        AdminButton.Visible = False

        If User_Login.GlobalSID = 984697 Then
            AdminButton.Visible = True
        End If

        ' Check if loggedInUserID is valid
        If User_Login.GlobalSID <> -1 Then
            ' If loggedInUserID is valid, fetch user details and display them
            Dim userDetails As Dictionary(Of String, Object) = GetUserDetails(User_Login.GlobalSID)
            SIDLabel.Text = User_Login.GlobalSID

            ' Check if 'Name' field exists
            If userDetails.ContainsKey("Name") AndAlso Not IsDBNull(userDetails("Name")) Then
                NameLabel.Text = userDetails("Name")
            Else
                NameLabel.Text = "N/A"
            End If

            ' Check if 'Email' field exists
            If userDetails.ContainsKey("Email") AndAlso Not IsDBNull(userDetails("Email")) Then
                EmailLabel.Text = userDetails("Email")
            Else
                EmailLabel.Text = "N/A"
            End If

            ' Check if 'Gender' field exists
            If userDetails.ContainsKey("Gender") AndAlso Not IsDBNull(userDetails("Gender")) Then
                GenderLabel.Text = userDetails("Gender")
            Else
                GenderLabel.Text = "N/A"
            End If

            ' Check if 'ContactNo' field exists
            If userDetails.ContainsKey("ContactNo") AndAlso Not IsDBNull(userDetails("ContactNo")) Then
                ContactLabel.Text = userDetails("ContactNo")
            Else
                ContactLabel.Text = "N/A"
            End If

            ' Check if 'Designation' field exists
            If userDetails.ContainsKey("Designation") AndAlso Not IsDBNull(userDetails("Designation")) Then
                DesignationLabel.Text = userDetails("Designation")
            Else
                DesignationLabel.Text = "N/A"
            End If

            ' Check if 'DOB' field exists
            If userDetails.ContainsKey("DOB") AndAlso Not IsDBNull(userDetails("DOB")) Then
                DOBLabel.Text = userDetails("DOB")
            Else
                DOBLabel.Text = "N/A"
            End If

            ' Load profile picture
            If userDetails.ContainsKey("ProfilePic") Then
                Dim profilePicData As Byte() = TryCast(userDetails("ProfilePic"), Byte())
                If profilePicData IsNot Nothing Then
                    Dim ms As New System.IO.MemoryStream(profilePicData)
                    Dim originalImage As Image = Image.FromStream(ms)
                    ' Stretch the image within PictureBox
                    PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                    PictureBox2.Image = originalImage
                End If
            Else
                MessageBox.Show("User details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("User not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub User_Profile_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' Drawing lines
        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(Color.Gainsboro, 2)
        'g.DrawLine(pen, New Point(270, 100), New Point(270, 600))
        g.DrawLine(pen, New Point(40, 310), New Point(230, 310))
        g.DrawLine(pen, New Point(310, 255), New Point(820, 255))
    End Sub

    Private Sub User_Profile_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ' When the form is clicked, set focus to another control
        ListBox1.Visible = False
        EditProfileButton.Focus()
    End Sub

    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, PictureBox2.Width, PictureBox2.Height)
        PictureBox2.Region = New Region(path)
    End Sub


    Private Sub LoadNotifications()
        Try
            conn.Open()
            Dim query As String = "SELECT UserID, Type, Message FROM Notifications WHERE UserID = @UserID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", User_Login.GlobalSID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim userID As Integer = reader.GetInt32("UserID")
                        Dim type As Integer = reader.GetInt32("Type")
                        Dim message As String = reader.GetString("Message")
                        AddNotificationToPanel(message)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching notifications: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub



    ' Function to fetch user details and profile picture from database based on SID
    Private Function GetUserDetails(userID As Integer) As Dictionary(Of String, Object)
        Dim userDetails As New Dictionary(Of String, Object)()
        Try
            conn.Open()
            Dim query As String = "SELECT Name, EmailAddress, Gender, ContactNo, Designation, DOB, ProfilePic FROM User WHERE SID = @SID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SID", userID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    userDetails.Add("Name", reader("Name"))
                    userDetails.Add("Email", reader("EmailAddress"))
                    userDetails.Add("Gender", reader("Gender"))
                    userDetails.Add("ContactNo", reader("ContactNo"))
                    userDetails.Add("Designation", reader("Designation"))
                    userDetails.Add("DOB", reader("DOB"))
                    userDetails.Add("ProfilePic", If(Not IsDBNull(reader("ProfilePic")), DirectCast(reader("ProfilePic"), Byte()), Nothing))
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return userDetails
    End Function



    Private Function GetUserDetailsByPartialName(partialName As String) As DataTable
        Dim userDetailsTable As New DataTable()
        Try
            conn.Open()
            Dim query As String = "SELECT SID, Name, EmailAddress FROM User WHERE Name LIKE @PartialName LIMIT 3"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PartialName", "%" & partialName & "%")
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(userDetailsTable)
            End Using

            ' Capitalize names in the DataTable
            For Each row As DataRow In userDetailsTable.Rows
                row("Name") = row("Name").ToString().ToUpper()
            Next
        Catch ex As Exception
            MessageBox.Show("Error fetching user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return userDetailsTable
    End Function

    Private Sub SearchTextBox_GotFocus(sender As Object, e As EventArgs) Handles SearchTextBox.GotFocus
        Dim partialName As String = SearchTextBox.Text.Trim()
        ListBox1.Visible = True
        SearchTextBox_TextChanged(sender, e)
    End Sub

    'Private Sub SearchTextBox_LostFocus(sender As Object, e As EventArgs) Handles SearchTextBox.LostFocus
    ' Hide the ListBox when the search bar loses focus
    '   ListBox1.Visible = False
    'End Sub

    'Private Sub ListBox1_LostFocus(sender As Object, e As EventArgs) Handles ListBox1.LostFocus
    ' Clear the ListBox when focus is lost
    '   ListBox1.DataSource = Nothing
    '   ListBox1.Visible = False
    'End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim partialName As String = SearchTextBox.Text.Trim()
        Dim MaximumListBoxHeight As Integer = 1000
        Dim DefaultListBoxHeight As Integer = 5
        ListBox1.Visible = True
        'If partialName <> "" Then
        Dim userDetailsTable As DataTable = GetUserDetailsByPartialName(partialName)
        If userDetailsTable.Rows.Count > 0 Then
            ' Add a column for the full name to the DataTable
            'userDetailsTable.Columns.Add("FullName", GetType(String), "Name + ' - ' + EmailAddress")

            ' Display search results in ListBox
            ListBox1.DisplayMember = "Name" ' Set the display member to the "FullName" column
            ListBox1.ValueMember = "SID" ' Set the value member to the "SID" column
            ListBox1.DataSource = userDetailsTable ' Set the data source to the user details table

            ' Calculate the height of the ListBox based on the number of rows
            Debug.WriteLine(userDetailsTable.Rows.Count * ListBox1.ItemHeight)
            Dim listBoxHeight As Integer = Math.Min((userDetailsTable.Rows.Count + 1) * ListBox1.ItemHeight, MaximumListBoxHeight)
            ListBox1.Height = listBoxHeight
        Else
            ListBox1.DataSource = Nothing ' Clear the ListBox if no results found
            ListBox1.Height = DefaultListBoxHeight ' Set the ListBox height to default
        End If
        'Else
        'ListBox1.DataSource = Nothing ' Clear the ListBox if search text is empty
        'ListBox1.Height = DefaultListBoxHeight ' Set the ListBox height to default
        'End If
    End Sub








    'Private Sub ListBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseMove
    ' Get the index of the item at the current mouse position
    'Dim index As Integer = ListBox1.IndexFromPoint(e.Location)

    '   Debug.WriteLine("MouseMove Index: " & index) ' Debug statement

    ' Set the selected index to the item under the mouse cursor
    'If index <> ListBox1.SelectedIndex Then
    '       ListBox1.SelectedIndex = index
    'End If
    'End Sub

    Private Sub ListBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim selectedIndex As Integer = ListBox1.SelectedIndex
            If selectedIndex <> -1 Then
                ' Retrieve the selected DataRowView object
                Dim selectedDataRowView As DataRowView = DirectCast(ListBox1.Items(selectedIndex), DataRowView)

                ' Extract the necessary information from the DataRowView
                Dim userDetails As Dictionary(Of String, Object) = GetUserDetails(selectedDataRowView("SID"))

                ' Display user details in a message box
                Dim message As New StringBuilder()
                message.AppendLine("Name: " & userDetails("Name"))
                message.AppendLine("Email: " & userDetails("Email"))
                message.AppendLine("Gender: " & userDetails("Gender"))
                message.AppendLine("Contact No: " & userDetails("ContactNo"))
                message.AppendLine("Designation: " & userDetails("Designation"))
                message.AppendLine("DOB: " & userDetails("DOB"))

                ListBox1.Visible = False
                MessageBox.Show(message.ToString(), "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Set focus back to the search bar
                SearchTextBox.Focus()

            End If
        End If
    End Sub


    ' Function to add a notification to the FlowLayoutPanel
    Private Sub AddNotificationToPanel(notificationText As String)
        Dim notificationLabel As New Label()
        notificationLabel.Text = notificationText
        notificationLabel.AutoSize = False
        notificationLabel.Width = NotificationPanel.Width - 40 ' Set the width as needed
        notificationLabel.Height = 50 ' Set the height as needed
        notificationLabel.TextAlign = ContentAlignment.MiddleCenter
        notificationLabel.BackColor = Color.Gray
        notificationLabel.ForeColor = Color.White
        notificationLabel.Padding = New Padding(10) ' Add padding for better appearance


        ' Calculate the required height based on the text content
        Using g As Graphics = CreateGraphics()
            Dim textSize As SizeF = g.MeasureString(notificationText, notificationLabel.Font, notificationLabel.Width - notificationLabel.Padding.Horizontal)
            notificationLabel.Height = CInt(textSize.Height) + notificationLabel.Padding.Vertical
        End Using


        ' Apply rounded corners
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rectangle As Rectangle = New Rectangle(0, 0, notificationLabel.Width, notificationLabel.Height)
        Dim radius As Integer = 10 ' Adjust the radius as needed
        Dim diameter As Integer = radius * 2

        ' Corners
        path.AddArc(rectangle.X, rectangle.Y, diameter, diameter, 180, 90) ' Top left corner
        path.AddArc(rectangle.X + rectangle.Width - diameter, rectangle.Y, diameter, diameter, 270, 90) ' Top right corner
        path.AddArc(rectangle.X + rectangle.Width - diameter, rectangle.Y + rectangle.Height - diameter, diameter, diameter, 0, 90) ' Bottom right corner
        path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - diameter, diameter, diameter, 90, 90) ' Bottom left corner
        path.CloseAllFigures()

        ' Set rounded corners as the region of the label
        notificationLabel.Region = New Region(path)

        ' Set the location of the label based on the current count of controls in the panel
        Dim yPosition As Integer = 10 ' Initial y-position
        If NotificationPanel.Controls.Count > 0 Then
            ' If there are existing controls, calculate the y-position based on the bottom of the last control
            Dim lastControl As Control = NotificationPanel.Controls(NotificationPanel.Controls.Count - 1)
            yPosition = lastControl.Bottom + 10 ' Add spacing of 10 units
        End If
        notificationLabel.Location = New Point(10, yPosition) ' Start from X=10

        ' Add click event handler to navigate to the corresponding form
        AddHandler notificationLabel.Click, AddressOf NotificationLabel_Click

        NotificationPanel.Controls.Add(notificationLabel)
    End Sub





    ' Event handler for notification label click
    Private Sub NotificationLabel_Click(sender As Object, e As EventArgs)
        ' Perform action based on the clicked notification
        ' For example, redirect to a specific page
        MessageBox.Show("Notification Clicked!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Function to retrieve notifications from a list and add them to the FlowLayoutPanel


    Private Sub User_Profile_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Load notifications when the form is shown
        LoadNotifications()
    End Sub

    Private Sub EditProfileButton_Click(sender As Object, e As EventArgs) Handles EditProfileButton.Click
        mypanel.Panel1.Controls.Clear()
        Dim form As New User_EditProfile
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
        'form.Show()
        'form.StartPosition = FormStartPosition.Manual
        'form.Location = Location ' Set the location of the new form to the current form's location
        'form.Show()
    End Sub

    Private Sub ChangePasswordButton_Click(sender As Object, e As EventArgs) Handles ChangePasswordButton.Click
        Dim form As New UserProfile_ChangePassword
        form.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        ' Open the signup form when the label is clicked
        Dim LoginForm As New User_Login()
        Dim mainpanel As New MainPanel()
        LoginForm.StartPosition = FormStartPosition.Manual
        LoginForm.Location = mainpanel.Location ' Set the location of the new form to the current form's location
        LoginForm.Show()
        mainpanel.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AdminButton.Click
        mypanel.Panel1.Controls.Clear()
        Dim form As New User_Admin
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

End Class