Imports MySql.Data.MySqlClient
Public Class electionPortal
    Dim idOfCurrentUser As Integer = 984571
    'Input to the form is SID
    'Public Sub New(ByVal userInput As Integer)
    '   InitializeComponent()
    '   Me.idOfCurrentUser = userInput
    'End Sub
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim electiondashboard As New election_dashboard()
        electiondashboard.Show()
        Me.Hide()
    End Sub
    Private Sub apply_Click_1(sender As Object, e As EventArgs) Handles apply.Click
        'To insert into voter table'here -2 means not voted
        Dim query As String = "insert into Voters values (@SID,-2,-2,-2,-2,-2)"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SID", idOfCurrentUser)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("You are now a Voter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'showing the old form back as current operation is successfully completed
            Dim electiondashboard As New election_dashboard()
            electiondashboard.Show()
            Me.Hide()
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub
End Class