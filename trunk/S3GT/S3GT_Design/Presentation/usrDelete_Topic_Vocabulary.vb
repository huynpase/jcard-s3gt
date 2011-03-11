Public Class usrDeleteTopic_Vocabulary
    Private id_topicgroup As Integer
    Private Name_topicgroup As String
    Private dgvVocByTopic As New DataGridView
    Private bHasDeletedSuccessfully As Boolean

    Dim blnHasNext, blnHasPrevious As Boolean
    Dim intOrder As Integer

    Public ReadOnly Property HasDeletedSuccessfully() As Boolean
        Get
            Return bHasDeletedSuccessfully
        End Get

    End Property
    Public Property TopicGroupID() As Integer
        Get
            Return id_topicgroup
        End Get
        Set(ByVal value As Integer)
            id_topicgroup = value
        End Set
    End Property
    Public Property TopicGroupName() As String
        Get
            Return Name_topicgroup
        End Get
        Set(ByVal value As String)
            Name_topicgroup = value
        End Set
    End Property

    Dim tableTopicByTopicGroup As New DataTable
    Dim tableVocByTopic As New DataTable
    Dim table_temp3 As New DataTable
    Dim objVocBO As New VocabulariesBO
    Dim objTopicBO As New TopicsBO
    Dim objTopicGroupBO As New TopicGroupsBO
    Dim vocabulary_Entity As New VocabulariesEntity
    Dim topic_Entity As New TopicsEntity
    Dim topic_group_Entity As New TopicGroupsEntity
    Private Sub usrtemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label_Topic_Group.Text = "List Topics of " + Name_topicgroup + " Topic Group"
        tableTopicByTopicGroup = objTopicBO.GetTopicTableByTopicGroup(id_topicgroup) '   GetVocTableByTopic(id_topicgroup)
        dgvTopicOfTopicGroup.DataSource = tableTopicByTopicGroup
        dgvTopicOfTopicGroup.Columns(0).Visible = False
        dgvTopicOfTopicGroup.Columns(1).Visible = False
        dgvTopicOfTopicGroup.Visible = True
    End Sub
    Public Sub Reset()
        Label_Topic_Group.Text = "List Topics of " + Name_topicgroup + " Topic Group"
        tableTopicByTopicGroup = objTopicBO.GetTopicTableByTopicGroup(id_topicgroup)
        dgvTopicOfTopicGroup.DataSource = tableTopicByTopicGroup
        dgvTopicOfTopicGroup.Columns(0).Visible = False
        dgvTopicOfTopicGroup.Columns(1).Visible = False
        dgvTopicOfTopicGroup.Visible = True
    End Sub
    Private Sub Button_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Cancel.Click
        'Dim usrAdd_New_Topic_Group As New usrAdd_New_Topic_Group
        'usrAdd_New_Topic_Group.Reset()
        'usrAdd_New_Topic_Group.Dock = DockStyle.Fill
        'frmMainForm.panContain.Controls.Add(usrAdd_New_Topic_Group)
        'frmMainForm.LoadDataToTree()
        'Me.SendToBack()
        'Me.Refresh()
        'Me.SendToBack()
        'If (example3.flag_delete = True) Then
        'Me.Refresh()
        'frmMainForm.Visible = True
        bHasDeletedSuccessfully = False
        Me.Parent.Controls.Remove(Me)
        Me.Finalize()
        'End If
    End Sub

    Private Sub Button_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_OK.Click
        Try
            If (radioDeleteChild.Checked = True) Then
                'Delete
                tableTopicByTopicGroup = objTopicBO.GetTopicTableByTopicGroup(id_topicgroup)
                dgvTopicOfTopicGroup.DataSource = tableTopicByTopicGroup
                dgvTopicOfTopicGroup.Visible = True
                Dim intTopicsLastIndex As Integer = dgvTopicOfTopicGroup.Rows.Count - 1
                'MessageBox.Show(t)
                Dim intTopicIndex As Integer = 0
                While (intTopicIndex < intTopicsLastIndex)
                    topic_Entity.TopicID = Integer.Parse(dgvTopicOfTopicGroup.Item(0, intTopicIndex).Value.ToString)
                    If (topic_Entity.TopicID > 0) Then
                        topic_Entity = objTopicBO.GetTopicByID(topic_Entity.TopicID)
                        tableVocByTopic = objVocBO.GetVocTableByTopic(topic_Entity.TopicID, blnHasNext, blnHasPrevious, 0)
                        dgvVocByTopic.DataSource = tableVocByTopic
                        dgvVocByTopic.Visible = True
                        Dim intVocLastIndex As Integer = dgvVocByTopic.Rows.Count - 1
                        Dim intVocIndex As Integer = 0
                        While (intVocIndex < intVocLastIndex)
                            vocabulary_Entity.VocID = dgvVocByTopic.Item(0, intVocIndex).Value
                            If (vocabulary_Entity.VocID > 0) Then
                                vocabulary_Entity.Hiragana = dgvVocByTopic.Item(1, intVocIndex).Value.ToString
                                vocabulary_Entity.Kanji = dgvVocByTopic.Item(2, intVocIndex).Value.ToString
                                vocabulary_Entity.Hannom = dgvVocByTopic.Item(3, intVocIndex).Value.ToString
                                vocabulary_Entity.Meaning = dgvVocByTopic.Item(4, intVocIndex).Value.ToString
                                vocabulary_Entity.Type = Byte.Parse(dgvVocByTopic.Item(5, intVocIndex).Value.ToString)
                                objVocBO.DeleteVocabulary(vocabulary_Entity)
                                intVocIndex = intVocIndex + 1
                            Else
                                intVocIndex = intVocLastIndex + 1 'to exit while loop
                            End If
                        End While
                        objTopicBO.DeleteTopicVOC(topic_Entity)
                        intTopicIndex = intTopicIndex + 1
                    Else
                        intTopicIndex = intTopicsLastIndex + 1
                    End If
                End While
                topic_group_Entity = objTopicGroupBO.GetTopicGroupByID(id_topicgroup)
                objTopicGroupBO.DeleteTopicGroup(topic_group_Entity)
                'frmMainForm.LoadDataToTree()
                Reset()
                bHasDeletedSuccessfully = True
                MessageBox.Show("Deleted sucessful", "Message")
            Else 'radioMoveToDefault.Checked = True
                tableTopicByTopicGroup = objTopicBO.GetTopicTableByTopicGroup(id_topicgroup)
                dgvTopicOfTopicGroup.DataSource = tableTopicByTopicGroup
                dgvTopicOfTopicGroup.Visible = True
                Dim intTopicLastIndex As Integer = dgvTopicOfTopicGroup.Rows.Count - 1
                'Move all the topic beloging to this topicgroup to Uncategorized Topics
                Dim intTopicIndex As Integer = 0
                While (intTopicIndex < intTopicLastIndex)
                    topic_Entity.TopicID = Integer.Parse(dgvTopicOfTopicGroup.Item(0, intTopicIndex).Value.ToString)
                    If (topic_Entity.TopicID > 0) Then
                        topic_Entity = objTopicBO.GetTopicByID(topic_Entity.TopicID)
                        'update Topic Group ID of the current topic to Uncategorized Topics topic group ID (ID=1)
                        topic_Entity.TopicGroupID = Constants_HaoLT.DEFAULT_TOPICGROUP_ID
                        objTopicBO.UpdateTopic(topic_Entity)
                        intTopicIndex = intTopicIndex + 1
                    Else
                        intTopicIndex = intTopicLastIndex + 1
                    End If
                End While
                topic_group_Entity = objTopicGroupBO.GetTopicGroupByID(id_topicgroup)
                objTopicGroupBO.DeleteTopicGroup(topic_group_Entity)
                'frmMainForm.LoadDataToTree()
                Reset()
                bHasDeletedSuccessfully = True
                MessageBox.Show("Deleted sucessful", "Message")
            End If
            'example3.flag_delete = True
            'remove this form
        Catch ex As Exception
            bHasDeletedSuccessfully = False
        End Try
        Me.Parent.Controls.Remove(Me)
        Me.Finalize()
    End Sub
End Class
