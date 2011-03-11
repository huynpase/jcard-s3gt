Public Class dlgFastRegisterVoc
    Dim usrFastRegVoc As usrFastRegisterVocabularies
    Dim strVoc As String
    Private Sub dlgFastRegisterVoc_ControlRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Me.ControlRemoved
        Me.Close()
    End Sub

    Private Sub dlgFastRegisterVoc_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        usrFastRegVoc.Dispose()
    End Sub

    Private Sub dlgFastRegisterVoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        usrFastRegVoc = New usrFastRegisterVocabularies(strVoc)
        usrFastRegVoc.Dock = DockStyle.Fill
        Me.Controls.Add(usrFastRegVoc)
    End Sub

    Public Sub New(ByVal pStrVoc As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strVoc = pStrVoc
    End Sub
End Class