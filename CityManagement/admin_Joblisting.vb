Imports MySql.Data.MySqlClient

Public Class admin_Joblisting

    ' Define a constructor that accepts text as an argument
    Public Sub New(ByVal labelText As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Set the text of a label or any other control on the form using the provided argument
        ' For example, if you have a label named Label1 on your form, you can set its text like this:
        Label1.Text = labelText

        ' Connect to the database
        Dim connString As String = Module1.connString
        Dim conn As New MySqlConnection(connString)

        Try
            conn.Open()

            ' Define the SQL query based on the labelText parameter
            Dim query As String = ""
            Select Case labelText
                Case "Institute Owner", "Hospital Owner", "SHO", "Transport Officer", "Municipal Officer"
                    query = "SELECT Institutes.Name, Institutes.Type, User.Name " &
                            "FROM Institutes " &
                            "INNER JOIN User ON Institutes.Owner_ID = User.SID " &
                            "WHERE Institutes.Type = @type"
                Case "Teacher", "Doctor", "Driver", "Employee", "Police"
                    query = "SELECT User.Name, User.Designation " &
                            "FROM User " &
                            "WHERE User.Designation = @designation"
                Case Else
                    MessageBox.Show("Invalid label text")
                    Return
            End Select

            ' Execute the query
            Dim cmd As New MySqlCommand(query, conn)

            ' Add parameters for the query
            If labelText = "Institute Owner" Then
                cmd.Parameters.AddWithValue("@type", "Education")
            ElseIf labelText = "Hospital Owner" Then
                cmd.Parameters.AddWithValue("@type", "Hospital")
            ElseIf labelText = "SHO" Then
                cmd.Parameters.AddWithValue("@type", "Law")
            ElseIf labelText = "Transport Officer" Then
                cmd.Parameters.AddWithValue("@type", "Transport")
            ElseIf labelText = "Municipal Officer" Then
                cmd.Parameters.AddWithValue("@type", "Finance")
            ElseIf labelText = "Teacher" Or labelText = "Doctor" Or labelText = "Driver" Or labelText = "Employee" Or labelText = "Police" Then
                cmd.Parameters.AddWithValue("@designation", labelText)
            End If

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing data in DataGridView
            DataGridView1.Rows.Clear()

            ' Add columns to the DataGridView
            If labelText = "Institute Owner" Or labelText = "Hospital Owner" Or labelText = "SHO" Or labelText = "Transport Officer" Or labelText = "Municipal Officer" Then
                DataGridView1.Columns.Add("Name", "Name")
                DataGridView1.Columns.Add("Type", "Type")
                DataGridView1.Columns.Add("Institute", "Institute")
            Else
                DataGridView1.Columns.Add("Name", "Name")
                DataGridView1.Columns.Add("Designation", "Designation")
            End If

            ' Set the width of columns based on the DataGridView width
            Dim columnWidth As Integer = DataGridView1.Width / DataGridView1.Columns.Count - 15
            For Each col As DataGridViewColumn In DataGridView1.Columns
                col.Width = columnWidth
            Next

            ' Iterate through the result set and populate the DataGridView
            While reader.Read()
                If labelText = "Institute Owner" Or labelText = "Hospital Owner" Or labelText = "SHO" Or labelText = "Transport Officer" Or labelText = "Municipal Officer" Then
                    Dim name As String = reader.GetString(0)
                    Dim type As String = reader.GetString(1)
                    Dim ownerName As String = reader.GetString(2)

                    ' Add a new row to the DataGridView with fetched data
                    DataGridView1.Rows.Add(name, type, ownerName)
                Else
                    Dim name As String = reader.GetString(0)
                    Dim designation As String = reader.GetString(1)

                    ' Add a new row to the DataGridView with fetched data
                    DataGridView1.Rows.Add(name, designation)
                End If
            End While

            ' Close the data reader
            reader.Close()

        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

End Class
