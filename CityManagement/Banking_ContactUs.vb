Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Banking_ContactUs
    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub





    Public Mysqlconn As New MySqlConnection
    'Public sqlCmd As New MySqlCommand
    Public sqlRd As MySqlDataReader
    Public sqlDt As New DataTable
    Public Dta As New MySqlDataAdapter
    Public SqlQuery As String

    ' Just change these to access local or online db
    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "bankingdatabase"

    'Public server As String = "172.16.114.244"
    ' Public username As String = "admin"
    ' Public password As String = "nimda"
    'Public database As String = "banking_database"

    Public bank_account_no As String = "1"
    Public bank_username As String = Global_Attributes.banking_username

    Private Sub CalculateBankAccNo()
        ' Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_banking

        sqlDt.Clear()
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "Select Bank_Account_Number from BankUserData where Username = '" & bank_username & "';"
        Using reader As MySqlDataReader = sqlCmd.ExecuteReader()
            If reader.Read() Then
                bank_account_no = reader.GetString("Bank_Account_Number")
            End If
        End Using
        Mysqlconn.Close()
        sqlCmd.Dispose()
    End Sub
    Private Sub CLearFields()
        TextBox2.Text = ""
    End Sub
    Private Sub InsertData()
        Dim query_type As String = ComboBox1.SelectedItem.ToString()
        ' Set the connection string property
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = slqConnection_banking
        sqlDt.Clear()
        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand

        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "INSERT INTO BankQueryLog(Bank_Account_Number,Type_of_Query,Day,Query,Status,Reply)" &
                             "VALUES (@BAN,'" & query_type & "',CURDATE(),'" & TextBox2.Text & "','PENDING','-');"

        sqlCmd.Parameters.Add("@BAN", MySqlDbType.VarChar).Value = bank_account_no


        If sqlCmd.ExecuteNonQuery() = 1 Then
            'MessageBox.Show("Sent to Publish!")
        Else
            MessageBox.Show("Some Error has occured!")
        End If
        ' Close the connection after use
        Mysqlconn.Close()
        sqlCmd.Dispose()
        MessageBox.Show("Query Sent!")
    End Sub
    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        Button16.BackColor = Color.FromArgb(1, 12, 40)
        Button17.BackColor = Color.FromArgb(1, 12, 40)
        Label12.BackColor = Color.FromArgb(1, 12, 40)
        Label13.BackColor = Color.FromArgb(1, 12, 40)

        ComboBox1.Items.Add("Bank Account Balance")
        ComboBox1.Items.Add("Check credit card outstanding amount")
        ComboBox1.Items.Add("Loan request")
        ComboBox1.Items.Add("Block Credit/Debit Card")
        ComboBox1.Items.Add("Report Unauthorised Transaction")
        ComboBox1.Items.Add("Others")
        CalculateBankAccNo()
        TextBox1.Text = bank_account_no

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        InsertData()
    End Sub


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click
        'Banking_Homepage.bank_username = bank_username
        ChildForm(Banking_Main.Panel1, Banking_Queries_User)
        'ChildForm(Banking_Queries_User)
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class