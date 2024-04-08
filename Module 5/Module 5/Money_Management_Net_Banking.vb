Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Money_Management_Net_Banking
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Dim username As String
    Dim password As String
    Dim remark As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox_Username.Text = RichTextBox_Username.Text.Trim()
        RichTextBox_Password.Text = RichTextBox_Password.Text.Trim()
        RichTextBox_Remark.Text = RichTextBox_Remark.Text.Trim()

        username = RichTextBox_Username.Text
        password = RichTextBox_Password.Text
        remark = RichTextBox_Remark.Text

        If Not username <> "" Then
            MessageBox.Show("Please enter username.")
        ElseIf Not password <> "" Then
            MessageBox.Show("Please enter password.")
        ElseIf Not remark <> "" Then
            MessageBox.Show("Please enter remark.")
        Else
            Try
                conn.Open()
                Dim query = "SELECT * FROM UserData Where Username = '" & username & "' AND Password = '" & password & "' ;"
                Dim cmd = New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                Dim sqlDt As New DataTable
                sqlDt.Load(reader)
                reader.Close()
                conn.Close()

                If sqlDt.Rows.Count = 0 Then
                    MessageBox.Show("Wrong Username or Password.")
                Else
                    Dim balance As Single = CType(sqlDt.Rows(0)("Balance"), Single)
                    If Money_Management_Homepage.amount > balance Then
                        MessageBox.Show("Insufficient Balane.")
                    Else
                        conn.Open()
                        ' withdraw
                        query = "UPDATE UserData SET Balance = Balance - " & Money_Management_Homepage.amount & " Where Username = '" & username & "' AND Password = '" & password & "' ;"
                        cmd = New MySqlCommand(query, conn)
                        reader = cmd.ExecuteReader
                        reader.Close()

                        ' deposit
                        query = "UPDATE UserData SET Balance = Balance + " & Money_Management_Homepage.amount & " Where Bank_Account_Number = '" & Money_Management_Homepage.account_number & "' ;"
                        cmd = New MySqlCommand(query, conn)
                        reader = cmd.ExecuteReader
                        reader.Close()

                        ' log
                        query = "Insert Into TransactionLog(Bank_Account_Number,Involved_Bank_Account_Number,Type_of_Transaction,Amount,Date_Time,Description) Values ('" & CType(sqlDt.Rows(0)("Bank_Account_Number"), String) & "','" & CType(Money_Management_Homepage.sqlDt.Rows(0)("Bank_Account_Number"), String) & "','Money Transfer'," & Money_Management_Homepage.amount & ",'0000-00-00','" & remark & "');"
                        cmd = New MySqlCommand(query, conn)
                        reader = cmd.ExecuteReader
                        reader.Close()
                        conn.Close()
                        Money_Management_Final.Show()
                    End If

                End If
            Catch ex As Exception
                MessageBox.Show("Error: {0}", ex.Message)
            End Try
        End If
    End Sub
End Class