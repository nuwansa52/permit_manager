Imports System.IO

Public Class AccessDataBase

    'Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Directory.GetCurrentDirectory.ToString.Replace("\bin\Debug", "") & "\permit_manager.accdb")
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\permit_manager.accdb")

    Function dbConnect() As OleDb.OleDbConnection
        Try

            If con.State = ConnectionState.Open Then
                Return con
            Else
                con.Open()
                Return con
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return con
        End Try

    End Function
End Class
