Imports MySql.Data.MySqlClient

Public Class listHospitals
    Dim connectionString As String = Module1.connString
    'Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim selection As String
    Dim userID As Integer = Module1.CurrUserSID
    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
        Dim specialisation As New specialisation()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(specialisation)
        End If
    End Sub

    Private Sub Guna2GradientTileButton2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2GradientTileButton3_Click(sender As Object, e As EventArgs)

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



    Private Sub listHospitals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Calculate the position and size of the previous form (specialisation)
        Dim prevForm As Form = Application.OpenForms("specialisation")
        If prevForm IsNot Nothing Then
            Dim prevFormBounds As Rectangle = prevForm.Bounds
            Dim overlap As Integer = 0 ' Adjust this value if you want some overlap

            ' Set the position and size of this form to overlap with the previous form
            Me.Bounds = New Rectangle(prevFormBounds.X, prevFormBounds.Y - Me.Height + overlap, prevFormBounds.Width, Me.Height)
        End If
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Query the Hospital table to fetch all rows
        Dim queryString As String = "SELECT name, location, contact,hos_id FROM hospitals"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            Dim yPos As Integer = 0 ' Initial Y position for the first row

            Try
                While reader.Read()
                    ' Create an instance of cListHospitals with data from the database
                    Dim hospitalName As String = reader("name").ToString()
                    Dim location As String = reader("location").ToString()
                    Dim contact As String = reader("contact").ToString()
                    Dim id As String = reader("hos_id").ToString()

                    Dim newHospital As New cListHospitals(hospitalName, location, contact, id)
                    newHospital.Location = New Point(0, yPos) ' Set the location of the newHospital control
                    Panel1.Controls.Add(newHospital) ' Add the newHospital control to Panel1

                    yPos += newHospital.Height + 20 ' Update the Y position for the next row
                End While
            Finally
                reader.Close()
            End Try
        End Using

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        selection = ComboBox1.SelectedItem

    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox3.TextChanged
        Dim text = Guna2TextBox3.Text
        Dim queryString As String = "SELECT name, location, contact,hos_id FROM hospitals"
        If (selection = "Location") Then
            queryString = "SELECT name, location, contact, hos_id FROM hospitals " &
                            "WHERE location LIKE '%" & text & "%';"
        Else
            queryString = "SELECT name, location, contact, hos_id FROM hospitals " &
                            "WHERE name LIKE '%" & text & "%';"
        End If

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            Dim yPos As Integer = 0 ' Initial Y position for the first row
            Panel1.Controls.Clear()
            Try
                While reader.Read()
                    ' Create an instance of cListHospitals with data from the database
                    Dim hospitalName As String = reader("name").ToString()
                    Dim location As String = reader("location").ToString()
                    Dim contact As String = reader("contact").ToString()
                    Dim id As String = reader("hos_id").ToString()

                    Dim newHospital As New cListHospitals(hospitalName, location, contact, id)
                    newHospital.Location = New Point(0, yPos) ' Set the location of the newHospital control
                    Panel1.Controls.Add(newHospital) ' Add the newHospital control to Panel1

                    yPos += newHospital.Height + 20 ' Update the Y position for the next row
                End While
            Finally
                reader.Close()
            End Try
        End Using
    End Sub

    Private Sub Guna2GradientTileButton3_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientTileButton3.Click
        Dim Health_Record_Tracker As New Health_Record_Tracker()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(Health_Record_Tracker)
        End If
    End Sub
End Class