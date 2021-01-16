<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class city
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
        Me.cityLabel = New System.Windows.Forms.Label()
        Me.cityInput = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistrictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionalSectretariatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GramasewaWasamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermitTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.search = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.district = New System.Windows.Forms.Label()
        Me.districtInput = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cityLabel
        '
        Me.cityLabel.AutoSize = True
        Me.cityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityLabel.Location = New System.Drawing.Point(27, 63)
        Me.cityLabel.Name = "cityLabel"
        Me.cityLabel.Size = New System.Drawing.Size(34, 16)
        Me.cityLabel.TabIndex = 0
        Me.cityLabel.Text = "City"
        '
        'cityInput
        '
        Me.cityInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityInput.Location = New System.Drawing.Point(100, 60)
        Me.cityInput.Name = "cityInput"
        Me.cityInput.Size = New System.Drawing.Size(233, 22)
        Me.cityInput.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(450, 24)
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DistrictToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.DivisionalSectretariatToolStripMenuItem, Me.GramasewaWasamToolStripMenuItem, Me.DepartmentToolStripMenuItem, Me.PermitTypeToolStripMenuItem, Me.SystemUserToolStripMenuItem})
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
        Me.search.Location = New System.Drawing.Point(340, 60)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(75, 23)
        Me.search.TabIndex = 24
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Location = New System.Drawing.Point(216, 163)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(90, 27)
        Me.edit.TabIndex = 31
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(325, 163)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(90, 27)
        Me.clearBtn.TabIndex = 29
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(106, 163)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(90, 27)
        Me.saveBtn.TabIndex = 30
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'district
        '
        Me.district.AutoSize = True
        Me.district.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.district.Location = New System.Drawing.Point(27, 108)
        Me.district.Name = "district"
        Me.district.Size = New System.Drawing.Size(59, 17)
        Me.district.TabIndex = 32
        Me.district.Text = "District"
        '
        'districtInput
        '
        Me.districtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.districtInput.FormattingEnabled = True
        Me.districtInput.Location = New System.Drawing.Point(100, 105)
        Me.districtInput.Name = "districtInput"
        Me.districtInput.Size = New System.Drawing.Size(233, 24)
        Me.districtInput.TabIndex = 33
        '
        'city
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 211)
        Me.Controls.Add(Me.districtInput)
        Me.Controls.Add(Me.district)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cityInput)
        Me.Controls.Add(Me.cityLabel)
        Me.Name = "city"
        Me.Text = "City"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cityLabel As Label
    Friend WithEvents cityInput As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DistrictToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DivisionalSectretariatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GramasewaWasamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermitTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents search As Button
    Friend WithEvents edit As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents district As Label
    Friend WithEvents districtInput As ComboBox
End Class
