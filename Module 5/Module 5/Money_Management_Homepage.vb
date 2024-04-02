Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class Money_Management_Homepage
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Public amount As Integer
    Public account_number As String
    Public receiver_name As String
    Public ifsc_code As String
    Public sqlDt As New DataTable

    Private Sub Button_Continue_Payment_Click(sender As Object, e As EventArgs) Handles Button_Continue_Payment.Click
        RichTextBox_Name.Text = RichTextBox_Name.Text.Trim()
        RichTextBox_IFSC_Code.Text = RichTextBox_IFSC_Code.Text.Trim()
        RichTextBox_Amount.Text = RichTextBox_Amount.Text.Trim()
        RichTextBox_Account_Number.Text = RichTextBox_Account_Number.Text.Trim()

        account_number = RichTextBox_Account_Number.Text
        receiver_name = RichTextBox_Name.Text
        ifsc_code = RichTextBox_IFSC_Code.Text
        If Not RichTextBox_Amount.Text <> "" Then
            MessageBox.Show("Please enter an Amount.")
        ElseIf Not Integer.TryParse(RichTextBox_Amount.Text, amount) Then
            MessageBox.Show("Please enter a valid integer Amount.")
        ElseIf Not RichTextBox_Account_Number.Text <> "" Then
            MessageBox.Show("Please enter an Account Number.")
        ElseIf Not RichTextBox_Name.Text <> "" Then
            MessageBox.Show("Please enter an Account Number.")
        ElseIf Not RichTextBox_IFSC_Code.Text <> "" Then
            MessageBox.Show("Please enter the IFSC Code.")
        ElseIf ComboBox_Mode_of_Payment.SelectedIndex = -1 Then
            MessageBox.Show("Please select a mode of payment.")
        ElseIf ifsc_code <> "CB001IN" Then
            MessageBox.Show("Currently service available for our bank only.Set IFSC code = CB001IN")
        Else
            Try
                conn.Open()
                Dim query = "SELECT * FROM UserData Where Bank_Account_Number = '" & account_number & "' AND Name = '" & receiver_name & "' ;"
                Dim cmd = New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                sqlDt.Load(reader)
                reader.Close()

                If sqlDt.Rows.Count = 0 Then
                    MessageBox.Show("No user found with current details.")
                Else
                    If ComboBox_Mode_of_Payment.SelectedIndex = 0 Then
                        MessageBox.Show("Netbanking Selected")
                    ElseIf ComboBox_Mode_of_Payment.SelectedIndex = 1 Then
                        MessageBox.Show("Credit Card Selected.")
                    Else
                        MessageBox.Show("Debit Card Selected.")
                    End If
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error: {0}", ex.Message)
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub Money_Management_Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox_IFSC_Code.Text = "CB001IN"
    End Sub
End Class