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
        Frm_Login.Show()
        Me.Close()
    End Sub
End Class