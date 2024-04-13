Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.IO
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class Banking_Admin_Home

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String


    'Dim server As String = "localhost"
    'Dim username As String = "root"
    ' Dim password As String = "12345678"
    ' Dim database As String = "bankingdatabase"

    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "bankingdatabase"






    Private Function IsValidBankAccountNumber(ByVal accountNumber As String) As Boolean
        ' Bank account number must be 10 digits and a number
        Dim regex As New Regex("^\d{10}$")
        Return regex.IsMatch(accountNumber)
    End Function

    Private Function IsValidEmail(ByVal email As String) As Boolean
        ' Email ID ends with .com
        Return email.EndsWith(".com", StringComparison.OrdinalIgnoreCase)
    End Function

    Private Function IsValidPhoneNumber(ByVal phoneNumber As String) As Boolean
        ' Phone Number must be 10 digits and a number
        Dim regex As New Regex("^\d{10}$")
        Return regex.IsMatch(phoneNumber)
    End Function

    Private Function IsValidDOB(ByVal dob As String) As Boolean
        ' DOB must be of the form yyyy-mm-dd
        Dim dt As DateTime
        Return DateTime.TryParseExact(dob, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, dt)
    End Function

    Private Function IsValidGender(ByVal gender As String) As Boolean
        ' Gender must be either Male or Female
        Return gender.Equals("Male", StringComparison.OrdinalIgnoreCase) OrElse gender.Equals("Female", StringComparison.OrdinalIgnoreCase)
    End Function

    Private Function IsNumeric(ByVal value As String) As Boolean
        ' Check if the value is numeric
        Return Double.TryParse(value, Nothing)
    End Function

    Private Function IsValidApproved(ByVal approved As String) As Boolean
        ' Approved must either be 1 or 0
        Return approved.Equals("1") OrElse approved.Equals("0")
    End Function












    Private Sub updateTable()
        Try
            ' Close the connection before modifying the connection string property
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next

            ' Set the connection string property
            'sqlConn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
            sqlConn.ConnectionString = Global_Attributes.slqConnection_banking

            ' Open the connection
            sqlConn.Open()

            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "SELECT * FROM UserData WHERE Approved=1"

            sqlRd = sqlCmd.ExecuteReader
            sqlDt.Clear()
            sqlDt.Load(sqlRd)
            sqlRd.Close()

            ' Close the connection after use
            sqlConn.Close()

            'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.ScrollBars = ScrollBars.Both
            DataGridView1.DataSource = sqlDt

        Catch ex As Exception
            MessageBox.Show("Error updating table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub Banking_Admin_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub


    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click

        Try


            ' Validate each field
            If Not IsValidBankAccountNumber(AccNo_TextBox.Text) Then
                MessageBox.Show("Bank Account Number must be 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsValidEmail(Email_TextBox.Text) Then
                MessageBox.Show("Invalid Email ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsValidPhoneNumber(Phone_TextBox.Text) Then
                MessageBox.Show("Phone Number must be 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsValidDOB(DOB_TextBox.Text) Then
                MessageBox.Show("Invalid Date of Birth. Please use the format yyyy-mm-dd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsValidGender(Gender_TextBox.Text) Then
                MessageBox.Show("Invalid Gender. Must be Male or Female.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsNumeric(Balance_TextBox.Text) Then
                MessageBox.Show("Balance must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsNumeric(CIBILScore_TextBox.Text) Then
                MessageBox.Show("CIBIL Score must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsNumeric(IdenNo_TextBox.Text) Then
                MessageBox.Show("Identification Number must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsValidApproved(Approved_TextBox.Text) Then
                MessageBox.Show("Approved must be 1 or 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' If all fields are valid, proceed with updating the record




            'sqlConn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
            sqlConn.ConnectionString = Global_Attributes.slqConnection_banking

            sqlConn.Open()

            sqlCmd.Connection = sqlConn

            With sqlCmd
                .CommandText = "UPDATE UserData SET Bank_Account_Number = @Bank_Account_Number, Email_ID=@Email_ID, Name=@Name, Address=@Address,Phone_Number=@Phone_Number, Username=@Username, Password=@Password, DOB=@DOB, Balance=@Balance, CIBIL_Score=@CIBIL_Score, Identification_Number=@Identification_Number, Approved=@Approved, Gender=@Gender WHERE Username=@OldUsername"
                .CommandType = CommandType.Text


                .Parameters.Clear()
                'Add parameters within the With block only
                .Parameters.AddWithValue("@Bank_Account_Number", AccNo_TextBox.Text)
                .Parameters.AddWithValue("@Email_ID", Email_TextBox.Text)
                .Parameters.AddWithValue("@Name", Name_TextBox.Text)
                .Parameters.AddWithValue("@Address", Address_TextBox.Text)
                .Parameters.AddWithValue("@Phone_Number", Phone_TextBox.Text)
                .Parameters.AddWithValue("@Username", Username_TextBox.Text)
                .Parameters.AddWithValue("@Password", Password_TextBox.Text)
                .Parameters.AddWithValue("@DOB", DOB_TextBox.Text)
                .Parameters.AddWithValue("@Balance", Balance_TextBox.Text)
                .Parameters.AddWithValue("@CIBIL_Score", CIBILScore_TextBox.Text)
                .Parameters.AddWithValue("@Identification_Number", IdenNo_TextBox.Text)
                .Parameters.AddWithValue("@Approved", Approved_TextBox.Text)
                .Parameters.AddWithValue("@Gender", Gender_TextBox.Text)

                ' Add the parameter for OldStudentid
                .Parameters.AddWithValue("@OldUsername", Username_TextBox.Text)

                ' Execute the command
                .ExecuteNonQuery()

                ' Clear parameters for next update operation
                .Parameters.Clear()

            End With


            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)




            ' Refresh DataGridView to reflect the updated data
            updateTable()

        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try

    End Sub



    Private Sub New_Button_Click(sender As Object, e As EventArgs) Handles New_Button.Click
        Try



            ' Validate each field
            If Not IsValidBankAccountNumber(AccNo_TextBox.Text) Then
                MessageBox.Show("Bank Account Number must be 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsValidEmail(Email_TextBox.Text) Then
                MessageBox.Show("Invalid Email ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsValidPhoneNumber(Phone_TextBox.Text) Then
                MessageBox.Show("Phone Number must be 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsValidDOB(DOB_TextBox.Text) Then
                MessageBox.Show("Invalid Date of Birth. Please use the format yyyy-mm-dd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsValidGender(Gender_TextBox.Text) Then
                MessageBox.Show("Invalid Gender. Must be Male or Female.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsNumeric(Balance_TextBox.Text) Then
                MessageBox.Show("Balance must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsNumeric(CIBILScore_TextBox.Text) Then
                MessageBox.Show("CIBIL Score must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsNumeric(IdenNo_TextBox.Text) Then
                MessageBox.Show("Identification Number must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsValidApproved(Approved_TextBox.Text) Then
                MessageBox.Show("Approved must be 1 or 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' If all fields are valid, proceed with updating the record




            'sqlConn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
            sqlConn.ConnectionString = Global_Attributes.slqConnection_banking
            sqlConn.Open()

            sqlCmd.Connection = sqlConn

            With sqlCmd
                .CommandText = "INSERT INTO UserData(Bank_Account_Number,Email_ID,Name,Address,Phone_Number,Username,Password,DOB,Balance,CIBIL_Score,Identification_Number,Approved,Gender) VALUES (@Bank_Account_Number,@Email_ID,@Name,@Address,@Phone_Number,@Username,@Password,@DOB,@Balance,@CIBIL_Score,@Identification_Number,@Approved,@Gender)"
                .CommandType = CommandType.Text


                .Parameters.Clear()
                ' Add parameters within the With block only
                .Parameters.AddWithValue("@Bank_Account_Number", AccNo_TextBox.Text)
                .Parameters.AddWithValue("@Email_ID", Email_TextBox.Text)
                .Parameters.AddWithValue("@Name", Name_TextBox.Text)
                .Parameters.AddWithValue("@Address", Address_TextBox.Text)
                .Parameters.AddWithValue("@Phone_Number", Phone_TextBox.Text)
                .Parameters.AddWithValue("@Username", Username_TextBox.Text)
                .Parameters.AddWithValue("@Password", Password_TextBox.Text)
                .Parameters.AddWithValue("@DOB", DOB_TextBox.Text)
                .Parameters.AddWithValue("@Balance", Balance_TextBox.Text)
                .Parameters.AddWithValue("@CIBIL_Score", CIBILScore_TextBox.Text)
                .Parameters.AddWithValue("@Identification_Number", IdenNo_TextBox.Text)
                .Parameters.AddWithValue("@Approved", Approved_TextBox.Text)
                .Parameters.AddWithValue("@Gender", Gender_TextBox.Text)
                ' Execute the command
                .ExecuteNonQuery()

                ' Clear parameters for next update operation
                .Parameters.Clear()

            End With


            MessageBox.Show("New record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)




            ' Refresh DataGridView to reflect the updated data
            updateTable()

        Catch ex As Exception
            MessageBox.Show("Error adding new record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try
    End Sub




    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        Try
            sqlConn.ConnectionString = Global_Attributes.slqConnection_banking
            'sqlConn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
            sqlConn.Open()

            sqlCmd.Connection = sqlConn

            With sqlCmd
                .CommandText = "DELETE FROM UserData WHERE Username=@OldUsername"
                .CommandType = CommandType.Text

                .Parameters.AddWithValue("@OldUsername", Username_TextBox.Text)

                ' Execute the command
                .ExecuteNonQuery()

                ' Clear parameters for next update operation
                .Parameters.Clear()
            End With


            MessageBox.Show("Record Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)




            ' Refresh DataGridView to reflect the updated data
            updateTable()

        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try
    End Sub




    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is in the leftmost column
        If e.ColumnIndex >= 0 Then
            ' If not, exit the event handler without performing any action
            Return
        End If

        ' Now proceed to load data into text boxes only if the clicked cell is in the leftmost column
        Try
            Name_TextBox.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            Email_TextBox.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            Phone_TextBox.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            AccNo_TextBox.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            Username_TextBox.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
            Password_TextBox.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
            Balance_TextBox.Text = DataGridView1.SelectedRows(0).Cells(9).Value.ToString
            Address_TextBox.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            DOB_TextBox.Text = DataGridView1.SelectedRows(0).Cells(8).Value.ToString
            CIBILScore_TextBox.Text = DataGridView1.SelectedRows(0).Cells(10).Value.ToString
            IdenNo_TextBox.Text = DataGridView1.SelectedRows(0).Cells(7).Value.ToString
            Approved_TextBox.Text = DataGridView1.SelectedRows(0).Cells(13).Value.ToString
            Gender_TextBox.Text = DataGridView1.SelectedRows(0).Cells(14).Value.ToString

            ' Load profile image into PictureBox1
            Dim profileImageBytes() As Byte = TryCast(DataGridView1.SelectedRows(0).Cells(11).Value, Byte())
            If profileImageBytes IsNot Nothing AndAlso profileImageBytes.Length > 0 Then
                Using ms As New MemoryStream(profileImageBytes)
                    PictureBox1.Image = Image.FromStream(ms)
                End Using
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage ' or PictureBoxSizeMode.Zoom
            Else
                PictureBox1.Image = Nothing ' Clear the PictureBox if there's no image
            End If

            ' Load signature image into PictureBox2
            Dim signatureBytes() As Byte = TryCast(DataGridView1.SelectedRows(0).Cells(12).Value, Byte())
            If signatureBytes IsNot Nothing AndAlso signatureBytes.Length > 0 Then
                Using ms As New MemoryStream(signatureBytes)
                    PictureBox2.Image = Image.FromStream(ms)
                End Using
                PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage ' or PictureBoxSizeMode.Zoom
            Else
                PictureBox2.Image = Nothing ' Clear the PictureBox if there's no image
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        Try
            ' Clear all text boxes on the form
            For Each ctrl In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    DirectCast(ctrl, TextBox).Text = ""
                End If
            Next

            ' Clear PictureBox images
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Refresh_Button_Click(sender As Object, e As EventArgs) Handles Refresh_Button.Click
        updateTable()
    End Sub


End Class