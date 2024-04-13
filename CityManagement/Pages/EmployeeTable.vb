Imports MySql.Data.MySqlClient

Public Class EmployeeTable
    Inherits Form

    Private WithEvents tableControl As TableControl

    Private OrgHeadWorkSectionForm As OrgHeadWorkSection

    Public Sub New(ParentForm As OrgHeadWorkSection)
        InitializeComponent()

        ' Initialize and add TableControl
        tableControl = New TableControl()
        tableControl.Dock = DockStyle.Fill
        'Me.Controls.Add(tableControl)
        'Panel1.Dock = DockStyle.Fill
        Panel1.Controls.Add(tableControl)
        Me.Controls.Add(Panel1)

        'Dim dataInput As String(,) = {{"1", "2 years", "3.1", "1234567890"},
        '                              {"5", "6 years", "4.2", "8123456789"},
        '                              {"9", "10 years", "4.6", "1209876543"}}
        Dim headerInput As String() = {"User ID", "Experience", "Rating", "Phone Number"}

        ' fetch data and headers from database in actual code
        Dim dataInput As String(,) = {}
        Dim userID As Integer
        Dim experience As String
        Dim rating As Decimal
        Dim Phone_Number As Int64

        Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Dim query As String = "select userID, experience, rating, Phone_Number from serviceWorkers where orgID = 101"
            Using cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    userID = Convert.ToInt32(reader("userID"))
                    experience = Convert.ToString(reader("experience"))
                    rating = Convert.ToDecimal(reader("rating"))
                    Phone_Number = Convert.ToInt64(reader("Phone_Number"))

                    ' Create a new array to hold the values
                    Dim newDataInput(0 To 3) As String
                    newDataInput(0) = userID.ToString()
                    newDataInput(1) = experience & " years"
                    newDataInput(2) = rating.ToString()
                    newDataInput(3) = Phone_Number.ToString()

                    ' Resize and copy the original dataInput array
                    Dim newDataSize As Integer = dataInput.GetLength(0) + 1
                    Dim newDataInputIndex As Integer = 0
                    Dim newDataInputColumnIndex As Integer
                    Dim newDataInputRowIndex As Integer
                    Dim newDataInputArray(newDataSize - 1, 3) As String

                    For newDataInputRowIndex = 0 To newDataSize - 2
                        For newDataInputColumnIndex = 0 To 3
                            newDataInputArray(newDataInputRowIndex, newDataInputColumnIndex) = dataInput(newDataInputRowIndex, newDataInputColumnIndex)
                        Next
                    Next

                    ' Add the new data to the last row
                    For newDataInputColumnIndex = 0 To 3
                        newDataInputArray(newDataSize - 1, newDataInputColumnIndex) = newDataInput(newDataInputColumnIndex)
                    Next

                    ' Assign the new array to dataInput
                    dataInput = newDataInputArray
                End While
            End Using
        Catch ex As Exception
            ' Handle exception
        End Try


        tableControl.LoadData(dataInput, headerInput)

        ' Set column width to fill the Panel
        Dim colWidth As Integer = (Panel1.Width - 1) \ tableControl.dataGridView.ColumnCount
        For Each col As DataGridViewColumn In tableControl.dataGridView.Columns
            col.Width = colWidth
        Next

        For Each row As DataGridViewRow In tableControl.dataGridView.Rows
            row.Height *= 2
        Next

        ' Adjust header height and style
        tableControl.dataGridView.ColumnHeadersHeight *= 2
        For Each col As DataGridViewColumn In tableControl.dataGridView.Columns
            col.HeaderCell.Style.Font = New Font(tableControl.dataGridView.Font, FontStyle.Bold)
        Next

        Dim totalHeight As Integer = (tableControl.dataGridView.Rows.Count + 2) * tableControl.dataGridView.Rows(0).Height

        ' Set panel height
        Panel1.Height = totalHeight
    End Sub

    Private Sub EmployeeTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    ' Other code for the form...
End Class
