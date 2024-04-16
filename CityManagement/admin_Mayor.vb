Imports MySql.Data.MySqlClient

Public Class admin_Mayor
    ' Define connection string
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim connString As String = Module1.connString
    Private Sub admin_Mayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.Location = Me.PictureBox1.PointToClient(Me.PointToScreen(Me.Label1.Location))
        Me.Label1.Parent = Me.PictureBox1
        Me.Label2.Location = Me.PictureBox2.PointToClient(Me.PointToScreen(Me.Label2.Location))
        Me.Label2.Parent = Me.PictureBox2
        LoadImagesFromDatabase()

        ' Set PictureBox SizeMode to Stretch
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub LoadImagesFromDatabase()
        ' Create MySqlConnection object
        Using conn As New MySqlConnection(connString)
            ' Open the connection
            conn.Open()

            ' Define the SQL query to fetch data from ElectionCommissioner table
            Dim query As String = "SELECT * FROM ElectionCommissioner"

            ' Create MySqlCommand object
            Using cmd As New MySqlCommand(query, conn)
                ' Execute the command and create a data reader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Check if there are rows in the result
                    If reader.Read() Then
                        ' Read the values of Nomination and Voting columns
                        Dim nomination As Integer = Convert.ToInt32(reader("Nomination"))
                        Dim voting As Integer = Convert.ToInt32(reader("Voting"))

                        ' Load images into PictureBoxes based on the values
                        If nomination = 0 Then
                            PictureBox1.ImageLocation = "..\..\..\MediaFiles\nominate-0.png"
                        Else
                            PictureBox1.ImageLocation = "..\..\..\MediaFiles\nominate-1.png"
                        End If

                        If voting = 0 Then
                            PictureBox2.ImageLocation = "..\..\..\MediaFiles\vote-0.png"
                        Else
                            PictureBox2.ImageLocation = "..\..\..\MediaFiles\vote-1.png"
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Toggle Nomination value in the database
        ToggleNominationValue()

        ' Reload the form to reflect the changes
        LoadImagesFromDatabase()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Toggle Voting value in the database
        ToggleVotingValue()

        ' Reload the form to reflect the changes
        LoadImagesFromDatabase()


    End Sub

    Private Sub ToggleNominationValue()
        ' Create MySqlConnection object
        Using conn As New MySqlConnection(connString)
            ' Open the connection
            conn.Open()

            ' Define the SQL query to update Nomination value
            Dim query As String = "UPDATE ElectionCommissioner SET Nomination = ABS(Nomination - 1), Voting = 0"

            ' Create MySqlCommand object
            Using cmd As New MySqlCommand(query, conn)
                ' Execute the first query
                cmd.ExecuteNonQuery()

                ' Check if Nomination = -1 after the update
                query = "SELECT Nomination FROM ElectionCommissioner"
                Using cmdCheckNomination As New MySqlCommand(query, conn)
                    Dim result As Integer = CInt(cmdCheckNomination.ExecuteScalar())

                    ' If Nomination = 1, update values in Voters table
                    If result = -1 Then
                        ' Define the SQL query to update values in Voters table
                        Dim updateVotersQuery As String = "UPDATE Voters SET Health = -2, Education = -2, Muncipal = -2, Commerce = -2, Transportation = -2"

                        ' Create MySqlCommand object
                        Using cmdUpdateVoters As New MySqlCommand(updateVotersQuery, conn)
                            ' Execute the update query for Voters table
                            cmdUpdateVoters.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
        End Using
    End Sub


    Private Sub ToggleVotingValue()
        ' Create MySqlConnection object
        Using conn As New MySqlConnection(connString)
            ' Open the connection
            conn.Open()

            ' Define the SQL query to fetch the current voting status
            Dim query As String = "SELECT Voting FROM ElectionCommissioner"

            ' Create MySqlCommand object
            Using cmd As New MySqlCommand(query, conn)
                ' Execute the command and get the current voting status
                Dim currentVoting As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Define the new voting status
                Dim newVoting As Integer = Math.Abs(currentVoting - 1)

                ' Define the SQL query to update Voting value
                Dim updateQuery As String = $"UPDATE ElectionCommissioner SET Voting = {newVoting}, Nomination = 0"

                ' Create MySqlCommand object for the update command
                Using updateCmd As New MySqlCommand(updateQuery, conn)
                    ' Execute the update command
                    updateCmd.ExecuteNonQuery()

                    ' Check if the voting has been changed to 0
                    If newVoting = 0 Then
                        ' If yes, update user designations
                        UpdateUserDesignations()
                    End If
                End Using
            End Using
        End Using

        ' Reload the form to reflect the changes
        LoadImagesFromDatabase()
    End Sub


    Private Sub UpdateUserDesignations()
        ' Create MySqlConnection object
        Using conn As New MySqlConnection(connString)
            ' Open the connection
            conn.Open()

            ' Clear previous ministers
            Dim clearPreviousQuery As String = "UPDATE User SET Designation = 'Not Employed' WHERE Designation IN ('Education Minister', 'Health Minister', 'Home Minister', 'Transport Minister', 'Finance Minister')"
            Using clearCmd As New MySqlCommand(clearPreviousQuery, conn)
                clearCmd.ExecuteNonQuery()
            End Using

            ' Perform the provided query to get SIDs and corresponding Designations
            Dim query As String = "WITH RankedNominees AS (
                                SELECT 
                                    n.SID,
                                    n.Designation,
                                    n.VoteCount,
                                    u.Name as Name,
                                    ROW_NUMBER() OVER (PARTITION BY n.Designation ORDER BY n.VoteCount DESC, u.DOB ASC) AS rank_within_designation
                                FROM 
                                    Nominees n
                                INNER JOIN User u ON n.SID = u.SID
                              )
                              SELECT 
                                  R.SID,
                                  R.Designation
                              FROM 
                                  RankedNominees R
                              WHERE 
                                  rank_within_designation = 1"

            ' Create MySqlCommand object
            Using cmd As New MySqlCommand(query, conn)
                ' Execute the query and create a data reader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Create lists to store SID and Designation
                    Dim sids As New List(Of Integer)()
                    Dim designations As New List(Of String)()

                    ' Loop through the data reader and populate the lists
                    While reader.Read()
                        sids.Add(reader.GetInt32("SID"))
                        designations.Add(reader.GetString("Designation"))
                    End While

                    ' Close the data reader
                    reader.Close()

                    ' Update Designations in Users table
                    For i As Integer = 0 To sids.Count - 1
                        Dim updateQuery As String = $"UPDATE User SET Designation = '{designations(i)}' WHERE SID = {sids(i)}"
                        Using updateCmd As New MySqlCommand(updateQuery, conn)
                            updateCmd.ExecuteNonQuery()
                        End Using
                    Next
                End Using
            End Using
        End Using
    End Sub





    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Me.Label1.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Me.Label1.Cursor = Cursors.Default
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Me.Label2.Cursor = Cursors.Hand
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Me.Label2.Cursor = Cursors.Default
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' Create an instance of the viewNominees form
        Dim viewNomineesForm As New elections_viewNominees

        ' Show the viewNominees form
        viewNomineesForm.Show()
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Me.Label3.Cursor = Cursors.Hand
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Me.Label3.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ClearNominees_Click(sender As Object, e As EventArgs) Handles ClearNominees.Click
        'To clear Nominees table and set the vote values back to -2 as the elections have been ended
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Dim query As String = "delete from Nominees"
            Using cmd As New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
        Try
            conn.Open()
            Dim updateVotersQuery As String = "UPDATE Voters SET Health = -2, Education = -2, Muncipal = -2, Commerce = -2, Transportation = -2"
            Using cmdUpdateVoters As New MySqlCommand(updateVotersQuery, conn)
                cmdUpdateVoters.ExecuteNonQuery()
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub
End Class
