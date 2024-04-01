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
    Dim mapping As New Dictionary(Of String, String)()
    Dim alreadyVoter As Boolean = False
    Dim isVotingPeriod As Boolean = False
    Dim isNominationPeriod As Boolean = False
    Dim eligibleToNominate As Boolean = False
    Dim resultsReleased As Boolean = False
    Private Sub electionPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Results are available only when the period is neither voting nor nomination
        Try
            conn.Open()
            Dim query2 As String = "select Nomination,Voting from ElectionCommissioner"
            Using cmd As New MySqlCommand(query2, conn)
                Dim reader = cmd.ExecuteReader
                reader.Read()
                If Convert.ToBoolean(reader("Nomination")) = False And Convert.ToBoolean(reader("Voting")) = False Then
                    resultsReleased = True
                End If
            End Using
        Catch ex As Exception

        Finally
            conn.Close()
        End Try


        mapping("Teacher") = "Education Minister"
        mapping("Educational Institute Owner") = "Education Minister"
        mapping("Education Minister") = "Education Minister"
        mapping("Doctor") = "Health Minister"
        mapping("Hospital Owner") = "Health Minister"
        mapping("Health Minister") = "Health Minister"
        mapping("Driver") = "Transportation Minister"
        mapping("Transportation Minister") = "Transportation Minister"
        mapping("Finance Minister") = "Finance Minister"
        mapping("Home Minister") = "Home Minister"
        Apply.FlatStyle = FlatStyle.Flat
        Apply.FlatAppearance.BorderSize = 0
        Apply.BackColor = System.Drawing.ColorTranslator.FromHtml("#5985b2")
        Results.FlatStyle = FlatStyle.Flat
        Results.FlatAppearance.BorderSize = 0
        Results.BackColor = System.Drawing.ColorTranslator.FromHtml("#5fb258")
        Results.Text = "Results"
        'First check if the current user is already voter
        Dim query As String = "select SID from Voters where SID=?"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("?", idOfCurrentUser)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    alreadyVoter = True
                    Apply.Text = "Applied!"
                Else
                    Apply.Text = "Apply!"
                End If
            End Using
        Catch ex As Exception

        Finally
            conn.Close()
        End Try
        'To check if the person is eligible to nominate based on his designation
        query = "select Designation from User where SID=@a"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@a", idOfCurrentUser)
                Dim reader = cmd.ExecuteReader
                reader.Read()
                If mapping.ContainsKey(Convert.ToString(reader("Designation"))) Then
                    eligibleToNominate = True
                End If
            End Using
        Catch ex As Exception

        Finally
            conn.Close()
        End Try



        'To check if the nomination period is there set by election commissioner
        query = "select Nomination from ElectionCommissioner"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    isNominationPeriod = Convert.ToBoolean(reader("Nomination"))
                    If (isNominationPeriod) And (alreadyVoter) And (eligibleToNominate) Then
                        Apply.Text = "Nominate!"
                    End If
                End If
            End Using
        Catch ex As Exception

        Finally
            conn.Close()
        End Try
        'To check if the voting period 
        query = "select Voting from ElectionCommissioner"
        isVotingPeriod = False
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    isVotingPeriod = Convert.ToBoolean(reader("Voting"))
                End If
            End Using
        Catch ex As Exception

        Finally
            conn.Close()
        End Try
        'To check if the person has already voted
        query = "select * from Voters where SID=?"
        Dim hasVoted As Boolean = False
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("?", idOfCurrentUser)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim tempVote As Integer = Convert.ToInt32(reader("Health"))
                    If Not (tempVote = -2) Then
                        hasVoted = True
                    End If
                End If
            End Using
        Catch ex As Exception

        Finally
            conn.Close()
        End Try
        'If hasVoted and voting period
        If isVotingPeriod And hasVoted Then
            Apply.Text = "Voted!"
        End If
        'If has not voted but voting period
        If isVotingPeriod And Not (hasVoted) And (alreadyVoter) Then
            Apply.Text = "Vote!"
        End If
        'MessageBox.Show(Apply.Text)
    End Sub
    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click
        If Apply.Text = "Apply!" Then
            Dim query As String
            Dim hasbecomeVoter As Boolean = False
            If Not alreadyVoter Then
                Dim dateOfBirth As Date
                'mysql query to get the dateofbirth of the current user
                query = "select DOB from User where SID=?"
                Try
                    conn.Open()

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("?", idOfCurrentUser)
                        Dim reader = cmd.ExecuteReader
                        If reader.Read Then
                            dateOfBirth = Convert.ToDateTime(reader("DOB"))
                        End If
                    End Using
                Catch ex As Exception

                Finally
                    conn.Close()
                End Try
                Dim currentDate = Date.Now
                Dim age = currentDate.Year - dateOfBirth.Year
                'To check if the birthday has occured in the current year
                If currentDate < dateOfBirth.AddYears(age) Then
                    age -= 1 ' Subtract 1 if birthday hasn't occurred yet
                End If
                'To insert into voter table'here -2 means not voted
                query = "insert into Voters values (@SID,-2,-2,-2,-2,-2)"
                Try
                    conn.Open()

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@SID", idOfCurrentUser)
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception

                Finally
                    conn.Close()
                End Try
                hasbecomeVoter = True
            End If
            'Now if the voting period is on,then the apply button should change to vote
            If hasbecomeVoter And isVotingPeriod Then
                Apply.Text = "Vote!"
            ElseIf hasbecomeVoter And isNominationPeriod Then
                Apply.Text = "Nominate!"
            ElseIf hasbecomeVoter Then
                Apply.Text = "Applied!"
            End If
        ElseIf Apply.Text = "Applied!" Then
            Apply.Enabled = False
        ElseIf Apply.Text = "Nominate!" Then
            'Check if the person is eligible to nominate, if he is not show a message to him that he doesn't meet the required criteria
            Dim nominationForm As New nomination()
            Me.Hide()
            nominationForm.Show()
        ElseIf Apply.Text = "Vote!" Then
            Dim votingPortalForm As New votingPortal()
            Me.Hide()
            votingPortalForm.Show()
        End If
    End Sub
    Private Sub Results_Click(sender As Object, e As EventArgs) Handles Results.Click
        If resultsReleased Then
            Dim resultsForm As New electionResults()
            Me.Hide()
            resultsForm.Show()
        Else
            MessageBox.Show("The results haven't been released yet by the Election Commissioner", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class