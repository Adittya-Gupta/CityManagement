Imports MySql.Data.MySqlClient

Public Class admin_Mayor
    ' Define connection string
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"

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
                            PictureBox1.ImageLocation = "C:\Users\tsriv\Downloads\nominate-0.png"
                        Else
                            PictureBox1.ImageLocation = "C:\Users\tsriv\Downloads\nominate-1.png"
                        End If

                        If voting = 0 Then
                            PictureBox2.ImageLocation = "C:\Users\tsriv\Downloads\vote-0.png"
                        Else
                            PictureBox2.ImageLocation = "C:\Users\tsriv\Downloads\vote-1.png"
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
                ' Execute the command
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub ToggleVotingValue()
        ' Create MySqlConnection object
        Using conn As New MySqlConnection(connString)
            ' Open the connection
            conn.Open()

            ' Define the SQL query to update Voting value
            Dim query As String = "UPDATE ElectionCommissioner SET Voting = ABS(Voting - 1), Nomination = 0"

            ' Create MySqlCommand object
            Using cmd As New MySqlCommand(query, conn)
                ' Execute the command
                cmd.ExecuteNonQuery()
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
        Dim viewNomineesForm As New viewNominees

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
End Class
