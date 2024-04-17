Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Net.Mail
Imports System.Windows.Forms

Public Class ForgotPassword
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Dim randomCode As String
    Dim elapsedTime As Integer = 0 ' Track elapsed time in seconds
    Dim incorrectAttempts As Integer = 0 ' Track incorrect attempts
    Dim WithEvents timer As New Timer()
    Dim resendTimer As New Timer()


    Private Sub ForgotPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Hide()
        ResendLabel.Visible = False ' Hide the resend label initially
    End Sub

    Public Function IsEmailPresent(ByVal EmailAddress As String) As Boolean
        Dim isPresent As Boolean = False

        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM User " &
                    "WHERE EmailAddress = @Email"

                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", EmailAddress)

                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                If count > 0 Then
                    isPresent = True
                    Environment.SetEnvironmentVariable("Email", EmailAddress)
                Else
                    MessageBox.Show("Email you have entered has not been registered!!.", "INVALID EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return isPresent
    End Function


    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    ' Timer tick event handler to track elapsed time
    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer.Tick
        elapsedTime += 1 ' Increment elapsed time by 1 second

        ' Calculate remaining time
        Dim timeLeft As Integer = 180 - elapsedTime

        ' Update the TimeLeftLabel with the remaining time
        Label6.Text = "Time Left: " & timeLeft.ToString() & " seconds"

        ' Check if 180 seconds have elapsed
        If elapsedTime >= 180 Then
            timer.Stop() ' Stop the timer
            MessageBox.Show("Verification code has expired. Please request a new one by clicking Send Code again.")
            Button1.Visible = True ' Make the Send Code button visible again
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        incorrectAttempts = 0

        Button1.Visible = False ' Hide the Send Code button
        Label2.Text = "Sending code....."
        Label2.Visible = True
        Label2.ForeColor = Color.Black

        ResendLabel.Text = "Resend code (30)"
        ResendLabel.Enabled = False ' Make sure it's not clickable yet
        ResendLabel.Visible = True

        ' Initialize the resend timer
        resendTimer.Interval = 1000 ' Update every second
        AddHandler resendTimer.Tick, AddressOf ResendTimer_Tick


        Dim EmailAddress As String = Email_tb.Text

        If String.IsNullOrEmpty(EmailAddress) Then
            MessageBox.Show("Please enter your Email to send code")
            Label2.Hide()
            Button1.Visible = True ' Show the Send Code button again
            Return
        End If

        If Not IsEmailPresent(EmailAddress) Then
            Label2.Hide()
            Button1.Visible = True ' Show the Send Code button again
            Return
        End If

        Dim rand As New Random()
        randomCode = (rand.Next(999999)).ToString()
        elapsedTime = 0 ' Reset elapsed time
        timer.Interval = 1000 ' Set interval to 1 second
        Try
            Dim mail As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")

            mail.From = New MailAddress("SmartCityManagement123@gmail.com")
            mail.To.Add(EmailAddress)
            mail.Subject = "VERIFICATION CODE - FORGOT PASSWORD"
            mail.Body = "Verification Code is: " & randomCode & ". It is valid for 3 minutes."


            SmtpServer.Port = 587
            SmtpServer.Credentials = New NetworkCredential("smartcitymanagement123@gmail.com", "yycerewjfqyirppg ")
            SmtpServer.EnableSsl = True

            Try
                SmtpServer.Send(mail)
                MessageBox.Show("Code has been sent to your Email, Please check your Email and enter the recieved code below!")
                Label2.Text = ""
                timer.Start() ' Start the timer
                resendTimer.Start()
                Label5.Visible = True
                Label6.Visible = True
                Label8.Visible = True
                Label9.Visible = True
                TextBox1.Visible = True
                PictureBox1.Visible = True
                Button2.Visible = True
            Catch ex As Exception
                ' Label2.Visible = True

                MessageBox.Show("Error occurred sending code: " & ex.Message)
                Button1.Visible = True ' Show the Send Code button again
            End Try



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private resendCountdown As Integer = 30 ' Start the countdown from 30 seconds
    Private hasResentCode As Boolean = False

    Private Sub ResendTimer_Tick(sender As Object, e As EventArgs)
        resendCountdown -= 1 ' Decrement the countdown
        ResendLabel.Text = $"Resend code ({resendCountdown})" ' Update the label text

        If resendCountdown <= 0 Then
            resendTimer.Stop() ' Stop the timer
            ResendLabel.Text = "Click here to resend code (Allowed only once) "
            ResendLabel.Enabled = True ' Make it clickable
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("Please enter the code to proceed!")
            Return
        End If

        If elapsedTime < 180 Then ' Check if the elapsed time is less than 180 seconds
            If TextBox1.Text.Equals(randomCode) Then
                timer.Stop()
                Dim Form As New User_ChangePassword()
                Form.StartPosition = FormStartPosition.Manual
                Form.Location = Me.Location ' Set the location of the new form to the current form's location
                Form.Show()
                Me.Hide()
            ElseIf elapsedTime = 0 Then
                MessageBox.Show("Please click on send code to get a code")
                Return
            Else
                incorrectAttempts += 1
                Dim attemptsLeft As Integer = 3 - incorrectAttempts
                If attemptsLeft > 0 Then
                    MessageBox.Show($"Incorrect code. You have {attemptsLeft} attempt(s) left.")
                Else
                    MessageBox.Show("You have entered an incorrect code multiple times. Please try again later.")
                    ' Simulate a click on the "Back to Login" button
                    Button3.PerformClick()
                    Return
                End If
            End If
        Else
            MessageBox.Show("Verification code has expired. Please request a new one by clicking on send code again.")
        End If
    End Sub



    ' Method to resend the code when the resend label is clicked
    Private Sub ResendLabel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ResendLabel.Click

        If hasResentCode Then
            ' If the code has already been resent, do nothing (or show a message)
            MessageBox.Show("Re-sending the code is allowed only once.")
            Return
        End If

        ' Continue with resend logic if the code has not been resent yet
        hasResentCode = True ' Update flag to indicate code has been resent
        ResendLabel.Visible = True
        ResendLabel.Enabled = True
        Button1.Visible = True
        Button1.PerformClick() ' Simulate a click on the "Send Code" button to resend the code
        incorrectAttempts = 0
        ' Label2.Visible = True
    End Sub

    Private Sub Form_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim LoginForm As New User_Login()
        LoginForm.StartPosition = FormStartPosition.Manual
        LoginForm.Location = Me.Location ' Set the location of the new form to the current form's location

        LoginForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class
