Imports System.Data.OleDb

Public Class depatment
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        saveDetails()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        saveDetails()
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        If departmentInput.Text <> "" Then
            Try
                Dim sdr As OleDbDataReader = findDetails(departmentInput.Text)

                If sdr.Read() Then

                    departmentInput.Text = sdr("description").ToString()

                Else
                    MessageBox.Show("Department Not Found", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please File Department Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If departmentInput.Text <> "" Then
            con = dbConn.dbConnect()

            Dim sdr As OleDbDataReader = findDetails(departmentInput.Text)

            If sdr.Read() Then
                Dim sql As String = "UPDATE [departments] SET [description] = @description WHERE [description] = @description"

                If con.State = ConnectionState.Open Then
                    Using sqlCom = New OleDbCommand(sql, con)
                        sqlCom.Parameters.Add("@description", OleDbType.VarChar).Value = departmentInput.Text

                        sqlCom.Parameters.Add("@description", OleDbType.VarChar).Value = departmentInput.Text

                        Dim icount As Integer = sqlCom.ExecuteNonQuery

                        If icount = 1 Then
                            MessageBox.Show("Successfully Saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None)
                        End If

                    End Using
                Else
                    MessageBox.Show("DB Connection Issue", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Department Already In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please File Department Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        Dim common As New Common()
        common.clearData(Me)
    End Sub

    Public Function findDetails(searchKey) As OleDb.OleDbDataReader
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'User Details Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [departments] WHERE [description] = @description", con)
                cmd.Parameters.Add("@description", searchKey)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                Return sdr

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function saveDetails() As Boolean
        If departmentInput.Text <> "" Then
            con = dbConn.dbConnect()

            Dim sdr As OleDbDataReader = findDetails(departmentInput.Text)

            If sdr.Read() Then
                MessageBox.Show("Department Already In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim sql As String = "INSERT INTO [departments] ([description]) VALUES(@description)"

                If con.State = ConnectionState.Open Then
                    Using sqlCom = New OleDbCommand(sql, con)
                        sqlCom.Parameters.Add("@description", OleDbType.VarChar).Value = departmentInput.Text
                        Dim icount As Integer = sqlCom.ExecuteNonQuery

                        If icount = 1 Then
                            MessageBox.Show("Successfully Saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None)
                        End If
                    End Using
                Else
                    MessageBox.Show("DB Connection Issue", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Else
            MessageBox.Show("Please File Department Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return True
    End Function

    Private Sub DistrictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistrictToolStripMenuItem.Click
        district.Show()
    End Sub

    Private Sub CityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CityToolStripMenuItem.Click
        city.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        customer.Show()
    End Sub

    Private Sub DivisionalSectretariatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivisionalSectretariatToolStripMenuItem.Click
        divisionalSecretariat.Show()
    End Sub

    Private Sub GramasewaWasamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GramasewaWasamToolStripMenuItem.Click
        gramaSewaWasama.Show()
    End Sub

    Private Sub PermitTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermitTypeToolStripMenuItem.Click
        permitType.Show()
    End Sub

    Private Sub SystemUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemUserToolStripMenuItem.Click
        systemUser.Show()
    End Sub

End Class