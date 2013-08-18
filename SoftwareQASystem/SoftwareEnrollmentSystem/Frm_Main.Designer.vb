<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.TextStudentID = New System.Windows.Forms.TextBox()
        Me.TextStudentName = New System.Windows.Forms.TextBox()
        Me.LabelStudentIdTip = New System.Windows.Forms.Label()
        Me.LabelStudentNameTip = New System.Windows.Forms.Label()
        Me.ComboGroup = New System.Windows.Forms.ComboBox()
        Me.ComboProfession = New System.Windows.Forms.ComboBox()
        Me.ComboSchool = New System.Windows.Forms.ComboBox()
        Me.TextPhoneNumber = New System.Windows.Forms.TextBox()
        Me.LabelPhoneTip = New System.Windows.Forms.Label()
        Me.LabelGroupTip = New System.Windows.Forms.Label()
        Me.LabelSchoolTip = New System.Windows.Forms.Label()
        Me.LabelProfessionTip = New System.Windows.Forms.Label()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemManagementCenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemControlPanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelConnectCondition = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextStudentID
        '
        Me.TextStudentID.Location = New System.Drawing.Point(620, 241)
        Me.TextStudentID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextStudentID.MaxLength = 10
        Me.TextStudentID.Name = "TextStudentID"
        Me.TextStudentID.Size = New System.Drawing.Size(181, 26)
        Me.TextStudentID.TabIndex = 0
        '
        'TextStudentName
        '
        Me.TextStudentName.Location = New System.Drawing.Point(620, 291)
        Me.TextStudentName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextStudentName.MaxLength = 8
        Me.TextStudentName.Name = "TextStudentName"
        Me.TextStudentName.Size = New System.Drawing.Size(181, 26)
        Me.TextStudentName.TabIndex = 1
        '
        'LabelStudentIdTip
        '
        Me.LabelStudentIdTip.AutoSize = True
        Me.LabelStudentIdTip.BackColor = System.Drawing.Color.Transparent
        Me.LabelStudentIdTip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelStudentIdTip.Location = New System.Drawing.Point(818, 243)
        Me.LabelStudentIdTip.Name = "LabelStudentIdTip"
        Me.LabelStudentIdTip.Size = New System.Drawing.Size(0, 20)
        Me.LabelStudentIdTip.TabIndex = 10
        '
        'LabelStudentNameTip
        '
        Me.LabelStudentNameTip.AutoSize = True
        Me.LabelStudentNameTip.BackColor = System.Drawing.Color.Transparent
        Me.LabelStudentNameTip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelStudentNameTip.Location = New System.Drawing.Point(818, 294)
        Me.LabelStudentNameTip.Name = "LabelStudentNameTip"
        Me.LabelStudentNameTip.Size = New System.Drawing.Size(0, 20)
        Me.LabelStudentNameTip.TabIndex = 11
        '
        'ComboGroup
        '
        Me.ComboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboGroup.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboGroup.FormattingEnabled = True
        Me.ComboGroup.Items.AddRange(New Object() {"专业组", "非专业组"})
        Me.ComboGroup.Location = New System.Drawing.Point(620, 340)
        Me.ComboGroup.Name = "ComboGroup"
        Me.ComboGroup.Size = New System.Drawing.Size(181, 28)
        Me.ComboGroup.TabIndex = 2
        '
        'ComboProfession
        '
        Me.ComboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboProfession.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboProfession.FormattingEnabled = True
        Me.ComboProfession.Location = New System.Drawing.Point(620, 433)
        Me.ComboProfession.Name = "ComboProfession"
        Me.ComboProfession.Size = New System.Drawing.Size(181, 28)
        Me.ComboProfession.TabIndex = 4
        '
        'ComboSchool
        '
        Me.ComboSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSchool.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboSchool.FormattingEnabled = True
        Me.ComboSchool.Location = New System.Drawing.Point(620, 386)
        Me.ComboSchool.Name = "ComboSchool"
        Me.ComboSchool.Size = New System.Drawing.Size(181, 28)
        Me.ComboSchool.TabIndex = 3
        '
        'TextPhoneNumber
        '
        Me.TextPhoneNumber.Location = New System.Drawing.Point(620, 482)
        Me.TextPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextPhoneNumber.MaxLength = 11
        Me.TextPhoneNumber.Name = "TextPhoneNumber"
        Me.TextPhoneNumber.Size = New System.Drawing.Size(181, 26)
        Me.TextPhoneNumber.TabIndex = 5
        '
        'LabelPhoneTip
        '
        Me.LabelPhoneTip.AutoSize = True
        Me.LabelPhoneTip.BackColor = System.Drawing.Color.Transparent
        Me.LabelPhoneTip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelPhoneTip.Location = New System.Drawing.Point(818, 485)
        Me.LabelPhoneTip.Name = "LabelPhoneTip"
        Me.LabelPhoneTip.Size = New System.Drawing.Size(0, 20)
        Me.LabelPhoneTip.TabIndex = 15
        '
        'LabelGroupTip
        '
        Me.LabelGroupTip.AutoSize = True
        Me.LabelGroupTip.BackColor = System.Drawing.Color.Transparent
        Me.LabelGroupTip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelGroupTip.Location = New System.Drawing.Point(818, 344)
        Me.LabelGroupTip.Name = "LabelGroupTip"
        Me.LabelGroupTip.Size = New System.Drawing.Size(0, 20)
        Me.LabelGroupTip.TabIndex = 12
        '
        'LabelSchoolTip
        '
        Me.LabelSchoolTip.AutoSize = True
        Me.LabelSchoolTip.BackColor = System.Drawing.Color.Transparent
        Me.LabelSchoolTip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSchoolTip.Location = New System.Drawing.Point(818, 389)
        Me.LabelSchoolTip.Name = "LabelSchoolTip"
        Me.LabelSchoolTip.Size = New System.Drawing.Size(0, 20)
        Me.LabelSchoolTip.TabIndex = 13
        '
        'LabelProfessionTip
        '
        Me.LabelProfessionTip.AutoSize = True
        Me.LabelProfessionTip.BackColor = System.Drawing.Color.Transparent
        Me.LabelProfessionTip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelProfessionTip.Location = New System.Drawing.Point(818, 435)
        Me.LabelProfessionTip.Name = "LabelProfessionTip"
        Me.LabelProfessionTip.Size = New System.Drawing.Size(0, 20)
        Me.LabelProfessionTip.TabIndex = 14
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Location = New System.Drawing.Point(664, 533)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(85, 32)
        Me.ButtonSubmit.TabIndex = 16
        Me.ButtonSubmit.Text = "确认提交"
        Me.ButtonSubmit.UseVisualStyleBackColor = True
        '
        'BackgroundWorker
        '
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSystem, Me.MenuHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1024, 25)
        Me.MenuStrip.TabIndex = 17
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MenuSystem
        '
        Me.MenuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemManagementCenter, Me.MenuItemControlPanel, Me.ToolStripMenuItem2, Me.MenuItemExit})
        Me.MenuSystem.Name = "MenuSystem"
        Me.MenuSystem.Size = New System.Drawing.Size(59, 21)
        Me.MenuSystem.Text = "系统(&S)"
        '
        'MenuItemManagementCenter
        '
        Me.MenuItemManagementCenter.Name = "MenuItemManagementCenter"
        Me.MenuItemManagementCenter.Size = New System.Drawing.Size(144, 22)
        Me.MenuItemManagementCenter.Text = "管理中心(&M)"
        '
        'MenuItemControlPanel
        '
        Me.MenuItemControlPanel.Name = "MenuItemControlPanel"
        Me.MenuItemControlPanel.Size = New System.Drawing.Size(144, 22)
        Me.MenuItemControlPanel.Text = "控制面板(&C)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(141, 6)
        '
        'MenuItemExit
        '
        Me.MenuItemExit.Name = "MenuItemExit"
        Me.MenuItemExit.Size = New System.Drawing.Size(144, 22)
        Me.MenuItemExit.Text = "退出系统(&X)"
        '
        'MenuHelp
        '
        Me.MenuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemHelp, Me.ToolStripMenuItem1, Me.MenuItemAbout})
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
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(154, 6)
        '
        'MenuItemAbout
        '
        Me.MenuItemAbout.Name = "MenuItemAbout"
        Me.MenuItemAbout.Size = New System.Drawing.Size(157, 22)
        Me.MenuItemAbout.Text = "关于(&A)"
        '
        'LabelConnectCondition
        '
        Me.LabelConnectCondition.AutoSize = True
        Me.LabelConnectCondition.BackColor = System.Drawing.Color.Transparent
        Me.LabelConnectCondition.ForeColor = System.Drawing.Color.Green
        Me.LabelConnectCondition.Location = New System.Drawing.Point(899, 31)
        Me.LabelConnectCondition.Name = "LabelConnectCondition"
        Me.LabelConnectCondition.Size = New System.Drawing.Size(65, 20)
        Me.LabelConnectCondition.TabIndex = 18
        Me.LabelConnectCondition.Text = "联机模式"
        '
        'Timer
        '
        Me.Timer.Interval = 2500
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SoftwareEnrollmentSystem.My.Resources.Resources.Frm_Main
        Me.ClientSize = New System.Drawing.Size(1024, 637)
        Me.Controls.Add(Me.LabelConnectCondition)
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.LabelProfessionTip)
        Me.Controls.Add(Me.LabelSchoolTip)
        Me.Controls.Add(Me.LabelGroupTip)
        Me.Controls.Add(Me.LabelPhoneTip)
        Me.Controls.Add(Me.TextPhoneNumber)
        Me.Controls.Add(Me.ComboGroup)
        Me.Controls.Add(Me.ComboProfession)
        Me.Controls.Add(Me.ComboSchool)
        Me.Controls.Add(Me.LabelStudentNameTip)
        Me.Controls.Add(Me.LabelStudentIdTip)
        Me.Controls.Add(Me.TextStudentName)
        Me.Controls.Add(Me.TextStudentID)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1040, 675)
        Me.MinimumSize = New System.Drawing.Size(1040, 675)
        Me.Name = "Frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "软件基础知识报名系统"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextStudentID As System.Windows.Forms.TextBox
    Friend WithEvents TextStudentName As System.Windows.Forms.TextBox
    Friend WithEvents LabelStudentIdTip As System.Windows.Forms.Label
    Friend WithEvents LabelStudentNameTip As System.Windows.Forms.Label
    Friend WithEvents ComboGroup As System.Windows.Forms.ComboBox
    Friend WithEvents ComboProfession As System.Windows.Forms.ComboBox
    Friend WithEvents ComboSchool As System.Windows.Forms.ComboBox
    Friend WithEvents TextPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents LabelPhoneTip As System.Windows.Forms.Label
    Friend WithEvents LabelGroupTip As System.Windows.Forms.Label
    Friend WithEvents LabelSchoolTip As System.Windows.Forms.Label
    Friend WithEvents LabelProfessionTip As System.Windows.Forms.Label
    Friend WithEvents ButtonSubmit As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemManagementCenter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemControlPanel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItemExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItemAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelConnectCondition As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
End Class
