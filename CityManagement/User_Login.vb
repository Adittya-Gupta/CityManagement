Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class User_Login

    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Public Shared GlobalSID As Integer = -1

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized


        ' Set initial visibility of login labels
        EmailLabel.Visible = False
        PasswordLabel.Visible = False

        ' Set initial text of text boxes
        EmailTextBox.Text = "Email"
        PasswordTextBox.Text = "Password"

    End Sub

    ' Function to hash the password using SHA256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub EmailTextBox_Enter(sender As Object, e As EventArgs) Handles EmailTextBox.Click
        If EmailTextBox.Text = "Email" Then
            EmailTextBox.Text = ""
            EmailLabel.ForeColor = Color.Black ' Set initial color to black
            EmailLabel.Visible = True ' Show the label
            Timer1.Start() ' Start the animation timer
        End If
    End Sub

    Private Sub EmailTextBox_Leave(sender As Object, e As EventArgs) Handles EmailTextBox.Leave
        If EmailTextBox.Text = "" Then
            EmailTextBox.Text = "Email"
            Timer1.Stop() ' Stop the animation timer
            EmailLabel.Visible = False ' Hide the label when leaving the textbox
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment the opacity of the label's ForeColor gradually
        Dim newColor As Color = Color.FromArgb(Math.Min(EmailLabel.ForeColor.R + 60, 255),
                                               Math.Min(EmailLabel.ForeColor.G + 60, 255),
                                               Math.Min(EmailLabel.ForeColor.B + 60, 255))
        EmailLabel.ForeColor = newColor

        ' Stop the animation when the color becomes white
        If newColor = Color.White Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub PasswordTextBox_Enter(sender As Object, e As EventArgs) Handles PasswordTextBox.Click
        If PasswordTextBox.Text = "Password" Then
            PasswordTextBox.Text = ""
            PasswordTextBox.PasswordChar = "•" ' Set password character
            PasswordLabel.ForeColor = Color.Black ' Set initial color to black
            PasswordLabel.Visible = True ' Show the label
            Timer2.Start() ' Start the animation timer
        End If
    End Sub

    Private Sub PasswordTextBox_Leave(sender As Object, e As EventArgs) Handles PasswordTextBox.Leave
        If PasswordTextBox.Text = "" Then
            PasswordTextBox.Text = "Password"
            PasswordTextBox.PasswordChar = ControlChars.NullChar ' Reset password character
            Timer2.Stop() ' Stop the animation timer
            PasswordLabel.Visible = False ' Hide the label when leaving the textbox
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Increment the opacity of the label's ForeColor gradually
        Dim newColor As Color = Color.FromArgb(Math.Min(PasswordLabel.ForeColor.R + 60, 255),
                                               Math.Min(PasswordLabel.ForeColor.G + 60, 255),
                                               Math.Min(PasswordLabel.ForeColor.B + 60, 255))
        PasswordLabel.ForeColor = newColor

        ' Stop the animation when the color becomes white
        If newColor = Color.White Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub SignUpLabel_Click(sender As Object, e As EventArgs) Handles SignUpLabel.Click
        ' Open the signup form when the label is clicked
        Dim signUpForm As New User_SignUpForm()
        signUpForm.StartPosition = FormStartPosition.Manual
        signUpForm.Location = Me.Location ' Set the location of the new form to the current form's location
        signUpForm.Show()
        Me.Hide()
    End Sub



    ' Button click event handler to toggle password visibility
    Private Sub TogglePasswordButton_Click(sender As Object, e As EventArgs) Handles TogglePasswordButton.Click
        If PasswordTextBox.PasswordChar = ControlChars.NullChar Then
            ' Password is currently hidden, show it
            PasswordTextBox.PasswordChar = "•"
        Else
            ' Password is currently shown, hide it
            PasswordTextBox.PasswordChar = ControlChars.NullChar
        End If
    End Sub

    ' Example email validation function

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ' Get the email and password entered by the user
        Dim email As String = EmailTextBox.Text
        Dim password As String = PasswordTextBox.Text

        ' Check if the email is empty
        If String.IsNullOrEmpty(email) OrElse email = "Email" Then
            MessageBox.Show("Please enter your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the email is in a valid format (you may use a more robust email validation method)
        If Not email.Contains("@") OrElse Not email.Contains(".") Then
            MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the password is empty
        If String.IsNullOrEmpty(password) OrElse password = "Password" Then
            MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Try
            conn.Open()

            ' Retrieve the hashed password associated with the provided email from the database
            Dim query As String = "SELECT SID,PasswordHash FROM User WHERE EmailAddress = @Email"
            Dim hashedPassword As String = ""
            Dim database_sid = -1
            Using cmd As New MySqlCommand(query, conn)
                ' Use parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@Email", email)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    database_sid = Convert.ToString(reader("SID"))
                    hashedPassword = Convert.ToString(reader("PasswordHash"))
                End If
                reader.Close()
            End Using

            ' Hash the password provided by the user for comparison
            Dim hashedInputPassword As String = HashPassword(password)

            ' Compare the hashed password from the database with the hashed password provided by the user
            If hashedPassword = hashedInputPassword Then
                ' If the passwords match, login successful
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GlobalSID = database_sid
                ' Add code to navigate to the next form or perform other actions upon successful login
                Dim profile As New User_Profile()
                profile.StartPosition = FormStartPosition.Manual
                profile.Location = Me.Location ' Set the location of the new form to the current form's location
                profile.Show()
                Me.Hide()

            Else
                ' If the passwords do not match, login failed
                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try


        ' Perform any other necessary checks (e.g., password length, special characters, etc.)



    End Sub
End Class
