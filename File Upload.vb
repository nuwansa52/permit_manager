Imports System.Data.OleDb
Imports System.IO
Imports Spire.PdfViewer.Forms

Partial Public Class fileUpload
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection
    Public Property AxAcroPDF1 As Object

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim pdfDoc As String = "D:\michelle\e-iceblue\Spire.Office.pdf"


        fileViewer.adobePdfReader.src = pdfDoc
        fileViewer.Show()


    End Sub

    Function trackUpload(path, headerId)

        con = dbConn.dbConnect()

        Dim sdr As OleDbDataReader = findDetails(userNameInput.Text)

        If sdr.Read() Then
            MessageBox.Show("User Already In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sql As String = "INSERT INTO [system_user] ([user_name], [user_fname], [user_lname], [user_role], [ag_office_id], [department_id], [password])
                                VALUES(@userName, @userfName, @userlName, @userRole, @agOfficeId, @departmentId, @password)"

            If con.State = ConnectionState.Open Then
                Using sqlCom = New OleDbCommand(sql, con)
                    sqlCom.Parameters.Add("@userName", OleDbType.VarChar).Value = userNameInput.Text
                    sqlCom.Parameters.Add("@userfName", OleDbType.VarChar).Value = firstNameInput.Text
                    sqlCom.Parameters.Add("@userlName", OleDbType.VarChar).Value = lastNameInput.Text
                    sqlCom.Parameters.Add("@userRole", OleDbType.VarChar).Value = roleInput.SelectedItem.ToString
                    sqlCom.Parameters.Add("@agOfficeId", OleDbType.Numeric).Value = DirectCast(agOfficeInput.SelectedItem, KeyValuePair(Of Integer, String)).Key
                    sqlCom.Parameters.Add("@departmentId", OleDbType.Numeric).Value = DirectCast(departmentInput.SelectedItem, KeyValuePair(Of Integer, String)).Key
                    sqlCom.Parameters.Add("@password", OleDbType.VarChar).Value = passwordInput.Text
                    Dim icount As Integer = sqlCom.ExecuteNonQuery

                    If icount = 1 Then
                        MessageBox.Show("Successfully Saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None)
                    End If
                End Using
            Else
                MessageBox.Show("DB Connection Issue", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Function
End Class