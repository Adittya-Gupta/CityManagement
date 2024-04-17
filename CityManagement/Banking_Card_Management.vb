Imports Mysqlx.Expect.Open.Types
Imports MySql.Data.MySqlClient

Public Class Banking_Card_Management
    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Public bank_username As String = "samuel"
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    'Dim connString As String = "server=localhost;userid=root;password=Aasneh18;database=bankingdatabase;"
    Dim connString As String = Global_Attributes.slqConnection_banking

    Dim conn As New MySqlConnection(connString)
    Dim has_credit_card As Boolean = False

    Private Sub Debit_Card_btn_Click(sender As Object, e As EventArgs) Handles Debit_Card_btn.Click
        ' Create an instance of the new form

        ' Show the new form
        'form2.Show()
        Banking_Debit_Card_Page.bank_username = bank_username
        ChildForm(Banking_Main.Panel1, Banking_Debit_Card_Page)

    End Sub

    Private Sub Credit_Card_btn_Click(sender As Object, e As EventArgs) Handles Credit_Card_btn.Click
        If has_credit_card Then
            ' Open form1
            'Dim form1 As New Banking_Credit_Card_Page()
            'form1.Show()
            Banking_Credit_Card_Page.bank_username = bank_username
            ChildForm(Banking_Main.Panel1, Banking_Credit_Card_Page)
        Else
            'Open form2
            Banking_Apply_Credit_Card.bank_username = bank_username
            ChildForm(Banking_Main.Panel1, Banking_Apply_Credit_Card)
        End If
        ' Close the current form
        'Me.Hide()

    End Sub

    Private Sub Banking_Card_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim bank_account_number As Integer = 123
        'MessageBox.Show(bank_username)
        banking_username = Global_Attributes.banking_username
        Try
            conn.Open()


            Dim query = "SELECT CardNumber, Type, CIBIL_Score, Expiry_Date, Cvv
                 FROM BankCreditDebitCard
                WHERE Type='CREDIT' and bank_username = '" & bank_username & "';"

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