Imports MySql.Data.MySqlClient

Public Class education_landing
    Private userid As Integer

    Private Sub education_landing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetManualUserID()
    End Sub
    Public Sub SetUserID(id As Integer)
        userid = id
    End Sub

    Public Sub SetManualUserID()
        ' Set the userid to 949664 for student
        ' Set the userid to 700016 for teacher
        SetUserID(Module1.CurrUserSID)
    End Sub

    Private Sub Btnteach_Click(sender As Object, e As EventArgs) Handles Btnteach.Click
        If userid = 0 Then
            MessageBox.Show("User ID is not provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim designation As String = GetDesignation(userid)
        If designation = "Teacher" Then
            mypanel.panel1.Controls.Clear()
            Dim form As New professor_dashboard()
            form.SetUserID(userid)
            form.TopLevel = False
            mypanel.panel1.Controls.Add(form)
            form.Show()
        Else
            MessageBox.Show("You are not a teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Btnstud_Click(sender As Object, e As EventArgs) Handles Btnstud.Click
        If userid = 0 Then
            MessageBox.Show("User ID is not provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim designation As String = GetDesignation(userid)


        If designation <> "Teacher" Then
            mypanel.panel1.Controls.Clear()
            Dim form As New allcourses_page()
            form.SetUserID(userid)
            form.TopLevel = False
            mypanel.panel1.Controls.Add(form)
            form.Show()
        Else
            MessageBox.Show("You cannot access this page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function GetDesignation(userid As Integer) As String
        Dim connectionString As String = Module1.connString
        Dim query As String = "SELECT Designation FROM User WHERE SID = @userid"

        Dim designation As String = ""

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userid", userid) ' Pass userid as Integer
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Initialize designation variable
                If reader.Read() Then
                    designation = reader("Designation").ToString() ' Read the designation from the query result
                End If
            End Using
        End Using

        Return designation
    End Function


End Class
