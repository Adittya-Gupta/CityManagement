Imports MySql.Data.MySqlClient

Public Class complaints_law
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Private lawList As New List(Of organization_details)

    Private Sub complaints_law_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#010001")
        Panel1.AutoScroll = False
        Panel1.HorizontalScroll.Enabled = False
        Panel1.HorizontalScroll.Visible = False
        Panel1.AutoScroll = True
        Panel1.Controls.Clear()
        lawList.Clear()
        Try
            conn.Open()
            Dim previousControlBottom As Integer = 0
            Dim query As String = "select * from Institutes where Type = 'Law'"
            Using cmd As New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                While reader.Read()
                    Dim law As New organization_details()
                    lawList.Add(law)
                    law.Dock = DockStyle.None
                    law.Width = Panel1.Width
                    law.Location = New Point(0, previousControlBottom)
                    law.org_name = Convert.ToString(reader("Name"))
                    law.org_ID = Convert.ToInt32(reader("ID"))
                    previousControlBottom = law.Bottom
                    Panel1.Controls.Add(law)

                    ' Wire up the click event for the user control
                    AddHandler law.Click, AddressOf law_Click
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub law_Click(sender As Object, e As EventArgs)
        ' Handle the click event for the user control here
        Dim clickedLaw As organization_details = DirectCast(sender, organization_details)
        ' You can access clicked hospital details here and perform actions accordingly
        Environment.SetEnvironmentVariable("station_id", clickedLaw.org_ID.ToString())
        Environment.SetEnvironmentVariable("station_name", clickedLaw.org_name.ToString())
        ' Dim compl_hospital_query As New complaints_hospital_query()
        '  MainPanel.switchPanel(compl_hospital_query)
        mypanel.Panel1.Controls.Clear()
        Dim form As New complaints_law_query()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class
