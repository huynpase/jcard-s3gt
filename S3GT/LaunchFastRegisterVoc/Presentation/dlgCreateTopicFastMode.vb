Imports System.Windows.Forms

Public Class dlgCreateTopicFastMode
    Dim usrTopic As usrTopicFastMode
    Dim strTopicGroup As String
    Private Sub dlgCreateTopic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If strTopicGroup.Equals(Constants_LanhVC.STR_BLANK_VALUE) Then
            strTopicGroup = Constants_HaoLT.DEFAULT_TOPICGROUP_NAME
        End If
        usrTopic = New usrTopicFastMode(strTopicGroup, True)
        usrTopic.Dock = DockStyle.Fill
        panShowControl.Controls.Add(usrTopic)
    End Sub

    Private Sub panShowControl_ControlRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles panShowControl.ControlRemoved
        Me.Close()
        usrTopic.Dispose()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal pTopicGroup As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strTopicGroup = pTopicGroup
    End Sub
End Class
