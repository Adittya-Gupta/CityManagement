Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class Health_Record_Tracker

    'Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim listView1 As New ListView()
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

        'Dim queryString As String = "SELECT DATE(date) as date, department, hos_id, prescription , bill FROM appointmentRecord"

        'Using connection As New MySqlConnection(connectionstring)
        'Dim command As New MySqlCommand(queryString, connection)
        'connection.Open()

        'Dim reader As MySqlDataReader = command.ExecuteReader()
        'Try
        'While reader.Read()
        'Dim row As New ListViewItem(New String() {Convert.ToDateTime(reader("date")).ToString("yyyy-MM-dd"), reader("hos_id").ToString(), reader("department").ToString(), reader("prescription").ToString(), reader("bill").ToString()})
        ''listView1.Items.Add(row)
        'End While
        'Finally
        'reader.Close()
        'End Try
        'End Using


        ' Add sample data rows to the ListView
        Dim row1 As New ListViewItem(New String() {"2024-02-15", "22011", "Cardiology", "Pres101.pdf", "Bill101.pdf"})
        Dim row2 As New ListViewItem(New String() {"2024-02-16", "22012", "Opthamology", "Pres102.pdf", "Bill102.pdf"})
        Dim row3 As New ListViewItem(New String() {"2024-02-17", "22012", "Cardiology", "Pres103.pdf", "Bill103.pdf"})
        Dim row4 As New ListViewItem(New String() {"2024-02-18", "22092", "Cardiology", "Pres104.pdf", "Bill104.pdf"})
        listView1.Items.AddRange(New ListViewItem() {row1, row2, row3, row4})

        ' Set the location of the ListView
        listView1.Location = New Point(44, 400) ' Set location to (30, 200)



        ' Set the ListView's height to fit its content
        listView1.Height = (300) ' Add some extra space for aesthetics

        ' Add the ListView to the form
        Me.Controls.Add(listView1)

        ' Bring the ListView to the front
        listView1.BringToFront()
    End Sub

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Health_Doctor_Employment_Requests.Show()
        Me.Close()
    End Sub
End Class