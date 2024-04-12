Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class User_Admin
    Dim connString As String = Module1.connString
    'Dim connString As String = "server=localhost;userid=root;password=pwd;database=smart_city_management"
    Dim connection As New MySqlConnection(connString)

    Private Sub User_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Open connection
            connection.Open()

            ' Load users data when the form loads
            LoadUsersData()

        Catch ex As Exception
            MessageBox.Show("Error loading user data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub LoadUsersData()
        'Query to select all users
        Dim query As String = "SELECT * FROM User"
        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim dataTable As New DataTable()

        ' Fill the DataTable with user data
        adapter.Fill(dataTable)

        ' Bind the DataTable to DataGridView
        DataGridView1.DataSource = dataTable
        DataGridView1.ReadOnly = True
    End Sub

    Private Function EmailExistsInDatabase(EmailAddress As String) As Boolean
        Try
            ' Open connection
            connection.Open()

            ' Query to check if the email exists in the database
            Dim query As String = "SELECT COUNT(*) FROM User WHERE EmailAddress = @EmailAddress"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@EmailAddress", EmailAddress)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

            ' If count > 0, email exists in the database
            Return count > 0

        Catch ex As Exception
            MessageBox.Show("Error checking email existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            ' Close connection
            connection.Close()
        End Try
    End Function

    Private Sub GetDetailsButton_Click(sender As Object, e As EventArgs) Handles GetDetailsButton.Click
        ' Check if any row is selected
        If DataGridView1.CurrentRow IsNot Nothing Then
            ' Retrieve user details from the current row
            Dim name = DataGridView1.CurrentRow.Cells("Name").Value.ToString
            Dim EmailAddress = DataGridView1.CurrentRow.Cells("EmailAddress").Value.ToString
            Dim ContactNo = DataGridView1.CurrentRow.Cells("ContactNo").Value.ToString

            ' Display user details in textboxes
            TextBoxName.Text = name
            TextBoxEmail.Text = EmailAddress
            TextBoxContact.Text = ContactNo
            TextBoxPassword.Text = "********"
        Else
            MessageBox.Show("Please select a row to get details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TextBoxName.Text = ""
        TextBoxEmail.Text = ""
        TextBoxContact.Text = ""
        TextBoxPassword.Text = ""
    End Sub


    ' Function to hash the password using SHA256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles AddUserButton.Click
        ' Open the AddUserForm to collect user information
        ' Retrieve user input from the form's textboxes
        Dim name As String = TextBoxName.Text
        Dim EmailAddress As String = TextBoxEmail.Text
        Dim ContactNo As String = TextBoxContact.Text
        Dim password As String = TextBoxPassword.Text

        ' Validate the input
        If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(EmailAddress) OrElse String.IsNullOrEmpty(ContactNo) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Open connection
            connection.Open()

            ' Query to insert a new user into the database
            Dim query As String = "INSERT INTO User (Name, EmailAddress, ContactNo,Designation, PasswordHash) VALUES (@Name, @EmailAddress, @ContactNo,@Designation, @Password)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Name", name)
            command.Parameters.AddWithValue("@EmailAddress", EmailAddress)
            command.Parameters.AddWithValue("@ContactNo", ContactNo)
            command.Parameters.AddWithValue("@Designation", "Not Employed")
            command.Parameters.AddWithValue("@Password", HashPassword(password))
            command.ExecuteNonQuery()

            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reload users data after adding a new user
            LoadUsersData()

        Catch ex As Exception
            MessageBox.Show("Error adding user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection
            connection.Close()
        End Try
    End Sub

    Private Sub EditUserButton_Click(sender As Object, e As EventArgs) Handles EditUserButton.Click
        ' Retrieve updated user information from the form's textboxes
        Dim name As String = TextBoxName.Text
        Dim EmailAddress As String = TextBoxEmail.Text
        Dim ContactNo As String = TextBoxContact.Text
        Dim password As String = TextBoxPassword.Text

        ' Validate the input
        If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(EmailAddress) OrElse String.IsNullOrEmpty(ContactNo) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the email exists in the database
        If Not EmailExistsInDatabase(EmailAddress) Then
            MessageBox.Show("Email does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Open connection
            connection.Open()

            If password <> "********" Then
                ' Query to update the user's information in the database based on email
                Dim query As String = "UPDATE User SET Name = @Name, ContactNo = @ContactNo, PasswordHash = @Password WHERE EmailAddress = @EmailAddress"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Name", name)
                command.Parameters.AddWithValue("@ContactNo", ContactNo)
                command.Parameters.AddWithValue("@Password", HashPassword(password))
                command.Parameters.AddWithValue("@EmailAddress", EmailAddress)
                command.ExecuteNonQuery()

            Else
                Dim query As String = "UPDATE User SET Name = @Name, ContactNo = @ContactNo WHERE EmailAddress = @EmailAddress"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Name", name)
                command.Parameters.AddWithValue("@ContactNo", ContactNo)
                command.Parameters.AddWithValue("@EmailAddress", EmailAddress)
                command.ExecuteNonQuery()
            End If
            MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reload users data after editing the user
            LoadUsersData()

        Catch ex As Exception
            MessageBox.Show("Error editing user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection
            connection.Close()
        End Try
    End Sub


    Private Sub DeleteUserButton_Click(sender As Object, e As EventArgs) Handles DeleteUserButton.Click
        Dim EmailAddress As String = TextBoxEmail.Text

        ' Validate the input
        If String.IsNullOrEmpty(EmailAddress) Then
            MessageBox.Show("Email field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the email exists in the database
        If Not EmailExistsInDatabase(EmailAddress) Then
            MessageBox.Show("Email does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Delete the user from the database
            Try
                ' Open connection
                connection.Open()

                ' Query to delete the user based on email
                Dim query As String = "DELETE FROM User WHERE EmailAddress = @EmailAddress"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@EmailAddress", EmailAddress)
                command.ExecuteNonQuery()

                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Reload users data after deleting the user
                LoadUsersData()

            Catch ex As Exception
                MessageBox.Show("Error deleting user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close connection
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label1.Click
        ' Add code to navigate to the next form or perform other actions upon successful login

        mypanel.Panel1.Controls.Clear()
        Dim form As New User_Profile
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()

    End Sub

End Class