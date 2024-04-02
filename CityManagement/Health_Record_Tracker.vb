Public Class Health_Record_Tracker

    Dim listView1 As New ListView()
    Private Sub Health_Record_Tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' Add sample data rows to the ListView
        Dim row1 As New ListViewItem(New String() {"12021", "John Doe", "Male", "2024-02-15", "13:15"})
        Dim row2 As New ListViewItem(New String() {"22012", "Jane Smith", "Female", "2024-02-16", "14:20"})
        Dim row3 As New ListViewItem(New String() {"32321", "Emily Johnson", "Female", "2024-02-17", "09:45"})
        Dim row4 As New ListViewItem(New String() {"41234", "Michael Brown", "Male", "2024-02-18", "10:20"})
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
End Class