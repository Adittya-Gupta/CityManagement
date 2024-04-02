Imports System.Windows.Forms
Imports CityManagement.Event_OfferService
Imports MySql.Data.MySqlClient

Public Class FestivalEvents_ChooseVendor
    Private selectedVendorButton As Button ' Tracks the currently selected vendor button
    Public vendorServiceTags As List(Of VendorServiceTag)
    Private currentIndex As Integer
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    ' Constructor to initialize the form with the list of VendorServiceTag objects and the current index
    Public Sub New(ByVal serviceTags As List(Of VendorServiceTag), ByVal index As Integer)
        InitializeComponent()
        Me.vendorServiceTags = serviceTags
        Me.currentIndex = index
    End Sub
    'Dim vendorServiceTags(currentIndex) As VendorServiceTag = vendorServiceTags(currentIndex)

    Private Sub FestivalEvents_ChooseVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Simulated list of vendors and their requests

        ' Set up the selected vendor label
        Dim lblSelected As New Label()
        lblSelected.Text = "Selected:"
        lblSelected.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold)
        lblSelected.AutoSize = True
        lblSelected.Location = New Point(10, 40)
        Me.Controls.Add(lblSelected)

        Dim lblSelectedVendor As New Label()
        lblSelectedVendor.Name = "lblSelectedVendor"
        If vendorServiceTags(currentIndex).ApprovedVendorSID Is Nothing Then
            lblSelectedVendor.Text = "Not Selected"
        Else
            lblSelectedVendor.Text = vendorServiceTags(currentIndex).ApprovedVendorSID
        End If
        lblSelectedVendor.Font = New Font(FontFamily.GenericSansSerif, 10)
        lblSelectedVendor.AutoSize = True
        lblSelectedVendor.Location = New Point(130, 40)
        Me.Controls.Add(lblSelectedVendor)

        Dim lblRequests As New Label()
        lblRequests.Text = "Requests:"
        lblRequests.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold)
        lblRequests.AutoSize = True
        lblRequests.Location = New Point(10, 70)
        Me.Controls.Add(lblRequests)

        ' Add Panel1
        Dim Panel1 As New Panel()
        Panel1.Location = New Point(10, 100)
        Panel1.Size = New Size(600, 300) ' Set the initial size of the panel
        Panel1.AutoScroll = True ' Enable auto-scrolling
        Panel1.BackColor = SystemColors.Control ' Set the background color to grey
        Me.Controls.Add(Panel1)

        ' Add vendor buttons inside Panel1
        Dim yPos As Integer = 0 ' Starting Y position for the vendor buttons
        For Each vendor As String In vendorServiceTags(currentIndex).ListofVendorSIDs
            Dim lblVendor As New Label()
            lblVendor.Text = vendor
            lblVendor.Font = New Font(FontFamily.GenericSansSerif, 12)
            lblVendor.AutoSize = True
            lblVendor.Location = New Point(10, yPos)

            Dim selectButton As New Button()
            selectButton.Text = "Select"
            selectButton.AutoSize = True
            selectButton.Location = New Point(lblVendor.Right + 50, yPos)
            selectButton.FlatStyle = FlatStyle.Flat ' Remove the border
            selectButton.Tag = vendor ' Set the vendor name as the Tag of the button
            selectButton.BackColor = Color.Black ' Set background color to black
            selectButton.ForeColor = Color.White ' Set foreground color to white

            AddHandler selectButton.Click, AddressOf SelectButton_Click

            Panel1.Controls.Add(lblVendor)
            Panel1.Controls.Add(selectButton)

            yPos += lblVendor.Height + 8
        Next
    End Sub

    Private Sub SelectButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = DirectCast(sender, Button)
        If clickedButton.Enabled = False Then
            Return
        End If
        ' If a vendor was previously selected, reset its appearance
        If selectedVendorButton IsNot Nothing Then
            selectedVendorButton.Enabled = True
        End If

        ' Mark the clicked vendor as selected
        clickedButton.Enabled = False
        selectedVendorButton = clickedButton

        ' Update the selected vendor label
        Dim lblSelectedVendor As Label = Me.Controls.Find("lblSelectedVendor", True).FirstOrDefault()
        If lblSelectedVendor IsNot Nothing Then
            lblSelectedVendor.Text = clickedButton.Tag.ToString()
            vendorServiceTags(currentIndex).ApprovedVendorSID = clickedButton.Tag.ToString()
            'Try
            '    conn.Open()
            '    Dim query As String = "UPDATE festivals SET vendor_service_tags = @ServiceTags WHERE name = @CurrEvent"
            '    Using cmd As New MySqlCommand(query, conn)
            '        ' Serialize the updated vendorServiceTags list to JSON
            '        Dim serviceTagsJson As String = Newtonsoft.Json.JsonConvert.SerializeObject(vendorServiceTags)
            '        cmd.Parameters.AddWithValue("@ServiceTags", serviceTagsJson)
            '        cmd.Parameters.AddWithValue("@CurrEvent", Module1.CurrEvent)
            '        cmd.ExecuteNonQuery()
            '    End Using
            'Catch ex As Exception
            '    MessageBox.Show("Error updating ApprovedVendorSID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Finally
            '    conn.Close()
            'End Try
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
