Imports MySql.Data.MySqlClient

Public Class complaints_Transport
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Private transportsList As New List(Of organization_details)
    Private Sub transport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#010001")
        Panel1.AutoScroll = False
        Panel1.HorizontalScroll.Enabled = False
        Panel1.HorizontalScroll.Visible = False
        Panel1.AutoScroll = True
        Panel1.Controls.Clear()
        transportsList.Clear()
        Try
            conn.Open()
            Dim previousControlBottom As Integer = 0
            Dim query As String = "select * from Institutes where Type = 'Transport'"
            Using cmd As New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader
                While reader.Read()
                    Dim transport As New organization_details()
                    transportsList.Add(transport)
                    transport.Dock = DockStyle.None
                    transport.Width = Panel1.Width
                    transport.Location = New Point(0, previousControlBottom)
                    transport.org_name = Convert.ToString(reader("Name"))
                    transport.org_ID = Convert.ToInt32(reader("ID"))
                    previousControlBottom = transport.Bottom
                    Panel1.Controls.Add(transport)

                    ' Wire up the click event for the user control
                    AddHandler transport.Click, AddressOf transport_Click
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub transport_Click(sender As Object, e As EventArgs)
        ' Handle the click event for the user control here
        Dim clickedtransport As organization_details = DirectCast(sender, organization_details)
        ' You can access clicked transport details here and perform actions accordingly
        Environment.SetEnvironmentVariable("transport_id", clickedtransport.org_ID.ToString())
        Environment.SetEnvironmentVariable("transport_name", clickedtransport.org_name.ToString())
        '  MainPanel.switchPanel(complaints_transport_query)

        mypanel.Panel1.Controls.Clear()
        Dim form As New complaints_transport_query()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub
End Class