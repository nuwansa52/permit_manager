<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Permit_Header
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
        Me.transferToInput = New System.Windows.Forms.TextBox()
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
        Me.customerInput = New System.Windows.Forms.TextBox()
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
        Me.SuspendLayout()
        '
        'permitType
        '
        Me.permitType.AutoSize = True
        Me.permitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permitType.Location = New System.Drawing.Point(59, 101)
        Me.permitType.Name = "permitType"
        Me.permitType.Size = New System.Drawing.Size(84, 17)
        Me.permitType.TabIndex = 0
        Me.permitType.Text = "Permit Type"
        '
        'permitTypeInput
        '
        Me.permitTypeInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permitTypeInput.FormattingEnabled = True
        Me.permitTypeInput.Location = New System.Drawing.Point(190, 94)
        Me.permitTypeInput.Name = "permitTypeInput"
        Me.permitTypeInput.Size = New System.Drawing.Size(121, 24)
        Me.permitTypeInput.TabIndex = 1
        '
        'applicationNo
        '
        Me.applicationNo.AutoSize = True
        Me.applicationNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applicationNo.Location = New System.Drawing.Point(12, 56)
        Me.applicationNo.Name = "applicationNo"
        Me.applicationNo.Size = New System.Drawing.Size(131, 17)
        Me.applicationNo.TabIndex = 2
        Me.applicationNo.Text = "Application Number"
        '
        'applicationNumberInput
        '
        Me.applicationNumberInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applicationNumberInput.Location = New System.Drawing.Point(190, 53)
        Me.applicationNumberInput.Name = "applicationNumberInput"
        Me.applicationNumberInput.Size = New System.Drawing.Size(121, 23)
        Me.applicationNumberInput.TabIndex = 3
        '
        'transportFrom
        '
        Me.transportFrom.AutoSize = True
        Me.transportFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transportFrom.Location = New System.Drawing.Point(66, 266)
        Me.transportFrom.Name = "transportFrom"
        Me.transportFrom.Size = New System.Drawing.Size(106, 17)
        Me.transportFrom.TabIndex = 5
        Me.transportFrom.Text = "Transport From"
        '
        'transportTo
        '
        Me.transportTo.AutoSize = True
        Me.transportTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transportTo.Location = New System.Drawing.Point(81, 299)
        Me.transportTo.Name = "transportTo"
        Me.transportTo.Size = New System.Drawing.Size(91, 17)
        Me.transportTo.TabIndex = 6
        Me.transportTo.Text = "Transport To"
        '
        'transferFromInput
        '
        Me.transferFromInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transferFromInput.Location = New System.Drawing.Point(208, 262)
        Me.transferFromInput.Name = "transferFromInput"
        Me.transferFromInput.Size = New System.Drawing.Size(141, 23)
        Me.transferFromInput.TabIndex = 7
        '
        'transferToInput
        '
        Me.transferToInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transferToInput.Location = New System.Drawing.Point(208, 293)
        Me.transferToInput.Name = "transferToInput"
        Me.transferToInput.Size = New System.Drawing.Size(141, 23)
        Me.transferToInput.TabIndex = 8
        '
        'transportDateTo
        '
        Me.transportDateTo.AutoSize = True
        Me.transportDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transportDateTo.Location = New System.Drawing.Point(69, 372)
        Me.transportDateTo.Name = "transportDateTo"
        Me.transportDateTo.Size = New System.Drawing.Size(125, 17)
        Me.transportDateTo.TabIndex = 9
        Me.transportDateTo.Text = "Transport Date To"
        '
        'transportDateFrom
        '
        Me.transportDateFrom.AutoSize = True
        Me.transportDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transportDateFrom.Location = New System.Drawing.Point(54, 334)
        Me.transportDateFrom.Name = "transportDateFrom"
        Me.transportDateFrom.Size = New System.Drawing.Size(140, 17)
        Me.transportDateFrom.TabIndex = 10
        Me.transportDateFrom.Text = "Transport Date From"
        '
        'dateTimePickerFrom
        '
        Me.dateTimePickerFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerFrom.Location = New System.Drawing.Point(232, 328)
        Me.dateTimePickerFrom.Name = "dateTimePickerFrom"
        Me.dateTimePickerFrom.Size = New System.Drawing.Size(117, 23)
        Me.dateTimePickerFrom.TabIndex = 11
        '
        'dateTimePickerTo
        '
        Me.dateTimePickerTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerTo.Location = New System.Drawing.Point(232, 372)
        Me.dateTimePickerTo.Name = "dateTimePickerTo"
        Me.dateTimePickerTo.Size = New System.Drawing.Size(117, 23)
        Me.dateTimePickerTo.TabIndex = 12
        '
        'vehicleNumber
        '
        Me.vehicleNumber.AutoSize = True
        Me.vehicleNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleNumber.Location = New System.Drawing.Point(35, 135)
        Me.vehicleNumber.Name = "vehicleNumber"
        Me.vehicleNumber.Size = New System.Drawing.Size(108, 17)
        Me.vehicleNumber.TabIndex = 13
        Me.vehicleNumber.Text = "Vehicle Number"
        '
        'vehicleNumberInput
        '
        Me.vehicleNumberInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleNumberInput.Location = New System.Drawing.Point(190, 135)
        Me.vehicleNumberInput.Name = "vehicleNumberInput"
        Me.vehicleNumberInput.Size = New System.Drawing.Size(121, 23)
        Me.vehicleNumberInput.TabIndex = 14
        '
        'paymentVoucherInput
        '
        Me.paymentVoucherInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentVoucherInput.Location = New System.Drawing.Point(480, 43)
        Me.paymentVoucherInput.Name = "paymentVoucherInput"
        Me.paymentVoucherInput.Size = New System.Drawing.Size(100, 23)
        Me.paymentVoucherInput.TabIndex = 16
        '
        'paymentVoucher
        '
        Me.paymentVoucher.AutoSize = True
        Me.paymentVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentVoucher.Location = New System.Drawing.Point(339, 49)
        Me.paymentVoucher.Name = "paymentVoucher"
        Me.paymentVoucher.Size = New System.Drawing.Size(120, 17)
        Me.paymentVoucher.TabIndex = 15
        Me.paymentVoucher.Text = "Payment Voucher"
        '
        'permitNumberInput
        '
        Me.permitNumberInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permitNumberInput.Location = New System.Drawing.Point(480, 106)
        Me.permitNumberInput.Name = "permitNumberInput"
        Me.permitNumberInput.Size = New System.Drawing.Size(100, 23)
        Me.permitNumberInput.TabIndex = 18
        '
        'permitNumber
        '
        Me.permitNumber.AutoSize = True
        Me.permitNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permitNumber.Location = New System.Drawing.Point(339, 112)
        Me.permitNumber.Name = "permitNumber"
        Me.permitNumber.Size = New System.Drawing.Size(102, 17)
        Me.permitNumber.TabIndex = 17
        Me.permitNumber.Text = "Permit Number"
        '
        'customerInput
        '
        Me.customerInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerInput.Location = New System.Drawing.Point(491, 187)
        Me.customerInput.Name = "customerInput"
        Me.customerInput.Size = New System.Drawing.Size(100, 23)
        Me.customerInput.TabIndex = 20
        '
        'customerNic
        '
        Me.customerNic.AutoSize = True
        Me.customerNic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerNic.Location = New System.Drawing.Point(350, 193)
        Me.customerNic.Name = "customerNic"
        Me.customerNic.Size = New System.Drawing.Size(94, 17)
        Me.customerNic.TabIndex = 19
        Me.customerNic.Text = "Customer NIC"
        '
        'customerSearchBtn
        '
        Me.customerSearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerSearchBtn.Location = New System.Drawing.Point(609, 186)
        Me.customerSearchBtn.Name = "customerSearchBtn"
        Me.customerSearchBtn.Size = New System.Drawing.Size(103, 23)
        Me.customerSearchBtn.TabIndex = 21
        Me.customerSearchBtn.Text = "Customer Search"
        Me.customerSearchBtn.UseVisualStyleBackColor = True
        '
        'landNoInput
        '
        Me.landNoInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.landNoInput.Location = New System.Drawing.Point(190, 175)
        Me.landNoInput.Name = "landNoInput"
        Me.landNoInput.Size = New System.Drawing.Size(121, 23)
        Me.landNoInput.TabIndex = 23
        '
        'landNo
        '
        Me.landNo.AutoSize = True
        Me.landNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.landNo.Location = New System.Drawing.Point(81, 178)
        Me.landNo.Name = "landNo"
        Me.landNo.Size = New System.Drawing.Size(62, 17)
        Me.landNo.TabIndex = 22
        Me.landNo.Text = "Land No"
        '
        'remarkInput
        '
        Me.remarkInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarkInput.Location = New System.Drawing.Point(453, 332)
        Me.remarkInput.Multiline = True
        Me.remarkInput.Name = "remarkInput"
        Me.remarkInput.Size = New System.Drawing.Size(108, 20)
        Me.remarkInput.TabIndex = 25
        '
        'remark
        '
        Me.remark.AutoSize = True
        Me.remark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remark.Location = New System.Drawing.Point(364, 333)
        Me.remark.Name = "remark"
        Me.remark.Size = New System.Drawing.Size(57, 17)
        Me.remark.TabIndex = 24
        Me.remark.Text = "Remark"
        '
        'cuttingPersonInput
        '
        Me.cuttingPersonInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuttingPersonInput.Location = New System.Drawing.Point(491, 232)
        Me.cuttingPersonInput.Name = "cuttingPersonInput"
        Me.cuttingPersonInput.Size = New System.Drawing.Size(100, 23)
        Me.cuttingPersonInput.TabIndex = 27
        '
        'cuttingPerson
        '
        Me.cuttingPerson.AutoSize = True
        Me.cuttingPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuttingPerson.Location = New System.Drawing.Point(350, 238)
        Me.cuttingPerson.Name = "cuttingPerson"
        Me.cuttingPerson.Size = New System.Drawing.Size(135, 17)
        Me.cuttingPerson.TabIndex = 26
        Me.cuttingPerson.Text = "Tree Cutting Person"
        '
        'receiptNumberInput
        '
        Me.receiptNumberInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiptNumberInput.Location = New System.Drawing.Point(609, 407)
        Me.receiptNumberInput.Name = "receiptNumberInput"
        Me.receiptNumberInput.Size = New System.Drawing.Size(100, 23)
        Me.receiptNumberInput.TabIndex = 29
        '
        'receiptNumber
        '
        Me.receiptNumber.AutoSize = True
        Me.receiptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiptNumber.Location = New System.Drawing.Point(481, 407)
        Me.receiptNumber.Name = "receiptNumber"
        Me.receiptNumber.Size = New System.Drawing.Size(110, 17)
        Me.receiptNumber.TabIndex = 28
        Me.receiptNumber.Text = "Receipt Number"
        '
        'paymentAmountInput
        '
        Me.paymentAmountInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentAmountInput.Location = New System.Drawing.Point(664, 290)
        Me.paymentAmountInput.Name = "paymentAmountInput"
        Me.paymentAmountInput.Size = New System.Drawing.Size(100, 23)
        Me.paymentAmountInput.TabIndex = 31
        '
        'paymentAmount
        '
        Me.paymentAmount.AutoSize = True
        Me.paymentAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentAmount.Location = New System.Drawing.Point(522, 293)
        Me.paymentAmount.Name = "paymentAmount"
        Me.paymentAmount.Size = New System.Drawing.Size(115, 17)
        Me.paymentAmount.TabIndex = 30
        Me.paymentAmount.Text = "Payment Amount"
        '
        'Permit_Header
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.paymentAmountInput)
        Me.Controls.Add(Me.paymentAmount)
        Me.Controls.Add(Me.receiptNumberInput)
        Me.Controls.Add(Me.receiptNumber)
        Me.Controls.Add(Me.cuttingPersonInput)
        Me.Controls.Add(Me.cuttingPerson)
        Me.Controls.Add(Me.remarkInput)
        Me.Controls.Add(Me.remark)
        Me.Controls.Add(Me.landNoInput)
        Me.Controls.Add(Me.landNo)
        Me.Controls.Add(Me.customerSearchBtn)
        Me.Controls.Add(Me.customerInput)
        Me.Controls.Add(Me.customerNic)
        Me.Controls.Add(Me.permitNumberInput)
        Me.Controls.Add(Me.permitNumber)
        Me.Controls.Add(Me.paymentVoucherInput)
        Me.Controls.Add(Me.paymentVoucher)
        Me.Controls.Add(Me.vehicleNumberInput)
        Me.Controls.Add(Me.vehicleNumber)
        Me.Controls.Add(Me.dateTimePickerTo)
        Me.Controls.Add(Me.dateTimePickerFrom)
        Me.Controls.Add(Me.transportDateFrom)
        Me.Controls.Add(Me.transportDateTo)
        Me.Controls.Add(Me.transferToInput)
        Me.Controls.Add(Me.transferFromInput)
        Me.Controls.Add(Me.transportTo)
        Me.Controls.Add(Me.transportFrom)
        Me.Controls.Add(Me.applicationNumberInput)
        Me.Controls.Add(Me.applicationNo)
        Me.Controls.Add(Me.permitTypeInput)
        Me.Controls.Add(Me.permitType)
        Me.Name = "Permit_Header"
        Me.Text = "Permit Header"
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
    Friend WithEvents transferToInput As TextBox
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
    Friend WithEvents customerInput As TextBox
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
End Class
