Public Class transport_landingPage
    Public Shared SID As Integer = Module1.CurrUserSID
    Dim connString As String = Globals.connectionstring
    Dim conn As New MySqlConnection(connString)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New transport_busSearch
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ' SQL query to fetch Designation from User table based on SID
            Dim selectQuery As String = "SELECT Designation FROM User WHERE SID = @SID"
            Dim sid As String = transport_landingPage.SID

            conn.Open()
            ' Create connection and command objects

            ' Create a command for SELECT query
            Using selectCommand As New MySqlCommand(selectQuery, conn)
                ' Add parameters for SID
                selectCommand.Parameters.AddWithValue("@SID", sid)

                ' Execute the SELECT query and get the result
                Dim designation As String = Convert.ToString(selectCommand.ExecuteScalar())

                ' Check if the designation is "driver"
                If designation = "Transport Minister" Then
                    mypanel.panel1.Controls.Clear()
                    Dim form As New transport_govOfficial
                    form.TopLevel = False
                    mypanel.panel1.Controls.Add(form)
                    form.Show()
                Else
                    MessageBox.Show("This control is only for Transport Ministers, you can return to accessing our other services.")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New transport_cabbooking
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New transport_citymap
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class