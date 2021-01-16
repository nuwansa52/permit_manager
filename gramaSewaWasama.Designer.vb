<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gramaSewaWasama
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
        Me.gramasewaWasamLabel = New System.Windows.Forms.Label()
        Me.gramasewaWasInput = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistrictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionalSectretariatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermitTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.search = New System.Windows.Forms.Button()
        Me.divisionalSecretariatInput = New System.Windows.Forms.ComboBox()
        Me.district = New System.Windows.Forms.Label()
        Me.edit = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gramasewaWasamLabel
        '
        Me.gramasewaWasamLabel.AutoSize = True
        Me.gramasewaWasamLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gramasewaWasamLabel.Location = New System.Drawing.Point(25, 70)
        Me.gramasewaWasamLabel.Name = "gramasewaWasamLabel"
        Me.gramasewaWasamLabel.Size = New System.Drawing.Size(155, 16)
        Me.gramasewaWasamLabel.TabIndex = 0
        Me.gramasewaWasamLabel.Text = "Gramasewa Wasama"
        '
        'gramasewaWasInput
        '
        Me.gramasewaWasInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gramasewaWasInput.Location = New System.Drawing.Point(204, 67)
        Me.gramasewaWasInput.Name = "gramasewaWasInput"
        Me.gramasewaWasInput.Size = New System.Drawing.Size(214, 22)
        Me.gramasewaWasInput.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(525, 24)
        Me.MenuStrip1.TabIndex = 23
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DistrictToolStripMenuItem, Me.CityToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.DivisionalSectretariatToolStripMenuItem, Me.DepartmentToolStripMenuItem, Me.PermitTypeToolStripMenuItem, Me.SystemUserToolStripMenuItem})
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
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DepartmentToolStripMenuItem.Text = "Department"
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
        'search
        '
        Me.search.Location = New System.Drawing.Point(431, 67)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(75, 23)
        Me.search.TabIndex = 27
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = True
        '
        'divisionalSecretariatInput
        '
        Me.divisionalSecretariatInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divisionalSecretariatInput.FormattingEnabled = True
        Me.divisionalSecretariatInput.Location = New System.Drawing.Point(204, 116)
        Me.divisionalSecretariatInput.Name = "divisionalSecretariatInput"
        Me.divisionalSecretariatInput.Size = New System.Drawing.Size(214, 24)
        Me.divisionalSecretariatInput.TabIndex = 35
        '
        'district
        '
        Me.district.AutoSize = True
        Me.district.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.district.Location = New System.Drawing.Point(17, 119)
        Me.district.Name = "district"
        Me.district.Size = New System.Drawing.Size(163, 17)
        Me.district.TabIndex = 34
        Me.district.Text = "Divisional Secretariat"
        '
        'edit
        '
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Location = New System.Drawing.Point(305, 172)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(90, 27)
        Me.edit.TabIndex = 38
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(414, 172)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(90, 27)
        Me.clearBtn.TabIndex = 36
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(195, 172)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(90, 27)
        Me.saveBtn.TabIndex = 37
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'gramaSewaWasama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 225)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.divisionalSecretariatInput)
        Me.Controls.Add(Me.district)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gramasewaWasInput)
        Me.Controls.Add(Me.gramasewaWasamLabel)
        Me.Name = "gramaSewaWasama"
        Me.Text = "Grama Sewa Wasama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gramasewaWasamLabel As Label
    Friend WithEvents gramasewaWasInput As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DistrictToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DivisionalSectretariatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermitTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents search As Button
    Friend WithEvents divisionalSecretariatInput As ComboBox
    Friend WithEvents district As Label
    Friend WithEvents edit As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents saveBtn As Button
End Class
