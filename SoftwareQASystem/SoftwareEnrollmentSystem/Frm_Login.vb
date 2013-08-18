Public Class Frm_Login
    Private TryTimes As UShort = 0     '最大尝试次数计数
    Private Sub Frm_Login_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        '如果用户按下Enter键
        If e.KeyChar = Chr(13) Then
            ButtonLogin_Click(sender, e)
        End If
    End Sub
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        '检查是否有未填写信息
        If ComboDomain.Text =Nothing Then
            MsgBox("请选择登录域!")
            Exit Sub
        ElseIf TextUserName.Text =Nothing Then
            MsgBox("请填写您的用户名!")
            Exit Sub
        ElseIf TextPassword.Text =Nothing Then
            MsgBox("请填写您的密码!")
            Exit Sub
        End If
        '验证用户身份
        If TextUserName.Text = AdministratorUserName And TextPassword.Text = AdministratorPassWord Then
            isLogined = True        '记录用户登录状态
            If ComboDomain.Text = "管理中心" Then
                MsgBox("欢迎你, " & TextUserName.Text & Chr(13) & "正在为您启动软件知识竞赛报名系统[管理中心]…")
                Frm_ManagementCenter.Show()
                Me.Close()
            Else 'If ComboDomain.Text = "控制面板" Then
                MsgBox("欢迎你, " & TextUserName.Text & Chr(13) & "正在为您启动软件知识竞赛报名系统[控制面板]…")
                Frm_ControlPanel.Show()
                Me.Close()
            End If
        Else
            MsgBox("您的用户名或密码不正确!")
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
    Private Sub ButtonBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonBack.Click
        If MsgBox("您确定要返回【软件知识竞赛报名系统】吗?", vbYesNo) = vbYes Then
            Frm_Main.Show()
            Me.Close()
        End If
    End Sub
End Class