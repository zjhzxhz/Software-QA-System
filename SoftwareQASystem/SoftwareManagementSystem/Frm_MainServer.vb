Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Public Class Frm_MainServer
    Private isStarted As Boolean = False            '管理系统开启状态
    Private hasNoticed As Boolean = False           '记录是否已提示合成竞赛结果
    Private CountLogin, CountSubmit As Integer      '登录/提交人数计数
    Private SecondUp As UInteger = 0                '存储竞赛已用时间
    Private SecondDown As UInteger = TotalTime      '存储竞赛剩余时间
    'Udp网络服务
    Private SocketServer As New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
    Private ReceiveByte(10240) As Byte
    Private ReceiveBuffer As New ClassLibrary.SocketMessage
    Private SendBuffer As New ClassLibrary.SocketMessage
    Private ClientPoint As New IPEndPoint(IPAddress.Any, 0)
    Private UserID As New ArrayList
    Private UserAddress As New ArrayList
    Private Sub Frm_MainServer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '初始化全局变量
        isStarted = False            '管理系统开启状态
        hasNoticed = False           '记录是否已提示合成竞赛结果
        '打开数据连接
        BackgroundWorker.WorkerSupportsCancellation = True
        BackgroundWorker.WorkerReportsProgress = True
        BackgroundWorker.RunWorkerAsync()
        '检测备用服务器是否可用
        If StandbyServerIpAddress = "Disabled" Or StandbyServerPort = "Disabled" Then
            ButtonSynchronize.Enabled = False
        End If
        '写入系统日志
        ListLog.Items.Add(System.DateTime.Now.ToLongTimeString & " : 启动竞赛问答系统")
    End Sub
    Private Sub Frm_Main_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If isStarted Then
            '取消关闭窗口动作
            e.Cancel = True
            '提示用户结束竞赛
            MsgBox("请先结束竞赛后再次尝试退出系统!")
        Else
            If hasNoticed = False Then
                If CountLogin <> 0 Or CountSubmit <> 0 Then
                    '提示用户合成竞赛结果
                    If MsgBox("请确认您已经合成了竞赛结果" & Chr(13) & "确认要继续吗?", vbYesNo) = vbNo Then
                        '取消关闭窗口动作
                        e.Cancel = True
                        '合成竞赛结果
                        ExportToExcel(Me.ListSubmit)
                    Else
                        MsgBox("感谢您的使用!")
                        '关闭数据连接
                        Try
                            BackgroundWorker.CancelAsync()
                            BackgroundWorker.Dispose()
                            SocketServer.Shutdown(SocketShutdown.Both)
                            SocketServer.Close()
                        Catch ex As Exception
                            MsgBox("An error occured while closing data connection." & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
                        End Try
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub ButtonSwitch_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ButtonSwitch.LinkClicked
        If isStarted = False Then
            isStarted = True
            LabelServerStatus.Text = "Running"
            LabelServerStatus.ForeColor = Color.Green
            '启用计时器
            TimerUp.Start()
            TimerDown.Start()
            '写入系统日志
            ListLog.Items.Add(System.DateTime.Now.ToLongTimeString & " : 开始软件知识竞赛")
            '向已登录的用户发送竞赛开始信息
            For i As Integer = 0 To UserAddress.Count - 1
                SendBuffer.Order = "LoginSuccessfully"
                SendBuffer.TimeUsed = SecondDown
                SocketServer.SendTo(SerializeMessage(SendBuffer), UserAddress(i))
            Next
        Else
            '请求用户确认
            If MsgBox("您确定要结束竞赛吗?" & Chr(13) & "请先确认所有用户都已经提交答案!", vbYesNo) = vbYes Then
                If MsgBox("请您再次确认", vbYesNo) = vbYes Then
                    isStarted = False
                    LabelServerStatus.Text = "Stopped"
                    LabelServerStatus.ForeColor = Color.Red
                    '禁用计时器
                    TimerUp.Stop()
                    TimerDown.Stop()
                    '写入系统日志
                    ListLog.Items.Add(System.DateTime.Now.ToLongTimeString & " : 结束软件知识竞赛")
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub
    Private Sub BackgroundWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        Try
            SocketServer.Bind(New IPEndPoint(IPAddress.Any, MainServerPort)) '绑定服务器地址
            While True
                SocketServer.ReceiveFrom(ReceiveByte, ClientPoint)  '接收信息
                ReceiveBuffer = DeserializeMessage(ReceiveByte)     '反序列化
                '根据命令决定处理方式
                Select Case ReceiveBuffer.Order
                    Case "Login"    '用于处理用户登录请求
                        '查找用户是否已登录或已完成答题
                        Dim isFound As Boolean = False
                        '在已提交用户的ListView中查找
                        For i As Integer = 0 To ListSubmit.Items.Count - 1
                            If ListSubmit.Items(i).SubItems(0).Text = ReceiveBuffer.StudentID Then
                                isFound = True
                                Exit For
                            End If
                        Next
                        '若未在已提交用户的ListView找到则继续在已登录用户的ListView中查找
                        If isFound = False Then
                            '在已登录用户的ListView中查找
                            For i As Integer = 0 To ListLogin.Items.Count - 1
                                If ListLogin.Items(i).SubItems(0).Text = ReceiveBuffer.StudentID Then
                                    isFound = True
                                    Exit For
                                End If
                            Next
                        End If
                        '返回信息至用户
                        If isFound = False Then
                            '记录登录用户的信息至ListLogin
                            With ListLogin
                                Dim iListItem As ListViewItem
                                iListItem = ListLogin.Items.Add(ReceiveBuffer.StudentID)
                                iListItem.SubItems.Add(ReceiveBuffer.StudentName)
                                iListItem.SubItems.Add(ReceiveBuffer.Group)
                                iListItem.SubItems.Add(ClientPoint.ToString)
                                iListItem.SubItems.Add(System.DateTime.Now.ToLongTimeString)
                            End With
                            '记录用户ID以及IP地址至ArrayList
                            UserID.Add(ReceiveBuffer.StudentID)
                            UserAddress.Add(ClientPoint)
                            '写入系统日志
                            ListLog.Items.Add(System.DateTime.Now.ToLongTimeString & " : 学号 " & ReceiveBuffer.StudentID & "(" & ReceiveBuffer.StudentName & ")的用户在" & ClientPoint.ToString & " 登录")
                            '刷新在线人数
                            CountLogin = CountLogin + 1
                            If CountLogin < 10 Then
                                LabelLogin.Text = "0" + Trim(Str(CountLogin))
                            Else
                                LabelLogin.Text = Trim(Str(CountLogin))
                            End If
                            '返回登录信息
                            If isStarted Then
                                '提示用户成功登录
                                SendBuffer.Order = "LoginSuccessfully"
                                SendBuffer.TimeUsed = SecondDown        '发送竞赛剩余时间信息
                            Else
                                '提示用户等待竞赛开始
                                SendBuffer.Order = "WaitForStart"
                            End If
                            SocketServer.SendTo(SerializeMessage(SendBuffer), ClientPoint)
                        Else 'If isFound = True Then
                            '提示用户登录失败
                            SendBuffer.Order = "UserLogined"
                            SocketServer.SendTo(SerializeMessage(SendBuffer), ClientPoint)
                        End If
                    Case "Update"
                        '返回成功建立连接确认
                        SendBuffer.Order = "UpdateSuccessfully"
                        SocketServer.SendTo(SerializeMessage(SendBuffer), ClientPoint)
                    Case "Submit"   '用于处理用户提交答题结果请求
                        Dim isFound As Boolean = False
                        '在已提交用户的ListView中查找
                        For i As Integer = 0 To ListSubmit.Items.Count - 1
                            If ListSubmit.Items(i).SubItems(0).Text = ReceiveBuffer.StudentID Then
                                isFound = True
                                Exit For
                            End If
                        Next
                        If isFound = False Then
                            '记录提交用户的信息至ListSubmit
                            With ListSubmit
                                Dim iListItem As ListViewItem
                                iListItem = ListSubmit.Items.Add(ReceiveBuffer.StudentID)
                                iListItem.SubItems.Add(ReceiveBuffer.StudentName)
                                iListItem.SubItems.Add(ReceiveBuffer.Group)
                                iListItem.SubItems.Add(ReceiveBuffer.Score)
                                iListItem.SubItems.Add(ReceiveBuffer.TimeUsed)
                                iListItem.SubItems.Add(ClientPoint.ToString)
                                iListItem.SubItems.Add(System.DateTime.Now.ToLongTimeString)
                            End With
                            '写入系统日志
                            ListLog.Items.Add(System.DateTime.Now.ToLongTimeString & " : 学号 " & ReceiveBuffer.StudentID & "(" & ReceiveBuffer.StudentName & ")的用户在" & ClientPoint.ToString & " 提交")
                            '刷新提交人数
                            CountSubmit = CountSubmit + 1
                            If CountSubmit < 10 Then
                                LabelSubmit.Text = "0" + Trim(Str(CountSubmit))
                            Else
                                LabelSubmit.Text = Trim(Str(CountSubmit))
                            End If
                        End If
                        '返回成功提交确认
                        SendBuffer.Order = "SubmitSuccessfully"
                        SocketServer.SendTo(SerializeMessage(SendBuffer), ClientPoint)
                    Case "Logout"   '用于处理用户登出请求
                        Dim isFound As Boolean = False
                        '删除在ArrayList和ListLogin中的记录
                        For i As Integer = 0 To ListLogin.Items.Count - 1
                            If ListLogin.Items(i).SubItems(0).Text = ReceiveBuffer.StudentID Then
                                isFound = True
                                ListLogin.Items(i).Remove()
                                UserID.RemoveAt(i)
                                UserAddress.RemoveAt(i)
                                Exit For
                            End If
                        Next
                        '若该用户在主服务器存在登录记录
                        If isFound = True Then
                            '写入系统日志
                            ListLog.Items.Add(System.DateTime.Now.ToLongTimeString & " : 学号 " & ReceiveBuffer.StudentID & "(" & ReceiveBuffer.StudentName & ")的用户在" & ClientPoint.ToString & " 登出")
                            '刷新在线人数
                            CountLogin = CountLogin - 1
                            If CountLogin < 10 Then
                                LabelLogin.Text = "0" + Trim(Str(CountLogin))
                            End If
                        End If
                    Case "SyncWithMainServer"           '发送信息使备用服务器与本机同步
                        SendBuffer.Order = "SyncWithMainServer"
                        SendBuffer.TimeUsed = SecondDown
                        SocketServer.SendTo(SerializeMessage(SendBuffer), ClientPoint)
                    Case "SyncWithStandbyServer"        '接收来自备用服务器的同步信息
                        SecondDown = ReceiveBuffer.TimeUsed
                    Case Else
                End Select
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ButtonSynchronize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSynchronize.Click
        Dim StandbyServerPoint As New IPEndPoint(IPAddress.Parse(StandbyServerIpAddress), StandbyServerPort)
        SendBuffer.Order = "SyncWithStandbyServer"
        SocketServer.SendTo(SerializeMessage(SendBuffer), StandbyServerPoint)
    End Sub
    Private Sub ButtonImportResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonImportResult.Click
        If isStarted Then
            MsgBox("请先结束竞赛, 再尝试导出竞赛结果")
        Else
            '禁用导入/ 导出竞赛结果控件
            ButtonImportResult.Enabled = False
            MenuItemImport.Enabled = False
            ButtonExportResult.Enabled = False
            MenuItemExport.Enabled = False
            '导出竞赛结果至Excel
            ImportFromExcel(Me.ListSubmit)
            '启用导入/ 导出竞赛结果控件
            ButtonImportResult.Enabled = True
            MenuItemImport.Enabled = True
            ButtonExportResult.Enabled = True
            MenuItemExport.Enabled = True
        End If
    End Sub
    Private Sub MenuItemImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemImport.Click
        ButtonImportResult_Click(sender, e)
    End Sub
    Private Sub ButtonExportResult_Click(sender As Object, e As EventArgs) Handles ButtonExportResult.Click
        If isStarted Then
            MsgBox("请先结束竞赛, 再尝试导出竞赛结果")
        Else
            '禁用导入/ 导出竞赛结果控件
            ButtonImportResult.Enabled = False
            MenuItemImport.Enabled = False
            ButtonExportResult.Enabled = False
            MenuItemExport.Enabled = False
            '导出竞赛结果至Excel
            ExportToExcel(Me.ListSubmit)
            hasNoticed = True
            '启用导入/ 导出竞赛结果控件
            ButtonImportResult.Enabled = True
            MenuItemImport.Enabled = True
            ButtonExportResult.Enabled = True
            MenuItemExport.Enabled = True
        End If
    End Sub
    Private Sub MenuItemExport_Click(sender As Object, e As EventArgs) Handles MenuItemExport.Click
        ButtonExportResult_Click(sender, e)
    End Sub
    Private Sub MenuItemSystemSettings_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemSystemSettings.Click
        If isStarted Then
            MsgBox("请先结束竞赛后再进行系统设置!")
            Exit Sub
        Else
            If CountLogin <> 0 Or CountSubmit <> 0 Then
                '提示用户合成竞赛结果
                If MsgBox("请确认您已经合成了竞赛结果" & Chr(13) & "确认要继续吗?", vbYesNo) = vbNo Then
                    ExportToExcel(Me.ListSubmit)    '合成竞赛结果
                    Exit Sub                        '取消关闭窗体
                End If
            End If
            '加载Frm_SystemSettings窗体
            Frm_SystemSettings.Show()
            HasNoticed = True   '已提示用户合成竞赛结果
            Me.Close()
        End If
    End Sub
    Private Sub MenuItemLogout_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemLogout.Click
        If isStarted Then
            MsgBox("请先结束竞赛后再退出登录!")
            Exit Sub
        Else
            If CountLogin <> 0 Or CountSubmit <> 0 Then
                '提示用户合成竞赛结果
                If MsgBox("请确认您已经合成了竞赛结果" & Chr(13) & "确认要继续吗?", vbYesNo) = vbNo Then
                    ExportToExcel(Me.ListSubmit)    '合成竞赛结果
                    Exit Sub                        '取消关闭窗体
                End If
            End If
            isLogined = False
            hasNoticed = True       '已提示用户合成竞赛结果
            Application.Restart()   '重新启动应用程序以释放绑定的端口
        End If
    End Sub
    Private Sub MenuItemExit_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemExit.Click
        If isStarted Then
            MsgBox("请先结束竞赛后再退出系统!")
            Exit Sub
        Else
            If CountLogin <> 0 Or CountSubmit <> 0 Then
                '提示用户合成竞赛结果
                If MsgBox("请确认您已经合成了竞赛结果" & Chr(13) & "确认要继续吗?", vbYesNo) = vbNo Then
                    ExportToExcel(Me.ListSubmit)    '合成竞赛结果
                    Exit Sub                        '取消关闭窗体
                End If
            End If
            MsgBox("感谢您的使用!")
            End
        End If
    End Sub
    Private Sub MenuItemHelp_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemHelp.Click
        If Dir(System.Windows.Forms.Application.StartupPath & "\HelpAndSupport.Chm") <> Nothing Then
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath & "\HelpAndSupport.Chm")
        Else
            MsgBox("未找到帮助文件!" & Chr(13) & "对此给您带来的不便我们深表歉意!" & Chr(13) & Chr(13) & "[Exception] HelpAndSupport.Chm Not Exists!")
        End If
    End Sub
    Private Sub MenuItemAbout_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemAbout.Click
        Frm_About.ShowDialog()
    End Sub
    Private Sub ButtonDeleteLoginedUser_Click(sender As Object, e As EventArgs) Handles ButtonDeleteLoginedUser.Click
        If ListLogin.SelectedItems.Count <> 0 And ListLogin.Items.Count > 0 Then
            For Each Item As ListViewItem In ListLogin.SelectedItems
                If MsgBox("您确定要删除学号为 " & Item.SubItems(0).Text & "(" & Item.SubItems(1).Text & ")" & " 用户吗?", vbYesNo) = vbYes Then
                    '删除在ArrayList中的记录
                    For i As Integer = 0 To UserID.Count - 1
                        If UserID(i) = Item.SubItems(0).Text Then
                            UserID.RemoveAt(i)
                            UserAddress.RemoveAt(i)
                            Exit For
                        End If
                    Next
                    '删除在ListLogin中的记录
                    ListLogin.Items.Remove(Item)
                    '刷新在线人数
                    CountLogin = CountLogin - 1
                    If CountLogin < 10 Then
                        LabelLogin.Text = "0" + Trim(Str(CountLogin))
                    End If
                    '写入系统日志
                    ListLog.Items.Add(System.DateTime.Now.ToLongTimeString & " : 学号 " & Item.SubItems(0).Text & "(" & Item.SubItems(1).Text & ")" & " 的用户被管理员手动登出")
                End If
            Next
        Else
            MsgBox("请在已登录用户列表中选择需要删除的用户!")
        End If
    End Sub
    Private Sub ButtonForceLogoutUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonForceLogoutUser.Click
        If ListLogin.SelectedItems.Count <> 0 And ListLogin.Items.Count > 0 Then
            SendBuffer.Order = "ForceLogout"
            For Each Item As ListViewItem In ListLogin.SelectedItems
                If MsgBox("您确定要强制登出学号为 " & Item.SubItems(0).Text & "(" & Item.SubItems(1).Text & ")" & " 用户吗?", vbYesNo) = vbYes Then
                    '删除在ArrayList中的记录
                    For i As Integer = 0 To UserID.Count - 1
                        If UserID(i) = Item.SubItems(0).Text Then
                            '发送【强制登出】请求至用户
                            SocketServer.SendTo(SerializeMessage(SendBuffer), UserAddress(i))
                            '删除在ArrayList中的记录
                            UserID.RemoveAt(i)
                            UserAddress.RemoveAt(i)
                            Exit For
                        End If
                    Next
                    '删除在ListLogin中的记录
                    ListLogin.Items.Remove(Item)
                    '刷新在线人数
                    CountLogin = CountLogin - 1
                    If CountLogin < 10 Then
                        LabelLogin.Text = "0" + Trim(Str(CountLogin))
                    End If
                    '写入系统日志
                    ListLog.Items.Add(System.DateTime.Now.ToLongTimeString & " : 学号 " & Item.SubItems(0).Text & "(" & Item.SubItems(1).Text & ")" & " 的用户被管理员强制登出")
                End If
            Next
            MsgBox("您所选择的用户已被强制退出!")
        Else
            MsgBox("请在已登录用户表中选择需要强制退出的用户!")
        End If
    End Sub
    Private Sub ListLogin_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListLogin.ColumnClick
        Static Dim LastColumn As UShort = 0
        Static Dim isAscending As Boolean = True
        '默认对每列进行升序排序
        If LastColumn <> e.Column Then
            LastColumn = e.Column
            isAscending = True
        End If
        ListLogin.ListViewItemSorter = New ListViewItemComparer(e.Column, isAscending)
        isAscending = Not isAscending
    End Sub
    Private Sub ListSubmit_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListSubmit.ColumnClick
        Static Dim LastColumn As UShort = 0
        Static Dim isAscending As Boolean = True
        '默认对每列进行升序排序
        If LastColumn <> e.Column Then
            LastColumn = e.Column
            isAscending = True
        End If
        ListSubmit.ListViewItemSorter = New ListViewItemComparer(e.Column, isAscending)
        isAscending = Not isAscending
    End Sub
    Private Sub ImportFromExcel(ByRef List As ListView)
        Dim RecordCounter As UInteger = 0
        Try
            Dim ExcelFileName As String = Nothing
            Dim ExcelFileExtensionName As String = Nothing
            If CountSubmit <> 0 Then
                If MsgBox("是否清空原有数据?" & Chr(13) & "该操作将无法恢复!", vbYesNo) = vbYes Then
                    List.Items.Clear()
                End If
            End If
            '提示用户选择需要导入的文件
            OpenFileDialog.Filter = "Excel 工作簿|*.xlsx|Excel 97-2003 工作簿|*.xls"
            If OpenFileDialog.ShowDialog() = DialogResult.OK Then
                ExcelFileName = OpenFileDialog.FileName
                ExcelFileExtensionName = System.IO.Path.GetExtension(ExcelFileName).ToLower
            Else
                Exit Sub        '用户取消操作
            End If
            '获取Excel文件版本
            Dim ExcelConnectionString As String = Nothing
            If ExcelFileExtensionName = ".xlsx" Then         '若文件为Excel 2007 格式
                ExcelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & ExcelFileName & ";Extended Properties='Excel 12.0;HDR=YES';"
            Else 'If ExcelFileExtensionName = ".xls" Then    '若文件为Excel 97-2003 格式
                ExcelConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ExcelFileName & ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';"
            End If
            '获取工作表名称
            Dim SheetName As String = InputBox("请输入存放数据的工作表名称:", , "Sheet1")
            If SheetName = Nothing Then
                Exit Sub
            End If
            '读取Excel文件信息
            Dim DbSet As New DataSet
            Dim DbAdapter As New OleDbDataAdapter("SELECT * FROM [" & SheetName & "$]", ExcelConnectionString)
            DbAdapter.Fill(DbSet)
            For i As Integer = 0 To DbSet.Tables(0).Rows.Count - 1
                Dim StudentInformation(7) As String      '用于暂存Excel数据
                Dim isFound As Boolean = False
                '读取Excel信息至数组
                For j As Integer = 0 To DbSet.Tables(0).Columns.Count - 1
                    If DbSet.Tables(0).Rows(i).Item(j).ToString.Trim = Nothing Then
                        Exit For
                    Else
                        StudentInformation(j) = Trim(DbSet.Tables(0).Rows(i).Item(j))
                    End If
                Next
                '跳过空记录
                If StudentInformation(0) = Nothing Then
                    Continue For
                End If
                '判断记录是否存在
                For j As Integer = 0 To List.Items.Count - 1
                    '若在ListSubmit中发现相同数据
                    If List.Items(j).SubItems(0).Text = StudentInformation(0) Then
                        isFound = True
                        Exit For
                    End If
                Next
                '询问用户是否覆盖
                If isFound Then
                    If MsgBox("已存在学号: " & StudentInformation(0) & " (" & StudentInformation(1) & ") 的记录" & Chr(13) & "是否继续添加?", vbYesNo) = vbNo Then
                        Continue For
                    End If
                End If
                '添加记录至ListSubmit
                With List
                    Dim iListItem As ListViewItem
                    iListItem = List.Items.Add(StudentInformation(0))
                    iListItem.SubItems.Add(StudentInformation(1))
                    iListItem.SubItems.Add(StudentInformation(2))
                    iListItem.SubItems.Add(StudentInformation(3))
                    iListItem.SubItems.Add(StudentInformation(4))
                    iListItem.SubItems.Add(StudentInformation(5))
                    iListItem.SubItems.Add(StudentInformation(6))
                End With
                RecordCounter += 1
            Next
            MsgBox("成功导入了 " & RecordCounter & " 条记录.")
        Catch ex As Exception
            MsgBox("An error occured while importing results from Excel." & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
    Private Sub ExportToExcel(ByRef List As ListView)
        Try
            If List.Items.Count <= 0 Then
                MsgBox("不存在可以导出的记录.")
                Exit Sub
            End If
            Dim ExcelObject As Object = CreateObject("Excel.Application")
            Dim WorkBookObject As Object = ExcelObject.WorkBooks.add()
            For i As Integer = 1 To List.Columns.Count          '记录标题至Excel的第一行
                WorkBookObject.worksheets(1).cells(1, i) = List.Columns(i - 1).Text.Trim
            Next
            Dim Array(List.Items.Count - 1, List.Columns.Count - 1)
            For i As Integer = 0 To List.Items.Count - 1
                For j As Integer = 0 To List.Columns.Count - 1
                    If j < List.Items(i).SubItems.Count Then    '若该行该列项存在
                        Array(i, j) = List.Items(i).SubItems(j).Text.Trim
                    Else                                        '若该行该列项不存在
                        Array(i, j) = ""
                    End If
                Next
            Next
            WorkBookObject.worksheets(1).range("A2").Resize(List.Items.Count, List.Columns.Count).Value = Array '将数组写入Excel
            WorkBookObject.worksheets(1).Cells.EntireColumn.AutoFit()   '设置自动调整列宽
            ExcelObject.Visible = True
            '释放Excel对象
            WorkBookObject = Nothing
            ExcelObject = Nothing
        Catch ex As Exception
            MsgBox("An error occured while exporting results to Excel." & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
    Private Sub TimerUp_Tick(sender As Object, e As EventArgs) Handles TimerUp.Tick
        SecondUp += 1
        ShowTime(LabelTimeUsed, SecondUp)               '更新时间显示
    End Sub
    Private Sub TimerDown_Tick(sender As Object, e As EventArgs) Handles TimerDown.Tick
        If SecondDown = 0 Then
            '结束软件知识竞赛
            isStarted = False
            LabelServerStatus.Text = "Stopped"
            LabelServerStatus.ForeColor = Color.Red
            '禁用计时器
            TimerUp.Stop()
            TimerDown.Stop()
            '写入系统日志
            ListLog.Items.Add(System.DateTime.Now.ToLongTimeString & " : 结束软件知识竞赛")
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