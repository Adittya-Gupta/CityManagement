Imports Mysqlx
Imports Syncfusion.Compression.Zip
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


    Sub childform(ByVal form As Form)
        form.TopLevel = False ' Set TopLevel property to False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add(form)
        form.Show()
    End Sub



    Private Function getUserEmailAddress() As String
        Dim email As String = ""
        Try
            ' Open the connection
            'sqlConn.ConnectionString = "server=MYSQL9001.site4now.net;userid=aa78df_scms;Password=abcd1234;database=db_aa78df_scms;sslmode=none"
            sqlConn.ConnectionString = GlobalConnString.str
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
        Dim obj1 As New Email_Draft
        obj1.username_test = User_EmailID
        childform(obj1)
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim obj2 As New Email_inbox
        obj2.username_test = User_EmailID
        childform(obj2)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim obj3 As New Email_SentEmails
        obj3.username_test = User_EmailID
        childform(obj3)
    End Sub
End Class