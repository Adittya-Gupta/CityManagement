Public Class EmployeeTable
    Inherits Form

    Private WithEvents tableControl As TableControl

    Public Sub New()
        InitializeComponent()

        ' Initialize and add TableControl
        tableControl = New TableControl()
        tableControl.Dock = DockStyle.Fill
        'Me.Controls.Add(tableControl)
        'Panel1.Dock = DockStyle.Fill
        Panel1.Controls.Add(tableControl)
        Me.Controls.Add(Panel1)

        ' fetch data and headers from database in actual code
        Dim dataInput As String(,) = {{"1", "2", "3", "4"},
                                      {"5", "6", "7", "8"},
                                      {"9", "10", "11", "12"}}

        Dim headerInput As String() = {"Header 1", "Header 2", "Header 3", "Header 4"}

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

    ' Other code for the form...
End Class
