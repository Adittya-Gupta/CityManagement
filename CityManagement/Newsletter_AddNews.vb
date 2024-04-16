Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class Newsletter_AddNews

    Public Mysqlconn As New MySqlConnection
    Public sqlCmd As New MySqlCommand
    Public sqlRd As MySqlDataReader
    Public sqlDt As New DataTable
    Public Dta As New MySqlDataAdapter
    Public SqlQuery As String

    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "bankingdatabase"


    'Public server As String = "172.16.114.244"
    'Public username As String = "admin"
    'Public password As String = "nimda"
    'Public database As String = "banking_database"

    Public payment_done As Int16 = 0

    Public Shared Sub ChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show()
    End Sub

    Public Shared Sub ChildForm2(ByVal childform As Form)
        mypanel.Panel1.Controls.Clear()
        childform.TopLevel = False
        mypanel.Panel1.Controls.Add(childform)
        childform.Show()
    End Sub

    'Make this form full screen
    Private Sub Newsletter_AddNews_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.WindowState = FormWindowState.Maximized
        'Panel1.BackColor = Color.FromArgb(246, 246, 233)

        ComboBox1.Items.Add("Festivals and Election")
        ComboBox1.Items.Add("Education and Health")
        ComboBox1.Items.Add("Transport and Communication")
        ComboBox1.Items.Add("Employment and Services")
        ComboBox1.Items.Add("Promotion and Advertisement")






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

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim opf As New OpenFileDialog()

        opf.Filter = "Choose Image (*.JPG;*.PNG,*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then
            PictureBox15.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'If payment_done = 0 Then
        '    MessageBox.Show("Please Make payment!")
        '    Return
        'End If

        If Global_Attributes.banking_payment_done = 0 Then
            MessageBox.Show("Please Make payment!")
            Return
        End If

        If PictureBox15.Image Is Nothing Then
            MessageBox.Show("Upload an image!")
            Return
        End If

        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Type cannot be empty!")
            Return
        End If

        Dim pic As New MemoryStream
        PictureBox15.Image.Save(pic, PictureBox15.Image.RawFormat)

        Dim headline As String = TextBox1.Text
        Dim published_by As String = TextBox2.Text
        Dim type As String = ComboBox1.SelectedItem.ToString()
        Dim content As String = TextBox5.Text

        If headline = "" Then
            MessageBox.Show("Headline cannot be empty!")
            Return
        End If
        If published_by = "" Then
            MessageBox.Show("Published by cannot be empty!")
            Return
        End If
        If type = "" Then
            MessageBox.Show("Type cannot be empty!")
            Return
        End If
        If content = "" Then
            MessageBox.Show("Content cannot be empty!")
            Return
        End If



        ' Set the connection string property
        'Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        Mysqlconn.ConnectionString = Global_Attributes.slqConnection_newsletter

        sqlDt.Clear()
        ' Open the connection
        Mysqlconn.Open()

        sqlCmd.Connection = Mysqlconn
        Dim query As String = "INSERT INTO NewsData(Published_On,Headline,Publisher,Type,Date,Content,Image)" &
                             "VALUES ('None','" & headline & "','" & published_by & "','" & type & "',CURDATE(),'" & content & "',@img);"

        sqlCmd.Parameters.Add("@img", MySqlDbType.Blob).Value = pic.ToArray()

        sqlCmd.CommandText = query

        If sqlCmd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Sent to Publish!")
        Else
            MessageBox.Show("Some Error has occured!")
        End If
        ' Close the connection after use
        Global_Attributes.banking_payment_done = 0
        Mysqlconn.Close()
        ChildForm(Newsletter_Main.Panel1, Newsletter_Homepage)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        banking_recv_username = "news"
        banking_recv_name = "news"

        Go_Back = 1
        Go_Back_Form = Me
        banking_payment_amount = 100

        Banking_Main.Panel1.Controls.Clear()
        Newsletter_Main.Panel1.Controls.Clear()

        ChildForm(Banking_Main.Panel1, Banking_Homepage)
        mypanel.Panel1.Controls.Clear()
        ChildForm2(Banking_Main)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class