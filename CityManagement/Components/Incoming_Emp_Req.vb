Imports System.Runtime.InteropServices
Imports System.Transactions
Imports DocumentFormat.OpenXml.Bibliography
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
    Private _empDesignation As String
    Private _prof_email As String
    Private _address As String

    Dim connString As String = Module1.connString
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Private Sub SetEmpDesignation()
        Select Case _orgID
            Case 101
                _empDesignation = "Electrician"
            Case 106
                _empDesignation = "Plumber"
            Case 105
                _empDesignation = "Merchant"
            Case 104
                _empDesignation = "Househelp"
            Case 103
                _empDesignation = "Teacher"
            Case 102
                _empDesignation = "Police"
            Case 107
                _empDesignation = "Driver"
            Case Else
                _empDesignation = "Unknown"  ' Default designation if orgID doesn't match any known category
                MessageBox.Show("Warning: No designation found for orgID " & _orgID.ToString() & ". Defaulting to 'Unknown'.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub

    Public Sub New(ParentForm As Form, ByVal dateValue As Date,
                   Optional ByVal name As String = "Name",
                   Optional ByVal i As Integer = 1,
                   Optional ByVal contactDetails As String = "contactDetails",
                   Optional ByVal bankAccountNumber As Int64 = 123,
                   Optional ByVal anyPrevWork As String = "anyPreviousWork",
                   Optional ByVal userID As Int32 = 123,
                   Optional ByVal orgID As Int32 = 101,
                   Optional ByVal prof_email As String = "anyPreviousWork",
                   Optional ByVal address As String = "anyPreviousWork",
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
        _prof_email = prof_email
        _address = address
        SetEmpDesignation()

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
        ' Open connection
        ' Ensure the connection is declared. Assuming conn is already declared.
        Dim transaction As MySqlTransaction
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                ' First UPDATE operation
                Dim query1 As String = "UPDATE workerEmployReq SET status = 'Approved' WHERE orgID = @A AND userID = @B;"
                Using cmd1 As New MySqlCommand(query1, conn)
                    cmd1.Transaction = transaction
                    cmd1.Parameters.Add("@A", MySqlDbType.Int32).Value = _orgID
                    cmd1.Parameters.Add("@B", MySqlDbType.Int32).Value = _userID
                    cmd1.ExecuteNonQuery()
                End Using

                ' Second UPDATE operation
                Dim query2 As String = "UPDATE User SET Designation = @C WHERE SID = @B;"
                Using cmd2 As New MySqlCommand(query2, conn)
                    cmd2.Transaction = transaction
                    cmd2.Parameters.Add("@B", MySqlDbType.Int32).Value = _userID
                    cmd2.Parameters.Add("@C", MySqlDbType.VarChar).Value = _empDesignation
                    cmd2.ExecuteNonQuery()
                End Using

                ' INSERT operation
                Dim query3 As String = "INSERT INTO serviceWorkers (userID, orgID, experience, rating, prof_email, noOfRatings, Phone_Number, address, profile_pic) VALUES (@A, @B, @C, @D, @E, @F, @G, @H, @I)"
                Using cmd3 As New MySqlCommand(query3, conn)
                    cmd3.Transaction = transaction
                    cmd3.Parameters.Add("@A", MySqlDbType.Int32).Value = _userID
                    cmd3.Parameters.Add("@B", MySqlDbType.Int32).Value = _orgID
                    cmd3.Parameters.Add("@C", MySqlDbType.Int32).Value = 0
                    cmd3.Parameters.Add("@D", MySqlDbType.Int32).Value = 0
                    cmd3.Parameters.Add("@E", MySqlDbType.VarChar).Value = _prof_email
                    cmd3.Parameters.Add("@F", MySqlDbType.Int32).Value = 0
                    cmd3.Parameters.Add("@G", MySqlDbType.VarChar).Value = _contactDetails
                    cmd3.Parameters.Add("@H", MySqlDbType.VarChar).Value = _address
                    If PictureBox1.Image IsNot Nothing Then
                        Dim ms As New System.IO.MemoryStream()
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                        Dim byteImage As Byte() = ms.ToArray()
                        cmd3.Parameters.Add("@I", MySqlDbType.Blob).Value = byteImage
                    Else
                        cmd3.Parameters.AddWithValue("@I", DBNull.Value)
                    End If
                    cmd3.ExecuteNonQuery()
                End Using

                ' INSERT Notification
                Dim msg As String = "Your employment request at org_id: " & _orgID & " has been confirmed. Time: " & Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
                Dim query4 As String = "INSERT INTO Notifications (UserID, Type, Message) VALUES (@clientID, 0, @msg)"
                Using cmd4 As New MySqlCommand(query4, conn)
                    cmd4.Transaction = transaction
                    cmd4.Parameters.AddWithValue("@clientID", _userID)
                    cmd4.Parameters.AddWithValue("@msg", msg)
                    cmd4.ExecuteNonQuery()
                End Using

                ' Commit transaction
                transaction.Commit()

                ' Remove control from parent, signaling successful transaction
                RemoveSelfFromParentControl()

                MessageBox.Show("Employment request confirmed. Notification sent to " & _name, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Could not complete the update. Problem with database. " & ex.Message)
                If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                    Try
                        transaction.Rollback()
                    Catch exRollback As Exception
                        MessageBox.Show("Rollback Failed: " & exRollback.Message)
                    End Try
                End If
            Finally
                If transaction IsNot Nothing Then
                    transaction.Dispose()
                End If
                conn.Close()
            End Try
        End Using


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
        Dim childForm As New IncomingDetailsForm(_contactDetails, _bankAccountNumber.ToString(), _anyPrevWork, _userID, _orgID, _name)
        '_parentForm.Controls.Add(childUserControl)
        childForm.Show()


        'Me.Hide()
        'MsgBox("hello")
    End Sub


End Class
