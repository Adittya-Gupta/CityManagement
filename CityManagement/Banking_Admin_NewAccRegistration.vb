Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class Banking_Admin_NewAccRegistration

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String


    'Dim server As String = "localhost"
    'Dim username As String = "root"
    'Dim password As String = "12345678"
    ' Dim database As String = "bankingdatabase"

    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "bankingdatabase"

    Dim Name_Registration As String
    Dim Email_Registration As String
    Dim Phone_Registration As String
    Dim AccNo_Registration As String
    Dim username_Registration As String
    Dim password_Registration As String
    Dim Address_Registration As String
    Dim DOB_Registration As String
    Dim Identification_number As String
    Dim Gender_Registration As String

    Dim profileImageBytes As Byte() = Nothing
    Dim signatureBytes As Byte() = Nothing



    Function GenerateRandomAccountNumber() As String
        Dim random As New Random()
        Dim accNo As String = ""

        For i As Integer = 0 To 9
            accNo &= random.Next(0, 10).ToString()
        Next

        Return accNo
    End Function



    Private Function IsAccountNumberUnique(ByVal accountNumber As String) As Boolean
        ' Check if the generated account number exists in the database
        Dim query As String = "SELECT COUNT(*) FROM BankUserData WHERE Bank_Account_Number = @Bank_Account_Number"
        Using cmd As New MySqlCommand(query, sqlConn) ' Use MySqlCommand here
            cmd.Parameters.AddWithValue("@Bank_Account_Number", accountNumber)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count = 0
        End Using
    End Function


    Private Function GenerateUniqueAccountNumber() As String
        ' Generate a unique account number
        Dim newAccountNumber As String
        Do
            newAccountNumber = GenerateRandomAccountNumber()
        Loop Until IsAccountNumberUnique(newAccountNumber)
        Return newAccountNumber
    End Function



    Public Sub updateQuery()
        Try
            ' Close the connection before modifying the connection string property
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If

            ' Set the connection string property
            sqlConn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"

            ' Open the connection
            sqlConn.Open()

            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "Insert Into BankTransactionLog(Bank_Account_Number,Involved_Bank_Account_Number,Type_of_Transaction,Amount,Date_Time,Description) Values ('" & AccNo_Registration & "','NAN','New Account Created',0,NOW(),'Successfully created new account');"

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
            sqlCmd.CommandText = "SELECT * FROM BankUserData WHERE Approved=0"

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




    Private Sub Banking_Admin_NewAccRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub




    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is in the leftmost column
        If e.ColumnIndex >= 0 Then
            ' If not, exit the event handler without performing any action
            Return
        End If

        ' Now proceed to load data into text boxes only if the clicked cell is in the leftmost column
        Try
            Name_Registration = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            Email_Registration = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            Phone_Registration = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            'AccNo_Registration = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            username_Registration = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
            password_Registration = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
            Identification_number = DataGridView1.SelectedRows(0).Cells(7).Value.ToString
            Address_Registration = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            DOB_Registration = DataGridView1.SelectedRows(0).Cells(8).Value.ToString
            Gender_Registration = DataGridView1.SelectedRows(0).Cells(14).Value.ToString



            If Not IsDBNull(DataGridView1.SelectedRows(0).Cells(11).Value) Then
                profileImageBytes = DirectCast(DataGridView1.SelectedRows(0).Cells(11).Value, Byte())
            End If

            ' Read signature as byte array
            If Not IsDBNull(DataGridView1.SelectedRows(0).Cells(12).Value) Then
                signatureBytes = DirectCast(DataGridView1.SelectedRows(0).Cells(12).Value, Byte())
            End If










        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.Click
        Try

            sqlConn.ConnectionString = Global_Attributes.slqConnection_banking

            'sqlConn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
            sqlConn.Open()

            sqlCmd.Connection = sqlConn

            With sqlCmd
                .CommandText = "UPDATE BankUserData SET Bank_Account_Number=@Bank_Account_Number, Email_ID=@Email_ID, Name=@Name, Address=@Address, Phone_Number=@Phone_Number, Password=@Password, DOB='" & DOB_Registration & "', Identification_Number=@Identification_Number, Approved=@Approved, Profile_Image=@Profile_Image, Signature=@Signature, Gender=@Gender WHERE Username=@Username"
                .CommandType = CommandType.Text

                .Parameters.Clear()
                AccNo_Registration = GenerateUniqueAccountNumber()
                ' Add parameters within the With block only
                .Parameters.AddWithValue("@Bank_Account_Number", AccNo_Registration)
                .Parameters.AddWithValue("@Email_ID", Email_Registration)
                .Parameters.AddWithValue("@Name", Name_Registration)
                .Parameters.AddWithValue("@Address", Address_Registration)
                .Parameters.AddWithValue("@Phone_Number", Phone_Registration)
                .Parameters.AddWithValue("@Username", username_Registration)
                .Parameters.AddWithValue("@Password", password_Registration)
                '.Parameters.AddWithValue("@DOB", DOB_Registration)
                .Parameters.AddWithValue("@Identification_Number", Identification_number)
                .Parameters.AddWithValue("@Approved", 1)
                .Parameters.AddWithValue("@Profile_Image", profileImageBytes)
                .Parameters.AddWithValue("@Signature", signatureBytes)
                .Parameters.AddWithValue("@Gender", Gender_Registration)

                ' Execute the command
                .ExecuteNonQuery()

                ' Clear parameters for next update operation
                .Parameters.Clear()
            End With


            MessageBox.Show("New record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)




            ' Refresh DataGridView to reflect the updated data
            updateTable()
            updateQuery()


        Catch ex As Exception
            MessageBox.Show("Error adding new record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try
    End Sub

    Private Sub Refresh_Button_Click(sender As Object, e As EventArgs) Handles Refresh_Button.Click
        updateTable()
    End Sub


End Class