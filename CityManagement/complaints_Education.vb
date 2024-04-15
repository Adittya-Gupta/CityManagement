Imports MySql.Data.MySqlClient

Public Class complaints_Education
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Private institutesList As New List(Of organization_details)

    Private Sub education_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#010001")
        Panel1.AutoScroll = False
        Panel1.HorizontalScroll.Enabled = False
        Panel1.HorizontalScroll.Visible = False
        Panel1.AutoScroll = True
        Panel1.Controls.Clear()
        institutesList.Clear()
        Try
            conn.Open()
            Dim previousControlBottom As Integer = 0
            Dim query As String = "select * from Institutes where Type = 'Education'"
            Using cmd As New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                While reader.Read()
                    Dim institute As New organization_details()
                    institutesList.Add(institute)
                    institute.Dock = DockStyle.None
                    institute.Width = Panel1.Width
                    institute.Location = New Point(0, previousControlBottom)
                    institute.org_name = Convert.ToString(reader("Name"))
                    institute.org_ID = Convert.ToInt32(reader("ID"))
                    previousControlBottom = institute.Bottom
                    Panel1.Controls.Add(institute)

                    ' Wire up the click event for the user control
                    AddHandler institute.Click, AddressOf institute_Click
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub institute_Click(sender As Object, e As EventArgs)
        ' Handle the click event for the user control here
        Dim clickedinstitute As organization_details = DirectCast(sender, organization_details)
        ' You can access clicked hospital details here and perform actions accordingly
        Environment.SetEnvironmentVariable("institute_id", clickedinstitute.org_ID.ToString())
        Environment.SetEnvironmentVariable("institute_name", clickedinstitute.org_name.ToString())
        Dim complaints_education_issue As Form = Nothing
        '  MainPanel.switchPanel(complaints_education_issue)
        mypanel.Panel1.Controls.Clear()
        Dim form As New complaints_education_query()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub


End Class