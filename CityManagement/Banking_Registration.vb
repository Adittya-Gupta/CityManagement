Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Banking_Registration

    'Dim connString As String = "server=172.16.114.244;userid=admin;password=nimda;database=banking_database"
    'Dim connString As String = "server=localhost;userid=root;password=abinash;database=banking_database;"
    Dim connString As String = Global_Attributes.slqConnection_banking

    Dim PhotoPath As String
    Dim SignPath As String


    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles ButtonPhoto.Click
        ' Show the OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            PhotoPath = openFileDialog.FileName

            ' Display the image in PictureBox
            PictureBoxPhoto.Image = Image.FromFile(PhotoPath)
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSign.Click
        ' Show the OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            SignPath = openFileDialog.FileName

            ' Display the image in PictureBox
            PictureBoxSign.Image = Image.FromFile(SignPath)
        End If
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim Name As String = TextBoxName.Text.Trim()
        Dim Email As String = TextBoxEmail.Text.Trim()
        Dim Phone As String = TextBoxPhone.Text.Trim()
        Dim IdentificationNumber As String = TextBoxIndentificationNumber.Text.Trim()
        Dim Gender As String = ComboBox1.SelectedItem.ToString()
        Dim Username As String = TextBoxUsername.Text.Trim()
        Dim Password As String = TextBoxpassword.Text.Trim()
        Dim ConfermPassword As String = TextBoxConfermPassword.Text.Trim()
        'Dim DOB As String = TextBoxDOB.Text.Trim()
        Dim Datentime As Date = DateTimePicker1.Value
        Dim DOB As String = Datentime.Date.ToString("yyyy-MM-dd")
        Dim Address As String = TextBoxAddress.Text.Trim()


        Dim PhotoBytes As Byte()
        Dim SignBytes As Byte()

        If Name = "" Then
            MessageBox.Show("Name Can't be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Email = "" Then
            MessageBox.Show("Email Can't be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Phone = "" Then
            MessageBox.Show("Phone Can't be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf IdentificationNumber = "" Then
            MessageBox.Show("IdentificationNumber Can't be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Gender = "" Then
            MessageBox.Show("Gender Can't be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Username = "" Then
            MessageBox.Show("Username Can't be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Password = "" Then
            MessageBox.Show("Password Can't be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Password <> ConfermPassword Then
            MessageBox.Show("Password mismatch Can't be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If PhotoPath IsNot Nothing Then
            PhotoBytes = File.ReadAllBytes(PhotoPath)
        Else
            MessageBox.Show("Please Upload Photo Can't be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If SignPath IsNot Nothing Then
            SignBytes = File.ReadAllBytes(SignPath)
        Else
            MessageBox.Show("Please Upload SIgnature Can't be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If IsValidPhoneNumber(Phone) = False Then
            MessageBox.Show("invalid Phone number ")
            Return
        End If

        If IsValidNumber(IdentificationNumber) = False Then
            MessageBox.Show("invalid Identification Number")
            Return
        End If


        Dim conn As MySqlConnection = New MySqlConnection(connString)

        Try
            ' Open connection
            conn.Open()
            'MessageBox.Show("Connected to MySQL database!")

            Dim query2 As String = "INSERT INTO `BankUserData`(`Bank_Account_Number`, `Email_ID`, `Name`, `Address`, `Phone_Number`, `Username`, `Password`, `DOB`, `Balance`, `CIBIL_Score`, `Profile_Image`, `Signature`, `Identification_Number`, `Gender`, `Approved`) VALUES ('','" & Email & "','" & Name & "','" & Address & "','" & Phone & "','" & Username & "','" & Password & "','" & DOB & "',0.0,0.0,?photo,?sign,'" & IdentificationNumber & "','" & Gender & "',0)"
            Dim cmd As MySqlCommand = New MySqlCommand(query2, conn)
            'Dim reader As MySqlDataReader = cmd.ExecuteReader()
            'reader.Close()

            cmd.Parameters.Add("?photo", MySqlDbType.MediumBlob).Value = PhotoBytes
            cmd.Parameters.Add("?sign", MySqlDbType.MediumBlob).Value = SignBytes
            cmd.ExecuteNonQuery()

            MessageBox.Show("You have sucessfully registered.")
            ChildForm(Banking_Main.Panel1, Banking_Homepage)

        Catch ex As Exception
            MessageBox.Show("Error: {0}", ex.Message)
        Finally
            conn.Close()
            'MessageBox.Show("Connection closed.")
        End Try


    End Sub

    Private Sub TextBoxpassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxpassword.TextChanged
        password_strength_check()
    End Sub

    Private Sub password_strength_check()
        Dim password As String = TextBoxpassword.Text
        Dim password_len As Integer = password.Length

        ' Checking lower alphabet in string 
        Dim hasLower As Boolean = False, hasUpper As Boolean = False
        Dim hasDigit As Boolean = False, specialChar As Boolean = False
        Dim normalChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 "

        For i As Integer = 0 To password_len - 1
            If Char.IsLower(password(i)) Then
                hasLower = True
            End If
            If Char.IsUpper(password(i)) Then
                hasUpper = True
            End If
            If Char.IsDigit(password(i)) Then
                hasDigit = True
            End If

            Dim special As Integer = password.IndexOfAny(normalChars.ToCharArray())
            If special <> -1 Then
                specialChar = True
            End If
        Next

        If hasLower AndAlso hasUpper AndAlso hasDigit AndAlso specialChar AndAlso (password_len >= 8) Then
            Label13.Text = "Strong"
            Label13.ForeColor = Color.Green
            'Console.WriteLine("Strong")
        ElseIf (hasLower OrElse hasUpper) AndAlso specialChar AndAlso (password_len >= 6) Then
            Label13.Text = "Moderate"
            Label13.ForeColor = Color.Blue
            'Console.WriteLine("Moderate")
        Else
            Label13.Text = "Weak"
            Label13.ForeColor = Color.Red
            'Console.WriteLine("Weak")
        End If
    End Sub

    Function IsValidPhoneNumber(phoneNumber As String) As Boolean
        ' Check if the phone number has a length of 10
        If Len(phoneNumber) <> 10 Then
            Return False
            Exit Function
        End If

        ' Check if all characters in the phone number are digits
        Dim i As Integer
        For i = 1 To Len(phoneNumber)
            If Not IsNumeric(Mid(phoneNumber, i, 1)) Then
                Return False
                Exit Function
            End If
        Next i
        ' If all conditions are met, the phone number is valid
        Return True
    End Function
    Function IsValidNumber(phoneNumber As String) As Boolean
        ' Check if all characters in the phone number are digits
        Dim i As Integer
        For i = 1 To Len(phoneNumber)
            If Not IsNumeric(Mid(phoneNumber, i, 1)) Then
                Return False
                Exit Function
            End If
        Next i
        ' If all conditions are met, the phone number is valid
        Return True
    End Function

    Private Sub TextBoxConfermPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxConfermPassword.TextChanged
        If TextBoxConfermPassword.Text = TextBoxpassword.Text Then

            Label14.ForeColor = Color.Green
            Label14.Text = "Password Matched"

        Else
            Label14.ForeColor = Color.Red
            Label14.Text = "Password not Matching"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        TextBoxpassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        ChildForm(Banking_Main.Panel1, Banking_Login)
    End Sub

    Private Sub TextBoxDOB_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBoxSign_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBoxPhoto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxAddress_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxGender_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxIndentificationNumber_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxPhone_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxEmail_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label12_Click_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged
        ' connection to database
        Dim Username As String = TextBoxUsername.Text.Trim()
        Label15.Text = ""

        Dim conn As MySqlConnection = New MySqlConnection(connString)

        Try
            ' Open connection
            conn.Open()
            ' MessageBox.Show("Connected to MySQL database!")

            Dim query = "SELECT * FROM `BankUserData` WHERE username = '" & Username & "'"
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim sqlDt As New DataTable
            sqlDt.Clear()
            sqlDt.Load(reader)
            reader.Close()
            Dim rowCount = sqlDt.Rows.Count

            If rowCount > 0 Then
                Label15.ForeColor = Color.Red
                Label15.Text = "Username Already exist"
            Else
                Label15.ForeColor = Color.Green
                Label15.Text = "Username Available"
            End If

        Catch ex As Exception
            MessageBox.Show("Error: {0}", ex.Message)
        Finally
            conn.Close()
            'MessageBox.Show("Connection closed.")
        End Try
    End Sub

End Class
