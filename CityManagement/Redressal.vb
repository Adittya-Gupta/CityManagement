Imports MySql.Data.MySqlClient

Public Class Redressal
    Dim idOfCurrentUser As Integer = Module1.CurrUserSID
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)

    Private Sub Redressal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up DataGridView
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True ' Enable text wrapping
        DataGridView1.RowHeadersVisible = False ' Hide row headers


        ' Add columns to the DataGridView
        Dim complaintIDColumn As New DataGridViewTextBoxColumn()
        complaintIDColumn.Name = "ComplaintID"
        complaintIDColumn.HeaderText = "Complaint ID"
        complaintIDColumn.Width = 140
        DataGridView1.Columns.Add(complaintIDColumn)

        Dim senderColumn As New DataGridViewTextBoxColumn()
        senderColumn.Name = "Sender"
        senderColumn.HeaderText = "Sender"
        senderColumn.Width = 170
        DataGridView1.Columns.Add(senderColumn)

        Dim dateColumn As New DataGridViewTextBoxColumn()
        dateColumn.Name = "sent_time"
        dateColumn.HeaderText = "Sent time"
        dateColumn.Width = 230
        DataGridView1.Columns.Add(dateColumn)

        Dim lastModifiedColumn As New DataGridViewTextBoxColumn()
        lastModifiedColumn.Name = "LastModified"
        lastModifiedColumn.HeaderText = "Last Modified"
        lastModifiedColumn.Width = 230
        DataGridView1.Columns.Add(lastModifiedColumn)

        Dim queryColumn As New DataGridViewTextBoxColumn()
        queryColumn.Name = "Query"
        queryColumn.HeaderText = "Query"
        queryColumn.Width = 190
        DataGridView1.Columns.Add(queryColumn)

        ' Add Status column as button
        Dim statusColumn As New DataGridViewButtonColumn()
        statusColumn.Name = "Status"
        statusColumn.HeaderText = "Status"
        statusColumn.Text = "Resolve" ' Change button text to "Resolve"
        statusColumn.UseColumnTextForButtonValue = True
        statusColumn.FlatStyle = FlatStyle.Popup ' Set button style to popup
        statusColumn.DefaultCellStyle.BackColor = Color.Red ' Set button background color to red
        statusColumn.Width = 120
        DataGridView1.Columns.Add(statusColumn)


        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        ' Fetch data from MySQL and populate DataGridView
        Try
            conn.Open()
            
            Dim query As String = ""
            ' Assuming designation is fetched from the User table
            Dim designation As String = GetDesignation(idOfCurrentUser)
            If designation = "Police" Then
                query = "SELECT c.complaint_id, c.from_user_id, c.reply_time, c.sent_time, c.complaint, c.status " &
                        "FROM Complaints c " &
                        "JOIN Police p ON c.to_org_id = p.Station_id " &
                        "WHERE p.SID = @UserId AND c.status = false"
            ElseIf designation = "Bank Employee" Then
                ' Fetch complaints that have to_org_id as -1 (assuming -1 represents Bank)
                query = "SELECT c.complaint_id, c.from_user_id, c.reply_time, c.sent_time, c.complaint, c.status " &
                        "FROM Complaints c " &
                        "WHERE c.to_org_id = -1 AND c.status = false"
            Else
                query = "SELECT c.complaint_id, c.from_user_id, c.reply_time, c.sent_time, c.complaint, c.status " &
                        "FROM Complaints c " &
                        "WHERE (c.to_user_id = @UserId) AND c.status = false"
            End If
            ' Assuming idofCurrentUser is an Integer variable containing the user ID
            ' Create and execute the command with parameterized query
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@UserId", idOfCurrentUser)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim row As DataGridViewRow = New DataGridViewRow()
                        row.CreateCells(DataGridView1)
                        row.Cells(0).Value = reader("complaint_id").ToString()
                        row.Cells(1).Value = reader("from_user_id").ToString()
                        row.Cells(2).Value = reader("sent_time").ToString()
                        row.Cells(3).Value = reader("reply_time").ToString()
                        row.Cells(4).Value = reader("complaint").ToString()
                        DataGridView1.Rows.Add(row)
                    End While
                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Function GetDesignation(userId As Integer) As String
        Dim designation As String = ""

        Try
            ' Open connection


            ' Query to fetch designation from User table based on SID
            Dim query As String = "SELECT Designation FROM User WHERE SID = @UserId"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@UserId", userId)

                ' Execute the query and get the result
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    designation = result.ToString()
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error fetching designation: " & ex.Message)

        End Try

        Return designation
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is in the button column and perform action accordingly
        If e.ColumnIndex = DataGridView1.Columns("Status").Index AndAlso e.RowIndex >= 0 Then
            ' Get the complaint ID of the clicked row
            Dim complaintID As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("ComplaintID").Value.ToString())

            ' Set the complaint ID as an environment variable
            Environment.SetEnvironmentVariable("ComplaintID", complaintID)
            conn.Close()
            Dim Quer1 As New Quer1()
            ' MainPanel.switchPanel(Quer1)
            mypanel.Panel1.Controls.Clear()
            Dim form As New Quer1()
            form.TopLevel = False
            mypanel.Panel1.Controls.Add(form)
            form.Show()

        End If
    End Sub

End Class
