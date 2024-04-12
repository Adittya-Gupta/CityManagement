Imports System.IO
Imports MySql.Data.MySqlClient

Public Class admin_home
    Private OriginalSize As Size = Me.Size
    Private Sub complaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Close the current form


        ' Create an instance of admin_Mayor form
        'Dim adminMayorForm As New admin_Mayor()
        ' mypanel.Panel1.Controls.Clear()
        ' Dim form As New admin_Mayor
        ' Form.TopLevel = False
        ' mypanel.Panel1.Controls.Add(form)
        ' Form.Show()

        mypanel.Panel1.Controls.Clear()
        Dim form As New election_dashboard()

        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()


    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        Label1.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        Label1.Cursor = Cursors.Default
    End Sub

    Private Sub admin_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize PictureBox controls with null value
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox5.Image = Nothing
        PictureBox6.Image = Nothing

        ' Set font size for labels
        Label2.Font = New Font(Label2.Font.FontFamily, 9)
        Label3.Font = New Font(Label3.Font.FontFamily, 9)
        Label4.Font = New Font(Label4.Font.FontFamily, 9)
        Label5.Font = New Font(Label5.Font.FontFamily, 9)
        Label6.Font = New Font(Label6.Font.FontFamily, 9)
        Label7.Font = New Font(Label7.Font.FontFamily, 9)

        ' Load profile pictures from the database
        LoadProfilePictures()
    End Sub

    Private Sub LoadProfilePictures()
        Try
            ' Open the connection
            conn.Open()

            ' Define the SQL query to retrieve names, designations, and profile pictures from the User table
            Dim query As String = "SELECT Name, Designation, ProfilePic FROM User WHERE Designation IN ('Mayor', 'Education Minister', 'Health Minister', 'Finance Minister', 'Transport Minister', 'Home Minister')"

            ' Create MySqlCommand object
            Using cmd As New MySqlCommand(query, conn)
                ' Execute the command and create a data reader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Loop through the results
                    While reader.Read()
                        Dim nameValue As String = reader("Name").ToString()
                        Dim designationValue As String = reader("Designation").ToString()
                        Dim profilePicValue As Byte() = If(reader("ProfilePic") Is DBNull.Value, Nothing, DirectCast(reader("ProfilePic"), Byte()))


                        ' Display the profile picture in the corresponding PictureBox control based on designation
                        Select Case designationValue
                            Case "Mayor"
                                DisplayImage(profilePicValue, PictureBox1)
                                Label2.Text = $"{nameValue}{Environment.NewLine}{designationValue}"
                            Case "Education Minister"
                                DisplayImage(profilePicValue, PictureBox2)
                                Label3.Text = $"{nameValue}{Environment.NewLine}{designationValue}"
                            Case "Health Minister"
                                DisplayImage(profilePicValue, PictureBox3)
                                Label4.Text = $"{nameValue}{Environment.NewLine}{designationValue}"
                            Case "Transport Minister"
                                DisplayImage(profilePicValue, PictureBox4)
                                Label5.Text = $"{nameValue}{Environment.NewLine}{designationValue}"
                            Case "Finance Minister"
                                DisplayImage(profilePicValue, PictureBox5)
                                Label6.Text = $"{nameValue}{Environment.NewLine}{designationValue}"
                            Case "Home Minister"
                                DisplayImage(profilePicValue, PictureBox6)
                                Label7.Text = $"{nameValue}{Environment.NewLine}{designationValue}"
                        End Select
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading profile pictures: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub

    Private Sub DisplayImage(ByVal imageData As Byte(), ByVal pictureBox As PictureBox)
        Try
            ' Check if the image data is not null
            If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                ' Convert byte array to image
                Using ms As New MemoryStream(imageData)
                    Dim image As Image = Image.FromStream(ms)
                    ' Display the image in the PictureBox control
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                    pictureBox.Image = image
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error displaying image: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub
End Class
