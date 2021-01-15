<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.userName = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.userNameLable = New System.Windows.Forms.Label()
        Me.passwordLable = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Button()
        Me.letMeIn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userName
        '
        Me.userName.Location = New System.Drawing.Point(533, 126)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(144, 20)
        Me.userName.TabIndex = 2
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(533, 181)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(144, 20)
        Me.password.TabIndex = 3
        '
        'userNameLable
        '
        Me.userNameLable.AutoSize = True
        Me.userNameLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameLable.Location = New System.Drawing.Point(404, 123)
        Me.userNameLable.Name = "userNameLable"
        Me.userNameLable.Size = New System.Drawing.Size(110, 25)
        Me.userNameLable.TabIndex = 5
        Me.userNameLable.Text = "User Name"
        '
        'passwordLable
        '
        Me.passwordLable.AutoSize = True
        Me.passwordLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLable.Location = New System.Drawing.Point(416, 176)
        Me.passwordLable.Name = "passwordLable"
        Me.passwordLable.Size = New System.Drawing.Size(98, 25)
        Me.passwordLable.TabIndex = 6
        Me.passwordLable.Text = "Password"
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.Location = New System.Drawing.Point(519, 247)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(81, 34)
        Me.clear.TabIndex = 7
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'letMeIn
        '
        Me.letMeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letMeIn.Location = New System.Drawing.Point(619, 247)
        Me.letMeIn.Name = "letMeIn"
        Me.letMeIn.Size = New System.Drawing.Size(80, 35)
        Me.letMeIn.TabIndex = 8
        Me.letMeIn.Text = "LogIn"
        Me.letMeIn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Permit_Issuens_Supporter.My.Resources.Resources.empowerment_checklist_orbit
        Me.PictureBox1.Location = New System.Drawing.Point(3, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(434, 390)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 421)
        Me.Controls.Add(Me.letMeIn)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.passwordLable)
        Me.Controls.Add(Me.userNameLable)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.userName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Permit Manager"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents userName As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents userNameLable As Label
    Friend WithEvents passwordLable As Label
    Friend WithEvents clear As Button
    Friend WithEvents letMeIn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
