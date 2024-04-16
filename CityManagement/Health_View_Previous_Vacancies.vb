Imports MySql.Data.MySqlClient
Public Class Health_View_Previous_Vacancies

    Private Sub Health_Doctor_Employment_Requests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        ' Create a new Panel control
        Dim panelListView As New Panel()
        panelListView.Size = New Size(1050, 550) ' Set the size as needed
        panelListView.Location = New Point(15, 150) ' Adjust the position as needed
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

        ' Retrieve data from the hospitalVacancy table
        Dim connectionString As String = Module1.connString
        'Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Dim query As String = "SELECT * FROM hospitalVacancy"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim i As Integer = 1 ' Initialize the counter variable
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim hos_id As Integer = Convert.ToInt32(reader("hos_id"))
                        Dim department As String = reader("department").ToString()
                        Dim vacancyCount As Integer = Convert.ToInt32(reader("vacancyCount"))
                        Dim description As String = reader("description").ToString()

                        ' Create HospitalVacancy instance and add it to the ListView or Panel
                        Dim vacancyItem As New Hospital_Vac_Comp(Me, hos_id, department, vacancyCount, description)
                        ' Add the HospitalVacancy instance to the ListView or Panel
                        vacancyItem.Button1.Tag = hos_id ' Button1 is the delete button
                        listView1.Controls.Add(vacancyItem)
                        vacancyItem.Left = 40

                        ' Set margin top for HospitalVacancy items
                        If i > 1 Then
                            vacancyItem.Top += (i - 1) * 130
                        End If

                        i += 1 ' Increment the counter variable
                    End While
                End Using
            End Using
        End Using

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim specialisation As New specialisation()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(specialisation)
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

        Dim Health_Create_New_Vacancy As New Health_Create_New_Vacancy()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(Health_Create_New_Vacancy)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Dim Health_Doctor_Employment_Requests As New Health_Doctor_Employment_Requests()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(Health_Doctor_Employment_Requests)
        End If
    End Sub
End Class