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

    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Public Sub New(ParentForm As Form, ByVal dateValue As Date, Optional ByVal name As String = "Name", Optional ByVal i As Integer = 1,
                   Optional ByVal contactDetails As String = "contactDetails", Optional ByVal bankAccountNumber As Int64 = 123, Optional ByVal anyPrevWork As String = "anyPreviousWork",
                   Optional ByVal userID As Int32 = 123, Optional ByVal orgID As Int32 = 101
        )
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
                MsgBox(_i.ToString() & " accepted")
                RemoveSelfFromParentControl()
            End Using
        Catch ex As Exception
            MsgBox("Could not accept. Problem with database. " & ex.Message)
            Return
        End Try

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
                MsgBox(_i.ToString() & " rejected")
                RemoveSelfFromParentControl()
            End Using
        Catch ex As Exception
            MsgBox("Could not accept. Problem with database. " & ex.Message)
            Return
        End Try

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
End Class
