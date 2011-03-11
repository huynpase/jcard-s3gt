Imports System.Windows.Forms

Public Class dlgDeleteTopic_Vocabulary
    Dim usrDelTopic_Voc As usrDeleteTopic_Vocabulary
    Private bHasDeletedSuccessfully As Boolean
    Public ReadOnly Property HasDeletedSuccessfully() As Boolean
        Get
            Return bHasDeletedSuccessfully
        End Get
    End Property

    Public Sub New(ByVal id_topicgroup As Integer, ByVal pTopicGroupName As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        usrDelTopic_Voc = New usrDeleteTopic_Vocabulary
        usrDelTopic_Voc.TopicGroupID = id_topicgroup
        usrDelTopic_Voc.TopicGroupName = pTopicGroupName
        usrDelTopic_Voc.Dock = DockStyle.Fill
        Me.Controls.Add(usrDelTopic_Voc)
    End Sub

    Private Sub dlgDeleteTopic_Vocabulary_ControlRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Me.ControlRemoved
        bHasDeletedSuccessfully = usrDelTopic_Voc.HasDeletedSuccessfully
        Me.Close()
    End Sub
End Class
