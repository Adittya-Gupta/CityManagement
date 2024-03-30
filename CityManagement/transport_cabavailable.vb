Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class transport_cabavailable
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub transport_cabavailable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim query As String = "Select * from running_cabs"
            'Create a list of dictionary to store the data
            Dim data As New List(Of Dictionary(Of String, Object))
            Dim cmd As New MySqlCommand(query, conn)
        Catch ex As Exception

        End Try
        For i As Integer = 0 To 10
            Dim card As New transport_cabCards
            FlowLayoutPanel1.Controls.Add(card)
        Next
    End Sub
End Class