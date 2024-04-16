Imports MySql.Data.MySqlClient

Public Class Health_ViewAppointment

    Dim connectionString As String = Module1.connString
    'Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim userID As Integer = Module1.CurrUserSID
    Dim doctorID As Integer = 0 ' Global variable to store doctor ID

    Dim listView1 As New ListView()

    Private Sub GetDoctorID()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT doctor_id FROM Doctors WHERE user_id = @userID"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@userID", userID)
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        doctorID = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error getting doctor ID: {ex.Message}")
        End Try
    End Sub
    Private Sub Health_ViewAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetDoctorID()

        listView1.Name = "listView1"
        listView1.Width = 1000 ' Set width to 1150
        listView1.View = View.Details ' Set view to Details mode
        listView1.FullRowSelect = True ' Select entire row when clicked
        'listView1.BorderStyle = BorderStyle.None
        listView1.Font = New Font("Arial", 14)
        listView1.Columns.Add("Appointment ID", 185)
        listView1.Columns.Add("Patient Name", 200)
        listView1.Columns.Add("Gender", 100)
        listView1.Columns.Add("Date", 160)
        listView1.Columns.Add("Time", 120)
        listView1.Columns.Add("Status", 220)
        listView1.BackColor = ColorTranslator.FromHtml("#F5F1F1")
        listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable ' Make column headers non-clickable
        listView1.HideSelection = True ' Remove highlighting effect after clicking

        Dim queryString As String = "SELECT appointment_id, user_id, CONCAT(date, ' ', time) AS combined_datetime , status FROM hospitalAppointment WHERE doctor_id = @doctorID"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@doctorID", doctorID)
            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            Try
                While reader.Read()
                    Dim userId As String = reader("user_id").ToString()
                    Dim userDetails As String() = GetUserDetails(userId, connectionString).Split(",")
                    Dim status As String
                    Select Case reader("status")
                        Case 0
                            status = "Booked"
                        Case 1
                            status = "Payment Pending"
                        Case 2
                            status = "Completed"
                        Case Else
                            status = "Unknown"
                    End Select
                    Dim combinedDateTime As String = reader.GetString("combined_datetime")
                    Dim components() As String = combinedDateTime.Split(" "c)
                    Dim dateComponent As String = components(0)
                    Dim timeComponent As String = components(1)

                    Dim row As New ListViewItem(New String() {reader("appointment_id").ToString(), userDetails(0), userDetails(1), dateComponent, timeComponent, status})
                    listView1.Items.Add(row)
                End While
            Finally
                reader.Close()
            End Try

        End Using

        'Dim row1 As New ListViewItem(New String() {"12021", "John Doe", "Male", "2024-02-15", "13:15"})
        'Dim row2 As New ListViewItem(New String() {"22012", "Jane Smith", "Female", "2024-02-16", "14:20"})
        'Dim row3 As New ListViewItem(New String() {"32321", "Emily Johnson", "Female", "2024-02-17", "09:45"})
        'Dim row4 As New ListViewItem(New String() {"41234", "Michael Brown", "Male", "2024-02-18", "10:20"})
        'listView1.Items.AddRange(New ListViewItem() {row1, row2, row3, row4})

        ' Set the location of the ListView
        listView1.Location = New Point(48, 100) ' Set location to (30, 200)

        ' Set the ListView's height to fit its content
        listView1.Height = (630) ' Add some extra space for aesthetics

        ' Add the ListView to the form
        Me.Controls.Add(listView1)

        ' Attach the event handler to the ListView's ItemActivate event
        AddHandler listView1.ItemActivate, AddressOf ListView1_ItemActivate

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

    ' ListView ItemActivate event handler
    Private Sub ListView1_ItemActivate(sender As Object, e As EventArgs)
        If listView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = listView1.SelectedItems(0)
            Dim statusColumnIndex As Integer = selectedItem.SubItems.Count - 1 ' Assuming status column is the last column
            Dim currentStatus As Integer = GetStatusValue(selectedItem.SubItems(statusColumnIndex).Text)

            If currentStatus < 2 Then ' Check if status is less than 2
                If currentStatus = 1 Then ' Check if status is 1
                    ' Call the payment function
                    'Dim paymentResult As String = Payment()

                    ' If payment is successful, update the status to 2; otherwise, keep it at 1
                    'If paymentResult = "success" Then
                    ' Update the status text
                    'selectedItem.SubItems(statusColumnIndex).Text = GetStatusText(2)

                    ' Update the status in the database
                    'Dim appointmentId As String = selectedItem.SubItems(0).Text ' Assuming appointment ID is in the first column
                    'UpdateStatusInDatabase(appointmentId, 2)
                    'End If
                End If
                If currentStatus = 0 Then
                    ' Increment the status value
                    Dim newStatus As Integer = currentStatus + 2

                    ' Update the status text
                    selectedItem.SubItems(statusColumnIndex).Text = GetStatusText(newStatus)

                    ' Update the status in the database
                    Dim appointmentId As String = selectedItem.SubItems(0).Text ' Assuming appointment ID is in the first column
                    UpdateStatusInDatabase(appointmentId, newStatus)
                End If
            End If
        End If
    End Sub



    ' Function to get the status value from status text
    Private Function GetStatusValue(statusText As String) As Integer
        Select Case statusText
            Case "Booked"
                Return 0
            Case "Payment Pending"
                Return 1
            Case "Completed"
                Return 2
            Case Else
                Return -1 ' Unknown status
        End Select
    End Function

    ' Function to get the status text from status value
    Private Function GetStatusText(statusValue As Integer) As String
        Select Case statusValue
            Case 0
                Return "Booked"
            Case 1
                Return "Payment Pending"
            Case 2
                Return "Completed"
            Case Else
                Return "Unknown"
        End Select
    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim specialisation As New specialisation()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(specialisation)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim listHospitals As New listHospitals()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(listHospitals)
        End If
    End Sub

    Private Sub UpdateStatusInDatabase(appointmentId As String, newStatus As Integer)
        Dim queryString As String = "UPDATE hospitalAppointment SET status = @newStatus WHERE appointment_id = @appointmentId"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@newStatus", newStatus)
            command.Parameters.AddWithValue("@appointmentId", appointmentId)
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
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
