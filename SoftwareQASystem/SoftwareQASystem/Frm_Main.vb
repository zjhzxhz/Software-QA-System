Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Public Class Frm_Main
    Private CurrentPurpose As String = Nothing
    '问答系统全局变量
    Private isSingle As Boolean = False                         '记录试题 单选/多选 属性
    Private QuestionIdAnswering As UShort = 0                   '记录用户所答试题题号
    Private Score As UShort = 0                                 '记录用户得分
    Private isFinished As Boolean = False                       '记录用户是否已完成试题作答
    Private SecondUp As UInteger = 0                            '存储用户使用时间
    Public SecondDown As UInteger = 0                           '存储用户剩余时间
    Private QuestionOrder(TotalQuestion) As Integer             '存储试题顺序
    Private RightAnswer(TotalQuestion) As String                '存储正确答案
    Private YourAnswer(TotalQuestion) As String                 '存储参赛者答案
    Private Sub Frm_Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '重新与服务器建立连接
        BackgroundWorker.WorkerReportsProgress = True
        BackgroundWorker.WorkerSupportsCancellation = True
        SendBuffer.Order = "Update"
        SocketCelint.SendTo(SerializeMessage(SendBuffer), ServerPoint)
        If BackgroundWorker.IsBusy = False Then
            BackgroundWorker.RunWorkerAsync()
        End If
        '记录试题顺序至QuestionOrder数组
        Frm_Login.LabelCondition.Text = "正在生成试题信息……"
        getRandomOrder(1, TotalQuestion)
        '加载答案至RightAnswer数组
        If Group = "专业组" Then
            getRightAnswer("ProfessionalGroup", TotalQuestion)
        Else
            getRightAnswer("Non-ProfessionalGroup", TotalQuestion)
        End If
        '更新用户信息
        LabelStudentID.Text = "学号: " + StudentID.ToString
        LabelStudentName.Text = "姓名: " + StudentName
        '显示参赛须知
        Frm_Login.LabelCondition.Text = "正在启动问答系统……"
        LabelTitleQuestion.Text = "参赛须知:"
        LabelQuestion.Size = New System.Drawing.Size(636, 200)  '调整显示大小
        LabelQuestion.Text = Chr(13) & StudentName & ", 感谢您参加由合肥工业大学软件学院组织的软件基础知识竞赛!" & Chr(13) &
                             Chr(13) & "请在参赛前仔细核对您的个人信息, 以免给您的操作造成不必要的麻烦." & Chr(13) &
                             Chr(13) & "请勿在竞赛中使用手机等通信设备或通过计算机访问Internet." & Chr(13) &
                             Chr(13) & "竞赛将在您单击确定后开始."
        '将答题控件设为不可见
        LabelTitleAnswer.Visible = False
        GroupBox.Visible = False
        ButtonPrevious.Visible = False
        ButtonNext.Visible = False
        TextJumpTo.Visible = False
        '软件知识问答系统启动完成
        Frm_Login.LabelCondition.Text = "完成!"
    End Sub
    Private Sub Frm_Main_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If isFinished = False Then
            e.Cancel = True
            MsgBox("请先完成试题的作答再尝试退出系统" & Chr(13) & "对此给您造成的不便我们深表歉意!")
        Else
            CurrentPurpose = "Logout"
            ConnectToServer(CurrentPurpose)
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
            Timer.Stop()        '禁用超时计时器
            TryTimes = 0        '重置TryTimes变量
            '[Exception] Unable to connect to Server!
        Else
            LastPurpose = Purpose       '记录当前连接请求
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
                ServerPoint = New IPEndPoint(IPAddress.Parse(StandbyServerIpAddress), StandbyServerPort)
            ElseIf isStandbyServerAvailable = False Then        '若备用服务器处于禁用状态
                ServerPoint = New IPEndPoint(IPAddress.Parse(MainServerIpAddress), MainServerPort)
            Else 'If isMainServerAvailable And isStandbyServerAvailable Then
                If TryTimes Mod 2 = 0 Then  '连接至主服务器
                    ServerPoint = New IPEndPoint(IPAddress.Parse(MainServerIpAddress), MainServerPort)
                Else                        '连接至备用服务器
                    ServerPoint = New IPEndPoint(IPAddress.Parse(StandbyServerIpAddress), StandbyServerPort)
                End If
            End If
            '向服务器发送信息
            If Purpose = "Submit" Then
                SendBuffer.StudentName = StudentName
                SendBuffer.Group = Group
                SendBuffer.Score = Score                    '用户得分
                SendBuffer.TimeUsed = LabelTimeUsed.Text    '用户答题所用时间
            End If
            '发送信息至服务器
            SendBuffer.Order = Purpose
            SendBuffer.StudentID = StudentID
            SocketCelint.SendTo(SerializeMessage(SendBuffer), ServerPoint)
            TryTimes += 1       '连接尝试计数
            Timer.Start()
            '重新与服务器建立连接
            SendBuffer.Order = "Update"
            SocketCelint.SendTo(SerializeMessage(SendBuffer), ServerPoint)
        End If
    End Sub
    Private Sub Frm_Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '检测用户键盘按键(Left, Right, and Enter)
        If e.KeyCode = Keys.Enter Then      'JumpTo功能
            '检查输入内容是否合法
            If TextJumpTo.Text = Nothing Or TextJumpTo.Text = "跳转至..." Then
                Exit Sub
            ElseIf IsNumeric(TextJumpTo.Text) = False Then
                MsgBox("请检查输入题号是否合法!")
                Exit Sub
            End If
            '检查输入题号是否越界
            If (Val(TextJumpTo.Text) <= 0) Or (Val(TextJumpTo.Text) > TotalQuestion) Then
                MsgBox("您输入的题号超过了索引范围!" & Chr(13) & Chr(13) & "[Exception] Index out of range.")
                Exit Sub
            End If
            '保存用户本题所选答案
            SaveUserChoice(isSingle, QuestionIdAnswering)
            '跳转到指定试题
            QuestionIdAnswering = Val(TextJumpTo.Text) - 1
            LabelQuestionID.Text = "答题计数: " & Str(QuestionIdAnswering + 1) & "/" & Str(TotalQuestion)
            '跳转到指定试题
            JumpToQuestionID(QuestionIdAnswering)
        ElseIf e.KeyCode = Keys.Left Then   '敲击左方向键可以跳转至上一题
            ButtonPrevious_Click(sender, e)
        ElseIf e.KeyCode = Keys.Right Then
            ButtonNext_Click(sender, e)     '敲击右方向键可以跳转至下一题
        End If
    End Sub
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        If isFinished = False Then  '当答题开始前单击
            '设置控件Visable和Enabled属性
            ButtonOK.Visible = False
            ButtonPrevious.Visible = True
            ButtonPrevious.Enabled = False      '对于第一题禁用<上一题>按钮
            ButtonNext.Visible = True
            ButtonNext.Enabled = True           '对于第一题启用<下一题>按钮
            TextJumpTo.Visible = True
            LabelTitleAnswer.Visible = True
            GroupBox.Visible = True
            LabelQuestion.Size = New System.Drawing.Size(636, 115)
            '启用KeyPress监听
            Me.KeyPreview = True
            '从数据库读取第一题试题
            If Group = "专业组" Then
                getNextQuestion("ProfessionalGroup", QuestionOrder(0))
            Else
                getNextQuestion("Non-ProfessionalGroup", QuestionOrder(0))
            End If
            '更新答题计数器显示
            LabelQuestionID.Text = "答题计数: 1 /" & Str(TotalQuestion)
            '开始计时
            TimerUp.Start()
        Else                        '当答题结束后单击
            Me.Close()
        End If
    End Sub
    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        '保存用户所选答案
        SaveUserChoice(isSingle, QuestionIdAnswering)
		'更新答题计数器
        ButtonPrevious.Enabled = True
        QuestionIdAnswering -= 1
        LabelQuestionID.Text = "答题计数: " & Str(QuestionIdAnswering + 1) & "/" & Str(TotalQuestion)
        '设置控件属性
        If QuestionIdAnswering = 0 Then
            ButtonPrevious.Enabled = False
        ElseIf QuestionIdAnswering = TotalQuestion - 2 Then
            ButtonNext.Text = "下一题 >>"
        End If
        '从数据库读取上一题试题
        If Group = "专业组" Then
            getNextQuestion("ProfessionalGroup", QuestionOrder(QuestionIdAnswering))
        Else
            getNextQuestion("Non-ProfessionalGroup", QuestionOrder(QuestionIdAnswering))
        End If
        '读取用户所选答案
        getUserChoice(isSingle, QuestionOrder(QuestionIdAnswering) - 1)
    End Sub
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        '保存用户所选答案
        SaveUserChoice(isSingle, QuestionIdAnswering)
        '判断用户是否已完成该试题作答
        If YourAnswer(QuestionOrder(QuestionIdAnswering) - 1) = Nothing Then
            If MsgBox("[提示] 您未选择本题的答案, 请问要跳过吗?", vbYesNo) = vbNo Then
                Exit Sub
            End If
        End If
        '设置控件Enabled属性
        ButtonPrevious.Enabled = True
        '更新答题计数器显示
        QuestionIdAnswering += 1
        LabelQuestionID.Text = "答题计数: " & Str(QuestionIdAnswering + 1) & "/" & Str(TotalQuestion)
        '当用户完成答题时
        If QuestionIdAnswering = TotalQuestion - 1 Then
            ButtonNext.Text = "完成答题"
        ElseIf QuestionIdAnswering = TotalQuestion Then
            '更新答题计数器显示(修正Bug)
            QuestionIdAnswering = TotalQuestion - 1
            LabelQuestionID.Text = "答题计数: " & Str(QuestionIdAnswering + 1) & "/" & Str(TotalQuestion)
            Dim QuestionUnanswered As New ArrayList
            '扫描是否还有未作答的试题
            For i As Integer = 0 To TotalQuestion - 1
                If YourAnswer(QuestionOrder(i) - 1) = Nothing Then
                    QuestionUnanswered.Add(i + 1)   '添加未作答试题序号
                End If
            Next
            '提示用户确认提交
            If QuestionUnanswered.Count = 0 Then        '用户不存在未作答试题
                If MsgBox("您已经完成所有问题的作答, 请问您确认要提交吗?", vbYesNo) = vbYes Then
                    If MsgBox("请您再次确认", vbYesNo) = vbYes Then
                        ProcessFinish() '准备提交结果至服务器
                    End If
                End If
            Else                                        '用户存在未作答试题
                Dim StringQuestionUnanswered As String = Nothing
                If QuestionUnanswered.Count = 1 Then
                    StringQuestionUnanswered = QuestionUnanswered(0)
                Else
                    For i As Integer = 0 To QuestionUnanswered.Count - 2
                        StringQuestionUnanswered = StringQuestionUnanswered + Str(QuestionUnanswered(i)) + ", "
                    Next
                    StringQuestionUnanswered = StringQuestionUnanswered + "和 " + Str(QuestionUnanswered(QuestionUnanswered.Count - 1))
                End If
                If MsgBox("您还有题号为 " & StringQuestionUnanswered & " 的试题未完成作答, 确认要继续提交吗?" & Chr(13) & "我们不建议您这么做.", vbYesNo) = vbYes Then
                    If MsgBox("请您再次确认", vbYesNo) = vbYes Then
                        ProcessFinish() '准备提交结果至服务器
                    End If
                End If
            End If
            Exit Sub
        End If
        '从数据库读取下一题试题
        If Group = "专业组" Then
            getNextQuestion("ProfessionalGroup", QuestionOrder(QuestionIdAnswering))
        Else
            getNextQuestion("Non-ProfessionalGroup", QuestionOrder(QuestionIdAnswering))
        End If
        '读取用户所选答案
        getUserChoice(isSingle, QuestionOrder(QuestionIdAnswering) - 1)
    End Sub
    Private Sub TextJumpTo_GotFocus(sender As Object, e As EventArgs) Handles TextJumpTo.GotFocus
        TextJumpTo.Clear()
    End Sub
    Private Sub TextJumpTo_LostFocus(sender As Object, e As EventArgs) Handles TextJumpTo.LostFocus
        TextJumpTo.Text = "跳转至..."
    End Sub
    Private Sub MenuItemSystemSettings_Click(sender As Object, e As EventArgs) Handles MenuItemSystemSettings.Click
        If isFinished = False Then
            MsgBox("在进行系统设置之前, 请先完成试题的作答!")
        Else
            Frm_SystemSettings.ShowDialog()
        End If
    End Sub
    Private Sub ButtonExit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExit.Click
        If MsgBox("您确定要退出【软件基础知识问答系统】吗?", vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItemExitSystem_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemExitSystem.Click
        ButtonExit_Click(sender, e)
    End Sub
    Private Sub ButtonInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInformation.Click
        Frm_About.ShowDialog()
    End Sub
    Private Sub MenuItemAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemAbout.Click
        ButtonInformation_Click(sender, e)
    End Sub
    Private Sub ButtonHelp_Click(sender As System.Object, e As System.EventArgs) Handles ButtonHelp.Click
        If Dir(System.Windows.Forms.Application.StartupPath & "\HelpAndSupport.Chm") <> Nothing Then
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath & "\HelpAndSupport.Chm")
        Else
            MsgBox("未找到帮助文件!" & Chr(13) & "对此给您带来的不便我们深表歉意!" & Chr(13) & Chr(13) & "[Exception] HelpAndSupport.Chm Not Exists!")
        End If
    End Sub
    Private Sub MenuItemHelp_Click(sender As Object, e As EventArgs) Handles MenuItemHelp.Click
        ButtonHelp_Click(sender, e)
    End Sub
    Private Sub JumpToQuestionID(ByVal QuestionID As UShort)
        '初始化控件属性
        ButtonPrevious.Enabled = True
        ButtonNext.Text = "下一题 >>"
        '对特殊情况设置控件属性
        If QuestionID = 0 Then
            ButtonPrevious.Enabled = False
        ElseIf QuestionID = TotalQuestion - 1 Then
            ButtonNext.Text = "完成答题"
        End If
        '从数据库读取试题
        If Group = "专业组" Then
            getNextQuestion("ProfessionalGroup", QuestionOrder(QuestionID))
        Else
            getNextQuestion("Non-ProfessionalGroup", QuestionOrder(QuestionID))
        End If
        '读取用户所选答案
        getUserChoice(isSingle, QuestionOrder(QuestionID) - 1)
        '恢复控件显示
        TextJumpTo.Clear()
    End Sub
    Private Sub getUserChoice(ByVal isSingle As Boolean, ByVal QuestionID As Integer)
        '初始化所有选项为未选中状态
        RadioButtonA.Checked = False
        RadioButtonB.Checked = False
        RadioButtonC.Checked = False
        RadioButtonD.Checked = False
        CheckBoxA.Checked = False
        CheckBoxB.Checked = False
        CheckBoxC.Checked = False
        CheckBoxD.Checked = False
        '读取用户选项
        If isSingle = True Then
            '读取该题答案(单选)
            If YourAnswer(QuestionID) = "A" Then
                RadioButtonA.Checked = True
            ElseIf YourAnswer(QuestionID) = "B" Then
                RadioButtonB.Checked = True
            ElseIf YourAnswer(QuestionID) = "C" Then
                RadioButtonC.Checked = True
            ElseIf YourAnswer(QuestionID) = "D" Then
                RadioButtonD.Checked = True
            End If
        Else
            '读取该题答案(多选)
            If InStr(YourAnswer(QuestionID), "A") <> 0 Then
                CheckBoxA.Checked = True
            End If
            If InStr(YourAnswer(QuestionID), "B") <> 0 Then
                CheckBoxB.Checked = True
            End If
            If InStr(YourAnswer(QuestionID), "C") <> 0 Then
                CheckBoxC.Checked = True
            End If
            If InStr(YourAnswer(QuestionID), "D") <> 0 Then
                CheckBoxD.Checked = True
            End If
        End If
    End Sub
    Private Sub SaveUserChoice(ByVal isSingle As Boolean, ByVal QuestionID As Integer)
        '重置用户答案
        YourAnswer(QuestionOrder(QuestionID) - 1) = Nothing
        '保存用户答案
        If isSingle Then
            '根据RadioButton选中状态 判断用户答案
            If RadioButtonA.Checked = True Then
                YourAnswer(QuestionOrder(QuestionID) - 1) = "A"
            ElseIf RadioButtonB.Checked = True Then
                YourAnswer(QuestionOrder(QuestionID) - 1) = "B"
            ElseIf RadioButtonC.Checked = True Then
                YourAnswer(QuestionOrder(QuestionID) - 1) = "C"
            ElseIf RadioButtonD.Checked = True Then
                YourAnswer(QuestionOrder(QuestionID) - 1) = "D"
            End If
        Else
            '根据CheckBox选中状态 判断用户答案
            If CheckBoxA.Checked = True Then
                YourAnswer(QuestionOrder(QuestionID) - 1) = YourAnswer(QuestionOrder(QuestionID) - 1) + "A"
            End If
            If CheckBoxB.Checked = True Then
                YourAnswer(QuestionOrder(QuestionID) - 1) = YourAnswer(QuestionOrder(QuestionID) - 1) + "B"
            End If
            If CheckBoxC.Checked = True Then
                YourAnswer(QuestionOrder(QuestionID) - 1) = YourAnswer(QuestionOrder(QuestionID) - 1) + "C"
            End If
            If CheckBoxD.Checked = True Then
                YourAnswer(QuestionOrder(QuestionID) - 1) = YourAnswer(QuestionOrder(QuestionID) - 1) + "D"
            End If
        End If
    End Sub
    Private Sub getNextQuestion(ByVal TableName As String, ByVal QuestionID As Integer)
        Try
            '检查数据库文件是否存在
            If Dir(DataBaseLocation) = Nothing Then
                MsgBox("未找到数据库文件,请与管理员联系!" & Chr(13) & "对您造成不便我们深表歉意!" & Chr(13) & Chr(13) & "[Exception] Database Not Found!")
                Exit Sub
            End If
            '从数据库获取试题信息
            Dim Connection = New OleDbConnection(DatabaseConnectionString)
            Connection.Open()
            Dim SQL As String = "Select * From [" & TableName & "] Where [QuestionID]=" & QuestionID
            Dim cmd = New OleDbCommand(SQL, Connection)
            Dim Reader As OleDbDataReader = cmd.ExecuteReader
            While Reader.Read
                LabelQuestion.Text = Reader("Question")
                If (Trim(Reader("RightAnswer")).Length = 1) Then    '若试题只有一个正确答案
                    isSingle = True
                    DisableControls(isSingle)
                    LabelTitleQuestion.Text = "Question(单选)"
                    RadioButtonA.Text = Reader("OptionA")
                    RadioButtonB.Text = Reader("OptionB")
                    RadioButtonC.Text = Reader("OptionC")
                    RadioButtonD.Text = Reader("OptionD")
                Else                                                '若试题有多个正确答案
                    isSingle = False
                    DisableControls(isSingle)
                    LabelTitleQuestion.Text = "Question(多选)"
                    CheckBoxA.Text = Reader("OptionA")
                    CheckBoxB.Text = Reader("OptionB")
                    CheckBoxC.Text = Reader("OptionC")
                    CheckBoxD.Text = Reader("OptionD")
                End If
            End While
            cmd.Dispose()
            Connection.Close()
        Catch ex As Exception
            MsgBox("An error occured while getting the next question." & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
    Private Sub DisableControls(ByVal isSingle As Boolean)
        If isSingle Then        '若该试题为单选题
            '只显示单选控件
            RadioButtonA.Visible = True
            RadioButtonB.Visible = True
            RadioButtonC.Visible = True
            RadioButtonD.Visible = True
            CheckBoxA.Visible = False
            CheckBoxB.Visible = False
            CheckBoxC.Visible = False
            CheckBoxD.Visible = False
        Else                    '若该试题为多选题
            '只显示多选控件
            CheckBoxA.Visible = True
            CheckBoxB.Visible = True
            CheckBoxC.Visible = True
            CheckBoxD.Visible = True
            RadioButtonA.Visible = False
            RadioButtonB.Visible = False
            RadioButtonC.Visible = False
            RadioButtonD.Visible = False
        End If
    End Sub
    Private Sub getRandomOrder(ByVal StartNumber As Integer, ByVal EndNumber As Integer)
        Dim NumberArray As New ArrayList
        For i As Integer = StartNumber To EndNumber
            NumberArray.Add(i)
        Next
        If (NumberArray.Count <= 0) Then
            Exit Sub
        Else
            Randomize()
            For i As Integer = StartNumber To EndNumber
                Dim Index As Integer = Rnd() * (NumberArray.Count - 1)
                QuestionOrder(i - 1) = CType(NumberArray(Index), Integer)
                NumberArray.RemoveAt(Index)
            Next
        End If
    End Sub
    Private Sub getRightAnswer(ByVal TableName As String, ByVal TotalQuestion As Integer)
        Try
            '检查数据库文件是否存在
            If Dir(DataBaseLocation) = Nothing Then
                MsgBox("未找到数据库文件,请与管理员联系!" & Chr(13) & "对您造成不便我们深表歉意!" & Chr(13) & Chr(13) & "[Exception] Database Not Found!")
                Exit Sub
            End If
            '从数据库读取标准答案
            Dim Connection = New OleDbConnection(DatabaseConnectionString)
            Connection.Open()
            For i As Integer = 1 To TotalQuestion
                Dim SQL As String = "Select * From [" & TableName & "] Where [QuestionID]=" & i
                Dim cmd = New OleDbCommand(SQL, Connection)
                Dim Reader As OleDbDataReader = cmd.ExecuteReader
                While Reader.Read
                    RightAnswer(i - 1) = Reader("RightAnswer")
                End While
                cmd.Dispose()
            Next i
            Connection.Close()
        Catch ex As Exception
            MsgBox("An error occured while reading right answers in the database." & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
    Private Sub ProcessFinish()
        isFinished = True
        '显示提示信息
        LabelTitleQuestion.Text = StudentName & ",感谢您的参与!"
        LabelQuestion.Text = "请稍后, 正在上传您的成绩至服务器……"
        '终止所有计时器
        TimerUp.Stop()
        TimerDown.Stop()
        '将答题控件设为不可见
        LabelTitleAnswer.Visible = False
        GroupBox.Visible = False
        ButtonPrevious.Visible = False
        ButtonNext.Visible = False
        TextJumpTo.Visible = False
        '计算用户得分
        LabelQuestion.Text = "正在计算您的得分……"
        For i As Integer = 1 To TotalQuestion
            If YourAnswer(i - 1) = RightAnswer(i - 1) Then
                Score = Score + 1
            End If
        Next
        UploadScoreByWeb(Score)
        UploadScoreByFTP("C:\Windows\Temp\", StudentID & StudentName & ".dat", Score)
        ButtonOK.Visible = True
        LabelQuestion.Text = Chr(13) & Chr(13) & "已经将您的成绩上传至服务器,请单击确定按钮退出系统." & Chr(13) & Chr(13) & "合肥工业大学软件学院感谢您的参与!"
    End Sub
    Private Sub UploadScoreByWeb(ByVal Score As UShort)
        LabelQuestion.Text = "正在上传结果至服务器……"
        CurrentPurpose = "Submit"
        ConnectToServer(CurrentPurpose)
        '开启监听线程
        If BackgroundWorker.IsBusy = False Then
            BackgroundWorker.RunWorkerAsync()
        End If
    End Sub
    Private Sub UploadScoreByFTP(ByVal FileFullPath As String, ByVal FileName As String, ByVal Score As UShort)
        LabelQuestion.Text = "正在上传结果至FTP服务器……"
        Try
            Dim FtpClient As New Net.WebClient
            '创建上传文件
            If Dir(FileFullPath & FileName) = Nothing Then
                Dim UploadFile As New System.IO.StreamWriter(FileFullPath & FileName)
                UploadFile.WriteLine("Score : " & Score)
                UploadFile.WriteLine("Time : " & LabelTimeUsed.Text)
                UploadFile.WriteLine()
                '将选手所选答案写入文件
                For i As Integer = 1 To TotalQuestion
                    UploadFile.WriteLine("#" & i & vbTab & "选手答案:" & YourAnswer(i - 1) & vbTab & "标准答案:" & RightAnswer(i - 1))
                Next
                UploadFile.Close()
                '上传文件
                FtpClient.Credentials = New Net.NetworkCredential(FtpServerUserName, FtpServerPassword)
                FtpClient.UploadFile("ftp://" & FtpServerIpAddress & "/" & FileName, FileFullPath & FileName)
                Exit Sub
            Else
                MsgBox("[Exception] The file you uploaded is already exists!")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("An error occured while uploading files via FTP Server" & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
    Private Sub BackgroundWorker_DoWork(ByVal Sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        While True
            Try
                '接收信息
                SocketCelint.ReceiveFrom(ReceiveByte, 0, ReceiveByte.Length, SocketFlags.None, ServerPoint)
                '反序列化接收到的信息(由服务器)
                ReceiveBuffer = DeserializeMessage(ReceiveByte)
                Select Case ReceiveBuffer.Order
                    Case "SubmitSuccessfully"           '提示用户已成功提交
                        BackgroundWorker.ReportProgress(0)
                    Case "ForceLogout"                  '提示用户被强制退出竞赛
                        BackgroundWorker.ReportProgress(1)
                    Case Else
                End Select
            Catch ex As Exception
                '[Exception] An error occured while sending orders to Server
            End Try
        End While
    End Sub
    Private Sub BackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged
        Select Case e.ProgressPercentage
            Case 0      'SubmitSuccessfully
                Timer.Stop()         '禁用超时计时器
                MsgBox("您已成功上传成绩至服务器!" & Chr(13) & Chr(13) & "[Expection] Submit Successfully!")
            Case 1      'ForceLogout
                TimerUp.Stop()
                TimerDown.Stop()
                MsgBox("您已被管理员强制退出问答系统" & Chr(13) & "对此给您造成的不便我们深表歉意!")
                End
            Case Else
        End Select
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ConnectToServer(CurrentPurpose)
    End Sub
    Private Sub TimerUp_Tick(sender As Object, e As EventArgs) Handles TimerUp.Tick
        SecondUp += 1
        ShowTime(LabelTimeUsed, SecondUp)               '更新时间显示
    End Sub
    Private Sub TimerDown_Tick(sender As Object, e As EventArgs) Handles TimerDown.Tick
        If SecondDown = 0 Then
            isFinished = True
            ProcessFinish()                             '准备提交结果至服务器
            MsgBox("Sorry, Time's up!")
        Else
            SecondDown -= 1
            ShowTime(LabelTimeRemaining, SecondDown)    '更新时间显示
        End If
    End Sub
    Private Sub ShowTime(LabelTime As Object, ByVal SecondCounter As UInteger)
        Dim Hour As Integer = 0
        Dim Minute As Integer = 0
        Dim Second As Integer = 0
        '时间换算
        Minute = SecondCounter \ 60
        Second = SecondCounter Mod 60
        Hour = Minute \ 60
        Minute = Minute Mod 60
        '更新时间显示
        If Second < 10 Then         '调整显示格式 HH:MM:SS
            If Minute < 10 Then
                LabelTime.Text = "0" & Trim(Str(Hour)) & ":0" & Trim(Str(Minute)) & ":0" & Trim(Str(Second))
            Else
                LabelTime.Text = "0" & Trim(Str(Hour)) & ":" & Trim(Str(Minute)) & ":0" & Trim(Str(Second))
            End If
        Else
            If Minute < 10 Then
                LabelTime.Text = "0" & Trim(Str(Hour)) & ":0" & Trim(Str(Minute)) & ":" & Trim(Str(Second))
            Else
                LabelTime.Text = "0" & Trim(Str(Hour)) & ":" & Trim(Str(Minute)) & ":" & Trim(Str(Second))
            End If
        End If
    End Sub
End Class