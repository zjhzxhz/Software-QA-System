<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_StandbyServer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_StandbyServer))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSystemSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSystemSperator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSystemSperator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemHelpSperator = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemImportSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemImportDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemImportResult = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelServerStatus = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageLogin = New System.Windows.Forms.TabPage()
        Me.ListLogin = New System.Windows.Forms.ListView()
        Me.LoginColumnStudentID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LoginColumnStudentName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LoginColumnGroup = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LoginColumnIpAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LoginColumnTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPageSubmit = New System.Windows.Forms.TabPage()
        Me.ListSubmit = New System.Windows.Forms.ListView()
        Me.SubmitColumnStudentID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubmitColumnStudentName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubmitColumnGroup = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubmitColumnScore = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubmitColumnTimeUsed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubmitColumnIpAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubmitColumnTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPageLog = New System.Windows.Forms.TabPage()
        Me.ListLog = New System.Windows.Forms.ListBox()
        Me.LabelLogin = New System.Windows.Forms.Label()
        Me.ButtonSwitch = New System.Windows.Forms.LinkLabel()
        Me.LabelSubmit = New System.Windows.Forms.Label()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.GroupControlUser = New System.Windows.Forms.GroupBox()
        Me.ButtonForceLogoutUser = New System.Windows.Forms.Button()
        Me.ButtonDeleteLoginedUser = New System.Windows.Forms.Button()
        Me.GroupControl = New System.Windows.Forms.GroupBox()
        Me.ButtonImportResult = New System.Windows.Forms.Button()
        Me.ButtonExportResult = New System.Windows.Forms.Button()
        Me.ButtonSynchronize = New System.Windows.Forms.Button()
        Me.LabelTimeRemaining = New System.Windows.Forms.Label()
        Me.LabelTimeUsed = New System.Windows.Forms.Label()
        Me.MenuItemExportSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemExportResult = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerUp = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDown = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageLogin.SuspendLayout()
        Me.TabPageSubmit.SuspendLayout()
        Me.TabPageLog.SuspendLayout()
        Me.GroupControlUser.SuspendLayout()
        Me.GroupControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSystem, Me.MenuHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1014, 27)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MenuSystem
        '
        Me.MenuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemSystemSettings, Me.MenuItemSystemSperator1, Me.MenuItemImport, Me.MenuItemExport, Me.MenuItemSystemSperator2, Me.MenuItemLogout, Me.MenuItemExit})
        Me.MenuSystem.Name = "MenuSystem"
        Me.MenuSystem.Size = New System.Drawing.Size(59, 21)
        Me.MenuSystem.Text = "系统(&S)"
        '
        'MenuItemSystemSettings
        '
        Me.MenuItemSystemSettings.Name = "MenuItemSystemSettings"
        Me.MenuItemSystemSettings.Size = New System.Drawing.Size(163, 22)
        Me.MenuItemSystemSettings.Text = "系统设置(&S)"
        '
        'MenuItemSystemSperator1
        '
        Me.MenuItemSystemSperator1.Name = "MenuItemSystemSperator1"
        Me.MenuItemSystemSperator1.Size = New System.Drawing.Size(160, 6)
        '
        'MenuItemImport
        '
        Me.MenuItemImport.Name = "MenuItemImport"
        Me.MenuItemImport.Size = New System.Drawing.Size(163, 22)
        Me.MenuItemImport.Text = "导入竞赛结果(&I)"
        '
        'MenuItemExport
        '
        Me.MenuItemExport.Name = "MenuItemExport"
        Me.MenuItemExport.Size = New System.Drawing.Size(163, 22)
        Me.MenuItemExport.Text = "导出竞赛结果(&E)"
        '
        'MenuItemSystemSperator2
        '
        Me.MenuItemSystemSperator2.Name = "MenuItemSystemSperator2"
        Me.MenuItemSystemSperator2.Size = New System.Drawing.Size(160, 6)
        '
        'MenuItemLogout
        '
        Me.MenuItemLogout.Name = "MenuItemLogout"
        Me.MenuItemLogout.Size = New System.Drawing.Size(163, 22)
        Me.MenuItemLogout.Text = "退出登录(&L)"
        '
        'MenuItemExit
        '
        Me.MenuItemExit.Name = "MenuItemExit"
        Me.MenuItemExit.Size = New System.Drawing.Size(163, 22)
        Me.MenuItemExit.Text = "退出系统(&X)"
        '
        'MenuHelp
        '
        Me.MenuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemHelp, Me.MenuItemHelpSperator, Me.MenuItemAbout})
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
        'MenuItemHelpSperator
        '
        Me.MenuItemHelpSperator.Name = "MenuItemHelpSperator"
        Me.MenuItemHelpSperator.Size = New System.Drawing.Size(154, 6)
        '
        'MenuItemAbout
        '
        Me.MenuItemAbout.Name = "MenuItemAbout"
        Me.MenuItemAbout.Size = New System.Drawing.Size(157, 22)
        Me.MenuItemAbout.Text = "关于(&A)"
        '
        'MenuItemImportSettings
        '
        Me.MenuItemImportSettings.Name = "MenuItemImportSettings"
        Me.MenuItemImportSettings.Size = New System.Drawing.Size(164, 22)
        Me.MenuItemImportSettings.Text = "导入配置(&S)"
        '
        'MenuItemImportDatabase
        '
        Me.MenuItemImportDatabase.Name = "MenuItemImportDatabase"
        Me.MenuItemImportDatabase.Size = New System.Drawing.Size(164, 22)
        Me.MenuItemImportDatabase.Text = "导入数据库(&D)"
        '
        'MenuItemImportResult
        '
        Me.MenuItemImportResult.Name = "MenuItemImportResult"
        Me.MenuItemImportResult.Size = New System.Drawing.Size(164, 22)
        Me.MenuItemImportResult.Text = "导入竞赛结果(&R)"
        '
        'LabelServerStatus
        '
        Me.LabelServerStatus.AutoSize = True
        Me.LabelServerStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelServerStatus.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelServerStatus.ForeColor = System.Drawing.Color.Red
        Me.LabelServerStatus.Location = New System.Drawing.Point(819, 97)
        Me.LabelServerStatus.Name = "LabelServerStatus"
        Me.LabelServerStatus.Size = New System.Drawing.Size(67, 19)
        Me.LabelServerStatus.TabIndex = 1
        Me.LabelServerStatus.Text = "Stopped"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageLogin)
        Me.TabControl.Controls.Add(Me.TabPageSubmit)
        Me.TabControl.Controls.Add(Me.TabPageLog)
        Me.TabControl.Location = New System.Drawing.Point(174, 217)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(476, 322)
        Me.TabControl.TabIndex = 7
        '
        'TabPageLogin
        '
        Me.TabPageLogin.Controls.Add(Me.ListLogin)
        Me.TabPageLogin.Location = New System.Drawing.Point(4, 26)
        Me.TabPageLogin.Name = "TabPageLogin"
        Me.TabPageLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageLogin.Size = New System.Drawing.Size(468, 292)
        Me.TabPageLogin.TabIndex = 0
        Me.TabPageLogin.Text = "已登录用户"
        Me.TabPageLogin.UseVisualStyleBackColor = True
        '
        'ListLogin
        '
        Me.ListLogin.AllowColumnReorder = True
        Me.ListLogin.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LoginColumnStudentID, Me.LoginColumnStudentName, Me.LoginColumnGroup, Me.LoginColumnIpAddress, Me.LoginColumnTime})
        Me.ListLogin.Location = New System.Drawing.Point(8, 6)
        Me.ListLogin.Name = "ListLogin"
        Me.ListLogin.Size = New System.Drawing.Size(453, 280)
        Me.ListLogin.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListLogin.TabIndex = 0
        Me.ListLogin.UseCompatibleStateImageBehavior = False
        Me.ListLogin.View = System.Windows.Forms.View.Details
        '
        'LoginColumnStudentID
        '
        Me.LoginColumnStudentID.Text = "学号"
        Me.LoginColumnStudentID.Width = 78
        '
        'LoginColumnStudentName
        '
        Me.LoginColumnStudentName.Text = "姓名"
        '
        'LoginColumnGroup
        '
        Me.LoginColumnGroup.Text = "组别"
        '
        'LoginColumnIpAddress
        '
        Me.LoginColumnIpAddress.Text = "登录IP"
        Me.LoginColumnIpAddress.Width = 120
        '
        'LoginColumnTime
        '
        Me.LoginColumnTime.Text = "登录时间"
        Me.LoginColumnTime.Width = 130
        '
        'TabPageSubmit
        '
        Me.TabPageSubmit.Controls.Add(Me.ListSubmit)
        Me.TabPageSubmit.Location = New System.Drawing.Point(4, 26)
        Me.TabPageSubmit.Name = "TabPageSubmit"
        Me.TabPageSubmit.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSubmit.Size = New System.Drawing.Size(468, 292)
        Me.TabPageSubmit.TabIndex = 1
        Me.TabPageSubmit.Text = "已提交用户"
        Me.TabPageSubmit.UseVisualStyleBackColor = True
        '
        'ListSubmit
        '
        Me.ListSubmit.AllowColumnReorder = True
        Me.ListSubmit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SubmitColumnStudentID, Me.SubmitColumnStudentName, Me.SubmitColumnGroup, Me.SubmitColumnScore, Me.SubmitColumnTimeUsed, Me.SubmitColumnIpAddress, Me.SubmitColumnTime})
        Me.ListSubmit.Location = New System.Drawing.Point(8, 6)
        Me.ListSubmit.Name = "ListSubmit"
        Me.ListSubmit.Size = New System.Drawing.Size(453, 280)
        Me.ListSubmit.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListSubmit.TabIndex = 0
        Me.ListSubmit.UseCompatibleStateImageBehavior = False
        Me.ListSubmit.View = System.Windows.Forms.View.Details
        '
        'SubmitColumnStudentID
        '
        Me.SubmitColumnStudentID.Text = "学号"
        Me.SubmitColumnStudentID.Width = 67
        '
        'SubmitColumnStudentName
        '
        Me.SubmitColumnStudentName.Text = "姓名"
        '
        'SubmitColumnGroup
        '
        Me.SubmitColumnGroup.Text = "组别"
        '
        'SubmitColumnScore
        '
        Me.SubmitColumnScore.Text = "得分"
        '
        'SubmitColumnTimeUsed
        '
        Me.SubmitColumnTimeUsed.Text = "所用时间"
        Me.SubmitColumnTimeUsed.Width = 80
        '
        'SubmitColumnIpAddress
        '
        Me.SubmitColumnIpAddress.Text = "提交IP"
        Me.SubmitColumnIpAddress.Width = 120
        '
        'SubmitColumnTime
        '
        Me.SubmitColumnTime.Text = "提交时间"
        Me.SubmitColumnTime.Width = 120
        '
        'TabPageLog
        '
        Me.TabPageLog.Controls.Add(Me.ListLog)
        Me.TabPageLog.Location = New System.Drawing.Point(4, 26)
        Me.TabPageLog.Name = "TabPageLog"
        Me.TabPageLog.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageLog.Size = New System.Drawing.Size(468, 292)
        Me.TabPageLog.TabIndex = 2
        Me.TabPageLog.Text = "系统日志"
        Me.TabPageLog.UseVisualStyleBackColor = True
        '
        'ListLog
        '
        Me.ListLog.FormattingEnabled = True
        Me.ListLog.ItemHeight = 17
        Me.ListLog.Location = New System.Drawing.Point(8, 7)
        Me.ListLog.Name = "ListLog"
        Me.ListLog.Size = New System.Drawing.Size(453, 276)
        Me.ListLog.TabIndex = 0
        '
        'LabelLogin
        '
        Me.LabelLogin.AutoSize = True
        Me.LabelLogin.BackColor = System.Drawing.Color.Transparent
        Me.LabelLogin.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelLogin.Location = New System.Drawing.Point(541, 161)
        Me.LabelLogin.Name = "LabelLogin"
        Me.LabelLogin.Size = New System.Drawing.Size(34, 25)
        Me.LabelLogin.TabIndex = 8
        Me.LabelLogin.Text = "00"
        '
        'ButtonSwitch
        '
        Me.ButtonSwitch.AutoSize = True
        Me.ButtonSwitch.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSwitch.Location = New System.Drawing.Point(893, 97)
        Me.ButtonSwitch.Name = "ButtonSwitch"
        Me.ButtonSwitch.Size = New System.Drawing.Size(32, 17)
        Me.ButtonSwitch.TabIndex = 0
        Me.ButtonSwitch.TabStop = True
        Me.ButtonSwitch.Text = "切换"
        '
        'LabelSubmit
        '
        Me.LabelSubmit.AutoSize = True
        Me.LabelSubmit.BackColor = System.Drawing.Color.Transparent
        Me.LabelSubmit.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelSubmit.Location = New System.Drawing.Point(541, 188)
        Me.LabelSubmit.Name = "LabelSubmit"
        Me.LabelSubmit.Size = New System.Drawing.Size(34, 25)
        Me.LabelSubmit.TabIndex = 10
        Me.LabelSubmit.Text = "00"
        '
        'BackgroundWorker
        '
        '
        'GroupControlUser
        '
        Me.GroupControlUser.BackColor = System.Drawing.Color.Transparent
        Me.GroupControlUser.Controls.Add(Me.ButtonForceLogoutUser)
        Me.GroupControlUser.Controls.Add(Me.ButtonDeleteLoginedUser)
        Me.GroupControlUser.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupControlUser.Location = New System.Drawing.Point(759, 220)
        Me.GroupControlUser.Name = "GroupControlUser"
        Me.GroupControlUser.Size = New System.Drawing.Size(200, 121)
        Me.GroupControlUser.TabIndex = 11
        Me.GroupControlUser.TabStop = False
        Me.GroupControlUser.Text = "用户管理"
        '
        'ButtonForceLogoutUser
        '
        Me.ButtonForceLogoutUser.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButtonForceLogoutUser.Location = New System.Drawing.Point(46, 79)
        Me.ButtonForceLogoutUser.Name = "ButtonForceLogoutUser"
        Me.ButtonForceLogoutUser.Size = New System.Drawing.Size(104, 31)
        Me.ButtonForceLogoutUser.TabIndex = 13
        Me.ButtonForceLogoutUser.Text = "强制登出用户"
        Me.ButtonForceLogoutUser.UseVisualStyleBackColor = True
        '
        'ButtonDeleteLoginedUser
        '
        Me.ButtonDeleteLoginedUser.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButtonDeleteLoginedUser.Location = New System.Drawing.Point(46, 32)
        Me.ButtonDeleteLoginedUser.Name = "ButtonDeleteLoginedUser"
        Me.ButtonDeleteLoginedUser.Size = New System.Drawing.Size(104, 31)
        Me.ButtonDeleteLoginedUser.TabIndex = 5
        Me.ButtonDeleteLoginedUser.Text = "删除已登录用户"
        Me.ButtonDeleteLoginedUser.UseVisualStyleBackColor = True
        '
        'GroupControl
        '
        Me.GroupControl.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl.Controls.Add(Me.ButtonImportResult)
        Me.GroupControl.Controls.Add(Me.ButtonExportResult)
        Me.GroupControl.Controls.Add(Me.ButtonSynchronize)
        Me.GroupControl.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupControl.Location = New System.Drawing.Point(759, 370)
        Me.GroupControl.Name = "GroupControl"
        Me.GroupControl.Size = New System.Drawing.Size(200, 169)
        Me.GroupControl.TabIndex = 12
        Me.GroupControl.TabStop = False
        Me.GroupControl.Text = "服务器工具"
        '
        'ButtonImportResult
        '
        Me.ButtonImportResult.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButtonImportResult.Location = New System.Drawing.Point(46, 78)
        Me.ButtonImportResult.Name = "ButtonImportResult"
        Me.ButtonImportResult.Size = New System.Drawing.Size(104, 32)
        Me.ButtonImportResult.TabIndex = 15
        Me.ButtonImportResult.Text = "导入竞赛结果"
        Me.ButtonImportResult.UseVisualStyleBackColor = True
        '
        'ButtonExportResult
        '
        Me.ButtonExportResult.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButtonExportResult.Location = New System.Drawing.Point(46, 122)
        Me.ButtonExportResult.Name = "ButtonExportResult"
        Me.ButtonExportResult.Size = New System.Drawing.Size(104, 32)
        Me.ButtonExportResult.TabIndex = 1
        Me.ButtonExportResult.Text = "导出竞赛结果"
        Me.ButtonExportResult.UseVisualStyleBackColor = True
        '
        'ButtonSynchronize
        '
        Me.ButtonSynchronize.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButtonSynchronize.Location = New System.Drawing.Point(46, 34)
        Me.ButtonSynchronize.Name = "ButtonSynchronize"
        Me.ButtonSynchronize.Size = New System.Drawing.Size(104, 32)
        Me.ButtonSynchronize.TabIndex = 0
        Me.ButtonSynchronize.Text = "同步服务器状态"
        Me.ButtonSynchronize.UseVisualStyleBackColor = True
        '
        'LabelTimeRemaining
        '
        Me.LabelTimeRemaining.AutoSize = True
        Me.LabelTimeRemaining.BackColor = System.Drawing.Color.Transparent
        Me.LabelTimeRemaining.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTimeRemaining.ForeColor = System.Drawing.Color.White
        Me.LabelTimeRemaining.Location = New System.Drawing.Point(162, 629)
        Me.LabelTimeRemaining.Name = "LabelTimeRemaining"
        Me.LabelTimeRemaining.Size = New System.Drawing.Size(80, 22)
        Me.LabelTimeRemaining.TabIndex = 14
        Me.LabelTimeRemaining.Text = "00:00:00"
        '
        'LabelTimeUsed
        '
        Me.LabelTimeUsed.AutoSize = True
        Me.LabelTimeUsed.BackColor = System.Drawing.Color.Transparent
        Me.LabelTimeUsed.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTimeUsed.ForeColor = System.Drawing.Color.White
        Me.LabelTimeUsed.Location = New System.Drawing.Point(162, 604)
        Me.LabelTimeUsed.Name = "LabelTimeUsed"
        Me.LabelTimeUsed.Size = New System.Drawing.Size(80, 22)
        Me.LabelTimeUsed.TabIndex = 13
        Me.LabelTimeUsed.Text = "00:00:00"
        '
        'MenuItemExportSettings
        '
        Me.MenuItemExportSettings.Name = "MenuItemExportSettings"
        Me.MenuItemExportSettings.Size = New System.Drawing.Size(164, 22)
        Me.MenuItemExportSettings.Text = "导出配置(&S)"
        '
        'MenuItemExportResult
        '
        Me.MenuItemExportResult.Name = "MenuItemExportResult"
        Me.MenuItemExportResult.Size = New System.Drawing.Size(164, 22)
        Me.MenuItemExportResult.Text = "导出竞赛结果(&R)"
        '
        'TimerUp
        '
        Me.TimerUp.Interval = 1000
        '
        'TimerDown
        '
        Me.TimerDown.Interval = 1000
        '
        'Frm_StandbyServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SoftwareManagementSystem.My.Resources.Resources.Frm_StandbyServer
        Me.ClientSize = New System.Drawing.Size(1014, 662)
        Me.Controls.Add(Me.LabelTimeRemaining)
        Me.Controls.Add(Me.LabelTimeUsed)
        Me.Controls.Add(Me.GroupControl)
        Me.Controls.Add(Me.GroupControlUser)
        Me.Controls.Add(Me.LabelSubmit)
        Me.Controls.Add(Me.ButtonSwitch)
        Me.Controls.Add(Me.LabelLogin)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.LabelServerStatus)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1030, 700)
        Me.MinimumSize = New System.Drawing.Size(1030, 700)
        Me.Name = "Frm_StandbyServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "软件基础知识问答管理系统"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPageLogin.ResumeLayout(False)
        Me.TabPageSubmit.ResumeLayout(False)
        Me.TabPageLog.ResumeLayout(False)
        Me.GroupControlUser.ResumeLayout(False)
        Me.GroupControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemHelpSperator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItemAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelServerStatus As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPageLogin As System.Windows.Forms.TabPage
    Friend WithEvents ListLogin As System.Windows.Forms.ListView
    Friend WithEvents LoginColumnStudentID As System.Windows.Forms.ColumnHeader
    Friend WithEvents LoginColumnStudentName As System.Windows.Forms.ColumnHeader
    Friend WithEvents LoginColumnGroup As System.Windows.Forms.ColumnHeader
    Friend WithEvents LoginColumnIpAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents LoginColumnTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPageSubmit As System.Windows.Forms.TabPage
    Friend WithEvents ListSubmit As System.Windows.Forms.ListView
    Friend WithEvents SubmitColumnStudentID As System.Windows.Forms.ColumnHeader
    Friend WithEvents SubmitColumnStudentName As System.Windows.Forms.ColumnHeader
    Friend WithEvents SubmitColumnGroup As System.Windows.Forms.ColumnHeader
    Friend WithEvents SubmitColumnScore As System.Windows.Forms.ColumnHeader
    Friend WithEvents SubmitColumnTimeUsed As System.Windows.Forms.ColumnHeader
    Friend WithEvents SubmitColumnIpAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents SubmitColumnTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPageLog As System.Windows.Forms.TabPage
    Friend WithEvents ListLog As System.Windows.Forms.ListBox
    Friend WithEvents LabelLogin As System.Windows.Forms.Label
    Friend WithEvents ButtonSwitch As System.Windows.Forms.LinkLabel
    Friend WithEvents MenuItemSystemSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSystemSperator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItemExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelSubmit As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuItemLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSystemSperator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItemImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupControlUser As System.Windows.Forms.GroupBox
    Friend WithEvents GroupControl As System.Windows.Forms.GroupBox
    Friend WithEvents MenuItemImportSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemImportDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemImportResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonDeleteLoginedUser As System.Windows.Forms.Button
    Friend WithEvents ButtonForceLogoutUser As System.Windows.Forms.Button
    Friend WithEvents LabelTimeUsed As System.Windows.Forms.Label
    Friend WithEvents MenuItemExportSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemExportResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelTimeRemaining As System.Windows.Forms.Label
    Friend WithEvents TimerUp As System.Windows.Forms.Timer
    Friend WithEvents TimerDown As System.Windows.Forms.Timer
    Friend WithEvents ButtonSynchronize As System.Windows.Forms.Button
    Friend WithEvents ButtonExportResult As System.Windows.Forms.Button
    Friend WithEvents ButtonImportResult As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
End Class
