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
        Me.districtTextBox = New System.Windows.Forms.TextBox()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'districtLabel
        '
        Me.districtLabel.AutoSize = True
        Me.districtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.districtLabel.Location = New System.Drawing.Point(60, 84)
        Me.districtLabel.Name = "districtLabel"
        Me.districtLabel.Size = New System.Drawing.Size(56, 16)
        Me.districtLabel.TabIndex = 0
        Me.districtLabel.Text = "District"
        '
        'districtTextBox
        '
        Me.districtTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.districtTextBox.Location = New System.Drawing.Point(147, 81)
        Me.districtTextBox.Name = "districtTextBox"
        Me.districtTextBox.Size = New System.Drawing.Size(233, 22)
        Me.districtTextBox.TabIndex = 6
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(319, 140)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(90, 32)
        Me.clearBtn.TabIndex = 7
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(197, 140)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(90, 32)
        Me.saveBtn.TabIndex = 8
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'district
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 221)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.districtTextBox)
        Me.Controls.Add(Me.districtLabel)
        Me.Name = "district"
        Me.Text = "District"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents districtLabel As Label
    Friend WithEvents districtTextBox As TextBox
    Friend WithEvents clearBtn As Button
    Friend WithEvents saveBtn As Button
End Class
