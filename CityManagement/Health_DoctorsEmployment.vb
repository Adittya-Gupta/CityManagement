Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Health_DoctorsEmployment
    Private EmploymentPortalForm As EmploymentPortal
    Dim connectionString As String = Module1.connString
    'Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Private previouslySelectedButton As Button = Nothing
    Dim pdfBytes As Byte() = Nothing
    Dim hosName As String = ""
    Dim userNames As String = ""
    Dim selectedDept As String = ""
    Dim userID As Integer = Module1.CurrUserSID

    'Constructor
    Public Sub New(ParentForm As EmploymentPortal)
        InitializeComponent()
        Me.EmploymentPortalForm = ParentForm ' Initialize EmploymentPortalForm
    End Sub

    Private Function GetUserName()
        Dim queryString As String = "SELECT Name FROM User WHERE SID = @userID"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@userID", userID)
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                userNames = reader("Name").ToString()
                'MessageBox.Show(Name)
            End If
        End Using
    End Function

    Private Sub Health_DoctorsEmployment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetUserName()

        FlowLayoutPanel1.AutoScroll = True
        ComboBox1.Height = 50 ' Set height to 50

        ' Fetch distinct department names from the hospitals table
        Dim deptList As New List(Of String)()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT DISTINCT `dept` FROM `hospitals`"
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        deptList.Add(reader("dept").ToString())
                    End While
                End Using
            End Using
        End Using

        ' Add department names to the ComboBox
        ComboBox1.Items.Add("Specialization") ' Add a default item
        ComboBox1.Items.AddRange(deptList.ToArray())

        ComboBox1.SelectedIndex = 0
        ' Set the SelectionLength property of the ComboBox to 0 to deselect any selected text
    End Sub

    Private Function GetHospitalDetails(hosID As Integer, connectionString As String) As Tuple(Of String, String)
        Dim queryString As String = "SELECT name, location FROM hospitals WHERE hos_id = @hosID"
        Dim hosName As String = ""
        Dim hosLocation As String = ""

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@hosID", hosID)
            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                hosName = reader("name").ToString()
                hosLocation = reader("location").ToString()
            End If
        End Using

        Return Tuple.Create(hosName, hosLocation)
    End Function

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' Open file dialog to choose a PDF file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Display the name of the selected PDF file in Label1
                Label1.Text = Path.GetFileName(openFileDialog.FileName)

                ' Read the selected PDF file as bytes
                pdfBytes = File.ReadAllBytes(openFileDialog.FileName)

                ' Now you can work with the pdfBytes array as needed
                ' For example, you can save it to a database later or process it further
                MessageBox.Show("PDF file loaded successfully.")
            Catch ex As Exception
                MessageBox.Show($"Error loading PDF file: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim selectedButton As Button = DirectCast(sender, Button)

        ' Reset color of previously selected button
        If previouslySelectedButton IsNot Nothing AndAlso previouslySelectedButton IsNot selectedButton Then
            previouslySelectedButton.BackColor = Color.FromArgb(235, 231, 231)
        End If

        ' Toggle button color
        If selectedButton.BackColor = Color.FromArgb(235, 231, 231) Then
            selectedButton.BackColor = Color.LightBlue
        Else
            selectedButton.BackColor = Color.FromArgb(235, 231, 231)
        End If

        ' Extract hospital information
        Dim infoParts As String() = selectedButton.Text.Split(New String() {"                        "}, StringSplitOptions.RemoveEmptyEntries)
        hosName = infoParts(0)
        Dim hosLocation As String = infoParts(1)
        Dim vacancyCount As Integer = Integer.Parse(infoParts(2))

        ' Use the extracted hospital information as needed
        'MessageBox.Show($"Hospital Name: {hosName}{Environment.NewLine}Location: {hosLocation}{Environment.NewLine}Vacancy Count: {vacancyCount}")

        ' Update the previously selected button reference
        previouslySelectedButton = selectedButton
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            FlowLayoutPanel1.Controls.Clear()
        End If

        If ComboBox1.SelectedIndex > 0 Then ' Check if a specialization is selected
            selectedDept = ComboBox1.SelectedItem.ToString()

            ' Clear existing controls in the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Clear()

            ' Fetch data from the vacancy table based on the selected department
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT `hos_id`, `vacancyCount` FROM `hospitalVacancy` WHERE `department` = @dept"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@dept", selectedDept)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim hosID As Integer = Convert.ToInt32(reader("hos_id"))
                            Dim vacancyCount As Integer = Convert.ToInt32(reader("vacancyCount"))

                            ' Fetch hospital name and location using the GetHospitalDetails function
                            Dim hosDetails As Tuple(Of String, String) = GetHospitalDetails(hosID, connectionString)
                            Dim hosName As String = hosDetails.Item1
                            Dim hosLocation As String = hosDetails.Item2

                            ' Create and configure a Button to display hospital information
                            Dim button As New Button()
                            button.Name = "HospitalButton" & hosID
                            button.Width = 920
                            button.Height = 50
                            button.BackColor = Color.FromArgb(235, 231, 231)
                            button.Text = $"{hosName}                        {hosLocation}                        {vacancyCount}"
                            button.Font = New Font(button.Font.FontFamily, 14)
                            button.Margin = New Padding(10)

                            ' Add event handler for button click
                            AddHandler button.Click, AddressOf Button_Click

                            ' Add the Button to the FlowLayoutPanel
                            FlowLayoutPanel1.Controls.Add(button)
                        End While
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Function GetHospitalID(hosName As String) As Integer
        Dim hosID As Integer = 0
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT hos_id FROM hospitals WHERE name = @hosName"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@hosName", hosName)
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        hosID = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error getting hospital ID: {ex.Message}")
        End Try
        Return hosID
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If userID = 0 OrElse hosName = "" OrElse selectedDept = "" OrElse pdfBytes Is Nothing Then
            MessageBox.Show("Please ensure all necessary data is available before inserting.")
            Return
        End If

        ' Get hospital ID using hospital name
        Dim hosID As Integer = GetHospitalID(hosName)

        ' Insert data into employmentreq table
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO DoctorEmploymentRequest (user_id, Name, hospital_id, dept, resume, Date) VALUES (@userID, @userName, @hosID, @dept, @resume, CURDATE())"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@userID", userID)
                    command.Parameters.AddWithValue("@userName", userNames)
                    command.Parameters.AddWithValue("@hosID", hosID)
                    command.Parameters.AddWithValue("@dept", selectedDept)
                    command.Parameters.AddWithValue("@resume", pdfBytes)
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Employment request inserted successfully.")
            ComboBox1.SelectedIndex = 0
            Label1.Text = ""
            pdfBytes = Nothing
        Catch ex As Exception
            MessageBox.Show($"Error inserting employment request: {ex.Message}")
        End Try
    End Sub





    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        EmploymentPortalForm.LoadListOfOrgForm()
    End Sub
End Class