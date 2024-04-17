Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Google.Protobuf.WellKnownTypes
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient

Public Class Banking_Money_Management_Homepage
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    'Dim connString As String = "server=localhost;userid=root;password=Aasneh18;database=bankingdatabase;"
    Dim connString As String = Global_Attributes.slqConnection_banking

    Dim conn As New MySqlConnection(connString)

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Public amount As Single
    Public account_number As String
    Public receiver_name As String
    Public sqlDt As New DataTable
    Public recv_account_number As String
    Private Sub CalculateBankAccNo()
        sqlDt.Clear()
        conn.Open()
        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = conn
        sqlCmd.CommandText = "Select Bank_Account_Number from BankUserData where Username = '" & Global_Attributes.banking_recv_username & "';"
        Using reader As MySqlDataReader = sqlCmd.ExecuteReader()
            If reader.Read() Then
                RichTextBox_Account_Number.Text = reader.GetString("Bank_Account_Number")
            End If
        End Using
        conn.Close()
        sqlCmd.Dispose()
    End Sub
    Private Sub Button_Continue_Payment_Click(sender As Object, e As EventArgs) Handles Button_Continue_Payment.Click
        RichTextBox_Name.Text = RichTextBox_Name.Text.Trim()
        RichTextBox_Amount.Text = RichTextBox_Amount.Text.Trim()
        RichTextBox_Account_Number.Text = RichTextBox_Account_Number.Text.Trim()

        account_number = RichTextBox_Account_Number.Text
        receiver_name = RichTextBox_Name.Text
        If Not RichTextBox_Amount.Text <> "" Then
            MessageBox.Show("Please enter an Amount.")
        ElseIf Not Single.TryParse(RichTextBox_Amount.Text, amount) Then
            MessageBox.Show("Please enter a valid Amount.")
        ElseIf Not RichTextBox_Account_Number.Text <> "" Then
            MessageBox.Show("Please enter an Account Number.")
        ElseIf Not RichTextBox_Name.Text <> "" Then
            MessageBox.Show("Please enter a name.")
        ElseIf ComboBox_Mode_of_Payment.SelectedIndex = -1 Then
            MessageBox.Show("Please select a mode of payment.")
        Else
            Try
                conn.Open()
                Dim query = "SELECT * FROM BankUserData Where Bank_Account_Number = '" & account_number & "' AND Name = '" & receiver_name & "' ;"
                Dim cmd = New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                sqlDt.Load(reader)
                reader.Close()
                conn.Close()

                If sqlDt.Rows.Count = 0 Then
                    MessageBox.Show("No user found with current details.")
                Else
                    recv_account_number = sqlDt.Rows(0)("Bank_Account_Number").ToString()
                    If ComboBox_Mode_of_Payment.SelectedIndex = 0 Then
                        'Money_Management_Net_Banking.Show()
                        ChildForm(Banking_Main.Panel1, Banking_Money_Management_Net_Banking)
                    ElseIf ComboBox_Mode_of_Payment.SelectedIndex = 1 Then
                        'Money_Management_Credit_Card.Show()
                        ChildForm(Banking_Main.Panel1, Banking_Money_Management_Credit_Card)
                    Else
                        'Money_Management_Debit_Card.Show()
                        ChildForm(Banking_Main.Panel1, Banking_Money_Management_Debit_Card)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error: {0}", ex.Message)
            End Try
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RichTextBox_Account_Number_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox_Account_Number.TextChanged

    End Sub

    Private Sub Banking_Money_Management_Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox_Name.Text = receiver_name
        RichTextBox_Amount.Text = amount.ToString
        RichTextBox_Account_Number.Text = account_number
        If banking_recv_username <> "" Then
            CalculateBankAccNo()
        End If
        If banking_payment_amount <> 0 Then
            RichTextBox_Amount.Text = Global_Attributes.banking_payment_amount.ToString()
        End If
        If banking_recv_name <> "" Then
            RichTextBox_Name.Text = Global_Attributes.banking_recv_name.ToString()
        End If
        If Global_Attributes.Go_Back = 0 Then
            Go_Back_Form = Me
        End If
        Global_Attributes.banking_payment_done = 0

    End Sub

    Private Sub RichTextBox_Amount_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox_Amount.TextChanged

    End Sub

    Private Sub RichTextBox_Name_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox_Name.TextChanged

    End Sub
End Class