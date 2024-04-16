Imports System.IO

Public Class IncomingDetailsForm
    Private _userID As Int32
    Private _orgID As Int32

    Public Sub New(Optional ByVal contactDetails As String = "Contact Details",
               Optional ByVal bankAccountNumber As String = "Bank account number",
               Optional ByVal anyPreviousWork As String = "Any previous work",
               Optional ByVal userID As Int32 = 102,
               Optional ByVal orgID As Int32 = 101
               )

        InitializeComponent()
        _userID = userID
        _orgID = orgID

        Me.FormBorderStyle = FormBorderStyle.None

        RichTextBox1.Text = contactDetails
        RichTextBox2.Text = bankAccountNumber
        RichTextBox3.Text = anyPreviousWork

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connString As String = Module1.connString
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT resume FROM workerEmployReq WHERE userID = @SID AND orgID = @orgID", conn)
                cmd.Parameters.AddWithValue("@SID", _userID)
                cmd.Parameters.AddWithValue("@orgID", _orgID)
                Dim resume_ As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
                If resume_ IsNot Nothing Then
                    ' Generate a unique temporary file name with .pdf extension in the temp folder
                    Dim tempPdfFilePath As String = Path.Combine(Application.StartupPath, "..\..\..\MediaFiles\EmpReqResume", _orgID.ToString() & "--" & _userID.ToString() & "--resume.pdf")

                    ' Write the binary data to the temporary PDF file
                    File.WriteAllBytes(tempPdfFilePath, resume_)
                    MessageBox.Show("PDF downloaded in  " & tempPdfFilePath)

                Else
                    MessageBox.Show("Resume not found for SID: " & _userID)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class