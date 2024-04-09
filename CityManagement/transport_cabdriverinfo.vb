Imports Mysqlx
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class transport_cabdriverinfo
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Dim conn2 As New MySqlConnection(connString)
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub transport_cabdriverinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.ControlBox = False
        Me.Text = ""
        Dim x As String = transport_cabdriverlogin.name
        TextBox3.Text = x
        TextBox4.Text = transport_cabdriverlogin.email
        Dim query As String = "SELECT depart_time FROM running_cabs WHERE cab_id = @CabId"
        Dim departTime As DateTime
        ' Create connection and command
        conn.Open()
        Using command As New MySqlCommand(query, conn)
            ' Add parameter for cabId
            command.Parameters.AddWithValue("@CabId", transport_cabdriverlogin.cabId)

            ' Open connection


            ' Execute scalar command to directly get the result
            Dim departTimeObj As Object = command.ExecuteScalar()

            ' Check if result is not null
            If departTimeObj IsNot Nothing Then
                departTime = Convert.ToDateTime(departTimeObj)
                ' Console.WriteLine("Depart Time: " & departTime.ToString())

            End If
        End Using

        Dim card As New previousRideCard()
        card.Label11.Text = departTime
        card.Label13.Text = transport_cabdriverlogin.fromLocation
        card.Label15.Text = transport_cabdriverlogin.toLocation

        FlowLayoutPanel1.Controls.Add(card)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form2 As New transport_cabbooking()
        Me.Hide()
        form2.ShowDialog()
        Me.Show()
    End Sub
End Class