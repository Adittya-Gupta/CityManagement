Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Banking_Money_Management_Debit_Card
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    'Dim connString As String = "server=localhost;userid=root;password=Aasneh18;database=bankingdatabase;"
    Dim connString As String = Global_Attributes.slqConnection_banking

    Dim conn As New MySqlConnection(connString)
    Public bank_account_no As String = "1"

    Function add_space(inputString As String) As String
        Dim outputString As String = ""
        Dim spacesToAdd As Integer = 19 - inputString.Length
        For i As Integer = 0 To spacesToAdd - 1
            outputString &= " "
        Next
        For i As Integer = 0 To inputString.Length - 1
            outputString &= inputString(i)
            If (i + 1) Mod 4 = 0 AndAlso (i + 1) <> inputString.Length Then
                outputString &= " "
            End If
        Next
        Return outputString
    End Function



    Private Sub CalculateBankAccNo()
        Dim sqlDt As New DataTable
        sqlDt.Clear()
        conn.Open()
        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = conn
        sqlCmd.CommandText = "Select Bank_Account_Number from BankUserData where Username = '" & Global_Attributes.banking_username & "';"
        Using reader As MySqlDataReader = sqlCmd.ExecuteReader()
            If reader.Read() Then
                bank_account_no = reader.GetString("Bank_Account_Number")
            End If
        End Using
        conn.Close()
        sqlCmd.Dispose()
    End Sub
    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Dim card As String
    Dim expiry As String
    Dim cvv As String
    Dim remark As String

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        CalculateBankAccNo()
        RichTextBox_Card.Text = RichTextBox_Card.Text.Trim()
        RichTextBox_Expiry.Text = RichTextBox_Expiry.Text.Trim()
        RichTextBox_Cvv.Text = RichTextBox_Cvv.Text.Trim()
        RichTextBox_Remark.Text = RichTextBox_Remark.Text.Trim()

        card = RichTextBox_Card.Text
        expiry = RichTextBox_Expiry.Text
        cvv = RichTextBox_Cvv.Text
        Dim spaced_card As String = Add_space(card)
        remark = RichTextBox_Remark.Text

        If Not card <> "" Then
            MessageBox.Show("Please enter Card Number.")
        ElseIf Not expiry <> "" Then
            MessageBox.Show("Please enter Expiry Date.")
        ElseIf Not cvv <> "" Then
            MessageBox.Show("Please enter CVV.")
        ElseIf Not remark <> "" Then
            MessageBox.Show("Please enter remark.")
        Else
            Try
                conn.Open()
                Dim query = "SELECT * FROM BankCreditDebitCard Where CardNumber = '" & card & "' AND Cvv = " & cvv & " AND Type = 'DEBIT' AND Expiry_Date = '" & expiry & "' ;"
                Dim cmd = New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                Dim sqlDt As New DataTable
                sqlDt.Load(reader)
                reader.Close()
                conn.Close()

                If sqlDt.Rows.Count = 0 Then
                    MessageBox.Show("Wrong Card Details.")
                Else
                    conn.Open()
                    query = "SELECT * FROM BankUserData Where Username = '" & CType(sqlDt.Rows(0)("bank_username"), String) & "' ;"
                    cmd = New MySqlCommand(query, conn)
                    reader = cmd.ExecuteReader
                    Dim sqlDt2 As New DataTable
                    sqlDt2.Load(reader)
                    reader.Close()
                    conn.Close()

                    Dim balance As Single = CType(sqlDt2.Rows(0)("Balance"), Single)
                    If Banking_Money_Management_Homepage.amount > balance Then
                        MessageBox.Show("Insufficient Balance.")
                    Else
                        conn.Open()
                        ' withdraw
                        query = "UPDATE BankUserData SET Balance = Balance - " & Banking_Money_Management_Homepage.amount & " Where Username = '" & CType(sqlDt.Rows(0)("bank_username"), String) & "' ;"
                        cmd = New MySqlCommand(query, conn)
                        reader = cmd.ExecuteReader
                        reader.Close()

                        ' deposit
                        query = "UPDATE BankUserData SET Balance = Balance + " & Banking_Money_Management_Homepage.amount & " Where Bank_Account_Number = '" & Banking_Money_Management_Homepage.account_number & "' ;"
                        cmd = New MySqlCommand(query, conn)
                        reader = cmd.ExecuteReader
                        reader.Close()

                        ' log
                        'query = "Insert Into BankTransactionLog(Bank_Account_Number,Involved_Bank_Account_Number,Type_of_Transaction,Amount,Date_Time,Description) Values ('" & CType(sqlDt.Rows(0)("Bank_Account_Number"), String) & "','" & CType(Banking_Money_Management_Homepage.sqlDt.Rows(0)("Bank_Account_Number"), String) & "','Money Transfer'," & Banking_Money_Management_Homepage.amount & ",NOW(),'" & remark & "');"
                        'cmd = New MySqlCommand(query, conn)
                        'reader = cmd.ExecuteReader

                        reader.Close()
                        conn.Close()
                        'Money_Management_Final.Show()
                        ChildForm(Banking_Main.Panel1, Banking_Money_Management_Final)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error: {0}", ex.Message)
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class