Imports MySql.Data.MySqlClient

Public Class complaints_Hospital
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Private hospitalsList As New List(Of organization_details)

    Private Sub complaints_Hospital_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#010001")
        Panel1.AutoScroll = False
        Panel1.HorizontalScroll.Enabled = False
        Panel1.HorizontalScroll.Visible = False
        Panel1.AutoScroll = True
        Panel1.Controls.Clear()
        hospitalsList.Clear()
        Try
            conn.Open()
            Dim previousControlBottom As Integer = 0
            Dim query As String = "select * from Institutes where Type = 'Hospital'"
            Using cmd As New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                While reader.Read()
                    Dim hospital As New organization_details()
                    hospitalsList.Add(hospital)
                    hospital.Dock = DockStyle.None
                    hospital.Width = Panel1.Width
                    hospital.Location = New Point(0, previousControlBottom)
                    hospital.org_name = Convert.ToString(reader("Name"))
                    hospital.org_ID = Convert.ToInt32(reader("ID"))
                    previousControlBottom = hospital.Bottom
                    Panel1.Controls.Add(hospital)

                    ' Wire up the click event for the user control
                    AddHandler hospital.Click, AddressOf hospital_Click
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub hospital_Click(sender As Object, e As EventArgs)
        ' Handle the click event for the user control here
        Dim clickedHospital As organization_details = DirectCast(sender, organization_details)
        ' You can access clicked hospital details here and perform actions accordingly
        Environment.SetEnvironmentVariable("hospital_id", clickedHospital.org_ID.ToString())
        Environment.SetEnvironmentVariable("hospital_name", clickedHospital.org_name.ToString())
        ' Dim compl_hospital_query As New complaints_hospital_query()
        '  MainPanel.switchPanel(compl_hospital_query)
        mypanel.Panel1.Controls.Clear()
        Dim form As New complaints_hospital_query()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class
