Imports System.CodeDom
Imports System.Reflection.Emit
Imports MySql.Data.MySqlClient
Public Class complaints_History
    Private Sub complaints_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userID As String = Module1.CurrUserSID.ToString()
        Dim connString As String = Module1.connString

        ' Set up DataGridView
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True ' Enable text wrapping
        DataGridView1.RowHeadersVisible = False ' Hide row headers


        ' Add columns to the DataGridView
        Dim complaintIDColumn As New DataGridViewTextBoxColumn()
        complaintIDColumn.Name = "ComplaintID"
        complaintIDColumn.HeaderText = "Complaint ID"
        complaintIDColumn.Width = 95
        DataGridView1.Columns.Add(complaintIDColumn)

        Dim sentToColumn As New DataGridViewTextBoxColumn()
        sentToColumn.Name = "Sent_to"
        sentToColumn.HeaderText = "Sent To"
        sentToColumn.Width = 150
        DataGridView1.Columns.Add(sentToColumn)

        Dim dateColumn As New DataGridViewTextBoxColumn()
        dateColumn.Name = "sent_time"
        dateColumn.HeaderText = "Sent time"
        dateColumn.Width = 185
        DataGridView1.Columns.Add(dateColumn)

        Dim lastModifiedColumn As New DataGridViewTextBoxColumn()
        lastModifiedColumn.Name = "LastModified"
        lastModifiedColumn.HeaderText = "Last Modified"
        lastModifiedColumn.Width = 185
        DataGridView1.Columns.Add(lastModifiedColumn)

        Dim queryColumn As New DataGridViewTextBoxColumn()
        queryColumn.Name = "Query"
        queryColumn.HeaderText = "Query"
        queryColumn.Width = 363
        DataGridView1.Columns.Add(queryColumn)

        ' Add Status column as button
        Dim statusColumn As New DataGridViewTextBoxColumn()
        statusColumn.Name = "Status"
        statusColumn.HeaderText = "Status"
        statusColumn.Width = 100
        DataGridView1.Columns.Add(statusColumn)


        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next


        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Dim query As String = "SELECT complaint_id,to_user_id,to_org_id,Name,reply_time,sent_time,complaint,status FROM Complaints JOIN User WHERE from_user_id = @userid AND Complaints.to_user_id = User.SID UNION ALL SELECT complaint_id,to_user_id,to_org_id,Name,reply_time,sent_time,complaint,status as Org_Name FROM Complaints JOIN Institutes WHERE from_user_id = @userid AND Complaints.to_org_id = Institutes.ID"
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@userid", userID)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim row As DataGridViewRow = New DataGridViewRow()
                        row.CreateCells(DataGridView1)
                        row.Cells(0).Value = reader("complaint_id").ToString()
                        row.Cells(1).Value = reader("Name").ToString()
                        row.Cells(2).Value = reader("sent_time").ToString()
                        row.Cells(3).Value = reader("reply_time").ToString()
                        row.Cells(4).Value = reader("complaint").ToString()
                        Dim status As Integer = reader("status")
                        row.Cells(5).Style.ForeColor = Color.White
                        If status = 0 Then
                            If row.Cells(3).Value = "" Then
                                row.Cells(5).Value = "Pending"
                                row.Cells(5).Style.BackColor = Color.Red
                            Else
                                row.Cells(5).Value = "Processing"
                                row.Cells(5).Style.BackColor = Color.Blue
                            End If
                        ElseIf status = 1 Then
                            row.Cells(5).Value = "Processing"
                            row.Cells(5).Style.BackColor = Color.Blue
                        Else
                            row.Cells(5).Value = "Resolved"
                            row.Cells(5).Style.BackColor = Color.Green
                        End If
                        DataGridView1.Rows.Add(row)
                    End While
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New complaints
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class