﻿Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Banking_Passbook

    Public Mysqlconn As New MySqlConnection
    'Public sqlCmd As New MySqlCommand
    Public sqlRd As MySqlDataReader
    Public sqlDt As New DataTable
    Public Dta As New MySqlDataAdapter
    Public SqlQuery As String

    Public server As String = "localhost"
    Public username As String = "root"
    Public password As String = "Aasneh18"
    Public database As String = "bankingdatabase"

    Public bank_account_no As Integer = 1
    Private Sub LoadFields()
        Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"
        sqlDt.Clear()
        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand

        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "Select * from bankingdatabase.UserData where Bank_Account_Number = @BAC;"

        sqlCmd.Parameters.Add("@BAC", MySqlDbType.Int64).Value = bank_account_no


        Dim adapter As New MySqlDataAdapter(sqlCmd)
        Dim table As New DataTable()


        adapter.Fill(table)

        If table.Rows.Count = 1 Then
            Label7.Text = table.Rows(0)(8).ToString()
            Label8.Text = table.Rows(0)(9).ToString()
        Else
            MessageBox.Show("Error has occured")
        End If
        Mysqlconn.Close()
        sqlCmd.Dispose()
    End Sub
    Private Sub RefreshDataGrid()
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
        ' Set the connection string property
        Mysqlconn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database & ";"

        ' Open the connection
        Mysqlconn.Open()
        Dim sqlCmd As New MySqlCommand
        sqlDt.Clear()

        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "SELECT * FROM bankingdatabase.TransactionLog where Bank_Account_Number = @BAC;"

        sqlCmd.Parameters.Add("@BAC", MySqlDbType.Int64).Value = bank_account_no

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()

        ' Close the connection after use
        Mysqlconn.Close()
        sqlCmd.Dispose()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.DataSource = sqlDt
    End Sub
    'Make this form full screen
    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        Panel2.BackColor = Color.FromArgb(1, 12, 40)
        Panel3.BackColor = Color.FromArgb(1, 0, 70)
        Button10.BackColor = Color.FromArgb(1, 0, 70)
        Button11.BackColor = Color.FromArgb(1, 0, 70)
        Button12.BackColor = Color.FromArgb(1, 0, 70)
        Button13.BackColor = Color.FromArgb(1, 0, 70)
        Button14.BackColor = Color.FromArgb(1, 0, 70)
        Button15.BackColor = Color.FromArgb(1, 0, 70)

        RefreshDataGrid()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class