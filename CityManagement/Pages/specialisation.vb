Imports MySql.Data.MySqlClient
Imports Windows.Media.Capture

Public Class specialisation
    Shared spec As String = ""
    Shared rate As String = ""
    Shared gin As String = ""
    Dim connectionString As String = Module1.connString
    'Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim userID As Integer = Module1.CurrUserSID

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
    End Sub

    Private Sub Guna2GradientTileButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton2.Click
        Dim listHospitals As New listHospitals()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(listHospitals)
        End If
    End Sub

    Private Sub Guna2GradientTileButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton3.Click
        Dim Health_Record_Tracker As New Health_Record_Tracker()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(Health_Record_Tracker)
        End If
    End Sub

    Public Function GetUserDesignation(ByVal userID As Integer) As String

        ' SQL query to fetch user designation based on userID
        Dim query As String = "SELECT Designation FROM User WHERE SID = @UserID"

        ' Initialize designation variable
        Dim designation As String = Nothing

        ' Create connection and command objects
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@UserID", userID)

                Try
                    ' Open connection
                    connection.Open()

                    ' Execute command and get the result
                    designation = Convert.ToString(command.ExecuteScalar())
                Catch ex As Exception
                    ' Handle any errors here
                    MessageBox.Show("Error fetching user designation: " & ex.Message)
                End Try
            End Using
        End Using

        ' Return the designation
        Return designation
    End Function

    Private Sub Guna2GradientTileButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton4.Click
        Dim designation As String = GetUserDesignation(userID)
        'MessageBox.Show(designation)

        ' Check the designation
        Select Case designation
            Case "Doctor"
                Dim Health_ViewAppointment As New Health_ViewAppointment()
                ' Get the instance of MainForm (assuming MainForm is the parent form)
                Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)
                ' Check if the main form instance is not null
                If MainPanel IsNot Nothing Then
                    ' Call the public method of the main form to show the child form in the panel
                    MainPanel.ShowChildFormInPanel(Health_ViewAppointment)
                End If
            Case "Hospital Owner"
                Dim Health_Doctor_Employment_Requests As New Health_Doctor_Employment_Requests()
                Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)
                If MainPanel IsNot Nothing Then
                    MainPanel.ShowChildFormInPanel(Health_Doctor_Employment_Requests)
                End If
            Case Else
                MessageBox.Show("You are not employed.")
        End Select
    End Sub
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub


    Private Sub Panel1_Paint(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim queryString As String = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id "

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            Dim yPos As Integer = 0 ' Initial Y position for the first row
            Dim componentCount As Integer = 0 ' Counter for components in the current row

            Try
                While reader.Read()
                    ' Create an instance of cMakeAppointment with data from the database
                    Dim dName As String = reader("Name").ToString()
                    Dim hName As String = reader("name").ToString()
                    Dim experience As String = reader("experience").ToString()
                    Dim location As String = reader("location").ToString()
                    Dim contact As String = reader("contact").ToString()
                    Dim gender As String = reader("Gender").ToString()
                    Dim rating As String = reader("rating").ToString()


                    ' Create and position the cMakeAppointment component
                    Dim cspec As New cspecialisation(dName, hName, gender, experience, location, contact, rating)
                    cspec.Location = New Point(0, yPos) ' Set the location of the newHospital control
                    Panel1.Controls.Add(cspec) ' Add the newHospital control to Panel1

                    yPos += cspec.Height + 20 ' Update the Y position for the next row
                End While
            Finally
                reader.Close()
            End Try
        End Using
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        spec = ComboBox2.SelectedItem

        Dim queryString As String
        If (spec <> "" And gin <> "" And rate <> "") Then


            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.speciality = @spec and D.rating >= @rate and U.Gender=@gin;"


        ElseIf (spec <> "" And gin <> "" And rate = "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.speciality = @spec and U.Gender=@gin;"

        ElseIf (spec <> "" And gin = "" And rate <> "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.speciality = @spec and D.rating >= @rate;"

        ElseIf (spec = "" And gin <> "" And rate <> "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE  D.rating >= @rate and U.Gender=@gin;"

        ElseIf (spec = "" And gin = "" And rate <> "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.rating >= @rate;"

        ElseIf (spec <> "" And gin = "" And rate = "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.speciality = @spec ;"

        ElseIf (spec = "" And gin <> "" And rate = "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE U.Gender=@gin;"




        End If
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@gin", gin)
            command.Parameters.AddWithValue("@spec", spec)
            If (rate <> "") Then command.Parameters.AddWithValue("@rate", Convert.ToInt32(rate))

            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            Dim yPos As Integer = 0 ' Initial Y position for the first row
            Dim componentCount As Integer = 0 ' Counter for components in the current row
            Panel1.Controls.Clear()
            Try
                While reader.Read()
                    ' Create an instance of cMakeAppointment with data from the database
                    Dim dName As String = reader("Name").ToString()
                    Dim hName As String = reader("name").ToString()
                    Dim experience As String = reader("experience").ToString()
                    Dim location As String = reader("location").ToString()
                    Dim contact As String = reader("contact").ToString()
                    Dim gender As String = reader("Gender").ToString()
                    Dim rating As String = reader("rating").ToString()


                    ' Create and position the cMakeAppointment component
                    Dim cspec As New cspecialisation(dName, hName, gender, experience, location, contact, rating)
                    cspec.Location = New Point(0, yPos) ' Set the location of the newHospital control
                    Panel1.Controls.Add(cspec) ' Add the newHospital control to Panel1

                    yPos += cspec.Height + 20 ' Update the Y position for the next row
                End While
            Finally
                reader.Close()
            End Try
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        rate = ComboBox1.SelectedItem

        Dim queryString As String
        If (spec <> "" And gin <> "" And rate <> "") Then


            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.speciality = @spec and D.rating >= @rate and U.Gender=@gin;"



        ElseIf (spec <> "" And gin <> "" And rate = "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.speciality = @spec and U.Gender=@gin;"

        ElseIf (spec <> "" And gin = "" And rate <> "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.speciality = @spec and D.rating >= @rate;"

        ElseIf (spec = "" And gin <> "" And rate <> "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE  D.rating >= @rate and U.Gender=@gin;"

        ElseIf (spec = "" And gin = "" And rate <> "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.rating >= @rate;"

        ElseIf (spec <> "" And gin = "" And rate = "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.speciality = @spec ;"

        ElseIf (spec = "" And gin <> "" And rate = "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE U.Gender=@gin;"


        End If
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@gin", gin)
            command.Parameters.AddWithValue("@spec", spec)
            If (rate <> "") Then command.Parameters.AddWithValue("@rate", Convert.ToInt32(rate))

            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            Dim yPos As Integer = 0 ' Initial Y position for the first row
            Dim componentCount As Integer = 0 ' Counter for components in the current row
            Panel1.Controls.Clear()
            Try
                While reader.Read()
                    ' Create an instance of cMakeAppointment with data from the database
                    Dim dName As String = reader("Name").ToString()
                    Dim hName As String = reader("name").ToString()
                    Dim experience As String = reader("experience").ToString()
                    Dim location As String = reader("location").ToString()
                    Dim contact As String = reader("contact").ToString()
                    Dim gender As String = reader("Gender").ToString()
                    Dim rating As String = reader("rating").ToString()


                    ' Create and position the cMakeAppointment component
                    Dim cspec As New cspecialisation(dName, hName, gender, experience, location, contact, rating)
                    cspec.Location = New Point(0, yPos) ' Set the location of the newHospital control
                    Panel1.Controls.Add(cspec) ' Add the newHospital control to Panel1

                    yPos += cspec.Height + 20 ' Update the Y position for the next row
                End While
            Finally
                reader.Close()
            End Try
        End Using
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        gin = ComboBox3.SelectedItem

        Dim queryString As String
        If (spec <> "" And gin <> "" And rate <> "") Then


            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.speciality = @spec and D.rating >= @rate and U.Gender=@gin;"

        ElseIf (spec <> "" And gin <> "" And rate = "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.speciality = @spec and U.Gender=@gin;"
        ElseIf (spec <> "" And gin = "" And rate <> "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.speciality = @spec and D.rating >= @rate;"
        ElseIf (spec = "" And gin <> "" And rate <> "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE  D.rating >= @rate and U.Gender=@gin;"
        ElseIf (spec = "" And gin = "" And rate <> "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.rating >= @rate;"
        ElseIf (spec <> "" And gin = "" And rate = "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE D.speciality = @spec ;"
        ElseIf (spec = "" And gin <> "" And rate = "") Then
            queryString = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, U.Name, U.Gender, H.name, H.location, H.contact " &
                            "FROM Doctors D " &
                            "INNER JOIN User U ON D.user_id = U.SID " &
                            "INNER JOIN hospitals H ON D.hos_id = H.hos_id " &
                            "WHERE U.Gender=@gin;"

        End If
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@gin", gin)
            command.Parameters.AddWithValue("@spec", spec)
            If (rate <> "") Then command.Parameters.AddWithValue("@rate", Convert.ToInt32(rate))
            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            Dim yPos As Integer = 0 ' Initial Y position for the first row
            Dim componentCount As Integer = 0 ' Counter for components in the current row
            Panel1.Controls.Clear()
            Try
                While reader.Read()
                    ' Create an instance of cMakeAppointment with data from the database
                    Dim dName As String = reader("Name").ToString()
                    Dim hName As String = reader("name").ToString()
                    Dim experience As String = reader("experience").ToString()
                    Dim location As String = reader("location").ToString()
                    Dim contact As String = reader("contact").ToString()
                    Dim gender As String = reader("Gender").ToString()
                    Dim rating As String = reader("rating").ToString()


                    ' Create and position the cMakeAppointment component
                    Dim cspec As New cspecialisation(dName, hName, gender, experience, location, contact, rating)
                    cspec.Location = New Point(0, yPos) ' Set the location of the newHospital control
                    Panel1.Controls.Add(cspec) ' Add the newHospital control to Panel1

                    yPos += cspec.Height + 20 ' Update the Y position for the next row
                End While
            Finally
                reader.Close()
            End Try
        End Using
    End Sub
End Class