Imports MySql.Data.MySqlClient
Imports Windows.Media.Capture

Public Class specialisation
    Dim spec As String = ""
    Dim rate As String = ""
    Dim gin As String = ""
    Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"

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

    End Sub


    Private Sub Guna2GradientTileButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton4.Click
        Dim Health_ViewAppointment As New Health_ViewAppointment()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(Health_ViewAppointment)
        End If
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
            'command.Parameters.AddWithValue("@gin", gin)
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