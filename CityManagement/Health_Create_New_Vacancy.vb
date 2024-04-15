Imports MySql.Data.MySqlClient


Public Class Health_Create_New_Vacancy
    ' Connection string for MySQL database
    Dim connectionString As String = Module1.connString
    'Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Retrieve data from the textboxes
            Dim hos_id As Integer = Integer.Parse(TextBox1.Text)
            Dim department As String = TextBox3.Text
            Dim vacancyCount As Integer = Integer.Parse(TextBox2.Text)
            Dim description As String = TextBox6.Text

            ' Construct the SQL INSERT query
            Dim query As String = "INSERT INTO hospitalVacancy (hos_id, department, vacancyCount, description) VALUES (@hos_id, @department, @vacancyCount, @description)"

            ' Create a MySqlConnection object
            Using connection As New MySqlConnection(connectionString)
                ' Create a MySqlCommand object
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the query
                    command.Parameters.AddWithValue("@hos_id", hos_id)
                    command.Parameters.AddWithValue("@department", department)
                    command.Parameters.AddWithValue("@vacancyCount", vacancyCount)
                    command.Parameters.AddWithValue("@description", description)

                    ' Open the connection
                    connection.Open()

                    ' Execute the INSERT query
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Show a message box indicating successful insertion
            MsgBox("New vacancy added.")

        Catch ex As Exception
            ' Show an error message box if an exception occurs
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim Health_View_Previous_Vacancies As New Health_View_Previous_Vacancies()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(Health_View_Previous_Vacancies)
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



    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        Dim specialisation As New specialisation()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim MainPanel As MainPanel = CType(Application.OpenForms("MainPanel"), MainPanel)

        ' Check if the main form instance is not null
        If MainPanel IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            MainPanel.ShowChildFormInPanel(specialisation)
        End If
    End Sub


End Class
