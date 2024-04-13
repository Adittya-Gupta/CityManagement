Imports System.Windows.Documents
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cms

Public Class makeAppointment
    Dim connectionString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"

    Shared hos_id As String
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub makeAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
        Dim specialisation As New specialisation()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim Temp2 As Temp2 = CType(Application.OpenForms("Temp2"), Temp2)

        ' Check if the main form instance is not null
        If Temp2 IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            Temp2.ShowChildFormInPanel(specialisation)
        End If
    End Sub

    Private Sub Guna2GradientTileButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton2.Click
        Dim listHospitals As New listHospitals()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim Temp2 As Temp2 = CType(Application.OpenForms("Temp2"), Temp2)

        ' Check if the main form instance is not null
        If Temp2 IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            Temp2.ShowChildFormInPanel(listHospitals)
        End If
    End Sub

    Private Sub Guna2GradientTileButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton3.Click

    End Sub


    Private Sub Guna2GradientTileButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton4.Click
        Dim Health_ViewAppointment As New Health_ViewAppointment()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim Temp2 As Temp2 = CType(Application.OpenForms("Temp2"), Temp2)

        ' Check if the main form instance is not null
        If Temp2 IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            Temp2.ShowChildFormInPanel(Health_ViewAppointment)
        End If
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged

    End Sub

    Private Sub Guna2TextBox2_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
    Shared Sub makeappointment(id As String)
        hos_id = id
        MessageBox.Show(id)
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Query the Hospital table to fetch all rows
        Dim queryString As String = "SELECT D.doctor_id, D.user_id, D.experience, D.rating, D.visiting_time_start, D.visiting_time_end, U.Name, U.Gender " &
                                    "FROM Doctors D " &
                                    "INNER JOIN User U ON D.user_id = U.SID " &
                                    "WHERE D.hos_id ='" & hos_id & "';"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            connection.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            Dim yPos As Integer = 0 ' Initial Y position for the first row
            Dim componentCount As Integer = 0 ' Counter for components in the current row

            Try
                While reader.Read()
                    ' Create an instance of cMakeAppointment with data from the database
                    Dim Name As String = reader("Name").ToString()
                    Dim experience As String = reader("experience").ToString()
                    Dim gender As String = reader("Gender").ToString()
                    Dim stime As String = reader("visiting_time_start").ToString()
                    Dim etime As String = reader("visiting_time_end").ToString()

                    ' Create and position the cMakeAppointment component
                    Dim cmake As New cMakeAppointment(Name, experience, gender, stime + " to " + etime)
                    cmake.Location = New Point(componentCount * (cmake.Width + 10), yPos)
                    Panel1.Controls.Add(cmake)

                    ' Increment component count for the current row
                    componentCount += 1

                    ' If 4 components are reached, start a new row
                    If componentCount >= 4 Then
                        yPos += cmake.Height + 10 ' Adjust Y position for the next row
                        componentCount = 0 ' Reset component count for the new row
                    End If
                End While
            Finally
                reader.Close()
            End Try
        End Using

        'Dim Doctor1 As New cMakeAppointment("Dr. John Doe", "10 Years", "Male", "9 am to 12 am", 4.5)
        'Dim Doctor2 As New cMakeAppointment("Dr. Jane Smith", "4 Years", "Male", "3 pm to 5 pm", 3.8)
        'Dim Doctor3 As New cMakeAppointment("Dr. Bob Johnson", "6 Years", "Male", "9 am to 11 am ", 2.7)
        'Dim Doctor4 As New cMakeAppointment("Dr. Hello", "8 Years", "Male", "2 pm to 5 pm ", 4.7)

        'Dim Doctor5 As New cMakeAppointment("Dr. John Doe", "10 Years", "Male", "9 am to 12 am", 4.5)
        'Dim Doctor6 As New cMakeAppointment("Dr. Jane Smith", "4 Years", "Male", "3 pm to 5 pm", 3.8)
        'Dim Doctor7 As New cMakeAppointment("Dr. Bob Johnson", "6 Years", "Male", "9 am to 11 am ", 2.7)
        'Dim Doctor8 As New cMakeAppointment("Dr. Hello", "8 Years", "Male", "2 pm to 5 pm ", 4.7)


        'Panel1.Controls.Add(Doctor1)
        'Panel1.Controls.Add(Doctor2)
        'Panel1.Controls.Add(Doctor3)
        'Panel1.Controls.Add(Doctor4)

        'Panel1.Controls.Add(Doctor5)
        'Panel1.Controls.Add(Doctor6)
        'Panel1.Controls.Add(Doctor7)
        'Panel1.Controls.Add(Doctor8)

        'If Panel1.Controls.Count > 1 Then
        '    Dim prevMessageLabel As Control = Panel1.Controls(Panel1.Controls.Count - 2)
        '    Doctor1.Left = 60
        '    Doctor2.Left = Doctor1.Width + 60 + 20
        '    Doctor3.Left = 60 + Doctor1.Width + 20 + Doctor2.Width + 20
        '    Doctor4.Left = 60 + Doctor1.Width + 20 + Doctor2.Width + 20 + Doctor3.Width + 20

        '    Doctor5.Left = 60
        '    Doctor6.Left = Doctor5.Width + 60 + 20
        '    Doctor7.Left = 60 + Doctor5.Width + 20 + Doctor6.Width + 20
        '    Doctor8.Left = 60 + Doctor5.Width + 20 + Doctor6.Width + 20 + Doctor7.Width + 20

        '    Doctor3.Top =
        '    Doctor2.Top = 0
        '    Doctor4.Top = 0

        '    Doctor5.Top = Doctor1.Height + 20
        '    Doctor6.Top = Doctor1.Height + 20
        '    Doctor7.Top = Doctor1.Height + 20
        '    Doctor8.Top = Doctor1.Height + 20


        'End If
    End Sub
End Class