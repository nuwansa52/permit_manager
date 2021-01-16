Imports System.Data.OleDb

Public Class gramaSewaWasama
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection

    Private Sub city_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'City Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT [ag_office_id], [description] FROM [ag_office]", con)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                Dim comboSource As New Dictionary(Of Integer, String)()

                While sdr.Read()
                    comboSource.Add(sdr("ag_office_id").ToString, sdr("description").ToString)
                End While

                divisionalSecretariatInput.DataSource = New BindingSource(comboSource, Nothing)
                divisionalSecretariatInput.DisplayMember = "Value"
                divisionalSecretariatInput.ValueMember = "Key"

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        saveDetails()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        saveDetails()
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Try
            Dim sdr As OleDbDataReader = findDetails(gramasewaWasInput.Text)

            If sdr.Read() Then

                gramasewaWasInput.Text = sdr("gw_wasama").ToString()
                divisionalSecretariatInput.SelectedValue = sdr.Item("ag_office_id")

            Else
                MessageBox.Show("Gramasewa Wasama Not Found", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function findDetails(searchKey) As OleDb.OleDbDataReader
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'User Details Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [gramsewa_wasam] WHERE [gw_wasama] = @gwWasama", con)
                cmd.Parameters.Add("@gwWasama", searchKey)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                Return sdr

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        con = dbConn.dbConnect()

        Dim sdr As OleDbDataReader = findDetails(gramasewaWasInput.Text)

        If sdr.Read() Then
            Dim sql As String = "UPDATE [gramsewa_wasam] SET [gw_wasama] = @gwWasama, [ag_office_id] = @agOfficeId WHERE [gw_wasama] = @gwWasama"

            If con.State = ConnectionState.Open Then
                Using sqlCom = New OleDbCommand(sql, con)
                    sqlCom.Parameters.Add("@gwWasama", OleDbType.VarChar).Value = gramasewaWasInput.Text
                    sqlCom.Parameters.Add("@agOfficeId", OleDbType.Numeric).Value = DirectCast(divisionalSecretariatInput.SelectedItem, KeyValuePair(Of Integer, String)).Key

                    sqlCom.Parameters.Add("@gwWasama", OleDbType.VarChar).Value = gramasewaWasInput.Text

                    Dim icount As Integer = sqlCom.ExecuteNonQuery

                    If icount = 1 Then
                        MessageBox.Show("Successfully Saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None)
                    End If

                End Using
            Else
                MessageBox.Show("DB Connection Issue", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Gramasewa Wasama Already In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        Dim common As New Common()
        common.clearData(Me)
    End Sub

    Private Function saveDetails() As Boolean
        con = dbConn.dbConnect()

        Dim sdr As OleDbDataReader = findDetails(divisionalSecretariatInput.Text)

        If sdr.Read() Then
            MessageBox.Show("Gramasewa Wasama Already In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sql As String = "INSERT INTO [gramsewa_wasam] ([ag_office_id], [gw_wasama]) VALUES(@agOfficeId, @gwWasama)"

            If con.State = ConnectionState.Open Then
                Using sqlCom = New OleDbCommand(sql, con)
                    sqlCom.Parameters.Add("@agOfficeId", OleDbType.Numeric).Value = DirectCast(divisionalSecretariatInput.SelectedItem, KeyValuePair(Of Integer, String)).Key
                    sqlCom.Parameters.Add("@gwWasama", OleDbType.VarChar).Value = gramasewaWasInput.Text
                    Dim icount As Integer = sqlCom.ExecuteNonQuery

                    If icount = 1 Then
                        MessageBox.Show("Successfully Saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None)
                    End If
                End Using
            Else
                MessageBox.Show("DB Connection Issue", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            Return True
        End If
    End Function
    Private Sub SystemUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemUserToolStripMenuItem.Click
        systemUser.Show()
    End Sub
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

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        depatment.Show()
    End Sub

    Private Sub PermitTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermitTypeToolStripMenuItem.Click
        permitType.Show()
    End Sub

    Private Sub gramaSewaWasama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class