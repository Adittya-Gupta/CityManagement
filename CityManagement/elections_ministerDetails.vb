Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics
Imports GemBox.Pdf
Imports Mysqlx.XDevAPI.Relational
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Controls
Imports System.Drawing.Drawing2D
Imports System.Windows.Media
Public Class elections_ministerDetails
    'Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim connString As String = Module1.connString
    Dim conn As New MySqlConnection(connString)
    Private SID As Integer
    Private vMargin As Integer
    Public Property NomineeName As String
        Get
            Return Name2.Text
        End Get
        Set(value As String)
            Name2.Text = value
        End Set
    End Property

    Public Property Designation As String
        Get
            Return Ministry.Text
        End Get
        Set(value As String)
            Ministry.Text = value
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
    Public Property NomineevMargin As Integer
        Get
            Return vMargin
        End Get
        Set(value As Integer)
            vMargin = value
        End Set
    End Property
    Private Sub OpenManifesto_Click(sender As Object, e As EventArgs) Handles OpenManifesto.Click
        Dim foundManifesto As Boolean = False
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
                    foundManifesto = True
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

        If foundManifesto = False Then
            MessageBox.Show("No Manifesto found for the requested candidate", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ministerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ministry.BackColor = System.Drawing.ColorTranslator.FromHtml("#fbfbfb")
        VictoryMargin.Text = vMargin.ToString()
        Try
            conn.Open()
            Dim query As String = "select VoteCount from Nominees where SID=@a"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@a", SID)
                Dim reader = cmd.ExecuteReader
                reader.Read()
                VoteCount.Text = Convert.ToString(reader("VoteCount"))
            End Using
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
        Try
            conn.Open()
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
End Class
