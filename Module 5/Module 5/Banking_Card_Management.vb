Imports Mysqlx.Expect.Open.Types
Imports MySql.Data.MySqlClient

Public Class Banking_Card_Management
    Public bank_username As String = "admin"
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim has_credit_card As Boolean = False

    Private Sub Debit_Card_btn_Click(sender As Object, e As EventArgs) Handles Debit_Card_btn.Click
        ' Create an instance of the new form
        Dim form2 As New Banking_Debit_Card_Page()

        ' Show the new form
        'form2.Show()
        ' Close the current form
        'Me.Hide()
        Dim childForm As New Banking_Debit_Card_Page()

        ' Set the bank username property of the new child form
        childForm.bank_username = Me.bank_username

        ' Access the parent form and call the ChildForm method to load the new child form

    End Sub

    Private Sub Credit_Card_btn_Click(sender As Object, e As EventArgs) Handles Credit_Card_btn.Click
        If has_credit_card Then
            ' Open form1
            Dim form1 As New Banking_Credit_Card_Page()
            form1.Show()
        Else
            'Open form2
            Dim form2 As New Banking_Apply_Credit_Card()
            form2.Show()
        End If
        ' Close the current form
        Me.Hide()

    End Sub

    Private Sub Banking_Card_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bank_account_number As Integer = 123

        Try
            conn.Open()


            Dim query = "SELECT CardNumber, Type, CIBIL_Score, Expiry_Date, Cvv
                 FROM CreditDebitCard
                WHERE Type='CREDIT' and Bank_Account_Number = " & bank_account_number & ";"

            Dim cmd = New MySqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader
            Dim sqlDt As New DataTable
            sqlDt.Load(reader)
            reader.Close()


            If sqlDt.Rows.Count = 0 Then
                'MessageBox.Show("No user found with current details.")
                has_credit_card = False
                Credit_Card_btn.Text = "Apply Credit Card"
            Else
                'Dim cardNumber As String = sqlDt.Rows(0)("CardNumber").ToString()
                'MessageBox.Show("Credit card number: " & cardNumber)
                has_credit_card = True
                Credit_Card_btn.Text = "My Credit Card"
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: {0}", ex.Message)
            conn.Close()
        End Try


    End Sub
End Class