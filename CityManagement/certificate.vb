Imports System.IO
Imports System.Reflection.Metadata
Imports Microsoft.VisualBasic.ApplicationServices
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf


Public Class certificate
    Private username As String
    Private institutename As String
    Private course1 As String
    Private userid As Integer

    Public Sub SetUserID(id As Integer)
        userid = id
    End Sub

    Public Sub SetUserName(id As String)
        course1 = id
    End Sub
    Public Sub SetcourcetName(id As String)
        username = id
    End Sub

    Public Sub SetInstName(id As String)
        institutename = id
    End Sub
    Private Sub certificate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Me.Size = New Size(1107, 760)
        Me.HorizontalScroll.Maximum = 0

        ' Dim imagePath As String = "C:\Users\vanit\OneDrive\Desktop\DEV\t1.jpg"
        PictureBox1.Size = New Size(900, 550)
        PictureBox1.Location = New Point(70, 70)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Try
            'PictureBox1.BackgroundImage = CType(Resources.GetObject("PictureBox1.BackgroundImage"), Image)
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message)
        End Try
        Dim name As New Label
        Dim course As New Label
        Dim Prof As New Label
        name.Text = username
        Prof.Text = "Professor_name"
        Prof.Size = New Size()
        course.Text = "This is to certify that " & name.Text & " has successfully completed the " & course1 & " course."

        name.Font = New Font("Arial", 20, FontStyle.Bold)
        name.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        course.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        name.Location = New Point(150, 220)
        course.MaximumSize = New Size(600, 0)
        course.Location = New Point(175, 310)
        course.AutoSize = True
        course.TextAlign = ContentAlignment.MiddleCenter
        name.Size = New Size(600, 50)
        name.TextAlign = ContentAlignment.MiddleCenter
        Dim preferredSize As Size = TextRenderer.MeasureText(course.Text, course.Font)
        course.Size = New Size(Math.Min(preferredSize.Width, course.MaximumSize.Width), preferredSize.Height)

        PictureBox1.Controls.Add(name)
        PictureBox1.Controls.Add(course)
        Dim btn As New System.Windows.Forms.Button
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = ColorTranslator.FromHtml("#1AE879")
        btn.Font = New Font("Arial", 12)
        btn.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#1AE879")
        btn.Size = New Size(150, 40)
        btn.Location = New Point(450, 650)
        btn.Text = "Download"
        btn.TextAlign = ContentAlignment.TopCenter
        AddHandler btn.Click, AddressOf btnPrint_Click
        Me.Controls.Add(btn)
        ' Bring labels to front
        name.BringToFront()
        course.BringToFront()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PDF files (*.pdf)|*.pdf"
            saveDialog.FilterIndex = 2
            saveDialog.RestoreDirectory = True

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using printDocument As New Printing.PrintDocument()
                    AddHandler printDocument.PrintPage, Sub(senderPrintDoc, args)
                                                            Dim memoryImage As New Bitmap(PictureBox1.Width, PictureBox1.Height)
                                                            PictureBox1.DrawToBitmap(memoryImage, New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height))
                                                            args.Graphics.DrawImage(memoryImage, 0, 0)
                                                        End Sub

                    Dim printFileName As String = Path.GetTempFileName()

                    printDocument.PrinterSettings.PrintFileName = printFileName

                    printDocument.Print()

                    File.Move(printFileName, saveDialog.FileName)

                    MessageBox.Show("PDF saved successfully.")
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error saving PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        mypanel.panel1.Controls.Clear()
        Dim form As New student_dashboard()
        form.SetUserID(userid)
        form.TopLevel = False
        mypanel.panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
