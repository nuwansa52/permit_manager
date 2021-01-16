<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class district
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
        Me.districtLabel = New System.Windows.Forms.Label()
        Me.districtInput = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.PermitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssuePermitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'districtLabel
        '
        Me.districtLabel.AutoSize = True
        Me.districtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.districtLabel.Location = New System.Drawing.Point(24, 87)
        Me.districtLabel.Name = "districtLabel"
        Me.districtLabel.Size = New System.Drawing.Size(56, 16)
        Me.districtLabel.TabIndex = 0
        Me.districtLabel.Text = "District"
        '
        'districtInput
        '
        Me.districtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.districtInput.Location = New System.Drawing.Point(111, 84)
        Me.districtInput.Name = "districtInput"
        Me.districtInput.Size = New System.Drawing.Size(233, 22)
        Me.districtInput.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.PermitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(458, 24)
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CityToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.DivisionalSectretariatToolStripMenuItem, Me.GramasewaWasamToolStripMenuItem, Me.DepartmentToolStripMenuItem, Me.PermitTypeToolStripMenuItem, Me.SystemUserToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
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
        Me.search.Location = New System.Drawing.Point(362, 84)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(75, 23)
        Me.search.TabIndex = 27
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Location = New System.Drawing.Point(237, 155)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(90, 27)
        Me.edit.TabIndex = 34
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(347, 155)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(90, 27)
        Me.clearBtn.TabIndex = 32
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(127, 155)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(90, 27)
        Me.saveBtn.TabIndex = 33
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'PermitToolStripMenuItem
        '
        Me.PermitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem1, Me.IssuePermitToolStripMenuItem})
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
        'IssuePermitToolStripMenuItem
        '
        Me.IssuePermitToolStripMenuItem.Name = "IssuePermitToolStripMenuItem"
        Me.IssuePermitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IssuePermitToolStripMenuItem.Text = "Issue Permit"
        '
        'district
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 221)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.districtInput)
        Me.Controls.Add(Me.districtLabel)
        Me.Name = "district"
        Me.Text = "District"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents districtLabel As Label
    Friend WithEvents districtInput As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CityToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents PermitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IssuePermitToolStripMenuItem As ToolStripMenuItem
End Class
