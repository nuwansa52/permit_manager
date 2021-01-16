Imports System.Data.OleDb

Public Class permitHeader
    Dim dbConn = New AccessDataBase()
    Dim con As New OleDb.OleDbConnection
    Dim customer As New customer()

    Private Sub permitHeader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Common.userRole <> "ROLE_ADMIN" Then
            MenuStrip1.Items.Item(1).Enabled = False
        End If

        If Common.userRole = "ROLE_FINANCE" Then
            customerSearchBtn.Visible = False
            saveBtn.Visible = False
        End If

        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'Permit Type Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT [permit_type_id], [Description] FROM [permit_type]", con)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                Dim comboSource As New Dictionary(Of Integer, String)()

                While sdr.Read()
                    comboSource.Add(sdr("permit_type_id").ToString, sdr("Description").ToString)
                End While

                permitTypeInput.DataSource = New BindingSource(comboSource, Nothing)
                permitTypeInput.DisplayMember = "Value"
                permitTypeInput.ValueMember = "Key"

                'Tree Type Load
                Dim cmd1 As OleDbCommand = New OleDbCommand("SELECT [tree_type_id], [description] FROM [tree_type]", con)
                Dim sdr1 As OleDbDataReader = cmd1.ExecuteReader(CommandBehavior.CloseConnection)
                Dim comboSource1 As New Dictionary(Of Integer, String)()

                While sdr1.Read()
                    comboSource1.Add(sdr1("tree_type_id").ToString, sdr1("description").ToString)
                End While

                typeOfTreeComboBox.DataSource = New BindingSource(comboSource1, Nothing)
                typeOfTreeComboBox.DisplayMember = "Value"
                typeOfTreeComboBox.ValueMember = "Key"

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub customerSearchBtn_Click(sender As Object, e As EventArgs) Handles customerSearchBtn.Click

        If customerNicInput.Text <> "" Then
            Try
                Dim sdr As OleDbDataReader = customer.findDetails(customerNicInput.Text)

                If sdr.Read() Then

                    customerNameInput.Text = sdr("cus_fname").ToString() & " " & sdr("cus_lname").ToString()
                    customerId.Visible = False
                    customerId.Text = sdr("cus_id")

                Else
                    Dim result As DialogResult = MessageBox.Show("Customer Not Found. Press `Yes` to Create a New Customer", "Hi " & Common.userName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If result = DialogResult.Yes Then
                        customer.Show()
                    End If

                    customerNameInput.Text = ""
                    customerId.Text = ""
                    customerNicInput.Text = ""
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Please File Customer NIC Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        saveDetails()
    End Sub

    Private Function saveDetails() As Boolean
        If customerNicInput.Text <> "" Then
            con = dbConn.dbConnect()

            Dim sdr As OleDbDataReader = findDetails(applicationNumberInput.Text, permitNumberInput.Text)

            If sdr.Read() Then
                MessageBox.Show("Permit/Application Already In the System", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                Dim sql As String = "INSERT INTO [permit_header] ([ag_office_id], [permit_type_id], [per_appication_no], [per_type_of_tree], [per_transport_from],
                                                 [per_transport_to], [per_transport_date_from], [per_transport_date_to], [per_vehicle_no], [per_payment_voucher],
                                                 [per_permit_no], [per_created_by], [per_created_on], [per_customer_id], [per_land_deed_no], [per_remark],
                                                 [per_name_of_tree_cutter], [per_payment_amount], [per_receipt_no])
                                     VALUES(@AgOfficeId, @permitTypeId, @PerAppicationNo, @PerTypeOfTree, @PerTransportFrom, @PerTransportTo, @PerTransportDateFrom,
                                            @PerTransportDateTo, @PerVehicleNo, @PerPaymentVoucher, @PerPermitNo, @PerCreatedBy, @PerCreatedOn, @PerCustomerId, @PerLandDeedNo,
                                            @PerRemark, @PerNameOfTreeCutter, @PerPaymentAmount, @receiptNo)"
                    MsgBox(Common.userId)
                    If con.State = ConnectionState.Open Then
                        Using sqlCom = New OleDbCommand(sql, con)
                            sqlCom.Parameters.Add("@agOfficeId", OleDbType.Numeric).Value = Common.agOfficeId
                            sqlCom.Parameters.Add("@permitTypeId", OleDbType.Numeric).Value = DirectCast(permitTypeInput.SelectedItem, KeyValuePair(Of Integer, String)).Key
                            sqlCom.Parameters.Add("@perAppicationNo", OleDbType.VarChar).Value = applicationNumberInput.Text
                            sqlCom.Parameters.Add("@perTypeOfTree", OleDbType.Numeric).Value = DirectCast(typeOfTreeComboBox.SelectedItem, KeyValuePair(Of Integer, String)).Key
                            sqlCom.Parameters.Add("@perTransportFrom", OleDbType.VarChar).Value = transferFromInput.Text
                            sqlCom.Parameters.Add("@perTransportTo", OleDbType.VarChar).Value = transportToInput.Text
                            sqlCom.Parameters.Add("@perTransportDateFrom", OleDbType.Date).Value = dateTimePickerFrom.Value.ToString
                            sqlCom.Parameters.Add("@perTransportDateTo", OleDbType.Date).Value = dateTimePickerTo.Value.ToString
                            sqlCom.Parameters.Add("@perVehicleNo", OleDbType.VarChar).Value = vehicleNumberInput.Text
                            sqlCom.Parameters.Add("@perPaymentVoucher", OleDbType.VarChar).Value = paymentVoucherInput.Text
                            sqlCom.Parameters.Add("@perPermitNo", OleDbType.VarChar).Value = permitNumberInput.Text
                            sqlCom.Parameters.Add("@perCreatedBy", OleDbType.Numeric).Value = Common.userId
                            sqlCom.Parameters.Add("@perCreatedOn", OleDbType.VarChar).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                            sqlCom.Parameters.Add("@perCustomerId", OleDbType.Numeric).Value = customerId.Text
                            sqlCom.Parameters.Add("@perLandDeedNo", OleDbType.VarChar).Value = landNoInput.Text
                            sqlCom.Parameters.Add("@perRemark", OleDbType.VarChar).Value = remarkInput.Text
                            sqlCom.Parameters.Add("@perNameOfTreeCutter", OleDbType.VarChar).Value = cuttingPersonInput.Text
                            sqlCom.Parameters.Add("@PerPaymentAmount", OleDbType.VarChar).Value = paymentAmountInput.Text
                            sqlCom.Parameters.Add("@receiptNo", OleDbType.VarChar).Value = "."

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
            MessageBox.Show("Please File Customer NIC Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return True
    End Function

    Private Sub searchPermit_Click(sender As Object, e As EventArgs) Handles searchPermit.Click
        con = dbConn.dbConnect()

        If applicationNumberInput.Text <> "" Then
            Dim sdr As OleDbDataReader = findDetails(applicationNumberInput.Text, permitNumberInput.Text)

            If sdr.Read() Then

                permitTypeInput.SelectedValue = sdr("permit_type_id")
                applicationNumberInput.Text = sdr("per_appication_no")
                typeOfTreeComboBox.SelectedValue = sdr("per_type_of_tree")
                transferFromInput.Text = sdr("per_transport_from")
                transportToInput.Text = sdr("per_transport_to")
                dateTimePickerFrom.Value = sdr("per_transport_date_from")
                dateTimePickerTo.Value = sdr("per_transport_date_to")
                vehicleNumberInput.Text = sdr("per_vehicle_no")
                paymentVoucherInput.Text = sdr("per_payment_voucher")
                permitNumberInput.Text = sdr("per_permit_no")
                landNoInput.Text = sdr("per_land_deed_no")
                remarkInput.Text = sdr("per_remark")
                cuttingPersonInput.Text = sdr("per_name_of_tree_cutter")
                paymentAmountInput.Text = sdr("per_payment_amount")
                receiptNumberInput.Text = sdr("per_receipt_no")
                customerId.Text = sdr("per_customer_id")

                Dim sdr1 As OleDbDataReader = customer.findDetailsById(sdr("per_customer_id"))

                If sdr1.Read() Then
                    customerNicInput.Text = sdr1("cus_nic")
                    customerNameInput.Text = sdr1("cus_fname") & " " & sdr1("cus_lname")
                End If
            End If
        Else
            MessageBox.Show("Please File Application Number Field", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Function findDetails(applicationNo, permitNo) As OleDb.OleDbDataReader
        con = dbConn.dbConnect()
        Try
            If con.State = ConnectionState.Open Then
                'User Details Load
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [permit_header]
                                                            WHERE [per_appication_no] = @perAppicationNo OR [per_permit_no] = @perPermitNo", con)
                cmd.Parameters.Add("@perAppicationNo", applicationNo)
                cmd.Parameters.Add("@perPermitNo", permitNo)
                Dim sdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                Return sdr

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Sub CustomerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem1.Click
        customer.Show()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If Common.userRole = "ROLE_FINANCE" Then
            Dim sql As String = "UPDATE [permit_header] SET [per_receipt_no] = @perReceiptNo, [per_payment_accept_user] = @perPaymentAcceptUser
                                WHERE [per_appication_no] = @perAppicationNo"

            If con.State = ConnectionState.Open Then
                Using sqlCom = New OleDbCommand(sql, con)
                    sqlCom.Parameters.Add("@perReceiptNo", OleDbType.VarChar).Value = receiptNumberInput.Text
                    sqlCom.Parameters.Add("@perPaymentAcceptUser", OleDbType.VarChar).Value = Common.agOfficeId
                    sqlCom.Parameters.Add("@perAppicationNo", OleDbType.VarChar).Value = applicationNumberInput.Text

                    Dim icount As Integer = sqlCom.ExecuteNonQuery

                    If icount = 1 Then
                        MessageBox.Show("Successfully Saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None)
                    End If

                End Using
            Else
                MessageBox.Show("DB Connection Issue", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class