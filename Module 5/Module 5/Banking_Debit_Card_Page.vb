Imports MySql.Data.MySqlClient
Public Class Banking_Debit_Card_Page

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Public bank_username As String = "admin"
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    'Dim connString As String = "server=localhost;userid=root;password=Aasneh18;database=bankingdatabase;"
    Dim connString As String = Global_Attributes.slqConnection_banking

    Dim conn As New MySqlConnection(connString)
    Dim bank_account_number As Integer = 123
    Private Sub Banking_Debit_Card_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        banking_username = Global_Attributes.banking_username

        Try
            conn.Open()

            Dim query = "SELECT CardNumber,Join_date
                 FROM CreditDebitCard
                WHERE Type='DEBIT' and bank_username = '" & bank_username & "';"

            Dim cmd = New MySqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader
            Dim sqlDt As New DataTable
            sqlDt.Load(reader)
            reader.Close()
            If sqlDt.Rows.Count = 0 Then
                'MessageBox.Show("No user found with current details.")
                Dim rand As New Random()
                Dim randomNumber1 As Integer = rand.Next(1000, 9000)
                Dim randomNumber2 As Integer = rand.Next(1000, 9000)
                Dim randomNumber3 As Integer = rand.Next(1000, 9000)
                Dim randomNumber4 As Integer = 4592
                Dim randomString As String = randomNumber4.ToString() & " " & randomNumber1.ToString() & " " & randomNumber2.ToString() & " " & randomNumber3.ToString()

                'Console.WriteLine("Concatenated random numbers: " & randomString)



                Dim query3 = "INSERT INTO CreditDebitCard (CardNumber, bank_username, Type, CIBIL_Score, Cvv)
                        VALUES ('" & randomString & "','" & bank_username & "', 
                            'DEBIT', 0, 500);"

                Dim cmd3 = New MySqlCommand(query3, conn)
                Dim reader3 = cmd3.ExecuteReader

                'Dim sqlDt2 As New DataTable
                'sqlDt2.Load(reader2)
                reader3.Close()

                Dim query4 = "SELECT CardNumber,Join_date
                 FROM CreditDebitCard
                WHERE Type='DEBIT' and bank_username = '" & bank_username & "';"

                Dim cmd4 = New MySqlCommand(query4, conn)
                Dim reader4 = cmd4.ExecuteReader
                Dim sqlDt4 As New DataTable
                sqlDt4.Load(reader4)
                reader4.Close()

                Dim cardNumber As String = sqlDt4.Rows(0)("CardNumber").ToString()
                Dim dateString As String = sqlDt4.Rows(0)("Join_date").ToString()



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


                Dim query5 = "SELECT Name
                 From UserData
                WHERE Username = '" & bank_username & "';"

                Dim cmd5 = New MySqlCommand(query5, conn)
                Dim reader5 = cmd5.ExecuteReader
                Dim sqlDt5 As New DataTable
                sqlDt5.Load(reader5)

                Dim Name As String = sqlDt5.Rows(0)("Name").ToString()
                Name_lbl.Text = Name

                reader5.Close()


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


                Dim query2 = "SELECT Name
                 From UserData
                WHERE Username = '" & bank_username & "';"

                Dim cmd2 = New MySqlCommand(query2, conn)
                Dim reader2 = cmd2.ExecuteReader
                Dim sqlDt2 As New DataTable
                sqlDt2.Load(reader2)

                Dim Name As String = sqlDt2.Rows(0)("Name").ToString()
                Name_lbl.Text = Name

                reader2.Close()
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: {0}", ex.Message)
            conn.Close()
        End Try

    End Sub


End Class