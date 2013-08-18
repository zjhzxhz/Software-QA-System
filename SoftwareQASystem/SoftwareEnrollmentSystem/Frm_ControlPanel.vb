Public Class Frm_ControlPanel
    Private Sub Frm_ControlPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '从Config.Xml文件中读取用户配置信息
        Dim XmlDocumentPath = Application.StartupPath & "\Config.Xml"
        If Dir(XmlDocumentPath) <> Nothing Then
            ReadXmlDocument(XmlDocumentPath)
        End If
        '调整LabelTitle显示文本及显示位置
        LabelTitle.Text = "验证通过,请在左侧选择设置项"
        LabelTitle.Location = New System.Drawing.Point(520, 335)
    End Sub
    Private Sub Frm_ControlPanel_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        '保存Config.Xml
        Dim XmlDocumentPath = Application.StartupPath & "\Config.Xml"
        Try
            '若Config.Xml文件已存在,则删除该文件
            If Dir(XmlDocumentPath) <> Nothing Then
                My.Computer.FileSystem.DeleteFile(XmlDocumentPath)
            End If
            '创建Config.Xml文件
            CreateXmlDocument(XmlDocumentPath)
        Catch ex As Exception
            MsgBox("An error occured while deleting Config.Xml" & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
    Private Sub ButtonSystemSettings_Click(sender As Object, e As EventArgs) Handles ButtonSystemSettings.Click
        '调整LabelTitle显示文本及显示位置
        LabelTitle.Text = "系统设置"
        LabelTitle.Location = New System.Drawing.Point(384, 176)
        '设置控件Visable状态
        GroupServerSettings.Visible = False
        GroupSchoolSettings.Visible = False
        GroupSystemSettings.Visible = True
        ButtonSave.Visible = True
        ButtonReset.Visible = True
        '读取当前配置信息至控件
        If Mode = "Network" And (StandbyServerIpAddress <> "Disabled" And StandbyServerPort <> "Disabled") Then
            ComboMode.Text = "联机报名模式"
        Else 'If Mode = "Local" Then
            ComboMode.Text = "脱机报名模式"
        End If
        TextAdministratorUserName.Text = AdministratorUserName
        TextAdministratorPassword.PasswordChar = Nothing
        TextAdministratorPassword.Text = "(保存的密码)"
    End Sub
    Private Sub TextAdministratorPassword_GotFocus(sender As Object, e As System.EventArgs) Handles TextAdministratorPassword.GotFocus
        TextAdministratorPassword.Clear()
        TextAdministratorPassword.PasswordChar = "●"
    End Sub
    Private Sub TextAdministratorPassword_LostFocus(sender As Object, e As System.EventArgs) Handles TextAdministratorPassword.LostFocus
        If TextAdministratorPassword.Text = Nothing Then
            TextAdministratorPassword.PasswordChar = Nothing
            TextAdministratorPassword.Text = "(保存的密码)"
        End If
    End Sub
    Private Sub ButtonServerSettings_Click(sender As Object, e As EventArgs) Handles ButtonServerSettings.Click
        '调整LabelTitle显示文本及显示位置
        LabelTitle.Text = "服务器设置"
        LabelTitle.Location = New System.Drawing.Point(384, 176)
        '设置控件Visable状态
        GroupSystemSettings.Visible = False
        GroupSchoolSettings.Visible = False
        GroupServerSettings.Visible = True
        ButtonSave.Visible = True
        ButtonReset.Visible = True
        '清空本机IP地址列表
        ComboMainServerIpAddress.Items.Clear()
        ComboStandbyServerIpAddress.Items.Clear()
        '添加本机IP地址至控件
        Dim IpAddressList() As System.Net.IPAddress = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.ToArray()
        ComboMainServerIpAddress.Items.Clear()
        ComboStandbyServerIpAddress.Items.Clear()
        For i = 0 To UBound(IpAddressList)
            ComboMainServerIpAddress.Items.Add(IpAddressList(i))
            ComboStandbyServerIpAddress.Items.Add(IpAddressList(i))
        Next
        '读取当前配置信息至控件
        If MainServerIpAddress = "Disabled" Then
            CheckBoxMainServer.Checked = False
            ComboMainServerIpAddress.Text = "(不可用)"
            ComboMainServerIpAddress.Enabled = False
            TextMainServerPort.Text = "(不可用)"
            TextMainServerPort.Enabled = False
        Else
            CheckBoxMainServer.Checked = True
            ComboMainServerIpAddress.Text = MainServerIpAddress
            TextMainServerPort.Text = MainServerPort
        End If
        If StandbyServerIpAddress = "Disabled" Then
            CheckBoxStandbyServer.Checked = False
            ComboStandbyServerIpAddress.Text = "(不可用)"
            ComboStandbyServerIpAddress.Enabled = False
            TextStandbyServerPort.Text = "(不可用)"
            TextStandbyServerPort.Enabled = False
        Else
            CheckBoxStandbyServer.Checked = True
            ComboStandbyServerIpAddress.Text = StandbyServerIpAddress
            TextStandbyServerPort.Text = StandbyServerPort
        End If
    End Sub
    Private Sub CheckBoxMainServer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxMainServer.CheckedChanged
        If CheckBoxMainServer.Checked = False Then
            ComboMainServerIpAddress.Text = "(不可用)"
            ComboMainServerIpAddress.Enabled = False
            TextMainServerPort.Text = "(不可用)"
            TextMainServerPort.Enabled = False
        Else
            ComboMainServerIpAddress.Enabled = True
            ComboMainServerIpAddress.Text = Nothing
            TextMainServerPort.Enabled = True
            TextMainServerPort.Text = Nothing
        End If
    End Sub
    Private Sub CheckBoxStandbyServer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxStandbyServer.CheckedChanged
        If CheckBoxStandbyServer.Checked = False Then
            ComboStandbyServerIpAddress.Text = "(不可用)"
            ComboStandbyServerIpAddress.Enabled = False
            TextStandbyServerPort.Text = "(不可用)"
            TextStandbyServerPort.Enabled = False
        Else
            ComboStandbyServerIpAddress.Enabled = True
            ComboStandbyServerIpAddress.Text = Nothing
            TextStandbyServerPort.Enabled = True
            TextStandbyServerPort.Text = Nothing
        End If
    End Sub
    Private Sub ButtonSchoolSettings_Click(sender As Object, e As EventArgs) Handles ButtonSchoolSettings.Click
        '调整LabelTitle显示文本及显示位置
        LabelTitle.Text = "院系设置"
        LabelTitle.Location = New System.Drawing.Point(384, 176)
        '设置控件Visable状态
        GroupSystemSettings.Visible = False
        GroupServerSettings.Visible = False
        GroupSchoolSettings.Visible = True
        ButtonSave.Visible = True
        ButtonReset.Visible = True
        '读取当前配置信息至控件
        Dim XmlDocumentPath = Application.StartupPath & "\SchoolInformation.Xml"
        TreeViewSchool.Nodes.Clear()    '清空TreeView原有内容
        If Dir(XmlDocumentPath) <> Nothing Then
            getSchoolInformation(XmlDocumentPath)
        End If
    End Sub
    Private Sub ButtonAddSchool_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAddSchool.Click
        Dim SchoolName As String = Nothing
        SchoolName = InputBox("请输入学院名称: ")
        If SchoolName <> Nothing Then
            TreeViewSchool.Nodes.Add(SchoolName)
        End If
    End Sub
    Private Sub ButtonAddProfession_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAddProfession.Click
        If TreeViewSchool.SelectedNode Is Nothing Then
            MsgBox("请选择需要添加专业的学院")
        Else
            Dim ProfessionName As String = Nothing
            ProfessionName = InputBox("请输入专业名称: " & Chr(13) & "[提示] 您正在向【" & TreeViewSchool.SelectedNode.Text.ToString & "】添加专业")
            If ProfessionName <> Nothing Then
                If TreeViewSchool.SelectedNode.Level = 0 Then   '判断所选结点是否为学院
                    TreeViewSchool.SelectedNode.Nodes.Add(ProfessionName)
                Else
                    MsgBox("请选择需要添加专业的学院")
                End If
            End If
        End If
    End Sub
    Private Sub ButtonDeleteNode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonDeleteNode.Click
        If TreeViewSchool.SelectedNode Is Nothing Then
            MsgBox("请选择需要删除的学院/ 专业")
        Else
            If MsgBox("您确定要删除所选学院/ 专业 (" & TreeViewSchool.SelectedNode.Text.ToString & ") 吗?", vbYesNo) = vbYes Then
                TreeViewSchool.Nodes.Remove(TreeViewSchool.SelectedNode)
            End If
        End If
    End Sub
    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSave.Click
        If LabelTitle.Text = "系统设置" Then
            '检测是否有未填项
            If ComboMode.Text = Nothing Then
                MsgBox("请选择报名模式")
                Exit Sub
            ElseIf TextAdministratorUserName.Text = Nothing Then
                MsgBox("请填写管理员用户名")
                Exit Sub
            ElseIf TextAdministratorPassword.Text = Nothing Then
                MsgBox("请填写管理员密码")
                Exit Sub
            End If
            If MsgBox("请确认您的修改:" & Chr(13) &
                   "    报名模式: " & ComboMode.Text & Chr(13) &
                   "    管理员用户名: " & TextAdministratorUserName.Text & Chr(13) &
                   "    管理员密码: " & TextAdministratorPassword.Text & Chr(13) &
                   "确认要继续吗?", vbYesNo) = vbYes Then
                '保存用户配置
                AdministratorUserName = TextAdministratorUserName.Text
                If ComboMode.Text = "脱机报名模式" Then
                    Mode = "Local"
                Else 'If ComboMode.Text = "联机报名模式" Then
                    If StandbyServerIpAddress = "Disabled" Or StandbyServerPort = "Disabled" Then
                        MsgBox("检测到您禁用了备用服务器, 无法开启联机报名模式!")
                        Mode = "Local"
                        ComboMode.Text = "脱机报名模式"
                    Else
                        Mode = "Network"
                    End If
                End If
                '判断管理员密码是否被修改
                If TextAdministratorPassword.Text <> "(保存的密码)" Then
                    AdministratorPassWord = TextAdministratorPassword.Text
                End If
            End If
        ElseIf LabelTitle.Text = "服务器设置" Then
            '验证是否有未填写的信息
            If ComboMainServerIpAddress.Text = Nothing Then
                MsgBox("请填写主服务器的IP地址")
                Exit Sub
            ElseIf TextMainServerPort.Text = Nothing Then
                MsgBox("请填写主服务器需要开放的端口")
                Exit Sub
            ElseIf ComboStandbyServerIpAddress.Text = Nothing Then
                MsgBox("请填写备用服务器的IP地址")
                Exit Sub
            ElseIf TextStandbyServerPort.Text = Nothing Then
                MsgBox("请填写备用服务器需要开放的端口")
                Exit Sub
            End If
            '验证主服务器IP地址以及端口合法性
            If CheckBoxMainServer.Checked = True Then
                If Not System.Text.RegularExpressions.Regex.IsMatch(ComboMainServerIpAddress.Text, "^\s*((([0-9A-Fa-f]{1,4}:){7}(([0-9A-Fa-f]{1,4})|:))|(([0-9A-Fa-f]{1,4}:){6}(:|((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})|(:[0-9A-Fa-f]{1,4})))|(([0-9A-Fa-f]{1,4}:){5}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(([0-9A-Fa-f]{1,4}:){4}(:[0-9A-Fa-f]{1,4}){0,1}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(([0-9A-Fa-f]{1,4}:){3}(:[0-9A-Fa-f]{1,4}){0,2}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(([0-9A-Fa-f]{1,4}:){2}(:[0-9A-Fa-f]{1,4}){0,3}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(([0-9A-Fa-f]{1,4}:)(:[0-9A-Fa-f]{1,4}){0,4}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(:(:[0-9A-Fa-f]{1,4}){0,5}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})))(%.+)?\s*$") Then
                    MsgBox("请检查主服务器IP地址输入的合法性!")
                    Exit Sub
                End If
            End If
            If TextMainServerPort.Text <> "(不可用)" And (IsNumeric(TextMainServerPort.Text) = False Or Val(TextMainServerPort.Text) > 65535 Or Val(TextMainServerPort.Text) < 1) Then
                MsgBox("请检查主服务器开放端口输入的合法性!" & Chr(13) & "提示: 请输入范围在(0,65536)范围内的整数.")
                Exit Sub
            End If
            '验证备用服务器IP地址以及端口合法性
            If CheckBoxStandbyServer.Checked = True Then
                If Not System.Text.RegularExpressions.Regex.IsMatch(ComboStandbyServerIpAddress.Text, "^\s*((([0-9A-Fa-f]{1,4}:){7}(([0-9A-Fa-f]{1,4})|:))|(([0-9A-Fa-f]{1,4}:){6}(:|((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})|(:[0-9A-Fa-f]{1,4})))|(([0-9A-Fa-f]{1,4}:){5}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(([0-9A-Fa-f]{1,4}:){4}(:[0-9A-Fa-f]{1,4}){0,1}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(([0-9A-Fa-f]{1,4}:){3}(:[0-9A-Fa-f]{1,4}){0,2}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(([0-9A-Fa-f]{1,4}:){2}(:[0-9A-Fa-f]{1,4}){0,3}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(([0-9A-Fa-f]{1,4}:)(:[0-9A-Fa-f]{1,4}){0,4}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(:(:[0-9A-Fa-f]{1,4}){0,5}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})))(%.+)?\s*$") Then
                    MsgBox("请检查备用服务器IP地址输入的合法性!")
                    Exit Sub
                End If
            End If
            If TextStandbyServerPort.Text <> "(不可用)" And (IsNumeric(TextStandbyServerPort.Text) = False Or Val(TextStandbyServerPort.Text) > 65535 Or Val(TextStandbyServerPort.Text) < 1) Then
                MsgBox("请检查备用服务器开放端口输入的合法性!" & Chr(13) & "提示: 请输入范围在(0,65536)范围内的整数.")
                Exit Sub
            End If
            '检测主服务器和备用服务器是否同时禁用
            If (ComboMainServerIpAddress.Text = "(不可用)" Or TextMainServerPort.Text = "(不可用)") And (ComboStandbyServerIpAddress.Text = "(不可用)" Or TextStandbyServerPort.Text = "(不可用)") Then
                MsgBox("您不能同时禁用主服务器和备用服务器!")
                Exit Sub
            End If
            '检测主服务器和备用服务器是否冲突
            If ComboMainServerIpAddress.Text = ComboStandbyServerIpAddress.Text And TextMainServerPort.Text = TextStandbyServerPort.Text Then
                MsgBox("备用服务器与主服务器的IP地址与开放端口不能完全相同!" & Chr(13) & "否则将导致服务无法正常启动!")
                Exit Sub
            End If
            '请求用户确认修改
            If MsgBox("请确认您的修改:" & Chr(13) &
                   "    主服务器" & Chr(13) &
                   "        IP地址: " & ComboMainServerIpAddress.Text & Chr(13) &
                   "        Port: " & TextMainServerPort.Text & Chr(13) &
                   "    备用服务器" & Chr(13) &
                   "        IP地址: " & ComboStandbyServerIpAddress.Text & Chr(13) &
                   "        Port: " & TextStandbyServerPort.Text & Chr(13) &
                   "确认要继续吗?", vbYesNo) = vbYes Then
                '保存主服务器用户配置
                If CheckBoxMainServer.Checked = True Then
                    MainServerIpAddress = ComboMainServerIpAddress.Text
                    MainServerPort = TextMainServerPort.Text
                Else
                    MainServerIpAddress = "Disabled"
                    MainServerPort = "Disabled"
                End If
                '保存备用服务器用户配置
                If CheckBoxStandbyServer.Checked = True Then
                    StandbyServerIpAddress = ComboStandbyServerIpAddress.Text
                    StandbyServerPort = TextStandbyServerPort.Text
                Else
                    StandbyServerIpAddress = "Disabled"
                    StandbyServerPort = "Disabled"
                End If
            Else
                Exit Sub
            End If
        Else 'If LabelTitle.Text = "院系设置" Then
            Dim XmlDocumentPath = Application.StartupPath & "\SchoolInformation.Xml"
            '删除已存在的SchoolInformation.Xml文件
            If Dir(XmlDocumentPath) <> Nothing Then
                Try
                    My.Computer.FileSystem.DeleteFile(XmlDocumentPath)
                Catch ex As Exception
                    MsgBox("An error occured while deleting SchoolInformation.Xml" & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
                End Try
            End If
            setSchoolInformation(XmlDocumentPath)
            MsgBox("已成功保存您的修改!")
        End If
    End Sub
    Private Sub ButtonReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonReset.Click
        If MsgBox("请问要继续吗?" & Chr(13) & "继续将撤销该页面的所有更改!", vbYesNo) = vbYes Then
            If LabelTitle.Text = "系统设置" Then
                TextAdministratorUserName.Text = AdministratorUserName
                If Mode = "Local" Then
                    ComboMode.Text = "脱机报名模式"
                Else 'If Mode = "Network" Then
                    ComboMode.Text = "联机报名模式"
                End If
                '恢复文本显示
                TextAdministratorPassword.PasswordChar = Nothing
                TextAdministratorPassword.Text = "(保存的密码)"
            ElseIf LabelTitle.Text = "服务器设置" Then
                If MainServerIpAddress = "Disabled" Then
                    CheckBoxMainServer.Checked = False
                    ComboMainServerIpAddress.Text = "(不可用)"
                    ComboMainServerIpAddress.Enabled = False
                    TextMainServerPort.Text = "(不可用)"
                    TextMainServerPort.Enabled = False
                Else
                    CheckBoxMainServer.Checked = True
                    ComboMainServerIpAddress.Text = MainServerIpAddress
                    TextMainServerPort.Text = MainServerPort
                End If
                If StandbyServerIpAddress = "Disabled" Then
                    CheckBoxStandbyServer.Checked = False
                    ComboStandbyServerIpAddress.Text = "(不可用)"
                    ComboStandbyServerIpAddress.Enabled = False
                    TextStandbyServerPort.Text = "(不可用)"
                    TextStandbyServerPort.Enabled = False
                Else
                    CheckBoxStandbyServer.Checked = True
                    ComboStandbyServerIpAddress.Text = StandbyServerIpAddress
                    TextStandbyServerPort.Text = StandbyServerPort
                End If
            Else 'If LabelTitle.Text = "院系设置" Then
                Dim XmlDocumentPath = Application.StartupPath & "\SchoolInformation.Xml"
                TreeViewSchool.Nodes.Clear()    '清空TreeView原有内容
                If Dir(XmlDocumentPath) <> Nothing Then
                    getSchoolInformation(XmlDocumentPath)
                End If
            End If
        End If
    End Sub
    Private Sub MenuItemManagementCenter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemManagementCenter.Click
        If Mode = "Local" Then          '若使用脱机模式报名
            If isLogined Then   '若用户已登录
                Frm_ManagementCenter.Show()
                Me.Close()
            Else                '若用户未登录
                Frm_Login.ComboDomain.Text = "管理中心"
                Frm_Login.ComboDomain.Enabled = False
                Frm_Login.Show()
                Me.Close()
            End If
        Else 'If Mode = "Network" Then  '若使用联机模式报名
            MsgBox("在联机报名模式下, 管理中心不可用!")
        End If
    End Sub
    Private Sub MenuItemMainForm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemMainForm.Click
        Frm_Main.Show()
        Me.Close()
    End Sub
    Private Sub MenuItemExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemExit.Click
        If MsgBox("您确定要退出【软件知识竞赛报名系统】吗?", vbYesNo) = vbYes Then
            End
        End If
    End Sub
    Private Sub MenuItemLogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLogout.Click
        isLogined = False
        MsgBox("您已成功退出登录, 现在为您跳转至登录前页面.")
        Frm_Main.Show()
        Me.Close()
    End Sub
    Private Sub MenuItemHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemHelp.Click
        If Dir(System.Windows.Forms.Application.StartupPath & "\HelpAndSupport.Chm") <> Nothing Then
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath & "\HelpAndSupport.Chm")
        Else
            MsgBox("未找到帮助文件!" & Chr(13) & "对此给您带来的不便我们深表歉意!" & Chr(13) & Chr(13) & "[Exception] HelpAndSupport.Chm Not Exists!")
        End If
    End Sub
    Private Sub MenuItemAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAbout.Click
        Frm_About.ShowDialog()
    End Sub
    Private Sub getSchoolInformation(ByVal XmlDocumentPath As String)
        Dim XmlReader As New Xml.XmlTextReader(XmlDocumentPath)
        Dim SchoolCounter As Short = -1
        Try
            '添加学院和专业信息至TreeView
            While XmlReader.Read
                If (XmlReader.NodeType = Xml.XmlNodeType.Element) Then
                    Select Case (XmlReader.LocalName)
                        Case "SchoolName"
                            TreeViewSchool.Nodes.Add(XmlReader.GetAttribute(0))
                            SchoolCounter += 1
                        Case "Profession"
                            TreeViewSchool.Nodes.Item(SchoolCounter).Nodes.Add(XmlReader.ReadString())
                    End Select
                End If
            End While
        Catch ex As Exception
            MsgBox("An error occured while adding Schools to TreeViewSchool." & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
    Private Sub setSchoolInformation(ByVal XmlDocumentPath As String)
        Try
            Dim XmlWriter As New Xml.XmlTextWriter(XmlDocumentPath, System.Text.Encoding.GetEncoding("utf-8"))
            XmlWriter.Formatting = Xml.Formatting.Indented '使用自动缩进便于阅读
            XmlWriter.WriteRaw("<?xml version=""1.0"" encoding=""utf-8"" ?>")
            XmlWriter.WriteStartElement("SchoolInformation")                                '创建根元素
            For i As UShort = 0 To TreeViewSchool.Nodes.Count - 1                           '添加第二级元素
                '添加学院
                XmlWriter.WriteStartElement("SchoolName")
                XmlWriter.WriteAttributeString("Name", TreeViewSchool.Nodes.Item(i).Text.ToString)
                '添加专业
                For j As UShort = 0 To TreeViewSchool.Nodes.Item(i).Nodes.Count - 1
                    XmlWriter.WriteElementString("Profession", TreeViewSchool.Nodes.Item(i).Nodes.Item(j).Text.ToString)
                Next
                XmlWriter.WriteEndElement()
            Next
            XmlWriter.WriteFullEndElement()                                                 '关闭根元素
            XmlWriter.Close()                                                               '关闭Xml文档
        Catch ex As Exception
            MsgBox("An error occured while saving SchoolInformation." & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
End Class