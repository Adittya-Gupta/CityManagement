Imports MySql.Data.MySqlClient
Public Class election_dashboard
    Dim idOfCurrentUser As Integer = Module1.CurrUserSID
    'Input to the form is SID
    'Public Sub New(ByVal userInput As Integer)
    '   InitializeComponent()
    '   Me.idOfCurrentUser = userInput
    'End Sub
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    'Dim connString As String = "Server=localhost;Database=smart_city_management;Uid=username;"
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Dim alreadyVoter As Boolean = False
    Dim isVotingPeriod As Boolean = False
    Dim isNominationPeriod As Boolean = False
    Dim eligibleToNominate As Boolean = False
    Dim resultsReleased As Boolean = False
    Dim hasVoted As Boolean = False
    Dim mapping As New Dictionary(Of String, String)() 'To check for whether the person is eligible to nominate, based on his qualifications
    Private Sub election_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mapping("Teacher") = "Education Minister"
        mapping("Educational Institute Owner") = "Education Minister"
        mapping("Institute Owner") = "Education Minister"
        mapping("Education Minister") = "Education Minister"
        mapping("Doctor") = "Health Minister"
        mapping("Hospital Owner") = "Health Minister"
        mapping("Health Minister") = "Health Minister"
        mapping("Driver") = "Transport Minister"
        mapping("Transportation Minister") = "Transport Minister"
        mapping("Transport Officer") = "Transport Minister"
        mapping("Finance Minister") = "Finance Minister"
        mapping("Muncipal Officer") = "Finance Minister"
        mapping("Employee") = "Finance Minister"
        mapping("Home Minister") = "Home Minister"
        mapping("SHO") = "Home Minister"
        mapping("Police") = "Home Minister"
        mapping("Owner") = "Home Minister"
        Try
            conn.Open()
            'First check if the current user is already voter
            Dim query As String = "select SID from Voters where SID=?"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("?", idOfCurrentUser)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                'MessageBox.Show("Reached")
                If reader.Read() Then
                    alreadyVoter = True
                Else
                    alreadyVoter = False
                End If
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
        'MessageBox.Show(alreadyVoter)
        Try
            conn.Open()
            'To check if the person is eligible to nominate based on his designation
            Dim query As String = "select Designation from User where SID = @a"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@a", idOfCurrentUser)
                Dim reader = cmd.ExecuteReader
                reader.Read()
                If mapping.ContainsKey(Convert.ToString(reader("Designation"))) And alreadyVoter Then
                    eligibleToNominate = True
                End If
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try

        Try
            conn.Open()
            'To check if the nomination period is there set by election commissioner
            Dim query As String = "select Nomination from ElectionCommissioner"
            Using cmd2 As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd2.ExecuteReader()
                If reader.Read() Then
                    isNominationPeriod = Convert.ToBoolean(reader("Nomination"))
                End If
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try

        Try
            conn.Open()
            'To check if the voting period 
            Dim query As String = "select Voting from ElectionCommissioner"
            Using cmd3 As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd3.ExecuteReader()
                If reader.Read() Then
                    isVotingPeriod = Convert.ToBoolean(reader("Voting"))
                End If
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
        Try
            conn.Open()
            'To check if the person has already voted
            Dim query As String = "select * from Voters where SID=?"
            Using cmd4 As New MySqlCommand(query, conn)
                cmd4.Parameters.AddWithValue("?", idOfCurrentUser)
                Dim reader As MySqlDataReader = cmd4.ExecuteReader()
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

        resultsReleased = (Not isNominationPeriod) And (Not isVotingPeriod)
        'MessageBox.Show(isVotingPeriod)
    End Sub
    Private Sub apply_to_become_voter_Click(sender As Object, e As EventArgs) Handles apply_to_become_voter.Click
        'First check if the current user is already voter
        Try
            conn.Open()
            Dim query As String
            If Not alreadyVoter Then
                Dim dateOfBirth As Date
                'mysql query to get the dateofbirth of the current user
                query = "select DOB from User where SID=?"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", idOfCurrentUser)
                    Dim reader = cmd.ExecuteReader
                    If reader.Read Then
                        dateOfBirth = Convert.ToDateTime(reader("DOB"))
                    End If
                End Using
                Dim currentDate = Date.Now
                Dim age = currentDate.Year - dateOfBirth.Year
                'To check if the birthday has occured in the current year
                If currentDate < dateOfBirth.AddYears(age) Then
                    age -= 1 ' Subtract 1 if birthday hasn't occurred yet
                End If

                If age >= 18 Then
                    mypanel.panel1.Controls.Clear()
                    Dim form As New elections_apply_for_voter()
                    form.TopLevel = False
                    mypanel.panel1.Controls.Add(form)
                    form.Show()
                Else
                    MessageBox.Show("You are not eligible to vote as your age is less than 18", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("You are already a Voter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub voting_portal_Click(sender As Object, e As EventArgs) Handles voting_portal.Click
        If alreadyVoter And isVotingPeriod And Not hasVoted Then
            'Dim voting_portal As New votingPortal()
            mypanel.Panel1.Controls.Clear()
            Dim form As New elections_votingPortal()

            form.TopLevel = False
            mypanel.Panel1.Controls.Add(form)
            form.Show()


        ElseIf Not isVotingPeriod Then
            MessageBox.Show("This is not voting period.Please try when its voting period", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not alreadyVoter Then
            MessageBox.Show("You are not a Voter yet.Please first apply to become voter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf hasVoted Then
            MessageBox.Show("You have already voted, you cannot vote again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub nomination_rules_Click(sender As Object, e As EventArgs) Handles nomination_rules.Click
        ' Dim nominationrules As New nomination_rules()
        mypanel.Panel1.Controls.Clear()
        Dim form As New elections_nomination_rules()

        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()


    End Sub

    Private Sub voting_rules_Click(sender As Object, e As EventArgs) Handles voting_rules.Click
        ' Dim votingrules As New voting_rules()
        mypanel.Panel1.Controls.Clear()
        Dim form As New elections_voting_rules()

        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
        ' votingrules.Show()

    End Sub

    Private Sub nomination_portal_Click(sender As Object, e As EventArgs) Handles nomination_portal.Click
        If isNominationPeriod And eligibleToNominate Then

            mypanel.panel1.Controls.Clear()
            Dim form As New elections_nomination()

            form.TopLevel = False
            mypanel.panel1.Controls.Add(form)
            form.Show()
        ElseIf Not isNominationPeriod Then
            MessageBox.Show("The current period is not Nomination Period,Please try in nomination Period", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not eligibleToNominate Then
            MessageBox.Show("You are not eligible to nominate,Please check the nomination rules page for more information", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub nominees_details_Click(sender As Object, e As EventArgs) Handles nominees_details.Click
        'Nominee details form to be shown here
        mypanel.Panel1.Controls.Clear()
        Dim form As New elections_viewNominees()

        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub results_portal_Click(sender As Object, e As EventArgs) Handles results_portal.Click
        If resultsReleased Then
            ' Dim electionresults As New electionResults()
            mypanel.Panel1.Controls.Clear()
            Dim form As New elections_final_results()

            form.TopLevel = False
            mypanel.Panel1.Controls.Add(form)
            form.Show()
            ' electionresults.Show()
            ' Me.Hide()
        Else
            MessageBox.Show("The election results are not yet released", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        'show the administration form here
        mypanel.Panel1.Controls.Clear()
        Dim form As New admin_home()

        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub AllResults_Click(sender As Object, e As EventArgs) Handles AllResults.Click
        'Dim allResults As New AllResults()
        mypanel.Panel1.Controls.Clear()
        Dim form As New elections_AllResults()

        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
        'allResults.Show()
        'Me.Hide()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles apply_to_become_voter.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        apply_to_become_voter.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles apply_to_become_voter.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        apply_to_become_voter.Cursor = Cursors.Default
    End Sub
    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles voting_portal.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        voting_portal.Cursor = Cursors.Hand
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles voting_portal.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        voting_portal.Cursor = Cursors.Default
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles nomination_rules.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        nomination_rules.Cursor = Cursors.Hand
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles nomination_rules.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        nomination_rules.Cursor = Cursors.Default
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles voting_rules.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        voting_rules.Cursor = Cursors.Hand
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles voting_rules.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        voting_rules.Cursor = Cursors.Default
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles nomination_portal.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        nomination_portal.Cursor = Cursors.Hand
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles nomination_portal.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        nomination_portal.Cursor = Cursors.Default
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles nominees_details.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        nominees_details.Cursor = Cursors.Hand
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles nominees_details.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        nominees_details.Cursor = Cursors.Default
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles results_portal.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        results_portal.Cursor = Cursors.Hand
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles results_portal.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        results_portal.Cursor = Cursors.Default
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles AllResults.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        AllResults.Cursor = Cursors.Hand
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles AllResults.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        AllResults.Cursor = Cursors.Default
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As EventArgs) Handles back.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        back.Cursor = Cursors.Hand
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles back.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        back.Cursor = Cursors.Default
    End Sub
End Class