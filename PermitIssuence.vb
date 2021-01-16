Imports System.Data.OleDb
Imports PdfSharp.Pdf
Imports Spire.Pdf.Grid

Public Class PermitIssuence
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = dbConn.dbConnect()

        Dim sql As String

        sql = "SELECT per_appication_no AS [Application No], per_transport_from AS [Transport From], per_transport_to AS [Transport To], per_transport_date_from AS [Transport Date From],
                    per_transport_date_to As [Transport Date To], per_vehicle_no As [Vehicle No], user_name As [Created User], per_created_on As [Created Date]
               FROM [permit_header]
               INNER JOIN [system_user] ON [permit_header].[per_created_by] = [system_user].[user_id]
               WHERE [per_created_on] BETWEEN '" & DateTimePicker2.Value.ToString("yyyy/MM/dd HH:mm:ss") & "' AND '" & DateTimePicker1.Value.ToString("yyyy/MM/dd HH:mm:ss") & "'"


        Dim adapter As New OleDbDataAdapter(sql, con)

        Dim dt As New DataTable("system_user")

        adapter.Fill(dt)

        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Create a new PDF document
        Dim doc As PdfDocument = New PdfDocument()

        'Add a page
        Dim page As PdfPage = doc.Pages.Add()

        'Create a PdfGrid
        Dim pdfGrid As PdfGrid = New PdfGrid()

        'Create a DataTable
        Dim dataTable As DataTable = GetDataTable()

        'Assign data source
        pdfGrid.DataSource = dataTable

        'Initialize grid style.
        Dim gridStyle As PdfGridStyle = New PdfGridStyle()

        'Add cell padding.
        gridStyle.CellPadding = New PdfPaddings(5, 5, 5, 5)

        'Apply style to grid.
        pdfGrid.Style = gridStyle

        'Draw grid to the page of PDF document
        pdfGrid.Draw(page, New PointF(10, 10))

        'Save the document
        doc.Save("Output.pdf")

        'Close the document
        doc.Close(True)
    End Sub
End Class