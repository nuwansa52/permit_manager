Imports System.Data.OleDb
Imports System.IO
Imports Spire.PdfViewer.Forms

Partial Public Class fileUpload
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection
    Public Property AxAcroPDF1 As Object

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DOC1UPL.Click
        Dim filePath As String
        Dim newFilePath As String

        OpenFileDialog1.Title = "Please select a file"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "file|*.pdf"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'Get the path of specified file
            filePath = OpenFileDialog1.FileName
            MsgBox(filePath)

            newFilePath = "D:\\Permit Manager\" & permitHeader.applicationNumberInput.Text
            If Directory.Exists(newFilePath) = False Then
                My.Computer.FileSystem.CreateDirectory(newFilePath)
            End If

            File.Copy(filePath, newFilePath & "\" & OpenFileDialog1.SafeFileName, True)

        End If
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles DOC2ViEW.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles DOC1ViEW.Click
        Dim pdfDoc As String = "D:\michelle\e-iceblue\Spire.Office.pdf"


        fileViewer.adobePdfReader.src = pdfDoc
        fileViewer.Show()


    End Sub

    Function trackUpload(path, headerId, code)

        con = dbConn.dbConnect()

        Dim sql As String = "INSERT INTO [upload_document] ([per_id], [doc_code], [doc_saved_path], [doc_uploaded_user], [doc_uploaded_date])
                                VALUES(@perId, @docCode, @docSavedPath, @docUploadedUser, @docUploadedDate)"

        If con.State = ConnectionState.Open Then
            Using sqlCom = New OleDbCommand(sql, con)

                sqlCom.Parameters.Add("@perId", OleDbType.VarChar).Value = permitHeader.permitId.Text
                sqlCom.Parameters.Add("@docCode", OleDbType.VarChar).Value = code
                sqlCom.Parameters.Add("@docSavedPath", OleDbType.VarChar).Value = path
                sqlCom.Parameters.Add("@docUploadedUser", OleDbType.VarChar).Value = Common.userId
                sqlCom.Parameters.Add("@docUploadedDate", OleDbType.Numeric).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

                Dim icount As Integer = sqlCom.ExecuteNonQuery

                If icount = 1 Then
                    MessageBox.Show("Successfully Saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None)
                End If
            End Using
        End If

    End Function
End Class