Imports Google.Protobuf.Reflection.SourceCodeInfo.Types
Imports Mysqlx
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class transport_cabdriverinfo
    Dim connString As String = Globals.connectionstring
    Dim conn As New MySqlConnection(connString)
    Dim conn2 As New MySqlConnection(connString)
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub transport_cabdriverinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.ControlBox = False
        Me.Text = ""

        Try
            Dim sid As Integer = transport_landingPage.SID

            ' Strings to store fetched values
            Dim name As String = ""
            Dim emailAddress As String = ""
            Dim contactNo As String = ""
            Dim cabId As Integer = -1

            ' SQL query to fetch Name, EmailAddress, and ContactNo from User table based on SID
            Dim selectQuery As String = "SELECT Name, EmailAddress, ContactNo FROM User WHERE SID = @SID"

            ' SQL query to fetch cab_id from all_cabs table based on Name
            Dim cabIdQuery As String = "SELECT cab_id FROM all_cabs WHERE driver_name = @Name"

            ' Create connection and command objects

            ' Open the connection
            conn.Open()

            ' Create a command for fetching Name, EmailAddress, and ContactNo
            Using selectCommand As New MySqlCommand(selectQuery, conn)
                ' Add parameter for SID
                selectCommand.Parameters.AddWithValue("@SID", sid)

                ' Execute the SELECT query and get the reader
                Using reader As MySqlDataReader = selectCommand.ExecuteReader()
                    ' Check if there are rows returned
                    If reader.HasRows Then
                        ' Read the data and store it in variables
                        reader.Read()
                        name = reader("Name").ToString()
                        emailAddress = reader("EmailAddress").ToString()
                        contactNo = reader("ContactNo").ToString()
                    Else
                        MessageBox.Show("No user found with the provided SID.")
                        Return
                    End If
                End Using
            End Using

            ' Create a command for fetching cab_id based on Name
            Using cabIdCommand As New MySqlCommand(cabIdQuery, conn)
                ' Add parameter for Name
                cabIdCommand.Parameters.AddWithValue("@Name", name)

                ' Execute the SELECT query and get the cab_id
                cabId = Convert.ToInt32(cabIdCommand.ExecuteScalar())

                ' Check if cab_id is found
                If cabId <> 0 Then
                    Console.WriteLine("The cab_id corresponding to user {0} is {1}.", name, cabId)
                Else
                    Console.WriteLine("No cab_id found for the user {0}.", name)
                End If
            End Using


            TextBox3.Text = name
            TextBox4.Text = emailAddress

            ' SQL query to fetch from_location, to_location, and depart_time from running_cabs table based on cab_id
            Dim runningCabsQuery As String = "SELECT from_location, to_location, depart_time FROM running_cabs WHERE cab_id = @CabId"

            Dim departTime As String
            Dim from_location As String
            Dim to_location As String
            ' Create connection and command

            Using runningCabsCommand As New MySqlCommand(runningCabsQuery, conn)
                ' Add parameter for cab_id
                runningCabsCommand.Parameters.AddWithValue("@CabId", cabId)

                ' Execute the SELECT query and get the reader
                Using reader As MySqlDataReader = runningCabsCommand.ExecuteReader()
                    ' Check if there are rows returned
                    If reader.HasRows Then
                        ' Read the data and store it in variables
                        reader.Read()
                        from_location = reader("from_location").ToString()
                        to_location = reader("to_location").ToString()
                        departTime = reader("depart_time").ToString()
                    Else
                        MessageBox.Show("No running cab found with the provided cab_id.")
                        Return
                    End If
                End Using
            End Using

            Dim price As Decimal = 0

            Dim sqlQuery As String = "SELECT price FROM all_cabs WHERE cab_id = @CabId"
            Using command As New MySqlCommand(sqlQuery, conn)
                command.Parameters.AddWithValue("@CabId", cabId)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        price = Convert.ToDecimal(reader("price"))

                    End If
                End Using ' Close reader
            End Using ' Close command


            Dim card As New previousRideCard()
            card.Label11.Text = departTime
            card.Label13.Text = from_location
            card.Label15.Text = to_location
            card.Label10.Text = price

            FlowLayoutPanel1.Controls.Add(card)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New transport_cabbooking
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()

    End Sub
End Class