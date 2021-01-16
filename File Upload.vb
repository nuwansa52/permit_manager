Imports System.Drawing.Printing
Imports System.IO

Public Class fileUpload
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

    Private WithEvents docPrint As New PrintDocument()
    ' Declare a string to hold the entire document contents. 
    ' Declare a string to hold the entire document contents. 
    Private documentContents As String

    ' Declare a variable to hold the portion of the document that 
    ' is not printed. 
    Private stringToPrint As String
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Dim e As New PrintPageEventArgs
        Dim docName As String = "C:\Users\Nuwan\Downloads\Fernando_K.A.M.S.W_E1641032.pdf"

        ' docPrint.DocumentName = docName

        Dim stream As New FileStream(docName, FileMode.Open)
        Try
            Dim reader As New StreamReader(stream)
            Try
                documentContents = reader.ReadToEnd()
                stringToPrint = documentContents
            Finally
                reader.Dispose()
            End Try
        Finally
            stream.Dispose()
        End Try


        PrintPreviewDialog1.Document = docPrint
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub


    Private Sub PrintPreviewDialog1_Load(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles docPrint.PrintPage
        Dim charactersOnPage As Integer = 0
        Dim linesPerPage As Integer = 0

        ' Sets the value of charactersOnPage to the number of characters  
        ' of stringToPrint that will fit within the bounds of the page.
        e.Graphics.MeasureString(stringToPrint, Me.Font, e.MarginBounds.Size,
        StringFormat.GenericTypographic, charactersOnPage, linesPerPage)
        MsgBox("LL")
        ' Draws the string within the bounds of the page.
        e.Graphics.DrawString(stringToPrint, Me.Font, Brushes.Black,
            e.MarginBounds, StringFormat.GenericTypographic)

        ' Remove the portion of the string that has been printed.
        stringToPrint = stringToPrint.Substring(charactersOnPage)

        ' Check to see if more pages are to be printed.
        e.HasMorePages = stringToPrint.Length > 0

        ' If there are no more pages, reset the string to be printed. 
        If Not e.HasMorePages Then
            stringToPrint = documentContents
        End If
    End Sub
End Class