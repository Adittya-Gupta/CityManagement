Public Class admin_Joblisting

    ' Define a constructor that accepts text as an argument
    Public Sub New(ByVal labelText As String)
        ' This call is required by the designer.
        InitializeComponent()


        ' Set the text of a label or any other control on the form using the provided argument
        ' For example, if you have a label named Label1 on your form, you can set its text like this:
        Label1.Text = labelText
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub admin_Joblisting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True ' Enable text wrapping
        DataGridView1.RowHeadersVisible = False ' Hide row headers

        Dim NameColumn As New DataGridViewTextBoxColumn()
        NameColumn.Name = "Name"
        NameColumn.HeaderText = "Name"
        NameColumn.Width = 140
        DataGridView1.Columns.Add(NameColumn)

        Dim DesignationColumn As New DataGridViewTextBoxColumn()
        DesignationColumn.Name = "Designation"
        DesignationColumn.HeaderText = "Designation"
        DesignationColumn.Width = 140
        DataGridView1.Columns.Add(DesignationColumn)

        Dim InstitueColumn As New DataGridViewTextBoxColumn()
        InstitueColumn.Name = "Institue"
        InstitueColumn.HeaderText = "Institue"
        InstitueColumn.Width = 140
        DataGridView1.Columns.Add(InstitueColumn)
    End Sub
End Class
