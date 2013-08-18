<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.ComboServerType = New System.Windows.Forms.ComboBox()
        Me.TextUserName = New System.Windows.Forms.TextBox()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.ButtonSet = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboServerType
        '
        Me.ComboServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboServerType.FormattingEnabled = True
        Me.ComboServerType.Location = New System.Drawing.Point(678, 225)
        Me.ComboServerType.Name = "ComboServerType"
        Me.ComboServerType.Size = New System.Drawing.Size(132, 25)
        Me.ComboServerType.TabIndex = 0
        '
        'TextUserName
        '
        Me.TextUserName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextUserName.Location = New System.Drawing.Point(396, 313)
        Me.TextUserName.Name = "TextUserName"
        Me.TextUserName.Size = New System.Drawing.Size(252, 29)
        Me.TextUserName.TabIndex = 1
        Me.TextUserName.Text = "谢浩哲"
        '
        'TextPassword
        '
        Me.TextPassword.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextPassword.Location = New System.Drawing.Point(396, 369)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(252, 29)
        Me.TextPassword.TabIndex = 2
        Me.TextPassword.Text = "zjhzxhz"
        Me.TextPassword.UseSystemPasswordChar = True
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackgroundImage = Global.SoftwareManagementSystem.My.Resources.Resources.Button_Login
        Me.ButtonLogin.Location = New System.Drawing.Point(424, 444)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(123, 29)
        Me.ButtonLogin.TabIndex = 3
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'ButtonSet
        '
        Me.ButtonSet.BackgroundImage = Global.SoftwareManagementSystem.My.Resources.Resources.Button_Set
        Me.ButtonSet.Location = New System.Drawing.Point(36, 581)
        Me.ButtonSet.Name = "ButtonSet"
        Me.ButtonSet.Size = New System.Drawing.Size(123, 29)
        Me.ButtonSet.TabIndex = 4
        Me.ButtonSet.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.BackgroundImage = Global.SoftwareManagementSystem.My.Resources.Resources.Button_Exit
        Me.ButtonExit.Location = New System.Drawing.Point(629, 443)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(122, 30)
        Me.ButtonExit.TabIndex = 5
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SoftwareManagementSystem.My.Resources.Resources.Frm_Login
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonSet)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.TextUserName)
        Me.Controls.Add(Me.ComboServerType)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 640)
        Me.MinimumSize = New System.Drawing.Size(1024, 640)
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "软件基础知识问答系统登录"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboServerType As System.Windows.Forms.ComboBox
    Friend WithEvents TextUserName As System.Windows.Forms.TextBox
    Friend WithEvents TextPassword As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents ButtonSet As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
End Class
