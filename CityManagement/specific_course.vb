Imports MySql.Data.MySqlClient
Imports System.IO

Public Class specific_course
    Dim connString As String = Globals.connectionstring
    Dim conn As New MySqlConnection(connString)
    Public course_price As Integer
    Private userid As Integer
    Public prof_id As Integer
    Public prof_bank_username As String

    Public Sub SetUserID(id As Integer)
        userid = id
    End Sub

    Private _courseId As Integer ' Change from CourseId to _courseId to avoid confusion with the parameter name

    ' Constructor that accepts courseId as argument
    Public Sub New(courseId As Integer)
        InitializeComponent()
        _courseId = courseId ' Assign the parameter value to the class member
    End Sub

    Public Sub CalculateBankAccNumber()
        'conn.ConnectionString = Global_Attributes.slqConnection_banking
        ' sqlDt.Clear()
        'Mysqlconn.Open()
        conn.Open()
        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = conn
        sqlCmd.CommandText = "Select Username from BankUserData where '" & prof_id & "';"
        Using reader As MySqlDataReader = sqlCmd.ExecuteReader()
            If reader.Read() Then
                prof_bank_username = reader.GetString("Bank_Account_Number")
            End If
        End Using
        conn.Close()
        sqlCmd.Dispose()
    End Sub

    Private Sub specific_course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            Dim query As String = "SELECT c.user_id as prof_id, c.course_name, c.course_description, c.course_photo, c.no_of_studenroll, u.Name as UserName FROM Courses c INNER JOIN User u ON c.user_id = u.SID WHERE c.course_id = " & _courseId
            Dim cmd As New MySqlCommand(query, conn)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Label3.Text = reader("course_name").ToString()
                    TextBox1.Text = reader("course_description").ToString()
                    prof_id = Convert.ToInt32(reader("prof_id"))
                    ' Load course photo from database
                    Dim imageData As Byte() = DirectCast(reader("course_photo"), Byte())
                    If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                        Using ms As New MemoryStream(imageData)
                            PictureBox1.Image = Image.FromStream(ms)
                        End Using
                    End If
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    Label1.Text = reader("no_of_studenroll").ToString()
                    Label2.Text = reader("UserName").ToString() ' Display user name
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Button3.Show()

        If banking_payment_done = 1 Then
            ' Your banking payment logic here
        End If

        ' Check user's payment status and update Button1 text
        UpdateButton1Text()
    End Sub

    Private Sub UpdateButton1Text()
        Dim requestStatus As Integer = GetRequestStatus()

        If requestStatus = -1 Then
            ' If user is not found in CourseRequests, add a new entry
            AddCourseRequest()
        ElseIf requestStatus = 0 Then
            ' If request_status is 0, show text in Button1 as Pending
            Button1.Text = "Pending"
        ElseIf requestStatus = 1 AndAlso CheckPayment() = 0 Then
            ' If request_status is 1 and payment_status is 0, make Button1 invisible
            Button1.Visible = False
        ElseIf requestStatus = 1 AndAlso CheckPayment() = 1 Then
            ' If both request_status and payment_status are 1, then display text on Button1 as Enrolled
            Button1.Text = "Enrolled"
        End If
    End Sub

    Private Function GetRequestStatus() As Integer
        Dim requestStatus As Integer = -1 ' Initialize as -1 indicating user not found

        ' Query to check if the user is in CourseRequests table
        Dim query As String = "SELECT request_status FROM CourseRequests WHERE course_id = " & _courseId & " AND user_id = " & userid

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    requestStatus = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return requestStatus
    End Function

    Private Sub AddCourseRequest()
        ' Add a new entry with request_status 0 and payment_status 0
        Dim query As String = "INSERT INTO CourseRequests (course_id, user_id, request_status, paymemt_status) VALUES (@course_id, @user_id, 0, 0)"

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@course_id", _courseId)
                cmd.Parameters.AddWithValue("@user_id", userid)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                Button1.Text = "Pending"
            End Using
        End Using
    End Sub

    Private Function CheckPayment() As Integer
        Dim res As Integer = 0
        conn.ConnectionString = connString ' Set connection string before opening connection
        conn.Open()
        Dim query As String = "SELECT paymemt_status FROM CourseRequests WHERE course_id = " & _courseId & " AND user_id = " & userid
        Dim sqlCmd As New MySqlCommand(query, conn)
        Using reader As MySqlDataReader = sqlCmd.ExecuteReader()
            If reader.Read() Then
                res = reader.GetInt32("paymemt_status")
            End If
        End Using
        conn.Close()
        Return res
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check user's payment status and update Button1 text
        UpdateButton1Text()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Your button click logic here
        banking_recv_username = prof_bank_username
        banking_recv_name = "Vallabh"

        Go_Back = 2
        Go_Back_Form = Me
        banking_payment_amount = 100

        Banking_Main.Panel1.Controls.Clear()
        Newsletter_Main.Panel1.Controls.Clear()

        ChildForm(Banking_Main.Panel1, Banking_Homepage)
        mypanel.panel1.Controls.Clear()
        ChildForm2(Banking_Main)
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

    Public Shared Sub ChildForm2(ByVal childform As Form)
        mypanel.panel1.Controls.Clear()
        childform.TopLevel = False
        mypanel.panel1.Controls.Add(childform)
        childform.Show()
    End Sub

    Private Sub GetCoursePrice()
        ' Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        conn.ConnectionString = connString ' Set connection string before opening connection

        conn.Open()
        Dim query As String = "SELECT * FROM Courses where course_id = " & _courseId & ""  ' Put course id.
        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = conn
        sqlCmd.CommandText = query
        Using reader As MySqlDataReader = sqlCmd.ExecuteReader()
            If reader.Read() Then
                course_price = reader.GetInt32("course_price")
            End If
        End Using
        conn.Close()
        sqlCmd.Dispose()
    End Sub

End Class
