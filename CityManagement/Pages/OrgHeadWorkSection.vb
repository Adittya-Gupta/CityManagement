Public Class OrgHeadWorkSection
    ' Establish your database connection string
    Private connString As String = Module1.connString
    'Private connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Private conn As New MySqlConnection(connString)
    Private _orgID As Int32 = 0

    Private Sub SetPvtOrgId(dept As String)
        Select Case dept
            Case "Electrician"
                _orgID = 101
            Case "Plumber"
                _orgID = 106
            Case "Merchant"
                _orgID = 105
            Case "Househelp"
                _orgID = 104
            Case "Education"
                _orgID = 103
            Case "Police"
                _orgID = 102
            Case "Transport"
                _orgID = 107
        End Select
    End Sub

    Private Sub OrgHeadWorkSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add your initialization code here
        ' This code will execute when the UserControl is loaded
        ' For example:
        Label1.Hide()
        Dim userID As Integer = Module1.CurrUserSID

        Try
            conn.Open()

            Dim query As String = "SELECT Designation FROM User WHERE SID = @UserID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", userID)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim designation As String = Convert.ToString(reader("Designation"))
                    CurvedLabel1.Text = CurvedLabel1.Text & designation & "!"

                    If designation.StartsWith("Head") Then
                        ' Extract substring from the 6th character onwards
                        Dim substring As String = designation.Substring(5) ' Index is 5 because the characters are 0-indexed
                        SetPvtOrgId(substring)
                        Label1.Text = Label1.Text & substring
                    Else
                        Console.WriteLine("Original string does not start with 'Head'.")
                    End If
                Else
                    MessageBox.Show("No user found with the specified ID.")
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Public Sub ShowFormInPanel(formToShow As Form)
        ' Clear Panel1
        Panel1.Controls.Clear()

        ' Set the properties of the form to be displayed inside Panel1
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill

        ' Add the form to Panel1
        Panel1.Controls.Add(formToShow)

        ' Show the form
        formToShow.Show()

    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Label1.Show()
        Label1.BringToFront()
        Panel1.SendToBack()
        LoadIncomingEmploymentReq()
    End Sub

    Public Sub LoadIncomingEmploymentReq()
        ShowFormInPanel(New IncomingEmploymentReq(Me, _orgID))
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Label1.Hide()
        ShowFormInPanel(New EmployeeTable(Me, _orgID))
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    'Public Sub LoadEmployeeTable()
    '    ShowFormInPanel(New EmployeeTable(Me))
    'End Sub

End Class