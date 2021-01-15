<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserfnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserlnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserroleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserdepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SystemuserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._DCBA___ProjectDataSet = New Permit_Issuens_Supporter._DCBA___ProjectDataSet()
        Me.System_userTableAdapter = New Permit_Issuens_Supporter._DCBA___ProjectDataSetTableAdapters.system_userTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemuserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DCBA___ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(413, 73)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(594, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SelectedValue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(594, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "SaveFormData"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(594, 229)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "UpdateValue"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UseridDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.UserfnameDataGridViewTextBoxColumn, Me.UserlnameDataGridViewTextBoxColumn, Me.UserroleDataGridViewTextBoxColumn, Me.UserdepartmentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SystemuserBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 288)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(646, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'UseridDataGridViewTextBoxColumn
        '
        Me.UseridDataGridViewTextBoxColumn.DataPropertyName = "user_id"
        Me.UseridDataGridViewTextBoxColumn.HeaderText = "user_id"
        Me.UseridDataGridViewTextBoxColumn.Name = "UseridDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "user_name"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "user_name"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'UserfnameDataGridViewTextBoxColumn
        '
        Me.UserfnameDataGridViewTextBoxColumn.DataPropertyName = "user_fname"
        Me.UserfnameDataGridViewTextBoxColumn.HeaderText = "user_fname"
        Me.UserfnameDataGridViewTextBoxColumn.Name = "UserfnameDataGridViewTextBoxColumn"
        '
        'UserlnameDataGridViewTextBoxColumn
        '
        Me.UserlnameDataGridViewTextBoxColumn.DataPropertyName = "user_lname"
        Me.UserlnameDataGridViewTextBoxColumn.HeaderText = "user_lname"
        Me.UserlnameDataGridViewTextBoxColumn.Name = "UserlnameDataGridViewTextBoxColumn"
        '
        'UserroleDataGridViewTextBoxColumn
        '
        Me.UserroleDataGridViewTextBoxColumn.DataPropertyName = "user_role"
        Me.UserroleDataGridViewTextBoxColumn.HeaderText = "user_role"
        Me.UserroleDataGridViewTextBoxColumn.Name = "UserroleDataGridViewTextBoxColumn"
        '
        'UserdepartmentDataGridViewTextBoxColumn
        '
        Me.UserdepartmentDataGridViewTextBoxColumn.DataPropertyName = "user_department"
        Me.UserdepartmentDataGridViewTextBoxColumn.HeaderText = "user_department"
        Me.UserdepartmentDataGridViewTextBoxColumn.Name = "UserdepartmentDataGridViewTextBoxColumn"
        '
        'SystemuserBindingSource
        '
        Me.SystemuserBindingSource.DataMember = "system_user"
        Me.SystemuserBindingSource.DataSource = Me._DCBA___ProjectDataSet
        '
        '_DCBA___ProjectDataSet
        '
        Me._DCBA___ProjectDataSet.DataSetName = "_DCBA___ProjectDataSet"
        Me._DCBA___ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'System_userTableAdapter
        '
        Me.System_userTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(317, 151)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemuserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DCBA___ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _DCBA___ProjectDataSet As _DCBA___ProjectDataSet
    Friend WithEvents SystemuserBindingSource As BindingSource
    Friend WithEvents System_userTableAdapter As _DCBA___ProjectDataSetTableAdapters.system_userTableAdapter
    Friend WithEvents UseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserfnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserlnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserroleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserdepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
End Class
