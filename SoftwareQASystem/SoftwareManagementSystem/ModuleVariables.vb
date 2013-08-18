Imports System
Imports System.Data.OleDb
Module ModuleVariables
    Public isLogined As Boolean = False                                 '用于记录用户登录状态
    '数据库信息
    Public DatabaseLocation As String = System.Windows.Forms.Application.StartupPath & "\DataBase.mdb"
    Public DatabasePassWord As String = "zjhzxhz"                       '默认数据库密码
    Public DatabaseConnectionString As String = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " & DatabaseLocation & "; Persist Security Info = false; Jet OLEDB:Database Password = " & DatabasePassWord & "; Mode = 12"
    '竞赛配置信息
    Public TotalQuestion As UShort = 10                                 '默认试题总数
    Public TotalTime As UInteger = 5400                                 '默认答题时间
    '软件知识竞赛管理系统配置信息
    Public AdministratorUserName As String = "谢浩哲"                   '默认管理员用户名
    Public AdministratorPassWord As String = "zjhzxhz"                  '默认管理员密码
    Public MainServerIpAddress As String = "127.0.0.1"                  '默认主服务器IP地址
    Public MainServerPort As String = "8081"                            '默认主服务器端口
    Public StandbyServerIpAddress As String = "127.0.0.1"               '默认备用服务器IP地址
    Public StandbyServerPort As String = "8082"                         '默认备用服务器端口
    Public FtpServerIpAddress As String = "127.0.0.1"                   '默认Ftp服务器IP地址
    Public FtpServerUserName As String = "SoftwareQA"                   '默认Ftp用户名
    Public FtpServerPassword As String = "zjhzxhz"                      '默认Ftp密码
End Module
