Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Banking_Apply_Credit_Card

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

    'Dim can_apply As Boolean = True
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none"
    'Dim connString As String = "server=localhost;userid=root;password=Aasneh18;database=bankingdatabase;"
    Dim connString As String = Global_Attributes.slqConnection_banking

    Dim conn As New MySqlConnection(connString)
    Dim bank_account_number As Integer = 123
    Private Sub Apply_btn_Click(sender As Object, e As EventArgs) Handles Apply_btn.Click
        banking_username = Global_Attributes.banking_username
        Dim can_apply As Boolean = True
        If CheckBox.Checked Then
            can_apply = False
            MessageBox.Show("You are not eligible for a credit card !!")
        End If
        Dim income As String = Income_tb.Text
        Dim num As Integer
        If Integer.TryParse(income, num) Then
            ' Valid integer input
            'MessageBox.Show($"{num}")
            If num < 600000 Then
                can_apply = False
                MessageBox.Show("You are not eligible for a credit card !!")
            End If
        Else
            ' Invalid integer input
            MessageBox.Show("Please enter a valid salary !!")
            can_apply = False
        End If

        If Income_Proof_tb.Text = "" Then
            MessageBox.Show("Please enter a valid income proof !!")
            can_apply = False
        End If



        If can_apply Then

            Try
                conn.Open()
                Dim rand As New Random()
                Dim randomNumber1 As Integer = rand.Next(1000, 9000)
                Dim randomNumber2 As Integer = rand.Next(1000, 9000)
                Dim randomNumber3 As Integer = rand.Next(1000, 9000)
                Dim randomNumber4 As Integer = 4592
                Dim randomString As String = randomNumber4.ToString() & " " & randomNumber1.ToString() & " " & randomNumber2.ToString() & " " & randomNumber3.ToString()

                'Console.WriteLine("Concatenated random numbers: " & randomString)



                Dim query = "INSERT INTO CreditDebitCard (CardNumber, bank_username, Type, CIBIL_Score, Cvv)
                        VALUES ('" & randomString & "','" & bank_username & "', 
                            'CREDIT', 0, 500);"

                Dim cmd = New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                Dim sqlDt As New DataTable
                sqlDt.Load(reader)
                reader.Close()

                conn.Close()

                MessageBox.Show("You have been granted a Credit Card")

                'Dim form1 As New Banking_Credit_Card_Page()
                'form1.Show()
                'Me.Hide()
                Banking_Credit_Card_Page.bank_username = bank_username
                ChildForm(Banking_Main.Panel1, Banking_Credit_Card_Page)


            Catch ex As Exception
                MessageBox.Show("Error: {0}", ex.Message)
                conn.Close()
            End Try

        End If
    End Sub


    Private Sub Choose_btn_Click(sender As Object, e As EventArgs) Handles Choose_btn.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set properties of the OpenFileDialog
        openFileDialog.Title = "Select a file"
        openFileDialog.Filter = "All files (*.*)|*.*"
        openFileDialog.InitialDirectory = "C:\"

        ' Display the OpenFileDialog and get the result
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Retrieve the selected file path
            Dim selectedFilePath As String = openFileDialog.FileName
            Dim selectedFileName As String = Path.GetFileName(selectedFilePath)
            Income_Proof_tb.Text = selectedFileName
            ' Do something with the selected file path
            'MessageBox.Show("Selected file: " & selectedFilePath)
        End If
    End Sub

    Private Sub Banking_Apply_Credit_Card_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        banking_username = Global_Attributes.banking_username
    End Sub
End Class