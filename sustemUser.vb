Imports System.Data.OleDb

Public Class systemUser
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection

    Private Sub systemUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then

                Dim cmd As OleDbCommand = New OleDbCommand("SELECT [ag_office_id], [description] FROM [ag_office]", con)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                Dim comboSource As New Dictionary(Of String, String)()

                While sdr.Read()
                    comboSource.Add(sdr("ag_office_id").ToString, sdr("description").ToString)
                End While

                agOfficeInput.DataSource = New BindingSource(comboSource, Nothing)
                agOfficeInput.DisplayMember = "Value"
                agOfficeInput.ValueMember = "Key"

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs)

        con = dbConn.dbConnect()

        Dim value As String = DirectCast(roleInput.SelectedItem, KeyValuePair(Of String, String)).Value

        Dim sql As String = "INSERT INTO [system_user] VALUES(@id, @userName, @fName, @lName, @userRole, @userDept)"

        If con.State = ConnectionState.Open Then
            Using sqlCom = New OleDbCommand(sql, con)
                sqlCom.Parameters.Add("@id", OleDbType.VarWChar).Value = 3
                sqlCom.Parameters.Add("@userName", OleDbType.VarWChar).Value = value
                sqlCom.Parameters.Add("@fName", OleDbType.VarWChar).Value = value
                sqlCom.Parameters.Add("@lName", OleDbType.VarWChar).Value = value
                sqlCom.Parameters.Add("@userRole", OleDbType.VarWChar).Value = value
                sqlCom.Parameters.Add("@userDept", OleDbType.VarWChar).Value = value
                Dim icount As Integer = sqlCom.ExecuteNonQuery
            End Using
        End If
    End Sub
    Private Sub DistrictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistrictToolStripMenuItem.Click
        district.Show()
    End Sub
End Class