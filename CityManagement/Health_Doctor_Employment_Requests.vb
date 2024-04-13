Public Class Health_Doctor_Employment_Requests



    Private Sub Health_Doctor_Employment_Requests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        ' Assuming comboBox2 is your ComboBox control
        Dim comboBoxLocation As Point = Guna2ComboBox1.Location
        Dim comboBoxHeight As Integer = Guna2ComboBox1.Height

        ' Create a new Panel control
        Dim panelListView As New Panel()
        panelListView.Size = New Size(1000, 600) ' Set the size as needed
        panelListView.Location = New Point(20, comboBoxLocation.Y + comboBoxHeight + 10) ' Adjust the position as needed
        panelListView.BackColor = Color.White ' Set background color as needed

        ' Create and position the ListView control within the new Panel
        Dim listView1 As New ListView()
        listView1.Dock = DockStyle.Fill
        listView1.View = View.Details ' Set the view to Details if needed

        ' Add columns to the ListView if needed
        ' For example:
        ' listView1.Columns.Add("Column 1")
        ' listView1.Columns.Add("Column 2")
        ' ...

        ' Add the ListView control to the new Panel
        panelListView.Controls.Add(listView1)

        ' Add the new Panel to the form
        Me.Controls.Add(panelListView)

        For i As Integer = 1 To 4
            Dim listItem As New Doctor_Emp_Req(Me, Date.Now, "Dr. S. K. Gosh", i)
            listView1.Controls.Add(listItem)
            listItem.Left = 80

            ' Set margin top for ListItem2 to ListItem4
            If i > 1 Then
                listItem.Top += (i - 1) * 130
            End If

        Next


    End Sub





    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Health_Create_New_Vacancy.Show()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Health_View_Previous_Vacancies.Show()
        Me.Close()

    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Health_Record_Tracker.Show()
        Close()
    End Sub
End Class