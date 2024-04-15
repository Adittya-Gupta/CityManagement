Imports MySql.Data.MySqlClient
Imports GemBox.Pdf
Public Class elections_final_results
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Private ministerDetailsList As New List(Of elections_ministerDetails)
    Private Sub electionResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Candidates.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff")
        Candidates.AutoScroll = False
        Candidates.HorizontalScroll.Enabled = False
        Candidates.HorizontalScroll.Visible = False
        Candidates.AutoScroll = True
        Candidates.Controls.Clear()
        ministerDetailsList.Clear()
        Try
            conn.Open()
            Dim previousControlBottom As Integer = 0
            Dim query As String = "WITH RankedNominees AS (SELECT n.SID,n.Designation,n.VoteCount,u.Name as Name,ROW_NUMBER() OVER (PARTITION BY n.Designation ORDER BY n.VoteCount DESC, u.DOB ASC) AS rank_within_designation FROM Nominees n INNER JOIN User u ON n.SID = u.SID) SELECT R.Designation,R.SID,R.Name,(SELECT MAX(VoteCount) FROM RankedNominees WHERE Designation = R.Designation) AS MaxVotes,COALESCE((SELECT VoteCount FROM RankedNominees WHERE Designation = R.Designation AND rank_within_designation = 2), 0) AS SecondMaxVotes FROM RankedNominees R WHERE rank_within_designation = 1"
            Using cmd As New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                While reader.Read()
                    Dim minister As New elections_ministerDetails()
                    ministerDetailsList.Add(minister)
                    minister.Dock = DockStyle.None
                    minister.Width = Candidates.Width
                    minister.Location = New Point(0, previousControlBottom)
                    minister.NomineeName = Convert.ToString(reader("Name"))
                    minister.NomineeSID = Convert.ToInt32(reader("SID"))
                    minister.Designation = Convert.ToString(reader("Designation"))
                    Dim maxVotes As Integer = reader.GetInt32(3)
                    Dim secondMaxVotes As Integer = reader.GetInt32(4)
                    minister.NomineevMargin = maxVotes - secondMaxVotes
                    previousControlBottom = minister.Bottom
                    Candidates.Controls.Add(minister)
                End While
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim form As New election_dashboard()
        mypanel.Panel1.Controls.Clear()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        Label1.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        Label1.Cursor = Cursors.Default
    End Sub
End Class
