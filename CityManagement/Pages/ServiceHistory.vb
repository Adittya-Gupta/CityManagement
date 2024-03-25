Imports CityManagement.HistoryItem

Public Class ServiceHistory
    Private UrbanClapNavForm As UrbanClapNav

    Public Sub New(ParentForm As UrbanClapNav)
        InitializeComponent()
        Me.UrbanClapNavForm = ParentForm
    End Sub

    Private Sub ServiceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create new instances of HistoryItem with specified values and states
        Dim historyItem1 As New HistoryItem("John Doe", "2 hours", "$50", currentState:=AppointmentState.Upcoming)
        Dim historyItem2 As New HistoryItem("Jane Smith", "1.5 hours", "$40", currentState:=AppointmentState.Completed)
        Dim historyItem3 As New HistoryItem("Bob Johnson", "3 hours", "$60", currentState:=AppointmentState.InProgress)
        Dim historyItem4 As New HistoryItem("Alice Williams", "2.5 hours", "$70", currentState:=AppointmentState.Finished)
        Dim historyItem5 As New HistoryItem("Eve Roberts", "2 hours", "$55", currentState:=AppointmentState.Rejected)
        Dim historyItem6 As New HistoryItem("Michael Brown", "1 hour", "$45", currentState:=AppointmentState.EnquirySent)

        ' Add the history items to Panel1
        Panel1.Controls.Add(historyItem1)
        Panel1.Controls.Add(historyItem2)
        Panel1.Controls.Add(historyItem3)
        Panel1.Controls.Add(historyItem4)
        Panel1.Controls.Add(historyItem5)
        Panel1.Controls.Add(historyItem6)

        ' Set the positions of the history items
        historyItem1.Top = 0
        historyItem2.Top = historyItem1.Bottom + 10
        historyItem3.Top = historyItem2.Bottom + 10
        historyItem4.Top = historyItem3.Bottom + 10
        historyItem5.Top = historyItem4.Bottom + 10
        historyItem6.Top = historyItem5.Bottom + 10
    End Sub

    Private Sub CurvedLabel9_Click(sender As Object, e As EventArgs) Handles CurvedLabel9.Click
        UrbanClapNavForm.ShowFormInPanel(UrbanClapNavForm.HomePage)
        UrbanClapNavForm.HideCurvedLabels()
    End Sub
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Search History" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.White ' Change text color to normal
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            TextBox1.Text = "Search History"
            TextBox1.ForeColor = Color.Gray ' Change text color to placeholder color
        End If
    End Sub
End Class
