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
        Me.roleInput = New System.Windows.Forms.ComboBox()
        Me.departmentInput = New System.Windows.Forms.ComboBox()
        Me.agOfficeInput = New System.Windows.Forms.ComboBox()
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
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.search = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName.Location = New System.Drawing.Point(75, 103)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(83, 16)
        Me.firstName.TabIndex = 0
        Me.firstName.Text = "First Name"
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userName.Location = New System.Drawing.Point(72, 57)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(86, 16)
        Me.userName.TabIndex = 1
        Me.userName.Text = "User Name"
        '
        'lastName
        '
        Me.lastName.AutoSize = True
        Me.lastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastName.Location = New System.Drawing.Point(425, 104)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(82, 16)
        Me.lastName.TabIndex = 2
        Me.lastName.Text = "Last Name"
        '
        'role
        '
        Me.role.AutoSize = True
        Me.role.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.role.Location = New System.Drawing.Point(117, 199)
        Me.role.Name = "role"
        Me.role.Size = New System.Drawing.Size(41, 16)
        Me.role.TabIndex = 3
        Me.role.Text = "Role"
        '
        'agOffice
        '
        Me.agOffice.AutoSize = True
        Me.agOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agOffice.Location = New System.Drawing.Point(1, 149)
        Me.agOffice.Name = "agOffice"
        Me.agOffice.Size = New System.Drawing.Size(157, 16)
        Me.agOffice.TabIndex = 4
        Me.agOffice.Text = "Divisional Secretariat"
        '
        'department
        '
        Me.department.AutoSize = True
        Me.department.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department.Location = New System.Drawing.Point(419, 147)
        Me.department.Name = "department"
        Me.department.Size = New System.Drawing.Size(88, 16)
        Me.department.TabIndex = 5
        Me.department.Text = "Department"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(431, 199)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(76, 16)
        Me.password.TabIndex = 6
        Me.password.Text = "Password"
        '
        'userNameInput
        '
        Me.userNameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameInput.Location = New System.Drawing.Point(186, 54)
        Me.userNameInput.Name = "userNameInput"
        Me.userNameInput.Size = New System.Drawing.Size(186, 22)
        Me.userNameInput.TabIndex = 8
        '
        'firstNameInput
        '
        Me.firstNameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameInput.Location = New System.Drawing.Point(186, 100)
        Me.firstNameInput.Name = "firstNameInput"
        Me.firstNameInput.Size = New System.Drawing.Size(186, 22)
        Me.firstNameInput.TabIndex = 9
        '
        'lastNameInput
        '
        Me.lastNameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameInput.Location = New System.Drawing.Point(527, 103)
        Me.lastNameInput.Name = "lastNameInput"
        Me.lastNameInput.Size = New System.Drawing.Size(186, 22)
        Me.lastNameInput.TabIndex = 12
        '
        'passwordInput
        '
        Me.passwordInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordInput.Location = New System.Drawing.Point(527, 196)
        Me.passwordInput.Name = "passwordInput"
        Me.passwordInput.Size = New System.Drawing.Size(186, 22)
        Me.passwordInput.TabIndex = 14
        '
        'roleInput
        '
        Me.roleInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roleInput.FormattingEnabled = True
        Me.roleInput.Items.AddRange(New Object() {"ROLE_ADMIN", "ROLE_USER", "ROLE_MANAGER", "ROLE_AUTH_OFFICER"})
        Me.roleInput.Location = New System.Drawing.Point(186, 194)
        Me.roleInput.Name = "roleInput"
        Me.roleInput.Size = New System.Drawing.Size(186, 24)
        Me.roleInput.TabIndex = 17
        '
        'departmentInput
        '
        Me.departmentInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentInput.FormattingEnabled = True
        Me.departmentInput.Location = New System.Drawing.Point(527, 146)
        Me.departmentInput.Name = "departmentInput"
        Me.departmentInput.Size = New System.Drawing.Size(186, 24)
        Me.departmentInput.TabIndex = 18
        '
        'agOfficeInput
        '
        Me.agOfficeInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agOfficeInput.FormattingEnabled = True
        Me.agOfficeInput.Location = New System.Drawing.Point(186, 143)
        Me.agOfficeInput.Name = "agOfficeInput"
        Me.agOfficeInput.Size = New System.Drawing.Size(186, 24)
        Me.agOfficeInput.TabIndex = 19
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(633, 267)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(90, 27)
        Me.clearBtn.TabIndex = 20
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(413, 267)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(90, 27)
        Me.saveBtn.TabIndex = 21
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(768, 24)
        Me.MenuStrip1.TabIndex = 22
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
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DistrictToolStripMenuItem, Me.CityToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.DivisionalSectretariatToolStripMenuItem, Me.GramasewaWasamToolStripMenuItem, Me.PermitTypeToolStripMenuItem, Me.DepartmentToolStripMenuItem})
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
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DepartmentToolStripMenuItem.Text = "Department"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(428, 55)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(75, 23)
        Me.search.TabIndex = 27
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Location = New System.Drawing.Point(523, 267)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(90, 27)
        Me.edit.TabIndex = 28
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'systemUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 316)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.agOfficeInput)
        Me.Controls.Add(Me.departmentInput)
        Me.Controls.Add(Me.roleInput)
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "systemUser"
        Me.Text = "System User"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents roleInput As ComboBox
    Friend WithEvents departmentInput As ComboBox
    Friend WithEvents agOfficeInput As ComboBox
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
    Friend WithEvents search As Button
    Friend WithEvents edit As Button
    Friend WithEvents DepartmentToolStripMenuItem As ToolStripMenuItem
End Class
