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
        Me.gramasewaWasTextBox = New System.Windows.Forms.TextBox()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'gramasewaWasamLabel
        '
        Me.gramasewaWasamLabel.AutoSize = True
        Me.gramasewaWasamLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gramasewaWasamLabel.Location = New System.Drawing.Point(43, 78)
        Me.gramasewaWasamLabel.Name = "gramasewaWasamLabel"
        Me.gramasewaWasamLabel.Size = New System.Drawing.Size(155, 16)
        Me.gramasewaWasamLabel.TabIndex = 0
        Me.gramasewaWasamLabel.Text = "Gramasewa Wasama"
        '
        'gramasewaWasTextBox
        '
        Me.gramasewaWasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gramasewaWasTextBox.Location = New System.Drawing.Point(222, 75)
        Me.gramasewaWasTextBox.Name = "gramasewaWasTextBox"
        Me.gramasewaWasTextBox.Size = New System.Drawing.Size(214, 22)
        Me.gramasewaWasTextBox.TabIndex = 1
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(386, 140)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(90, 32)
        Me.clearBtn.TabIndex = 3
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(264, 140)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(90, 32)
        Me.saveBtn.TabIndex = 4
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'gramaSewaWasama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 213)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.gramasewaWasTextBox)
        Me.Controls.Add(Me.gramasewaWasamLabel)
        Me.Name = "gramaSewaWasama"
        Me.Text = "Grama Sewa Wasama"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gramasewaWasamLabel As Label
    Friend WithEvents gramasewaWasTextBox As TextBox
    Friend WithEvents clearBtn As Button
    Friend WithEvents saveBtn As Button
End Class
