Imports System.IO
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities

Public Class IncomingEmploymentReq

    Private OrgHeadWorkSectionForm As OrgHeadWorkSection
    Private _orgID As Int32

    'Constructor
    'Public Sub New(ParentForm As EmploymentPortal)
    '    InitializeComponent()
    '    'Me.EmployOrgListForm = ParentForm
    '    Me.EmploymentPortalForm = ParentForm ' Initialize EmploymentPortalForm
    '    Me.FormBorderStyle = FormBorderStyle.None
    'End Sub

    'Constructor
    Public Sub New(ParentForm As OrgHeadWorkSection,
                   ByVal orgID As Int32)
        InitializeComponent()
        _orgID = orgID
        'Me.EmployOrgListForm = ParentForm
        Me.OrgHeadWorkSectionForm = ParentForm ' Initialize EmploymentPortalForm
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IncomingEmploymentReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        Panel1.HorizontalScroll.Enabled = False
        Panel1.HorizontalScroll.Visible = False
        Label1.Hide()

        Dim userID_ As Integer
        Dim orgID_ As Integer
        Dim name_ As String
        Dim date_ As DateTime
        Dim contactDetails_ As String
        Dim bank_account_no_ As Int64
        Dim detailsPrevWork_ As String
        Dim prof_email_ As String
        Dim address_ As String
        Dim i As Integer = 1

        ' start
        Dim connString As String = Module1.connString
        'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Dim query As String = "select userID, orgID, name, date, contactDetails, bank_account_no, detailsPrevWork, profile_picture, email, address from workerEmployReq where orgID = @A and status = 'Submitted' "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@A", _orgID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    userID_ = Convert.ToInt32(reader("userID"))
                    orgID_ = Convert.ToInt32(reader("orgID"))
                    name_ = Convert.ToString(reader("name"))
                    date_ = Convert.ToDateTime(reader("date"))
                    contactDetails_ = Convert.ToString(reader("contactDetails"))
                    bank_account_no_ = Convert.ToInt64(reader("bank_account_no"))
                    detailsPrevWork_ = Convert.ToString(reader("detailsPrevWork"))
                    prof_email_ = Convert.ToString(reader("email"))
                    address_ = Convert.ToString(reader("address"))

                    ' Handling the profile_picture BLOB field
                    Dim img_bytes As Byte() = Nothing
                    If Not IsDBNull(reader("profile_picture")) Then
                        img_bytes = TryCast(reader("profile_picture"), Byte())
                    End If

                    Dim img As Image = Nothing
                    If img_bytes IsNot Nothing Then
                        Using ms As New MemoryStream(img_bytes)
                            img = Image.FromStream(ms)
                        End Using
                    End If



                    'Dim listItem As New Incoming_Emp_Req(Me, date_, name_, i, contactDetails_, bank_account_no_, detailsPrevWork_, userID_, orgID_)
                    Dim listItem As New Incoming_Emp_Req(Me, date_, name_, i, contactDetails_, bank_account_no_, detailsPrevWork_, userID_, orgID_, prof_email_, address_, img)
                    Panel1.Controls.Add(listItem)

                    ' Set margin top for ListItem2 to ListItem4
                    If i > 1 Then
                        listItem.Top += (i - 1) * 200
                    End If


                    i = i + 1
                End While
            End Using
            If i = 1 Then
                Label1.Show()
            End If
            Panel1.Height = i * 200
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

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class