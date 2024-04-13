Public Class listHospitals

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

    Private Sub Guna2GradientTileButton2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2GradientTileButton3_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Guna2GradientTileButton4_Click(sender As Object, e As EventArgs)
        Dim Health_ViewAppointment As New Health_ViewAppointment()

        ' Get the instance of MainForm (assuming MainForm is the parent form)
        Dim Temp2 As Temp2 = CType(Application.OpenForms("Temp2"), Temp2)

        ' Check if the main form instance is not null
        If Temp2 IsNot Nothing Then
            ' Call the public method of the main form to show the child form in the panel
            Temp2.ShowChildFormInPanel(Health_ViewAppointment)
        End If
    End Sub



    Private Sub listHospitals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Calculate the position and size of the previous form (specialisation)
        Dim prevForm As Form = Application.OpenForms("specialisation")
        If prevForm IsNot Nothing Then
            Dim prevFormBounds As Rectangle = prevForm.Bounds
            Dim overlap As Integer = 0 ' Adjust this value if you want some overlap

            ' Set the position and size of this form to overlap with the previous form
            Me.Bounds = New Rectangle(prevFormBounds.X, prevFormBounds.Y - Me.Height + overlap, prevFormBounds.Width, Me.Height)
        End If
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Hos1 As New cListHospitals("RamKrishna", "near Lohit Hostle", "+91 2929--0987772")
        Dim Hos2 As New cListHospitals("ArjunKrishna", "near Disang Hostle", "+91 292987772")
        Dim Hos3 As New cListHospitals("AgYa", "near Brahma Hostle", "+91 29299787772")



        Panel1.Controls.Add(Hos1)
        Panel1.Controls.Add(Hos2)
        Panel1.Controls.Add(Hos3)


        If Panel1.Controls.Count > 1 Then
            Dim prevMessageLabel As Control = Panel1.Controls(Panel1.Controls.Count - 2)


            Hos1.Top = 0
            Hos1.Left = 20
            Hos2.Left = 20
            Hos3.Left = 20
            Hos2.Top = Hos1.Height + 20
            Hos3.Top = Hos1.Height + 20 + Hos2.Height + 20

        End If
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub
End Class