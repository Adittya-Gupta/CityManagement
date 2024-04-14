Imports MySql.Data.MySqlClient

Public Class Health_Doctor_Employment_Requests



    Private Sub Health_Doctor_Employment_Requests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        ' Assuming comboBox2 is your ComboBox control
        Dim comboBoxLocation As Point = Guna2ComboBox1.Location
        Dim comboBoxHeight As Integer = Guna2ComboBox1.Height

        ' Create a new Panel control
        Dim panelListView As New Panel()
        panelListView.Size = New Size(1200, 600) ' Set the size as needed
        panelListView.Location = New Point(20, comboBoxLocation.Y + comboBoxHeight + 10) ' Adjust the position as needed
        panelListView.BackColor = Color.White ' Set background color as needed
        panelListView.AutoScroll = True ' Make the panel scrollable

        ' Create and position the ListView control within the new Panel
        Dim listView1 As New ListView()
        listView1.Dock = DockStyle.Fill ' Dock the ListView to fill the entire Panel
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

        ' Retrieve data from the DoctorEmploymentRequest table
        Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Dim query As String = "SELECT * FROM DoctorEmploymentRequest"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim i As Integer = 1 ' Initialize the counter variable
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim user_id As Integer = Convert.ToInt32(reader("user_id"))
                        Dim name As String = reader("Name").ToString()
                        Dim hospital_id As Integer = Convert.ToInt32(reader("hospital_id"))
                        Dim dept As String = reader("dept").ToString()
                        Dim resumeBytes As Byte() = DirectCast(reader("resume"), Byte())
                        Dim [date] As Date = Convert.ToDateTime(reader("Date"))

                        ' Create Doctor_Emp_Req instance and add it to the ListView
                        Dim listItem As New Doctor_Emp_Req(Me, [date], name, resumeBytes, user_id)
                        ' Set the Tag property of the buttons
                        listItem.Button1.Tag = user_id ' Button1 is the reject button
                        listItem.Button2.Tag = user_id ' Button2 is the accept button

                        listView1.Controls.Add(listItem)
                        listItem.Left = 80

                        ' Set margin top for ListItem2 to ListItem4
                        If i > 1 Then
                            listItem.Top += (i - 1) * 130
                        End If

                        i += 1 ' Increment the counter variable
                    End While
                End Using
            End Using
        End Using





    End Sub





    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

        Dim Health_Create_New_Vacancy As New Health_Create_New_Vacancy()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim Temp2 As Temp2 = CType(Application.OpenForms("Temp2"), Temp2)

        ' Check if the main form instance is not null
        If Temp2 IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            Temp2.ShowChildFormInPanel(Health_Create_New_Vacancy)
        End If
    End Sub


    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

        Dim Health_View_Previous_Vacancies As New Health_View_Previous_Vacancies()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim Temp2 As Temp2 = CType(Application.OpenForms("Temp2"), Temp2)

        ' Check if the main form instance is not null
        If Temp2 IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            Temp2.ShowChildFormInPanel(Health_View_Previous_Vacancies)
        End If

    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Dim Health_Record_Tracker As New Health_Record_Tracker()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim Temp2 As Temp2 = CType(Application.OpenForms("Temp2"), Temp2)

        ' Check if the main form instance is not null
        If Temp2 IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            Temp2.ShowChildFormInPanel(Health_Record_Tracker)
        End If
    End Sub
End Class