Public Class frmMoveAndCopy
    Public Sub New(ByVal dataSourceSameVocabulary As DataGridViewRowCollection, ByVal strTopicGroup As String, _
    ByVal strTopicName As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim frmMove_Copy As New usrMoveAndCopy(dataSourceSameVocabulary, strTopicGroup, strTopicName)
        frmMove_Copy.Dock = DockStyle.Fill
        PanelMoveAndCopy.Controls.Add(frmMove_Copy)

    End Sub
End Class