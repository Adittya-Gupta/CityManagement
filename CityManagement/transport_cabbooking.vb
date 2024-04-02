Public Class transport_cabbooking
    Public Shared FromLocation As String
    Public Shared ToLocation As String
    Public Shared sqlFormattedDateTime As String

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FromLocation = ComboBox1.SelectedItem.ToString()
        ToLocation = ComboBox1.SelectedItem.ToString()
        'departTime = DateTimePicker1.Value.TimeOfDay

        Dim selectedDateTime As DateTime = DateTimePicker1.Value

        ' Format the DateTime object as a string in the required format for SQL
        sqlFormattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss")

        ' Now you can use sqlFormattedDateTime in your SQL query
        'MessageBox.Show("Selected date and time in SQL format: " & sqlFormattedDateTime)
        Dim form2 As New transport_cabavailable()

        ' Show Form2
        Me.Hide()
        form2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub transport_cabbooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New transport_cabdriverlogin()

        ' Show Form2
        Me.Hide()
        form2.ShowDialog()
        Me.Show()
    End Sub
End Class