Imports System.Data.OleDb

Public Class customer
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection

    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                cityComboBox.DataSource = New BindingSource(comboSource, Nothing)
                cityComboBox.DisplayMember = "Value"
                cityComboBox.ValueMember = "Key"

                'Gramasewa Wasama
                Dim cmd1 As OleDbCommand = New OleDbCommand("SELECT [gw_id], [gw_wasama] FROM [gramsewa_wasam]", con)
                Dim sdr1 As OleDbDataReader = cmd1.ExecuteReader(CommandBehavior.CloseConnection)
                Dim comboSource1 As New Dictionary(Of Integer, String)()

                While sdr1.Read()
                    comboSource1.Add(sdr1("gw_id").ToString, sdr1("gw_wasama").ToString)
                End While

                gramasewaWasamaComboBox.DataSource = New BindingSource(comboSource1, Nothing)
                gramasewaWasamaComboBox.DisplayMember = "Value"
                gramasewaWasamaComboBox.ValueMember = "Key"
            End If

            ' Feed NIC Based on the Permit Header
            If Application.OpenForms().OfType(Of permitHeader).Any Then
                nicTextBox.Text = permitHeader.customerNicInput.Text
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
        If nicTextBox.Text <> "" Then
            Try
                Dim sdr As OleDbDataReader = findDetails(nicTextBox.Text)

                If sdr.Read() Then

                    firstNameTextBox.Text = sdr("cus_fname").ToString()
                    middleNameTextBox.Text = sdr("cus_mname").ToString()
                    lastNameTextBox.Text = sdr("cus_lname").ToString()
                    nicTextBox.Text = sdr("cus_nic").ToString()

                    houseNoTextBox.Text = sdr("cus_house_no").ToString()
                    streetTextBox.Text = sdr("cus_street").ToString()
                    cityComboBox.SelectedValue = sdr("cus_city")

                    mobileNoMaskedTextBox.Text = sdr("cus_mobile").ToString()
                    landLineNoMaskedTextBox.Text = sdr("cus_landline").ToString()

                    typeComboBox.SelectedIndex = typeComboBox.FindString(sdr("cus_type").ToString()).ToString()
                    businessRegNoTextBox.Text = sdr("cus_business_reg_no").ToString()
                    vatTextBox.Text = sdr("cus_vat").ToString()
                    gramasewaWasamaComboBox.SelectedValue = sdr("cus_gramasewa")

                Else
                    MessageBox.Show("Customer Not Found", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Please File NIC Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If nicTextBox.Text <> "" Then
            con = dbConn.dbConnect()

            Dim sdr As OleDbDataReader = findDetails(nicTextBox.Text)

            If sdr.Read() Then
                Dim sql As String = "UPDATE [customer] SET [cus_fname] = @cusFname, [cus_mname] = @cusMname, [cus_lname] = @cusLname,
                                [cus_house_no] = @cusHouseNo, [cus_street] = @cusStreet, [cus_city] = @cusCity, [cus_mobile] = @cusMobile,
                                [cus_landline] = @cusLandline, [cus_type] = @cusType, [cus_business_reg_no] = @cusBusinessRegNo, [cus_vat] = @cusVat, [cus_gramasewa] = @cusGramasewa
                                WHERE [cus_nic] = @cusNic"

                If con.State = ConnectionState.Open Then
                    Using sqlCom = New OleDbCommand(sql, con)
                        sqlCom.Parameters.Add("@cusFname", OleDbType.VarChar).Value = firstNameTextBox.Text
                        sqlCom.Parameters.Add("@cusMname", OleDbType.VarChar).Value = middleNameTextBox.Text
                        sqlCom.Parameters.Add("@cusLname", OleDbType.VarChar).Value = lastNameTextBox.Text
                        sqlCom.Parameters.Add("@cusHouseNo", OleDbType.VarChar).Value = houseNoTextBox.Text
                        sqlCom.Parameters.Add("@cusStreet", OleDbType.VarChar).Value = streetTextBox.Text
                        sqlCom.Parameters.Add("@cusCity", OleDbType.Numeric).Value = DirectCast(cityComboBox.SelectedItem, KeyValuePair(Of Integer, String)).Key
                        sqlCom.Parameters.Add("@cusMobile", OleDbType.VarChar).Value = mobileNoMaskedTextBox.Text
                        sqlCom.Parameters.Add("@cusLandline", OleDbType.VarChar).Value = landLineNoMaskedTextBox.Text
                        sqlCom.Parameters.Add("@cusType", OleDbType.VarChar).Value = typeComboBox.SelectedItem.ToString
                        sqlCom.Parameters.Add("@cusBusinessRegNo", OleDbType.VarChar).Value = businessRegNoTextBox.Text
                        sqlCom.Parameters.Add("@cusVat", OleDbType.VarChar).Value = vatTextBox.Text
                        sqlCom.Parameters.Add("@cusGramasewa", OleDbType.VarChar).Value = DirectCast(gramasewaWasamaComboBox.SelectedItem, KeyValuePair(Of Integer, String)).Key

                        sqlCom.Parameters.Add("@cusNic", OleDbType.VarChar).Value = nicTextBox.Text

                        Dim icount As Integer = sqlCom.ExecuteNonQuery

                        If icount = 1 Then
                            MessageBox.Show("Successfully Saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None)
                        End If

                    End Using
                Else
                    MessageBox.Show("DB Connection Issue", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Customer Not In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please File NIC Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [customer] WHERE [cus_nic] = @cusNic", con)
                cmd.Parameters.Add("@cusNic", searchKey)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                Return sdr

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function findDetailsById(searchKey) As OleDb.OleDbDataReader
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'User Details Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [customer] WHERE [cus_id] = @cusId", con)
                cmd.Parameters.Add("@cusId", searchKey)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                Return sdr

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function saveDetails() As Boolean
        If nicTextBox.Text <> "" Then
            con = dbConn.dbConnect()

            Dim sdr As OleDbDataReader = findDetails(nicTextBox.Text)

            If sdr.Read() Then
                MessageBox.Show("User Already In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim sql As String = "INSERT INTO [customer] ([cus_fname], [cus_mname], [cus_lname], [cus_house_no], [cus_street], [cus_city], [cus_mobile],
                                    [cus_landline], [cus_type], [cus_business_reg_no], [cus_vat], [cus_gramasewa], [cus_nic])
                                VALUES(@cusFname, @cusMname, @cusLname, @cusHouseNo, @cusStreet, @cusCity, @cusMobile, @cusLandline, @cusType, @cusBusinessRegNo, @cusVat, @cusGramasewa, @cusNic)"

                If con.State = ConnectionState.Open Then
                    Using sqlCom = New OleDbCommand(sql, con)

                        sqlCom.Parameters.Add("@cusFname", OleDbType.VarChar).Value = firstNameTextBox.Text
                        sqlCom.Parameters.Add("@cusMname", OleDbType.VarChar).Value = middleNameTextBox.Text
                        sqlCom.Parameters.Add("@cusLname", OleDbType.VarChar).Value = lastNameTextBox.Text
                        sqlCom.Parameters.Add("@cusHouseNo", OleDbType.VarChar).Value = houseNoTextBox.Text
                        sqlCom.Parameters.Add("@cusStreet", OleDbType.VarChar).Value = streetTextBox.Text
                        sqlCom.Parameters.Add("@cusCity", OleDbType.Numeric).Value = DirectCast(cityComboBox.SelectedItem, KeyValuePair(Of Integer, String)).Key
                        sqlCom.Parameters.Add("@cusMobile", OleDbType.VarChar).Value = mobileNoMaskedTextBox.Text
                        sqlCom.Parameters.Add("@cusLandline", OleDbType.VarChar).Value = landLineNoMaskedTextBox.Text
                        sqlCom.Parameters.Add("@cusType", OleDbType.VarChar).Value = typeComboBox.SelectedItem.ToString
                        sqlCom.Parameters.Add("@cusBusinessRegNo", OleDbType.VarChar).Value = businessRegNoTextBox.Text
                        sqlCom.Parameters.Add("@cusVat", OleDbType.VarChar).Value = vatTextBox.Text
                        sqlCom.Parameters.Add("@cusGramasewa", OleDbType.Numeric).Value = DirectCast(gramasewaWasamaComboBox.SelectedItem, KeyValuePair(Of Integer, String)).Key
                        sqlCom.Parameters.Add("@cusNic", OleDbType.VarChar).Value = nicTextBox.Text

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
            MessageBox.Show("Please File NIC Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Set Permit Header Details
        If Application.OpenForms().OfType(Of permitHeader).Any Then
            Try
                Dim sdr As OleDbDataReader = findDetails(nicTextBox.Text)

                If sdr.Read() Then

                    permitHeader.customerNameInput.Text = sdr("cus_fname").ToString() & " " & sdr("cus_lname").ToString()
                    permitHeader.customerNicInput.Text = sdr("cus_nic")
                    permitHeader.customerId.Text = sdr("cus_id")

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try

        End If

        Return True
    End Function

    Private Sub CityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CityToolStripMenuItem.Click
        city.Show()
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

    Private Sub DistrictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistrictToolStripMenuItem.Click
        district.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        permitHeader.Show()
    End Sub
End Class