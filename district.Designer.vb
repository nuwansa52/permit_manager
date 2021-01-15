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
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.districtComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'districtLabel
        '
        Me.districtLabel.AutoSize = True
        Me.districtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.districtLabel.Location = New System.Drawing.Point(74, 119)
        Me.districtLabel.Name = "districtLabel"
        Me.districtLabel.Size = New System.Drawing.Size(56, 16)
        Me.districtLabel.TabIndex = 0
        Me.districtLabel.Text = "District"
        '
        'saveBtn
        '
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(189, 184)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(87, 40)
        Me.saveBtn.TabIndex = 2
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(281, 184)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(87, 40)
        Me.clearBtn.TabIndex = 2
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'districtComboBox
        '
        Me.districtComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.districtComboBox.FormattingEnabled = True
        Me.districtComboBox.Location = New System.Drawing.Point(189, 111)
        Me.districtComboBox.Name = "districtComboBox"
        Me.districtComboBox.Size = New System.Drawing.Size(179, 24)
        Me.districtComboBox.TabIndex = 3
        '
        'district
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 290)
        Me.Controls.Add(Me.districtComboBox)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.districtLabel)
        Me.Name = "district"
        Me.Text = "district"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents districtLabel As Label
    Friend WithEvents saveBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents districtComboBox As ComboBox
End Class
