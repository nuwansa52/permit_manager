﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class report
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.userTransaction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 101)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Permit Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'userTransaction
        '
        Me.userTransaction.Location = New System.Drawing.Point(262, 40)
        Me.userTransaction.Name = "userTransaction"
        Me.userTransaction.Size = New System.Drawing.Size(149, 101)
        Me.userTransaction.TabIndex = 1
        Me.userTransaction.Text = "User Transactions"
        Me.userTransaction.UseVisualStyleBackColor = True
        '
        'report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 196)
        Me.Controls.Add(Me.userTransaction)
        Me.Controls.Add(Me.Button1)
        Me.Name = "report"
        Me.Text = "Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents userTransaction As Button
End Class
