Imports System.Data.OleDb
Imports System.Text
Imports System.Security.Cryptography
Module ModuleFunctions
    Public Function Encryption(ByVal Password As String) As String
        Dim DesProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
        Dim HashMd5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
        Dim Key As String = "SoftwareQASystem"  '用于加密的Key
        DesProvider.Key = HashMd5.ComputeHash(Encoding.Default.GetBytes(Key))
        DesProvider.Mode = CipherMode.ECB
        Dim DESEncrypt As ICryptoTransform = DesProvider.CreateEncryptor()
        Dim Buffer As Byte() = Encoding.Default.GetBytes(Password)
        Return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function
    Public Function Decryption(ByVal Password As String) As String
        Dim DesProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
        Dim HashMd5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
        Dim Key As String = "SoftwareQASystem"  '用于解密的Key
        DesProvider.Key = HashMd5.ComputeHash(Encoding.Default.GetBytes(Key))
        DesProvider.Mode = CipherMode.ECB
        Dim DESDecrypt As ICryptoTransform = DesProvider.CreateDecryptor()
        Dim DecryptPassword As String =Nothing
        Try
            Dim Buffer As Byte() = Convert.FromBase64String(Password)
            DecryptPassword = Encoding.Default.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            'Do Nothing
        End Try
        Return DecryptPassword
    End Function
    Public Function getRandomString(ByVal Length As Integer)
        Dim RandomString As String =Nothing
        Dim CharTable(128) As Char
        '向数组中添加元素
        For i As Integer = 0 To 9       '添加数字至数组【0】-【29】
            CharTable(i) = Chr(i + 48)
            CharTable(i + 10) = Chr(i + 48)
            CharTable(i + 20) = Chr(i + 48)
        Next
        For i As Integer = 65 To 90     '添加大写字母至数组【30】-【55】
            CharTable(i - 35) = Chr(i)
        Next
        For i As Integer = 97 To 122    '添加小写字母至数组【56】-【81】
            CharTable(i - 41) = Chr(i)
        Next
        '生成密码
        For i As Integer = 1 To Length
            Randomize()
            RandomString = RandomString + CharTable(Int(Rnd() * 81))
        Next
        Return RandomString
    End Function
    '读取Xml文件
    Public Sub ReadXmlDocument(ByVal XmlDocumentPath As String)
        Try
            Dim XmlReader As New Xml.XmlTextReader(XmlDocumentPath)
            While XmlReader.Read
                If (XmlReader.NodeType = Xml.XmlNodeType.Element) Then
                    Select Case (XmlReader.LocalName)
                        Case "Product"
                            If XmlReader.ReadToFollowing("Name") Then
                                '若产品名称与配置文件不匹配
                                If (XmlReader.ReadString <> Application.ProductName) Then
                                    MsgBox("An error occured while reading configuration in Config.Xml" & Chr(13) & Chr(13) &
                                           "[Exception] The Xml document is mismatched with the Software!")
                                    Exit Sub
                                End If
                            End If
                        Case "UserInformation"
                            If XmlReader.ReadToFollowing("UserName") Then
                                AdministratorUserName = XmlReader.ReadString
                            End If
                            If XmlReader.ReadToFollowing("Password") Then
                                AdministratorPassWord = Decryption(XmlReader.ReadString)
                            End If
                        Case "Database"
                            If XmlReader.ReadToFollowing("TotalQuestion") Then
                                TotalQuestion = XmlReader.ReadString
                            End If
                            If XmlReader.ReadToFollowing("TotalTime") Then
                                TotalTime = XmlReader.ReadString
                            End If
                            If XmlReader.ReadToFollowing("Password") Then
                                DatabasePassWord = Decryption(XmlReader.ReadString)
                            End If
                        Case "MainServer"
                            If XmlReader.ReadToFollowing("IpAddress") Then
                                MainServerIpAddress = XmlReader.ReadString
                            End If
                            If XmlReader.ReadToFollowing("Port") Then
                                MainServerPort = XmlReader.ReadString
                            End If
                        Case "StandbyServer"
                            If XmlReader.ReadToFollowing("IpAddress") Then
                                StandbyServerIpAddress = XmlReader.ReadString
                            End If
                            If XmlReader.ReadToFollowing("Port") Then
                                StandbyServerPort = XmlReader.ReadString
                            End If
                        Case "FtpServer"
                            If XmlReader.ReadToFollowing("IpAddress") Then
                                FtpServerIpAddress = XmlReader.ReadString
                            End If
                            If XmlReader.ReadToFollowing("UserName") Then
                                FtpServerUserName = Decryption(XmlReader.ReadString)
                            End If
                            If XmlReader.ReadToFollowing("Password") Then
                                FtpServerPassword = Decryption(XmlReader.ReadString)
                            End If
                    End Select
                End If
            End While
        Catch ex As Exception
            MsgBox("An error occured while reading configuration in Config.Xml" & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
    '创建Xml文件
    Public Sub CreateXmlDocument(ByVal XmlDocumentPath As String)
        Try
            Dim XmlWriter As New Xml.XmlTextWriter(XmlDocumentPath, System.Text.Encoding.GetEncoding("utf-8"))
            XmlWriter.Formatting = Xml.Formatting.Indented '使用自动缩进便于阅读
            XmlWriter.WriteRaw("<?xml version=""1.0"" encoding=""utf-8"" ?>")
            XmlWriter.WriteStartElement("Config")                                           '创建根元素
            '第二级元素 - Product        <Product> 
            XmlWriter.WriteStartElement("Product")                                          '添加第二级元素
            XmlWriter.WriteElementString("Name", Application.ProductName)                   '添加子元素
            XmlWriter.WriteElementString("Version", Application.ProductVersion)             '添加子元素
            XmlWriter.WriteEndElement() '</Product>                                         '关闭第二级元素
            '第二级元素 - UserInformation<UserInformation> 
            XmlWriter.WriteStartElement("UserInformation")                                  '添加第二级元素
            XmlWriter.WriteElementString("UserName", AdministratorUserName)                 '添加子元素
            XmlWriter.WriteElementString("Password", Encryption(AdministratorPassWord))     '添加子元素
            XmlWriter.WriteEndElement() '</UserInformation>                                 '关闭第二级元素
            '第二级元素 - SystemSettings <SystemSettings>
            XmlWriter.WriteStartElement("SystemSettings")                                   '添加第二级元素
            '第三级元素 - Database      <Database> 
            XmlWriter.WriteStartElement("Database")                                         '添加第三级元素
            XmlWriter.WriteElementString("TotalQuestion", TotalQuestion)                    '添加子元素
            XmlWriter.WriteElementString("TotalTime", TotalTime)                            '添加子元素
            XmlWriter.WriteElementString("Password", Encryption(DatabasePassWord))          '添加子元素
            XmlWriter.WriteEndElement() '</Database>                                        '关闭第三级元素
            '第三级元素 - MainServer      <MainServer> 
            XmlWriter.WriteStartElement("MainServer")                                        '添加第三级元素
            XmlWriter.WriteElementString("IpAddress", MainServerIpAddress)                   '添加子元素
            XmlWriter.WriteElementString("Port", MainServerPort)                             '添加子元素
            XmlWriter.WriteEndElement() '</MainServer>                                       '关闭第三级元素
            '第三级元素 - StandbyServer  <StandbyServer>
            XmlWriter.WriteStartElement("StandbyServer")                                    '添加第三级元素
            XmlWriter.WriteElementString("IpAddress", StandbyServerIpAddress)               '添加子元素
            XmlWriter.WriteElementString("Port", StandbyServerPort)                         '添加子元素
            XmlWriter.WriteEndElement() '</StandbyServer>                                   '关闭第三级元素
            '第三级元素 - StandbyServer  <FtpServer>
            XmlWriter.WriteStartElement("FtpServer")                                        '添加第三级元素
            XmlWriter.WriteElementString("IpAddress", FtpServerIpAddress)                   '添加子元素
            XmlWriter.WriteElementString("UserName", Encryption(FtpServerUserName))         '添加子元素
            XmlWriter.WriteElementString("Password", Encryption(FtpServerPassword))         '添加子元素
            XmlWriter.WriteEndElement() '</FtpServer>                                       '关闭第三级元素
            XmlWriter.WriteEndElement() '</SystemSettings>                                  '关闭第二级元素
            XmlWriter.WriteFullEndElement()                                                 '关闭根元素
            XmlWriter.Close()                                                               '关闭Xml文档
        Catch ex As Exception
            MsgBox("An error occured while writing configuration in Config.Xml" & Chr(13) & Chr(13) & "[Exception] " & ex.Message)
        End Try
    End Sub
    Public Class ListViewItemComparer
        Implements IComparer
        Private m_Column As Integer
        Private m_isAscending As Boolean
        Public Sub New(ByVal Column As UInteger, ByVal isAscending As Boolean)
            m_Column = Column
            m_isAscending = isAscending
        End Sub
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
            If m_isAscending Then
                Return [String].Compare(CType(x, ListViewItem).SubItems(m_Column).Text, CType(y, ListViewItem).SubItems(m_Column).Text)
            Else
                Return [String].Compare(CType(y, ListViewItem).SubItems(m_Column).Text, CType(x, ListViewItem).SubItems(m_Column).Text)
            End If
        End Function
    End Class
End Module
