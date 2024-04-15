Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Incoming_Emp_Req
    Private _parentForm As IncomingEmploymentReq
    Public _i As Integer
    Public _name As String
    Private _contactDetails As String
    Private _bankAccountNumber As Int64
    Private _anyPrevWork As String
    Private _userID As Int32
    Private _orgID As Int32

    Dim connString As String = Module1.connString
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Public Sub New(ParentForm As Form, ByVal dateValue As Date,
                   Optional ByVal name As String = "Name",
                   Optional ByVal i As Integer = 1,
                   Optional ByVal contactDetails As String = "contactDetails",
                   Optional ByVal bankAccountNumber As Int64 = 123,
                   Optional ByVal anyPrevWork As String = "anyPreviousWork",
                   Optional ByVal userID As Int32 = 123,
                   Optional ByVal orgID As Int32 = 101,
                   Optional ByVal img As Image = Nothing
        )
        '          Optional ByVal img As Image = Nothing

        InitializeComponent()

        _parentForm = ParentForm

        ' Set the values of the components based on the parameters
        Label1.Text = dateValue.ToString("dd MMM yyyy")
        Label4.Text = name
        _i = i
        _contactDetails = contactDetails
        _bankAccountNumber = bankAccountNumber
        _anyPrevWork = anyPrevWork
        _userID = userID
        _orgID = orgID
        _name = name

        If img IsNot Nothing Then
            PictureBox1.Image = img
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub RemoveSelfFromParentControl()
        _parentForm.Controls.Remove(Me)

        Dim index As Integer = _parentForm.Panel1.Controls.IndexOf(Me)
        'MsgBox("Index is " & index.ToString())
        'MsgBox("_parentForm.panel1.Controls.Count is " & _parentForm.Panel1.Controls.Count.ToString())
        For i As Integer = index + 1 To _parentForm.Panel1.Controls.Count - 1
            Dim ctrl As Control = _parentForm.Panel1.Controls(i)
            If TypeOf ctrl Is Incoming_Emp_Req Then
                Dim userCtrl As Incoming_Emp_Req = CType(ctrl, Incoming_Emp_Req)
                userCtrl._i -= 1
                'MsgBox("_i of " & userCtrl._name & " changed to " & userCtrl._i.ToString())
                userCtrl.Top = (userCtrl._i - 1) * 200
            End If
        Next

        _parentForm.Panel1.Height -= 200

        Me.Dispose()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' api call
        Try
            conn.Open()
            Dim query = "UPDATE workerEmployReq SET status = 'Approved' WHERE orgID = @A AND userID = @B;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@A", _orgID)
                cmd.Parameters.AddWithValue("@B", _userID)
                cmd.ExecuteNonQuery()
                RemoveSelfFromParentControl()
            End Using
        Catch ex As Exception
            MsgBox("Could not accept. Problem with database. " & ex.Message)
            Return
        End Try

        Dim msg As String = "Your employment request at org_id: " & _orgID & " has been confirmed. Time: " & Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim query2 As String = "INSERT INTO Notifications (UserID, Type, Message) " & "VALUES (@clientID, 0, @msg)"
        Using cmd2 As New MySqlCommand(query2, conn)
            cmd2.Parameters.AddWithValue("@clientID", _userID)
            cmd2.Parameters.AddWithValue("@msg", msg)
            cmd2.ExecuteNonQuery()
        End Using
        MessageBox.Show("Employment request confirmed. Notification sent to " & _name, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        'If newStatus = "Upcoming" Then
        '    ' Insert a notification for the client
        'ElseIf newStatus = "Rejected" Then
        '    ' Insert a notification for the client
        '    Dim msg As String = "Your service request has been rejected."
        '    Dim query2 As String = "INSERT INTO Notifications (UserID, Type, Message) " & "VALUES (@clientID, 0, @msg)"
        '    Using cmd2 As New MySqlCommand(query2, conn)
        '        cmd2.Parameters.AddWithValue("@clientID", clientID)
        '        cmd2.Parameters.AddWithValue("@msg", msg)
        '        cmd2.ExecuteNonQuery()
        '    End Using
        '    MessageBox.Show("Service request rejected. Notification sent to the client.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' api call
        Try
            conn.Open()
            Dim query = "UPDATE workerEmployReq SET status = 'Rejected' WHERE orgID = @A AND userID = @B;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@A", _orgID)
                cmd.Parameters.AddWithValue("@B", _userID)
                cmd.ExecuteNonQuery()
                RemoveSelfFromParentControl()
            End Using
        Catch ex As Exception
            MsgBox("Could not accept. Problem with database. " & ex.Message)
            Return
        End Try

        Dim msg As String = "Your employment request at org_id: " & _orgID & " has been confirmed. Time: " & Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim query2 As String = "INSERT INTO Notifications (UserID, Type, Message) " & "VALUES (@clientID, 0, @msg)"
        Using cmd2 As New MySqlCommand(query2, conn)
            cmd2.Parameters.AddWithValue("@clientID", _userID)
            cmd2.Parameters.AddWithValue("@msg", msg)
            cmd2.ExecuteNonQuery()
        End Using
        MessageBox.Show("Employment request dismissed. Notification sent to " & _name, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim childForm As New IncomingDetailsForm(_contactDetails, _bankAccountNumber.ToString(), _anyPrevWork)
        '_parentForm.Controls.Add(childUserControl)
        childForm.Show()


        'Me.Hide()
        'MsgBox("hello")
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox(_i)
    End Sub

    Private Sub Incoming_Emp_Req_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Incoming_Emp_Req_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
