Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Org.BouncyCastle.Ocsp
Imports System.IO
Imports System.Windows
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Chart = System.Windows.Forms.DataVisualization.Charting.Chart
Public Class Newsletter_articlespage
    Public Mysqlconn As New MySqlConnection
    'Public sqlCmd As New MySqlCommand
    Public sqlRd As MySqlDataReader
    Public sqlDt As New DataTable
    Public Dta As New MySqlDataAdapter
    Public SqlQuery As String

    'Public server As String = "172.16.114.244"
    'Public username As String = "admin"
    'Public password As String = "nimda"
    'Public database As String = "banking_database"

    'Public server As String = "localhost"
    'Public username As String = "root"
    ' Public password As String = "vacuum#28C"
    ' Public database As String = "newsdatabase"

    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "newsdatabase"

    'loads home page of newsletter
    Private Sub LoadFields()
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_newsletter

        sqlDt.Clear()
        Mysqlconn.Open()   'Open the connection

        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = Mysqlconn
        'select the top 3 latest headlines
        'sqlCmd.CommandText = "SELECT * FROM newsdata ORDER BY Date DESC;"
        sqlCmd.CommandText = "SELECT * FROM newsdata where Published_On != 'None' ORDER BY Date DESC;"


        Dim adapter As New MySqlDataAdapter(sqlCmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        'display the news
        Dim i As Integer = 0
        For Each row As DataRow In table.Rows
            '--------------------load picture-----------------------
            Dim pic As New PictureBox()
            pic.Name = "pic" & row("News_ID").ToString()
            pic.Width = 250
            pic.Height = 100
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            pic.Location = New Point(5, 210 + 105 * i)

            ' Convert byte array to image
            Dim imageData As Byte() = DirectCast(row("Image"), Byte())
            Using ms As New MemoryStream(imageData)
                pic.Image = Image.FromStream(ms)
            End Using

            ' Add the textbox to the panel
            Display_panel.Controls.Add(pic)

            '------------------load content------------------------
            Dim textbox As New RichTextBox()
            textbox.Name = "textbox" & row("News_ID").ToString()
            textbox.Width = Display_panel.Width - 280 '250 for pic and 5,5,5 for gaps between pic and content + buffer 15
            textbox.Location = New Point(260, 210 + 105 * i)
            textbox.ReadOnly = True
            textbox.BackColor = Color.FromArgb(246, 246, 233)

            textbox.Text = "Date: " & row("Date").ToString().Substring(0, 9) & vbTab & vbTab  'write date
            textbox.Text &= "Publisher: " & row("Publisher").ToString() & Environment.NewLine 'write publisher
            textbox.Text &= "Headline: " & row("Headline").ToString() & Environment.NewLine 'write headline
            textbox.Text &= row("Content").ToString() 'write content

            ' Add the textbox to the panel
            Display_panel.Controls.Add(textbox)

            i = i + 1
        Next

        Mysqlconn.Close()
        sqlCmd.Dispose()
    End Sub

    Private Sub LoadTopic(ByVal s As String)
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_newsletter

        sqlDt.Clear()
        Mysqlconn.Open()   'Open the connection

        Dim sqlCmd As New MySqlCommand
        sqlCmd.Connection = Mysqlconn
        'select records of desired type only
        sqlCmd.CommandText = "SELECT * FROM newsdata WHERE Published_On = '" & s & "' ORDER BY Date DESC;"

        Dim adapter As New MySqlDataAdapter(sqlCmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        'display the news
        Dim i As Integer = 0
        For Each row As DataRow In table.Rows
            '--------------------load picture-----------------------
            Dim pic As New PictureBox()
            pic.Name = "pic" & row("News_ID").ToString()
            pic.Width = 250
            pic.Height = 100
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            pic.Location = New Point(5, 5 + 105 * i)

            ' Convert byte array to image
            Dim imageData As Byte() = DirectCast(row("Image"), Byte())
            Using ms As New MemoryStream(imageData)
                pic.Image = Image.FromStream(ms)
            End Using

            ' Add the textbox to the panel
            Display_panel.Controls.Add(pic)

            '------------------load content------------------------
            Dim textbox As New RichTextBox()
            textbox.Name = "textbox" & row("News_ID").ToString()
            textbox.Width = Display_panel.Width - 280 '250 for pic and 5,5,5 for gaps between pic and content + buffer 15
            textbox.Location = New Point(260, 5 + 105 * i)
            textbox.ReadOnly = True
            textbox.BackColor = Color.FromArgb(246, 246, 233)

            textbox.Text = "Date: " & row("Date").ToString().Substring(0, 9) & vbTab & vbTab  'write date
            textbox.Text &= "Publisher: " & row("Publisher").ToString() & Environment.NewLine 'write publisher
            textbox.Text &= "Headline: " & row("Headline").ToString() & Environment.NewLine 'write headline
            textbox.Text &= row("Content").ToString() 'write content

            ' Add the textbox to the panel
            Display_panel.Controls.Add(textbox)

            i = i + 1
        Next

        Mysqlconn.Close()
        sqlCmd.Dispose()
    End Sub

    Private Sub LoadStats()
        '------------------------Chart for transport----------------------------
        Dim chart1 As New Chart With {
            .Width = 250,
            .Height = 200,
            .Location = New Point(5, 5),
            .Visible = True
        }

        'add chart title
        Dim chartTitle As New Title("Number of Requests")
        chart1.Titles.Add(chartTitle)

        ' Add data points to the series
        Dim series1 As New Series("Series1")
        series1.ChartType = SeriesChartType.Column

        series1.Points.AddXY("Cabs", 125)
        series1.Points.AddXY("Buses", 170)
        series1.Points(0).Color = Color.Turquoise  ' Individual point color
        series1.Points(1).Color = Color.Turquoise ' Individual point color

        chart1.Series.Add(series1) ' Add the series to the chart

        'add chart area for display
        Dim area1 = chart1.ChartAreas.Add(chart1.ChartAreas.NextUniqueName())
        series1.ChartArea = area1.Name

        ' Add the chart to the panel
        Display_panel.Controls.Add(chart1)

        '------------------------Chart for Healthcare----------------------------
        Dim chart2 As New Chart()
        chart2.Width = 250
        chart2.Height = 200
        chart2.Location = New Point(260, 5)
        chart2.Visible = True

        'add chart title
        Dim chartTitle2 As New Title("Doctors by Rating")
        chart2.Titles.Add(chartTitle2)

        ' Add data points to the series
        Dim series2 As New Series("Series1")
        series2.ChartType = SeriesChartType.Pie

        series2.Points.AddXY("0-1", 5)
        series2.Points.AddXY("1-2", 10)
        series2.Points.AddXY("2-3", 40)
        series2.Points.AddXY("3-4", 30)
        series2.Points.AddXY("4-5", 15)

        series2.Points(0).Color = Color.FromArgb(139, 0, 0)  'dark red
        series2.Points(1).Color = Color.FromArgb(255, 0, 0)  ' red
        series2.Points(2).Color = Color.FromArgb(255, 204, 0)  ' yellow
        series2.Points(3).Color = Color.FromArgb(154, 205, 50) ' yellow-green
        series2.Points(4).Color = Color.FromArgb(0, 100, 0)  ' dark green

        chart2.Series.Add(series2) ' Add the series to the chart

        'add chart area for display
        Dim area2 = chart2.ChartAreas.Add(chart2.ChartAreas.NextUniqueName())
        series2.ChartArea = area2.Name

        ' Add the chart to the panel
        Display_panel.Controls.Add(chart2)

        '------------------------Chart for Elections----------------------------
        Dim chart3 As New Chart()
        chart3.Width = 300
        chart3.Height = 200
        chart3.Location = New Point(515, 5)
        chart3.Visible = True

        'add chart title
        Dim chartTitle3 As New Title("Voter Turnout by Sector")
        chart3.Titles.Add(chartTitle3)

        ' Add data points to the series
        Dim series3 As New Series("Series1")
        series3.ChartType = SeriesChartType.Column
        series3.Color = Color.Blue

        series3.Points.AddXY("Health", 130)
        series3.Points.AddXY("Education", 100)
        series3.Points.AddXY("Municipal", 220)
        series3.Points.AddXY("Commerce", 170)
        series3.Points.AddXY("Transportation", 90)

        chart3.Series.Add(series3) ' Add the series to the chart

        'add chart area for display
        Dim area3 = chart3.ChartAreas.Add(chart3.ChartAreas.NextUniqueName())
        series3.ChartArea = area3.Name

        ' Add the chart to the panel
        Display_panel.Controls.Add(chart3)

    End Sub

    Private Sub Newsletter_Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStats()
        LoadFields()
        Home_btn.BackColor = Color.DarkKhaki
    End Sub

    Private Sub Festivals_btn_Click(sender As Object, e As EventArgs) Handles Festivals_btn.Click
        Display_panel.Controls.Clear()
        Home_btn.BackColor = Color.FromArgb(246, 246, 233)
        Festivals_btn.BackColor = Color.DarkKhaki
        EduHealth_btn.BackColor = Color.FromArgb(246, 246, 233)
        Transport_btn.BackColor = Color.FromArgb(246, 246, 233)
        Employment_btn.BackColor = Color.FromArgb(246, 246, 233)
        Promotions_btn.BackColor = Color.FromArgb(246, 246, 233)

        LoadTopic("Festivals and Election")
    End Sub

    Private Sub EduHealth_btn_Click(sender As Object, e As EventArgs) Handles EduHealth_btn.Click
        Display_panel.Controls.Clear()
        Home_btn.BackColor = Color.FromArgb(246, 246, 233)
        Festivals_btn.BackColor = Color.FromArgb(246, 246, 233)
        EduHealth_btn.BackColor = Color.DarkKhaki
        Transport_btn.BackColor = Color.FromArgb(246, 246, 233)
        Employment_btn.BackColor = Color.FromArgb(246, 246, 233)
        Promotions_btn.BackColor = Color.FromArgb(246, 246, 233)

        LoadTopic("Education and Health")
    End Sub

    Private Sub Transport_btn_Click(sender As Object, e As EventArgs) Handles Transport_btn.Click
        Display_panel.Controls.Clear()
        Home_btn.BackColor = Color.FromArgb(246, 246, 233)
        Festivals_btn.BackColor = Color.FromArgb(246, 246, 233)
        EduHealth_btn.BackColor = Color.FromArgb(246, 246, 233)
        Transport_btn.BackColor = Color.DarkKhaki
        Employment_btn.BackColor = Color.FromArgb(246, 246, 233)
        Promotions_btn.BackColor = Color.FromArgb(246, 246, 233)

        LoadTopic("Transport and Communication")
    End Sub

    Private Sub Employment_btn_Click(sender As Object, e As EventArgs) Handles Employment_btn.Click
        Display_panel.Controls.Clear()
        Home_btn.BackColor = Color.FromArgb(246, 246, 233)
        Festivals_btn.BackColor = Color.FromArgb(246, 246, 233)
        EduHealth_btn.BackColor = Color.FromArgb(246, 246, 233)
        Transport_btn.BackColor = Color.FromArgb(246, 246, 233)
        Employment_btn.BackColor = Color.DarkKhaki
        Promotions_btn.BackColor = Color.FromArgb(246, 246, 233)

        LoadTopic("Employment and Services")
    End Sub

    Private Sub Promotions_btn_Click(sender As Object, e As EventArgs) Handles Promotions_btn.Click
        Display_panel.Controls.Clear()
        Home_btn.BackColor = Color.FromArgb(246, 246, 233)
        Festivals_btn.BackColor = Color.FromArgb(246, 246, 233)
        EduHealth_btn.BackColor = Color.FromArgb(246, 246, 233)
        Transport_btn.BackColor = Color.FromArgb(246, 246, 233)
        Employment_btn.BackColor = Color.FromArgb(246, 246, 233)
        Promotions_btn.BackColor = Color.DarkKhaki

        LoadTopic("Promotion and Advertisement")
    End Sub

    Private Sub Home_btn_Click(sender As Object, e As EventArgs) Handles Home_btn.Click
        Display_panel.Controls.Clear()
        Home_btn.BackColor = Color.DarkKhaki
        Festivals_btn.BackColor = Color.FromArgb(246, 246, 233)
        EduHealth_btn.BackColor = Color.FromArgb(246, 246, 233)
        Transport_btn.BackColor = Color.FromArgb(246, 246, 233)
        Employment_btn.BackColor = Color.FromArgb(246, 246, 233)
        Promotions_btn.BackColor = Color.FromArgb(246, 246, 233)

        LoadStats()
        LoadFields()
    End Sub

    Private Sub Display_panel_Paint(sender As Object, e As PaintEventArgs) Handles Display_panel.Paint

    End Sub
End Class