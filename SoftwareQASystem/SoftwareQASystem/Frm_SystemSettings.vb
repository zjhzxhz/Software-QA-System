Imports System.Data.OleDb
Public Class Frm_SystemSettings
    Private isLogined As Boolean = False    '记录用户登录状态
    Private TryTimes As UShort = 0          '最大尝试次数计数
    Private Sub Frm_SystemSettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '从Config.Xml文件中读取用户配置信息
        Dim XmlDocumentPath = Application.StartupPath & "\Config.Xml"
        If Dir(XmlDocumentPath) <> Nothing Then
            ReadXmlDocument(XmlDocumentPath)
        End If
        '调整MenuItemLogout显示文本
        MenuItemLogout.Text = "返回登录窗体(&B)"
        '调整LabelTitle显示文本及显示位置
        LabelTitle.Text = "要继续,请输入密码:"
        LabelTitle.Location = New System.Drawing.Point(400, 240)
    End Sub
    Private Sub Frm_SystemSettings_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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
            MsgBox("An error occured while deleting Config.Xml" & Chr(13) & Chr(13) & ex.Message)
        End Try
    End Sub
    Private Sub Frm_SystemSettings_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        '如果用户按下Enter键
        If e.KeyChar = Chr(13) Then
            If isLogined = False Then
                ButtonEnter_Click(sender, e)
            Else
                ButtonSave_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub ButtonEnter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEnter.Click
        If TextPassword.Text = AdministratorPassWord Or isLogined = True Then
            '记录用户登录状态
            isLogined = True
            '调整MenuItemLogout显示文本
            MenuItemLogout.Text = "退出登录(&L)"
            '设置控件不可见
            TextPassword.Visible = False
            ButtonEnter.Visible = False
            '调整LabelTitle显示文本及显示位置
            LabelTitle.Text = "验证通过,请在左侧选择设置项"
            LabelTitle.Location = New System.Drawing.Point(520, 335)
            '启用设置选项控件
            ButtonSystemSettings.Enabled = True
            ButtonServerSettings.Enabled = True
            ButtonQuestionLibrary.Enabled = True
        Else
            MsgBox("密码不正确!" & Chr(13) & "请尝试重新输入!")
            TextPassword.Clear()
            TryTimes += 1
            If TryTimes = 3 Then
                MsgBox("对不起,系统无法让您登陆!" & Chr(13) & "请向系统管理员咨询!")
                Frm_Login.Show()
                Me.Close()
            End If
        End If
    End Sub
    Private Sub ButtonSystemSettings_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSystemSettings.Click
        '调整LabelTitle显示文本及显示位置
        LabelTitle.Text = "系统设置"
        LabelTitle.Location = New System.Drawing.Point(380, 180)
        '设置控件Visable状态
        GroupServerSettings.Visible = False
        GroupQuestionLibrary.Visible = False
        GroupSystemSettings.Visible = True
        ButtonSave.Visible = True
        ButtonReset.Visible = True
        '添加本机IP地址至控件
        Dim IpAddressList() As System.Net.IPAddress = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.ToArray()
        ComboFtpServerIpAddress.Items.Clear()
        For i = 0 To UBound(IpAddressList)
            ComboFtpServerIpAddress.Items.Add(IpAddressList(i))
        Next
        '读取当前配置信息至控件
        TextAdministratorUserName.Text = AdministratorUserName
        TextAdministratorPassword.PasswordChar = Nothing
        TextAdministratorPassword.Text = "(保存的密码)"
        TextDatabasePassword.PasswordChar = Nothing
        TextDatabasePassword.Text = "(保存的密码)"
        ComboFtpServerIpAddress.Text = FtpServerIpAddress
        TextFtpServerUserName.Text = FtpServerUserName
        TextFtpServerPassword.PasswordChar = Nothing
        TextFtpServerPassword.Text = "(保存的密码)"
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
    Private Sub TextDatabasePassword_GotFocus(sender As Object, e As System.EventArgs) Handles TextDatabasePassword.GotFocus
        TextDatabasePassword.Clear()
        TextDatabasePassword.PasswordChar = "●"
    End Sub
    Private Sub TextDatabasePassword_LostFocus(sender As Object, e As System.EventArgs) Handles TextDatabasePassword.LostFocus
        If TextDatabasePassword.Text = Nothing Then
            TextDatabasePassword.PasswordChar = Nothing
            TextDatabasePassword.Text = "(保存的密码)"
        End If
    End Sub
    Private Sub TextFtpServerPassword_GotFocus(sender As Object, e As System.EventArgs) Handles TextFtpServerPassword.GotFocus
        TextFtpServerPassword.Clear()
        TextFtpServerPassword.PasswordChar = "●"
    End Sub
    Private Sub TextFtpServer_LostFocus(sender As Object, e As System.EventArgs) Handles TextFtpServerPassword.LostFocus
        If TextFtpServerPassword.Text = Nothing Then
            TextFtpServerPassword.PasswordChar = Nothing
            TextFtpServerPassword.Text = "(保存的密码)"
        End If
    End Sub
    Private Sub ButtonPageUpDown_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPageUpDown.Click
        If ButtonPageUpDown.Text = "下一页" Then
            '更新Button文字显示
            ButtonPageUpDown.Text = "上一页"
            '更新控件可见性
            LabelAdministratorUserName.Visible = False
            TextAdministratorUserName.Visible = False
            LabelAdministratorPassword.Visible = False
            TextAdministratorPassword.Visible = False
            LabelDatabasePassword.Visible = False
            TextDatabasePassword.Visible = False
            LabelFtpServerIpAddress.Visible = True
            ComboFtpServerIpAddress.Visible = True
            LabelFtpServerUserName.Visible = True
            TextFtpServerUserName.Visible = True
            LabelFtpServerPassword.Visible = True
            TextFtpServerPassword.Visible = True
        Else
            '更新Button文字显示
            ButtonPageUpDown.Text = "下一页"
            '更新控件可见性
            LabelAdministratorUserName.Visible = True
            TextAdministratorUserName.Visible = True
            LabelAdministratorPassword.Visible = True
            TextAdministratorPassword.Visible = True
            LabelDatabasePassword.Visible = True
            TextDatabasePassword.Visible = True
            LabelFtpServerIpAddress.Visible = False
            ComboFtpServerIpAddress.Visible = False
            LabelFtpServerUserName.Visible = False
            TextFtpServerUserName.Visible = False
            LabelFtpServerPassword.Visible = False
            TextFtpServerPassword.Visible = False
        End If
    End Sub
    Private Sub ButtonServerSettings_Click(sender As System.Object, e As System.EventArgs) Handles ButtonServerSettings.Click
        '调整LabelTitle显示文本及显示位置
        LabelTitle.Text = "服务器设置"
        LabelTitle.Location = New System.Drawing.Point(380, 180)
        '设置控件Visable状态
        GroupSystemSettings.Visible = False
        GroupQuestionLibrary.Visible = False
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
    Private Sub ButtonQuestionLibrary_Click(sender As System.Object, e As System.EventArgs) Handles ButtonQuestionLibrary.Click
        '调整LabelTitle显示文本及显示位置
        LabelTitle.Text = "题库设置"
        LabelTitle.Location = New System.Drawing.Point(380, 180)
        '设置控件Visable状态
        GroupSystemSettings.Visible = False
        GroupServerSettings.Visible = False
        GroupQuestionLibrary.Visible = True
        ButtonSave.Visible = True
        ButtonReset.Visible = True
        '读取当前配置信息至控件
        TextTotalQuestion.Text = TotalQuestion
        TextTotalTime.Text = TotalTime / 60         '将秒(Second)转化为分钟(Minute)
    End Sub
    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        If LabelTitle.Text = "系统设置" Then
            '检测是否有未填项
            If TextAdministratorUserName.Text = Nothing Then
                MsgBox("请填写管理员用户名")
                Exit Sub
            ElseIf TextAdministratorPassword.Text = Nothing Then
                MsgBox("请填写管理员密码")
                Exit Sub
            ElseIf TextDatabasePassword.Text = Nothing Then
                MsgBox("请填写数据库密码")
                Exit Sub
            ElseIf ComboFtpServerIpAddress.Text = Nothing Then
                MsgBox("请填写FTP服务器地址")
                Exit Sub
            ElseIf TextFtpServerUserName.Text = Nothing Then
                MsgBox("请填写FTP用户名")
                Exit Sub
            ElseIf TextFtpServerPassword.Text = Nothing Then
                MsgBox("请填写FTP密码")
                Exit Sub
            End If
            '判断Ftp服务器地址合法性
            If Not System.Text.RegularExpressions.Regex.IsMatch(ComboFtpServerIpAddress.Text, "^\s*((([0-9A-Fa-f]{1,4}:){7}(([0-9A-Fa-f]{1,4})|:))|(([0-9A-Fa-f]{1,4}:){6}(:|((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})|(:[0-9A-Fa-f]{1,4})))|(([0-9A-Fa-f]{1,4}:){5}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(([0-9A-Fa-f]{1,4}:){4}(:[0-9A-Fa-f]{1,4}){0,1}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(([0-9A-Fa-f]{1,4}:){3}(:[0-9A-Fa-f]{1,4}){0,2}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(([0-9A-Fa-f]{1,4}:){2}(:[0-9A-Fa-f]{1,4}){0,3}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(([0-9A-Fa-f]{1,4}:)(:[0-9A-Fa-f]{1,4}){0,4}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(:(:[0-9A-Fa-f]{1,4}){0,5}((:((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})?)|((:[0-9A-Fa-f]{1,4}){1,2})))|(((25[0-5]|2[0-4]\d|[01]?\d{1,2})(\.(25[0-5]|2[0-4]\d|[01]?\d{1,2})){3})))(%.+)?\s*$") Then
                MsgBox("请检查FTP服务器IP地址输入的合法性!")
                Exit Sub
            End If
            '请求用户确认修改
            If MsgBox("请确认您的修改:" & Chr(13) &
                   "    管理员用户名: " & TextAdministratorUserName.Text & Chr(13) &
                   "    管理员密码: " & TextAdministratorPassword.Text & Chr(13) &
                   "    数据库密码: " & TextDatabasePassword.Text & Chr(13) &
                   "    FTP地址: " & ComboFtpServerIpAddress.Text & Chr(13) &
                   "    FTP用户名: " & TextFtpServerUserName.Text & Chr(13) &
                   "    FTP密码: " & TextFtpServerPassword.Text & Chr(13) &
                   "确认要继续吗?", vbYesNo) = vbYes Then
                '保存用户配置
                AdministratorUserName = TextAdministratorUserName.Text  '修改管理员用户名
                FtpServerIpAddress = ComboFtpServerIpAddress.Text       '修改FTP服务器地址
                FtpServerUserName = TextFtpServerUserName.Text          '修改FTP用户名
                '判断管理员密码是否被修改
                If TextAdministratorPassword.Text <> "(保存的密码)" Then
                    AdministratorPassWord = TextAdministratorPassword.Text
                End If
                '判断数据库密码是否被修改
                If TextDatabasePassword.Text <> "(保存的密码)" Then
                    If Dir(DatabaseLocation) <> Nothing Then
                        '修改数据库密码
                        Dim Connection = New OleDbConnection(DatabaseConnectionString)
                        Dim Command As New OleDbCommand
                        Try
                            Connection.Open()
                            'TextDatabasePassword中为新密码, DatabasePassWord为旧密码
                            Command = New OleDbCommand("ALTER DATABASE PASSWORD " & TextDatabasePassword.Text & " " & DatabasePassWord, Connection)
                            Command.ExecuteNonQuery()
                            Command.Dispose()
                            Connection.Close()
                            '更新DatabasePassword
                            DatabasePassWord = TextDatabasePassword.Text
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    Else
                        MsgBox("未检测到数据库文件,无法完成数据库密码修改!" & Chr(13) & Chr(13) & "[Exception] Database Not Found!")
                        Exit Sub
                    End If
                    '判断Ftp服务器密码是否被修改
                    If TextFtpServerPassword.Text <> "(保存的密码)" Then
                        FtpServerPassword = TextFtpServerPassword.Text
                    End If
                End If
            Else '用户放弃修改
                Exit Sub
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
        Else 'If LabelTitle.Text = "题库设置" Then
            '验证是否有未填写的信息
            If TextTotalQuestion.Text = Nothing Then
                MsgBox("请填写试题总数")
                Exit Sub
            ElseIf TextTotalTime.Text = Nothing Then
                MsgBox("请填写答题时间")
                Exit Sub
            End If
            '验证输入有效性
            If IsNumeric(TextTotalQuestion.Text) = False Or Val(TextTotalQuestion.Text) < 0 Then
                MsgBox("请检查试题总数输入的合法性")
                Exit Sub
            ElseIf IsNumeric(TextTotalQuestion.Text) = False Or Val(TextTotalTime.Text) < 0 Then
                MsgBox("请检查答题时间输入的合法性")
                Exit Sub
            End If
            '验证输入合理性
            If Val(TextTotalQuestion.Text) > getTotalRecord("ProfessionalGroup") Or Val(TextTotalQuestion.Text) > getTotalRecord("Non-ProfessionalGroup") Then
                MsgBox("您输入的试题总数大于题库中题目总数")
                Exit Sub
            ElseIf Val(TextTotalTime.Text) > 120 Then
                If MsgBox("您设置的时间超过了 120 分钟, 我们不建议这样做." & Chr(13) & "您确定要继续吗?", vbYesNo) = vbNo Then
                    Exit Sub
                End If
            End If
            '请求用户确认修改
            If MsgBox("请确认您的修改:" & Chr(13) &
                   "    试题总数: " & TextTotalQuestion.Text & Chr(13) &
                   "    答题时间: " & TextTotalTime.Text & " 分钟" & Chr(13) &
                   "确认要继续吗?", vbYesNo) = vbYes Then
                '保存用户配置
                TotalQuestion = Val(TextTotalQuestion.Text)
                TotalTime = Val(TextTotalTime.Text) * 60
            Else
                Exit Sub
            End If
        End If
    End Sub
    Private Sub ButtonReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReset.Click
        If MsgBox("请问要继续吗?" & Chr(13) & "继续将撤销该页面的所有更改!", vbYesNo) = vbYes Then
            If LabelTitle.Text = "系统设置" Then
                TextAdministratorUserName.Text = AdministratorUserName
                '恢复文本显示
                TextAdministratorPassword.PasswordChar = Nothing
                TextAdministratorPassword.Text = "(保存的密码)"
                TextDatabasePassword.PasswordChar = Nothing
                TextDatabasePassword.Text = "(保存的密码)"
                ComboFtpServerIpAddress.Text = FtpServerIpAddress
                TextFtpServerUserName.Text = FtpServerUserName
                TextFtpServerPassword.PasswordChar = Nothing
                TextFtpServerPassword.Text = "(保存的密码)"
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
            Else 'If LabelTitle.Text = "题库设置" Then
                TextTotalQuestion.Text = Str(TotalQuestion)
                TextTotalTime.Text = Str(TotalTime)
            End If
        End If
    End Sub
    Private Sub MenuItemImportSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemImportSettings.Click
        If isLogined = False Then
            MsgBox("请先登录后才能导入配置文件!")
            Exit Sub
        Else
            If ImportExportFile("Import", "Config.Xml") = True Then
                MsgBox("已成功导入新的配置文件!")
            End If
        End If
        '从导入的Config.Xml文件中读取用户配置信息
        Dim XmlDocumentPath = Application.StartupPath & "\Config.Xml"
        If Dir(XmlDocumentPath) <> Nothing Then
            ReadXmlDocument(XmlDocumentPath)
        End If
    End Sub
    Private Sub MenuItemImportDatabase_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemImportDatabase.Click
        If isLogined = False Then
            MsgBox("请先登录后才能导入数据库文件!")
            Exit Sub
        Else
            If ImportExportFile("Import", "DataBase.mdb") = True Then
                MsgBox("已成功导入新的数据库文件!")
            End If
        End If
    End Sub
    Private Sub MenuItemExportSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemExportSettings.Click
        If isLogined = False Then
            MsgBox("请先登录后才能导出配置文件!")
            Exit Sub
        Else
            If ImportExportFile("Export", "Config.Xml") Then
                MsgBox("已成功导出您的配置文件至" & Chr(13) & OpenFileDialog.FileName)
            End If
        End If
    End Sub
    Private Sub MenuItemExportDatabase_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemExportDatabase.Click
        If isLogined = False Then
            MsgBox("请先登录后才能导出数据库文件!")
            Exit Sub
        Else
            If ImportExportFile("Export", "DataBase.mdb") Then
                MsgBox("已成功导出您的数据库文件至" & Chr(13) & OpenFileDialog.FileName)
            End If
        End If
    End Sub
    Private Sub MenuItemLogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLogout.Click
        Frm_Login.Show()
        Me.Close()
    End Sub
    Private Sub MenuItemExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemExit.Click
        MsgBox("感谢您的使用!")
        End
    End Sub
    Private Sub MenuItemHelp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemHelp.Click
        If Dir(System.Windows.Forms.Application.StartupPath & "\HelpAndSupport.Chm") <> Nothing Then
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath & "\HelpAndSupport.Chm")
        Else
            MsgBox("未找到帮助文件!" & Chr(13) & "对此给您带来的不便我们深表歉意!" & Chr(13) & Chr(13) & "[Exception] HelpAndSupport.Chm Not Exists!")
        End If
    End Sub
    Private Sub MenuItemAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemAbout.Click
        Frm_About.ShowDialog()
    End Sub
    Private Function ImportExportFile(ByVal Purpose As String, ByVal FileName As String) As Boolean
        Dim Source As String = Nothing
        Dim Destination As String = Nothing
        '更新OpenFileDialog显示
        OpenFileDialog.FileName = FileName
        If FileName = "Config.Xml" Then
            OpenFileDialog.Filter = "配置文件 (Config.Xml)|Config.Xml"
        Else 'If FileName = "DataBase.mdb"
            OpenFileDialog.Filter = "数据库文件 (DataBase.mdb)|DataBase.mdb"
        End If
        OpenFileDialog.RestoreDirectory = True
        '导入/导出 选项设置
        If Purpose = "Import" Then
            OpenFileDialog.CheckFileExists = True
        Else 'If Purpose = "Export"
            OpenFileDialog.CheckFileExists = False
        End If
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            '导入/导出 选项设置
            If Purpose = "Import" Then
                OpenFileDialog.CheckFileExists = True
                Source = OpenFileDialog.FileName
                Destination = Application.StartupPath & "\" & FileName
            Else 'If Purpose = "Export"
                OpenFileDialog.CheckFileExists = False
                Source = Application.StartupPath & "\" & FileName
                Destination = OpenFileDialog.FileName
            End If
            '检查文件是否存在
            If Dir(Destination) <> Nothing Then
                '若源文件位置和目标文件位置相同
                If Source = Destination Then
                    Return True
                Else
                    If MsgBox("应用程序目录已存在相同命名的文件, 确认要覆盖吗?", vbYesNo) = vbYes Then
                        My.Computer.FileSystem.DeleteFile(Destination)
                        FileCopy(Source, Destination)
                    Else
                        Return False            '用户取消操作
                    End If
                End If
            Else
                FileCopy(Source, Destination)
            End If
        Else
            Return False                        '用户取消操作
        End If
        Return True
    End Function
    Private Function getTotalRecord(ByVal TableName As String) As UInteger
        Dim Counter As UInteger = 0
        Try
            Dim Connection = New OleDbConnection(DatabaseConnectionString)
            Connection.Open()
            Dim SQL As String = "Select QuestionID From [" & TableName & "]"
            Dim Command = New OleDbCommand(SQL, Connection)
            Dim Reader As OleDbDataReader = Command.ExecuteReader
            While Reader.Read
                Counter += 1
            End While
            Command.Dispose()
            Connection.Close()
        Catch ex As Exception
            MsgBox("An error occured while getting TotalRecord in the database!" & Chr(13) & Chr(13) & ex.Message)
        End Try
        Return Counter
    End Function
End Class