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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSystemSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemExitSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelStudentID = New System.Windows.Forms.Label()
        Me.LabelStudentName = New System.Windows.Forms.Label()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ButtonInformation = New System.Windows.Forms.Label()
        Me.ButtonHelp = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Label()
        Me.LabelInformation = New System.Windows.Forms.Label()
        Me.LabelTitleQuestion = New System.Windows.Forms.Label()
        Me.LabelTitleAnswer = New System.Windows.Forms.Label()
        Me.LabelQuestionID = New System.Windows.Forms.Label()
        Me.LabelTitleTimeUsed = New System.Windows.Forms.Label()
        Me.LabelTitleTimeRemaining = New System.Windows.Forms.Label()
        Me.TimerUp = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDown = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTimeRemaining = New System.Windows.Forms.Label()
        Me.LabelTimeUsed = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.LabelQuestion = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.TextJumpTo = New System.Windows.Forms.TextBox()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.CheckBoxD = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxB = New System.Windows.Forms.CheckBox()
        Me.CheckBoxA = New System.Windows.Forms.CheckBox()
        Me.RadioButtonD = New System.Windows.Forms.RadioButton()
        Me.RadioButtonC = New System.Windows.Forms.RadioButton()
        Me.RadioButtonB = New System.Windows.Forms.RadioButton()
        Me.RadioButtonA = New System.Windows.Forms.RadioButton()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSystem, Me.MenuHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1152, 25)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MenuSystem
        '
        Me.MenuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemSystemSettings, Me.ToolStripMenuItem1, Me.MenuItemExitSystem})
        Me.MenuSystem.Name = "MenuSystem"
        Me.MenuSystem.Size = New System.Drawing.Size(59, 21)
        Me.MenuSystem.Text = "系统(&S)"
        '
        'MenuItemSystemSettings
        '
        Me.MenuItemSystemSettings.Name = "MenuItemSystemSettings"
        Me.MenuItemSystemSettings.Size = New System.Drawing.Size(140, 22)
        Me.MenuItemSystemSettings.Text = "系统设置(&S)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(137, 6)
        '
        'MenuItemExitSystem
        '
        Me.MenuItemExitSystem.Name = "MenuItemExitSystem"
        Me.MenuItemExitSystem.Size = New System.Drawing.Size(140, 22)
        Me.MenuItemExitSystem.Text = "退出登录(&X)"
        '
        'MenuHelp
        '
        Me.MenuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemHelp, Me.ToolStripMenuItem2, Me.MenuItemAbout})
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
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(154, 6)
        '
        'MenuItemAbout
        '
        Me.MenuItemAbout.Name = "MenuItemAbout"
        Me.MenuItemAbout.Size = New System.Drawing.Size(157, 22)
        Me.MenuItemAbout.Text = "关于(&A)"
        '
        'LabelStudentID
        '
        Me.LabelStudentID.AutoSize = True
        Me.LabelStudentID.BackColor = System.Drawing.Color.Transparent
        Me.LabelStudentID.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelStudentID.ForeColor = System.Drawing.Color.White
        Me.LabelStudentID.Location = New System.Drawing.Point(963, 75)
        Me.LabelStudentID.Name = "LabelStudentID"
        Me.LabelStudentID.Size = New System.Drawing.Size(132, 22)
        Me.LabelStudentID.TabIndex = 1
        Me.LabelStudentID.Text = "学号: 20116524"
        '
        'LabelStudentName
        '
        Me.LabelStudentName.AutoSize = True
        Me.LabelStudentName.BackColor = System.Drawing.Color.Transparent
        Me.LabelStudentName.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelStudentName.ForeColor = System.Drawing.Color.White
        Me.LabelStudentName.Location = New System.Drawing.Point(964, 110)
        Me.LabelStudentName.Name = "LabelStudentName"
        Me.LabelStudentName.Size = New System.Drawing.Size(100, 22)
        Me.LabelStudentName.TabIndex = 2
        Me.LabelStudentName.Text = "姓名: 谢浩哲"
        '
        'BackgroundWorker
        '
        '
        'ButtonInformation
        '
        Me.ButtonInformation.BackColor = System.Drawing.Color.Transparent
        Me.ButtonInformation.Location = New System.Drawing.Point(27, 595)
        Me.ButtonInformation.Name = "ButtonInformation"
        Me.ButtonInformation.Size = New System.Drawing.Size(48, 48)
        Me.ButtonInformation.TabIndex = 3
        '
        'ButtonHelp
        '
        Me.ButtonHelp.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHelp.Location = New System.Drawing.Point(81, 595)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(48, 48)
        Me.ButtonHelp.TabIndex = 4
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.Location = New System.Drawing.Point(135, 596)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(48, 48)
        Me.ButtonExit.TabIndex = 5
        '
        'LabelInformation
        '
        Me.LabelInformation.AutoSize = True
        Me.LabelInformation.BackColor = System.Drawing.Color.Transparent
        Me.LabelInformation.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelInformation.ForeColor = System.Drawing.Color.White
        Me.LabelInformation.Location = New System.Drawing.Point(60, 193)
        Me.LabelInformation.Name = "LabelInformation"
        Me.LabelInformation.Size = New System.Drawing.Size(93, 26)
        Me.LabelInformation.TabIndex = 6
        Me.LabelInformation.Text = "答题信息:"
        '
        'LabelTitleQuestion
        '
        Me.LabelTitleQuestion.AutoSize = True
        Me.LabelTitleQuestion.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitleQuestion.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTitleQuestion.ForeColor = System.Drawing.Color.Black
        Me.LabelTitleQuestion.Location = New System.Drawing.Point(386, 193)
        Me.LabelTitleQuestion.Name = "LabelTitleQuestion"
        Me.LabelTitleQuestion.Size = New System.Drawing.Size(109, 27)
        Me.LabelTitleQuestion.TabIndex = 7
        Me.LabelTitleQuestion.Text = "Question:"
        '
        'LabelTitleAnswer
        '
        Me.LabelTitleAnswer.AutoSize = True
        Me.LabelTitleAnswer.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitleAnswer.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTitleAnswer.ForeColor = System.Drawing.Color.Black
        Me.LabelTitleAnswer.Location = New System.Drawing.Point(386, 352)
        Me.LabelTitleAnswer.Name = "LabelTitleAnswer"
        Me.LabelTitleAnswer.Size = New System.Drawing.Size(93, 27)
        Me.LabelTitleAnswer.TabIndex = 8
        Me.LabelTitleAnswer.Text = "Answer:"
        '
        'LabelQuestionID
        '
        Me.LabelQuestionID.AutoSize = True
        Me.LabelQuestionID.BackColor = System.Drawing.Color.Transparent
        Me.LabelQuestionID.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelQuestionID.ForeColor = System.Drawing.Color.White
        Me.LabelQuestionID.Location = New System.Drawing.Point(88, 245)
        Me.LabelQuestionID.Name = "LabelQuestionID"
        Me.LabelQuestionID.Size = New System.Drawing.Size(149, 21)
        Me.LabelQuestionID.TabIndex = 9
        Me.LabelQuestionID.Text = "答题计数: 000/ 100"
        '
        'LabelTitleTimeUsed
        '
        Me.LabelTitleTimeUsed.AutoSize = True
        Me.LabelTitleTimeUsed.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitleTimeUsed.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTitleTimeUsed.ForeColor = System.Drawing.Color.White
        Me.LabelTitleTimeUsed.Location = New System.Drawing.Point(88, 299)
        Me.LabelTitleTimeUsed.Name = "LabelTitleTimeUsed"
        Me.LabelTitleTimeUsed.Size = New System.Drawing.Size(78, 21)
        Me.LabelTitleTimeUsed.TabIndex = 10
        Me.LabelTitleTimeUsed.Text = "已用时间:"
        '
        'LabelTitleTimeRemaining
        '
        Me.LabelTitleTimeRemaining.AutoSize = True
        Me.LabelTitleTimeRemaining.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitleTimeRemaining.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTitleTimeRemaining.ForeColor = System.Drawing.Color.White
        Me.LabelTitleTimeRemaining.Location = New System.Drawing.Point(88, 328)
        Me.LabelTitleTimeRemaining.Name = "LabelTitleTimeRemaining"
        Me.LabelTitleTimeRemaining.Size = New System.Drawing.Size(78, 21)
        Me.LabelTitleTimeRemaining.TabIndex = 11
        Me.LabelTitleTimeRemaining.Text = "剩余时间:"
        '
        'TimerUp
        '
        Me.TimerUp.Interval = 1000
        '
        'TimerDown
        '
        Me.TimerDown.Interval = 1000
        '
        'LabelTimeRemaining
        '
        Me.LabelTimeRemaining.AutoSize = True
        Me.LabelTimeRemaining.BackColor = System.Drawing.Color.Transparent
        Me.LabelTimeRemaining.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTimeRemaining.ForeColor = System.Drawing.Color.White
        Me.LabelTimeRemaining.Location = New System.Drawing.Point(166, 329)
        Me.LabelTimeRemaining.Name = "LabelTimeRemaining"
        Me.LabelTimeRemaining.Size = New System.Drawing.Size(72, 21)
        Me.LabelTimeRemaining.TabIndex = 12
        Me.LabelTimeRemaining.Text = "00:00:00"
        '
        'LabelTimeUsed
        '
        Me.LabelTimeUsed.AutoSize = True
        Me.LabelTimeUsed.BackColor = System.Drawing.Color.Transparent
        Me.LabelTimeUsed.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelTimeUsed.ForeColor = System.Drawing.Color.White
        Me.LabelTimeUsed.Location = New System.Drawing.Point(166, 299)
        Me.LabelTimeUsed.Name = "LabelTimeUsed"
        Me.LabelTimeUsed.Size = New System.Drawing.Size(72, 21)
        Me.LabelTimeUsed.TabIndex = 13
        Me.LabelTimeUsed.Text = "00:00:00"
        '
        'Timer
        '
        Me.Timer.Interval = 3000
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.Location = New System.Drawing.Point(968, 474)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(86, 30)
        Me.ButtonPrevious.TabIndex = 0
        Me.ButtonPrevious.Text = "上一题 <<"
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        Me.ButtonPrevious.Visible = False
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(968, 520)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(86, 30)
        Me.ButtonNext.TabIndex = 1
        Me.ButtonNext.Text = "下一题 >>"
        Me.ButtonNext.UseVisualStyleBackColor = True
        Me.ButtonNext.Visible = False
        '
        'LabelQuestion
        '
        Me.LabelQuestion.BackColor = System.Drawing.Color.Transparent
        Me.LabelQuestion.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelQuestion.ForeColor = System.Drawing.Color.Black
        Me.LabelQuestion.Location = New System.Drawing.Point(417, 234)
        Me.LabelQuestion.Name = "LabelQuestion"
        Me.LabelQuestion.Size = New System.Drawing.Size(636, 115)
        Me.LabelQuestion.TabIndex = 18
        Me.LabelQuestion.Text = "LabelQuestion"
        '
        'ButtonOK
        '
        Me.ButtonOK.Enabled = False
        Me.ButtonOK.Location = New System.Drawing.Point(684, 444)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(86, 30)
        Me.ButtonOK.TabIndex = 22
        Me.ButtonOK.Text = "确定"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'TextJumpTo
        '
        Me.TextJumpTo.Location = New System.Drawing.Point(968, 411)
        Me.TextJumpTo.Name = "TextJumpTo"
        Me.TextJumpTo.Size = New System.Drawing.Size(85, 23)
        Me.TextJumpTo.TabIndex = 2
        Me.TextJumpTo.Text = "跳转至..."
        '
        'GroupBox
        '
        Me.GroupBox.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox.Controls.Add(Me.CheckBoxD)
        Me.GroupBox.Controls.Add(Me.CheckBoxC)
        Me.GroupBox.Controls.Add(Me.CheckBoxB)
        Me.GroupBox.Controls.Add(Me.CheckBoxA)
        Me.GroupBox.Controls.Add(Me.RadioButtonD)
        Me.GroupBox.Controls.Add(Me.RadioButtonC)
        Me.GroupBox.Controls.Add(Me.RadioButtonB)
        Me.GroupBox.Controls.Add(Me.RadioButtonA)
        Me.GroupBox.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(421, 376)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(496, 184)
        Me.GroupBox.TabIndex = 24
        Me.GroupBox.TabStop = False
        '
        'CheckBoxD
        '
        Me.CheckBoxD.AutoSize = True
        Me.CheckBoxD.Location = New System.Drawing.Point(34, 144)
        Me.CheckBoxD.Name = "CheckBoxD"
        Me.CheckBoxD.Size = New System.Drawing.Size(93, 21)
        Me.CheckBoxD.TabIndex = 21
        Me.CheckBoxD.Text = "CheckBoxD"
        Me.CheckBoxD.UseVisualStyleBackColor = True
        '
        'CheckBoxC
        '
        Me.CheckBoxC.AutoSize = True
        Me.CheckBoxC.Location = New System.Drawing.Point(35, 108)
        Me.CheckBoxC.Name = "CheckBoxC"
        Me.CheckBoxC.Size = New System.Drawing.Size(92, 21)
        Me.CheckBoxC.TabIndex = 20
        Me.CheckBoxC.Text = "CheckBoxC"
        Me.CheckBoxC.UseVisualStyleBackColor = True
        '
        'CheckBoxB
        '
        Me.CheckBoxB.AutoSize = True
        Me.CheckBoxB.Location = New System.Drawing.Point(35, 72)
        Me.CheckBoxB.Name = "CheckBoxB"
        Me.CheckBoxB.Size = New System.Drawing.Size(92, 21)
        Me.CheckBoxB.TabIndex = 19
        Me.CheckBoxB.Text = "CheckBoxB"
        Me.CheckBoxB.UseVisualStyleBackColor = True
        '
        'CheckBoxA
        '
        Me.CheckBoxA.AutoSize = True
        Me.CheckBoxA.Location = New System.Drawing.Point(35, 35)
        Me.CheckBoxA.Name = "CheckBoxA"
        Me.CheckBoxA.Size = New System.Drawing.Size(92, 21)
        Me.CheckBoxA.TabIndex = 18
        Me.CheckBoxA.Text = "CheckBoxA"
        Me.CheckBoxA.UseVisualStyleBackColor = True
        '
        'RadioButtonD
        '
        Me.RadioButtonD.AutoSize = True
        Me.RadioButtonD.Location = New System.Drawing.Point(35, 143)
        Me.RadioButtonD.Name = "RadioButtonD"
        Me.RadioButtonD.Size = New System.Drawing.Size(107, 21)
        Me.RadioButtonD.TabIndex = 17
        Me.RadioButtonD.Text = "RadioButtonD"
        Me.RadioButtonD.UseVisualStyleBackColor = True
        '
        'RadioButtonC
        '
        Me.RadioButtonC.AutoSize = True
        Me.RadioButtonC.Location = New System.Drawing.Point(35, 107)
        Me.RadioButtonC.Name = "RadioButtonC"
        Me.RadioButtonC.Size = New System.Drawing.Size(106, 21)
        Me.RadioButtonC.TabIndex = 16
        Me.RadioButtonC.Text = "RadioButtonC"
        Me.RadioButtonC.UseVisualStyleBackColor = True
        '
        'RadioButtonB
        '
        Me.RadioButtonB.AutoSize = True
        Me.RadioButtonB.Location = New System.Drawing.Point(36, 71)
        Me.RadioButtonB.Name = "RadioButtonB"
        Me.RadioButtonB.Size = New System.Drawing.Size(106, 21)
        Me.RadioButtonB.TabIndex = 15
        Me.RadioButtonB.Text = "RadioButtonB"
        Me.RadioButtonB.UseVisualStyleBackColor = True
        '
        'RadioButtonA
        '
        Me.RadioButtonA.AutoSize = True
        Me.RadioButtonA.Location = New System.Drawing.Point(35, 34)
        Me.RadioButtonA.Name = "RadioButtonA"
        Me.RadioButtonA.Size = New System.Drawing.Size(106, 21)
        Me.RadioButtonA.TabIndex = 14
        Me.RadioButtonA.Text = "RadioButtonA"
        Me.RadioButtonA.UseVisualStyleBackColor = True
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SoftwareQASystem.My.Resources.Resources.Frm_Main
        Me.ClientSize = New System.Drawing.Size(1152, 647)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.TextJumpTo)
        Me.Controls.Add(Me.LabelQuestion)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.LabelTimeUsed)
        Me.Controls.Add(Me.LabelTimeRemaining)
        Me.Controls.Add(Me.LabelTitleTimeRemaining)
        Me.Controls.Add(Me.LabelTitleTimeUsed)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.LabelQuestionID)
        Me.Controls.Add(Me.LabelTitleAnswer)
        Me.Controls.Add(Me.LabelTitleQuestion)
        Me.Controls.Add(Me.LabelInformation)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.ButtonInformation)
        Me.Controls.Add(Me.LabelStudentName)
        Me.Controls.Add(Me.LabelStudentID)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1168, 685)
        Me.MinimumSize = New System.Drawing.Size(1168, 685)
        Me.Name = "Frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "软件基础知识竞赛问答系统"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelStudentID As System.Windows.Forms.Label
    Friend WithEvents LabelStudentName As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuItemHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItemAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemExitSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonInformation As System.Windows.Forms.Label
    Friend WithEvents ButtonHelp As System.Windows.Forms.Label
    Friend WithEvents ButtonExit As System.Windows.Forms.Label
    Friend WithEvents MenuItemSystemSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LabelInformation As System.Windows.Forms.Label
    Friend WithEvents LabelTitleQuestion As System.Windows.Forms.Label
    Friend WithEvents LabelTitleAnswer As System.Windows.Forms.Label
    Friend WithEvents LabelQuestionID As System.Windows.Forms.Label
    Friend WithEvents LabelTitleTimeUsed As System.Windows.Forms.Label
    Friend WithEvents LabelTitleTimeRemaining As System.Windows.Forms.Label
    Friend WithEvents TimerUp As System.Windows.Forms.Timer
    Friend WithEvents TimerDown As System.Windows.Forms.Timer
    Friend WithEvents LabelTimeRemaining As System.Windows.Forms.Label
    Friend WithEvents LabelTimeUsed As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents ButtonPrevious As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents LabelQuestion As System.Windows.Forms.Label
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents TextJumpTo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxD As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxC As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxB As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxA As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButtonD As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonC As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonB As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonA As System.Windows.Forms.RadioButton
End Class
