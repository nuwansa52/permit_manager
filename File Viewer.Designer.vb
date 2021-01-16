<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fileViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fileViewer))
        Me.adobePdfReader = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.adobePdfReader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'adobePdfReader
        '
        Me.adobePdfReader.Enabled = True
        Me.adobePdfReader.Location = New System.Drawing.Point(0, -1)
        Me.adobePdfReader.Name = "adobePdfReader"
        Me.adobePdfReader.OcxState = CType(resources.GetObject("adobePdfReader.OcxState"), System.Windows.Forms.AxHost.State)
        Me.adobePdfReader.Size = New System.Drawing.Size(1045, 643)
        Me.adobePdfReader.TabIndex = 16
        '
        'fileViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 644)
        Me.Controls.Add(Me.adobePdfReader)
        Me.Name = "fileViewer"
        Me.Text = "File Viewer"
        CType(Me.adobePdfReader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents adobePdfReader As AxAcroPDFLib.AxAcroPDF
End Class
