Imports System
Imports System.Data.OleDb
Module ModuleVariables
    '数据库信息
    Public DatabaseLocation As String = System.Windows.Forms.Application.StartupPath & "\DataBase.mdb"
    Public DatabasePassWord As String = "zjhzxhz"                       '默认数据库密码
    Public DatabaseConnectionString As String = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " & DatabaseLocation & "; Persist Security Info = false; Jet OLEDB:Database Password = " & DatabasePassWord & "; Mode = 12"
    '软件知识竞赛报名系统配置信息
    Public Mode As String = "Local"                                     '默认报名模式
    Public isLogined As Boolean = False                                 '记录用户登录状态
    Public AdministratorUserName As String = "谢浩哲"                   '默认管理员用户名
    Public AdministratorPassWord As String = "zjhzxhz"                  '默认管理员密码
    Public MainServerIpAddress As String = "127.0.0.1"                  '默认主服务器IP地址
    Public MainServerPort As String = "8081"                            '默认主服务器端口
    Public StandbyServerIpAddress As String = "127.0.0.1"               '默认备用服务器IP地址
    Public StandbyServerPort As String = "8082"                         '默认备用服务器端口
End Module
