Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics
Imports GemBox.Pdf
Imports System.Windows.Controls
Imports System.Drawing.Drawing2D
Public Class candidateDetails

    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim connString As String = Globals.connectionstring
    Dim conn As New MySqlConnection(connString)
    Private SID As Integer
    Public Property NomineeName As String
        Get
            Return Name2.Text
        End Get
        Set(value As String)
            Name2.Text = value
        End Set
    End Property
    Public Property NomineeSID As Integer
        Get
            Return SID
        End Get
        Set(value As Integer)
            SID = value
        End Set
    End Property
    Public Property AgendaContent As String
        Get
            Return Agenda.Text
        End Get
        Set(value As String)
            Agenda.Text = value
        End Set
    End Property

    Public Property Checked As Boolean
        Get
            Return CheckBox.Checked
        End Get
        Set(value As Boolean)
            CheckBox.Checked = value
        End Set
    End Property
    ' Event to notify MainForm when CheckBox state changes
    Public Event CheckBoxCheckedChanged(sender As Object, e As EventArgs)
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox.CheckedChanged
        ' Raise the CheckBoxCheckedChanged event
        RaiseEvent CheckBoxCheckedChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub OpenManifesto_Click(sender As Object, e As EventArgs) Handles OpenManifesto.Click
        Try
            conn.Open()
            Dim query As String = "select Manifesto from Nominees where SID=@a"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@a", SID)
                Dim pdfData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
                'MessageBox.Show(pdfData.ToString)
                If pdfData IsNot Nothing AndAlso pdfData.Length > 0 Then
                    ' Specify the custom temporary file path
                    Dim folderPath As String = Application.StartupPath ' Specify an existing directory
                    Dim tempFilePath As String = Path.Combine(folderPath, "manifesto.pdf")
                    MessageBox.Show("The requested Manifesto is saved at " & tempFilePath, "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Create directory if it doesn't exist
                    If Not Directory.Exists(folderPath) Then
                        Directory.CreateDirectory(folderPath)
                    End If
                    ' Save PDF data to the custom temporary file
                    File.WriteAllBytes(tempFilePath, pdfData)

                    ' Load PDF document using GemBox.Pdf
                    Using document = PdfDocument.Load(tempFilePath)

                        ' Get viewer preferences specifying the way the document should be displayed on the screen.
                        Dim ViewerPreferences = document.ViewerPreferences

                        ' Modify viewer preferences.
                        ViewerPreferences.CenterWindow = False
                        ViewerPreferences.FitWindow = True
                        ViewerPreferences.HideMenubar = True
                        ViewerPreferences.HideToolbar = False
                        ViewerPreferences.NonFullScreenPageMode = PdfPageMode.FullScreen
                        ViewerPreferences.ViewArea = PdfPageBoundaryType.MediaBox

                        ' Save modified PDF document
                        Dim outputPath As String = Path.Combine(Path.GetTempPath(), "ViewerPreferences.pdf")
                        document.Save(outputPath)

                        ' Open the modified PDF document
                        Process.Start(outputPath)
                    End Using
                Else
                    MessageBox.Show("No Manifesto found for the requested candidate", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception

        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub candidateDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Agenda.BackColor = System.Drawing.ColorTranslator.FromHtml("#fbfbfb")
            Dim query As String = "select ProfilePic from User where SID=@a"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@a", SID)
                Dim reader = cmd.ExecuteReader
                reader.Read()
                If Not reader.IsDBNull(reader.GetOrdinal("ProfilePic")) Then
                    Dim imageData As Byte() = DirectCast(reader("ProfilePic"), Byte())
                    Dim imageStream As New MemoryStream(imageData)
                    Dim profileImage As Bitmap = Bitmap.FromStream(imageStream)
                    profilePhoto.Image = profileImage
                    profilePhoto.SizeMode = PictureBoxSizeMode.StretchImage
                    'Dim circularRegion As New Region(New Rectangle(0, 0, profilePhoto.Width, profilePhoto.Height))
                    'Dim graphicsPath As New GraphicsPath()
                    'graphicsPath.AddEllipse(0, 0, profilePhoto.Width, profilePhoto.Height)
                    'circularRegion.Exclude(graphicsPath)
                    '' Apply circular region to the PictureBox
                    'profilePhoto.Region = circularRegion
                Else
                End If
            End Using
        Catch ex As Exception

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles OpenManifesto.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        OpenManifesto.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles OpenManifesto.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        OpenManifesto.Cursor = Cursors.Default
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles CheckBox.MouseEnter
        ' Change mouse cursor to hand when hovering over the label
        CheckBox.Cursor = Cursors.Hand
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles CheckBox.MouseLeave
        ' Reset mouse cursor to default when leaving the label
        CheckBox.Cursor = Cursors.Default
    End Sub
End Class
