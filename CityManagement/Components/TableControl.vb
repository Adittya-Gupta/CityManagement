Imports System.Windows.Forms

Public Class TableControl
    Inherits UserControl

    Public WithEvents dataGridView As DataGridView

    Public Sub New()
        ' Initialize the control
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        ' Initialize DataGridView
        dataGridView = New DataGridView()
        dataGridView.Dock = DockStyle.Fill
        Me.Controls.Add(dataGridView)
    End Sub

    Public Sub LoadData(data As String(,), headers As String())
        ' Set DataGridView properties
        dataGridView.ColumnCount = data.GetLength(1)
        dataGridView.RowCount = data.GetLength(0)
        ' Set RowHeadersVisible property to False
        dataGridView.RowHeadersVisible = False
        'dataGridView.AllowUserToAddRows = False
        'dataGridView.AllowUserToDeleteRows = False
        'dataGridView.ReadOnly = True
        dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        ' Set headers
        For j As Integer = 0 To headers.Length - 1
            dataGridView.Columns(j).HeaderText = headers(j)
            dataGridView.Columns(j).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        ' Load data into DataGridView
        For i As Integer = 0 To data.GetLength(0) - 1
            For j As Integer = 0 To data.GetLength(1) - 1
                dataGridView.Rows(i).Cells(j).Value = data(i, j)
            Next
        Next
    End Sub
End Class
