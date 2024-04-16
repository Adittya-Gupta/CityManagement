﻿Imports Mysqlx
Imports System.Data.SqlTypes




Public Class Email_Landing

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String


    'Dim server As String = "localhost"
    'Dim username As String = "root"
    ' Dim password As String = "12345678"
    ' Dim database As String = "bankingdatabase"

    Public server As String = "MYSQL9001.site4now.net"
    Public username As String = "aa78df_scms"
    Public password As String = "abcd1234"
    Public database As String = "db_aa78df_scms"
    Public User_EmailID As String = ""


    Sub childform(ByVal form As Form, ByVal userEmail As String)
        ' Set TopLevel property to False
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add(form)
        ' Pass the User_EmailID to the child form
        If TypeOf form Is Email_Draft Then
            Dim emailDraftForm As Email_Draft = DirectCast(form, Email_Draft)
            emailDraftForm.User_EmailID = userEmail
        End If
        form.Show()
    End Sub



    Private Function getUserEmailAddress() As String
        Dim email As String = ""
        Try
            ' Open the connection
            sqlConn.ConnectionString = "server=MYSQL9001.site4now.net;userid=aa78df_scms;Password=abcd1234;database=db_aa78df_scms;sslmode=none"
            sqlConn.Open()

            ' Construct the SQL query
            sqlQuery = "SELECT EmailAddress FROM User WHERE SID = @SID" ' Replace SID with your actual identifier for the user

            ' Create a MySqlCommand object
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)

            ' Add parameters to the command
            sqlCmd.Parameters.AddWithValue("@SID", CurrUserSID) ' Replace YourSIDValueHere with the actual SID value for the user

            ' Execute the query and retrieve the result
            sqlRd = sqlCmd.ExecuteReader()

            ' Check if there are rows returned
            If sqlRd.HasRows Then
                ' Read the first row
                sqlRd.Read()
                ' Retrieve the email address from the result
                email = sqlRd.GetString("EmailAddress")
            End If

        Catch ex As Exception
            ' Handle any exceptions here
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the reader and the connection
            If Not sqlRd Is Nothing Then
                sqlRd.Close()
            End If
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try

        ' Return the email address
        Return email
    End Function



    Private Sub Email_Landing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User_EmailID = getUserEmailAddress()
    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        childform(New Email_Draft(), User_EmailID)
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        childform(New Email_inbox(), User_EmailID)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        childform(New Email_SentEmails(), User_EmailID)
    End Sub
End Class