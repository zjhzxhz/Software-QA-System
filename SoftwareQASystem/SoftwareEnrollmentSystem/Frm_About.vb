Public NotInheritable Class Frm_About
    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 设置此窗体的标题。
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> Nothing Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("关于 {0}", ApplicationTitle)
        ' 初始化“关于”对话框显示的所有文字。
        ' TODO: 在项目的“应用程序”窗格中自定义此应用程序的程序集信息 
        '    属性对话框(在“项目”菜单下)。
        Me.LabelProductName.Text = "产品名称：" & My.Application.Info.ProductName
        Me.LabelVersion.Text = "版本：" & String.Format("版本 {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = "版权：" & My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
    End Sub
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class
