Public Class Health_DoctorsEmployment
    Private Sub Health_DoctorsEmployment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.AutoScroll = True
        ComboBox1.Height = 50 ' Set height to 50
        ComboBox1.Items.AddRange(New String() {"Specialization", "Cardiology", "General Practicineer", "Neurology"})
        ComboBox1.SelectedIndex = 0
        ' Set the SelectionLength property of the ComboBox to 0 to deselect any selected text



        ' Add five ListBoxes to the FlowLayoutPanel
        For i As Integer = 1 To 10
            Dim botton As New Button()
            botton.Name = "ListBox" & i
            botton.Width = 950
            botton.Height = 100
            botton.BackColor = System.Drawing.ColorTranslator.FromHtml("#EBE7E7")

            ' Add items to the ListBox
            botton.Text = "IITG Hospital            Near KV Gate          46"

            ' Set the font size
            botton.Font = New Font(botton.Font.FontFamily, 24)

            ' Add some margin between ListBoxes
            botton.Margin = New Padding(10)


            ' Add the ListBox to the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Add(botton)
        Next
    End Sub
End Class