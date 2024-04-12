Imports MySql.Data.MySqlClient
Imports System.IO
Public Class organization_details
    Dim connString As String = "server=172.16.114.244;userid=admin;Password=nimda;database=smart_city_management;sslmode=none"
    Dim conn As New MySqlConnection(connString)
    Private organization_id As Integer = 1

    Public Property org_name As String
        Get
            Return Name2.Text
        End Get
        Set(value As String)
            Name2.Text = value
        End Set
    End Property

    Public Property org_ID As Integer
        Get
            Return organization_id
        End Get
        Set(value As Integer)
            organization_id = value
        End Set
    End Property

    Private Sub ministerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim query As String = "select pic from Institutes where ID = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", organization_id)
                Dim reader = cmd.ExecuteReader
                reader.Read()
                If Not reader.IsDBNull(reader.GetOrdinal("pic")) Then
                    Dim imageData As Byte() = DirectCast(reader("pic"), Byte())
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
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub profilePhoto_Click(sender As Object, e As EventArgs) Handles profilePhoto.Click
        Me.OnClick(e)
    End Sub

    Private Sub Name2_Click(sender As Object, e As EventArgs) Handles Name2.Click
        Me.OnClick(e)
    End Sub
End Class
