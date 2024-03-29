Public Class ListOfChats

    'Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    'Load the form
    Private Sub ListOfChats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a 7 new instance of ListItem
        Dim listItem1 As New Chatlistitem("John Doe", "123 Main St")
        Dim listItem2 As New Chatlistitem("Jane Smith", "456 Oak Ave")
        Dim listItem3 As New Chatlistitem("Bob Johnson", "789 Elm Blvd")
        Dim listItem4 As New Chatlistitem("Alice Williams", "321 Pine Ln")
        Dim listItem5 As New Chatlistitem("John Doe", "123 Main St")
        Dim listItem6 As New Chatlistitem("Jane Smith", "456 Oak Ave")
        Dim listItem7 As New Chatlistitem("Bob Johnson", "789 Elm Blvd")

        ' Add the list items to the form
        SplitContainer1.Panel1.Controls.Add(listItem1)
        SplitContainer1.Panel1.Controls.Add(listItem2)
        SplitContainer1.Panel1.Controls.Add(listItem3)
        SplitContainer1.Panel1.Controls.Add(listItem4)
        SplitContainer1.Panel1.Controls.Add(listItem5)
        SplitContainer1.Panel1.Controls.Add(listItem6)
        SplitContainer1.Panel1.Controls.Add(listItem7)

        ' Dock each item to the top
        listItem1.Dock = DockStyle.Top
        listItem2.Dock = DockStyle.Top
        listItem3.Dock = DockStyle.Top
        listItem4.Dock = DockStyle.Top
        listItem5.Dock = DockStyle.Top
        listItem6.Dock = DockStyle.Top
        listItem7.Dock = DockStyle.Top
    End Sub

    Private Sub CurvedLabel9_Click(sender As Object, e As EventArgs) Handles CurvedLabel9.Click
        Globals.UrbanClapNavForm.HideCurvedLabels()
        Globals.UrbanClapNavForm.ShowFormInPanel(Globals.HomePage)
    End Sub
End Class
