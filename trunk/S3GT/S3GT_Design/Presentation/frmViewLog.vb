Public Class frmViewLog

    Private Sub frmViewLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strLog As String = ""
        strLog = strLog + Date.Today.ToString("yyyymmdd") + ":" + Date.Now.ToString("hhmmss")
        strLog = strLog + "VOC:Group1:Topic group11:Successful:No Image" + vbCrLf
        strLog = strLog + Date.Today.ToString("yyyymmdd") + ":" + Date.Now.ToString("hhmmss")
        strLog = strLog + "VOC:Group1:Topic group12:Successful:No Image" + vbCrLf
        strLog = strLog + Date.Today.ToString("yyyymmdd") + ":" + Date.Now.ToString("hhmmss")
        strLog = strLog + "VOC:Group1:Topic group13:Successful:No Image" + vbCrLf
        txtLog.Text = strLog
    End Sub
End Class