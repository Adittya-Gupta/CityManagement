Imports MySql.Data.MySqlClient

Public Class IncomingEmploymentReq

    Private OrgHeadWorkSectionForm As OrgHeadWorkSection

    'Constructor
    'Public Sub New(ParentForm As EmploymentPortal)
    '    InitializeComponent()
    '    'Me.EmployOrgListForm = ParentForm
    '    Me.EmploymentPortalForm = ParentForm ' Initialize EmploymentPortalForm
    '    Me.FormBorderStyle = FormBorderStyle.None
    'End Sub

    'Constructor
    Public Sub New(ParentForm As OrgHeadWorkSection)
        InitializeComponent()
        'Me.EmployOrgListForm = ParentForm
        Me.OrgHeadWorkSectionForm = ParentForm ' Initialize EmploymentPortalForm
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IncomingEmploymentReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        Dim userID_ As Integer
        Dim orgID_ As Integer
        Dim name_ As String
        Dim date_ As DateTime
        Dim contactDetails_ As String
        Dim bank_account_no_ As Int64
        Dim detailsPrevWork_ As String
        Dim i As Integer = 1

        ' start
        Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Dim query As String = "select userID, orgID, name, date, contactDetails, bank_account_no, detailsPrevWork from workerEmployReq where orgID = @A and status = 'Submitted' "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@A", 101)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    userID_ = Convert.ToInt32(reader("userID"))
                    orgID_ = Convert.ToInt32(reader("orgID"))
                    name_ = Convert.ToString(reader("name"))
                    date_ = Convert.ToDateTime(reader("date"))
                    contactDetails_ = Convert.ToString(reader("contactDetails"))
                    bank_account_no_ = Convert.ToInt64(reader("bank_account_no"))
                    detailsPrevWork_ = Convert.ToString(reader("detailsPrevWork"))

                    Dim listItem As New Incoming_Emp_Req(Me, date_, name_, i, contactDetails_, bank_account_no_, detailsPrevWork_, userID_, orgID_)
                    Panel1.Controls.Add(listItem)
                    listItem.Left = 80

                    ' Set margin top for ListItem2 to ListItem4
                    If i > 1 Then
                        listItem.Top += (i - 1) * 200
                    End If

                    i = i + 1
                End While
            End Using
        Catch ex As Exception
            ' Handle exception
        End Try
        ' end



        'For i As Integer = 1 To 4
        '        Dim listItem As New Incoming_Emp_Req(Me, Date.Now, "Rashaad", i, "1234567890", 987654321, "previous work")
        '        Panel1.Controls.Add(listItem)
        '        listItem.Left = 80

        '        ' Set margin top for ListItem2 to ListItem4
        '        If i > 1 Then
        '            listItem.Top += (i - 1) * 200
        '        End If
        '    Next


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class