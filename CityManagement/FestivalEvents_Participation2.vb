Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class FestivalEvents_Participation2
    ' Database connection string
    Dim connString As String = Module1.connString
    ' MySqlConnection object to handle communication with the MySQL database
    Dim conn As New MySqlConnection(connString)

    Dim EventId As Integer = CurrEventID
    Dim UserSID As Integer = CurrUserSID

    'Dim EventId As Integer = 4
    'Dim UserSID As Integer = 1

    Public Class Restrictions
        Public Property minAge As Integer?
        Public Property maxAge As Integer?
        Public Property maxParticipants As Integer?
    End Class

    Private restriction As Restrictions


    Private Sub Event_Participation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If UserSID <> -1 Then
            ' Assume EventID is somehow determined or passed to this form
            Dim eventDetails As Dictionary(Of String, Object) = GetEventDetails(EventId)
            If eventDetails IsNot Nothing Then
                ' Populate the labels with these details
                EventName.Text = eventDetails("EventName").ToString()
                EventVenue.Text = eventDetails("Venue").ToString()
                Description.Text = eventDetails("EventDescription").ToString()

                ' Parse and format the DateTime to separate date and time
                Dim eventDateTime As DateTime
                If DateTime.TryParse(eventDetails("DateTime").ToString(), eventDateTime) Then
                    EventDate.Text = eventDateTime.ToString("d") ' Example format: 12/31/2020
                    EventTime.Text = eventDateTime.ToString("t") ' Example format: 11:59 PM
                End If

                ' If a cover image is available, load it into the PictureBox
                Dim CoverImageData As Byte() = TryCast(eventDetails("CoverImage"), Byte())
                If CoverImageData IsNot Nothing Then
                    Dim ms As New System.IO.MemoryStream(CoverImageData)
                    PictureBox1.Image = Image.FromStream(ms)
                End If


                restriction = JsonConvert.DeserializeObject(Of Restrictions)(eventDetails("Restrictions").ToString())

                ' Add restrictionsList data to form
                Dim minAgeText As String = If(restriction.minAge.HasValue, $"{restriction.minAge}", "Not specified")
                Dim maxAgeText As String = If(restriction.maxAge.HasValue, $"{restriction.maxAge}", "Not specified")
                Dim maxParticipantsText As String = If(restriction.maxParticipants.HasValue, $"{restriction.maxParticipants}", "Not specified")
                minage.Text = minAgeText
                maxage.Text = maxAgeText
                capacity.Text = maxParticipantsText

            Else
                MessageBox.Show("Festival details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Try
                conn.Open() ' Open database connection

                Dim isRegistered As Boolean = False
                Dim query As String = "SELECT COUNT(*) FROM Attendee WHERE EventID = @EventID AND UserID = @UserID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EventID", EventId)
                    cmd.Parameters.AddWithValue("@UserID", UserSID)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        isRegistered = True
                    End If
                End Using

                ' Set the button text based on the registration status
                If isRegistered Then
                    Button1.Text = "Unregister"
                Else
                    Button1.Text = "Register"
                End If

            Catch ex As Exception
                MessageBox.Show("Failed to load event registration status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("User not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open() ' Open database connection

            ' Check if the event is open
            Dim isOpen As Boolean
            Dim checkOpenQuery As String = "SELECT isopen FROM festivals WHERE id = @EventID"
            Using cmd As New MySqlCommand(checkOpenQuery, conn)
                cmd.Parameters.AddWithValue("@EventID", EventId)
                isOpen = Convert.ToBoolean(cmd.ExecuteScalar())
            End Using

            ' Get user's date of birth from the database
            Dim dob As Date
            Dim getDobQuery As String = "SELECT DOB FROM User WHERE SID = @UserSID"
            Using cmd As New MySqlCommand(getDobQuery, conn)
                cmd.Parameters.AddWithValue("@UserSID", UserSID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    dob = Convert.ToDateTime(reader("dob"))
                End If
                reader.Close()
            End Using

            ' Calculate user's age based on date of birth
            Dim userAge As Integer = Date.Now.Year - dob.Year
            If Date.Now < dob.AddYears(userAge) Then
                userAge -= 1 ' Adjust age if the birthday hasn't occurred yet this year
            End If

            ' Check if the user's age falls within the event restrictions
            Dim isAgeValid As Boolean = True
            Dim restrictionsQuery As String = "SELECT restrictions FROM festivals WHERE id = @EventID"
            Using cmdRestrictions As New MySqlCommand(restrictionsQuery, conn)
                cmdRestrictions.Parameters.AddWithValue("@EventID", EventId)
                Dim restrictionsJson As String = cmdRestrictions.ExecuteScalar().ToString()
                Dim restrictions As Restrictions = JsonConvert.DeserializeObject(Of Restrictions)(restrictionsJson)
                If restrictions IsNot Nothing Then
                    If restrictions.minAge.HasValue AndAlso userAge < restrictions.minAge Then
                        isAgeValid = False
                    End If
                    If restrictions.maxAge.HasValue AndAlso userAge > restrictions.maxAge Then
                        isAgeValid = False
                    End If
                End If

            End Using

            ' Check if the user is already registered for the event
            Dim isRegistered As Boolean = False
            Dim query As String = "SELECT COUNT(*) FROM Attendee WHERE EventID = @EventID AND UserID = @UserID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EventID", EventId)
                cmd.Parameters.AddWithValue("@UserID", UserSID)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    isRegistered = True
                End If
            End Using

            ' If the event is open and the user's age is within the restrictions, proceed with registration/unregistration
            If isOpen AndAlso isAgeValid Then
                ' If the user is not already registered, register them for the event
                If Not isRegistered Then
                    Dim insertQuery As String = "INSERT INTO Attendee (EventID, UserID) VALUES (@EventID, @UserID)"
                    Using cmd As New MySqlCommand(insertQuery, conn)
                        cmd.Parameters.AddWithValue("@EventID", EventId)
                        cmd.Parameters.AddWithValue("@UserID", UserSID)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("You have successfully registered for the event.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Change the button text to "Unregister" since the user is now registered
                    Button1.Text = "Unregister"
                Else
                    ' If the user is already registered, unregister them from the event
                    Dim deleteQuery As String = "DELETE FROM Attendee WHERE EventID = @EventID AND UserID = @UserID"
                    Using cmd As New MySqlCommand(deleteQuery, conn)
                        cmd.Parameters.AddWithValue("@EventID", EventId)
                        cmd.Parameters.AddWithValue("@UserID", UserSID)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("You have successfully unregistered from the event.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Change the button text to "Register" since the user is now unregistered
                    Button1.Text = "Register"
                End If
            Else
                ' Notify the user if the event is not open or if their age is not within the restrictions
                If Not isOpen Then
                    MessageBox.Show("The event is not currently open for registration.", "Event Not Open", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf Not isAgeValid Then
                    MessageBox.Show("You do not meet the age restrictions for this event.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to update event registration status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close() ' Close the database connection
            End If
        End Try
    End Sub


    ' Retrieves festival details from the database using the provided EventID
    Private Function GetEventDetails(EventID As Integer) As Dictionary(Of String, Object)
        Dim festivalDetails As New Dictionary(Of String, Object)()
        Try
            conn.Open() ' Open database connection
            ' SQL query to fetch festival details
            Dim query As String = "SELECT name, description, image, owner_sid, vendor_service_tags, event_type, venue, dateTime, isapproved, isopen, restrictions FROM festivals WHERE id = @EventID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EventID", EventID) ' Bind the EventID parameter
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    festivalDetails.Add("EventName", reader("name"))
                    festivalDetails.Add("DateTime", reader("dateTime").ToString())
                    festivalDetails.Add("Venue", reader("venue"))
                    festivalDetails.Add("EventDescription", reader("description"))
                    festivalDetails.Add("Restrictions", If(Not IsDBNull(reader("restrictions")), reader("restrictions").ToString(), "{}"))
                    ' Assuming CoverImage is also being retrieved here based on your initial setup
                    festivalDetails.Add("CoverImage", If(Not IsDBNull(reader("image")), DirectCast(reader("image"), Byte()), Nothing))
                    ' Additional fields can be added as needed
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching festival details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close() ' Ensure the connection is closed even if an error occurs
        End Try
        Return festivalDetails
    End Function

    Private Sub ApplyFontToControl(ByVal control As Control, ByVal font As Font)
        ' Set font for the current control
        control.Font = font

        ' Recursively set font for all child controls
        For Each childControl As Control In control.Controls
            ApplyFontToControl(childControl, font)
        Next
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New FestivalEvents_EventDetails
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class