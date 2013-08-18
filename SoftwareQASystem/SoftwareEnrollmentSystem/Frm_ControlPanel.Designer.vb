<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ControlPanel
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemManagementCenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemMainForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSeperator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSeperator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupServerSettings = New System.Windows.Forms.GroupBox()
        Me.TextStandbyServerPort = New System.Windows.Forms.TextBox()
        Me.TextMainServerPort = New System.Windows.Forms.TextBox()
        Me.CheckBoxMainServer = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStandbyServer = New System.Windows.Forms.CheckBox()
        Me.ComboStandbyServerIpAddress = New System.Windows.Forms.ComboBox()
        Me.ComboMainServerIpAddress = New System.Windows.Forms.ComboBox()
        Me.LabelStandbyServerPort = New System.Windows.Forms.Label()
        Me.LabelStandbyServerIpAddress = New System.Windows.Forms.Label()
        Me.LabelMainServerPort = New System.Windows.Forms.Label()
        Me.LabelStandbyServer = New System.Windows.Forms.Label()
        Me.LabelMainServerIpAddress = New System.Windows.Forms.Label()
        Me.LabelMainServer = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.ButtonSchoolSettings = New System.Windows.Forms.Label()
        Me.ButtonServerSettings = New System.Windows.Forms.Label()
        Me.ButtonSystemSettings = New System.Windows.Forms.Label()
        Me.GroupSystemSettings = New System.Windows.Forms.GroupBox()
        Me.ComboMode = New System.Windows.Forms.ComboBox()
        Me.LabelMode = New System.Windows.Forms.Label()
        Me.LabelAdministratorPassword = New System.Windows.Forms.Label()
        Me.TextAdministratorUserName = New System.Windows.Forms.TextBox()
        Me.TextAdministratorPassword = New System.Windows.Forms.TextBox()
        Me.LabelAdministratorUserName = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.GroupSchoolSettings = New System.Windows.Forms.GroupBox()
        Me.ButtonDeleteNode = New System.Windows.Forms.Button()
        Me.ButtonAddProfession = New System.Windows.Forms.Button()
        Me.ButtonAddSchool = New System.Windows.Forms.Button()
        Me.TreeViewSchool = New System.Windows.Forms.TreeView()
        Me.MenuStrip.SuspendLayout()
        Me.GroupServerSettings.SuspendLayout()
        Me.GroupSystemSettings.SuspendLayout()
        Me.GroupSchoolSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSystem, Me.MenuHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1024, 25)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MenuSystem
        '
        Me.MenuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemManagementCenter, Me.MenuItemMainForm, Me.MenuItemSeperator1, Me.MenuItemLogout, Me.MenuItemExit})
        Me.MenuSystem.Name = "MenuSystem"
        Me.MenuSystem.Size = New System.Drawing.Size(59, 21)
        Me.MenuSystem.Text = "系统(&S)"
        '
        'MenuItemManagementCenter
        '
        Me.MenuItemManagementCenter.Name = "MenuItemManagementCenter"
        Me.MenuItemManagementCenter.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemManagementCenter.Text = "管理中心(&M)"
        '
        'MenuItemMainForm
        '
        Me.MenuItemMainForm.Name = "MenuItemMainForm"
        Me.MenuItemMainForm.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemMainForm.Text = "返回主窗体(&B)"
        '
        'MenuItemSeperator1
        '
        Me.MenuItemSeperator1.Name = "MenuItemSeperator1"
        Me.MenuItemSeperator1.Size = New System.Drawing.Size(149, 6)
        '
        'MenuItemLogout
        '
        Me.MenuItemLogout.Name = "MenuItemLogout"
        Me.MenuItemLogout.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemLogout.Text = "退出登录(&L)"
        '
        'MenuItemExit
        '
        Me.MenuItemExit.Name = "MenuItemExit"
        Me.MenuItemExit.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemExit.Text = "退出系统(&X)"
        '
        'MenuHelp
        '
        Me.MenuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemHelp, Me.MenuItemSeperator2, Me.MenuItemAbout})
        Me.MenuHelp.Name = "MenuHelp"
        Me.MenuHelp.Size = New System.Drawing.Size(61, 21)
        Me.MenuHelp.Text = "帮助(&H)"
        '
        'MenuItemHelp
        '
        Me.MenuItemHelp.Name = "MenuItemHelp"
        Me.MenuItemHelp.Size = New System.Drawing.Size(157, 22)
        Me.MenuItemHelp.Text = "帮助和支持(F1)"
        '
        'MenuItemSeperator2
        '
        Me.MenuItemSeperator2.Name = "MenuItemSeperator2"
        Me.MenuItemSeperator2.Size = New System.Drawing.Size(154, 6)
        '
        'MenuItemAbout
        '
        Me.MenuItemAbout.Name = "MenuItemAbout"
        Me.MenuItemAbout.Size = New System.Drawing.Size(157, 22)
        Me.MenuItemAbout.Text = "关于(&A)"
        '
        'GroupServerSettings
        '
        Me.GroupServerSettings.BackColor = System.Drawing.Color.Transparent
        Me.GroupServerSettings.Controls.Add(Me.TextStandbyServerPort)
        Me.GroupServerSettings.Controls.Add(Me.TextMainServerPort)
        Me.GroupServerSettings.Controls.Add(Me.CheckBoxMainServer)
        Me.GroupServerSettings.Controls.Add(Me.CheckBoxStandbyServer)
        Me.GroupServerSettings.Controls.Add(Me.ComboStandbyServerIpAddress)
        Me.GroupServerSettings.Controls.Add(Me.ComboMainServerIpAddress)
        Me.GroupServerSettings.Controls.Add(Me.LabelStandbyServerPort)
        Me.GroupServerSettings.Controls.Add(Me.LabelStandbyServerIpAddress)
        Me.GroupServerSettings.Controls.Add(Me.LabelMainServerPort)
        Me.GroupServerSettings.Controls.Add(Me.LabelStandbyServer)
        Me.GroupServerSettings.Controls.Add(Me.LabelMainServerIpAddress)
        Me.GroupServerSettings.Controls.Add(Me.LabelMainServer)
        Me.GroupServerSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupServerSettings.Location = New System.Drawing.Point(436, 216)
        Me.GroupServerSettings.Name = "GroupServerSettings"
        Me.GroupServerSettings.Size = New System.Drawing.Size(500, 250)
        Me.GroupServerSettings.TabIndex = 114
        Me.GroupServerSettings.TabStop = False
        Me.GroupServerSettings.Visible = False
        '
        'TextStandbyServerPort
        '
        Me.TextStandbyServerPort.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextStandbyServerPort.Location = New System.Drawing.Point(118, 206)
        Me.TextStandbyServerPort.Name = "TextStandbyServerPort"
        Me.TextStandbyServerPort.Size = New System.Drawing.Size(150, 26)
        Me.TextStandbyServerPort.TabIndex = 11
        '
        'TextMainServerPort
        '
        Me.TextMainServerPort.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextMainServerPort.Location = New System.Drawing.Point(118, 94)
        Me.TextMainServerPort.Name = "TextMainServerPort"
        Me.TextMainServerPort.Size = New System.Drawing.Size(150, 26)
        Me.TextMainServerPort.TabIndex = 10
        '
        'CheckBoxMainServer
        '
        Me.CheckBoxMainServer.AutoSize = True
        Me.CheckBoxMainServer.Checked = True
        Me.CheckBoxMainServer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxMainServer.Location = New System.Drawing.Point(128, 32)
        Me.CheckBoxMainServer.Name = "CheckBoxMainServer"
        Me.CheckBoxMainServer.Size = New System.Drawing.Size(99, 21)
        Me.CheckBoxMainServer.TabIndex = 9
        Me.CheckBoxMainServer.Text = "启用主服务器"
        Me.CheckBoxMainServer.UseVisualStyleBackColor = True
        '
        'CheckBoxStandbyServer
        '
        Me.CheckBoxStandbyServer.AutoSize = True
        Me.CheckBoxStandbyServer.Location = New System.Drawing.Point(128, 141)
        Me.CheckBoxStandbyServer.Name = "CheckBoxStandbyServer"
        Me.CheckBoxStandbyServer.Size = New System.Drawing.Size(111, 21)
        Me.CheckBoxStandbyServer.TabIndex = 8
        Me.CheckBoxStandbyServer.Text = "启用备用服务器"
        Me.CheckBoxStandbyServer.UseVisualStyleBackColor = True
        '
        'ComboStandbyServerIpAddress
        '
        Me.ComboStandbyServerIpAddress.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboStandbyServerIpAddress.FormattingEnabled = True
        Me.ComboStandbyServerIpAddress.Location = New System.Drawing.Point(118, 169)
        Me.ComboStandbyServerIpAddress.Name = "ComboStandbyServerIpAddress"
        Me.ComboStandbyServerIpAddress.Size = New System.Drawing.Size(310, 28)
        Me.ComboStandbyServerIpAddress.TabIndex = 7
        '
        'ComboMainServerIpAddress
        '
        Me.ComboMainServerIpAddress.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboMainServerIpAddress.FormattingEnabled = True
        Me.ComboMainServerIpAddress.Location = New System.Drawing.Point(118, 57)
        Me.ComboMainServerIpAddress.Name = "ComboMainServerIpAddress"
        Me.ComboMainServerIpAddress.Size = New System.Drawing.Size(310, 28)
        Me.ComboMainServerIpAddress.TabIndex = 6
        '
        'LabelStandbyServerPort
        '
        Me.LabelStandbyServerPort.AutoSize = True
        Me.LabelStandbyServerPort.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelStandbyServerPort.ForeColor = System.Drawing.Color.Black
        Me.LabelStandbyServerPort.Location = New System.Drawing.Point(49, 208)
        Me.LabelStandbyServerPort.Name = "LabelStandbyServerPort"
        Me.LabelStandbyServerPort.Size = New System.Drawing.Size(46, 21)
        Me.LabelStandbyServerPort.TabIndex = 5
        Me.LabelStandbyServerPort.Text = "Port:"
        '
        'LabelStandbyServerIpAddress
        '
        Me.LabelStandbyServerIpAddress.AutoSize = True
        Me.LabelStandbyServerIpAddress.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelStandbyServerIpAddress.ForeColor = System.Drawing.Color.Black
        Me.LabelStandbyServerIpAddress.Location = New System.Drawing.Point(49, 171)
        Me.LabelStandbyServerIpAddress.Name = "LabelStandbyServerIpAddress"
        Me.LabelStandbyServerIpAddress.Size = New System.Drawing.Size(61, 21)
        Me.LabelStandbyServerIpAddress.TabIndex = 4
        Me.LabelStandbyServerIpAddress.Text = "IP地址:"
        '
        'LabelMainServerPort
        '
        Me.LabelMainServerPort.AutoSize = True
        Me.LabelMainServerPort.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelMainServerPort.ForeColor = System.Drawing.Color.Black
        Me.LabelMainServerPort.Location = New System.Drawing.Point(49, 96)
        Me.LabelMainServerPort.Name = "LabelMainServerPort"
        Me.LabelMainServerPort.Size = New System.Drawing.Size(46, 21)
        Me.LabelMainServerPort.TabIndex = 3
        Me.LabelMainServerPort.Text = "Port:"
        '
        'LabelStandbyServer
        '
        Me.LabelStandbyServer.AutoSize = True
        Me.LabelStandbyServer.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelStandbyServer.ForeColor = System.Drawing.Color.Black
        Me.LabelStandbyServer.Location = New System.Drawing.Point(27, 138)
        Me.LabelStandbyServer.Name = "LabelStandbyServer"
        Me.LabelStandbyServer.Size = New System.Drawing.Size(95, 22)
        Me.LabelStandbyServer.TabIndex = 2
        Me.LabelStandbyServer.Text = "备用服务器:"
        '
        'LabelMainServerIpAddress
        '
        Me.LabelMainServerIpAddress.AutoSize = True
        Me.LabelMainServerIpAddress.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelMainServerIpAddress.ForeColor = System.Drawing.Color.Black
        Me.LabelMainServerIpAddress.Location = New System.Drawing.Point(49, 60)
        Me.LabelMainServerIpAddress.Name = "LabelMainServerIpAddress"
        Me.LabelMainServerIpAddress.Size = New System.Drawing.Size(61, 21)
        Me.LabelMainServerIpAddress.TabIndex = 1
        Me.LabelMainServerIpAddress.Text = "IP地址:"
        '
        'LabelMainServer
        '
        Me.LabelMainServer.AutoSize = True
        Me.LabelMainServer.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelMainServer.ForeColor = System.Drawing.Color.Black
        Me.LabelMainServer.Location = New System.Drawing.Point(27, 29)
        Me.LabelMainServer.Name = "LabelMainServer"
        Me.LabelMainServer.Size = New System.Drawing.Size(79, 22)
        Me.LabelMainServer.TabIndex = 0
        Me.LabelMainServer.Text = "主服务器:"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelTitle.Location = New System.Drawing.Point(384, 176)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(113, 28)
        Me.LabelTitle.TabIndex = 112
        Me.LabelTitle.Text = "LabelTitle"
        '
        'ButtonSchoolSettings
        '
        Me.ButtonSchoolSettings.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSchoolSettings.Location = New System.Drawing.Point(64, 440)
        Me.ButtonSchoolSettings.Name = "ButtonSchoolSettings"
        Me.ButtonSchoolSettings.Size = New System.Drawing.Size(236, 119)
        Me.ButtonSchoolSettings.TabIndex = 109
        '
        'ButtonServerSettings
        '
        Me.ButtonServerSettings.BackColor = System.Drawing.Color.Transparent
        Me.ButtonServerSettings.Location = New System.Drawing.Point(64, 289)
        Me.ButtonServerSettings.Name = "ButtonServerSettings"
        Me.ButtonServerSettings.Size = New System.Drawing.Size(236, 119)
        Me.ButtonServerSettings.TabIndex = 108
        '
        'ButtonSystemSettings
        '
        Me.ButtonSystemSettings.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSystemSettings.Location = New System.Drawing.Point(64, 144)
        Me.ButtonSystemSettings.Name = "ButtonSystemSettings"
        Me.ButtonSystemSettings.Size = New System.Drawing.Size(236, 119)
        Me.ButtonSystemSettings.TabIndex = 107
        '
        'GroupSystemSettings
        '
        Me.GroupSystemSettings.BackColor = System.Drawing.Color.Transparent
        Me.GroupSystemSettings.Controls.Add(Me.ComboMode)
        Me.GroupSystemSettings.Controls.Add(Me.LabelMode)
        Me.GroupSystemSettings.Controls.Add(Me.LabelAdministratorPassword)
        Me.GroupSystemSettings.Controls.Add(Me.TextAdministratorUserName)
        Me.GroupSystemSettings.Controls.Add(Me.TextAdministratorPassword)
        Me.GroupSystemSettings.Controls.Add(Me.LabelAdministratorUserName)
        Me.GroupSystemSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupSystemSettings.Location = New System.Drawing.Point(436, 216)
        Me.GroupSystemSettings.Name = "GroupSystemSettings"
        Me.GroupSystemSettings.Size = New System.Drawing.Size(500, 250)
        Me.GroupSystemSettings.TabIndex = 104
        Me.GroupSystemSettings.TabStop = False
        Me.GroupSystemSettings.Visible = False
        '
        'ComboMode
        '
        Me.ComboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMode.FormattingEnabled = True
        Me.ComboMode.Items.AddRange(New Object() {"脱机报名模式", "联机报名模式"})
        Me.ComboMode.Location = New System.Drawing.Point(190, 65)
        Me.ComboMode.Name = "ComboMode"
        Me.ComboMode.Size = New System.Drawing.Size(228, 25)
        Me.ComboMode.TabIndex = 5
        '
        'LabelMode
        '
        Me.LabelMode.AutoSize = True
        Me.LabelMode.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelMode.ForeColor = System.Drawing.Color.Black
        Me.LabelMode.Location = New System.Drawing.Point(66, 65)
        Me.LabelMode.Name = "LabelMode"
        Me.LabelMode.Size = New System.Drawing.Size(78, 21)
        Me.LabelMode.TabIndex = 4
        Me.LabelMode.Text = "报名模式:"
        '
        'LabelAdministratorPassword
        '
        Me.LabelAdministratorPassword.AutoSize = True
        Me.LabelAdministratorPassword.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelAdministratorPassword.ForeColor = System.Drawing.Color.Black
        Me.LabelAdministratorPassword.Location = New System.Drawing.Point(66, 166)
        Me.LabelAdministratorPassword.Name = "LabelAdministratorPassword"
        Me.LabelAdministratorPassword.Size = New System.Drawing.Size(94, 21)
        Me.LabelAdministratorPassword.TabIndex = 3
        Me.LabelAdministratorPassword.Text = "管理员密码:"
        '
        'TextAdministratorUserName
        '
        Me.TextAdministratorUserName.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextAdministratorUserName.Location = New System.Drawing.Point(190, 112)
        Me.TextAdministratorUserName.Name = "TextAdministratorUserName"
        Me.TextAdministratorUserName.Size = New System.Drawing.Size(228, 26)
        Me.TextAdministratorUserName.TabIndex = 1
        Me.TextAdministratorUserName.Text = "谢浩哲"
        '
        'TextAdministratorPassword
        '
        Me.TextAdministratorPassword.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextAdministratorPassword.Location = New System.Drawing.Point(190, 164)
        Me.TextAdministratorPassword.Name = "TextAdministratorPassword"
        Me.TextAdministratorPassword.Size = New System.Drawing.Size(228, 26)
        Me.TextAdministratorPassword.TabIndex = 2
        Me.TextAdministratorPassword.Text = "(保存的密码)"
        '
        'LabelAdministratorUserName
        '
        Me.LabelAdministratorUserName.AutoSize = True
        Me.LabelAdministratorUserName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelAdministratorUserName.ForeColor = System.Drawing.Color.Black
        Me.LabelAdministratorUserName.Location = New System.Drawing.Point(66, 114)
        Me.LabelAdministratorUserName.Name = "LabelAdministratorUserName"
        Me.LabelAdministratorUserName.Size = New System.Drawing.Size(110, 21)
        Me.LabelAdministratorUserName.TabIndex = 0
        Me.LabelAdministratorUserName.Text = "管理员用户名:"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(756, 485)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 32)
        Me.ButtonSave.TabIndex = 110
        Me.ButtonSave.Text = "保存"
        Me.ButtonSave.UseVisualStyleBackColor = True
        Me.ButtonSave.Visible = False
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(861, 485)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(75, 32)
        Me.ButtonReset.TabIndex = 111
        Me.ButtonReset.Text = "重置"
        Me.ButtonReset.UseVisualStyleBackColor = True
        Me.ButtonReset.Visible = False
        '
        'GroupSchoolSettings
        '
        Me.GroupSchoolSettings.BackColor = System.Drawing.Color.Transparent
        Me.GroupSchoolSettings.Controls.Add(Me.ButtonDeleteNode)
        Me.GroupSchoolSettings.Controls.Add(Me.ButtonAddProfession)
        Me.GroupSchoolSettings.Controls.Add(Me.ButtonAddSchool)
        Me.GroupSchoolSettings.Controls.Add(Me.TreeViewSchool)
        Me.GroupSchoolSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupSchoolSettings.Location = New System.Drawing.Point(436, 216)
        Me.GroupSchoolSettings.Name = "GroupSchoolSettings"
        Me.GroupSchoolSettings.Size = New System.Drawing.Size(500, 250)
        Me.GroupSchoolSettings.TabIndex = 116
        Me.GroupSchoolSettings.TabStop = False
        Me.GroupSchoolSettings.Visible = False
        '
        'ButtonDeleteNode
        '
        Me.ButtonDeleteNode.Font = New System.Drawing.Font("Microsoft YaHei", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButtonDeleteNode.Location = New System.Drawing.Point(409, 196)
        Me.ButtonDeleteNode.Name = "ButtonDeleteNode"
        Me.ButtonDeleteNode.Size = New System.Drawing.Size(75, 33)
        Me.ButtonDeleteNode.TabIndex = 117
        Me.ButtonDeleteNode.Text = "删除学院/专业"
        Me.ButtonDeleteNode.UseVisualStyleBackColor = True
        '
        'ButtonAddProfession
        '
        Me.ButtonAddProfession.Location = New System.Drawing.Point(409, 125)
        Me.ButtonAddProfession.Name = "ButtonAddProfession"
        Me.ButtonAddProfession.Size = New System.Drawing.Size(75, 33)
        Me.ButtonAddProfession.TabIndex = 3
        Me.ButtonAddProfession.Text = "添加专业"
        Me.ButtonAddProfession.UseVisualStyleBackColor = True
        '
        'ButtonAddSchool
        '
        Me.ButtonAddSchool.Location = New System.Drawing.Point(409, 77)
        Me.ButtonAddSchool.Name = "ButtonAddSchool"
        Me.ButtonAddSchool.Size = New System.Drawing.Size(75, 33)
        Me.ButtonAddSchool.TabIndex = 1
        Me.ButtonAddSchool.Text = "添加学院"
        Me.ButtonAddSchool.UseVisualStyleBackColor = True
        '
        'TreeViewSchool
        '
        Me.TreeViewSchool.Location = New System.Drawing.Point(21, 29)
        Me.TreeViewSchool.Name = "TreeViewSchool"
        Me.TreeViewSchool.Size = New System.Drawing.Size(374, 203)
        Me.TreeViewSchool.TabIndex = 0
        '
        'Frm_ControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SoftwareEnrollmentSystem.My.Resources.Resources.Frm_ControlPanel
        Me.ClientSize = New System.Drawing.Size(1024, 637)
        Me.Controls.Add(Me.GroupSchoolSettings)
        Me.Controls.Add(Me.GroupServerSettings)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.ButtonSchoolSettings)
        Me.Controls.Add(Me.ButtonServerSettings)
        Me.Controls.Add(Me.ButtonSystemSettings)
        Me.Controls.Add(Me.GroupSystemSettings)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_ControlPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "软件基础知识报名系统 - Control Panel"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupServerSettings.ResumeLayout(False)
        Me.GroupServerSettings.PerformLayout()
        Me.GroupSystemSettings.ResumeLayout(False)
        Me.GroupSystemSettings.PerformLayout()
        Me.GroupSchoolSettings.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemManagementCenter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemMainForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSeperator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItemExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupServerSettings As System.Windows.Forms.GroupBox
    Friend WithEvents TextStandbyServerPort As System.Windows.Forms.TextBox
    Friend WithEvents TextMainServerPort As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxMainServer As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStandbyServer As System.Windows.Forms.CheckBox
    Friend WithEvents ComboStandbyServerIpAddress As System.Windows.Forms.ComboBox
    Friend WithEvents ComboMainServerIpAddress As System.Windows.Forms.ComboBox
    Friend WithEvents LabelStandbyServerPort As System.Windows.Forms.Label
    Friend WithEvents LabelStandbyServerIpAddress As System.Windows.Forms.Label
    Friend WithEvents LabelMainServerPort As System.Windows.Forms.Label
    Friend WithEvents LabelStandbyServer As System.Windows.Forms.Label
    Friend WithEvents LabelMainServerIpAddress As System.Windows.Forms.Label
    Friend WithEvents LabelMainServer As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents ButtonSchoolSettings As System.Windows.Forms.Label
    Friend WithEvents ButtonServerSettings As System.Windows.Forms.Label
    Friend WithEvents ButtonSystemSettings As System.Windows.Forms.Label
    Friend WithEvents GroupSystemSettings As System.Windows.Forms.GroupBox
    Friend WithEvents TextAdministratorUserName As System.Windows.Forms.TextBox
    Friend WithEvents TextAdministratorPassword As System.Windows.Forms.TextBox
    Friend WithEvents LabelAdministratorUserName As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents LabelMode As System.Windows.Forms.Label
    Friend WithEvents LabelAdministratorPassword As System.Windows.Forms.Label
    Friend WithEvents ComboMode As System.Windows.Forms.ComboBox
    Friend WithEvents MenuItemHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSeperator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItemAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupSchoolSettings As System.Windows.Forms.GroupBox
    Friend WithEvents TreeViewSchool As System.Windows.Forms.TreeView
    Friend WithEvents ButtonAddSchool As System.Windows.Forms.Button
    Friend WithEvents ButtonAddProfession As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteNode As System.Windows.Forms.Button
End Class
