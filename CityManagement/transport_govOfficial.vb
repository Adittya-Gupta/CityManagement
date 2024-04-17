Imports MySql.Data.MySqlClient

Public Class transport_govOfficial
    Dim connString As String = Globals.connectionstring
    Dim conn As New MySqlConnection(connString)

    Private Sub InsertIntoBusTable(busId As Integer, driverName As String, driverNumber As String, girlsSeat As Integer, boysSeat As Integer, girlsPrice As Double, boysPrice As Double, pathId As Integer, isDaily As Integer, departTime As TimeSpan)
        Dim query As String = "INSERT INTO bus (bus_id, driver_name, driver_numner, girls_seat, boys_seat, girls_price, boys_price, path_id, isDaily, depart_time) VALUES (@busId, @driverName, @driverNumber, @girlsSeat, @boysSeat, @girlsPrice, @boysPrice, @pathId, @isDaily, @departTime)"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@busId", busId)
        cmd.Parameters.AddWithValue("@driverName", driverName)
        cmd.Parameters.AddWithValue("@driverNumber", driverNumber)
        cmd.Parameters.AddWithValue("@girlsSeat", girlsSeat)
        cmd.Parameters.AddWithValue("@boysSeat", boysSeat)
        cmd.Parameters.AddWithValue("@girlsPrice", girlsPrice)
        cmd.Parameters.AddWithValue("@boysPrice", boysPrice)
        cmd.Parameters.AddWithValue("@pathId", pathId)
        cmd.Parameters.AddWithValue("@isDaily", isDaily)
        cmd.Parameters.AddWithValue("@departTime", departTime.ToString())
        Try
            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Data inserted successfully.")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
                TextBox8.Clear()
                TextBox9.Clear()
                DateTimePicker1.Value = DateTime.Now
            Else
                MessageBox.Show("No rows were inserted.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Retrieve input values from TextBoxes
        Dim busIdStr = TextBox1.Text
        Dim pathIdStr = TextBox5.Text
        Dim isDailyStr = TextBox4.Text
        Dim boysSeatStr = TextBox3.Text
        Dim girlsSeatStr = TextBox2.Text
        Dim boysPriceStr = TextBox7.Text
        Dim girlsPriceStr = TextBox6.Text
        Dim driverName = TextBox8.Text
        Dim driverNumber = TextBox9.Text
        Dim departTime = DateTimePicker2.Value.TimeOfDay

        ' Validate input values
        Dim busId, pathId, isDaily, boysSeat, girlsSeat As Integer
        Dim boysPrice, girlsPrice As Double
        If Integer.TryParse(busIdStr, busId) AndAlso
       Integer.TryParse(pathIdStr, pathId) AndAlso
       Integer.TryParse(isDailyStr, isDaily) AndAlso
       Integer.TryParse(boysSeatStr, boysSeat) AndAlso
       Integer.TryParse(girlsSeatStr, girlsSeat) AndAlso
       Double.TryParse(boysPriceStr, boysPrice) AndAlso
       Double.TryParse(girlsPriceStr, girlsPrice) AndAlso
       Not String.IsNullOrWhiteSpace(driverName) AndAlso
       Not String.IsNullOrWhiteSpace(driverNumber) Then
            ' All input values are valid, proceed with insertion
            InsertIntoBusTable(busId, driverName, driverNumber, girlsSeat, boysSeat, girlsPrice, boysPrice, pathId, isDaily, departTime)
        Else
            ' Display error message for invalid input
            MessageBox.Show("Invalid input! Please enter valid numeric values.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New transport_landingPage
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class