Imports MySql.Data.MySqlClient
Public Class Banking_Apply_Credit_Card
    Dim can_apply As Boolean = True
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim bank_account_number As Integer = 123
    Private Sub Apply_btn_Click(sender As Object, e As EventArgs) Handles Apply_btn.Click
        Try
            conn.Open()
            Dim rand As New Random()
            Dim randomNumber1 As Integer = rand.Next(1000, 9000)
            Dim randomNumber2 As Integer = rand.Next(1000, 9000)
            Dim randomNumber3 As Integer = rand.Next(1000, 9000)
            Dim randomNumber4 As Integer = 4592
            Dim randomString As String = randomNumber4.ToString() & " " & randomNumber1.ToString() & " " & randomNumber2.ToString() & " " & randomNumber3.ToString()

            'Console.WriteLine("Concatenated random numbers: " & randomString)



            Dim query = "INSERT INTO CreditDebitCard (CardNumber, Bank_Account_Number, Type, CIBIL_Score, Cvv)
                        VALUES (' " & randomString & "'," & bank_account_number & ", 
                            'CREDIT', 0, 500);"

            Dim cmd = New MySqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader
            Dim sqlDt As New DataTable
            sqlDt.Load(reader)
            reader.Close()

            conn.Close()

            MessageBox.Show("You have been granted a Credit Card")

            Dim form1 As New Banking_Credit_Card_Page()
            form1.Show()
            Me.Hide()


        Catch ex As Exception
            MessageBox.Show("Error: {0}", ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Banking_Apply_Credit_Card_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class