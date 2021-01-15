<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DivisionalSecretariat
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
        Me.divisionalSecTextBox = New System.Windows.Forms.TextBox()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.cityComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cityLable
        '
        Me.cityLable.AutoSize = True
        Me.cityLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityLable.Location = New System.Drawing.Point(36, 92)
        Me.cityLable.Name = "cityLable"
        Me.cityLable.Size = New System.Drawing.Size(34, 16)
        Me.cityLable.TabIndex = 0
        Me.cityLable.Text = "City"
        '
        'divisionalSectxbox
        '
        Me.divisionalSectxbox.AutoSize = True
        Me.divisionalSectxbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divisionalSectxbox.Location = New System.Drawing.Point(36, 157)
        Me.divisionalSectxbox.Name = "divisionalSectxbox"
        Me.divisionalSectxbox.Size = New System.Drawing.Size(157, 16)
        Me.divisionalSectxbox.TabIndex = 0
        Me.divisionalSectxbox.Text = "Divisional Secretariat"
        '
        'divisionalSecTextBox
        '
        Me.divisionalSecTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divisionalSecTextBox.Location = New System.Drawing.Point(213, 157)
        Me.divisionalSecTextBox.Name = "divisionalSecTextBox"
        Me.divisionalSecTextBox.Size = New System.Drawing.Size(233, 22)
        Me.divisionalSecTextBox.TabIndex = 1
        '
        'savebtn
        '
        Me.savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.Location = New System.Drawing.Point(285, 250)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(85, 39)
        Me.savebtn.TabIndex = 2
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'clearbtn
        '
        Me.clearbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.Location = New System.Drawing.Point(396, 250)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(81, 39)
        Me.clearbtn.TabIndex = 2
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = True
        '
        'cityComboBox
        '
        Me.cityComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityComboBox.FormattingEnabled = True
        Me.cityComboBox.Location = New System.Drawing.Point(213, 87)
        Me.cityComboBox.Name = "cityComboBox"
        Me.cityComboBox.Size = New System.Drawing.Size(233, 24)
        Me.cityComboBox.TabIndex = 3
        '
        'DivisionalSecretariat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 323)
        Me.Controls.Add(Me.cityComboBox)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.divisionalSecTextBox)
        Me.Controls.Add(Me.divisionalSectxbox)
        Me.Controls.Add(Me.cityLable)
        Me.Name = "DivisionalSecretariat"
        Me.Text = "agOffice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cityLable As Label
    Friend WithEvents divisionalSectxbox As Label
    Friend WithEvents divisionalSecTextBox As TextBox
    Friend WithEvents savebtn As Button
    Friend WithEvents clearbtn As Button
    Friend WithEvents cityComboBox As ComboBox
End Class
