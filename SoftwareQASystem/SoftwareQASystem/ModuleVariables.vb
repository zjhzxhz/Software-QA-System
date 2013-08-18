Imports System
Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Module ModuleVariable
    '学生信息
    Public StudentID As Integer     '学号
    Public StudentName As String    '姓名
    Public Group As String          '组别
    'Udp网络通信
    Public SocketCelint As New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp) '客户端Socket对象
    Public ServerPoint As IPEndPoint                           '服务器IP及端口号
    Public SendBuffer As New ClassLibrary.SocketMessage        '发送内容
    Public ReceiveBuffer As New ClassLibrary.SocketMessage     '接收内容
    Public ReceiveByte(10240) As Byte                          '接收字节数组
    '数据库信息
    Public DataBaseLocation As String = System.Windows.Forms.Application.StartupPath & "\DataBase.mdb" '数据库文件位置
    Public DatabasePassWord As String = "zjhzxhz"                       '默认数据库密码
    Public DatabaseConnectionString As String = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " & DataBaseLocation & ";Persist Security Info = false;Jet OLEDB:Database Password = " & DatabasePassWord
    '管理员信息
    Public AdministratorUserName As String = "谢浩哲"                   '默认管理员用户名
    Public AdministratorPassWord As String = "zjhzxhz"                  '默认管理员密码
    '竞赛配置信息
    Public TotalQuestion As UShort = 10                                 '默认试题总数
    Public TotalTime As UInteger = 5400                                 '默认答题时间
    '服务器信息
    Public MainServerIpAddress As String = "127.0.0.1"                  '默认主服务器IP地址
    Public MainServerPort As String = "8081"                            '默认主服务器端口
    Public StandbyServerIpAddress As String = "127.0.0.1"               '默认备用服务器IP地址
    Public StandbyServerPort As String = "8082"                         '默认备用服务器端口
    Public FtpServerIpAddress As String = "127.0.0.1"                   '默认Ftp服务器IP地址
    Public FtpServerUserName As String = "SoftwareQA"                   '默认Ftp用户名
    Public FtpServerPassword As String = "zjhzxhz"                      '默认Ftp密码
End Module
