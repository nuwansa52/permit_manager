Imports System.Data.OleDb

Public Class city
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection

    Private Sub city_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'City Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT [district_id], [district_name] FROM [district]", con)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                Dim comboSource As New Dictionary(Of Integer, String)()

                While sdr.Read()
                    comboSource.Add(sdr("district_id").ToString, sdr("district_name").ToString)
                End While

                districtInput.DataSource = New BindingSource(comboSource, Nothing)
                districtInput.DisplayMember = "Value"
                districtInput.ValueMember = "Key"

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
            If cityInput.Text <> "" Then
                Dim sdr As OleDbDataReader = findDetails(cityInput.Text)

                If sdr.Read() Then

                    cityInput.Text = sdr("city_name").ToString()
                    districtInput.SelectedValue = sdr.Item("district_id")

                Else
                    MessageBox.Show("City Not Found", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please File City Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function findDetails(searchKey) As OleDb.OleDbDataReader
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'User Details Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [city] WHERE [city_name] = @cityName", con)
                cmd.Parameters.Add("@cityName", searchKey)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                Return sdr

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click

        If cityInput.Text <> "" Then
            con = dbConn.dbConnect()

            Dim sdr As OleDbDataReader = findDetails(cityInput.Text)

            If sdr.Read() Then
                Dim sql As String = "UPDATE [city] SET [city_name] = @cityName, [district_id] = @districtId WHERE [city_name] = @cityName"

                If con.State = ConnectionState.Open Then
                    Using sqlCom = New OleDbCommand(sql, con)
                        sqlCom.Parameters.Add("@cityName", OleDbType.VarChar).Value = cityInput.Text
                        sqlCom.Parameters.Add("@districtId", OleDbType.Numeric).Value = DirectCast(districtInput.SelectedItem, KeyValuePair(Of Integer, String)).Key

                        sqlCom.Parameters.Add("@cityName", OleDbType.VarChar).Value = cityInput.Text

                        Dim icount As Integer = sqlCom.ExecuteNonQuery

                        If icount = 1 Then
                            MessageBox.Show("Successfully Saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None)
                        End If

                    End Using
                Else
                    MessageBox.Show("DB Connection Issue", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("City Already In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please File City Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        Dim common As New Common()
        common.clearData(Me)
    End Sub

    Private Function saveDetails() As Boolean
        If cityInput.Text <> "" Then
            con = dbConn.dbConnect()

            Dim sdr As OleDbDataReader = findDetails(cityInput.Text)

            If sdr.Read() Then
                MessageBox.Show("City Already In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim sql As String = "INSERT INTO [city] ([district_id], [city_name]) VALUES(@districtId, @cityName)"

                If con.State = ConnectionState.Open Then
                    Using sqlCom = New OleDbCommand(sql, con)
                        sqlCom.Parameters.Add("@districtId", OleDbType.Numeric).Value = DirectCast(districtInput.SelectedItem, KeyValuePair(Of Integer, String)).Key
                        sqlCom.Parameters.Add("@userName", OleDbType.VarChar).Value = cityInput.Text
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
            MessageBox.Show("Please File City Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return True
    End Function

    Private Sub DistrictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistrictToolStripMenuItem.Click
        district.Show()
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

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        depatment.Show()
    End Sub

    Private Sub PermitTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermitTypeToolStripMenuItem.Click
        permitType.Show()
    End Sub

    Private Sub SystemUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemUserToolStripMenuItem.Click
        systemUser.Show()
    End Sub

End Class