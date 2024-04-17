Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class Health_Record_Tracker

    Dim connectionString As String = Module1.connString
    'Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim listView1 As New ListView()
    Dim userID As Integer = Module1.CurrUserSID
    Private Sub Health_Record_Tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listView1.Name = "listView1"
        listView1.Width = 1000 ' Set width to 1150
        listView1.View = View.Details ' Set view to Details mode
        listView1.FullRowSelect = True ' Select entire row when clicked
        'listView1.BorderStyle = BorderStyle.None
        listView1.Font = New Font("Arial", 14)
        listView1.Columns.Add("Date", 205)
        listView1.Columns.Add("Hospital ID", 200)
        listView1.Columns.Add("Department", 200)
        listView1.Columns.Add("Prescription", 200)
        listView1.Columns.Add("Bill", 200)
        listView1.BackColor = ColorTranslator.FromHtml("#F5F1F1")
        listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable ' Make column headers non-clickable
        listView1.HideSelection = True ' Remove highlighting effect after clicking
        Dim userName As String = GetUserName(Module1.CurrUserSID)
        Label12.Text = userName

        Dim queryString As String = "SELECT DATE(date) as date, department, hos_id, prescription , bill FROM appointmentRecord WHERE user_id = @UserID"
        'Dim queryString1 As String = "SELECT Name FROM User where SID = Module1.CurrUserSID"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@UserID", Module1.CurrUserSID)
            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            Try
                While reader.Read()
                    Dim row As New ListViewItem(New String() {Convert.ToDateTime(reader("date")).ToString("yyyy-MM-dd"), reader("hos_id").ToString(), reader("department").ToString(), reader("prescription").ToString(), reader("bill").ToString()})


                    listView1.Items.Add(row)


                End While
            Finally
                reader.Close()
            End Try
        End Using





        ' Add sample data rows to the ListView
        'Dim row1 As New ListViewItem(New String() {"2024-02-15", "22011", "Cardiology", "Pres101.pdf", "Bill101.pdf"})
        'Dim row2 As New ListViewItem(New String() {"2024-02-16", "22012", "Opthamology", "Pres102.pdf", "Bill102.pdf"})
        'Dim row3 As New ListViewItem(New String() {"2024-02-17", "22012", "Cardiology", "Pres103.pdf", "Bill103.pdf"})
        'Dim row4 As New ListViewItem(New String() {"2024-02-18", "22092", "Cardiology", "Pres104.pdf", "Bill104.pdf"})
        'listView1.Items.AddRange(New ListViewItem() {row1, row2, row3, row4})

        ' Set the location of the ListView
        listView1.Location = New Point(35, 400) ' Set location to (30, 200)



        ' Set the ListView's height to fit its content
        listView1.Height = (300) ' Add some extra space for aesthetics

        ' Add the ListView to the form
        Me.Controls.Add(listView1)

        ' Bring the ListView to the front
        listView1.BringToFront()
    End Sub


    Private Function GetUserName(userId As Integer) As String
        ' SQL query to fetch user's name based on SID
        Dim queryString As String = "SELECT Name FROM User WHERE SID = @SID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryString, connection)
                command.Parameters.AddWithValue("@SID", userId)

                Try
                    connection.Open()
                    Dim userName As String = Convert.ToString(command.ExecuteScalar())
                    Return userName
                Catch ex As Exception
                    MessageBox.Show("Error fetching user's name: " & ex.Message)
                    Return "Anand Keshav"
                End Try
            End Using
        End Using
    End Function
    Private Function GetUserDetails(userId As String, connectionString As String) As String
        Dim queryString As String = "SELECT Name, Gender FROM User WHERE SID = @userId"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@user_id", userId)
            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                Return String.Format("{0},{1}", reader("Name"), reader("Gender"))
            Else
                Return "User details not found"
            End If
        End Using
    End Function

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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
End Class