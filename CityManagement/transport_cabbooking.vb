Public Class transport_cabbooking
    Public Shared FromLocation As String
    Public Shared ToLocation As String
    Public Shared sqlFormattedDateTime As String
    Dim connString As String = Globals.connectionstring
    Dim conn As New MySqlConnection(connString)

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FromLocation = ComboBox1.SelectedItem.ToString()
        ToLocation = ComboBox2.SelectedItem.ToString()
        'MessageBox.Show(FromLocation & " " & ToLocation)
        'departTime = DateTimePicker1.Value.TimeOfDay

        Dim selectedDateTime As DateTime = DateTimePicker1.Value

        ' Format the DateTime object as a string in the required format for SQL
        sqlFormattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss")

        ' Now you can use sqlFormattedDateTime in your SQL query
        'MessageBox.Show("Selected date and time in SQL format: " & sqlFormattedDateTime)
        mypanel.panel1.Controls.Clear()
        Dim form As New transport_cabavailable
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()

    End Sub

    Private Sub transport_cabbooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.ControlBox = False
        Me.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
                If designation = "Driver" Then
                    mypanel.panel1.Controls.Clear()
                    Dim form As New transport_cabdriverinfo
                    form.TopLevel = False
                    mypanel.panel1.Controls.Add(form)
                    form.Show()
                Else
                    MessageBox.Show("This control is accessible only to drivers, you can return to accessing our other services.")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        mypanel.panel1.Controls.Clear()
        Dim form As New transport_cabuserhistory
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New transport_landingPage
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class