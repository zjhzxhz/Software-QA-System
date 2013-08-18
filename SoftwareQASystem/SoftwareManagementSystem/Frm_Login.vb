Public Class Frm_Login
    Private TryTimes As UShort = 0     '最大尝试次数计数
    Private Sub Frm_Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '检查可用的服务器角色
        Dim isMainServerAvailable As Boolean = False
        Dim isStandbyServerAvailable As Boolean = False
        If MainServerIpAddress <> "Disabled" And MainServerPort <> "Disabled" Then
            isMainServerAvailable = True
            ComboServerType.Items.Add("主服务器")
        End If
        If StandbyServerIpAddress <> "Disabled" And StandbyServerPort <> "Disabled" Then
            isStandbyServerAvailable = True
            ComboServerType.Items.Add("备用服务器")
        End If
        '若无可用的服务器
        If ComboServerType.Items.Count = 0 Then
            MsgBox("检测到主服务器和备用服务器都已禁用, 若要继续, 请现在【系统设置】中修改设置!")
            Frm_SystemSettings.Show()
            Me.Close()
        End If
        '根据本机IP地址自动匹配服务器角色
        Dim IpAddressList() As System.Net.IPAddress = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.ToArray()
        If StandbyServerIpAddress = "127.0.0.1" Then
            ComboServerType.Text = "主服务器"
        ElseIf MainServerIpAddress = "127.0.0.1" Then
            ComboServerType.Text = "备用服务器"
        Else
            For i = 0 To UBound(IpAddressList)
                If MainServerIpAddress = IpAddressList(i).ToString() Then
                    ComboServerType.Text = "主服务器"
                    Exit For
                ElseIf StandbyServerIpAddress = IpAddressList(i).ToString() Then
                    ComboServerType.Text = "备用服务器"
                    Exit For
                End If
            Next
        End If
    End Sub
    Private Sub Frm_Login_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        '如果用户按下Enter键
        If e.KeyChar = Chr(13) Then
            ButtonLogin_Click(sender, e)
        End If
    End Sub
    Private Sub ButtonLogin_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLogin.Click
        If ComboServerType.Text =Nothing Then   '判断是否已选择服务器角色
            MsgBox("请选择您的服务器角色!")
            Exit Sub
        ElseIf TextUserName.Text =Nothing Then  '判断是否已填写用户名
            MsgBox("请填写您的用户名!")
            Exit Sub
        ElseIf TextPassword.Text =Nothing Then  '判断是否已填写密码
            MsgBox("请填写您的密码!")
            Exit Sub
        End If
        '验证用户身份
        If TextUserName.Text = AdministratorUserName And TextPassword.Text = AdministratorPassWord Then
            isLogined = True
            '准备跳转到目标窗体
            MsgBox("欢迎你, " & TextUserName.Text & Chr(13) & "正在为您启动软件知识竞赛管理系统…")
            If ComboServerType.Text = "主服务器" Then
                Frm_MainServer.Show()
                Me.Close()
            Else 'ComboServerType.Text = "备用服务器"
                Frm_StandbyServer.Show()
                Me.Close()
            End If
        Else
            MsgBox("您的用户名或密码不正确!")   '提示用户用户名或密码不正确
            TextPassword.Clear()                '清空输入的密码
            TryTimes += 1
            '是否超过最大尝试次数限制
            If TryTimes = 3 Then
                MsgBox("对不起,系统无法让您登陆!" & Chr(13) & "请向系统管理员咨询!")
                End
            End If
            Exit Sub
        End If
    End Sub
    Private Sub ButtonExit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExit.Click
        If MsgBox("您确定要退出【软件知识竞赛管理系统】吗?", vbYesNo) = vbYes Then
            MsgBox("感谢您的使用!")
            Me.Close()
        End If
    End Sub
    Private Sub ButtonSet_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSet.Click
        Frm_SystemSettings.Show()
        Me.Close()
    End Sub
End Class