Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Money_Management_Debit_Card
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Dim card_no As String
    Dim expiry_date As String
    Dim cvv As String
    Dim pin As String
    Dim remark As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox_Card_Number.Text = RichTextBox_Card_Number.Text.Trim()
        RichTextBox_Expiry_Date.Text = RichTextBox_Expiry_Date.Text.Trim()
        RichTextBox_CVV.Text = RichTextBox_CVV.Text.Trim()
        RichTextBox_PIN.Text = RichTextBox_PIN.Text.Trim()
        RichTextBox_Remark.Text = RichTextBox_Remark.Text.Trim()

        card_no = RichTextBox_Card_Number.Text
        expiry_date = RichTextBox_Expiry_Date.Text
        cvv = RichTextBox_CVV.Text
        pin = RichTextBox_PIN.Text
        remark = RichTextBox_Remark.Text

        If Not card_no <> "" Then
            MessageBox.Show("Please enter Card Number.")
        ElseIf Not expiry_date <> "" Then
            MessageBox.Show("Please enter Expiry Date.")
        ElseIf Not cvv <> "" Then
            MessageBox.Show("Please enter CVV.")
        ElseIf Not pin <> "" Then
            MessageBox.Show("Please enter PIN.")
        ElseIf Not remark <> "" Then
            MessageBox.Show("Please enter remark.")
        Else
            Try
                conn.Open()
                Dim query = "SELECT * FROM CreditDebitCard Where CardNumber =' " & card_no & "' AND Cvv = '" & cvv & "' ;"
                Dim cmd = New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                Dim sqlDt As New DataTable
                sqlDt.Load(reader)
                reader.Close()

                If sqlDt.Rows.Count = 0 Then
                    MessageBox.Show("No Card Details Found.")
                Else
                    MessageBox.Show("Card Details Found")
                End If

                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error: {0}", ex.Message)
                conn.Close()
            End Try
        End If

    End Sub
End Class