Imports System.Data.OleDb
Public Class Frm_ManagementCenter
    Private Sub Frm_ManagementCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Start()   '防止数据太多造成窗体加载延时
    End Sub
    Private Sub MenuItemControlPanel_Click(sender As Object, e As EventArgs) Handles MenuItemControlPanel.Click
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
    Private Sub MenuItemMainForm_Click(sender As Object, e As EventArgs) Handles MenuItemMainForm.Click
        Frm_Main.Show()
        Me.Close()
    End Sub
    Private Sub MenuItemExit_Click(sender As Object, e As EventArgs) Handles MenuItemExit.Click
        If MsgBox("您确定要退出【软件知识竞赛报名系统】吗?", vbYesNo) = vbYes Then
            End
        End If
    End Sub
    Private Sub MenuItemLogout_Click(sender As Object, e As EventArgs) Handles MenuItemLogout.Click
        isLogined = False
        MsgBox("您已成功退出登录, 现在为您跳转至登录前页面.")
        Frm_Main.Show()
        Me.Close()
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
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Timer.Stop()        '在读取完数据后自动终止
        '检查数据库文件是否存在
        If Dir(DatabaseLocation) = Nothing Then
            MsgBox("未找到数据库文件,请与管理员联系!" & Chr(13) & "对您造成不便我们深表歉意!" & Chr(13) & Chr(13) & "[Exception] Database Not Found!")
            Exit Sub
        End If
        '从数据库读取报名用户信息
        Try
            Dim Connection = New OleDbConnection(DatabaseConnectionString)
            Connection.Open()
            Dim SQL As String = "Select * From [Student]"
            Dim Command = New OleDbCommand(SQL, Connection)
            Dim Reader As OleDbDataReader = Command.ExecuteReader
            While Reader.Read
                '添加已报名用户信息至ListRegister
                With ListRegister
                    Dim iListItem As ListViewItem
                    iListItem = ListRegister.Items.Add(Trim(Reader("StudentID")))
                    iListItem.SubItems.Add(Trim(Reader("StudentName")))
                    iListItem.SubItems.Add(Trim(Reader("Password")))
                    iListItem.SubItems.Add(Trim(Reader("Group")))
                    iListItem.SubItems.Add(Trim(Reader("School")))
                    iListItem.SubItems.Add(Trim(Reader("Profession")))
                    iListItem.SubItems.Add(Trim(Reader("Phone")))
                End With
            End While
            Command.Dispose()
            Connection.Close()
        Catch ex As Exception
            MsgBox("An error occured while reading data in the database!" & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
End Class