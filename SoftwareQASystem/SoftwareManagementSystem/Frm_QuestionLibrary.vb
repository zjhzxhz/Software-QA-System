Imports System.Data.OleDb
Public Class Frm_QuestionLibrary
    Private Sub Frm_QuestionLibrary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboGroup.Text = "专业组"
    End Sub
    Private Sub ComboGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboGroup.SelectedIndexChanged
        If ComboGroup.Text = "专业组" Then
            ConnectToDatabase("[ProfessionalGroup]")
        Else
            ConnectToDatabase("[Non-ProfessionalGroup]")
        End If
    End Sub
    Private Sub ConnectToDatabase(ByVal TableName As String)
        '从数据库读取试题信息
        Dim Connection As New OleDbConnection(DatabaseConnectionString)
        Dim SQL As String = "Select * From " & TableName & "Order by QuestionID"
        Dim Command = New OleDbCommand(SQL, Connection)
        Dim DbAdapter As OleDbDataAdapter = New OleDbDataAdapter(Command)
        Dim DbSet As New DataSet
        DbSet.Clear()
        Connection.Open()
        DbAdapter.Fill(DbSet, TableName)
        DataGridQuestionLibrary.DataSource = DbSet.Tables(TableName)
        Dim Reader As OleDbDataReader = Command.ExecuteReader
        While Reader.Read
        End While
        Connection.Close()
        Reader.Close()
        Command.Dispose()
    End Sub
    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        Static Dim canEdit As Boolean = False
        If canEdit Then     '若当前可以编辑数据库内容
            ButtonEdit.Text = "启用编辑"
            ButtonDeleteQuestion.Enabled = False
            ButtonSave.Enabled = False
            DataGridQuestionLibrary.ReadOnly = True
        Else
            ButtonEdit.Text = "禁用编辑"
            ButtonDeleteQuestion.Enabled = True
            ButtonSave.Enabled = True
            DataGridQuestionLibrary.ReadOnly = False
        End If
        canEdit = Not canEdit
    End Sub
    Private Sub ButtonDeleteQuestion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonDeleteQuestion.Click
        Dim DTable As DataTable = DataGridQuestionLibrary.DataSource
        If DataGridQuestionLibrary.IsSelected(DataGridQuestionLibrary.CurrentRowIndex) Then
            Dim SelectRowNumber As UInteger = DataGridQuestionLibrary.CurrentRowIndex
            If MsgBox("您确定要删除第 " & Str(SelectRowNumber + 1) & " 行的数据吗?", vbYesNo) = vbYes Then
                DTable.Rows.RemoveAt(SelectRowNumber)
                DataGridQuestionLibrary.Refresh()
            End If
        Else
            MsgBox("请选择需要删除的行")
        End If
    End Sub
    Private Sub ButtonSaveSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSave.Click
        Dim DTable As DataTable = DataGridQuestionLibrary.DataSource
        If MsgBox("确认要保存修改吗?", vbYesNo) = vbYes Then
            Dim DbAdapter As New OleDbDataAdapter
            Using Connection As New OleDbConnection(DatabaseConnectionString)
                Dim TableName As String = Nothing
                If ComboGroup.Text = "专业组" Then
                    TableName = "[ProfessionalGroup]"
                Else
                    TableName = "[Non-ProfessionalGroup]"
                End If
                Dim SQL As String = "Select * From " & TableName
                DbAdapter.SelectCommand = New OleDbCommand(SQL, Connection)
                Dim DbBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(DbAdapter)
                Connection.Open()
                DbAdapter.Update(DTable)
                Connection.Close()
                MsgBox("已成功保存您的修改至数据库.")
            End Using
        End If
    End Sub
End Class