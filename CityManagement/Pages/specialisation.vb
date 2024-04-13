Imports Windows.Media.Capture

Public Class specialisation
    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
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
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub


    Private Sub Panel1_Paint(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim specialist1 As New cspecialisation("Dr. John Doe", "abc Hospital", "Male", "10 Years", "Near IIG", "+91- 8749384923", 4.5)
        Dim specialist2 As New cspecialisation("Dr. Jane Smith", "abc Hospital", "Male", "4 Years", "Near IIG", "+91- 8749384923", 3.8)
        Dim specialist3 As New cspecialisation("Dr. Bob Johnson", "abc Hospital", "Male", "6 Years", "Near IIG ", "+91- 8749384923", 2.7)
        Dim specialist4 As New cspecialisation("Dr. Hello", "abc Hospital", "Male", "5 Years", "Near IIG", "+91- 8749384923", 4.7)



        Panel1.Controls.Add(specialist1)
        Panel1.Controls.Add(specialist2)
        Panel1.Controls.Add(specialist3)
        Panel1.Controls.Add(specialist4)

        If Panel1.Controls.Count > 1 Then
            Dim prevMessageLabel As Control = Panel1.Controls(Panel1.Controls.Count - 2)
            specialist1.Left = 20
            specialist2.Left = 20
            specialist3.Left = 20
            specialist4.Left = 20


            specialist1.Top = 0
            specialist2.Top = specialist1.Height + 20
            specialist3.Top = specialist1.Height + 20 + specialist2.Height + 20
            specialist4.Top = specialist1.Height + 20 + specialist2.Height + 20 + specialist3.Height + 20


        End If
    End Sub
End Class