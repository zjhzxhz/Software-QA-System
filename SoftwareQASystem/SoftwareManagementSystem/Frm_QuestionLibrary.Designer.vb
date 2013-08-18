<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QuestionLibrary
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
        Me.ButtonDeleteQuestion = New System.Windows.Forms.Button()
        Me.ComboGroup = New System.Windows.Forms.ComboBox()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.DataGridQuestionLibrary = New System.Windows.Forms.DataGrid()
        Me.LabelGruop = New System.Windows.Forms.Label()
        Me.GroupEdit = New System.Windows.Forms.GroupBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.LabelEditDatabase = New System.Windows.Forms.Label()
        CType(Me.DataGridQuestionLibrary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonDeleteQuestion
        '
        Me.ButtonDeleteQuestion.Enabled = False
        Me.ButtonDeleteQuestion.Location = New System.Drawing.Point(39, 77)
        Me.ButtonDeleteQuestion.Name = "ButtonDeleteQuestion"
        Me.ButtonDeleteQuestion.Size = New System.Drawing.Size(75, 31)
        Me.ButtonDeleteQuestion.TabIndex = 112
        Me.ButtonDeleteQuestion.Text = "删除试题"
        Me.ButtonDeleteQuestion.UseVisualStyleBackColor = True
        '
        'ComboGroup
        '
        Me.ComboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboGroup.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboGroup.FormattingEnabled = True
        Me.ComboGroup.Items.AddRange(New Object() {"专业组", "非专业组"})
        Me.ComboGroup.Location = New System.Drawing.Point(814, 109)
        Me.ComboGroup.Name = "ComboGroup"
        Me.ComboGroup.Size = New System.Drawing.Size(159, 28)
        Me.ComboGroup.TabIndex = 113
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(39, 26)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 31)
        Me.ButtonEdit.TabIndex = 111
        Me.ButtonEdit.Text = "启用编辑"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'DataGridQuestionLibrary
        '
        Me.DataGridQuestionLibrary.AlternatingBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DataGridQuestionLibrary.BackColor = System.Drawing.Color.White
        Me.DataGridQuestionLibrary.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DataGridQuestionLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGridQuestionLibrary.CaptionBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DataGridQuestionLibrary.CaptionFont = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DataGridQuestionLibrary.CaptionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridQuestionLibrary.CaptionText = "软件基础知识竞赛试题库"
        Me.DataGridQuestionLibrary.DataMember = ""
        Me.DataGridQuestionLibrary.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridQuestionLibrary.FlatMode = True
        Me.DataGridQuestionLibrary.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridQuestionLibrary.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridQuestionLibrary.GridLineColor = System.Drawing.Color.Peru
        Me.DataGridQuestionLibrary.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGridQuestionLibrary.HeaderBackColor = System.Drawing.Color.Maroon
        Me.DataGridQuestionLibrary.HeaderFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridQuestionLibrary.HeaderForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DataGridQuestionLibrary.LinkColor = System.Drawing.Color.Maroon
        Me.DataGridQuestionLibrary.Location = New System.Drawing.Point(0, 0)
        Me.DataGridQuestionLibrary.Name = "DataGridQuestionLibrary"
        Me.DataGridQuestionLibrary.ParentRowsBackColor = System.Drawing.Color.BurlyWood
        Me.DataGridQuestionLibrary.ParentRowsForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridQuestionLibrary.PreferredColumnWidth = 128
        Me.DataGridQuestionLibrary.ReadOnly = True
        Me.DataGridQuestionLibrary.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridQuestionLibrary.SelectionForeColor = System.Drawing.Color.GhostWhite
        Me.DataGridQuestionLibrary.Size = New System.Drawing.Size(768, 562)
        Me.DataGridQuestionLibrary.TabIndex = 0
        '
        'LabelGruop
        '
        Me.LabelGruop.AutoSize = True
        Me.LabelGruop.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelGruop.Location = New System.Drawing.Point(791, 75)
        Me.LabelGruop.Name = "LabelGruop"
        Me.LabelGruop.Size = New System.Drawing.Size(95, 22)
        Me.LabelGruop.TabIndex = 114
        Me.LabelGruop.Text = "请选择组别:"
        '
        'GroupEdit
        '
        Me.GroupEdit.Controls.Add(Me.ButtonSave)
        Me.GroupEdit.Controls.Add(Me.ButtonEdit)
        Me.GroupEdit.Controls.Add(Me.ButtonDeleteQuestion)
        Me.GroupEdit.Location = New System.Drawing.Point(814, 230)
        Me.GroupEdit.Name = "GroupEdit"
        Me.GroupEdit.Size = New System.Drawing.Size(159, 180)
        Me.GroupEdit.TabIndex = 115
        Me.GroupEdit.TabStop = False
        '
        'ButtonSave
        '
        Me.ButtonSave.Enabled = False
        Me.ButtonSave.Location = New System.Drawing.Point(39, 129)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 31)
        Me.ButtonSave.TabIndex = 117
        Me.ButtonSave.Text = "保存修改"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'LabelEditDatabase
        '
        Me.LabelEditDatabase.AutoSize = True
        Me.LabelEditDatabase.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelEditDatabase.Location = New System.Drawing.Point(791, 205)
        Me.LabelEditDatabase.Name = "LabelEditDatabase"
        Me.LabelEditDatabase.Size = New System.Drawing.Size(95, 22)
        Me.LabelEditDatabase.TabIndex = 116
        Me.LabelEditDatabase.Text = "修改试题库:"
        '
        'Frm_QuestionLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(1008, 562)
        Me.Controls.Add(Me.LabelEditDatabase)
        Me.Controls.Add(Me.GroupEdit)
        Me.Controls.Add(Me.LabelGruop)
        Me.Controls.Add(Me.DataGridQuestionLibrary)
        Me.Controls.Add(Me.ComboGroup)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 600)
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "Frm_QuestionLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "题库设置"
        CType(Me.DataGridQuestionLibrary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupEdit.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonDeleteQuestion As System.Windows.Forms.Button
    Friend WithEvents ComboGroup As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents DataGridQuestionLibrary As System.Windows.Forms.DataGrid
    Friend WithEvents LabelGruop As System.Windows.Forms.Label
    Friend WithEvents GroupEdit As System.Windows.Forms.GroupBox
    Friend WithEvents LabelEditDatabase As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
End Class
