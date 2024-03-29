Public Class ListofWorkers_Citizen
    Private Filterform As New Workersfilter()
    Public Sub New()
        InitializeComponent()
        AddHandler Me.VisibleChanged, AddressOf ListofWorkers_Citizen_VisibleChanged
    End Sub
    Private Sub ListofWorkers_Citizen_VisibleChanged(sender As Object, e As EventArgs)
        If Not Me.Visible Then
            Filterform.Hide()
        End If
    End Sub

    Private Sub ListofWorkers_Citizen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a new instance of ListItem
        Dim listItem1 As New ListItem("John Doe", "123 Main St", "5 ratings", "+91 9049382222", 4.5)
        Dim listItem2 As New ListItem("Jane Smith", "456 Oak Ave", "10 ratings", "+91 9049383333", 3.8)
        Dim listItem3 As New ListItem("Bob Johnson", "789 Elm Blvd", "3 ratings", "+91 9049384444", 2.7)
        Dim listItem4 As New ListItem("Alice Williams", "321 Pine Ln", "8 ratings", "+91 9049385555", 4.2)
        Dim listItem5 As New ListItem()

        ' Add the list items to the form
        Panel1.Controls.Add(listItem1)
        Panel1.Controls.Add(listItem2)
        Panel1.Controls.Add(listItem3)
        Panel1.Controls.Add(listItem4)
        Panel1.Controls.Add(listItem5)

        ' Position the message label based on the previous messages
        If Panel1.Controls.Count > 1 Then
            Dim prevMessageLabel As Control = Panel1.Controls(Panel1.Controls.Count - 2)
            listItem1.Top = 0
            listItem2.Top = 200
            listItem3.Top = 400
            listItem4.Top = 600
            listItem5.Top = 800
        End If

    End Sub

    Private Sub CurvedLabel9_Click(sender As Object, e As EventArgs) Handles CurvedLabel9.Click
        ' Show list of Workers form inside Panel1
        Globals.HomePage = Globals.listofServicesForm
        Globals.UrbanClapNavForm.ShowFormInPanel(Globals.listofServicesForm)
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Search for Service Provider" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.White ' Change text color to normal
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            TextBox1.Text = "Search for Service Provider"
            TextBox1.ForeColor = Color.Gray ' Change text color to placeholder color
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Check if Filterform is already visible
        If Filterform.Visible Then
            ' If Filterform is already visible, hide it
            Filterform.Hide()
        Else
            Filterform.BringToFront()
            ' If Filterform is not visible, show it
            Filterform.Show()
        End If
    End Sub
End Class
