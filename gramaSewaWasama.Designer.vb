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
        Me.saveButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'gramasewaWasamLabel
        '
        Me.gramasewaWasamLabel.AutoSize = True
        Me.gramasewaWasamLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gramasewaWasamLabel.Location = New System.Drawing.Point(65, 94)
        Me.gramasewaWasamLabel.Name = "gramasewaWasamLabel"
        Me.gramasewaWasamLabel.Size = New System.Drawing.Size(155, 16)
        Me.gramasewaWasamLabel.TabIndex = 0
        Me.gramasewaWasamLabel.Text = "Gramasewa Wasama"
        '
        'gramasewaWasTextBox
        '
        Me.gramasewaWasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gramasewaWasTextBox.Location = New System.Drawing.Point(226, 90)
        Me.gramasewaWasTextBox.Name = "gramasewaWasTextBox"
        Me.gramasewaWasTextBox.Size = New System.Drawing.Size(214, 22)
        Me.gramasewaWasTextBox.TabIndex = 1
        '
        'saveButton
        '
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Location = New System.Drawing.Point(228, 151)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 34)
        Me.saveButton.TabIndex = 2
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(309, 151)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 34)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'gramaSewaWasama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 273)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.gramasewaWasTextBox)
        Me.Controls.Add(Me.gramasewaWasamLabel)
        Me.Name = "gramaSewaWasama"
        Me.Text = "gramaSewaWasama"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gramasewaWasamLabel As Label
    Friend WithEvents gramasewaWasTextBox As TextBox
    Friend WithEvents saveButton As Button
    Friend WithEvents clearButton As Button
End Class
