Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json.Linq

Public Class FestivalEvents_RegRestrictions
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Private isAcceptingReg As Boolean = False

    Private Sub FestivalEvents_RegRestrictions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized

        Me.FormBorderStyle = FormBorderStyle.None
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM festivals WHERE id = @CurrEvent"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CurrEvent", Module1.CurrEventID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                reader.Read()
                Dim restrictions As String = If(Not IsDBNull(reader("restrictions")), reader("restrictions").ToString(), "{}")
                Dim restrictionsObject As JObject = JObject.Parse(restrictions)
                isAcceptingReg = reader("isOpen")

                ' Extract fields from JSON object
                Dim minAge As Integer? = If(restrictionsObject("minAge") IsNot Nothing, restrictionsObject("minAge").ToObject(Of Integer?)(), Nothing)
                Dim maxAge As Integer? = If(restrictionsObject("maxAge") IsNot Nothing, restrictionsObject("maxAge").ToObject(Of Integer?)(), Nothing)
                Dim maxParticipants As Integer? = If(restrictionsObject("maxParticipants") IsNot Nothing, restrictionsObject("maxParticipants").ToObject(Of Integer?)(), Nothing)

                ' Populate UI controls based on extracted fields
                CheckBox1.Checked = minAge IsNot Nothing
                CheckBox2.Checked = maxAge IsNot Nothing
                CheckBoxApplyMaxParticipants.Checked = maxParticipants IsNot Nothing

                If minAge IsNot Nothing Then
                    TrackBarMinAge.Value = minAge.Value
                    LabelMinAgeValue.Text = minAge.Value.ToString()
                End If

                If maxAge IsNot Nothing Then
                    TrackBarMaxAge.Value = maxAge.Value
                    LabelMaxAgeValue.Text = maxAge.Value.ToString()
                End If

                If maxParticipants IsNot Nothing Then
                    TextBoxMaxParticipants.Text = maxParticipants.ToString()
                End If
                CheckBox1_CheckedChanged(CheckBox1, EventArgs.Empty)
                CheckBox2_CheckedChanged(CheckBox2, EventArgs.Empty)
                CheckBoxApplyMaxParticipants_CheckedChanged(CheckBoxApplyMaxParticipants, EventArgs.Empty)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error fetching festival details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        ' Update button appearance based on the state
        If isAcceptingReg Then
            Button1.Text = "Form Open"
            Button1.BackColor = Color.Black
        Else
            Button1.Text = "Form Closed"
            Button1.BackColor = Color.Gray
        End If
    End Sub

    Private Sub ToggleButton_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Toggle the state
        isAcceptingReg = Not isAcceptingReg

        ' Update button appearance based on the state
        If isAcceptingReg Then
            Button1.Text = "Form Open"
            Button1.BackColor = Color.Black
        Else
            Button1.Text = "Form Closed"
            Button1.BackColor = Color.Gray
        End If
    End Sub


    Private Sub TextBoxMaxParticipants_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMaxParticipants.KeyPress
        ' Check if the pressed key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the pressed key is not a digit and not a control key, ignore it
            e.Handled = True
        End If
    End Sub


    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim updatedRestrictions As New JObject()

        ' Check if CheckBoxApplyMinAge is checked and TrackBarMinAge has value
        If CheckBox1.Checked Then
            updatedRestrictions.Add("minAge", TrackBarMinAge.Value)
        Else
            updatedRestrictions.Add("minAge", Nothing)
        End If

        ' Check If CheckBoxApplyMaxAge Is checked And TrackBarMaxAge has value
        If CheckBox2.Checked Then
            updatedRestrictions.Add("maxAge", TrackBarMaxAge.Value)
        Else
            updatedRestrictions.Add("maxAge", Nothing)
        End If

        ' Check if CheckBoxApplyMaxParticipants is checked and TextBoxMaxParticipants has value and contains only numbers
        If CheckBoxApplyMaxParticipants.Checked Then
            Dim maxParticipants As Integer
            If Integer.TryParse(TextBoxMaxParticipants.Text, maxParticipants) AndAlso maxParticipants > 0 Then
                ' Only add maxParticipants if it's a valid integer greater than 0
                updatedRestrictions.Add("maxParticipants", maxParticipants)
            Else
                MessageBox.Show("Please enter a valid number for maximum participants.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Exit the subroutine without saving
            End If
        Else
            updatedRestrictions.Add("maxParticipants", Nothing)
        End If

        Try
            conn.Open()
            ' Check if minAge is less than maxAge
            If updatedRestrictions("minAge") IsNot Nothing AndAlso updatedRestrictions("maxAge") IsNot Nothing Then
                Dim minAge As Integer? = updatedRestrictions.Value(Of Integer?)("minAge")
                Dim maxAge As Integer? = updatedRestrictions.Value(Of Integer?)("maxAge")

                If minAge.HasValue AndAlso maxAge.HasValue AndAlso minAge.Value > maxAge.Value Then
                    MessageBox.Show("Minimum age must be less than maximum age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return ' Exit the subroutine without saving
                End If
            End If

            ' Convert the updatedRestrictions JObject to a JSON string
            Dim updatedRestrictionsJson As String = updatedRestrictions.ToString()

            ' Update the database with the new JSON string
            Dim query As String = "UPDATE festivals SET restrictions = @RestrictionsJson WHERE id = @CurrEvent"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RestrictionsJson", updatedRestrictionsJson)
                cmd.Parameters.AddWithValue("@CurrEvent", Module1.CurrEventID)
                cmd.ExecuteNonQuery()
            End Using

            query = "UPDATE festivals SET isopen = @isAcceptingReg WHERE id = @CurrEvent"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@isAcceptingReg", isAcceptingReg)
                cmd.Parameters.AddWithValue("@CurrEvent", Module1.CurrEventID)
                cmd.ExecuteNonQuery()
            End Using

            ' Show a success message
            MessageBox.Show("Restrictions updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub




    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim form As New FestivalEvents_EventDetails
        form.TopLevel = False
        mypanel.Panel1.Controls.Clear()
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TrackBarMinAge.Enabled = CheckBox1.Checked
        'If Not CheckBox1.Checked Then
        '    TrackBarMinAge.Value = TrackBarMinAge.Minimum ' Reset the value when CheckBox1 is unchecked
        'End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        TrackBarMaxAge.Enabled = CheckBox2.Checked
        'If Not CheckBox2.Checked Then
        '    TrackBarMaxAge.Value = TrackBarMaxAge.Minimum ' Reset the value when CheckBox2 is unchecked
        'End If
    End Sub

    Private Sub CheckBoxApplyMaxParticipants_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxApplyMaxParticipants.CheckedChanged
        TextBoxMaxParticipants.Enabled = CheckBoxApplyMaxParticipants.Checked
        If Not CheckBoxApplyMaxParticipants.Checked Then
            TextBoxMaxParticipants.Text = "" ' Clear the text when CheckBoxApplyMaxParticipants is unchecked
        End If
    End Sub

    Private Sub TrackBarMinAge_Scroll(sender As Object, e As EventArgs) Handles TrackBarMinAge.Scroll
        LabelMinAgeValue.Text = TrackBarMinAge.Value.ToString()
    End Sub

    Private Sub TrackBarMaxAge_Scroll(sender As Object, e As EventArgs) Handles TrackBarMaxAge.Scroll
        LabelMaxAgeValue.Text = TrackBarMaxAge.Value.ToString()
    End Sub
End Class
