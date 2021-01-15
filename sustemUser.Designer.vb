<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class systemUser
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
        Me.firstName = New System.Windows.Forms.Label()
        Me.userName = New System.Windows.Forms.Label()
        Me.lastName = New System.Windows.Forms.Label()
        Me.role = New System.Windows.Forms.Label()
        Me.agOffice = New System.Windows.Forms.Label()
        Me.department = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.userNameInput = New System.Windows.Forms.TextBox()
        Me.firstNameInput = New System.Windows.Forms.TextBox()
        Me.lastNameInput = New System.Windows.Forms.TextBox()
        Me.passwordInput = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.roleInput = New System.Windows.Forms.ComboBox()
        Me.departmentInput = New System.Windows.Forms.ComboBox()
        Me.agOfficeInput = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName.Location = New System.Drawing.Point(68, 139)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(76, 17)
        Me.firstName.TabIndex = 0
        Me.firstName.Text = "First Name"
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userName.Location = New System.Drawing.Point(65, 71)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(79, 17)
        Me.userName.TabIndex = 1
        Me.userName.Text = "User Name"
        '
        'lastName
        '
        Me.lastName.AutoSize = True
        Me.lastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastName.Location = New System.Drawing.Point(442, 139)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(76, 17)
        Me.lastName.TabIndex = 2
        Me.lastName.Text = "Last Name"
        '
        'role
        '
        Me.role.AutoSize = True
        Me.role.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.role.Location = New System.Drawing.Point(107, 280)
        Me.role.Name = "role"
        Me.role.Size = New System.Drawing.Size(37, 17)
        Me.role.TabIndex = 3
        Me.role.Text = "Role"
        '
        'agOffice
        '
        Me.agOffice.AutoSize = True
        Me.agOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agOffice.Location = New System.Drawing.Point(75, 208)
        Me.agOffice.Name = "agOffice"
        Me.agOffice.Size = New System.Drawing.Size(69, 17)
        Me.agOffice.TabIndex = 4
        Me.agOffice.Text = "AG Office"
        '
        'department
        '
        Me.department.AutoSize = True
        Me.department.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department.Location = New System.Drawing.Point(436, 208)
        Me.department.Name = "department"
        Me.department.Size = New System.Drawing.Size(82, 17)
        Me.department.TabIndex = 5
        Me.department.Text = "Department"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(449, 280)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(69, 17)
        Me.password.TabIndex = 6
        Me.password.Text = "Password"
        '
        'userNameInput
        '
        Me.userNameInput.Location = New System.Drawing.Point(184, 70)
        Me.userNameInput.Name = "userNameInput"
        Me.userNameInput.Size = New System.Drawing.Size(186, 20)
        Me.userNameInput.TabIndex = 8
        '
        'firstNameInput
        '
        Me.firstNameInput.Location = New System.Drawing.Point(184, 138)
        Me.firstNameInput.Name = "firstNameInput"
        Me.firstNameInput.Size = New System.Drawing.Size(186, 20)
        Me.firstNameInput.TabIndex = 9
        '
        'lastNameInput
        '
        Me.lastNameInput.Location = New System.Drawing.Point(560, 138)
        Me.lastNameInput.Name = "lastNameInput"
        Me.lastNameInput.Size = New System.Drawing.Size(186, 20)
        Me.lastNameInput.TabIndex = 12
        '
        'passwordInput
        '
        Me.passwordInput.Location = New System.Drawing.Point(560, 279)
        Me.passwordInput.Name = "passwordInput"
        Me.passwordInput.Size = New System.Drawing.Size(186, 20)
        Me.passwordInput.TabIndex = 14
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(570, 395)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(75, 23)
        Me.save.TabIndex = 15
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(687, 395)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 23)
        Me.clear.TabIndex = 16
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'roleInput
        '
        Me.roleInput.FormattingEnabled = True
        Me.roleInput.Items.AddRange(New Object() {"ROLE_ADMIN", "ROLE_USER", "ROLE_MANAGER", "ROLE_AUTH_OFFICER"})
        Me.roleInput.Location = New System.Drawing.Point(184, 280)
        Me.roleInput.Name = "roleInput"
        Me.roleInput.Size = New System.Drawing.Size(186, 21)
        Me.roleInput.TabIndex = 17
        '
        'departmentInput
        '
        Me.departmentInput.FormattingEnabled = True
        Me.departmentInput.Location = New System.Drawing.Point(560, 207)
        Me.departmentInput.Name = "departmentInput"
        Me.departmentInput.Size = New System.Drawing.Size(186, 21)
        Me.departmentInput.TabIndex = 18
        '
        'agOfficeInput
        '
        Me.agOfficeInput.FormattingEnabled = True
        Me.agOfficeInput.Location = New System.Drawing.Point(184, 207)
        Me.agOfficeInput.Name = "agOfficeInput"
        Me.agOfficeInput.Size = New System.Drawing.Size(186, 21)
        Me.agOfficeInput.TabIndex = 19
        '
        'systemUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.agOfficeInput)
        Me.Controls.Add(Me.departmentInput)
        Me.Controls.Add(Me.roleInput)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.passwordInput)
        Me.Controls.Add(Me.lastNameInput)
        Me.Controls.Add(Me.firstNameInput)
        Me.Controls.Add(Me.userNameInput)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.department)
        Me.Controls.Add(Me.agOffice)
        Me.Controls.Add(Me.role)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.firstName)
        Me.Name = "systemUser"
        Me.Text = "System User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstName As Label
    Friend WithEvents userName As Label
    Friend WithEvents lastName As Label
    Friend WithEvents role As Label
    Friend WithEvents agOffice As Label
    Friend WithEvents department As Label
    Friend WithEvents password As Label
    Friend WithEvents userNameInput As TextBox
    Friend WithEvents firstNameInput As TextBox
    Friend WithEvents lastNameInput As TextBox
    Friend WithEvents passwordInput As TextBox
    Friend WithEvents save As Button
    Friend WithEvents clear As Button
    Friend WithEvents roleInput As ComboBox
    Friend WithEvents departmentInput As ComboBox
    Friend WithEvents agOfficeInput As ComboBox
End Class
