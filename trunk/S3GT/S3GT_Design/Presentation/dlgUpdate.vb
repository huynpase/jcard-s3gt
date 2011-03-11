Imports System.Windows.Forms

Public Class dlgUpdate

    Public Sub SetTextMessageContent(ByVal strContent As String)
        lblMessageContent.Text = strContent
    End Sub
    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        DialogResult = Constants_LanhVC.INT_PROCESS
        Me.Close()
    End Sub


    Private Sub btnSkip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkip.Click
        DialogResult = Constants_LanhVC.INT_SKIP
        Me.Close()
    End Sub

    Private Sub lblMessageContent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMessageContent.Click

    End Sub
End Class
