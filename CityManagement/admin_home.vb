Imports System.IO
Imports MySql.Data.MySqlClient

Public Class admin_home
    Private OriginalSize As Size = Me.Size


    Dim idOfCurrentUser As Integer = Module1.CurrUserSID
    Dim connString As String = Module1.connString

    Dim conn As New MySqlConnection(connString)

    Private Sub complaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Close the current form
        ' Create an instance of election_dashboard form
        Panel1.Controls.Clear()
        Dim form As New election_dashboard
        form.TopLevel = False
        Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        Label1.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        Label1.Cursor = Cursors.Default
    End Sub

    Private Sub admin_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize PictureBox controls with null value
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox5.Image = Nothing
        PictureBox6.Image = Nothing

        ' Set font size for labels
        Label2.Font = New Font(Label2.Font.FontFamily, 9)
        Label3.Font = New Font(Label3.Font.FontFamily, 9)
        Label4.Font = New Font(Label4.Font.FontFamily, 9)
        Label5.Font = New Font(Label5.Font.FontFamily, 9)
        Label6.Font = New Font(Label6.Font.FontFamily, 9)
        Label7.Font = New Font(Label7.Font.FontFamily, 9)

        ' Load profile pictures from the database
        LoadProfilePictures()

        ' Check the designation of the current user and make Label8 visible accordingly
        Dim currentUserDesignation As String = GetDesignation(idOfCurrentUser)
        If currentUserDesignation = "Mayor" OrElse
           currentUserDesignation = "Education Minister" OrElse
           currentUserDesignation = "Health Minister" OrElse
           currentUserDesignation = "Finance Minister" OrElse
           currentUserDesignation = "Transport Minister" OrElse
           currentUserDesignation = "Home Minister" OrElse
           currentUserDesignation = "Owner" Then
            Label8.Visible = True
        Else
            Label8.Visible = False
        End If
    End Sub

    Private Sub LoadProfilePictures()
        Try
            ' Open the connection
            conn.Open()

            ' Define the SQL query to retrieve names, designations, and profile pictures from the User table
            Dim query As String = "SELECT Name, Designation, ProfilePic FROM User WHERE Designation IN ('Mayor', 'Education Minister', 'Health Minister', 'Finance Minister', 'Transport Minister', 'Home Minister')"

            ' Create MySqlCommand object
            Using cmd As New MySqlCommand(query, conn)
                ' Execute the command and create a data reader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Loop through the results
                    While reader.Read()
                        Dim nameValue As String = reader("Name").ToString()
                        Dim designationValue As String = reader("Designation").ToString()
                        Dim profilePicValue As Byte() = If(reader("ProfilePic") Is DBNull.Value, Nothing, DirectCast(reader("ProfilePic"), Byte()))

                        ' Display the profile picture in the corresponding PictureBox control based on designation
                        Select Case designationValue
                            Case "Mayor"
                                DisplayImage(profilePicValue, PictureBox1)
                                Label2.Text = $"{nameValue}{Environment.NewLine}{designationValue}"
                            Case "Education Minister"
                                DisplayImage(profilePicValue, PictureBox2)
                                Label3.Text = $"{nameValue}{Environment.NewLine}{designationValue}"
                            Case "Health Minister"
                                DisplayImage(profilePicValue, PictureBox3)
                                Label4.Text = $"{nameValue}{Environment.NewLine}{designationValue}"
                            Case "Transport Minister"
                                DisplayImage(profilePicValue, PictureBox4)
                                Label5.Text = $"{nameValue}{Environment.NewLine}{designationValue}"
                            Case "Finance Minister"
                                DisplayImage(profilePicValue, PictureBox5)
                                Label6.Text = $"{nameValue}{Environment.NewLine}{designationValue}"
                            Case "Home Minister"
                                DisplayImage(profilePicValue, PictureBox6)
                                Label7.Text = $"{nameValue}{Environment.NewLine}{designationValue}"
                        End Select
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading profile pictures: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub

    Private Sub DisplayImage(ByVal imageData As Byte(), ByVal pictureBox As PictureBox)
        Try
            ' Check if the image data is not null
            If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                ' Convert byte array to image
                Using ms As New MemoryStream(imageData)
                    Dim image As Image = Image.FromStream(ms)
                    ' Display the image in the PictureBox control
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                    pictureBox.Image = image
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error displaying image: " & ex.Message)
        End Try
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ' Open the corresponding form based on the designation of the current user
        Dim currentUserDesignation As String = GetDesignation(idOfCurrentUser)

        ' Check if the designation is Owner
        If currentUserDesignation = "Owner" Then
            Try
                ' Open the connection
                conn.Open()

                ' Define the query to fetch the Type and ID from the Institutes table based on Owner_ID (SID)
                Dim query As String = "SELECT Type, ID FROM Institutes WHERE Owner_ID = @UserId"

                Using command As New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@UserId", idOfCurrentUser)

                    ' Execute the query and get the result
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        Dim instituteType As String = reader("Type").ToString()
                        Dim instituteID As Integer = Convert.ToInt32(reader("ID"))

                        ' Open the corresponding form based on the institute type
                        Select Case instituteType
                            Case "Education"
                                Panel1.Controls.Clear()
                                Dim form As New EducationOwner(instituteID)
                                form.TopLevel = False
                                Panel1.Controls.Add(form)
                                form.Show()
                            Case "Hospital"
                                Panel1.Controls.Clear()
                                Dim form As New HospitalOwner(instituteID)
                                form.TopLevel = False
                                Panel1.Controls.Add(form)
                                form.Show()
                            Case "Law"
                                Panel1.Controls.Clear()
                                Dim form As New SHO(instituteID)
                                form.TopLevel = False
                                Panel1.Controls.Add(form)
                                form.Show()
                            Case "Finance"
                                Panel1.Controls.Clear()
                                Dim form As New MuncipalOffice(instituteID)
                                form.TopLevel = False
                                Panel1.Controls.Add(form)
                                form.Show()
                            Case "Transport"
                                Panel1.Controls.Clear()
                                Dim form As New TransportOfficer(instituteID)
                                form.TopLevel = False
                                Panel1.Controls.Add(form)
                                form.Show()
                            Case Else
                                MessageBox.Show("Unknown institute type")
                        End Select
                    End If

                    reader.Close()
                End Using
            Catch ex As Exception
                ' Handle exceptions
                MessageBox.Show("Error fetching institute type: " & ex.Message)
            Finally
                ' Close the connection
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        Else
            ' If the designation is not Owner, 
            Select Case currentUserDesignation
                Case "Mayor"
                    Panel1.Controls.Clear()
                    Dim form As New admin_Mayor()
                    form.TopLevel = False
                    Panel1.Controls.Add(form)
                    form.Show()
                Case "Education Minister"
                    Panel1.Controls.Clear()
                    Dim form As New EducationMinister()
                    form.TopLevel = False
                    Panel1.Controls.Add(form)
                    form.Show()
                Case "Health Minister"
                    Panel1.Controls.Clear()
                    Dim form As New HealthMinister()
                    form.TopLevel = False
                    Panel1.Controls.Add(form)
                    form.Show()
                Case "Finance Minister"
                    Panel1.Controls.Clear()
                    Dim form As New FinanceMinister()
                    form.TopLevel = False
                    Panel1.Controls.Add(form)
                    form.Show()
                Case "Transport Minister"
                    Panel1.Controls.Clear()
                    Dim form As New TransportMinister()
                    form.TopLevel = False
                    Panel1.Controls.Add(form)
                    form.Show()
                Case "Home Minister"
                    Panel1.Controls.Clear()
                    Dim form As New HomeMinister()
                    form.TopLevel = False
                    Panel1.Controls.Add(form)
                    form.Show()
            End Select
        End If
    End Sub




    Private Function GetDesignation(userId As Integer) As String
        Dim designation As String = ""
        Try
            ' Open connection
            conn.Open()

            ' Query to fetch designation from User table based on SID
            Dim query As String = "SELECT Designation FROM User WHERE SID = @UserId"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@UserId", userId)

                ' Execute the query and get the result
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    designation = result.ToString()
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error fetching designation: " & ex.Message)
        Finally
            ' Close connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        Return designation
    End Function

    Private Sub Administration_Click(sender As Object, e As EventArgs) Handles Administration.Click

    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label16.Click, Label18.Click, Label22.Click, Label17.Click, Label14.Click, Label15.Click, Label7.Click, Label13.Click, Label12.Click, Label20.Click, Label19.Click
        Dim clickedLabel As Label = DirectCast(sender, Label) ' Get the label that was clicked
        OpenNewFormWithLabelText(clickedLabel.Text)
    End Sub

    ' Function to open a new form with the input text
    Private Sub OpenNewFormWithLabelText(inputText As String)
        panel1.Controls.Clear()
        Dim form As New admin_Joblisting(inputText) ' Pass the text as input to the constructor of admin_Joblisting form
        form.TopLevel = False
        panel1.Controls.Add(form)
        form.Show()
    End Sub

End Class
