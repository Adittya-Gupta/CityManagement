Imports MySql.Data.MySqlClient
Public Class elections_apply_for_voter
    Dim idOfCurrentUser As Integer = Module1.CurrUserSID
    'Input to the form is SID
    'Public Sub New(ByVal userInput As Integer)
    '   InitializeComponent()
    '   Me.idOfCurrentUser = userInput
    'End Sub
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim form As New election_dashboard()
        mypanel.panel1.Controls.Clear()
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
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
            Dim form As New election_dashboard()
            mypanel.panel1.Controls.Clear()
            form.TopLevel = False
            mypanel.panel1.Controls.Add(form)
            form.Show()
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles back.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        back.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles back.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        back.Cursor = Cursors.Default
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles apply.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        apply.Cursor = Cursors.Hand
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles apply.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        apply.Cursor = Cursors.Default
    End Sub
End Class