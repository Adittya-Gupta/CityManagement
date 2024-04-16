Imports MySql.Data.MySqlClient
Public Class Banking_Credit_Card_Page

    Public bank_username As String = "admin"

    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    'Dim connString As String = "server=localhost;userid=root;password=Aasneh18;database=bankingdatabase;"
    Dim connString As String = Global_Attributes.slqConnection_banking

    Dim conn As New MySqlConnection(connString)
    Dim bank_account_number As Integer = 123
    Private Sub Banking_Credit_Card_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        banking_username = Global_Attributes.banking_username

        Try
            conn.Open()


            Dim query = "SELECT CardNumber,Join_date
                 FROM BankCreditDebitCard
                WHERE Type='CREDIT' and bank_username = '" & bank_username & "';"

            Dim cmd = New MySqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader
            Dim sqlDt As New DataTable
            sqlDt.Load(reader)
            reader.Close()
            If sqlDt.Rows.Count = 0 Then
                MessageBox.Show("No user found with current details.")
            Else
                Dim cardNumber As String = sqlDt.Rows(0)("CardNumber").ToString()
                Dim dateString As String = sqlDt.Rows(0)("Join_date").ToString()



                ' Parse the date string into a DateTime object
                Dim dateValue As DateTime = DateTime.Parse(dateString)

                ' Extract month and year parts as strings
                Dim month As String = dateValue.Month.ToString("00")
                Dim year As String = dateValue.Year.ToString().Substring(2) ' Get last two digits of year

                ' Add 4 years to the date
                Dim expiryDate As DateTime = dateValue.AddYears(4)

                ' Convert expiry date to a string with the desired format
                Dim expiryDateString As String = expiryDate.ToString("yyyy-MM-dd")
                Dim expiryMonth As String = expiryDate.Month.ToString("00") ' Pad with leading zeros
                Dim expiryYear As String = expiryDate.Year.ToString().Substring(2) ' Get last two digits of year
                ' Output the results
                'Console.WriteLine("Month: " & month)
                'Console.WriteLine("Last two digits of year: " & year)
                'Console.WriteLine("Expiry date: " & expiryDateString)


                'MessageBox.Show("Credit card number: " & cardNumber)
                Card_Number_lbl.Text = cardNumber
                Member_Since_lbl.Text = month & "/" & year
                Valid_Thru_lbl.Text = expiryMonth & "/" & expiryYear

                'MessageBox.Show(bank_username)

                Dim query2 = "SELECT Name
                 From BankUserData
                WHERE Username = '" & bank_username & "';"

                Dim cmd2 = New MySqlCommand(query2, conn)
                Dim reader2 = cmd2.ExecuteReader
                Dim sqlDt2 As New DataTable
                sqlDt2.Load(reader2)

                Dim Name As String = sqlDt2.Rows(0)("Name").ToString()
                Name_lbl.Text = Name

                reader2.Close()
                ' sqlDt.Load(reader)
                ' reader.Close()


            End If



            'query = "SELECT Name From UserData
            '   WHERE Bank_Account_Number = " & bank_account_number & ";"
            'cmd = New MySqlCommand(query, conn)
            'reader = cmd.ExecuteReader
            'sqlDt.Load(reader)
            'reader.Close()
            'If sqlDt.Rows.Count = 0 Then
            'MessageBox.Show("No user found with current details.")
            'Else
            'Dim Name As String = sqlDt.Rows(0)("Name").ToString()
            'MessageBox.Show("Credit card number: " & cardNumber)
            'Name_lbl.Text = Name

            'End If


            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: {0}", ex.Message)
            conn.Close()
        End Try

    End Sub


End Class