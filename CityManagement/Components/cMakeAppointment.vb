Public Class cMakeAppointment
    Dim hos_id As String
    Dim did As String
    Dim stime As String
    Dim uid As String
    Public Sub New(Optional ByVal name As String = "Default Name", Optional ByVal Exp As String = "Default Address", Optional ByVal Gender As String = "0 ratings", Optional ByVal Time As String = "+91 9049381111", Optional ByVal rating As Double = 3.0, Optional hosid As String = "", Optional doc As String = "", Optional stimee As String = "", Optional ui As String = "")
        'this call Is required by the designer.
        InitializeComponent()
        ' Set the values to the controls
        CurvedLabel5.Text = name
        CurvedLabel3.Text = Exp
        CurvedLabel1.Text = Gender
        CurvedLabel4.Text = Time
        CurvedLabel2.Text = rating
        uid = ui
        hos_id = hosid
        did = doc
        stime = stimee

        ' Add a Click event handler to the form
        AddHandler Me.Click, AddressOf Form_Click
    End Sub

    Public Sub Form_Click(sender As Object, e As EventArgs) Handles Me.Click
        ' Set the clicked form as the active form
        Me.BackColor = Color.LightGray

        Dim send As New makeAppointment()
        send.senddata(hos_id, did, stime, uid)

    End Sub



End Class
