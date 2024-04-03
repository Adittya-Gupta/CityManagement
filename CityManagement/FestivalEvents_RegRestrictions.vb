Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json.Linq


Public Class FestivalEvents_RegRestrictions
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Private Sub FestivalEvents_RegRestrictions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the initial state of CheckBox1 and adjust controls accordingly
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM festivals WHERE id = @CurrEvent "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CurrEvent", Module1.CurrEventID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                reader.Read()
                Dim restrictions As String = If(Not IsDBNull(reader("restrictions")), reader("restrictions").ToString(), "{}")
                Dim restrictionsObject As JObject = JObject.Parse(restrictions)

                ' Variables to store extracted fields
                Dim minAge As Integer? = Nothing
                Dim maxAge As Integer? = Nothing
                Dim maxParticipants As Integer? = Nothing

                ' Extract fields from JSON object
                If restrictionsObject.ContainsKey("minAge") Then
                    minAge = restrictionsObject("minAge").ToObject(Of Integer?)()
                End If

                If restrictionsObject.ContainsKey("maxAge") Then
                    maxAge = restrictionsObject("maxAge").ToObject(Of Integer?)()
                End If

                If restrictionsObject.ContainsKey("maxParticipants") Then
                    maxParticipants = restrictionsObject("maxParticipants").ToObject(Of Integer?)()
                End If

                ' Populate UI controls based on extracted fields
                If minAge.HasValue OrElse maxAge.HasValue Then
                    ' At least one age value is present
                    TextBox1.Text = If(minAge, "") ' Put minAge in TextBox1, empty if null
                    TextBox2.Text = If(maxAge, "") ' Put maxAge in TextBox2, empty if null
                    CheckBox1.Checked = True ' Check CheckBox1
                Else
                    ' Neither minAge nor maxAge is present
                    CheckBox1.Checked = False ' Uncheck CheckBox1
                End If
                CheckBox1_CheckedChanged(Nothing, Nothing) ' Trigger the event handler manually
                If maxParticipants.HasValue Then
                    ' maxParticipants value is present
                    TextBox3.Text = maxParticipants.ToString() ' Put maxParticipants in TextBox3
                    CheckBox2.Checked = True ' Check CheckBox2
                Else
                    ' maxParticipants value is not present
                    CheckBox2.Checked = False ' Uncheck CheckBox2
                End If
                CheckBox2_CheckedChanged(Nothing, Nothing) ' Trigger the event handler manually

            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching festival details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        'CheckBox1.Checked = True
        'CheckBox1_CheckedChanged(Nothing, Nothing) ' Trigger the event handler manually

        '' Set the initial state of CheckBox2 and adjust controls accordingly
        'CheckBox2.Checked = True
        'CheckBox2_CheckedChanged(Nothing, Nothing) ' Trigger the event handler manually
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the entered character is a digit or a control character like Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If not a digit or a control character, suppress the key press event
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the entered character is a digit or a control character like Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If not a digit or a control character, suppress the key press event
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the entered character is a digit or a control character like Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If not a digit or a control character, suppress the key press event
            e.Handled = True
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label1.Visible = True
            Label2.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
        Else
            Label1.Visible = False
            Label2.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Label4.Visible = True
            TextBox3.Visible = True
        Else
            Label4.Visible = False
            TextBox3.Visible = False
        End If
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if CheckBox1 is checked and TextBox1 and TextBox2 have values
        If CheckBox1.Checked AndAlso String.IsNullOrEmpty(TextBox1.Text) AndAlso String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("Enter a value in alteast one of Minimum or Maximum age.")
            Return
        End If

        ' Check if CheckBox1 is checked and TextBox2 value is greater than TextBox1 value
        If CheckBox1.Checked AndAlso Not String.IsNullOrEmpty(TextBox1.Text) AndAlso Not String.IsNullOrEmpty(TextBox2.Text) Then
            Dim value1 As Integer
            Dim value2 As Integer
            If Integer.TryParse(TextBox1.Text, value1) AndAlso Integer.TryParse(TextBox2.Text, value2) Then
                If value2 <= value1 Then
                    MessageBox.Show("Maximum age must be greater than Minimum age.")
                    Return
                End If
            End If
        End If

        ' Check if CheckBox2 is checked and TextBox3 has a positive value
        If CheckBox2.Checked AndAlso (String.IsNullOrEmpty(TextBox3.Text) OrElse Convert.ToInt32(TextBox3.Text) <= 0) Then
            MessageBox.Show("Enter a value in Maximum Participants.")
            Return
        End If
        Try
            Dim updatedRestrictions As New JObject()

            ' Check if CheckBox1 is checked and TextBox1 and TextBox2 have values
            If CheckBox1.Checked Then
                ' Create a JSON object for minAge and maxAge
                updatedRestrictions.Add("minAge", If(Not String.IsNullOrEmpty(TextBox1.Text), TextBox1.Text, Nothing))
                updatedRestrictions.Add("maxAge", If(Not String.IsNullOrEmpty(TextBox2.Text), TextBox2.Text, Nothing))
            Else
                ' Add null values for minAge and maxAge
                updatedRestrictions.Add("minAge", Nothing)
                updatedRestrictions.Add("maxAge", Nothing)
            End If

            ' Check if CheckBox2 is checked and TextBox3 has a value
            If CheckBox2.Checked Then
                ' Add numOfParticipants to updatedRestrictions
                updatedRestrictions.Add("maxParticipants", TextBox3.Text)
            Else
                ' Add null value for numOfParticipants
                updatedRestrictions.Add("maxParticipants", Nothing)
            End If

            ' Convert the updatedRestrictions JObject to a JSON string
            Dim updatedRestrictionsJson As String = updatedRestrictions.ToString()

            ' Update the database with the new JSON string
            Dim query As String = "UPDATE festivals SET restrictions = @RestrictionsJson WHERE name = @CurrEvent"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RestrictionsJson", updatedRestrictionsJson)
                cmd.Parameters.AddWithValue("@CurrEvent", Module1.CurrEvent)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using

            ' Show a success message
            MessageBox.Show("Restrictions updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try



        ' If all conditions are met
        'MessageBox.Show("All conditions met.")
    End Sub
End Class