<Serializable()> Public Class SocketMessage
    Public Order As String              '请求
    '用户信息
    Public StudentID As Long            '学号
    Public StudentName As String        '姓名
    Public Group As String              '组别
    Public School As String            '学院
    Public Profession As String         '专业
    Public UserPassword As String       '用户密码
    Public PhoneNumber As String        '联系方式
    '答题信息
    Public Score As String              '得分
    Public TimeUsed As String           '所用时间
End Class