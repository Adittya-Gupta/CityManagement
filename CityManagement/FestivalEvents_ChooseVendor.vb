Imports System.Windows.Forms
Imports CityManagement.FestivalEvents_Offer_Service2
Imports MySql.Data.MySqlClient

Public Class FestivalEvents_ChooseVendor
    Private selectedVendorButton As Button ' Tracks the currently selected vendor button
    Public vendorServiceTags As List(Of VendorServiceTag)
    Private currentIndex As Integer
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)

    ' Constructor to initialize the form with the list of VendorServiceTag objects and the current index
    Public Sub New(ByVal serviceTags As List(Of VendorServiceTag), ByVal index As Integer)
        InitializeComponent()
        Me.vendorServiceTags = serviceTags
        Me.currentIndex = index
    End Sub

    Private Sub FestivalEvents_ChooseVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            ' Set up the selected vendor label
            Dim lblSelected As New Label()
            lblSelected.Text = "Selected:"
            lblSelected.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold)
            lblSelected.AutoSize = True
            lblSelected.Location = New Point(20, 40)
            Me.Controls.Add(lblSelected)

            Dim lblSelectedVendor As New Label()
            lblSelectedVendor.Name = "lblSelectedVendor"
            If vendorServiceTags(currentIndex).ApprovedVendorSID Is Nothing Then
                lblSelectedVendor.Text = "Not Selected"
            Else
                lblSelectedVendor.Text = GetVendorName(vendorServiceTags(currentIndex).ApprovedVendorSID)
            End If
            lblSelectedVendor.Font = New Font(FontFamily.GenericSansSerif, 10)
            lblSelectedVendor.AutoSize = True
            lblSelectedVendor.Location = New Point(130, 40)
            Me.Controls.Add(lblSelectedVendor)

            Dim lblRequests As New Label()
            lblRequests.Text = "Requests:"
            lblRequests.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold)
            lblRequests.AutoSize = True
            lblRequests.Location = New Point(20, 70)
            Me.Controls.Add(lblRequests)

            ' Add Panel1
            Dim Panel1 As New Panel()
            Panel1.Location = New Point(20, 100)
            Panel1.Size = New Size(600, 300) ' Set the initial size of the panel
            Panel1.AutoScroll = True ' Enable auto-scrolling
            Panel1.BackColor = Color.WhiteSmoke ' Set the background color to light gray
            Me.Controls.Add(Panel1)

            ' Add vendor buttons inside Panel1
            Dim yPos As Integer = 0 ' Starting Y position for the vendor buttons
            For Each vendor In vendorServiceTags(currentIndex).ListofVendorSIDs
                Dim lblVendor As New Label()
                lblVendor.Text = GetVendorName(vendor)
                lblVendor.Font = New Font(FontFamily.GenericSansSerif, 12)
                lblVendor.AutoSize = True
                lblVendor.Location = New Point(10, yPos)

                Dim selectButton As New Button()
                selectButton.Text = "Select"
                selectButton.AutoSize = True
                selectButton.Location = New Point(lblVendor.Right + 20, yPos)
                selectButton.FlatStyle = FlatStyle.Flat ' Remove the border
                selectButton.Tag = vendor ' Set the vendor name as the Tag of the button
                selectButton.BackColor = Color.FromArgb(53, 152, 220) ' Set background color to blue
                selectButton.ForeColor = Color.White ' Set foreground color to white
                selectButton.Padding = New Padding(10) ' Add padding for better appearance

                AddHandler selectButton.Click, AddressOf SelectButton_Click

                Panel1.Controls.Add(lblVendor)
                Panel1.Controls.Add(selectButton)

                yPos += lblVendor.Height + 20
            Next
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Public Function GetVendorName(ByVal SID As Integer) As String
        Dim name As String = SID.ToString

        ' Ensure the connection is open before attempting to use it
        If conn.State <> ConnectionState.Open Then
            MessageBox.Show("Connection is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return name
        End If

        Try
            Dim query = "SELECT Name FROM User WHERE SID = @sid"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@sid", SID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        name = reader("Name").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return name
    End Function

    Private Sub SelectButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = DirectCast(sender, Button)
        If clickedButton.Enabled = False Then
            Return
        End If
        If selectedVendorButton IsNot Nothing Then
            selectedVendorButton.Enabled = True
        End If
        clickedButton.Enabled = False
        selectedVendorButton = clickedButton
        Dim lblSelectedVendor As Label = Me.Controls.Find("lblSelectedVendor", True).FirstOrDefault()
        If lblSelectedVendor IsNot Nothing Then
            lblSelectedVendor.Text = clickedButton.Tag.ToString()
            vendorServiceTags(currentIndex).ApprovedVendorSID = clickedButton.Tag.ToString()
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
