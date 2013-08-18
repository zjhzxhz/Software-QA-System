Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Public Class Frm_Login
    Private CurrentPurpose As String = Nothing
    Private Sub Frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '开启监听线程
        BackGroundWorker.WorkerReportsProgress = True
        BackGroundWorker.WorkerSupportsCancellation = True
    End Sub
    Private Sub Frm_Login_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        '检测用户键盘按键(Enter)
        If e.KeyChar = Chr(13) Then
            ButtonOK_Click(sender, e)
        End If
    End Sub
    Private Sub TextStudentID_GotFocus(sender As Object, e As System.EventArgs) Handles TextStudentID.GotFocus
        If TextStudentID.Text = "请输入您的学号" Then
            TextStudentID.Clear()
        End If
        '设置文本框字体颜色
        TextStudentID.ForeColor = Color.Black
    End Sub
    Private Sub TextStudentID_LostFocus(sender As Object, e As System.EventArgs) Handles TextStudentID.LostFocus
        LabelUserName.Text = Nothing                                    '清空原用户名 
        If TextStudentID.Text = "请输入您的学号" Then
            TextStudentID.ForeColor = Color.FromArgb(64, 64, 64, 64)    '设置文本框字体颜色
            Exit Sub
        ElseIf TextStudentID.Text = Nothing Then
            TextStudentID.ForeColor = Color.FromArgb(64, 64, 64, 64)    '设置文本框字体颜色
            TextStudentID.Text = "请输入您的学号"                        '设置文本框显示内容
            Exit Sub
        Else
            '设置文本框字体颜色
            TextStudentID.ForeColor = Color.FromArgb(64, 64, 64, 64)
            '检查数据库文件是否存在
            If Dir(DataBaseLocation) = Nothing Then
                MsgBox("未找到数据库文件,请与管理员联系!" & Chr(13) & "对您造成不便我们深表歉意!" & Chr(13) & Chr(13) & "[Exception] Database Not Found!")
                Exit Sub
            End If
            '从数据库验证用户信息
            Try
                Dim Connection = New OleDbConnection(DatabaseConnectionString)
                Connection.Open()
                Dim SQL As String = "Select * From [Student] Where [StudentID]=" & TextStudentID.Text
                Dim Command = New OleDbCommand(SQL, Connection)
                Dim Reader As OleDbDataReader = Command.ExecuteReader
                Dim Counter As UInteger = 0
                While Reader.Read
                    Counter += 1
                    If TextStudentID.Text = Trim(Reader("StudentID")) Then
                        LabelUserName.Text = Trim(Reader("StudentName"))   '从数据库读取用户姓名
                        Exit While
                    End If
                End While
                Command.Dispose()
                Connection.Close()
            Catch ex As Exception
                MsgBox("An error occured while getting StudentName in the database!" & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub TextStudentID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextStudentID.KeyPress
        '只允许数字和退格键入
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Chr(Keys.Back) Then
            Return
        End If
        e.Handled = True
    End Sub
    Private Sub TextPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextPassword.GotFocus
        If TextPassword.Text = "请输入您的密码" Then
            TextPassword.Clear()
            TextPassword.PasswordChar = "●"
        End If
        '设置文本框字体颜色
        TextPassword.ForeColor = Color.Black
    End Sub
    Private Sub TextPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextPassword.LostFocus
        '设置文本框字体颜色
        TextPassword.ForeColor = Color.FromArgb(64, 64, 64, 64)
        '显示文本框提示内容
        If TextPassword.Text = Nothing Then
            TextPassword.PasswordChar = Nothing
            TextPassword.Text = "请输入您的密码"
        End If
    End Sub
    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        '检测是否有未填项和输入正确性
        If TextStudentID.Text = Nothing Or TextStudentID.Text = "请输入您的学号" Then
            MsgBox("请输入您的学号!")
            Exit Sub
        ElseIf IsNumeric(TextStudentID.Text) = False Then
            MsgBox("请检查学号输入的合法性!")
            Exit Sub
        ElseIf TextPassword.Text = Nothing Or TextStudentID.Text = "请输入您的密码" Then
            MsgBox("请输入您的密码!")
            Exit Sub
        End If
        '检测服务器可用状态
        If (StandbyServerIpAddress = "Disabled" Or StandbyServerPort = "Disabled") And (MainServerIpAddress = "Disabled" Or MainServerPort = "Disabled") Then
            MsgBox("无法登录到服务器, 可能是由于管理员未配置可用的服务器." & Chr(13) & Chr(13) & "[Expection] No Server is available to handle this requrest!")
        End If
        '连接到数据库校验用户信息正确性
        Dim Counter As UInteger = 0
        Try
            '检查数据库文件是否存在
            If Dir(DataBaseLocation) = Nothing Then
                MsgBox("未找到数据库文件,请与管理员联系!" & Chr(13) & "对您造成不便我们深表歉意!" & Chr(13) & Chr(13) & "[Exception] Database Not Found!")
                Exit Sub
            End If
            '从数据库验证用户信息
            Dim Connection = New OleDbConnection(DatabaseConnectionString)
            Connection.Open()
            Dim SQL As String = "Select * From [Student] Where [StudentID]=" & TextStudentID.Text
            Dim Command = New OleDbCommand(SQL, Connection)
            Dim Reader As OleDbDataReader = Command.ExecuteReader
            While Reader.Read
                Counter = Counter + 1   '用于判断数据库中是否存在该学号
                If TextStudentID.Text = Trim(Reader("StudentID")) And TextPassword.Text = Trim(Reader(("Password"))) Then
                    '读取用户信息
                    StudentID = Trim(Reader("StudentID"))
                    StudentName = Trim(Reader("StudentName"))
                    Group = Trim(Reader("Group"))
                Else
                    MsgBox("您输入的学号或者密码不正确!")
                    Exit Sub
                End If
            End While
            Command.Dispose()
            Connection.Close()
        Catch ex As Exception
            MsgBox("An error occured while reading data in the database." & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
        '若未在数据库中发现用户信息
        If Counter = 0 Then
            '检测备用服务器是否可用
            If StandbyServerIpAddress = "Disabled" Or StandbyServerPort = "Disabled" Then
                MsgBox("您输入的学号或者密码不正确!" & Chr(13) & Chr(13) & "[提示] 若要进行远程验证, 请检查您是否启用了备用服务器.", , "软件基础知识问答系统")
                Exit Sub
            Else
                '连接到备用服务器验证用户有效性
                CurrentPurpose = "Validate"
                ConnectToServer(CurrentPurpose)
            End If
        Else
            '登录至服务器
            CurrentPurpose = "Login"
            ConnectToServer(CurrentPurpose)
        End If
    End Sub
    Private Sub ButtonExit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExit.Click
        If MsgBox("您确定要退出【软件知识竞赛问答系统】吗?", vbYesNo) = vbYes Then
            MsgBox("感谢您的使用!")
            End
        End If
    End Sub
    Private Sub ButtonSet_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSet.Click
        Frm_SystemSettings.Show()
        Me.Close()
    End Sub
    Private Sub ButtonInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInformation.Click
        Frm_About.ShowDialog()
    End Sub
    Private Sub ButtonHelp_Click(sender As System.Object, e As System.EventArgs) Handles ButtonHelp.Click
        If Dir(System.Windows.Forms.Application.StartupPath & "\HelpAndSupport.Chm") <> Nothing Then
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath & "\HelpAndSupport.Chm")
        Else
            MsgBox("未找到帮助文件!" & Chr(13) & "对此给您带来的不便我们深表歉意!" & Chr(13) & Chr(13) & "[Exception] HelpAndSupport.Chm Not Exists!")
        End If
    End Sub
    Private Sub ConnectToServer(ByVal Purpose As String)
        Static Dim TryTimes As UShort = 0               '连接尝试计数器
        Static Dim LastPurpose As String = Nothing      '记录上次连接请求
        '判断连接请求是否改变
        If Purpose <> LastPurpose Then
            TryTimes = 0
        End If
        '判断是否超过最大尝试次数
        If TryTimes > 3 Then
            '禁用超时计时器
            Timer.Stop()
            MsgBox("Failed to login to Server!" & Chr(13) & "Please check your network and IP configuration.")
            LabelCondition.Text = "未能成功与服务器建立连接."
            '启用窗体控件
            ButtonOK.Enabled = True
            TextStudentID.Enabled = True
            '重置TryTimes变量
            TryTimes = 0
        Else
            LastPurpose = Purpose       '记录当前连接请求
            If Purpose = "Login" Then
                '检测可用的服务器
                Dim isMainServerAvailable As Boolean = True
                Dim isStandbyServerAvailable As Boolean = True
                If MainServerIpAddress = "Disabled" Or MainServerPort = "Disabled" Then
                    isMainServerAvailable = False
                ElseIf StandbyServerIpAddress = "Disabled" Or StandbyServerPort = "Disabled" Then
                    isStandbyServerAvailable = False
                End If
                '设置请求连接的服务器
                If isMainServerAvailable = False Then               '若主服务器处于禁用状态
                    LabelCondition.Text = "正在连接备用服务器……"
                    ServerPoint = New IPEndPoint(IPAddress.Parse(StandbyServerIpAddress), StandbyServerPort)
                ElseIf isStandbyServerAvailable = False Then        '若备用服务器处于禁用状态
                    LabelCondition.Text = "正在连接主服务器……"
                    ServerPoint = New IPEndPoint(IPAddress.Parse(MainServerIpAddress), MainServerPort)
                Else 'If isMainServerAvailable And isStandbyServerAvailable Then
                    If TryTimes Mod 2 = 0 Then  '连接至主服务器
                        LabelCondition.Text = "正在连接主服务器……"
                        ServerPoint = New IPEndPoint(IPAddress.Parse(MainServerIpAddress), MainServerPort)
                    Else                        '连接至备用服务器
                        LabelCondition.Text = "正在连接备用服务器……"
                        ServerPoint = New IPEndPoint(IPAddress.Parse(StandbyServerIpAddress), StandbyServerPort)
                    End If
                End If
                '向服务器发送信息
                SendBuffer.StudentID = StudentID
                SendBuffer.StudentName = StudentName
                SendBuffer.Group = Group
            ElseIf Purpose = "Validate" Then
                LabelCondition.Text = "正在连接到服务器验证用户信息……"
                SendBuffer.StudentID = TextStudentID.Text
                SendBuffer.UserPassword = TextPassword.Text
                ServerPoint = New IPEndPoint(IPAddress.Parse(StandbyServerIpAddress), StandbyServerPort)
            End If
            '发送信息至服务器
            SendBuffer.Order = Purpose
            SocketCelint.SendTo(SerializeMessage(SendBuffer), ServerPoint)
            '开启监听线程
            If BackGroundWorker.IsBusy = False Then
                BackGroundWorker.RunWorkerAsync()
            End If
            TryTimes += 1       '连接尝试计数
            Timer.Start()       '开始连接计时
        End If
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ConnectToServer(CurrentPurpose)
    End Sub
    Private Sub BackGroundWorker_DoWork(ByVal Sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackGroundWorker.DoWork
        While True
            Try
                '接收信息
                SocketCelint.ReceiveFrom(ReceiveByte, 0, ReceiveByte.Length, SocketFlags.None, ServerPoint)
                '反序列化接收到的信息(由服务器)
                ReceiveBuffer = DeserializeMessage(ReceiveByte)
                Select Case ReceiveBuffer.Order
                    Case "WaitForStart"             '提示用户等待竞赛开始
                        BackGroundWorker.ReportProgress(0)
                    Case "LoginSuccessfully"        '提示用户成功登录
                        BackGroundWorker.ReportProgress(1)
                    Case "UserLogined"              '提示用户重复登录
                        BackGroundWorker.ReportProgress(2)
                    Case "ValidateSuccessfully"     '提示用户远程验证成功
                        BackGroundWorker.ReportProgress(3)
                    Case "ValidateFailed"           '提示用户远程验证失败
                        BackGroundWorker.ReportProgress(4)
                    Case "UpdateSuccessfully"       '提示用户与服务器重新建立连接(在Frm_Main窗体中)
                        BackGroundWorker.ReportProgress(5)
                End Select
            Catch ex As Exception
                '[Exception] An error occured while sending orders to Server
            End Try
        End While
    End Sub
    Private Sub BackGroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackGroundWorker.ProgressChanged
        Timer.Stop()                    '禁用连接超时计时器
        Select Case e.ProgressPercentage
            Case 0  'WaitForStart
                Frm_Waiting.Show()      '提示用户等待竞赛开始
                Me.Enabled = False      '禁用窗体所有控件
            Case 1  'LoginSuccessfully
                '判断用户是否处于等待状态
                If Frm_Waiting.IsHandleCreated Then
                    Frm_Waiting.CanClose = True
                    Frm_Waiting.Close()
                End If
                '更新竞赛剩余时间
                Frm_Main.SecondDown = ReceiveBuffer.TimeUsed
                '提示用户已验证成功
                LabelCondition.Text = "已连接到服务器……"
                MsgBox("欢迎你," & LabelUserName.Text & "," & Chr(13) & "欢迎参加软件基础知识竞赛!")
                Frm_Main.Show()
                Me.Close()
            Case 2  'UserLogined
                LabelCondition.Text = "服务器拒绝登陆!"
                MsgBox("该用户已登录或已完成答题!" & Chr(13) & "请勿重复登录!" & Chr(13) & Chr(13) & "软件基础知识问答系统即将关闭, 对此给您带来的不便我们深表歉意!")
                End
            Case 3  'ValidateSuccessfully
                '提示用户已验证成功
                LabelCondition.Text = "已完成用户身份有效性验证……"
                '显示用户姓名
                LabelUserName.Text = ReceiveBuffer.StudentName
                '读取用户信息
                StudentID = ReceiveBuffer.StudentID
                StudentName = ReceiveBuffer.StudentName
                Group = ReceiveBuffer.Group
                '登录至服务器
                CurrentPurpose = "Login"
                ConnectToServer(CurrentPurpose)
            Case 4  'ValidateFailed
                '提示用户已验证失败
                LabelCondition.Text = "远程验证用户身份有效性失败!"
                MsgBox("您输入的学号或者密码不正确!", , "软件基础知识问答系统")
            Case 5  'UpdateSuccessfully
                Frm_Main.TimerDown.Start()
                Frm_Main.ButtonOK.Enabled = True
            Case Else
        End Select
    End Sub
End Class