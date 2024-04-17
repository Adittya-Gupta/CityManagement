Imports MySql.Data.MySqlClient

Public Class EmployeeTable
    Inherits Form

    Private WithEvents tableControl As TableControl
    Private _orgID As Int32

    Private OrgHeadWorkSectionForm As OrgHeadWorkSection

    Public Sub New(ParentForm As OrgHeadWorkSection,
                   ByVal orgID As Int32)
        InitializeComponent()
        _orgID = orgID

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
        Dim headerInput As String() = {"User ID", "Email ID", "Experience", "Rating", "Phone Number"}

        ' fetch data and headers from database in actual code
        Dim dataInput As String(,) = {}
        Dim emailID As String
        Dim experience As String
        Dim rating As Decimal
        Dim Phone_Number As Int64
        Dim userID As Int32

        Dim connString As String = Module1.connString
        'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Dim query As String = "select userID, prof_email, experience, rating, Phone_Number from serviceWorkers where orgID = @A"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@A", _orgID)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    userID = Convert.ToInt32(reader("userID"))
                    emailID = Convert.ToString(reader("prof_email"))
                    experience = Convert.ToString(reader("experience"))
                    rating = Convert.ToDecimal(reader("rating"))
                    Phone_Number = Convert.ToInt64(reader("Phone_Number"))

                    ' Create a new array to hold the values
                    Dim newDataInput(0 To 4) As String
                    newDataInput(0) = userID.ToString()
                    newDataInput(1) = emailID.ToString()
                    newDataInput(2) = experience & " years"
                    newDataInput(3) = rating.ToString()
                    newDataInput(4) = Phone_Number.ToString()

                    ' Resize and copy the original dataInput array
                    Dim newDataSize As Integer = dataInput.GetLength(0) + 1
                    Dim newDataInputIndex As Integer = 0
                    Dim newDataInputColumnIndex As Integer
                    Dim newDataInputRowIndex As Integer
                    Dim newDataInputArray(newDataSize - 1, 4) As String

                    For newDataInputRowIndex = 0 To newDataSize - 2
                        For newDataInputColumnIndex = 0 To 4
                            newDataInputArray(newDataInputRowIndex, newDataInputColumnIndex) = dataInput(newDataInputRowIndex, newDataInputColumnIndex)
                        Next
                    Next

                    ' Add the new data to the last row
                    For newDataInputColumnIndex = 0 To 4
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
        Dim totalWidth As Integer = Panel1.Width - 1
        tableControl.dataGridView.Columns(0).Width = totalWidth * 0.16
        tableControl.dataGridView.Columns(1).Width = totalWidth * 0.3
        tableControl.dataGridView.Columns(2).Width = totalWidth * 0.14
        tableControl.dataGridView.Columns(3).Width = totalWidth * 0.1
        tableControl.dataGridView.Columns(4).Width = totalWidth * 0.3

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
