Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Banking_LoanDetails
    Public loan_type As String
    Public bank_username As String
    'Interest Rates- will be passed on every loans page
    Public Home_IR As Double
    Public Edu_IR As Double
    Public Busn_LowRisk_IR As Double
    Public Busn_HighRisk_IR As Double
    Public Transport_IR As Double
    Public Personal_Medical_IR As Double
    Public Personal_Otherwise_IR As Double

    'user info
    Dim CIBIL_score As Double
    Dim CustomerName As String
    Dim AC_no As String
    Dim email As String

    Public Mysqlconn As New MySqlConnection
    Public sqlRd As MySqlDataReader
    Public sqlDt As New DataTable
    Public Dta As New MySqlDataAdapter
    Public SqlQuery As String

    'Public server As String = "172.16.114.244"
    'Public username As String = "admin"
    'Public password As String = "nimda"
    'Public database As String = "banking_database"

    ' Public server As String = "localhost"
    ' Public username As String = "root"
    ' Public password As String = "vacuum#28C"
    'Public database As String = "banking_database"

    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "bankingdatabase"

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub



    Private Sub Banking_LoanDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--------------obtain user info----------------
        bank_username = Global_Attributes.banking_username
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_banking

        Mysqlconn.Open()   'Open the connection

        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = Mysqlconn
        'select the user info
        sqlCmd.CommandText = "SELECT * FROM userdata WHERE Username='" & bank_username & "';"
        Dim adapter As New MySqlDataAdapter(sqlCmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ' Check if the DataTable contains any rows
        If table.Rows.Count > 0 Then
            ' Retrieve the value from the first row and first column
            AC_no = table.Rows(0)("Bank_Account_Number").ToString()
            CustomerName = table.Rows(0)("Name").ToString()
            CIBIL_score = Double.Parse(table.Rows(0)("CIBIL_score").ToString())
            email = table.Rows(0)("Email_ID").ToString()
        End If

        Mysqlconn.Close()
        sqlCmd.Dispose()

        'autofill info in details page
        Name_tb.Text = CustomerName
        ACno_tb.Text = AC_no
        CIBILscore_tb.Text = CIBIL_score.ToString()

        If loan_type = "Home" Then
            ListBox1.SelectedIndex = 0
            InterestRate_tb.Text = Home_IR.ToString()
        ElseIf loan_type = "Education" Then
            ListBox1.SelectedIndex = 1
            InterestRate_tb.Text = Edu_IR.ToString()
        ElseIf loan_type = "Personal" Then
            ListBox1.SelectedIndex = 2
            InterestRate_tb.Text = Personal_Medical_IR.ToString()
        ElseIf loan_type = "Transport" Then
            ListBox1.SelectedIndex = 6
            InterestRate_tb.Text = Transport_IR.ToString()
        ElseIf loan_type = "Business" Then
            ListBox1.SelectedIndex = 4
            InterestRate_tb.Text = Busn_LowRisk_IR.ToString()
        End If

    End Sub

    Private Sub Submit_btn_Click(sender As Object, e As EventArgs) Handles Submit_btn.Click
        '-------------------------Performing form validation----------------------
        Dim flag As Boolean = True 'initially no errors assumed

        If Name_tb.Text <> CustomerName Then
            flag = False
            MessageBox.Show("Your name does not match official records.")
        End If

        If ACno_tb.Text <> AC_no Then
            flag = False
            MessageBox.Show("Your Account No does not match official records.")
        End If

        If CIBILscore_tb.Text <> CIBIL_score.ToString() Then
            flag = False
            MessageBox.Show("Your CIBIL_score does not match official records.")
        End If

        If Email_tb.Text <> email Then
            flag = False
            MessageBox.Show("Your email does not match official records.")
        End If

        Dim p As Double
        If Double.TryParse(Principal_tb.Text, p) And p < 10000000 Then 'max 1cr loan
            'do nothing
        Else
            flag = False
            MessageBox.Show("You must enter a numerical value between 0 and 1,00,00,000.")
        End If

        If Double.TryParse(Duration_tb.Text, p) And p < 20 Then 'max 20 yrs allowed
            'do nothing
        Else
            flag = False
            MessageBox.Show("You must enter a numerical value between 0 and 20 years.")
        End If

        If CheckBox1.Checked = False Then
            flag = False
            MessageBox.Show("You must agree to the terms and conditions.")
        End If

        If Double.TryParse(CIBILscore_tb.Text, p) And p > 450 Then
            'do nothing
        Else
            flag = False
            MessageBox.Show("Sorry you cannot apply for the loan, as your CIBIL score is less than 450.")
        End If

        'If flag is true after all the validation checks
        If flag = True Then
            '-----------------insert details into query DB-----------------------
            Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
            Mysqlconn.Open()   'Open the connection

            Dim sqlCmd As New MySqlCommand
            sqlCmd.Connection = Mysqlconn
            'select the user info
            sqlCmd.CommandText = "INSERT INTO querylog " &
                                "(Query_ID, Bank_Account_Number, Type_of_Query, Day, Query, Status, Reply) " &
                                "VALUES (@Value1, @Value2, 'Loan request', @Value3, @Value4, 'pending', 'pending');"

            ' Add parameter values
            Dim random As New Random()
            Dim r As Integer = random.Next(1000, 10000) 'query ID generated randomly
            Dim currentDate As Date = Date.Today
            Dim query_body As String = ""
            query_body &= "Amount= Rs" & Principal_tb.Text & "/- "
            query_body &= "Duration= " & Duration_tb.Text & "years "
            query_body &= "Purpose= " & Purpose_tb.Text

            sqlCmd.Parameters.AddWithValue("@Value1", r.ToString()) 'query id
            sqlCmd.Parameters.AddWithValue("@Value2", AC_no)
            sqlCmd.Parameters.AddWithValue("@Value3", currentDate)
            sqlCmd.Parameters.AddWithValue("@Value4", query_body)

            ' Execute the command
            sqlCmd.ExecuteNonQuery()
            'Close the connection
            Mysqlconn.Close()
            sqlCmd.Dispose()

            '-------------clear the form----------------
            Name_tb.Clear()
            ACno_tb.Clear()
            Purpose_tb.Clear()
            CIBILscore_tb.Clear()
            Email_tb.Clear()
            Aadhar_tb.Clear()
            Principal_tb.Clear()
            InterestRate_tb.Clear()
            Duration_tb.Clear()

            MessageBox.Show("Submit Success!")
        End If

    End Sub

    'Private Sub Loans_btn_Click(sender As Object, e As EventArgs) 
    '  Me.Hide()
    '     Banking_LoanHomepage.Show()
    '  End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'TODO: make interest tb as readonly
        If ListBox1.SelectedIndex = 0 Then
            InterestRate_tb.Text = Home_IR.ToString()
        ElseIf ListBox1.SelectedIndex = 1 Then
            InterestRate_tb.Text = Edu_IR.ToString()
        ElseIf ListBox1.SelectedIndex = 2 Then
            InterestRate_tb.Text = Personal_Medical_IR.ToString()
        ElseIf ListBox1.SelectedIndex = 3 Then
            InterestRate_tb.Text = Personal_Otherwise_IR.ToString()
        ElseIf ListBox1.SelectedIndex = 4 Then
            InterestRate_tb.Text = Busn_LowRisk_IR.ToString()
        ElseIf ListBox1.SelectedIndex = 5 Then
            InterestRate_tb.Text = Busn_HighRisk_IR.ToString()
        ElseIf ListBox1.SelectedIndex = 6 Then
            InterestRate_tb.Text = Transport_IR.ToString()
        End If
    End Sub
End Class