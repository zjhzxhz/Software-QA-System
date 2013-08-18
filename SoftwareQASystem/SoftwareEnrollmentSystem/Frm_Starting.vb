Public Class Frm_Starting
    Private Sub Frm_Starting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '显示产品名称和版本信息
        LabelProductName.Text = Application.ProductName
        LabelVersion.Text = Application.ProductVersion
        '从Config.Xml文件中读取用户配置信息
        Dim XmlDocumentPath = Application.StartupPath & "\Config.Xml"
        If Dir(XmlDocumentPath) <> Nothing Then
            ReadXmlDocument(XmlDocumentPath)
        End If
        '启动计时器
        Timer.Start()
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        '从SchoolInformation.Xml文件中读取院系信息
        Dim XmlDocumentPath = Application.StartupPath & "\SchoolInformation.Xml"
        If Dir(XmlDocumentPath) = Nothing Then
            Timer.Stop()
            MsgBox("未能找到院系配置文件! 请在【控制面板】中完成院系设置后继续!" & Chr(13) & Chr(13) & "[Exception] SchoolInformation.Xml Not Exsits!")
            Frm_ControlPanel.Show()
            Me.Close()
        Else
            Frm_Main.Show()
            Me.Close()
        End If
    End Sub
End Class