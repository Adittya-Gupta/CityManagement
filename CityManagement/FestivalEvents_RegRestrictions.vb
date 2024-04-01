Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json.Linq

Public Class FestivalEvents_RegRestrictions
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Private Sub FestivalEvents_RegRestrictions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the initial state of CheckBox1 and adjust controls accordingly
        Try
            Dim query As String = "SELECT * FROM festivals WHERE id = @CurrEventId "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CurrEventId", Module1.CurrEventID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                reader.Read()
                Dim restrictions As String = If(Not IsDBNull(reader("restrictions")), reader("restrictions").ToString(), "{}")
                Dim restrictionsArray As JArray = JArray.Parse(restrictions)

                ' Variables to store extracted fields
                Dim age1 As String = Nothing
                Dim age2 As String = Nothing
                Dim numOfParticipants As String = Nothing

                ' Iterate through JSON array and extract fields
                For Each item As JObject In restrictionsArray
                    If item.ContainsKey("age1") Then
                        age1 = item("age1").ToString()
                    ElseIf item.ContainsKey("age2") Then
                        age2 = item("age2").ToString()
                    ElseIf item.ContainsKey("numOfParticipants") Then
                        numOfParticipants = item("numOfParticipants").ToString()
                    End If
                Next
                If age1 Is Nothing AndAlso age2 Is Nothing Then
                    ' If both are null, uncheck CheckBox1
                    CheckBox1.Checked = False
                Else
                    ' If at least one of them is non-null, populate TextBox1 and TextBox2 accordingly
                    TextBox1.Text = If(age1, "") ' Put age1 in TextBox1, empty if null
                    TextBox2.Text = If(age2, "") ' Put age2 in TextBox2, empty if null
                    CheckBox1.Checked = True ' Check CheckBox1
                End If

                ' Check if numOfParticipants is null/nothing
                If numOfParticipants Is Nothing Then
                    ' If it's null, uncheck CheckBox2
                    CheckBox2.Checked = False
                Else
                    ' If it's not null, populate TextBox3
                    TextBox3.Text = numOfParticipants ' Put numOfParticipants in TextBox3
                    CheckBox2.Checked = True ' Check CheckBox2
                End If
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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
            Dim updatedRestrictions As New JArray()
            If CheckBox1.Checked AndAlso Not String.IsNullOrEmpty(TextBox1.Text) AndAlso Not String.IsNullOrEmpty(TextBox2.Text) Then
                ' Create a JSON object for age1 and age2
                Dim ageObject As New JObject()
                ageObject.Add("age1", TextBox1.Text)
                ageObject.Add("age2", TextBox2.Text)
                ' Add ageObject to updatedRestrictions
                updatedRestrictions.Add(ageObject)
            End If

            ' Check if CheckBox2 is checked and TextBox3 has a value
            If CheckBox2.Checked AndAlso Not String.IsNullOrEmpty(TextBox3.Text) Then
                ' Create a JSON object for numOfParticipants
                Dim participantsObject As New JObject()
                participantsObject.Add("numOfParticipants", TextBox3.Text)
                ' Add participantsObject to updatedRestrictions
                updatedRestrictions.Add(participantsObject)
            End If

            ' Convert the updatedRestrictions JArray to a JSON string
            Dim updatedRestrictionsJson As String = updatedRestrictions.ToString()

            ' Update the database with the new JSON string
            Dim query As String = "UPDATE festivals SET restrictions = @RestrictionsJson WHERE id = @CurrEventId"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RestrictionsJson", updatedRestrictionsJson)
                cmd.Parameters.AddWithValue("@CurrEventId", Module1.CurrEventID)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using

            ' Show a success message
            MessageBox.Show("Restrictions updated successfully.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try


        ' If all conditions are met
        MessageBox.Show("All conditions met.")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class