Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class HistoryItem
    ' Enumeration for different states of the appointment
    Enum AppointmentState
        EnquirySent
        Rejected
        Withdrawn
        Upcoming
        Cancelled
        InProgress
        Completed
        Finished
    End Enum

    ' Enumeration for different actions that can be performed
    Enum CustomerAction
        Withdraw
        Cancel
        Pay
        Rate
        None
    End Enum

    Public BookingId As String

    ' Dictionary to store the colors for each appointment state
    Private stateColors As New Dictionary(Of AppointmentState, Color) From {
        {AppointmentState.EnquirySent, ColorTranslator.FromHtml("#001D64")},
        {AppointmentState.Rejected, ColorTranslator.FromHtml("#8E00FE")},
        {AppointmentState.Withdrawn, ColorTranslator.FromHtml("#8E00FE")},
        {AppointmentState.Upcoming, ColorTranslator.FromHtml("#FEBA31")},
        {AppointmentState.Cancelled, ColorTranslator.FromHtml("#8E00FE")},
        {AppointmentState.InProgress, ColorTranslator.FromHtml("#454BDE")},
        {AppointmentState.Completed, ColorTranslator.FromHtml("#22D249")},
        {AppointmentState.Finished, ColorTranslator.FromHtml("#22D249")}
    }

    ' Dictionary to store the colors for each customer action
    Private actionColors As New Dictionary(Of String, Color) From {
        {"None", ColorTranslator.FromHtml("#929292")},
        {"Withdraw", ColorTranslator.FromHtml("#FFBC2929")},
        {"Cancel", ColorTranslator.FromHtml("#FFBC2929")},
        {"Pay", ColorTranslator.FromHtml("#22D249")},
        {"Rate", ColorTranslator.FromHtml("#FF7F23")}
    }

    ' Current state of the appointment
    Private currentAppointmentState As AppointmentState = AppointmentState.EnquirySent

    ' Function to update the appointment state and corresponding actions
    Private Sub UpdateAppointmentState(newState As AppointmentState)
        currentAppointmentState = newState

        ' Update CurvedLabel3 based on the new state
        Select Case currentAppointmentState
            Case AppointmentState.EnquirySent
                CurvedLabel3.Text = "Enquiry Sent"
                CurvedLabel4.Text = "Withdraw"
            Case AppointmentState.Rejected
                CurvedLabel3.Text = "Rejected"
                CurvedLabel4.Text = "None"
            Case AppointmentState.Withdrawn
                CurvedLabel3.Text = "Withdrawn"
                CurvedLabel4.Text = "None"
            Case AppointmentState.Upcoming
                CurvedLabel3.Text = "Upcoming"
                CurvedLabel4.Text = "Cancel"
            Case AppointmentState.Cancelled
                CurvedLabel3.Text = "Cancelled"
                CurvedLabel4.Text = "None"
            Case AppointmentState.InProgress
                CurvedLabel3.Text = "In Progress"
                CurvedLabel4.Text = "Pay"
            Case AppointmentState.Completed
                CurvedLabel3.Text = "Completed"
                CurvedLabel4.Text = "Rate"
            Case AppointmentState.Finished
                CurvedLabel3.Text = "Finished"
                CurvedLabel4.Text = "None"
        End Select

        ' Assign colors based on status and action
        CurvedLabel3.ForeColor = stateColors(currentAppointmentState)
        CurvedLabel4.BackColor = actionColors(CurvedLabel4.Text)
    End Sub
    Private Sub HandleAction(action As CustomerAction)
        Dim newState As AppointmentState
        Dim previousState As AppointmentState = currentAppointmentState

        Select Case action
            Case CustomerAction.Withdraw
                If currentAppointmentState = AppointmentState.EnquirySent Then
                    ' Perform action to withdraw the enquiry
                    ' Update the state
                    UpdateAppointmentState(AppointmentState.Withdrawn)
                    newState = AppointmentState.Withdrawn
                End If
            Case CustomerAction.Cancel
                If currentAppointmentState = AppointmentState.Upcoming Then
                    ' Perform action to cancel the appointment
                    ' Update the state
                    UpdateAppointmentState(AppointmentState.Cancelled)
                    newState = AppointmentState.Cancelled
                End If
            Case CustomerAction.Pay
                If currentAppointmentState = AppointmentState.InProgress Then
                    ' Perform action to pay
                    ' Update the state
                    UpdateAppointmentState(AppointmentState.Completed)
                    newState = AppointmentState.Completed
                End If
            Case CustomerAction.Rate
                If currentAppointmentState = AppointmentState.Completed Then
                    ' Perform action to rate
                    ' Update the state
                    UpdateAppointmentState(AppointmentState.Finished)
                    newState = AppointmentState.Finished
                End If
        End Select

        ' Update Globals.ServiceHistory.OriginalStatusList by subtracting one from the previous state and adding one to the new state
        Globals.ServiceHistoryForm.OriginalStatusCount(previousState) -= 1
        Globals.ServiceHistoryForm.OriginalStatusCount(newState) += 1

        ' Update status in the database
        UpdateStatusInDatabase(newState)
    End Sub

    ' Constructor with optional parameters
    Public Sub New(
                Optional ByVal bookingid As String = "1",
                Optional ByVal name As String = "Default Name",
               Optional ByVal serviceTime As String = "Will be updated",
               Optional ByVal billAmount As String = "To be Decided",
               Optional ByVal ratingValue As Double = 3.5,
               Optional ByVal currentState As AppointmentState = AppointmentState.EnquirySent)

        InitializeComponent()

        ' Set the values of the components based on the parameters
        Me.BookingId = bookingid
        Label1.Text = name
        Label2.Text = serviceTime
        Label3.Text = billAmount
        Rating1.RatingValue = ratingValue

        ' Initialize the appointment state
        UpdateAppointmentState(currentState)

        ' Make the PictureBox round
        MakePictureBoxRound(PictureBox1)
    End Sub

    Private Sub MakePictureBoxRound(pictureBox As PictureBox)
        ' Create a GraphicsPath to define a circle
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height)

        ' Set the PictureBox's region to the circle defined by the GraphicsPath
        pictureBox.Region = New Region(path)
    End Sub

    Private Sub CurvedLabel4_Click(sender As Object, e As EventArgs) Handles CurvedLabel4.Click
        ' Handle the action based on the current state
        Globals.ServiceHistoryForm.semaphore.WaitOne()
        Select Case currentAppointmentState
            Case AppointmentState.EnquirySent
                HandleAction(CustomerAction.Withdraw)
            Case AppointmentState.Upcoming
                HandleAction(CustomerAction.Cancel)
            Case AppointmentState.InProgress
                HandleAction(CustomerAction.Pay)
            Case AppointmentState.Completed
                Using rateform As New Rate()
                    'Change the position to be in the centre of the screen
                    Dim result As DialogResult = rateform.ShowDialog()
                    If result = DialogResult.OK Then
                        ' Get the selected stars count from the child form
                        Dim selectedStarsCount As Integer = rateform.SelectedStars
                        HandleAction(CustomerAction.Rate)
                    End If
                End Using
        End Select
        Globals.ServiceHistoryForm.semaphore.Release()
    End Sub

    Private Sub UpdateStatusInDatabase(newState As AppointmentState)
        ' Define the SQL query to update the status in the serviceBooking table
        Dim query As String = "UPDATE serviceBooking SET status = @status WHERE serviceBookingId = @bookingId"
        ' Create MySQL connection
        Using connection As New MySqlConnection(Globals.connectionstring)
            ' Open the connection
            connection.Open()

            ' Create MySqlCommand
            Using command As New MySqlCommand(query, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@status", newState.ToString())

                ' Add bookingId parameter (you need to define bookingId variable)
                command.Parameters.AddWithValue("@bookingId", Me.BookingId)

                ' Execute the command
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
