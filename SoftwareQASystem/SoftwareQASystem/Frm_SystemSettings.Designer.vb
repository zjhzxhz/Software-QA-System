<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SystemSettings
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
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.ButtonSystemSettings = New System.Windows.Forms.Label()
        Me.ButtonServerSettings = New System.Windows.Forms.Label()
        Me.ButtonQuestionLibrary = New System.Windows.Forms.Label()
        Me.GroupSystemSettings = New System.Windows.Forms.GroupBox()
        Me.ButtonPageUpDown = New System.Windows.Forms.Button()
        Me.TextFtpServerUserName = New System.Windows.Forms.TextBox()
        Me.LabelFtpServerUserName = New System.Windows.Forms.Label()
        Me.ComboFtpServerIpAddress = New System.Windows.Forms.ComboBox()
        Me.TextAdministratorUserName = New System.Windows.Forms.TextBox()
        Me.TextAdministratorPassword = New System.Windows.Forms.TextBox()
        Me.LabelFtpServerIpAddress = New System.Windows.Forms.Label()
        Me.LabelAdministratorPassword = New System.Windows.Forms.Label()
        Me.TextFtpServerPassword = New System.Windows.Forms.TextBox()
        Me.LabelAdministratorUserName = New System.Windows.Forms.Label()
        Me.TextDatabasePassword = New System.Windows.Forms.TextBox()
        Me.LabelFtpServerPassword = New System.Windows.Forms.Label()
        Me.LabelDatabasePassword = New System.Windows.Forms.Label()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemImportSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemImportDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemExportSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemExportDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSperate1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSperate2 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.GroupQuestionLibrary = New System.Windows.Forms.GroupBox()
        Me.TextTotalQuestion = New System.Windows.Forms.TextBox()
        Me.TextTotalTime = New System.Windows.Forms.TextBox()
        Me.LabelTotalTime = New System.Windows.Forms.Label()
        Me.LabelTotalQuestion = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.GroupSystemSettings.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.GroupServerSettings.SuspendLayout()
        Me.GroupQuestionLibrary.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextPassword
        '
        Me.TextPassword.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextPassword.Location = New System.Drawing.Point(494, 349)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TextPassword.Size = New System.Drawing.Size(270, 29)
        Me.TextPassword.TabIndex = 0
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.White
        Me.LabelTitle.Location = New System.Drawing.Point(380, 180)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(113, 28)
        Me.LabelTitle.TabIndex = 100
        Me.LabelTitle.Text = "LabelTitle"
        '
        'ButtonSystemSettings
        '
        Me.ButtonSystemSettings.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSystemSettings.Enabled = False
        Me.ButtonSystemSettings.Location = New System.Drawing.Point(60, 149)
        Me.ButtonSystemSettings.Name = "ButtonSystemSettings"
        Me.ButtonSystemSettings.Size = New System.Drawing.Size(236, 119)
        Me.ButtonSystemSettings.TabIndex = 2
        '
        'ButtonServerSettings
        '
        Me.ButtonServerSettings.BackColor = System.Drawing.Color.Transparent
        Me.ButtonServerSettings.Enabled = False
        Me.ButtonServerSettings.Location = New System.Drawing.Point(60, 294)
        Me.ButtonServerSettings.Name = "ButtonServerSettings"
        Me.ButtonServerSettings.Size = New System.Drawing.Size(236, 119)
        Me.ButtonServerSettings.TabIndex = 3
        '
        'ButtonQuestionLibrary
        '
        Me.ButtonQuestionLibrary.BackColor = System.Drawing.Color.Transparent
        Me.ButtonQuestionLibrary.Enabled = False
        Me.ButtonQuestionLibrary.Location = New System.Drawing.Point(60, 444)
        Me.ButtonQuestionLibrary.Name = "ButtonQuestionLibrary"
        Me.ButtonQuestionLibrary.Size = New System.Drawing.Size(236, 119)
        Me.ButtonQuestionLibrary.TabIndex = 4
        '
        'GroupSystemSettings
        '
        Me.GroupSystemSettings.BackColor = System.Drawing.Color.Transparent
        Me.GroupSystemSettings.Controls.Add(Me.ButtonPageUpDown)
        Me.GroupSystemSettings.Controls.Add(Me.TextFtpServerUserName)
        Me.GroupSystemSettings.Controls.Add(Me.LabelFtpServerUserName)
        Me.GroupSystemSettings.Controls.Add(Me.ComboFtpServerIpAddress)
        Me.GroupSystemSettings.Controls.Add(Me.TextAdministratorUserName)
        Me.GroupSystemSettings.Controls.Add(Me.TextAdministratorPassword)
        Me.GroupSystemSettings.Controls.Add(Me.LabelFtpServerIpAddress)
        Me.GroupSystemSettings.Controls.Add(Me.LabelAdministratorPassword)
        Me.GroupSystemSettings.Controls.Add(Me.TextFtpServerPassword)
        Me.GroupSystemSettings.Controls.Add(Me.LabelAdministratorUserName)
        Me.GroupSystemSettings.Controls.Add(Me.TextDatabasePassword)
        Me.GroupSystemSettings.Controls.Add(Me.LabelFtpServerPassword)
        Me.GroupSystemSettings.Controls.Add(Me.LabelDatabasePassword)
        Me.GroupSystemSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupSystemSettings.Location = New System.Drawing.Point(432, 220)
        Me.GroupSystemSettings.Name = "GroupSystemSettings"
        Me.GroupSystemSettings.Size = New System.Drawing.Size(500, 250)
        Me.GroupSystemSettings.TabIndex = 0
        Me.GroupSystemSettings.TabStop = False
        Me.GroupSystemSettings.Visible = False
        '
        'ButtonPageUpDown
        '
        Me.ButtonPageUpDown.Location = New System.Drawing.Point(414, 206)
        Me.ButtonPageUpDown.Name = "ButtonPageUpDown"
        Me.ButtonPageUpDown.Size = New System.Drawing.Size(68, 33)
        Me.ButtonPageUpDown.TabIndex = 13
        Me.ButtonPageUpDown.Text = "下一页"
        Me.ButtonPageUpDown.UseVisualStyleBackColor = True
        '
        'TextFtpServerUserName
        '
        Me.TextFtpServerUserName.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextFtpServerUserName.Location = New System.Drawing.Point(160, 110)
        Me.TextFtpServerUserName.Name = "TextFtpServerUserName"
        Me.TextFtpServerUserName.Size = New System.Drawing.Size(228, 26)
        Me.TextFtpServerUserName.TabIndex = 4
        Me.TextFtpServerUserName.Text = "SoftwareQA"
        Me.TextFtpServerUserName.Visible = False
        '
        'LabelFtpServerUserName
        '
        Me.LabelFtpServerUserName.AutoSize = True
        Me.LabelFtpServerUserName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelFtpServerUserName.ForeColor = System.Drawing.Color.White
        Me.LabelFtpServerUserName.Location = New System.Drawing.Point(44, 112)
        Me.LabelFtpServerUserName.Name = "LabelFtpServerUserName"
        Me.LabelFtpServerUserName.Size = New System.Drawing.Size(90, 21)
        Me.LabelFtpServerUserName.TabIndex = 4
        Me.LabelFtpServerUserName.Text = "FTP用户名:"
        Me.LabelFtpServerUserName.Visible = False
        '
        'ComboFtpServerIpAddress
        '
        Me.ComboFtpServerIpAddress.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboFtpServerIpAddress.FormattingEnabled = True
        Me.ComboFtpServerIpAddress.Location = New System.Drawing.Point(160, 59)
        Me.ComboFtpServerIpAddress.Name = "ComboFtpServerIpAddress"
        Me.ComboFtpServerIpAddress.Size = New System.Drawing.Size(228, 28)
        Me.ComboFtpServerIpAddress.TabIndex = 12
        Me.ComboFtpServerIpAddress.Visible = False
        '
        'TextAdministratorUserName
        '
        Me.TextAdministratorUserName.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextAdministratorUserName.Location = New System.Drawing.Point(160, 60)
        Me.TextAdministratorUserName.Name = "TextAdministratorUserName"
        Me.TextAdministratorUserName.Size = New System.Drawing.Size(228, 26)
        Me.TextAdministratorUserName.TabIndex = 1
        Me.TextAdministratorUserName.Text = "谢浩哲"
        '
        'TextAdministratorPassword
        '
        Me.TextAdministratorPassword.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextAdministratorPassword.Location = New System.Drawing.Point(160, 110)
        Me.TextAdministratorPassword.Name = "TextAdministratorPassword"
        Me.TextAdministratorPassword.Size = New System.Drawing.Size(228, 26)
        Me.TextAdministratorPassword.TabIndex = 2
        Me.TextAdministratorPassword.Text = "(保存的密码)"
        '
        'LabelFtpServerIpAddress
        '
        Me.LabelFtpServerIpAddress.AutoSize = True
        Me.LabelFtpServerIpAddress.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelFtpServerIpAddress.ForeColor = System.Drawing.Color.White
        Me.LabelFtpServerIpAddress.Location = New System.Drawing.Point(44, 61)
        Me.LabelFtpServerIpAddress.Name = "LabelFtpServerIpAddress"
        Me.LabelFtpServerIpAddress.Size = New System.Drawing.Size(74, 21)
        Me.LabelFtpServerIpAddress.TabIndex = 8
        Me.LabelFtpServerIpAddress.Text = "FTP地址:"
        Me.LabelFtpServerIpAddress.Visible = False
        '
        'LabelAdministratorPassword
        '
        Me.LabelAdministratorPassword.AutoSize = True
        Me.LabelAdministratorPassword.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelAdministratorPassword.ForeColor = System.Drawing.Color.White
        Me.LabelAdministratorPassword.Location = New System.Drawing.Point(41, 112)
        Me.LabelAdministratorPassword.Name = "LabelAdministratorPassword"
        Me.LabelAdministratorPassword.Size = New System.Drawing.Size(94, 21)
        Me.LabelAdministratorPassword.TabIndex = 1
        Me.LabelAdministratorPassword.Text = "管理员密码:"
        '
        'TextFtpServerPassword
        '
        Me.TextFtpServerPassword.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextFtpServerPassword.Location = New System.Drawing.Point(160, 162)
        Me.TextFtpServerPassword.Name = "TextFtpServerPassword"
        Me.TextFtpServerPassword.Size = New System.Drawing.Size(228, 26)
        Me.TextFtpServerPassword.TabIndex = 5
        Me.TextFtpServerPassword.Text = "(保存的密码)"
        Me.TextFtpServerPassword.Visible = False
        '
        'LabelAdministratorUserName
        '
        Me.LabelAdministratorUserName.AutoSize = True
        Me.LabelAdministratorUserName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelAdministratorUserName.ForeColor = System.Drawing.Color.White
        Me.LabelAdministratorUserName.Location = New System.Drawing.Point(41, 62)
        Me.LabelAdministratorUserName.Name = "LabelAdministratorUserName"
        Me.LabelAdministratorUserName.Size = New System.Drawing.Size(110, 21)
        Me.LabelAdministratorUserName.TabIndex = 0
        Me.LabelAdministratorUserName.Text = "管理员用户名:"
        '
        'TextDatabasePassword
        '
        Me.TextDatabasePassword.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextDatabasePassword.Location = New System.Drawing.Point(160, 162)
        Me.TextDatabasePassword.Name = "TextDatabasePassword"
        Me.TextDatabasePassword.Size = New System.Drawing.Size(228, 26)
        Me.TextDatabasePassword.TabIndex = 6
        Me.TextDatabasePassword.Text = "(保存的密码)"
        '
        'LabelFtpServerPassword
        '
        Me.LabelFtpServerPassword.AutoSize = True
        Me.LabelFtpServerPassword.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelFtpServerPassword.ForeColor = System.Drawing.Color.White
        Me.LabelFtpServerPassword.Location = New System.Drawing.Point(44, 164)
        Me.LabelFtpServerPassword.Name = "LabelFtpServerPassword"
        Me.LabelFtpServerPassword.Size = New System.Drawing.Size(74, 21)
        Me.LabelFtpServerPassword.TabIndex = 5
        Me.LabelFtpServerPassword.Text = "FTP密码:"
        Me.LabelFtpServerPassword.Visible = False
        '
        'LabelDatabasePassword
        '
        Me.LabelDatabasePassword.AutoSize = True
        Me.LabelDatabasePassword.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelDatabasePassword.ForeColor = System.Drawing.Color.White
        Me.LabelDatabasePassword.Location = New System.Drawing.Point(41, 164)
        Me.LabelDatabasePassword.Name = "LabelDatabasePassword"
        Me.LabelDatabasePassword.Size = New System.Drawing.Size(94, 21)
        Me.LabelDatabasePassword.TabIndex = 2
        Me.LabelDatabasePassword.Text = "数据库密码:"
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(857, 489)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(75, 32)
        Me.ButtonReset.TabIndex = 8
        Me.ButtonReset.Text = "重置"
        Me.ButtonReset.UseVisualStyleBackColor = True
        Me.ButtonReset.Visible = False
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(752, 489)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 32)
        Me.ButtonSave.TabIndex = 7
        Me.ButtonSave.Text = "保存"
        Me.ButtonSave.UseVisualStyleBackColor = True
        Me.ButtonSave.Visible = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSystem, Me.MenuHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1024, 25)
        Me.MenuStrip.TabIndex = 101
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MenuSystem
        '
        Me.MenuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemImport, Me.MenuItemExport, Me.MenuItemSperate1, Me.MenuItemLogout, Me.MenuItemExit})
        Me.MenuSystem.Name = "MenuSystem"
        Me.MenuSystem.Size = New System.Drawing.Size(59, 21)
        Me.MenuSystem.Text = "系统(&S)"
        '
        'MenuItemImport
        '
        Me.MenuItemImport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemImportSettings, Me.MenuItemImportDatabase})
        Me.MenuItemImport.Name = "MenuItemImport"
        Me.MenuItemImport.Size = New System.Drawing.Size(140, 22)
        Me.MenuItemImport.Text = "导入(&I)"
        '
        'MenuItemImportSettings
        '
        Me.MenuItemImportSettings.Name = "MenuItemImportSettings"
        Me.MenuItemImportSettings.Size = New System.Drawing.Size(153, 22)
        Me.MenuItemImportSettings.Text = "导入配置(&S)"
        '
        'MenuItemImportDatabase
        '
        Me.MenuItemImportDatabase.Name = "MenuItemImportDatabase"
        Me.MenuItemImportDatabase.Size = New System.Drawing.Size(153, 22)
        Me.MenuItemImportDatabase.Text = "导入数据库(&D)"
        '
        'MenuItemExport
        '
        Me.MenuItemExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemExportSettings, Me.MenuItemExportDatabase})
        Me.MenuItemExport.Name = "MenuItemExport"
        Me.MenuItemExport.Size = New System.Drawing.Size(140, 22)
        Me.MenuItemExport.Text = "导出(&E)"
        '
        'MenuItemExportSettings
        '
        Me.MenuItemExportSettings.Name = "MenuItemExportSettings"
        Me.MenuItemExportSettings.Size = New System.Drawing.Size(153, 22)
        Me.MenuItemExportSettings.Text = "导出配置(&S)"
        '
        'MenuItemExportDatabase
        '
        Me.MenuItemExportDatabase.Name = "MenuItemExportDatabase"
        Me.MenuItemExportDatabase.Size = New System.Drawing.Size(153, 22)
        Me.MenuItemExportDatabase.Text = "导出数据库(&D)"
        '
        'MenuItemSperate1
        '
        Me.MenuItemSperate1.Name = "MenuItemSperate1"
        Me.MenuItemSperate1.Size = New System.Drawing.Size(137, 6)
        '
        'MenuItemLogout
        '
        Me.MenuItemLogout.Name = "MenuItemLogout"
        Me.MenuItemLogout.Size = New System.Drawing.Size(140, 22)
        Me.MenuItemLogout.Text = "退出登录(&L)"
        '
        'MenuItemExit
        '
        Me.MenuItemExit.Name = "MenuItemExit"
        Me.MenuItemExit.Size = New System.Drawing.Size(140, 22)
        Me.MenuItemExit.Text = "退出系统(&X)"
        '
        'MenuHelp
        '
        Me.MenuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemHelp, Me.MenuItemSperate2, Me.MenuItemAbout})
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
        'MenuItemSperate2
        '
        Me.MenuItemSperate2.Name = "MenuItemSperate2"
        Me.MenuItemSperate2.Size = New System.Drawing.Size(154, 6)
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
        Me.GroupServerSettings.Location = New System.Drawing.Point(432, 220)
        Me.GroupServerSettings.Name = "GroupServerSettings"
        Me.GroupServerSettings.Size = New System.Drawing.Size(500, 250)
        Me.GroupServerSettings.TabIndex = 102
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
        Me.CheckBoxMainServer.Enabled = False
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
        Me.LabelStandbyServerPort.ForeColor = System.Drawing.Color.White
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
        Me.LabelStandbyServerIpAddress.ForeColor = System.Drawing.Color.White
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
        Me.LabelMainServerPort.ForeColor = System.Drawing.Color.White
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
        Me.LabelStandbyServer.ForeColor = System.Drawing.Color.White
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
        Me.LabelMainServerIpAddress.ForeColor = System.Drawing.Color.White
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
        Me.LabelMainServer.ForeColor = System.Drawing.Color.White
        Me.LabelMainServer.Location = New System.Drawing.Point(27, 29)
        Me.LabelMainServer.Name = "LabelMainServer"
        Me.LabelMainServer.Size = New System.Drawing.Size(79, 22)
        Me.LabelMainServer.TabIndex = 0
        Me.LabelMainServer.Text = "主服务器:"
        '
        'GroupQuestionLibrary
        '
        Me.GroupQuestionLibrary.BackColor = System.Drawing.Color.Transparent
        Me.GroupQuestionLibrary.Controls.Add(Me.TextTotalQuestion)
        Me.GroupQuestionLibrary.Controls.Add(Me.TextTotalTime)
        Me.GroupQuestionLibrary.Controls.Add(Me.LabelTotalTime)
        Me.GroupQuestionLibrary.Controls.Add(Me.LabelTotalQuestion)
        Me.GroupQuestionLibrary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupQuestionLibrary.Location = New System.Drawing.Point(432, 220)
        Me.GroupQuestionLibrary.Name = "GroupQuestionLibrary"
        Me.GroupQuestionLibrary.Size = New System.Drawing.Size(500, 250)
        Me.GroupQuestionLibrary.TabIndex = 103
        Me.GroupQuestionLibrary.TabStop = False
        Me.GroupQuestionLibrary.Visible = False
        '
        'TextTotalQuestion
        '
        Me.TextTotalQuestion.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextTotalQuestion.Location = New System.Drawing.Point(160, 58)
        Me.TextTotalQuestion.Name = "TextTotalQuestion"
        Me.TextTotalQuestion.Size = New System.Drawing.Size(172, 29)
        Me.TextTotalQuestion.TabIndex = 105
        Me.TextTotalQuestion.Text = "10"
        '
        'TextTotalTime
        '
        Me.TextTotalTime.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextTotalTime.Location = New System.Drawing.Point(160, 118)
        Me.TextTotalTime.Name = "TextTotalTime"
        Me.TextTotalTime.Size = New System.Drawing.Size(172, 29)
        Me.TextTotalTime.TabIndex = 106
        Me.TextTotalTime.Text = "90"
        '
        'LabelTotalTime
        '
        Me.LabelTotalTime.AutoSize = True
        Me.LabelTotalTime.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTotalTime.ForeColor = System.Drawing.Color.White
        Me.LabelTotalTime.Location = New System.Drawing.Point(72, 121)
        Me.LabelTotalTime.Name = "LabelTotalTime"
        Me.LabelTotalTime.Size = New System.Drawing.Size(310, 21)
        Me.LabelTotalTime.TabIndex = 104
        Me.LabelTotalTime.Text = "答题时间:                                        分钟"
        '
        'LabelTotalQuestion
        '
        Me.LabelTotalQuestion.AutoSize = True
        Me.LabelTotalQuestion.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTotalQuestion.ForeColor = System.Drawing.Color.White
        Me.LabelTotalQuestion.Location = New System.Drawing.Point(72, 61)
        Me.LabelTotalQuestion.Name = "LabelTotalQuestion"
        Me.LabelTotalQuestion.Size = New System.Drawing.Size(78, 21)
        Me.LabelTotalQuestion.TabIndex = 0
        Me.LabelTotalQuestion.Text = "试题总数:"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.BackgroundImage = Global.SoftwareQASystem.My.Resources.Resources.Button_Enter
        Me.ButtonEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonEnter.Location = New System.Drawing.Point(802, 332)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(64, 64)
        Me.ButtonEnter.TabIndex = 104
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Frm_SystemSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SoftwareQASystem.My.Resources.Resources.Frm_SystemSettings
        Me.ClientSize = New System.Drawing.Size(1024, 637)
        Me.Controls.Add(Me.GroupQuestionLibrary)
        Me.Controls.Add(Me.GroupServerSettings)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.ButtonQuestionLibrary)
        Me.Controls.Add(Me.ButtonServerSettings)
        Me.Controls.Add(Me.ButtonSystemSettings)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.GroupSystemSettings)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1040, 675)
        Me.MinimumSize = New System.Drawing.Size(1040, 675)
        Me.Name = "Frm_SystemSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "软件知识竞赛问答系统 - Control Panel"
        Me.GroupSystemSettings.ResumeLayout(False)
        Me.GroupSystemSettings.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupServerSettings.ResumeLayout(False)
        Me.GroupServerSettings.PerformLayout()
        Me.GroupQuestionLibrary.ResumeLayout(False)
        Me.GroupQuestionLibrary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextPassword As System.Windows.Forms.TextBox
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents ButtonSystemSettings As System.Windows.Forms.Label
    Friend WithEvents ButtonServerSettings As System.Windows.Forms.Label
    Friend WithEvents ButtonQuestionLibrary As System.Windows.Forms.Label
    Friend WithEvents GroupSystemSettings As System.Windows.Forms.GroupBox
    Friend WithEvents LabelAdministratorUserName As System.Windows.Forms.Label
    Friend WithEvents LabelAdministratorPassword As System.Windows.Forms.Label
    Friend WithEvents LabelDatabasePassword As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextAdministratorPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextDatabasePassword As System.Windows.Forms.TextBox
    Friend WithEvents TextAdministratorUserName As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents GroupServerSettings As System.Windows.Forms.GroupBox
    Friend WithEvents LabelStandbyServer As System.Windows.Forms.Label
    Friend WithEvents LabelMainServerIpAddress As System.Windows.Forms.Label
    Friend WithEvents LabelMainServer As System.Windows.Forms.Label
    Friend WithEvents LabelMainServerPort As System.Windows.Forms.Label
    Friend WithEvents LabelStandbyServerPort As System.Windows.Forms.Label
    Friend WithEvents LabelStandbyServerIpAddress As System.Windows.Forms.Label
    Friend WithEvents ComboMainServerIpAddress As System.Windows.Forms.ComboBox
    Friend WithEvents ComboStandbyServerIpAddress As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxStandbyServer As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMainServer As System.Windows.Forms.CheckBox
    Friend WithEvents TextMainServerPort As System.Windows.Forms.TextBox
    Friend WithEvents TextStandbyServerPort As System.Windows.Forms.TextBox
    Friend WithEvents LabelFtpServerUserName As System.Windows.Forms.Label
    Friend WithEvents LabelFtpServerPassword As System.Windows.Forms.Label
    Friend WithEvents TextFtpServerUserName As System.Windows.Forms.TextBox
    Friend WithEvents TextFtpServerPassword As System.Windows.Forms.TextBox
    Friend WithEvents LabelFtpServerIpAddress As System.Windows.Forms.Label
    Friend WithEvents ComboFtpServerIpAddress As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonPageUpDown As System.Windows.Forms.Button
    Friend WithEvents MenuItemHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSperate2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItemAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSperate1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItemImportSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemImportDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemExportSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemExportDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupQuestionLibrary As System.Windows.Forms.GroupBox
    Friend WithEvents TextTotalQuestion As System.Windows.Forms.TextBox
    Friend WithEvents TextTotalTime As System.Windows.Forms.TextBox
    Friend WithEvents LabelTotalTime As System.Windows.Forms.Label
    Friend WithEvents LabelTotalQuestion As System.Windows.Forms.Label
    Friend WithEvents MenuItemLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonEnter As System.Windows.Forms.Button
End Class
