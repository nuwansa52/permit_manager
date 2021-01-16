<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class permitHeader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.permitType = New System.Windows.Forms.Label()
        Me.permitTypeInput = New System.Windows.Forms.ComboBox()
        Me.applicationNo = New System.Windows.Forms.Label()
        Me.applicationNumberInput = New System.Windows.Forms.TextBox()
        Me.transportFrom = New System.Windows.Forms.Label()
        Me.transportTo = New System.Windows.Forms.Label()
        Me.transferFromInput = New System.Windows.Forms.TextBox()
        Me.transportToInput = New System.Windows.Forms.TextBox()
        Me.transportDateTo = New System.Windows.Forms.Label()
        Me.transportDateFrom = New System.Windows.Forms.Label()
        Me.dateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.dateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.vehicleNumber = New System.Windows.Forms.Label()
        Me.vehicleNumberInput = New System.Windows.Forms.TextBox()
        Me.paymentVoucherInput = New System.Windows.Forms.TextBox()
        Me.paymentVoucher = New System.Windows.Forms.Label()
        Me.permitNumberInput = New System.Windows.Forms.TextBox()
        Me.permitNumber = New System.Windows.Forms.Label()
        Me.customerNicInput = New System.Windows.Forms.TextBox()
        Me.customerNic = New System.Windows.Forms.Label()
        Me.customerSearchBtn = New System.Windows.Forms.Button()
        Me.landNoInput = New System.Windows.Forms.TextBox()
        Me.landNo = New System.Windows.Forms.Label()
        Me.remarkInput = New System.Windows.Forms.TextBox()
        Me.remark = New System.Windows.Forms.Label()
        Me.cuttingPersonInput = New System.Windows.Forms.TextBox()
        Me.cuttingPerson = New System.Windows.Forms.Label()
        Me.receiptNumberInput = New System.Windows.Forms.TextBox()
        Me.receiptNumber = New System.Windows.Forms.Label()
        Me.paymentAmountInput = New System.Windows.Forms.TextBox()
        Me.paymentAmount = New System.Windows.Forms.Label()
        Me.permitDetailsGroup = New System.Windows.Forms.GroupBox()
        Me.transpoertDetailsGroup = New System.Windows.Forms.GroupBox()
        Me.paymentDetailsGroup = New System.Windows.Forms.GroupBox()
        Me.otherGroup = New System.Windows.Forms.GroupBox()
        Me.searchPermit = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistrictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionalSectretariatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GramasewaWasamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermitTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.typeOfTree = New System.Windows.Forms.Label()
        Me.typeOfTreeComboBox = New System.Windows.Forms.ComboBox()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.customerNameInput = New System.Windows.Forms.TextBox()
        Me.customerName = New System.Windows.Forms.Label()
        Me.customerId = New System.Windows.Forms.Label()
        Me.permitDetailsGroup.SuspendLayout()
        Me.transpoertDetailsGroup.SuspendLayout()
        Me.paymentDetailsGroup.SuspendLayout()
        Me.otherGroup.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'permitType
        '
        Me.permitType.AutoSize = True
        Me.permitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permitType.Location = New System.Drawing.Point(62, 68)
        Me.permitType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.permitType.Name = "permitType"
        Me.permitType.Size = New System.Drawing.Size(92, 16)
        Me.permitType.TabIndex = 0
        Me.permitType.Text = "Permit Type"
        '
        'permitTypeInput
        '
        Me.permitTypeInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permitTypeInput.FormattingEnabled = True
        Me.permitTypeInput.Location = New System.Drawing.Point(178, 65)
        Me.permitTypeInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.permitTypeInput.Name = "permitTypeInput"
        Me.permitTypeInput.Size = New System.Drawing.Size(204, 24)
        Me.permitTypeInput.TabIndex = 1
        '
        'applicationNo
        '
        Me.applicationNo.AutoSize = True
        Me.applicationNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applicationNo.Location = New System.Drawing.Point(10, 32)
        Me.applicationNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.applicationNo.Name = "applicationNo"
        Me.applicationNo.Size = New System.Drawing.Size(144, 16)
        Me.applicationNo.TabIndex = 2
        Me.applicationNo.Text = "Application Number"
        '
        'applicationNumberInput
        '
        Me.applicationNumberInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applicationNumberInput.Location = New System.Drawing.Point(178, 29)
        Me.applicationNumberInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.applicationNumberInput.Name = "applicationNumberInput"
        Me.applicationNumberInput.Size = New System.Drawing.Size(204, 23)
        Me.applicationNumberInput.TabIndex = 3
        '
        'transportFrom
        '
        Me.transportFrom.AutoSize = True
        Me.transportFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transportFrom.Location = New System.Drawing.Point(40, 63)
        Me.transportFrom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.transportFrom.Name = "transportFrom"
        Me.transportFrom.Size = New System.Drawing.Size(114, 16)
        Me.transportFrom.TabIndex = 5
        Me.transportFrom.Text = "Transport From"
        '
        'transportTo
        '
        Me.transportTo.AutoSize = True
        Me.transportTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transportTo.Location = New System.Drawing.Point(56, 98)
        Me.transportTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.transportTo.Name = "transportTo"
        Me.transportTo.Size = New System.Drawing.Size(98, 16)
        Me.transportTo.TabIndex = 6
        Me.transportTo.Text = "Transport To"
        '
        'transferFromInput
        '
        Me.transferFromInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transferFromInput.Location = New System.Drawing.Point(178, 60)
        Me.transferFromInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.transferFromInput.Name = "transferFromInput"
        Me.transferFromInput.Size = New System.Drawing.Size(204, 23)
        Me.transferFromInput.TabIndex = 7
        '
        'transportToInput
        '
        Me.transportToInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transportToInput.Location = New System.Drawing.Point(178, 95)
        Me.transportToInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.transportToInput.Name = "transportToInput"
        Me.transportToInput.Size = New System.Drawing.Size(204, 23)
        Me.transportToInput.TabIndex = 8
        '
        'transportDateTo
        '
        Me.transportDateTo.AutoSize = True
        Me.transportDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transportDateTo.Location = New System.Drawing.Point(19, 174)
        Me.transportDateTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.transportDateTo.Name = "transportDateTo"
        Me.transportDateTo.Size = New System.Drawing.Size(135, 16)
        Me.transportDateTo.TabIndex = 9
        Me.transportDateTo.Text = "Transport Date To"
        '
        'transportDateFrom
        '
        Me.transportDateFrom.AutoSize = True
        Me.transportDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transportDateFrom.Location = New System.Drawing.Point(3, 136)
        Me.transportDateFrom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.transportDateFrom.Name = "transportDateFrom"
        Me.transportDateFrom.Size = New System.Drawing.Size(151, 16)
        Me.transportDateFrom.TabIndex = 10
        Me.transportDateFrom.Text = "Transport Date From"
        '
        'dateTimePickerFrom
        '
        Me.dateTimePickerFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerFrom.Location = New System.Drawing.Point(178, 131)
        Me.dateTimePickerFrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dateTimePickerFrom.Name = "dateTimePickerFrom"
        Me.dateTimePickerFrom.Size = New System.Drawing.Size(204, 23)
        Me.dateTimePickerFrom.TabIndex = 11
        '
        'dateTimePickerTo
        '
        Me.dateTimePickerTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerTo.Location = New System.Drawing.Point(178, 169)
        Me.dateTimePickerTo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dateTimePickerTo.Name = "dateTimePickerTo"
        Me.dateTimePickerTo.Size = New System.Drawing.Size(204, 23)
        Me.dateTimePickerTo.TabIndex = 12
        '
        'vehicleNumber
        '
        Me.vehicleNumber.AutoSize = True
        Me.vehicleNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleNumber.Location = New System.Drawing.Point(36, 28)
        Me.vehicleNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vehicleNumber.Name = "vehicleNumber"
        Me.vehicleNumber.Size = New System.Drawing.Size(118, 16)
        Me.vehicleNumber.TabIndex = 13
        Me.vehicleNumber.Text = "Vehicle Number"
        '
        'vehicleNumberInput
        '
        Me.vehicleNumberInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleNumberInput.Location = New System.Drawing.Point(178, 25)
        Me.vehicleNumberInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.vehicleNumberInput.Name = "vehicleNumberInput"
        Me.vehicleNumberInput.Size = New System.Drawing.Size(204, 23)
        Me.vehicleNumberInput.TabIndex = 14
        '
        'paymentVoucherInput
        '
        Me.paymentVoucherInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentVoucherInput.Location = New System.Drawing.Point(167, 29)
        Me.paymentVoucherInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.paymentVoucherInput.Name = "paymentVoucherInput"
        Me.paymentVoucherInput.Size = New System.Drawing.Size(204, 23)
        Me.paymentVoucherInput.TabIndex = 16
        '
        'paymentVoucher
        '
        Me.paymentVoucher.AutoSize = True
        Me.paymentVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentVoucher.Location = New System.Drawing.Point(23, 32)
        Me.paymentVoucher.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.paymentVoucher.Name = "paymentVoucher"
        Me.paymentVoucher.Size = New System.Drawing.Size(129, 16)
        Me.paymentVoucher.TabIndex = 15
        Me.paymentVoucher.Text = "Payment Voucher"
        '
        'permitNumberInput
        '
        Me.permitNumberInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permitNumberInput.Location = New System.Drawing.Point(178, 100)
        Me.permitNumberInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.permitNumberInput.Name = "permitNumberInput"
        Me.permitNumberInput.Size = New System.Drawing.Size(204, 23)
        Me.permitNumberInput.TabIndex = 18
        '
        'permitNumber
        '
        Me.permitNumber.AutoSize = True
        Me.permitNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permitNumber.Location = New System.Drawing.Point(44, 103)
        Me.permitNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.permitNumber.Name = "permitNumber"
        Me.permitNumber.Size = New System.Drawing.Size(110, 16)
        Me.permitNumber.TabIndex = 17
        Me.permitNumber.Text = "Permit Number"
        '
        'customerNicInput
        '
        Me.customerNicInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerNicInput.Location = New System.Drawing.Point(170, 57)
        Me.customerNicInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.customerNicInput.Name = "customerNicInput"
        Me.customerNicInput.Size = New System.Drawing.Size(148, 23)
        Me.customerNicInput.TabIndex = 20
        '
        'customerNic
        '
        Me.customerNic.AutoSize = True
        Me.customerNic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerNic.Location = New System.Drawing.Point(45, 60)
        Me.customerNic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.customerNic.Name = "customerNic"
        Me.customerNic.Size = New System.Drawing.Size(102, 16)
        Me.customerNic.TabIndex = 19
        Me.customerNic.Text = "Customer NIC"
        '
        'customerSearchBtn
        '
        Me.customerSearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerSearchBtn.Location = New System.Drawing.Point(348, 56)
        Me.customerSearchBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.customerSearchBtn.Name = "customerSearchBtn"
        Me.customerSearchBtn.Size = New System.Drawing.Size(98, 28)
        Me.customerSearchBtn.TabIndex = 21
        Me.customerSearchBtn.Text = "Customer Search"
        Me.customerSearchBtn.UseVisualStyleBackColor = True
        '
        'landNoInput
        '
        Me.landNoInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.landNoInput.Location = New System.Drawing.Point(178, 133)
        Me.landNoInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.landNoInput.Name = "landNoInput"
        Me.landNoInput.Size = New System.Drawing.Size(204, 23)
        Me.landNoInput.TabIndex = 23
        '
        'landNo
        '
        Me.landNo.AutoSize = True
        Me.landNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.landNo.Location = New System.Drawing.Point(88, 133)
        Me.landNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.landNo.Name = "landNo"
        Me.landNo.Size = New System.Drawing.Size(66, 16)
        Me.landNo.TabIndex = 22
        Me.landNo.Text = "Land No"
        '
        'remarkInput
        '
        Me.remarkInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarkInput.Location = New System.Drawing.Point(167, 98)
        Me.remarkInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.remarkInput.Multiline = True
        Me.remarkInput.Name = "remarkInput"
        Me.remarkInput.Size = New System.Drawing.Size(263, 71)
        Me.remarkInput.TabIndex = 25
        '
        'remark
        '
        Me.remark.AutoSize = True
        Me.remark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remark.Location = New System.Drawing.Point(90, 126)
        Me.remark.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.remark.Name = "remark"
        Me.remark.Size = New System.Drawing.Size(62, 16)
        Me.remark.TabIndex = 24
        Me.remark.Text = "Remark"
        '
        'cuttingPersonInput
        '
        Me.cuttingPersonInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuttingPersonInput.Location = New System.Drawing.Point(167, 27)
        Me.cuttingPersonInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cuttingPersonInput.Name = "cuttingPersonInput"
        Me.cuttingPersonInput.Size = New System.Drawing.Size(230, 23)
        Me.cuttingPersonInput.TabIndex = 27
        '
        'cuttingPerson
        '
        Me.cuttingPerson.AutoSize = True
        Me.cuttingPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuttingPerson.Location = New System.Drawing.Point(7, 30)
        Me.cuttingPerson.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cuttingPerson.Name = "cuttingPerson"
        Me.cuttingPerson.Size = New System.Drawing.Size(145, 16)
        Me.cuttingPerson.TabIndex = 26
        Me.cuttingPerson.Text = "Tree Cutting Person"
        '
        'receiptNumberInput
        '
        Me.receiptNumberInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiptNumberInput.Location = New System.Drawing.Point(167, 100)
        Me.receiptNumberInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.receiptNumberInput.Name = "receiptNumberInput"
        Me.receiptNumberInput.Size = New System.Drawing.Size(204, 23)
        Me.receiptNumberInput.TabIndex = 29
        '
        'receiptNumber
        '
        Me.receiptNumber.AutoSize = True
        Me.receiptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiptNumber.Location = New System.Drawing.Point(32, 103)
        Me.receiptNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.receiptNumber.Name = "receiptNumber"
        Me.receiptNumber.Size = New System.Drawing.Size(120, 16)
        Me.receiptNumber.TabIndex = 28
        Me.receiptNumber.Text = "Receipt Number"
        '
        'paymentAmountInput
        '
        Me.paymentAmountInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentAmountInput.Location = New System.Drawing.Point(167, 65)
        Me.paymentAmountInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.paymentAmountInput.Name = "paymentAmountInput"
        Me.paymentAmountInput.Size = New System.Drawing.Size(204, 23)
        Me.paymentAmountInput.TabIndex = 31
        '
        'paymentAmount
        '
        Me.paymentAmount.AutoSize = True
        Me.paymentAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentAmount.Location = New System.Drawing.Point(29, 69)
        Me.paymentAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.paymentAmount.Name = "paymentAmount"
        Me.paymentAmount.Size = New System.Drawing.Size(123, 16)
        Me.paymentAmount.TabIndex = 30
        Me.paymentAmount.Text = "Payment Amount"
        '
        'permitDetailsGroup
        '
        Me.permitDetailsGroup.Controls.Add(Me.searchPermit)
        Me.permitDetailsGroup.Controls.Add(Me.applicationNumberInput)
        Me.permitDetailsGroup.Controls.Add(Me.applicationNo)
        Me.permitDetailsGroup.Controls.Add(Me.permitTypeInput)
        Me.permitDetailsGroup.Controls.Add(Me.permitType)
        Me.permitDetailsGroup.Controls.Add(Me.landNoInput)
        Me.permitDetailsGroup.Controls.Add(Me.landNo)
        Me.permitDetailsGroup.Controls.Add(Me.permitNumberInput)
        Me.permitDetailsGroup.Controls.Add(Me.permitNumber)
        Me.permitDetailsGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permitDetailsGroup.Location = New System.Drawing.Point(35, 107)
        Me.permitDetailsGroup.Name = "permitDetailsGroup"
        Me.permitDetailsGroup.Size = New System.Drawing.Size(489, 173)
        Me.permitDetailsGroup.TabIndex = 32
        Me.permitDetailsGroup.TabStop = False
        Me.permitDetailsGroup.Text = "Permit Details"
        '
        'transpoertDetailsGroup
        '
        Me.transpoertDetailsGroup.Controls.Add(Me.dateTimePickerFrom)
        Me.transpoertDetailsGroup.Controls.Add(Me.transportFrom)
        Me.transpoertDetailsGroup.Controls.Add(Me.transportTo)
        Me.transpoertDetailsGroup.Controls.Add(Me.transferFromInput)
        Me.transpoertDetailsGroup.Controls.Add(Me.transportToInput)
        Me.transpoertDetailsGroup.Controls.Add(Me.transportDateTo)
        Me.transpoertDetailsGroup.Controls.Add(Me.transportDateFrom)
        Me.transpoertDetailsGroup.Controls.Add(Me.dateTimePickerTo)
        Me.transpoertDetailsGroup.Controls.Add(Me.vehicleNumberInput)
        Me.transpoertDetailsGroup.Controls.Add(Me.vehicleNumber)
        Me.transpoertDetailsGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transpoertDetailsGroup.Location = New System.Drawing.Point(35, 299)
        Me.transpoertDetailsGroup.Name = "transpoertDetailsGroup"
        Me.transpoertDetailsGroup.Size = New System.Drawing.Size(411, 207)
        Me.transpoertDetailsGroup.TabIndex = 33
        Me.transpoertDetailsGroup.TabStop = False
        Me.transpoertDetailsGroup.Text = "Transport Details"
        '
        'paymentDetailsGroup
        '
        Me.paymentDetailsGroup.Controls.Add(Me.paymentVoucherInput)
        Me.paymentDetailsGroup.Controls.Add(Me.paymentVoucher)
        Me.paymentDetailsGroup.Controls.Add(Me.paymentAmountInput)
        Me.paymentDetailsGroup.Controls.Add(Me.receiptNumberInput)
        Me.paymentDetailsGroup.Controls.Add(Me.receiptNumber)
        Me.paymentDetailsGroup.Controls.Add(Me.paymentAmount)
        Me.paymentDetailsGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentDetailsGroup.Location = New System.Drawing.Point(556, 107)
        Me.paymentDetailsGroup.Name = "paymentDetailsGroup"
        Me.paymentDetailsGroup.Size = New System.Drawing.Size(397, 141)
        Me.paymentDetailsGroup.TabIndex = 24
        Me.paymentDetailsGroup.TabStop = False
        Me.paymentDetailsGroup.Text = "Payment Details"
        '
        'otherGroup
        '
        Me.otherGroup.Controls.Add(Me.typeOfTreeComboBox)
        Me.otherGroup.Controls.Add(Me.typeOfTree)
        Me.otherGroup.Controls.Add(Me.cuttingPerson)
        Me.otherGroup.Controls.Add(Me.cuttingPersonInput)
        Me.otherGroup.Controls.Add(Me.remarkInput)
        Me.otherGroup.Controls.Add(Me.remark)
        Me.otherGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otherGroup.Location = New System.Drawing.Point(482, 299)
        Me.otherGroup.Name = "otherGroup"
        Me.otherGroup.Size = New System.Drawing.Size(454, 190)
        Me.otherGroup.TabIndex = 34
        Me.otherGroup.TabStop = False
        Me.otherGroup.Text = "Other"
        '
        'searchPermit
        '
        Me.searchPermit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchPermit.Location = New System.Drawing.Point(390, 27)
        Me.searchPermit.Margin = New System.Windows.Forms.Padding(4)
        Me.searchPermit.Name = "searchPermit"
        Me.searchPermit.Size = New System.Drawing.Size(77, 28)
        Me.searchPermit.TabIndex = 35
        Me.searchPermit.Text = "Search"
        Me.searchPermit.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(760, 497)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(90, 27)
        Me.update.TabIndex = 37
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(869, 497)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(90, 27)
        Me.clearBtn.TabIndex = 35
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(650, 497)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(90, 27)
        Me.saveBtn.TabIndex = 36
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.PermitToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(981, 24)
        Me.MenuStrip1.TabIndex = 38
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DistrictToolStripMenuItem, Me.CityToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.DivisionalSectretariatToolStripMenuItem, Me.GramasewaWasamToolStripMenuItem, Me.PermitTypeToolStripMenuItem, Me.SystemUserToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'DistrictToolStripMenuItem
        '
        Me.DistrictToolStripMenuItem.Name = "DistrictToolStripMenuItem"
        Me.DistrictToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DistrictToolStripMenuItem.Text = "District"
        '
        'CityToolStripMenuItem
        '
        Me.CityToolStripMenuItem.Name = "CityToolStripMenuItem"
        Me.CityToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CityToolStripMenuItem.Text = "City"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'DivisionalSectretariatToolStripMenuItem
        '
        Me.DivisionalSectretariatToolStripMenuItem.Name = "DivisionalSectretariatToolStripMenuItem"
        Me.DivisionalSectretariatToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DivisionalSectretariatToolStripMenuItem.Text = "Divisional Sectretariat"
        '
        'GramasewaWasamToolStripMenuItem
        '
        Me.GramasewaWasamToolStripMenuItem.Name = "GramasewaWasamToolStripMenuItem"
        Me.GramasewaWasamToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GramasewaWasamToolStripMenuItem.Text = "Gramasewa Wasam"
        '
        'PermitTypeToolStripMenuItem
        '
        Me.PermitTypeToolStripMenuItem.Name = "PermitTypeToolStripMenuItem"
        Me.PermitTypeToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PermitTypeToolStripMenuItem.Text = "Permit Type"
        '
        'SystemUserToolStripMenuItem
        '
        Me.SystemUserToolStripMenuItem.Name = "SystemUserToolStripMenuItem"
        Me.SystemUserToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SystemUserToolStripMenuItem.Text = "System User"
        '
        'PermitToolStripMenuItem
        '
        Me.PermitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem1})
        Me.PermitToolStripMenuItem.Name = "PermitToolStripMenuItem"
        Me.PermitToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.PermitToolStripMenuItem.Text = "Permit"
        '
        'CustomerToolStripMenuItem1
        '
        Me.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1"
        Me.CustomerToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CustomerToolStripMenuItem1.Text = "Customer"
        '
        'typeOfTree
        '
        Me.typeOfTree.AutoSize = True
        Me.typeOfTree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeOfTree.Location = New System.Drawing.Point(54, 65)
        Me.typeOfTree.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.typeOfTree.Name = "typeOfTree"
        Me.typeOfTree.Size = New System.Drawing.Size(98, 16)
        Me.typeOfTree.TabIndex = 28
        Me.typeOfTree.Text = "Type of Tree"
        '
        'typeOfTreeComboBox
        '
        Me.typeOfTreeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeOfTreeComboBox.FormattingEnabled = True
        Me.typeOfTreeComboBox.Location = New System.Drawing.Point(167, 63)
        Me.typeOfTreeComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.typeOfTreeComboBox.Name = "typeOfTreeComboBox"
        Me.typeOfTreeComboBox.Size = New System.Drawing.Size(230, 24)
        Me.typeOfTreeComboBox.TabIndex = 36
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogOutToolStripMenuItem.Text = "LogOut"
        '
        'customerNameInput
        '
        Me.customerNameInput.Enabled = False
        Me.customerNameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerNameInput.Location = New System.Drawing.Point(621, 57)
        Me.customerNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.customerNameInput.Name = "customerNameInput"
        Me.customerNameInput.Size = New System.Drawing.Size(148, 23)
        Me.customerNameInput.TabIndex = 40
        '
        'customerName
        '
        Me.customerName.AutoSize = True
        Me.customerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerName.Location = New System.Drawing.Point(482, 60)
        Me.customerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.customerName.Name = "customerName"
        Me.customerName.Size = New System.Drawing.Size(118, 16)
        Me.customerName.TabIndex = 39
        Me.customerName.Text = "Customer Name"
        '
        'customerId
        '
        Me.customerId.AutoSize = True
        Me.customerId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerId.Location = New System.Drawing.Point(969, 0)
        Me.customerId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.customerId.Name = "customerId"
        Me.customerId.Size = New System.Drawing.Size(12, 16)
        Me.customerId.TabIndex = 41
        Me.customerId.Text = "."
        '
        'permitHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 545)
        Me.Controls.Add(Me.customerId)
        Me.Controls.Add(Me.customerNameInput)
        Me.Controls.Add(Me.customerName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.otherGroup)
        Me.Controls.Add(Me.paymentDetailsGroup)
        Me.Controls.Add(Me.transpoertDetailsGroup)
        Me.Controls.Add(Me.permitDetailsGroup)
        Me.Controls.Add(Me.customerSearchBtn)
        Me.Controls.Add(Me.customerNicInput)
        Me.Controls.Add(Me.customerNic)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "permitHeader"
        Me.Text = "Permit Header"
        Me.permitDetailsGroup.ResumeLayout(False)
        Me.permitDetailsGroup.PerformLayout()
        Me.transpoertDetailsGroup.ResumeLayout(False)
        Me.transpoertDetailsGroup.PerformLayout()
        Me.paymentDetailsGroup.ResumeLayout(False)
        Me.paymentDetailsGroup.PerformLayout()
        Me.otherGroup.ResumeLayout(False)
        Me.otherGroup.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents permitType As Label
    Friend WithEvents permitTypeInput As ComboBox
    Friend WithEvents applicationNo As Label
    Friend WithEvents applicationNumberInput As TextBox
    Friend WithEvents transportFrom As Label
    Friend WithEvents transportTo As Label
    Friend WithEvents transferFromInput As TextBox
    Friend WithEvents transportToInput As TextBox
    Friend WithEvents transportDateTo As Label
    Friend WithEvents transportDateFrom As Label
    Friend WithEvents dateTimePickerFrom As DateTimePicker
    Friend WithEvents dateTimePickerTo As DateTimePicker
    Friend WithEvents vehicleNumber As Label
    Friend WithEvents vehicleNumberInput As TextBox
    Friend WithEvents paymentVoucherInput As TextBox
    Friend WithEvents paymentVoucher As Label
    Friend WithEvents permitNumberInput As TextBox
    Friend WithEvents permitNumber As Label
    Friend WithEvents customerNicInput As TextBox
    Friend WithEvents customerNic As Label
    Friend WithEvents customerSearchBtn As Button
    Friend WithEvents landNoInput As TextBox
    Friend WithEvents landNo As Label
    Friend WithEvents remarkInput As TextBox
    Friend WithEvents remark As Label
    Friend WithEvents cuttingPersonInput As TextBox
    Friend WithEvents cuttingPerson As Label
    Friend WithEvents receiptNumberInput As TextBox
    Friend WithEvents receiptNumber As Label
    Friend WithEvents paymentAmountInput As TextBox
    Friend WithEvents paymentAmount As Label
    Friend WithEvents permitDetailsGroup As GroupBox
    Friend WithEvents transpoertDetailsGroup As GroupBox
    Friend WithEvents paymentDetailsGroup As GroupBox
    Friend WithEvents otherGroup As GroupBox
    Friend WithEvents searchPermit As Button
    Friend WithEvents update As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DistrictToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DivisionalSectretariatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GramasewaWasamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermitTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents typeOfTreeComboBox As ComboBox
    Friend WithEvents typeOfTree As Label
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents customerNameInput As TextBox
    Friend WithEvents customerName As Label
    Friend WithEvents customerId As Label
End Class
