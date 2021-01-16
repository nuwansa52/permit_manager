Imports System.Data.OleDb

Public Class divisionalSecretariat
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection

    Private Sub divisionalSecretariat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'City Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT [city_id], [city_name] FROM [city]", con)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                Dim comboSource As New Dictionary(Of Integer, String)()

                While sdr.Read()
                    comboSource.Add(sdr("city_id").ToString, sdr("city_name").ToString)
                End While

                cityInput.DataSource = New BindingSource(comboSource, Nothing)
                cityInput.DisplayMember = "Value"
                cityInput.ValueMember = "Key"

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs)
        saveDetails()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        saveDetails()
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        If divisionalSecInput.Text <> "" Then
            Try
                Dim sdr As OleDbDataReader = findDetails(cityInput.Text)

                If sdr.Read() Then

                    divisionalSecInput.Text = sdr("description").ToString()
                    cityInput.SelectedValue = sdr.Item("city_id")

                Else
                    MessageBox.Show("Divisional Secretariat Not Found", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Please File Divisional Secretariat Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Function findDetails(searchKey) As OleDb.OleDbDataReader
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'User Details Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [ag_office] WHERE [description] = @description", con)
                cmd.Parameters.Add("@description", searchKey)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                Return sdr

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If divisionalSecInput.Text <> "" Then
            con = dbConn.dbConnect()

            Dim sdr As OleDbDataReader = findDetails(cityInput.Text)

            If sdr.Read() Then
                Dim sql As String = "UPDATE [ag_office] SET [description] = @description, [city_id] = @city_id WHERE [description] = @description"

                If con.State = ConnectionState.Open Then
                    Using sqlCom = New OleDbCommand(sql, con)
                        sqlCom.Parameters.Add("@description", OleDbType.VarChar).Value = cityInput.Text
                        sqlCom.Parameters.Add("@cityId", OleDbType.Numeric).Value = DirectCast(cityInput.SelectedItem, KeyValuePair(Of Integer, String)).Key

                        sqlCom.Parameters.Add("@description", OleDbType.VarChar).Value = cityInput.Text

                        Dim icount As Integer = sqlCom.ExecuteNonQuery

                        If icount = 1 Then
                            MessageBox.Show("Successfully Saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None)
                        End If

                    End Using
                Else
                    MessageBox.Show("DB Connection Issue", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Divisional Secretariat Not In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please File Divisional Secretariat Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        Dim common As New Common()
        common.clearData(Me)
    End Sub

    Private Function saveDetails() As Boolean
        If divisionalSecInput.Text <> "" Then
            con = dbConn.dbConnect()

            Dim sdr As OleDbDataReader = findDetails(cityInput.Text)

            If sdr.Read() Then
                MessageBox.Show("Divisional Secretariat Already In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim sql As String = "INSERT INTO [ag_office] ([city_id], [description]) VALUES(@cityId, @description)"

                If con.State = ConnectionState.Open Then
                    Using sqlCom = New OleDbCommand(sql, con)
                        sqlCom.Parameters.Add("@cityId", OleDbType.Numeric).Value = DirectCast(cityInput.SelectedItem, KeyValuePair(Of Integer, String)).Key
                        sqlCom.Parameters.Add("@description", OleDbType.VarChar).Value = cityInput.Text
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
            MessageBox.Show("Please File Divisional Secretariat Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return True
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

    Private Sub GramasewaWasamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GramasewaWasamToolStripMenuItem.Click
        gramaSewaWasama.Show()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        depatment.Show()
    End Sub

    Private Sub PermitTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermitTypeToolStripMenuItem.Click
        permitType.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem1.Click
        customer.Show()
    End Sub

    Private Sub IssuePermitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssuePermitToolStripMenuItem.Click
        permitHeader.Show()
    End Sub
End Class