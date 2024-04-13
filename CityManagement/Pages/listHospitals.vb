Imports MySql.Data.MySqlClient

Public Class listHospitals
    Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
        Dim specialisation As New specialisation()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim Temp2 As Temp2 = CType(Application.OpenForms("Temp2"), Temp2)

        ' Check if the main form instance is not null
        If Temp2 IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            Temp2.ShowChildFormInPanel(specialisation)
        End If
    End Sub

    Private Sub Guna2GradientTileButton2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2GradientTileButton3_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Guna2GradientTileButton4_Click(sender As Object, e As EventArgs)
        Dim Health_ViewAppointment As New Health_ViewAppointment()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim Temp2 As Temp2 = CType(Application.OpenForms("Temp2"), Temp2)

        ' Check if the main form instance is not null
        If Temp2 IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            Temp2.ShowChildFormInPanel(Health_ViewAppointment)
        End If
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

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub
End Class