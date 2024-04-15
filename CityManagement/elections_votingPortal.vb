Imports System.Security.Cryptography
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports GemBox.Pdf
Public Class elections_votingPortal
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Dim idOfCurrentUser As Integer = Module1.CurrUserSID
    'Input to the form is SID
    'Public Sub New(ByVal userInput As Integer)
    '   InitializeComponent()
    '   Me.idOfCurrentUser = userInput
    'End Sub
    Private candidateDetailsList As New List(Of candidateDetails)
    Private userVotes As New Dictionary(Of String, Integer)()
    Dim currentDesignation As String
    Public Sub New()
        InitializeComponent()
        ComponentInfo.SetLicense("YOUR_LICENSE_KEY")
    End Sub
    Private Sub votingPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Candidates.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF")
        Candidates.AutoScroll = False
        Candidates.HorizontalScroll.Enabled = False
        Candidates.HorizontalScroll.Visible = False
        Candidates.AutoScroll = True
        Dim itemsList As New List(Of String) From {"Education Minister", "Transport Minister", "Health Minister", "Finance Minister", "Home Minister"}
        selectMinister.Items.AddRange(itemsList.ToArray())
        selectMinister.DropDownStyle = ComboBoxStyle.DropDownList
        userVotes("Education Minister") = -1
        userVotes("Transport Minister") = -1
        userVotes("Health Minister") = -1
        userVotes("Finance Minister") = -1
        userVotes("Home Minister") = -1
        selectMinister.SelectedIndex = 0
        Candidates.Controls.Clear()
        candidateDetailsList.Clear()
        Dim previousControlBottom As Integer = 0
        Try
            conn.Open()
            Dim query As String = "select Name,Agenda,Nominees.SID as SID from Nominees INNER JOIN User on Nominees.SID=User.SID where Nominees.Designation=@a"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@a", "Education Minister")
                Dim reader = cmd.ExecuteReader
                While reader.Read
                    Dim candidate As New candidateDetails()
                    candidateDetailsList.Add(candidate)
                    candidate.Dock = DockStyle.None
                    candidate.Width = Candidates.Width
                    candidate.Location = New Point(0, previousControlBottom)
                    candidate.AgendaContent = Convert.ToString(reader("Agenda"))
                    candidate.NomineeName = Convert.ToString(reader("Name"))
                    candidate.NomineeSID = Convert.ToInt32(reader("SID"))
                    previousControlBottom = candidate.Bottom
                    Candidates.Controls.Add(candidate)
                End While
            End Using
        Catch ex As Exception

        Finally
            conn.Close()
        End Try

        For Each candidateDetail As candidateDetails In candidateDetailsList
            AddHandler candidateDetail.CheckBoxCheckedChanged, AddressOf CheckBoxUserControl_CheckedChanged
        Next
    End Sub

    Private Sub selectMinister_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectMinister.SelectedIndexChanged
        Candidates.Controls.Clear()
        candidateDetailsList.Clear()
        Dim previousControlBottom = 0
        Select Case selectMinister.SelectedIndex
            Case 0
                Try
                    conn.Open()
                    Dim query = "select Name,Agenda,Nominees.SID as SID from Nominees INNER JOIN User on Nominees.SID=User.SID where Nominees.Designation=@a"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@a", "Education Minister")
                        currentDesignation = "Education Minister"
                        Dim reader = cmd.ExecuteReader
                        While reader.Read
                            Dim candidate As New candidateDetails
                            candidateDetailsList.Add(candidate)
                            candidate.Dock = DockStyle.None
                            candidate.Width = Candidates.Width
                            candidate.Location = New Point(0, previousControlBottom)
                            candidate.AgendaContent = Convert.ToString(reader("Agenda"))
                            candidate.NomineeName = Convert.ToString(reader("Name"))
                            candidate.NomineeSID = Convert.ToInt32(reader("SID"))
                            If userVotes("Education Minister") = candidate.NomineeSID Then
                                candidate.CheckBox.Checked = True
                            End If
                            previousControlBottom = candidate.Bottom
                            Candidates.Controls.Add(candidate)
                        End While
                    End Using
                Catch ex As Exception

                Finally
                    conn.Close()
                End Try
            Case 1
                Try
                    conn.Open()
                    Dim query = "select Name,Agenda,Nominees.SID as SID from Nominees INNER JOIN User on Nominees.SID=User.SID where Nominees.Designation=@a"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@a", "Transport Minister")
                        currentDesignation = "Transport Minister"
                        Dim reader = cmd.ExecuteReader
                        While reader.Read
                            Dim candidate As New candidateDetails
                            candidateDetailsList.Add(candidate)
                            candidate.Dock = DockStyle.None
                            candidate.Width = Candidates.Width
                            candidate.Location = New Point(0, previousControlBottom)
                            candidate.AgendaContent = Convert.ToString(reader("Agenda"))
                            candidate.NomineeName = Convert.ToString(reader("Name"))
                            candidate.NomineeSID = Convert.ToInt32(reader("SID"))
                            If userVotes("Transport Minister") = candidate.NomineeSID Then
                                candidate.CheckBox.Checked = True
                            End If
                            previousControlBottom = candidate.Bottom
                            Candidates.Controls.Add(candidate)
                        End While
                    End Using
                Catch ex As Exception

                Finally
                    conn.Close()
                End Try
            Case 2
                Try
                    conn.Open()
                    Dim query = "select Name,Agenda,Nominees.SID as SID from Nominees INNER JOIN User on Nominees.SID=User.SID where Nominees.Designation=@a"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@a", "Health Minister")
                        currentDesignation = "Health Minister"
                        Dim reader = cmd.ExecuteReader
                        While reader.Read
                            Dim candidate As New candidateDetails
                            candidateDetailsList.Add(candidate)
                            candidate.Dock = DockStyle.None
                            candidate.Width = Candidates.Width
                            candidate.Location = New Point(0, previousControlBottom)
                            candidate.AgendaContent = Convert.ToString(reader("Agenda"))
                            candidate.NomineeName = Convert.ToString(reader("Name"))
                            candidate.NomineeSID = Convert.ToInt32(reader("SID"))
                            If userVotes("Health Minister") = candidate.NomineeSID Then
                                candidate.CheckBox.Checked = True
                            End If
                            previousControlBottom = candidate.Bottom
                            Candidates.Controls.Add(candidate)
                        End While
                    End Using
                Catch ex As Exception

                Finally
                    conn.Close()
                End Try
            Case 3
                Try
                    conn.Open()
                    Dim query = "select Name,Agenda,Nominees.SID as SID from Nominees INNER JOIN User on Nominees.SID=User.SID where Nominees.Designation=@a"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@a", "Finance Minister")
                        currentDesignation = "Finance Minister"
                        Dim reader = cmd.ExecuteReader
                        While reader.Read
                            Dim candidate As New candidateDetails
                            candidateDetailsList.Add(candidate)
                            candidate.Dock = DockStyle.None
                            candidate.Width = Candidates.Width
                            candidate.Location = New Point(0, previousControlBottom)
                            candidate.AgendaContent = Convert.ToString(reader("Agenda"))
                            candidate.NomineeName = Convert.ToString(reader("Name"))
                            candidate.NomineeSID = Convert.ToInt32(reader("SID"))
                            If userVotes("Finance Minister") = candidate.NomineeSID Then
                                candidate.CheckBox.Checked = True
                            End If
                            previousControlBottom = candidate.Bottom
                            Candidates.Controls.Add(candidate)
                        End While
                    End Using
                Catch ex As Exception

                Finally
                    conn.Close()
                End Try
            Case 4
                Try
                    conn.Open()
                    Dim query = "select Name,Agenda,Nominees.SID as SID from Nominees INNER JOIN User on Nominees.SID=User.SID where Nominees.Designation=@a"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@a", "Home Minister")
                        currentDesignation = "Home Minister"
                        Dim reader = cmd.ExecuteReader
                        While reader.Read
                            Dim candidate As New candidateDetails
                            candidateDetailsList.Add(candidate)
                            candidate.Dock = DockStyle.None
                            candidate.Width = Candidates.Width
                            candidate.Location = New Point(0, previousControlBottom)
                            candidate.AgendaContent = Convert.ToString(reader("Agenda"))
                            candidate.NomineeName = Convert.ToString(reader("Name"))
                            candidate.NomineeSID = Convert.ToInt32(reader("SID"))
                            If userVotes("Home Minister") = candidate.NomineeSID Then
                                candidate.CheckBox.Checked = True
                            End If
                            previousControlBottom = candidate.Bottom
                            Candidates.Controls.Add(candidate)
                        End While
                    End Using
                Catch ex As Exception
                Finally
                    conn.Close()
                End Try
        End Select
        For Each candidateDetail In candidateDetailsList
            AddHandler candidateDetail.CheckBoxCheckedChanged, AddressOf CheckBoxUserControl_CheckedChanged
        Next
    End Sub

    Private Sub CheckBoxUserControl_CheckedChanged(sender As Object, e As EventArgs)
        ' Cast the sender to candidateDetails
        Dim clickedControl As candidateDetails = DirectCast(sender, candidateDetails)
        ' If the clicked control is checked, uncheck all other controls
        If clickedControl.Checked Then
            ' Iterate through the candidateDetailsList
            For Each ctrl As candidateDetails In candidateDetailsList
                ' Check if the control is not the clicked control
                If ctrl IsNot clickedControl Then
                    ' Uncheck the control
                    ctrl.Checked = False
                End If
            Next
            userVotes(currentDesignation) = clickedControl.NomineeSID
            'MessageBox.Show(userVotes(currentDesignation), currentDesignation)
        Else
        End If
    End Sub

    Private Sub NOTAButton_Click(sender As Object, e As EventArgs) Handles NOTA.Click
        ' Clear all checkboxes in the list
        For Each ctrl In candidateDetailsList
            ctrl.Checked = False
        Next
        userVotes(currentDesignation) = -1
    End Sub
    Private Sub Vote_Click(sender As Object, e As EventArgs) Handles Vote.Click
        Try
            conn.Open()
            Dim query = "update Voters set Health=@a,Education=@b,Muncipal=@c,Commerce=@d,Transportation=@e where SID=@f"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@f", idOfCurrentUser)
                cmd.Parameters.AddWithValue("@a", userVotes("Health Minister"))
                cmd.Parameters.AddWithValue("@b", userVotes("Education Minister"))
                cmd.Parameters.AddWithValue("@c", userVotes("Home Minister"))
                cmd.Parameters.AddWithValue("@d", userVotes("Finance Minister"))
                cmd.Parameters.AddWithValue("@e", userVotes("Transport Minister"))
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Your Vote was successfully registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If userVotes("Health Minister") >= 0 Then
                query = "update Nominees set VoteCount = VoteCount + 1 where SID=@a"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@a", userVotes("Health Minister"))
                    cmd.ExecuteNonQuery()
                End Using
            End If
            If userVotes("Education Minister") >= 0 Then
                query = "update Nominees set VoteCount = VoteCount + 1 where SID=@a"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@a", userVotes("Education Minister"))
                    cmd.ExecuteNonQuery()
                End Using
            End If
            If userVotes("Home Minister") >= 0 Then
                query = "update Nominees set VoteCount = VoteCount + 1 where SID=@a"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@a", userVotes("Home Minister"))
                    cmd.ExecuteNonQuery()
                End Using
            End If
            If userVotes("Finance Minister") >= 0 Then
                query = "update Nominees set VoteCount = VoteCount + 1 where SID=@a"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@a", userVotes("Finance Minister"))
                    cmd.ExecuteNonQuery()
                End Using
            End If
            If userVotes("Transport Minister") >= 0 Then
                query = "update Nominees set VoteCount = VoteCount + 1 where SID=@a"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@a", userVotes("Transport Minister"))
                    cmd.ExecuteNonQuery()
                End Using
            End If
            'Open new form and close the current form here
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
        Dim form As New election_dashboard()
        mypanel.panel1.Controls.Clear()
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim form As New election_dashboard()
        mypanel.Panel1.Controls.Clear()
        form.TopLevel = False
        mypanel.Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles back.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        back.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles back.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        back.Cursor = Cursors.Default
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Vote.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        Vote.Cursor = Cursors.Hand
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Vote.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        Vote.Cursor = Cursors.Default
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles NOTA.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        NOTA.Cursor = Cursors.Hand
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles NOTA.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        NOTA.Cursor = Cursors.Default
    End Sub
End Class