Imports MySql.Data.MySqlClient

Public Class Health_ViewAppointment

    Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"

    Dim listView1 As New ListView()
    Private Sub Health_ViewAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listView1.Name = "listView1"
        listView1.Width = 1000 ' Set width to 1150
        listView1.View = View.Details ' Set view to Details mode
        listView1.FullRowSelect = True ' Select entire row when clicked
        'listView1.BorderStyle = BorderStyle.None
        listView1.Font = New Font("Arial", 14)
        listView1.Columns.Add("Appointment ID", 175)
        listView1.Columns.Add("Patient Name", 330)
        listView1.Columns.Add("Gender", 120)
        listView1.Columns.Add("Date", 200)
        listView1.Columns.Add("Time", 170)
        listView1.BackColor = ColorTranslator.FromHtml("#F5F1F1")
        listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable ' Make column headers non-clickable
        listView1.HideSelection = True ' Remove highlighting effect after clicking

        Dim queryString As String = "SELECT appointment_id, user_id, DATE(date) as date, time FROM hospitalAppointment"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            Try
                While reader.Read()
                    Dim userId As String = reader("user_id").ToString()
                    Dim userDetails As String() = GetUserDetails(userId, connectionString).Split(",")
                    Dim row As New ListViewItem(New String() {reader("appointment_id").ToString(), userDetails(0), userDetails(1), Convert.ToDateTime(reader("date")).ToString("yyyy-MM-dd"), reader("time").ToString()})
                    listView1.Items.Add(row)
                End While
            Finally
                reader.Close()
            End Try
        End Using

        ' Set the location of the ListView
        listView1.Location = New Point(44, 130) ' Set location to (30, 200)



        ' Set the ListView's height to fit its content
        listView1.Height = (500) ' Add some extra space for aesthetics

        ' Add the ListView to the form
        Me.Controls.Add(listView1)

        ' Bring the ListView to the front
        listView1.BringToFront()
    End Sub

    Private Function GetUserDetails(userId As String, connectionString As String) As String
        Dim queryString As String = "SELECT Name, Gender FROM User WHERE SID = @userId"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@userId", userId)
            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                Return String.Format("{0},{1}", reader("Name"), reader("Gender"))
            Else
                Return "User details not found"
            End If
        End Using
    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim specialisation As New specialisation()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim Temp2 As Temp2 = CType(Application.OpenForms("Temp2"), Temp2)

        ' Check if the main form instance is not null
        If Temp2 IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            Temp2.ShowChildFormInPanel(specialisation)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim listHospitals As New listHospitals()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim Temp2 As Temp2 = CType(Application.OpenForms("Temp2"), Temp2)

        ' Check if the main form instance is not null
        If Temp2 IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            Temp2.ShowChildFormInPanel(listHospitals)
        End If
    End Sub
End Class