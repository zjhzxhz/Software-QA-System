Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Public Class Frm_Main
    Private Const PASSWORD_LENGTH As UShort = 8
    Private CurrentPurpose As String = Nothing
    Private isInformationRight(6) As Boolean    '用于存储信息输入正确性
    'Udp网络通信
    Private SocketCelint As New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp) '客户端Socket对象
    Private ServerPoint As IPEndPoint                           '服务器IP及端口号
    Private SendBuffer As New ClassLibrary.SocketMessage        '发送内容
    Private ReceiveBuffer As New ClassLibrary.SocketMessage     '接收内容
    Private ReceiveByte(10240) As Byte                          '接收字节数组
    Private Sub Frm_Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '从SchoolInformation.Xml文件中读取院系信息
        Dim XmlDocumentPath = Application.StartupPath & "\SchoolInformation.Xml"
        If Dir(XmlDocumentPath) = Nothing Then
            MsgBox("未能找到院系配置文件! 请在【控制面板】中完成院系设置后继续!" & Chr(13) & Chr(13) & "[Exception] SchoolInformation.Xml Not Exsits!")
            Frm_ControlPanel.Show()
            Me.Close()
        Else
            getSchoolName(XmlDocumentPath)
        End If
        '更新连接状态
        If Mode = "Local" Then      '若使用脱机模式报名
            LabelConnectCondition.ForeColor = Color.Green
            LabelConnectCondition.Text = "脱机模式"
        Else                        '若使用联机模式报名
            If StandbyServerIpAddress = "Disabled" Or StandbyServerPort = "Disabled" Then   '若备用服务器不可用
                MsgBox("您尚未启用备用服务器, 无法使用联机报名模式!")
                Mode = "Local"
                LabelConnectCondition.ForeColor = Color.Green
                LabelConnectCondition.Text = "脱机模式"
            Else
                LabelConnectCondition.ForeColor = Color.Orange
                LabelConnectCondition.Text = "Connecting ..."
                '检查与备用服务器的连接
                CurrentPurpose = "ConnectTest"
                ConnectToServer(CurrentPurpose)
                '开启监听线程
                BackgroundWorker.WorkerReportsProgress = True
                BackgroundWorker.WorkerSupportsCancellation = True
            End If
        End If
    End Sub
    Private Sub LabelConnectCondition_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LabelConnectCondition.Click
        If Mode = "Network" Then    '若使用联机模式报名
            If LabelConnectCondition.Text = "Disconnected" Then     '若未能与服务器建立连接
                LabelConnectCondition.ForeColor = Color.Orange
                LabelConnectCondition.Text = "Connecting ..."
                '检查与备用服务器的连接
                CurrentPurpose = "ConnectTest"
                ConnectToServer(CurrentPurpose)
            End If
        End If
    End Sub
    Private Sub TextStudentID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextStudentID.LostFocus
        If (Val(TextStudentID.Text).ToString).Length = 8 Or (Val(TextStudentID.Text).ToString).Length = 10 Then
            LabelStudentIdTip.ForeColor = Color.Green
            LabelStudentIdTip.Text = "输入正确"
            isInformationRight(0) = True
        Else
            LabelStudentIdTip.ForeColor = Color.Red
            LabelStudentIdTip.Text = "请输入正确的学号"
            isInformationRight(0) = False
        End If
    End Sub
    Private Sub TextStudentName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextStudentName.LostFocus
        If TextStudentName.Text <> Nothing Then
            LabelStudentNameTip.ForeColor = Color.Green
            LabelStudentNameTip.Text = "输入正确"
            isInformationRight(1) = True
        Else
            LabelStudentNameTip.ForeColor = Color.Red
            LabelStudentNameTip.Text = "请输入您的姓名"
            isInformationRight(1) = False
        End If
    End Sub
    Private Sub ComboGroup_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboGroup.LostFocus
        If ComboGroup.Text <> Nothing Then
            LabelGroupTip.ForeColor = Color.Green
            LabelGroupTip.Text = "正确"
            isInformationRight(2) = True
        Else
            LabelGroupTip.ForeColor = Color.Red
            LabelGroupTip.Text = "请选择您的参赛组别"
            isInformationRight(2) = False
        End If
    End Sub
    Private Sub ComboSchool_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboSchool.LostFocus
        If ComboSchool.Text <> Nothing Then
            LabelSchoolTip.ForeColor = Color.Green
            LabelSchoolTip.Text = "正确"
            isInformationRight(3) = True
        Else
            LabelSchoolTip.ForeColor = Color.Red
            LabelSchoolTip.Text = "请选择您的学院"
            isInformationRight(3) = False
        End If
    End Sub
    Private Sub ComboSchool_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboSchool.SelectedIndexChanged
        ComboGroup.Enabled = True
        '清空原有专业
        ComboProfession.Items.Clear()
        LabelProfessionTip.Text = Nothing
        isInformationRight(4) = False
        '软件学院和计算机学院只能参加专业组比赛
        If ComboSchool.Text = "软件学院" Or ComboSchool.Text = "计算机与信息学院" Then
            ComboGroup.Text = "专业组"
            ComboGroup.Enabled = False
            '显示提示信息
            LabelGroupTip.ForeColor = Color.Green
            LabelGroupTip.Text = "正确"
            isInformationRight(2) = True
        End If
        '从SchoolInformation.Xml读取专业信息
        getProfessionName(Application.StartupPath & "\SchoolInformation.Xml", ComboSchool.Text)
    End Sub
    Private Sub ComboProfession_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboProfession.LostFocus
        If ComboProfession.Text <> Nothing Then
            LabelProfessionTip.ForeColor = Color.Green
            LabelProfessionTip.Text = "正确"
            isInformationRight(4) = True
        Else
            LabelProfessionTip.ForeColor = Color.Red
            LabelProfessionTip.Text = "请选择您的专业"
            isInformationRight(4) = False
        End If
    End Sub
    Private Sub TextPhoneNumber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextPhoneNumber.LostFocus
        If (Val(TextPhoneNumber.Text).ToString).Length = 11 Then
            LabelPhoneTip.ForeColor = Color.Green
            LabelPhoneTip.Text = "输入正确"
            isInformationRight(5) = True
        Else
            LabelPhoneTip.ForeColor = Color.Red
            LabelPhoneTip.Text = "请输入正确的联系方式"
            isInformationRight(5) = False
        End If
    End Sub
    Private Sub ButtonSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubmit.Click
        '判断信息输入正确性
        For i As Integer = 0 To 5
            If isInformationRight(i) = False Then
                If i = 0 Then
                    MsgBox("请输入正确的学号!")
                    Exit Sub
                ElseIf i = 1 Then
                    MsgBox("请输入您的姓名!")
                    Exit Sub
                ElseIf i = 2 Then
                    MsgBox("请选择您的参赛组别!")
                    Exit Sub
                ElseIf i = 3 Then
                    MsgBox("请选择您的学院!")
                    Exit Sub
                ElseIf i = 4 Then
                    MsgBox("请选择您的专业!")
                    Exit Sub
                ElseIf i = 5 Then
                    MsgBox("请输入正确的联系方式!")
                    Exit Sub
                End If
            End If
        Next
        '确认信息无误
        If (MsgBox("您输入的信息是:" & Chr(13) & "    学号: " & TextStudentID.Text &
                                       Chr(13) & "    姓名: " & TextStudentName.Text &
                                       Chr(13) & "    组别: " & ComboGroup.Text &
                                       Chr(13) & "    学院: " & ComboSchool.Text &
                                       Chr(13) & "    专业: " & ComboProfession.Text &
                                       Chr(13) & "    联系方式: " & TextPhoneNumber.Text &
                                       Chr(13) & "确认提交吗?", vbYesNo)) = vbYes Then
            SubmitInformation()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub SubmitInformation()
        If Mode = "Local" Then          '若使用脱机模式报名
            '检查数据库文件是否存在
            If Dir(DatabaseLocation) = Nothing Then
                MsgBox("未找到数据库文件,请与管理员联系!" & Chr(13) & "对您造成不便我们深表歉意!" & Chr(13) & Chr(13) & "[Exception] Database Not Found!")
                Exit Sub
            End If
            Try
                '连接到数据库
                Dim Connection = New OleDbConnection(DatabaseConnectionString)
                Connection.Open()
                '在本地数据库中查找用户信息
                Dim SQL As String = "Select * From [Student] Where [StudentID]=" & TextStudentID.Text
                Dim Command = New OleDbCommand(SQL, Connection)
                Dim Reader As OleDbDataReader = Command.ExecuteReader
                While Reader.Read
                    If TextStudentID.Text = Trim(Reader("StudentID")) Then
                        MsgBox("该用户已报名, 请勿重复报名!" & Chr(13) & Chr(13) & "[Exception] User already exsits!")
                        ClearAll()
                        '释放数据库连接
                        Command.Dispose()
                        Connection.Close()
                        Exit Sub
                    End If
                End While
                Command.Dispose()
                '在本地数据库中记录用户信息
                Dim UserPassword As String = getRandomString(PASSWORD_LENGTH)
                SQL = "Insert into [Student] values (" & TextStudentID.Text & ", '" & TextStudentName.Text & "', '" & UserPassword & "', '" & ComboGroup.Text & "', '" & ComboSchool.Text & "', '" & ComboProfession.Text & "', '" & TextPhoneNumber.Text & "')"
                Command = New OleDbCommand(SQL, Connection)
                Command.ExecuteNonQuery()
                Connection.Close()
                '通知用户已完成报名
                MsgBox(TextStudentName.Text & "同学 ,恭喜您!" & Chr(13) & "您已成功报名参加软件知识竞赛!")
                ClearAll()
            Catch ex As Exception
                MsgBox("An error occured whiling writing data in the database!" & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
            End Try
        Else 'If Mode = "Network" Then  '若使用联机模式报名
            If StandbyServerIpAddress = "Disabled" Or StandbyServerPort = "Disabled" Then   '若备用服务器不可用
                MsgBox("您尚未启用备用服务器, 无法使用联机报名模式!")
                Mode = "Local"
                LabelConnectCondition.ForeColor = Color.Green
                LabelConnectCondition.Text = "脱机模式"
            Else
                CurrentPurpose = "Register"
                ConnectToServer(CurrentPurpose)
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
    Private Sub MenuItemControlPanel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemControlPanel.Click
        If isLogined Then   '若用户已登录
            Frm_ControlPanel.Show()
            Me.Close()
        Else                '若用户未登录
            Frm_Login.ComboDomain.Text = "控制面板"
            Frm_Login.ComboDomain.Enabled = False
            Frm_Login.Show()
            Me.Close()
        End If
    End Sub
    Private Sub MenuItemExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemExit.Click
        If MsgBox("您确定要退出【软件知识竞赛报名系统】吗?", vbYesNo) = vbYes Then
            End
        End If
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
    Private Sub ConnectToServer(ByVal Purpose As String)
        Static Dim TryTimes As UShort = 0      '连接尝试计数器
        '检查是否超过尝试上限
        If TryTimes >= 3 Then
            Timer.Stop()
            '提示用户登录失败
            MsgBox("Failed to connect to Server!" & Chr(13) & "Please check your network and IP configuration.")
            LabelConnectCondition.ForeColor = Color.Red
            LabelConnectCondition.Text = "Disconnected"
            '初始化TryTimes变量
            TryTimes = 0
            Exit Sub
        End If
        ServerPoint = New IPEndPoint(IPAddress.Parse(StandbyServerIpAddress), StandbyServerPort)
        SendBuffer.Order = Purpose
        If Purpose = "ConnectTest" Then     '检查与备用服务器的连接
            'Do Nothing
        ElseIf Purpose = "Register" Then    '向备用服务器发送报名信息
            SendBuffer.StudentID = TextStudentID.Text
            SendBuffer.StudentName = TextStudentName.Text
            SendBuffer.UserPassword = getRandomString(PASSWORD_LENGTH)
            SendBuffer.Group = ComboGroup.Text
            SendBuffer.School = ComboSchool.Text
            SendBuffer.Profession = ComboProfession.Text
            SendBuffer.PhoneNumber = TextPhoneNumber.Text
        End If
        '发送信息至服务器
        SocketCelint.SendTo(SerializeMessage(SendBuffer), ServerPoint)
        '开启监听线程
        If BackgroundWorker.IsBusy = False Then
            BackgroundWorker.RunWorkerAsync()
        End If
        TryTimes += 1
        Timer.Start()
    End Sub
    Private Sub ClearAll()
        '清空用户所有信息
        LabelStudentIdTip.Text = Nothing
        TextStudentID.Text = Nothing
        LabelStudentNameTip.Text = Nothing
        TextStudentName.Text = Nothing
        LabelGroupTip.Text = Nothing
        ComboGroup.Text = Nothing
        LabelSchoolTip.Text = Nothing
        ComboSchool.Text = Nothing
        LabelProfessionTip.Text = Nothing
        ComboProfession.Text = Nothing
        LabelPhoneTip.Text = Nothing
        TextPhoneNumber.Text = Nothing
    End Sub
    Private Sub getSchoolName(ByVal XmlDocumentPath As String)
        Try
            Dim XmlReader As New Xml.XmlTextReader(XmlDocumentPath)
            While XmlReader.Read
                If (XmlReader.NodeType = Xml.XmlNodeType.Element) Then
                    Select Case (XmlReader.LocalName)
                        Case "SchoolName"
                            ComboSchool.Items.Add(XmlReader.GetAttribute(0))
                    End Select
                End If
            End While
        Catch ex As Exception
            MsgBox("An error occured while getting SchoolName in SchoolInformation.Xml" & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
    Private Sub getProfessionName(ByVal XmlDocumentPath As String, ByVal SchoolName As String)
        Try
            Dim XmlReader As New Xml.XmlTextReader(XmlDocumentPath)
            While XmlReader.Read
                If (XmlReader.NodeType = Xml.XmlNodeType.Element) Then
                    Select Case (XmlReader.LocalName)
                        Case "SchoolName"
                            If XmlReader.GetAttribute(0) = SchoolName Then
                                Dim LastLineNumber As UInteger = 0
                                While XmlReader.ReadToFollowing("Profession")
                                    If XmlReader.LineNumber = LastLineNumber + 1 Or LastLineNumber = 0 Then
                                        ComboProfession.Items.Add(XmlReader.ReadString())
                                        LastLineNumber = XmlReader.LineNumber
                                    Else
                                        Exit While
                                    End If
                                End While
                            End If
                        Case Else
                    End Select
                End If
            End While
        Catch ex As Exception
            MsgBox("An error occured while getting ProfessionName in SchoolInformation.Xml" & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ConnectToServer(CurrentPurpose)
    End Sub
    Private Sub BackgroundWorker_DoWork(ByVal Sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        While True
            Try
                '接收信息
                SocketCelint.ReceiveFrom(ReceiveByte, 0, ReceiveByte.Length, SocketFlags.None, ServerPoint)
                '反序列化接收到的信息(由服务器)
                ReceiveBuffer = DeserializeMessage(ReceiveByte)
                Select Case ReceiveBuffer.Order
                    Case "Connected"                '提示用户与服务器成功建立连接
                        BackgroundWorker.ReportProgress(0)
                    Case "RegisterSuccessfully"
                        BackgroundWorker.ReportProgress(1)
                    Case "UserRegistered"
                        BackgroundWorker.ReportProgress(2)
                    Case Else
                End Select
            Catch ex As Exception
                '[Exception] An error occured while sending orders to Server
            End Try
        End While
    End Sub
    Private Sub BackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged
        Select Case e.ProgressPercentage
            Case 0      '提示用户已与服务器建立连接
                Timer.Stop()    '禁用连接超时计时器
                LabelConnectCondition.ForeColor = Color.Green
                LabelConnectCondition.Text = "Connected"
            Case 1      '提示用户已完成报名
                Timer.Stop()
                MsgBox(TextStudentName.Text & "同学 ,恭喜您!" & Chr(13) & "您已成功报名参加软件知识竞赛!" & Chr(13) & "您的密码是: " & ReceiveBuffer.UserPassword & Chr(13) & "您已经可以直接在计算机上登录了.")
                ClearAll()
            Case 2      '提示用户请勿重复报名
                Timer.Stop()
                MsgBox("该用户已报名, 请勿重复报名!" & Chr(13) & Chr(13) & "[Exception] User already exsits!")
                ClearAll()
            Case Else
        End Select
    End Sub
End Class