Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Net.Mail
Imports System.Windows.Forms
Public Class ForgotPassword
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    'Dim EmailAddress As String = Environment.GetEnvironmentVariable("Email")
    Dim randomCode As String
    Dim elapsedTime As Integer = 0 ' Track elapsed time in seconds
    Dim WithEvents timer As New Timer()

    Private Sub ForgotPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Hide()
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
        Dim timeLeft As Integer = 60 - elapsedTime
        TimeLeftLabel.Text = "Time Left: " & timeLeft.ToString() & " seconds"
        If elapsedTime >= 60 Then ' Check if 60 seconds have elapsed
            timer.Stop() ' Stop the timer
            MessageBox.Show("Verification code has expired. Please request a new one by clicking Send Code again.")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Label2.Visible = True
        Label2.Text = "Sending code....."
        Label2.ForeColor = Color.Black

        Dim EmailAddress As String = Email_tb.Text

        If String.IsNullOrEmpty(EmailAddress) Then
            MessageBox.Show("Please enter your Email to send code")
            Label2.Hide()

            Return
        End If

        If Not IsEmailPresent(EmailAddress) Then
            Label2.Hide()

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
            mail.Body = "Verification Code is: " + randomCode

            SmtpServer.Port = 587
            SmtpServer.Credentials = New NetworkCredential("smartcitymanagement123@gmail.com", "yycerewjfqyirppg ")
            SmtpServer.EnableSsl = True

            Try
                SmtpServer.Send(mail)
                MessageBox.Show("Please check your Email for the verification code and enter it below!")
                timer.Start() ' Start the timer
            Catch ex As Exception
                'Label2.Visible = True
                Label2.Text = "Unexpected Error occured!! Please click on send code again!"
                Label2.ForeColor = Color.Red
                MessageBox.Show("Error occured sending code :", ex.Message)

            End Try

            'Label2.Visible = True
            Label2.Text = "Code sent!" & Environment.NewLine & "Please check your Email for the code and enter it below!"
            Label2.ForeColor = Color.Green

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("Please enter the code to proceed!")
            Return
        End If

        If elapsedTime < 60 Then ' Check if the elapsed time is less than 60 seconds
            If TextBox1.Text.Equals(randomCode) Then
                timer.Stop()
                switchPanel(User_ChangePassword)
                'Dim resetPassword As New User_ChangePassword()
                'resetPassword.Show()
                'Me.Hide()

            ElseIf elapsedTime = 0 Then
                MessageBox.Show("Please click on send code to get a code")
                Return
            Else
                Label2.Text = "Incorrect code."
                Label2.ForeColor = Color.Red
                MessageBox.Show("Incorrect code.")
            End If
        Else
            Label2.Text = "Verification code has expired. Please request a new one by clicking on Send Code again."
            Label2.ForeColor = Color.Red
            MessageBox.Show("Verification code has expired. Please request a new one by clicking on send code again.")
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Open the login form when the button is clicked
        Dim LoginForm As New User_Login()
        LoginForm.StartPosition = FormStartPosition.Manual
        LoginForm.Location = Me.Location ' Set the location of the new form to the current form's location
        LoginForm.Show()
        Me.Close()
    End Sub

End Class

