<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class divisionalSecretariat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cityLable = New System.Windows.Forms.Label()
        Me.divisionalSectxbox = New System.Windows.Forms.Label()
        Me.divisionalSecInput = New System.Windows.Forms.TextBox()
        Me.cityInput = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistrictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GramasewaWasamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermitTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.search = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cityLable
        '
        Me.cityLable.AutoSize = True
        Me.cityLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityLable.Location = New System.Drawing.Point(148, 109)
        Me.cityLable.Name = "cityLable"
        Me.cityLable.Size = New System.Drawing.Size(34, 16)
        Me.cityLable.TabIndex = 0
        Me.cityLable.Text = "City"
        '
        'divisionalSectxbox
        '
        Me.divisionalSectxbox.AutoSize = True
        Me.divisionalSectxbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divisionalSectxbox.Location = New System.Drawing.Point(25, 61)
        Me.divisionalSectxbox.Name = "divisionalSectxbox"
        Me.divisionalSectxbox.Size = New System.Drawing.Size(157, 16)
        Me.divisionalSectxbox.TabIndex = 0
        Me.divisionalSectxbox.Text = "Divisional Secretariat"
        '
        'divisionalSecInput
        '
        Me.divisionalSecInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divisionalSecInput.Location = New System.Drawing.Point(202, 61)
        Me.divisionalSecInput.Name = "divisionalSecInput"
        Me.divisionalSecInput.Size = New System.Drawing.Size(233, 22)
        Me.divisionalSecInput.TabIndex = 1
        '
        'cityInput
        '
        Me.cityInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityInput.FormattingEnabled = True
        Me.cityInput.Location = New System.Drawing.Point(202, 106)
        Me.cityInput.Name = "cityInput"
        Me.cityInput.Size = New System.Drawing.Size(233, 24)
        Me.cityInput.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(554, 24)
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DistrictToolStripMenuItem, Me.CityToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.GramasewaWasamToolStripMenuItem, Me.DepartmentToolStripMenuItem, Me.PermitTypeToolStripMenuItem, Me.SystemUserToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'DistrictToolStripMenuItem
        '
        Me.DistrictToolStripMenuItem.Name = "DistrictToolStripMenuItem"
        Me.DistrictToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DistrictToolStripMenuItem.Text = "District"
        '
        'CityToolStripMenuItem
        '
        Me.CityToolStripMenuItem.Name = "CityToolStripMenuItem"
        Me.CityToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CityToolStripMenuItem.Text = "City"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'GramasewaWasamToolStripMenuItem
        '
        Me.GramasewaWasamToolStripMenuItem.Name = "GramasewaWasamToolStripMenuItem"
        Me.GramasewaWasamToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.GramasewaWasamToolStripMenuItem.Text = "Gramasewa Wasam"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DepartmentToolStripMenuItem.Text = "Department"
        '
        'PermitTypeToolStripMenuItem
        '
        Me.PermitTypeToolStripMenuItem.Name = "PermitTypeToolStripMenuItem"
        Me.PermitTypeToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PermitTypeToolStripMenuItem.Text = "Permit Type"
        '
        'SystemUserToolStripMenuItem
        '
        Me.SystemUserToolStripMenuItem.Name = "SystemUserToolStripMenuItem"
        Me.SystemUserToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SystemUserToolStripMenuItem.Text = "System User"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(456, 61)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(75, 23)
        Me.search.TabIndex = 27
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Location = New System.Drawing.Point(332, 172)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(90, 27)
        Me.edit.TabIndex = 34
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(441, 172)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(90, 27)
        Me.clearBtn.TabIndex = 32
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(222, 172)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(90, 27)
        Me.saveBtn.TabIndex = 33
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'divisionalSecretariat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 227)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cityInput)
        Me.Controls.Add(Me.divisionalSecInput)
        Me.Controls.Add(Me.divisionalSectxbox)
        Me.Controls.Add(Me.cityLable)
        Me.Name = "divisionalSecretariat"
        Me.Text = "Divisional Secretariat"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cityLable As Label
    Friend WithEvents divisionalSectxbox As Label
    Friend WithEvents divisionalSecInput As TextBox
    Friend WithEvents cityInput As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DistrictToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GramasewaWasamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermitTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents search As Button
    Friend WithEvents edit As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents saveBtn As Button
End Class
