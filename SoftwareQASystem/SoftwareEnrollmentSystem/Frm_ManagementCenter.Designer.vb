<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ManagementCenter
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemControlPanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemMainForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSeperator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSepetator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageRegister = New System.Windows.Forms.TabPage()
        Me.ListRegister = New System.Windows.Forms.ListView()
        Me.ColumnStudentID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnStudentName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnPassword = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnGroup = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnSchool = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnProfession = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnPhone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSystem, Me.MenuHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1024, 27)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MenuSystem
        '
        Me.MenuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemControlPanel, Me.MenuItemMainForm, Me.MenuItemSeperator1, Me.MenuItemLogout, Me.MenuItemExit})
        Me.MenuSystem.Name = "MenuSystem"
        Me.MenuSystem.Size = New System.Drawing.Size(59, 21)
        Me.MenuSystem.Text = "系统(&S)"
        '
        'MenuItemControlPanel
        '
        Me.MenuItemControlPanel.Name = "MenuItemControlPanel"
        Me.MenuItemControlPanel.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemControlPanel.Text = "控制面板(&C)"
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
        Me.MenuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemHelp, Me.MenuItemSepetator2, Me.MenuItemAbout})
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
        'MenuItemSepetator2
        '
        Me.MenuItemSepetator2.Name = "MenuItemSepetator2"
        Me.MenuItemSepetator2.Size = New System.Drawing.Size(154, 6)
        '
        'MenuItemAbout
        '
        Me.MenuItemAbout.Name = "MenuItemAbout"
        Me.MenuItemAbout.Size = New System.Drawing.Size(157, 22)
        Me.MenuItemAbout.Text = "关于(&A)"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageRegister)
        Me.TabControl.Location = New System.Drawing.Point(389, 182)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(546, 350)
        Me.TabControl.TabIndex = 8
        '
        'TabPageRegister
        '
        Me.TabPageRegister.Controls.Add(Me.ListRegister)
        Me.TabPageRegister.Location = New System.Drawing.Point(4, 26)
        Me.TabPageRegister.Name = "TabPageRegister"
        Me.TabPageRegister.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRegister.Size = New System.Drawing.Size(538, 320)
        Me.TabPageRegister.TabIndex = 0
        Me.TabPageRegister.Text = "已报名用户"
        Me.TabPageRegister.UseVisualStyleBackColor = True
        '
        'ListRegister
        '
        Me.ListRegister.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnStudentID, Me.ColumnStudentName, Me.ColumnPassword, Me.ColumnGroup, Me.ColumnSchool, Me.ColumnProfession, Me.ColumnPhone})
        Me.ListRegister.Location = New System.Drawing.Point(7, 7)
        Me.ListRegister.Name = "ListRegister"
        Me.ListRegister.Size = New System.Drawing.Size(525, 307)
        Me.ListRegister.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListRegister.TabIndex = 0
        Me.ListRegister.UseCompatibleStateImageBehavior = False
        Me.ListRegister.View = System.Windows.Forms.View.Details
        '
        'ColumnStudentID
        '
        Me.ColumnStudentID.Text = "学号"
        Me.ColumnStudentID.Width = 72
        '
        'ColumnStudentName
        '
        Me.ColumnStudentName.Text = "姓名"
        '
        'ColumnPassword
        '
        Me.ColumnPassword.Text = "用户密码"
        Me.ColumnPassword.Width = 84
        '
        'ColumnGroup
        '
        Me.ColumnGroup.Text = "组别"
        '
        'ColumnSchool
        '
        Me.ColumnSchool.Text = "学院"
        '
        'ColumnProfession
        '
        Me.ColumnProfession.Text = "专业"
        '
        'ColumnPhone
        '
        Me.ColumnPhone.Text = "联系方式"
        Me.ColumnPhone.Width = 108
        '
        'Timer
        '
        '
        'Frm_ManagementCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SoftwareEnrollmentSystem.My.Resources.Resources.Frm_ManagementCenter
        Me.ClientSize = New System.Drawing.Size(1024, 637)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1040, 675)
        Me.MinimumSize = New System.Drawing.Size(1040, 675)
        Me.Name = "Frm_ManagementCenter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "软件知识竞赛报名系统 - Management Center"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPageRegister.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSepetator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItemAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemControlPanel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemMainForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSeperator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItemLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPageRegister As System.Windows.Forms.TabPage
    Friend WithEvents ListRegister As System.Windows.Forms.ListView
    Friend WithEvents ColumnStudentID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnStudentName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnPassword As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnGroup As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnSchool As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnProfession As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnPhone As System.Windows.Forms.ColumnHeader
    Friend WithEvents Timer As System.Windows.Forms.Timer
End Class
