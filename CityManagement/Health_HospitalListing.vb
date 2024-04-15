Imports MySql.Data.MySqlClient

Public Class Health_HospitalListing
    Private EmploymentPortalForm As EmploymentPortal

    Dim connectionString As String = Module1.connString
    'Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim user_id As Integer = Module1.CurrUserSID

    'Constructor
    Public Sub New(ParentForm As EmploymentPortal)
        InitializeComponent()
        Me.EmploymentPortalForm = ParentForm ' Initialize EmploymentPortalForm
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        EmploymentPortalForm.LoadListOfOrgForm()
    End Sub

    Private Sub InsertProposal()
        Dim queryString As String = "INSERT INTO HospitalProposal (userID, ownerName, location, contactNo, bankAccDetails, description) VALUES (@userID, @ownerName, @location, @contactNo, @bankAccDetails, @description)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryString, connection)
                command.Parameters.AddWithValue("@userID", user_id)
                command.Parameters.AddWithValue("@ownerName", TextBox1.Text)
                command.Parameters.AddWithValue("@location", TextBox4.Text)
                command.Parameters.AddWithValue("@contactNo", TextBox3.Text)
                command.Parameters.AddWithValue("@bankAccDetails", TextBox2.Text)
                command.Parameters.AddWithValue("@description", TextBox6.Text)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Call InsertProposal method when necessary
    ' For example, you can call this method on a button click event
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate phone number
        Dim phoneNumber As String = TextBox3.Text.Trim()
        If Not IsNumeric(phoneNumber) Then
            MessageBox.Show("Phone number should contain only digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If phoneNumber.Length <> 10 Then
            MessageBox.Show("Phone number should be 10 digits long.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' If phone number is valid, proceed to insert proposal
        InsertProposal()
        MessageBox.Show("Proposal submitted successfully!")

        ' Clear all textboxes
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
    End Sub



End Class