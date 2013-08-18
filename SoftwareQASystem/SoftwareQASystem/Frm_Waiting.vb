Public Class Frm_Waiting
    Public CanClose As Boolean = False
    Private Sub Frm_Waiting_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If CanClose = False Then
            e.Cancel = True
        End If
    End Sub
End Class