<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ComboDomain = New System.Windows.Forms.ComboBox()
        Me.TextUserName = New System.Windows.Forms.TextBox()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackgroundImage = Global.SoftwareEnrollmentSystem.My.Resources.Resources.Button_Login
        Me.ButtonLogin.Location = New System.Drawing.Point(401, 445)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(122, 30)
        Me.ButtonLogin.TabIndex = 3
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'ButtonBack
        '
        Me.ButtonBack.BackgroundImage = Global.SoftwareEnrollmentSystem.My.Resources.Resources.Button_Back
        Me.ButtonBack.Location = New System.Drawing.Point(604, 445)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(124, 30)
        Me.ButtonBack.TabIndex = 4
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ComboDomain
        '
        Me.ComboDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboDomain.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboDomain.FormattingEnabled = True
        Me.ComboDomain.Items.AddRange(New Object() {"管理中心", "控制面板"})
        Me.ComboDomain.Location = New System.Drawing.Point(413, 286)
        Me.ComboDomain.Name = "ComboDomain"
        Me.ComboDomain.Size = New System.Drawing.Size(260, 29)
        Me.ComboDomain.TabIndex = 0
        '
        'TextUserName
        '
        Me.TextUserName.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextUserName.Location = New System.Drawing.Point(413, 338)
        Me.TextUserName.Name = "TextUserName"
        Me.TextUserName.Size = New System.Drawing.Size(260, 29)
        Me.TextUserName.TabIndex = 1
        Me.TextUserName.Text = "谢浩哲"
        '
        'TextPassword
        '
        Me.TextPassword.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextPassword.Location = New System.Drawing.Point(413, 392)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(260, 29)
        Me.TextPassword.TabIndex = 2
        Me.TextPassword.Text = "zjhzxhz"
        Me.TextPassword.UseSystemPasswordChar = True
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SoftwareEnrollmentSystem.My.Resources.Resources.Frm_Login
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.TextUserName)
        Me.Controls.Add(Me.ComboDomain)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 640)
        Me.MinimumSize = New System.Drawing.Size(1024, 640)
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents ComboDomain As System.Windows.Forms.ComboBox
    Friend WithEvents TextUserName As System.Windows.Forms.TextBox
    Friend WithEvents TextPassword As System.Windows.Forms.TextBox
End Class
