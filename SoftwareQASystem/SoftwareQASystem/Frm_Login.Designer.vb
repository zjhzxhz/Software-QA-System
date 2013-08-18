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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.LabelCondition = New System.Windows.Forms.Label()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.BackGroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TextStudentID = New System.Windows.Forms.TextBox()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Label()
        Me.ButtonDummy = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Label()
        Me.ButtonSet = New System.Windows.Forms.Label()
        Me.ButtonHelp = New System.Windows.Forms.Label()
        Me.ButtonInformation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelCondition
        '
        Me.LabelCondition.AutoSize = True
        Me.LabelCondition.BackColor = System.Drawing.Color.Transparent
        Me.LabelCondition.Font = New System.Drawing.Font("Microsoft YaHei", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCondition.ForeColor = System.Drawing.Color.White
        Me.LabelCondition.Location = New System.Drawing.Point(523, 378)
        Me.LabelCondition.Name = "LabelCondition"
        Me.LabelCondition.Size = New System.Drawing.Size(0, 20)
        Me.LabelCondition.TabIndex = 4
        '
        'TextPassword
        '
        Me.TextPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextPassword.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextPassword.Location = New System.Drawing.Point(508, 418)
        Me.TextPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(261, 35)
        Me.TextPassword.TabIndex = 2
        Me.TextPassword.Text = "请输入您的密码"
        '
        'BackGroundWorker
        '
        '
        'Timer
        '
        Me.Timer.Interval = 3500
        '
        'TextStudentID
        '
        Me.TextStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextStudentID.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextStudentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextStudentID.Location = New System.Drawing.Point(216, 418)
        Me.TextStudentID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextStudentID.MaxLength = 10
        Me.TextStudentID.Name = "TextStudentID"
        Me.TextStudentID.Size = New System.Drawing.Size(260, 35)
        Me.TextStudentID.TabIndex = 1
        Me.TextStudentID.Text = "请输入您的学号"
        '
        'LabelUserName
        '
        Me.LabelUserName.BackColor = System.Drawing.Color.Transparent
        Me.LabelUserName.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelUserName.ForeColor = System.Drawing.Color.White
        Me.LabelUserName.Location = New System.Drawing.Point(370, 333)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(236, 36)
        Me.LabelUserName.TabIndex = 0
        Me.LabelUserName.Text = "姓  名"
        Me.LabelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonOK
        '
        Me.ButtonOK.BackColor = System.Drawing.Color.Transparent
        Me.ButtonOK.Location = New System.Drawing.Point(797, 411)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(48, 48)
        Me.ButtonOK.TabIndex = 3
        '
        'ButtonDummy
        '
        Me.ButtonDummy.Location = New System.Drawing.Point(12, 659)
        Me.ButtonDummy.Name = "ButtonDummy"
        Me.ButtonDummy.Size = New System.Drawing.Size(98, 29)
        Me.ButtonDummy.TabIndex = 0
        Me.ButtonDummy.Text = "ButtonDummy"
        Me.ButtonDummy.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.Location = New System.Drawing.Point(71, 598)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(36, 36)
        Me.ButtonExit.TabIndex = 5
        '
        'ButtonSet
        '
        Me.ButtonSet.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSet.Location = New System.Drawing.Point(17, 599)
        Me.ButtonSet.Name = "ButtonSet"
        Me.ButtonSet.Size = New System.Drawing.Size(36, 36)
        Me.ButtonSet.TabIndex = 6
        '
        'ButtonHelp
        '
        Me.ButtonHelp.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHelp.Location = New System.Drawing.Point(967, 17)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(42, 42)
        Me.ButtonHelp.TabIndex = 7
        '
        'ButtonInformation
        '
        Me.ButtonInformation.BackColor = System.Drawing.Color.Transparent
        Me.ButtonInformation.Location = New System.Drawing.Point(910, 17)
        Me.ButtonInformation.Name = "ButtonInformation"
        Me.ButtonInformation.Size = New System.Drawing.Size(42, 42)
        Me.ButtonInformation.TabIndex = 8
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SoftwareQASystem.My.Resources.Resources.Frm_Login
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.ButtonInformation)
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.ButtonSet)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonDummy)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.LabelUserName)
        Me.Controls.Add(Me.TextStudentID)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.LabelCondition)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 640)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 640)
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "软件基础知识问答系统登录"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCondition As System.Windows.Forms.Label
    Friend WithEvents TextPassword As System.Windows.Forms.TextBox
    Friend WithEvents BackGroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents TextStudentID As System.Windows.Forms.TextBox
    Friend WithEvents LabelUserName As System.Windows.Forms.Label
    Friend WithEvents ButtonOK As System.Windows.Forms.Label
    Friend WithEvents ButtonDummy As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Label
    Friend WithEvents ButtonSet As System.Windows.Forms.Label
    Friend WithEvents ButtonHelp As System.Windows.Forms.Label
    Friend WithEvents ButtonInformation As System.Windows.Forms.Label
End Class
