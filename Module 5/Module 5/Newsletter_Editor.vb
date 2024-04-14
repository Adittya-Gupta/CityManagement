Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle

Public Class Newsletter_Editor

    Public Mysqlconn As New MySqlConnection
    Public sqlRd As MySqlDataReader
    Public sqlDt As New DataTable
    Public Dta As New MySqlDataAdapter
    Public SqlQuery As String

    ' Just change these to access local or online db

    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "newsdatabase"


    'Public server As String = "172.16.114.244"
    'Public username As String = "admin"
    'Public password As String = "nimda"
    'Public database As String = "banking_database"

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Private Function ErrorHandling() As Boolean
        If PictureBox15.Image Is Nothing Then
            MessageBox.Show("Upload an image!")
            Return True
        End If

        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Type cannot be empty!")
            Return True
        End If

        If ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Published on which page cannot be empty!")
            Return True
        End If

        If TextBox1.Text = "" Then
            MessageBox.Show("Headline cannot be empty!")
            Return True
        End If

        If TextBox2.Text = "" Then
            MessageBox.Show("Published By cannot be empty!")
            Return True
        End If

        If TextBox5.Text = "" Then
            MessageBox.Show("Content cannot be empty!")
            Return True
        End If
        Return False
    End Function
    Private Sub ClearFields()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""

        ComboBox1.Items.Add("Festivals and Election")
        ComboBox1.Items.Add("Education and Health")
        ComboBox1.Items.Add("Transport and Communication")
        ComboBox1.Items.Add("Employment and Services")
        ComboBox1.Items.Add("Promotion and Advertisement")

        ComboBox2.Items.Add("Festivals and Election")
        ComboBox2.Items.Add("Education and Health")
        ComboBox2.Items.Add("Transport and Communication")
        ComboBox2.Items.Add("Employment and Services")
        ComboBox2.Items.Add("Promotion and Advertisement")
        ComboBox2.Items.Add("Main")
        ComboBox2.Items.Add("None")

        ComboBox3.Items.Add("Festivals and Election")
        ComboBox3.Items.Add("Education and Health")
        ComboBox3.Items.Add("Transport and Communication")
        ComboBox3.Items.Add("Employment and Services")
        ComboBox3.Items.Add("Promotion and Advertisement")

        PictureBox15.Image = Nothing
    End Sub
    Private Sub ClearDataGrid()
        For Each row As DataGridViewRow In DataGridView1.Rows
            DataGridView1.Rows.Remove(row)
        Next
    End Sub

    Private Sub RefreshDataGrid()
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
        ' Set the connection string property
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_newsletter

        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand
        sqlDt.Clear()

        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "SELECT * FROM newsdatabase.NewsData;"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()

        ' Close the connection after use
        Mysqlconn.Close()
        sqlCmd.Dispose()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.DataSource = sqlDt
    End Sub
    Private Sub InsertData()
        Dim pic As New MemoryStream
        PictureBox15.Image.Save(pic, PictureBox15.Image.RawFormat)

        Dim headline As String = TextBox1.Text
        Dim published_by As String = TextBox2.Text
        Dim type As String = ComboBox1.SelectedItem.ToString()
        Dim content As String = TextBox5.Text

        Dim published_on As String = ComboBox2.SelectedItem.ToString()

        If published_on <> "None" Then
            MessageBox.Show("Please select None for published on initially!")
            Return
        End If


        ' Set the connection string property
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_newsletter

        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        sqlDt.Clear()
        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand

        sqlCmd.Connection = Mysqlconn
        Dim query As String = "INSERT INTO newsdatabase.NewsData(Published_On,Headline,Publisher,Type,Date,Content,Image)" &
                             "VALUES ('None','" & headline & "','" & published_by & "','" & type & "',CURDATE(),'" & content & "',@img);"

        sqlCmd.Parameters.Add("@img", MySqlDbType.Blob).Value = pic.ToArray()

        sqlCmd.CommandText = query

        If sqlCmd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Added new News!")
        Else
            MessageBox.Show("Some Error has occured!")
        End If
        ' Close the connection after use
        Mysqlconn.Close()
        sqlCmd.Dispose()
        RefreshDataGrid()
    End Sub
    Private Sub UpdateData()
        Dim ID As String
        Dim headline As String
        Dim day As String
        Dim published_by As String
        Dim type As String
        Dim published_on As String
        Dim content As String

        'ID = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        ID = TextBox3.Text
        headline = TextBox1.Text
        published_by = TextBox2.Text
        day = TextBox4.Text
        content = TextBox5.Text
        type = ComboBox1.SelectedItem.ToString()
        published_on = ComboBox2.SelectedItem.ToString()

        'Dim newsID As Integer = Integer.Parse(ID)
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_newsletter

        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        sqlDt.Clear()
        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand

        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "UPDATE newsdatabase.NewsData SET Published_On = @PublishedOn, Headline = @Headline, Publisher = @Publisher, " &
                            "Type = @Type, Content = @Content, Image = @Image where News_ID = @ID;"

        sqlCmd.Parameters.Add("@PublishedOn", MySqlDbType.VarChar).Value = published_on
        sqlCmd.Parameters.Add("@Headline", MySqlDbType.VarChar).Value = headline
        sqlCmd.Parameters.Add("@Publisher", MySqlDbType.VarChar).Value = published_by
        sqlCmd.Parameters.Add("@Type", MySqlDbType.VarChar).Value = type
        'sqlCmd.Parameters.Add("@Date", MySqlDbType.Date).Value = day
        sqlCmd.Parameters.Add("@Content", MySqlDbType.VarChar).Value = content


        Dim pic As New MemoryStream
        PictureBox15.Image.Save(pic, PictureBox15.Image.RawFormat)

        sqlCmd.Parameters.Add("@Image", MySqlDbType.Blob).Value = pic.ToArray()

        sqlCmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = ID

        If sqlCmd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Updated Record!")
        Else
            MessageBox.Show("Some Error has occured!")
        End If

        Mysqlconn.Close()
        sqlCmd.Dispose()
        RefreshDataGrid()
    End Sub
    Private Sub DeleteData()
        'Dim ID As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        Dim ID As String = TextBox3.Text
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_newsletter

        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand

        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "DELETE FROM newsdatabase.NewsData WHERE News_ID = @ID;"

        sqlCmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = ID

        If sqlCmd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Entry Deleted!")

        Else
            MessageBox.Show("Some Error has occured!")
        End If

        Mysqlconn.Close()
        sqlCmd.Dispose()
        RefreshDataGrid()
    End Sub

    Private Function SendToPublish() As Boolean
        Dim ID As String
        Dim headline As String
        Dim day As String
        Dim published_by As String
        Dim type As String
        Dim published_on As String
        Dim content As String

        'ID = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        ID = TextBox3.Text
        headline = TextBox1.Text
        published_by = TextBox2.Text
        day = TextBox4.Text
        content = TextBox5.Text
        type = ComboBox1.SelectedItem.ToString()
        published_on = ComboBox2.SelectedItem.ToString()

        Dim newsID As Integer = Integer.Parse(ID)

        If published_on = "None" Then
            MessageBox.Show("Please specify a page to publish on!")
            RefreshDataGrid()
            Return False
            'Return
        End If

        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_newsletter


        ' Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        sqlDt.Clear()
        ' Open the connection
        Mysqlconn.Open()
        Dim query As String = "SELECT COUNT(*) AS EntryCount FROM newsdatabase.NewsData WHERE Published_On = @PublishedOn;"

        ' Create a MySqlCommand object
        Dim sqlCmd As New MySqlCommand(query, Mysqlconn)

        ' Add parameter for the type you want to count entries for
        sqlCmd.Parameters.Add("@PublishedOn", MySqlDbType.VarChar).Value = published_on

        ' Execute the query and get the result
        Dim entryCount As Integer = Convert.ToInt32(sqlCmd.ExecuteScalar())
        'MessageBox.Show(entryCount)
        ' Display or use the entry count as needed
        If entryCount > 2 Then
            MessageBox.Show("Too many entries for this page, either delete some entries or choose some other page")
            Mysqlconn.Close()
            sqlCmd.Dispose()
            RefreshDataGrid()
            Return False
        End If
        Mysqlconn.Close()
        sqlCmd.Dispose()
        RefreshDataGrid()
        MessageBox.Show("Published!")
        Return True
    End Function

    Private Sub Newsletter_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(246, 246, 233)

        ClearFields()
        RefreshDataGrid()


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image (*.JPG;*.PNG,*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox15.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.ColumnIndex >= 0 Then
            'If Not, exit the event handler without performing any action
            'MessageBox.Show("Error")
            Return
        End If

        Dim ID As String
        Dim headline As String
        Dim day As String
        Dim published_by As String
        Dim type As String
        Dim published_on As String
        Dim content As String

        ID = DataGridView1.SelectedRows(0).Cells(0).Value.ToString

        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_newsletter

        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        sqlDt.Clear()
        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand

        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "Select * from newsdatabase.NewsData where News_ID = @ID;"

        sqlCmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = ID


        Dim adapter As New MySqlDataAdapter(sqlCmd)
        Dim table As New DataTable()


        adapter.Fill(table)

        If table.Rows.Count = 1 Then
            published_on = table.Rows(0)(1).ToString()
            headline = table.Rows(0)(2).ToString()
            published_by = table.Rows(0)(3).ToString()
            type = table.Rows(0)(4).ToString()
            day = table.Rows(0)(5).ToString()
            content = table.Rows(0)(6).ToString()


            Dim img As Byte()
            img = CType(table.Rows(0)(7), Byte())

            Dim ms As New MemoryStream(img)
            PictureBox15.Image = Image.FromStream(ms)

            TextBox1.Text = headline
            TextBox2.Text = published_by
            TextBox3.Text = ID
            TextBox4.Text = day
            TextBox5.Text = content
            ComboBox1.Text = type
            ComboBox2.Text = published_on
        Else
            MessageBox.Show("Error has occured")
        End If
        Mysqlconn.Close()
        sqlCmd.Dispose()
        RefreshDataGrid()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'Go back
        ChildForm(Newsletter_Main.Panel1, Newsletter_Homepage)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If (ErrorHandling()) Then
            Return
        End If

        If (SendToPublish()) Then
            UpdateData()
        Else
            MessageBox.Show("Failed to publish!")

        End If




    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (ErrorHandling()) Then
            Return
        End If
        UpdateData()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (ErrorHandling()) Then
            Return
        End If
        InsertData()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        DeleteData()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        RefreshDataGrid()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        Dim type As String = ComboBox3.SelectedItem.ToString()

        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
        ' Set the connection string property
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_newsletter

        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand
        sqlDt.Clear()

        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "SELECT * FROM newsdatabase.NewsData where Type = '" & type & "';"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()

        ' Close the connection after use
        Mysqlconn.Close()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.DataSource = sqlDt

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim published_by As String = TextBox7.Text

        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
        ' Set the connection string property
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_newsletter

        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand
        sqlDt.Clear()

        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "SELECT * FROM newsdatabase.NewsData where Publisher = '" & published_by & "';"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()

        ' Close the connection after use
        Mysqlconn.Close()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.DataSource = sqlDt
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class