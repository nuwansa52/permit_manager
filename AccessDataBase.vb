Public Class AccessDataBase
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=permit_manager.accdb")

    Function dbConnect() As OleDb.OleDbConnection

        Try

            If con.State = ConnectionState.Open Then
                Return con
            Else
                con.Open()
                Return con
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return con
        End Try

    End Function
End Class
