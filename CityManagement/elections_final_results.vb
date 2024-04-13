Imports MySql.Data.MySqlClient
Imports GemBox.Pdf
Public Class elections_final_results
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
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
            Dim query As String = "SELECT N.Designation, MAX(VoteCount) AS MaxVotes,Name,N.SID as SID, (SELECT VoteCount FROM Nominees WHERE Designation = N.Designation ORDER BY VoteCount DESC LIMIT 1, 1) AS SecondMaxVotes FROM Nominees N INNER JOIN User on N.SID = User.SID GROUP BY N.Designation"
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
                    Dim maxVotes As Integer = reader.GetInt32(1)
                    Dim secondMaxVotes As Integer = If(reader.IsDBNull(2), 0, reader.GetInt32(4))
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