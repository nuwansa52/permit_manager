Imports System.Data.OleDb

Public Class systemUser
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection

    Private Sub systemUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                agOfficeInput.DataSource = New BindingSource(comboSource, Nothing)
                agOfficeInput.DisplayMember = "Value"
                agOfficeInput.ValueMember = "Key"

                'Department
                Dim cmd1 As OleDbCommand = New OleDbCommand("SELECT [department_id], [description] FROM [departments]", con)
                Dim sdr1 As OleDbDataReader = cmd1.ExecuteReader(CommandBehavior.CloseConnection)
                Dim comboSource1 As New Dictionary(Of Integer, String)()

                While sdr.Read()
                    comboSource.Add(sdr("department_id").ToString, sdr("description").ToString)
                End While

                departmentInput.DataSource = New BindingSource(comboSource, Nothing)
                departmentInput.DisplayMember = "Value"
                departmentInput.ValueMember = "Key"

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
        If userNameInput.Text <> "" Then
            Try
                Dim sdr As OleDbDataReader = findDetails(userNameInput.Text)

                If sdr.Read() Then

                    userNameInput.Text = sdr("user_name").ToString()
                    firstNameInput.Text = sdr("user_fname").ToString()
                    lastNameInput.Text = sdr("user_lname").ToString()
                    roleInput.SelectedIndex = roleInput.FindString(sdr.Item("user_role").ToString()).ToString()
                    agOfficeInput.SelectedValue = sdr.Item("ag_office_id")
                    departmentInput.SelectedValue = sdr.Item("department_id")
                    passwordInput.Text = sdr("password").ToString()

                Else
                    MessageBox.Show("User Not Found", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Please File User Name Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If userNameInput.Text <> "" Then
            con = dbConn.dbConnect()

            Dim sdr As OleDbDataReader = findDetails(userNameInput.Text)

            If sdr.Read() Then
                Dim sql As String = "UPDATE [system_user] SET [user_fname] = @userfName, [user_lname] = @userlName, [user_role] =  @userRole, [ag_office_id] = @agOfficeId,
                                [department_id] = @departmentId, [password] = @password WHERE [user_name] = @userName"

                If con.State = ConnectionState.Open Then
                    Using sqlCom = New OleDbCommand(sql, con)
                        sqlCom.Parameters.Add("@userfName", OleDbType.VarChar).Value = firstNameInput.Text
                        sqlCom.Parameters.Add("@userlName", OleDbType.VarChar).Value = lastNameInput.Text
                        sqlCom.Parameters.Add("@userRole", OleDbType.VarChar).Value = roleInput.SelectedItem.ToString
                        sqlCom.Parameters.Add("@agOfficeId", OleDbType.Numeric).Value = DirectCast(agOfficeInput.SelectedItem, KeyValuePair(Of Integer, String)).Key
                        sqlCom.Parameters.Add("@departmentId", OleDbType.Numeric).Value = DirectCast(departmentInput.SelectedItem, KeyValuePair(Of Integer, String)).Key
                        sqlCom.Parameters.Add("@password", OleDbType.VarChar).Value = passwordInput.Text

                        sqlCom.Parameters.Add("@userName", OleDbType.VarChar).Value = userNameInput.Text

                        Dim icount As Integer = sqlCom.ExecuteNonQuery

                        If icount = 1 Then
                            MessageBox.Show("Successfully Saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None)
                        End If

                    End Using
                Else
                    MessageBox.Show("DB Connection Issue", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("User Not In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please File User Name Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [system_user] WHERE [user_name] = @userName", con)
                cmd.Parameters.Add("@userName", searchKey)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                Return sdr

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function saveDetails() As Boolean
        If userNameInput.Text <> "" Then
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
        Else
            MessageBox.Show("Please File User Name Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        department.Show()
    End Sub

    Private Sub PermitTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermitTypeToolStripMenuItem.Click
        permitType.Show()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        department.Show()
    End Sub

End Class