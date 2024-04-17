Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Doctor_Emp_Req
    Private _parentForm As Form
    Private _i As Integer
    Private _resumeData As Byte()

    Public Sub New(ParentForm As Form, ByVal dateValue As Date, ByVal name As String, ByVal resumeBytes As Byte(), Optional ByVal i As Integer = 1)
        InitializeComponent()

        _parentForm = ParentForm

        ' Set the values of the components based on the parameters
        Label1.Text = dateValue.ToString("dd MMM yyyy")
        Label4.Text = name
        _i = i

        ' Store the resume data in a field for later use
        _resumeData = resumeBytes
    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Get the user ID associated with the button clicked
        Dim userID As Integer = CType(sender, Button).Tag

        ' Remove the entry from the database using the user ID
        Dim success = RemoveEntryFromDatabase(userID)
        'MsgBox(userID)

        If success Then
            ' Insert the new doctor entry into the Doctors table
            success = AddDoctorToTable(userID)

            If success Then


                MsgBox("Employment request accepted and doctor added")
            Else
                MsgBox("Failed to add the doctor")
            End If
        Else
            MsgBox("Failed to remove the employment request")
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get the user ID associated with the button clicked
        Dim userID As Integer = CType(sender, Button).Tag

        ' Remove the entry from the database using the user ID
        'MsgBox(userID)
        Dim success As Boolean = RemoveEntryFromDatabase(userID)

        If success Then

            MsgBox("Employment request rejected")
        Else
            MsgBox("Failed to remove the employment request")
        End If
    End Sub

    Private Function RemoveEntryFromDatabase(userID As Integer) As Boolean
        ' Execute a MySQL delete query to remove the entry from the database
        Dim connectionString As String = Module1.connString
        'Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Dim query As String = "DELETE FROM DoctorEmploymentRequest WHERE user_id = @user_id"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Replace @user_id with the actual user_id of the entry to be removed
                command.Parameters.AddWithValue("@user_id", userID)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' If at least one row is affected, the entry was successfully deleted
                    Return rowsAffected > 0
                Catch ex As Exception
                    ' Handle any exceptions
                    MsgBox("Error: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Public Function UpdateUserDesignationToDoctor(ByVal userId As Integer) As Boolean
        ' Dim connectionString As String = "Your_Connection_String_Here"
        Dim connectionString As String = Module1.connString
        Dim query As String = "UPDATE User SET Designation = 'Doctor' WHERE SID = @UserId"

        Try
            Using connection As New MySqlConnection(connString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserId", userId)
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        Console.WriteLine("User designation updated successfully.")
                        Return True
                    Else
                        Console.WriteLine("User with specified ID not found.")
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("An error occurred: " & ex.Message)
            Return False
        End Try
    End Function


    Private Function AddDoctorToTable(user_id As Integer) As Boolean
        ' Execute a SQL query to insert the doctor entry into the Doctors table
        Dim connectionString As String = Module1.connString
        'Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Dim query As String = "INSERT INTO Doctors (user_id, hos_id, prof_email, experience, speciality, salary, rating, total_ratings, visiting_time_start, visiting_time_end) VALUES (@user_id, @hos_id, @prof_email, @experience, @speciality, @salary, 0, 0, @visiting_time_start, @visiting_time_end)"

        UpdateUserDesignationToDoctor(user_id)

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@user_id", user_id)
                command.Parameters.AddWithValue("@hos_id", 20) ' Default value
                command.Parameters.AddWithValue("@prof_email", "s.gosh@gamil.com") ' Default value
                command.Parameters.AddWithValue("@experience", 3) ' Default value
                command.Parameters.AddWithValue("@speciality", "Cardiology") ' Default value
                command.Parameters.AddWithValue("@salary", 50000) ' Default value
                command.Parameters.AddWithValue("@visiting_time_start", "08:00:00") ' Default value
                command.Parameters.AddWithValue("@visiting_time_end", "16:00:00") ' Default value

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function





    Private Sub Doctor_Emp_Req_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Save the resume data to a temporary PDF file
        Dim tempFilePath As String = Path.GetTempFileName()
        tempFilePath = Path.ChangeExtension(tempFilePath, "pdf") ' Change the file extension to .pdf
        File.WriteAllBytes(tempFilePath, _resumeData)

        ' Specify the path to save the resume file
        Dim saveFilePath As String = "..\..\..\MediaFiles\DocEmpReq\Resume.pdf"

        ' Save the file
        File.Copy(tempFilePath, saveFilePath, True)

        MessageBox.Show("Resume file downloaded successfully to: " & saveFilePath)
    End Sub

End Class
